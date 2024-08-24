Public Class OutputDevice

    Dim myName As String = ""
    Dim myHost As String = ""
    Dim myPort As Integer = ""
    Dim myPoll As Boolean = False
    Dim myIs1403 As Boolean = True
    Dim myIs3525 As Boolean = False
    Dim myAutoPrint As Boolean = False

    ' Even though we don't set up a Name, host or port, The default is going to be a printer via sockdev
    ' which is likely to be the most common.

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

    Private Function CheckPath(path As String) As Boolean
        If Not myPoll Then
            Return True         ' This device does NOT poll a directory.
            ' So return True as though the directory exists.
        End If
        Dim IsDirectory As Boolean = IO.Directory.Exists(path)
        Return IsDirectory
    End Function

    Private Function CheckDevice() As Boolean
        ' If this is not a polling device, attempt to make the connection.
        ' BE AWARE: Once this is done, any jobs waiting on the output device
        ' *WILL* be fired at us whether we want them to be or not.  I'll figure
        ' out what to do about that eventually.  Probably just handle them as regular
        ' output jobs.
        Dim retval As Boolean = False     ' Default response is going to be a failure.


        ' Make the connection, accept any output if there's something waiting.


        Return retval
    End Function

End Class
