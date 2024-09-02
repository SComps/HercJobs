Imports System.IO
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms.VisualStyles

Public Class CardReader
    'Hercules 3505 card reader connection
    Dim myName As String = "Card Reader"
    Dim myHost As String = ""
    Dim myPort As Integer = 3505
    Dim sendOk As Boolean = False

    Public myClient As TcpClient
    Public Property FriendlyName As String
        Get
            Return myName
        End Get
        Set(value As String)
            myName = value
        End Set
    End Property

    Public Property Host As String
        Get
            Return myHost
        End Get
        Set(value As String)
            myHost = value
        End Set
    End Property

    Public Property Port As Integer
        Get
            Return myPort
        End Get
        Set(value As Integer)
            myPort = value
        End Set
    End Property

    Public Sub New()
        myName = "Undefined reader"
        myHost = "localhost"
        myPort = 3505
    End Sub
    Public Sub New(friendly As String, host As String, port As Integer)
        myName = friendly
        myHost = host
        myPort = port
    End Sub

    Public Function SendJob(filename As String) As Boolean
        ' Trying this method of sending the job as a separate thread.
        sendOk = False
        Debug.Print("Starting send job thread.")
        Dim newThread As New Thread(AddressOf SendJob2)
        newThread.Start(filename)
        Debug.Print("Thread stopped.")
        Return sendOk
    End Function

    Public Sub SendJob2(fileName As String)
        ' Sends deck to this object's port.
        ' If it succeeds sending (not to be confused with executed on the guest) return True
        ' otherwise return false in sendOk
        Dim thisDeck As New StreamReader(fileName)
        Dim deck As New List(Of String)
        Dim thisLine As String = ""
        While Not thisDeck.EndOfStream
            thisLine = thisDeck.ReadLine
            deck.Add(thisLine)
        End While
        thisDeck.Close()
        Dim jobStream As NetworkStream = Connect(myHost, myPort)
        If jobStream Is Nothing Then
            sendOk = False
            Exit Sub
        End If

        For Each l As String In deck
            l = l & vbCrLf
            Dim lineBytes As Byte() = Encoding.ASCII.GetBytes(l)
            Try
                jobStream.Write(lineBytes)
            Catch ex As Exception
                jobStream.Close()
                sendOk = False
                Exit Sub
            End Try
        Next

        If myClient.GetStream() IsNot Nothing Then
            myClient.GetStream().Close()
        End If
        myClient.Close()
        sendOk = True
    End Sub

    Private Function Connect(host As String, port As Integer) As NetworkStream
        ' Connect to the remote port, and return the network stream if successful
        Try
            MyClient = New TcpClient(host, port)
            Dim IStream As NetworkStream = MyClient.GetStream
            Return IStream
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class
