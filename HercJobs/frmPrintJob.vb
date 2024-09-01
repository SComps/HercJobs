Public Class frmPrintJob
    Dim myJob As List(Of String)

    WriteOnly Property OutList As List(Of String)
        Set(value As List(Of String))
            myJob = value
        End Set
    End Property
    Private Sub frmPrintJob_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each s As String In myJob
            outData.AppendText(s)
        Next
    End Sub
End Class