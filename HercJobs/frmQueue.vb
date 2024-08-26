Public Class frmQueue

    Dim DeckQueue As New List(Of QueueEntry)
    Dim IQueue As IEnumerable(Of QueueEntry)    ' Used for the grid

    Private Sub frmQueue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DeckQueue.Clear()
        ' Get whatever is currently in the Decklist
        For Each f As String In Form1.DeckList.Items
            Dim qe As New QueueEntry
            qe.Index = DeckQueue.Count
            qe.filename = f
            Debug.Print("Adding " & qe.filename)
            DeckQueue.Add(qe)
        Next
        IQueue = (From q As QueueEntry In DeckQueue Order By q.Index Select q)
        BindingSource1.DataSource = IQueue
        QGrid.DataSource = BindingSource1
        'Stop
        If Form1.AllReaderStop = False Then
            PauseReader()
        End If
    End Sub

    Private Sub PauseReader()
        Dim msg As String = "Your selected reader is currently enabled." & vbCrLf & vbCrLf &
            "Once you submit a Reader queue, these jobs will" & vbCrLf &
            "begin running.  Do you want to pause your readers" & vbCrLf &
            "to give yourself a chance to verify your selections?"
        Dim msgStyle As MsgBoxStyle = MsgBoxStyle.YesNoCancel Or MsgBoxStyle.Question
        Dim result As New DialogResult
        result = MsgBox(msg, msgStyle, "Preparation")
        If result = DialogResult.Yes Then
            Form1.AllReaderStop = True
            Form1.RunStop.PerformClick()
        End If
        If result = DialogResult.Cancel Then
            Me.Close()
        End If
    End Sub

    Private Sub SelectFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectFilesToolStripMenuItem.Click
        dlgFile.Filter = Form1.dlgLoadDeck.Filter
        dlgFile.DefaultExt = Form1.dlgLoadDeck.DefaultExt
        dlgFile.InitialDirectory = Form1.dlgLoadDeck.InitialDirectory
        dlgFile.Multiselect = True
        Dim result As DialogResult = dlgFile.ShowDialog
        If result = DialogResult.Cancel Then
            'User wanted out
            Exit Sub
        Else
            'User has clicked Okay.
            For Each f As String In dlgFile.FileNames
                Dim qe As New QueueEntry
                qe.Index = DeckQueue.Count + 1
                qe.filename = f
                DeckQueue.Add(qe)
            Next
            IQueue = (From q As QueueEntry In DeckQueue Order By q.Index Select q)
            BindingSource1.DataSource = IQueue

        End If
    End Sub

    Private Sub pupMenu_Opened(sender As Object, e As EventArgs) Handles pupMenu.Opened
        mnuUp.Enabled = False
        mnuDown.Enabled = False
        If QGrid.Rows.Count = 1 Then
            'We can't move anything
            Exit Sub
        End If
        If QGrid.CurrentRow.Index > 0 Then
            mnuUp.Enabled = True
        End If
        If QGrid.CurrentRow.Index < (QGrid.Rows.Count - 1) Then
            mnuDown.Enabled = True
        End If
    End Sub

    Private Sub mnuDown_Click(sender As Object, e As EventArgs) Handles mnuDown.Click
        Dim thisRow = QGrid.CurrentRow.Index
        Dim OriginCell As String = QGrid.Rows(thisRow).Cells(0).Value
        Dim DestCell As String = QGrid.Rows(thisRow + 1).Cells(0).Value
        Dim OriginFile As String = QGrid.Rows(thisRow).Cells(1).Value
        Dim DestFile As String = QGrid.Rows(thisRow + 1).Cells(1).Value
        'Just swap the filenames here.  We're only changing the order.
        QGrid.Rows(thisRow + 1).Cells(1).Value = OriginFile
        QGrid.Rows(thisRow).Cells(1).Value = DestFile
    End Sub

    Private Sub mnuUp_Click(sender As Object, e As EventArgs) Handles mnuUp.Click
        Dim thisRow = QGrid.CurrentRow.Index
        Dim OriginCell As String = QGrid.Rows(thisRow).Cells(0).Value
        Dim DestCell As String = QGrid.Rows(thisRow - 1).Cells(0).Value
        Dim OriginFile As String = QGrid.Rows(thisRow).Cells(1).Value
        Dim DestFile As String = QGrid.Rows(thisRow - 1).Cells(1).Value
        'Just swap the filenames here.  We're only changing the order.
        QGrid.Rows(thisRow - 1).Cells(1).Value = OriginFile
        QGrid.Rows(thisRow).Cells(1).Value = DestFile
    End Sub


    Private Sub ClearListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearListToolStripMenuItem.Click
        DeckQueue.Clear()
        IQueue = (From q As QueueEntry In DeckQueue Order By q.Index Select q)
        If IQueue Is Nothing Then
            QGrid.Rows.Clear()
        End If
        BindingSource1.DataSource = IQueue
    End Sub

    Private Sub btnQueue_Click(sender As Object, e As EventArgs) Handles btnQueue.Click
        ' Send the current DeckQueue into the main form's Decklist
        For Each q As QueueEntry In IQueue
            Form1.DeckList.Items.Add(q.Filename)
        Next
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class

