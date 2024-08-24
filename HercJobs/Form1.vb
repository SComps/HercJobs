Imports System.Diagnostics.Metrics
Imports System.Xml.Serialization

Public Class Form1

    Public Shared Readers As New List(Of CardReader)
    Private RunningReader As CardReader
    Private AllReaderStop As Boolean = False
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
        ' Set up an initial card reader for testing.
        'Dim newReader As New CardReader("MVS TK5 Reader", "localhost", 3505)
        'Readers.Add(newReader)
        If IO.File.Exists("readers.xml") Then
            'There's already a saved list of readers
            Readers = LoadReaders()
        End If
        UpdateReaderList()
        DeckColor = DeckList.BackColor

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
        LogBox.AppendText(Now.ToShortDateString & " " & txt & vbCrLf)
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
        Using file As System.IO.FileStream = System.IO.File.Open("readers.xml", IO.FileMode.OpenOrCreate, IO.FileAccess.Write)
            serializer.Serialize(file, currentConf)
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
End Class
