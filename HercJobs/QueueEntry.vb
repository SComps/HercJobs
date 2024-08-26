Public Class QueueEntry
    Dim myIndex As Integer = 0
    Dim myFilename As String = ""

    Public Property Index As Integer
        Get
            Return myIndex
        End Get
        Set(value As Integer)
            myIndex = value
        End Set
    End Property
    Public Property Filename As String
        Get
            Return myFilename
        End Get
        Set(value As String)
            myFilename = value
        End Set
    End Property
End Class
