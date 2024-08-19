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
        Dim newReader As New CardReader("MVS TK5 Reader", "s370", 3505)
        Readers.Add(newReader)
        UpdateReaderList()
        DeckColor = DeckList.BackColor
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
        Else
            AllReaderStop = False
            DeckList.BackColor = DeckColor
            RunStop.Text = "Pause"
        End If
    End Sub

    Private Sub CheckQueue()
        Dim jobsWaiting As Integer = DeckList.Items.Count
        If jobsWaiting = 0 Then
            Exit Sub
        Else
            Dim jobFile As String = DeckList.Items(0)
            RunningReader.SendJob(jobFile)
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
End Class
