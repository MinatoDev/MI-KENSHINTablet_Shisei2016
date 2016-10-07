Option Explicit On

Imports System
Imports System.IO.Ports
Imports System.IO
Imports System.ComponentModel
Imports System.Text

Public Class Serial
    Public sp As SerialPort
    Public portName As String
    Public errmsg As String = ""
    Public BaudRate As Integer
    Public Parity As IO.Ports.Parity
    Public DataBits As Integer
    Public StopBits As IO.Ports.StopBits
    Public FlowControl As String

    Public Sub New()
        sp = New SerialPort
        sp.Close()
        portName = ""
        errmsg = ""
        portName = My.Settings.Port
        BaudRate = My.Settings.Speed
        Select Case My.Settings.Parity
            Case "0"
                Parity = IO.Ports.Parity.Space  '0
            Case "1"
                Parity = IO.Ports.Parity.Mark   '1
            Case "奇数"
                Parity = IO.Ports.Parity.Odd    '奇数 
            Case "偶数"
                Parity = IO.Ports.Parity.Even   '偶数
            Case "なし"
                Parity = IO.Ports.Parity.None   'なし
        End Select
        DataBits = My.Settings.DataBit
        StopBits = My.Settings.StopBit

        Select Case My.Settings.FlowControl
            Case 0
                FlowControl = IO.Ports.Handshake.None                       'なし
            Case 1
                FlowControl = IO.Ports.Handshake.XOnXOff                    'XOnXOff
            Case 2
                FlowControl = IO.Ports.Handshake.RequestToSend              'RTS/CTS
            Case 3
                FlowControl = IO.Ports.Handshake.RequestToSendXOnXOff       'XON/XOFF+RTS/CTS
        End Select
    End Sub

    Private Sub initPort()

    End Sub


    Public Function open() As Boolean
        Try


            errmsg = ""

            GoTo 100
            ' シリアルポートのオープン
            sp.PortName = portName

            ' シリアルポートの通信速度指定
            sp.BaudRate = BaudRate

            ' シリアルポートのパリティ指定
            'sp.Parity = IO.Ports.Parity.None
            sp.Parity = Parity
            ' シリアルポートのビット数指定

            sp.DataBits = DataBits
            ' シリアルポートのストップビット指定
            'sp.StopBits = IO.Ports.StopBits.One
            sp.StopBits = StopBits

            '文字コードをセットする.
            sp.Encoding = Encoding.ASCII

            sp.Handshake = FlowControl

            sp.ReceivedBytesThreshold = 1

            ' シリアルポートのオープン
            sp.Open()

100:

            'オープンするシリアルポートをコンボボックスから取り出す.
            sp.PortName = portName

            'ボーレートをコンボボックスから取り出す.
            sp.BaudRate = BaudRate

            'データビットをセットする. (データビット = 8ビット)
            sp.DataBits = DataBits

            'パリティビットをセットする. (パリティビット = なし)
            sp.Parity = Parity

            'ストップビットをセットする. (ストップビット = 1ビット)
            sp.StopBits = StopBits

            'フロー制御をコンボボックスから取り出す.
            sp.Handshake = FlowControl

            '文字コードをセットする.
            sp.Encoding = Encoding.Unicode

            Try
                'シリアルポートをオープンする.
                sp.Open()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Catch ex As UnauthorizedAccessException
            errmsg = "ポートへのアクセスが拒否されています。"
            sp = Nothing
        Catch ex As ArgumentOutOfRangeException
            errmsg = "このインスタンスの 1 つ以上のプロパティが無効です。"
            sp = Nothing
        Catch ex As ArgumentException
            errmsg = "ポート名が 'COM' で始まっていません。"
            sp = Nothing
        Catch ex As IOException
            errmsg = "ポートが無効状態です。"
            sp = Nothing
        Catch ex As InvalidOperationException
            errmsg = "指定されたポートが既に開いています。"
            sp = Nothing
        Catch ex As Exception
            errmsg = "不明なエラーです。"
            sp = Nothing
        End Try

        If IsNothing(sp) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function close() As Boolean
        Try
            errmsg = ""
            sp.Close()
        Catch ex As IOException
            errmsg = "ポートが無効状態です。"
        Catch ex As Exception
            errmsg = "不明なエラーです。"
        End Try

        If errmsg = "" Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function writeData(data As String) As Boolean
        Try
            errmsg = ""
            sp.Write(data)
        Catch ex As ArgumentOutOfRangeException
            errmsg = "文字列が null です。"
        Catch ex As IOException
            errmsg = "ポートが無効状態です。"
        Catch ex As InvalidOperationException
            errmsg = "指定したポートが開いていません。"
        Catch ex As TimeoutException
            errmsg = "書き込むことができませんでした。"
        Catch ex As Exception
            errmsg = "不明なエラーです。"
        End Try

        If errmsg = "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function clearInBuffer() As Boolean
        Try
            errmsg = ""
            sp.DiscardInBuffer()
        Catch ex As IOException
            errmsg = "ポートが無効状態です。"
        Catch ex As InvalidOperationException
            errmsg = "ストリームが閉じられました。"
            errmsg = "不明なエラーです。"
        End Try

        If errmsg = "" Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function clearOutBuffer() As Boolean
        Try
            errmsg = ""
            sp.DiscardOutBuffer()
        Catch ex As IOException
            errmsg = "ポートが無効状態です。"
        Catch ex As InvalidOperationException
            errmsg = "ストリームが閉じられました。"
            errmsg = "不明なエラーです。"
        End Try

        If errmsg = "" Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function readData(ByRef data As String) As Boolean
        Try
            errmsg = ""
            data = sp.ReadExisting
        Catch ex As InvalidOperationException
            errmsg = "指定したポートが開いていません。"
        Catch ex As TimeoutException
            errmsg = "読込むことができませんでした。"
        Catch ex As Exception
            errmsg = "不明なエラーです。"

        End Try

        If errmsg = "" Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function writedataB(ByVal data As String, ByRef buff As String) As Boolean
        Try
            ' シリアルポートにデータ送信
            Dim dat As Byte() = System.Text.Encoding.GetEncoding("SHIFT-JIS").GetBytes(data)
            sp.Write(dat, 0, dat.GetLength(0))

        Catch ex As Exception

        End Try

        If errmsg = "" Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
