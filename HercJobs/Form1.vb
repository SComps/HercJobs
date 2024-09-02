Imports System.Diagnostics.Metrics
Imports System.Reflection.Metadata
Imports System.Windows.Forms.Design
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization
Imports PdfSharp.Diagnostics
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf


Public Class Form1

    Public Shared Readers As New List(Of CardReader)
    Private RunningReader As CardReader
    Friend WithEvents Outputs As New List(Of OutputDevice)
    Public AllReaderStop As Boolean = False
    Private DeckColor As Color

    Private Sub CardReadersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CardReadersToolStripMenuItem.Click
        ' Open the card reader configuration form
        Dim ReaderForm As New frmReader
        Dim result As DialogResult = ReaderForm.ShowDialog()
        If result = DialogResult.OK Then
            SaveReaders()
        End If
        UpdateReaderList()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        AppendLog("Log starting")
        'Check if there's readers defined.  If so, load them.
        If System.IO.File.Exists("readers.xml") Then
            'There's already a saved list of readers
            Readers = LoadReaders()
        End If
        UpdateReaderList()
        DeckColor = DeckList.BackColor
        'Check for any outputs are defined.  If so, load them.
        If System.IO.File.Exists("outputs.xml") Then
            Outputs = LoadOutputs()
        End If
        'Dim newDev As New OutputDevice
        'newDev.Host = "s370"
        'newDev.Port = 1405
        'newDev.Is3525 = False
        'newDev.Is1403 = True
        'newDev.AutoPrint = False
        'newDev.FriendlyName = "S370 PRINTER 4"
        'newDev.PollFiles = False
        'Outputs.Add(newDev)
        'newDev = Nothing
        'Dim myDev As OutputDevice = Outputs.Item(0)
        'myDev.Connect()
        'AppendLog("Connected to " & myDev.FriendlyName)
        'AddHandler myDev.JobReceived, AddressOf GotOutput
    End Sub

    Private Sub UpdateReaderList()
        SelectedReader.Items.Clear()
        For Each r As CardReader In Readers
            SelectedReader.Items.Add(r.FriendlyName)
        Next
        If Readers.Count > 0 Then
            SelectedReader.SelectedIndex = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = dlgLoadDeck.ShowDialog()
        If result = DialogResult.OK Then
            DeckList.Items.Add(dlgLoadDeck.FileName)
            CheckQueue()
        End If
    End Sub

    Private Sub RunStop_Click(sender As Object, e As EventArgs) Handles RunStop.Click
        If RunStop.Text = "Pause" Then
            AllReaderStop = True
            DeckList.BackColor = Color.Yellow
            RunStop.Text = "Start"
            AppendLog("Stopping readers.")
        Else
            AllReaderStop = False
            DeckList.BackColor = DeckColor
            RunStop.Text = "Pause"
            AppendLog("Starting readers.")
            ' Check the queue in case something was added while we were stopped.
            CheckQueue()
        End If
    End Sub

    Private Sub CheckQueue()
        If AllReaderStop Then Exit Sub                    ' Readers are stopped.
        Dim jobsWaiting As Integer = DeckList.Items.Count
        If jobsWaiting = 0 Then
            Exit Sub
        Else
            Dim jobFile As String = DeckList.Items(0)
            AppendLog("Sending " & jobFile)
            RunningReader.SendJob(jobFile)
            'Wait 2 seconds
            AppendLog("Waiting 2 seconds for reader to settle.")
            Dim StartTime As DateTime = Now()
            Do Until Now() >= StartTime.AddSeconds(2)
                Application.DoEvents()
            Loop
            AppendLog("Success.")
            DeckList.Items.RemoveAt(0)
            CheckQueue()
        End If
    End Sub

    Private Sub SelectedReader_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectedReader.SelectedIndexChanged
        For Each r As CardReader In Readers
            If r.FriendlyName = SelectedReader.SelectedItem Then
                RunningReader = r
                Me.Text = "Hercules Jobs (" & RunningReader.FriendlyName & ")"
            End If
        Next
    End Sub

    Private Sub DeckList_DragDrop(sender As Object, e As DragEventArgs) Handles DeckList.DragDrop
        ' Get the array of files being dropped
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())

        ' Add each file name to the ListBox
        For Each file As String In files
            DeckList.Items.Add(file)
        Next
        CheckQueue()
    End Sub

    Private Sub DeckList_DragEnter(sender As Object, e As DragEventArgs) Handles DeckList.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            ' If so, change the effect to Copy
            e.Effect = DragDropEffects.Copy
        Else
            ' Otherwise, do not allow the drop
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub AppendLog(txt As String)
        Dim txtfmt As String = "** {0}" & vbCrLf
        LogBox.AppendText(String.Format(txtfmt, txt))
        LogBox.ScrollToCaret()
    End Sub

    Private Sub SaveReaders()
        Dim currentConf As New List(Of ReaderConfig)
        For Each r In Readers
            Dim thisRC As New ReaderConfig
            thisRC.Name = r.FriendlyName
            thisRC.Host = r.Host
            thisRC.Port = r.Port
            currentConf.Add(thisRC)
        Next
        Dim serializer As New XmlSerializer(GetType(List(Of ReaderConfig)), New XmlRootAttribute("CardReaders"))
        Using file As System.IO.FileStream = System.IO.File.Open("readers.xml", System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write)
            serializer.Serialize(file, currentConf)
        End Using
    End Sub

    Private Sub SaveOutputs()
        Dim currentOuts As New List(Of OutputConfig)
        For Each o As OutputDevice In Outputs
            Dim thisOC As New OutputConfig
            thisOC.FriendlyName = o.FriendlyName
            thisOC.Host = o.Host
            thisOC.Port = o.Port
            thisOC.Is1403 = o.Is1403
            thisOC.Is3525 = o.Is3525
            thisOC.PollFiles = o.PollFiles
            thisOC.AutoPrint = o.AutoPrint
            currentOuts.Add(thisOC)
        Next
        Dim serializer As New XmlSerializer(GetType(List(Of OutputConfig)), New XmlRootAttribute("OutputDevs"))
        Using file As System.IO.FileStream = System.IO.File.Open("outputs.xml", System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write)
            serializer.Serialize(file, currentOuts)
        End Using
    End Sub

    Private Function LoadReaders() As List(Of CardReader)
        Dim serializer As New XmlSerializer(GetType(List(Of ReaderConfig)), New XmlRootAttribute("CardReaders"))
        Dim deserialized As List(Of ReaderConfig) = Nothing
        Using file = System.IO.File.OpenRead("readers.xml")
            deserialized = DirectCast(serializer.Deserialize(file), List(Of ReaderConfig))
        End Using
        Dim NewReaders As New List(Of CardReader)
        For Each c As ReaderConfig In deserialized
            Dim thisCR As New CardReader
            thisCR.FriendlyName = c.Name
            thisCR.Host = c.Host
            thisCR.Port = c.Port
            NewReaders.Add(thisCR)
        Next
        Return NewReaders
    End Function

    Private Function LoadOutputs() As List(Of OutputDevice)
        Dim serializer As New XmlSerializer(GetType(List(Of OutputDevice)), New XmlRootAttribute("OutputDevs"))
        Dim deserialized As List(Of OutputDevice) = Nothing
        Using file = System.IO.File.OpenRead("outputs.xml")
            deserialized = DirectCast(serializer.Deserialize(file), List(Of OutputDevice))
        End Using
        Dim newOutputs As New List(Of OutputDevice)
        For Each o As OutputDevice In deserialized
            Dim thisOD As New OutputDevice
            thisOD.FriendlyName = o.FriendlyName
            thisOD.Host = o.Host
            thisOD.Port = o.Port
            thisOD.Is1403 = o.Is1403
            thisOD.Is3525 = o.Is3525
            thisOD.PollFiles = o.PollFiles
            thisOD.AutoPrint = o.AutoPrint
            newOutputs.Add(thisOD)
        Next
        Return newOutputs
    End Function

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim response As New DialogResult
        response = MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "End program")
        If response = DialogResult.Yes Then
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub PrintersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintersToolStripMenuItem.Click
        Dim prtConfig As New frmPrinter
        Dim result As New DialogResult
        result = prtConfig.ShowDialog
    End Sub

    Private Sub btnQueue_Click(sender As Object, e As EventArgs) Handles btnQueue.Click
        Dim viewQueue As New frmQueue
        Dim result As New DialogResult
        result = viewQueue.ShowDialog
    End Sub

    Public Sub GotOutput(sender As OutputDevice, outList As List(Of String))
        Dim txtFmt As String = "Received {0} lines of output for {1}"
        Dim outputGUID As String = NewGUID()
        AppendLog(String.Format(txtFmt, outList.Count, sender.FriendlyName))
        Dim po As New frmPrintJob
        po.Text = po.Text & " (" & outputGUID & ")"
        po.OutList = outList
        outList = Paginate(outList) 'Paginate if for PDF output
        po.Show()
        Dim outputFile As String = CreatePDF(sender.FriendlyName, outList, outputGUID)
        AppendLog("Saved output to " & outputfile)
    End Sub

    Public Function CreatePDF(title As String, outList As List(Of String), fileguid As String) As String
        Dim JobNumber As String = ""
        Dim JobName As String = ""
        Dim doc As New PdfDocument
        doc.Info.Title = title
        Dim page As PdfPage = doc.AddPage()
        page.Orientation = PdfSharp.PageOrientation.Landscape
        ' Get an XGraphics object for drawing
        Dim gfx As XGraphics = XGraphics.FromPdfPage(page)

        ' Create a font
        Dim font As XFont = New XFont("Lucida Console", 8, XFontStyleEx.Regular)

        ' Set initial coordinates for text
        Dim x As Double = 10
        Dim y As Double = 0
        Dim newHeight As Double = page.Height.Point / 67
        Dim lineHeight As Double = newHeight
        ' Calculate the maximum number of lines that can fit on a page
        Dim maxLinesPerPage As Integer = CInt((page.Height.Point - y) / lineHeight)

        ' Loop through the list of strings and draw each on a new line
        Dim currentLine As Integer = 0

        For Each line As String In outList
            ' TODO:I'm using a class E printer, will need to get a bit more intelligent with this.
            If line.Trim.StartsWith("****E   END") Then
                Dim largs As String() = line.Split(" ")

                JobNumber = largs(9)
                JobName = largs(11)
            End If
            If line = "" Then line = " "
            If (line(0) = vbFormFeed) Then
                ' Add a new page
                page = doc.AddPage()
                page.Orientation = PdfSharp.PageOrientation.Landscape
                gfx = XGraphics.FromPdfPage(page)
                y = 0 ' Reset the y-coordinate
                currentLine = 0
                ' Don't do the 5 lines for a FF because paginate already does this.
            End If
            ' If the current line exceeds maxLinesPerPage, create a new page
            If currentLine > 0 AndAlso currentLine Mod maxLinesPerPage = 0 Then
                ' Add a new page
                page = doc.AddPage()
                page.Orientation = PdfSharp.PageOrientation.Landscape
                gfx = XGraphics.FromPdfPage(page)
                y = 0 ' Reset the y-coordinate
                currentLine = 0
                For i = 1 To 5
                    gfx.DrawString(" ", font, XBrushes.Black, New XRect(x, y, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
                    y += lineHeight ' Move to the next line
                    currentLine += 1
                Next
            End If

            ' Draw the current line
            gfx.DrawString(line, font, XBrushes.Black, New XRect(x, y, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
            y += lineHeight ' Move to the next line
            currentLine += 1
        Next
        Dim outputFile As String = fileguid & ".pdf"
        If JobName <> "" And JobNumber <> "" Then
            outputFile = String.Format("JOB-{0}-{1}.pdf", JobNumber, JobName)
        End If
        doc.Save(outputFile)
        doc.Close()
        Return outputFile
    End Function

    Public Function NewGUID() As String
        Dim oGuid As String = ""
        oGuid = Guid.NewGuid().ToString
        Return oGuid
    End Function

    Private Function Paginate(inp As List(Of String)) As List(Of String)
        'What we're looking for here is vbFormFeed.  When we see this, we start a new line
        'put the vbFormFeed on it's own line (without vbLF or vbCR)
        'To do this, we have to examine each line character by character because occassionally
        'the vbFormFeed is preceeded by a vbCR (for some reason)... ask JES2?
        '---
        'Remove the final FF if it exists
        If inp.Last = vbFormFeed Then
            inp(inp.Count - 1) = ""
            'The PDF handler handles the final page out
        End If
        Dim newList As New List(Of String)
        ' Add 5 lines at the top of the job, see below about starting on line 6 for JES2
        newList.Add(" ")
        newList.Add(" ")
        newList.Add(" ")
        newList.Add(" ")
        newList.Add(" ")
        For Each l As String In inp
            ' Try to pull the job name and number out of the document

            Dim thisLine As String = ""
            For Each c As Char In l
                ' Eat any Line feeds or Carriage Returns. List of String doesn't need them.
                If (c = vbCr) Then c = Chr(0)
                If c = vbFormFeed Then
                    newList.Add(thisLine)
                    newList.Add(vbFormFeed)
                    ' Add 5 lines at the top of the page because JES2 likes to do that naturally
                    newList.Add(" ")
                    newList.Add(" ")
                    newList.Add(" ")
                    newList.Add(" ")
                    newList.Add(" ") ' Sure I could have done this in a loop, but it would have been close to 5 lines anyway.
                    thisLine = ""
                Else
                    thisLine = thisLine & c
                End If
            Next
            If thisLine <> "" Then
                newList.Add(thisLine)
            End If
        Next
        Return newList
    End Function
End Class
