Public Class frmPrinter
    Private Sub frmPrinter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadOutputList()
    End Sub

    Private Sub ReloadOutputList()
        OutputList.Items.Clear()
        ' put the 'add' item in first
        OutputList.Items.Add("<add new output device>")
        ' Now add any addition devices.

    End Sub
End Class