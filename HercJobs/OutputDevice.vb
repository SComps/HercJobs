Imports System.Drawing.Imaging
Imports System.Net.Sockets
Imports System.Text

Public Class OutputDevice

    Dim myName As String = ""
    Dim myHost As String = ""
    Dim myPort As Integer = 0
    Dim myPoll As Boolean = False
    Dim myIs1403 As Boolean = True
    Dim myIs3525 As Boolean = False
    Dim myAutoPrint As Boolean = False
    Dim myClient As New TcpClient()
    Private WithEvents myTimer As New Timer

    Event JobReceived(sender As Object, outList As List(Of String))

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

    Public Sub Connect()
        If (myHost.Trim = "") Or (myPort = 0) Then
            Exit Sub
        End If
        Try
            myClient.Connect(myHost, myPort)
            myTimer.Interval = 1000
            myTimer.Enabled = True
        Catch ex As Exception
            Stop
        End Try
    End Sub
    Private Function CheckDevice() As Boolean
        ' If this is not a polling device, attempt to make the connection.
        ' BE AWARE: Once this is done, any jobs waiting on the output device
        ' *WILL* be fired at us whether we want them to be or not.  I'll figure
        ' out what to do about that eventually.  Probably just handle them as regular
        ' output jobs.
        Dim retval As Boolean = False     ' Default response is going to be a failure.


        ' Make the connection, accept any output if there's something waiting.
        Try
            myClient.Connect(myHost, myPort)
        Catch ex As Exception
            ' It didn't connect, let it go ahead and return false
        End Try
        If myClient.Connected() Then
            retval = True
            ' This is very rude.  Hercules might be talking to us, so in the future
            ' check for incoming data and handle it as necessary.  We all know there
            ' could be a gazillion jobs that JES2 has been waiting to rid itself of.

            myClient.Close()
        End If
        Return retval
    End Function

    Private Function GetOutput() As List(Of String)
        Dim thisOutput As New List(Of String)
        Dim myStream As NetworkStream = Nothing
        If myClient.Connected Then
            myStream = myClient.GetStream()
            Do
                Dim newLine As String = ReadLine(myStream)
                If (newLine Is Nothing) Then
                    Exit Do
                End If
                thisOutput.Add(newLine)
            Loop
        End If
        Return thisOutput
    End Function

    Private Function ReadLine(thisStream As NetworkStream) As String
        'Reads one line from the network stream.  What's the point of taking
        'ReadLine out of the Network Stream?  Somebody at Microsoft thought
        'that was a good idea.  Probably the same guy that came up with CoPilot.
        'because nobody ever reads whole lines of text from a network stream.  
        Dim MyString As String = ""
        If thisStream.DataAvailable Then
            While thisStream.DataAvailable
                Dim thisByte(1) As Byte
                thisStream.Read(thisByte, 0, 1)
                Dim thisChar As String = Encoding.ASCII.GetString(thisByte, 0, 1)
                MyString = MyString & thisChar
                If thisChar = vbLf Then
                    Return MyString
                End If
            End While
        Else
            Return Nothing
        End If
        Return MyString
    End Function
    Private Sub Timer_Fire() Handles myTimer.Tick
        ' Once connected to the remote host, this time is enabled and checked based on interval.
        ' If a job exists, it reads it into the object, and raises the JobReceived Event.  
        ' then it re-enables the Timer for the next pass.  The interval can be extended
        ' if the checks happen to rapidly.
        myTimer.Enabled = False
        Dim myJob As List(Of String) = GetOutput()
        If myJob.Count > 0 Then
            ' A job has been printed.  It might be ours, it might not.
            RaiseEvent JobReceived(Me, myJob)
        End If
        myTimer.Enabled = True
    End Sub
End Class
