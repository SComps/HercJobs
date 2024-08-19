Public Class frmReader

    Dim EditReader As CardReader = Nothing
    Dim CurrentFriendlyName As String = "" 'Holds the original FriendlyName in case the user changes it
    'and we need to know which object to change

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        ' Save current changes
        If EditReader Is Nothing Then
            'Move along, nothing to see here
            Exit Sub
        End If
        If CurrentFriendlyName = "adding" Then
            'Move the textbox contents into EditReader
            EditReader.FriendlyName = txtFriendly.Text
            EditReader.Host = txtHost.Text
            EditReader.Port = txtPort.Text
            Form1.Readers.Add(EditReader)
            lstReaders_Rebuild()
            EditReader = Nothing
            CurrentFriendlyName = ""
            Exit Sub
        End If
        'Move the textbox contents into EditReader
        EditReader.FriendlyName = txtFriendly.Text
        EditReader.Host = txtHost.Text
        EditReader.Port = txtPort.Text
        'EditReader points directly at the existing Reader in the list
        'so it's automagically updated.
        lstReaders_Rebuild()
        EditReader = Nothing
        CurrentFriendlyName = ""
    End Sub

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        ' Remove the selected item from the collection

    End Sub

    Private Sub frmReader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each r As CardReader In Form1.Readers
            lstReaders.Items.Add(r.FriendlyName)
        Next
    End Sub

    Private Sub lstReaders_Rebuild()
        lstReaders.Items.Clear()
        lstReaders.Items.Add("<add new reader>")
        For Each r As CardReader In Form1.Readers
            lstReaders.Items.Add(r.FriendlyName)
        Next
        txtFriendly.Text = ""
        txtHost.Text = ""
        txtPort.Text = ""
    End Sub
    Private Sub lstReaders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstReaders.SelectedIndexChanged
        If EditReader IsNot Nothing Then
            Dim dirty As Boolean = False
            If txtFriendly.Text <> EditReader.FriendlyName Then dirty = True
            If txtHost.Text <> EditReader.Host Then dirty = True
            If Val(txtPort.Text) <> EditReader.Port Then dirty = True
            If dirty = True Then
                Dim result As DialogResult =
                MsgBox("You have unsaved data. Do you want to discard these changes?",
                       MsgBoxStyle.Question Or MsgBoxStyle.YesNo,
                       "Unsaved changes")
                If result = DialogResult.Yes Then
                    EditReader = Nothing
                Else
                    Exit Sub
                End If
            End If
        End If
        Dim findReader As String = lstReaders.SelectedItem
        If findReader = "<add new reader>" Then
            EditReader = New CardReader
            CurrentFriendlyName = "adding"
        Else
            For Each r As CardReader In Form1.Readers
                If r.FriendlyName = findReader Then
                    EditReader = r
                    CurrentFriendlyName = EditReader.FriendlyName
                End If
            Next
        End If
        If EditReader Is Nothing Then
            Throw New Exception("Unable to create a new card reader.")
            Exit Sub
        End If
        txtFriendly.Text = EditReader.FriendlyName
        txtHost.Text = EditReader.Host
        txtPort.Text = EditReader.Port
        txtFriendly.Focus()
    End Sub
End Class