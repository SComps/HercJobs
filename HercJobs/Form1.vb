Public Class Form1

    Public Shared Readers As New List(Of CardReader)
    Private RunningReader As CardReader
    Private AllReaderStop As Boolean = False
    Private DeckColor As Color

    Private Sub CardReadersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CardReadersToolStripMenuItem.Click
        ' Open the card reader configuration form
        Dim ReaderForm As New frmReader
        Dim result As DialogResult = ReaderForm.ShowDialog()
        UpdateReaderList()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Set up an initial card reader for testing.
        Dim newReader As New CardReader("MVS TK5 Reader", "localhost", 3505)
        Readers.Add(newReader)
        UpdateReaderList()
        DeckColor = DeckList.BackColor
        AppendLog("Log starting")
    End Sub

    Private Sub UpdateReaderList()
        SelectedReader.Items.Clear()
        For Each r As CardReader In Readers
            SelectedReader.Items.Add(r.FriendlyName)
        Next
        SelectedReader.SelectedIndex = 0
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
        End If
    End Sub

    Private Sub CheckQueue()
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
End Class
