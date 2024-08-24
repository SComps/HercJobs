Public Class ReaderConfig

    '* This class is for the serialization of Readers

    Dim myName As String
    Dim myHost As String
    Dim myPort As Integer

    Property Name As String
        Get
            Return myName
        End Get
        Set(value As String)
            myName = value
        End Set
    End Property
    Property Host As String
        Get
            Return myHost
        End Get
        Set(value As String)
            myHost = value
        End Set
    End Property
    Property Port As Integer
        Get
            Return myPort
        End Get
        Set(value As Integer)
            myPort = value
        End Set
    End Property
End Class
