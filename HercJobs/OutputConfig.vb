Imports System.Net.Sockets

Public Class OutputConfig
    ' This class has no methods or events.  It simply defines a structure for XML serialization
    Dim myName As String = ""
    Dim myHost As String = ""
    Dim myPort As Integer = 0
    Dim myPoll As Boolean = False
    Dim myIs1403 As Boolean = True
    Dim myIs3525 As Boolean = False
    Dim myAutoPrint As Boolean = False

    Property FriendlyName As String
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
    Property PollFiles As Boolean
        Get
            Return myPoll
        End Get
        Set(value As Boolean)
            myPoll = value
        End Set
    End Property
    Property Is1403 As Boolean
        Get
            Return myIs1403
        End Get
        Set(value As Boolean)
            myIs1403 = value
        End Set
    End Property
    Property Is3525 As Boolean
        Get
            Return myIs3525
        End Get
        Set(value As Boolean)
            myIs3525 = value
        End Set
    End Property

    Property AutoPrint As Boolean
        Get
            Return myAutoPrint
        End Get
        Set(value As Boolean)
            myAutoPrint = value
        End Set
    End Property
End Class
