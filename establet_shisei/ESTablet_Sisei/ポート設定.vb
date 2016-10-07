Option Explicit On

Imports System.Media
Imports System.IO.Ports
Imports System.ComponentModel

Public Class ポート設定
    Private errmsg As String = ""
#Region "初期化"
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Me.MinimumSize = New Size(1192, 768)
        Me.MaximumSize = New Size(1192, 768)

        Me.Icon = My.Resources.計測

        Dim ser As Serial = New Serial()
        Dim aaa(0) As String
        Dim idx As Integer
        Call GetPortNames(aaa)

        For idx = 0 To aaa.Length - 1 Step 1
            cmbPort.Items.Add(aaa(idx))
        Next

        cmbPort.Text = My.Settings.Port
        cmbデータビット.Text = My.Settings.DataBit.ToString
        cmbビット秒.Text = My.Settings.Speed.ToString
        cmbパリティ.Text = My.Settings.Parity.ToString
        cmbストップビット.Text = My.Settings.StopBit.ToString
        Select Case My.Settings.FlowControl
            Case 0
                cmbフロー制御.Text = "なし"
            Case 1
                cmbフロー制御.Text = "XON/XOFF"
            Case 2
                cmbフロー制御.Text = "RTS/CTS"
            Case 3
                cmbフロー制御.Text = "XON/XOFF + RTS/CTS"
        End Select

    End Sub

#End Region
#Region "設定ボタン"
    Private Sub btn設定_Click(sender As System.Object, e As System.EventArgs) Handles btn設定.Click
        Dim errmsg As String = ""
        Dim errobj As Object = Nothing

        Try
            errobj = cmbPort
            If cmbPort.Text = "" Then
                errmsg = "ポートを選択してください。"
                Throw New No_InputException(errmsg)
            Else
                ep.SetError(errobj, Nothing)
            End If

            errobj = cmbデータビット
            If cmbデータビット.Text = "" Then
                errmsg = "データビットを選択してください。"
                Throw New No_InputException(errmsg)
            Else
                ep.SetError(errobj, Nothing)
            End If

            errobj = cmbビット秒
            If cmbビット秒.Text = "" Then
                errmsg = "ビット/秒を選択してください。"
                Throw New No_InputException(errmsg)
            Else
                ep.SetError(errobj, Nothing)
            End If

            errobj = cmbパリティ
            If cmbパリティ.Text = "" Then
                errmsg = "パリティを選択してください。"
                Throw New No_InputException(errmsg)
            Else
                ep.SetError(errobj, Nothing)
            End If

            errobj = cmbストップビット
            If cmbストップビット.Text = "" Then
                errmsg = "ストップビットを選択してください。"
                Throw New No_InputException(errmsg)
            Else
                ep.SetError(errobj, Nothing)
            End If

            errobj = cmbフロー制御
            If cmbフロー制御.Text = "" Then
                errmsg = "フロー制御を選択してください。"
                Throw New No_InputException(errmsg)
            Else
                ep.SetError(errobj, Nothing)
            End If

            My.Settings.Port = cmbPort.Text
            My.Settings.DataBit = Short.Parse(cmbデータビット.Text)
            My.Settings.Speed = Integer.Parse(cmbビット秒.Text)
            My.Settings.Parity = cmbパリティ.Text
            My.Settings.StopBit = Short.Parse(cmbストップビット.Text)

            Select Case cmbフロー制御.Text
                Case "なし"
                    My.Settings.FlowControl = 0     'None
                Case "XON/XOFF"
                    My.Settings.FlowControl = 1     'XOnXOff
                Case "RTS/CTS"
                    My.Settings.FlowControl = 2     'RequestToSend 
                Case "XON/XOFF + RTS/CTS"
                    My.Settings.FlowControl = 3     'RequestToSendXOnXOff
            End Select
            My.Settings.Save()
            Call 計測.initComPort()
            MessageBox.Show("設定しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As No_InputException
            SystemSounds.Exclamation.Play()
            ep.SetError(errobj, errmsg)
        Catch ex As Exception
            SystemSounds.Exclamation.Play()
            MsgBox(unkownError)
        End Try
    End Sub

#End Region
#Region "Formイベント"
    Private Sub btn戻る_Click(sender As System.Object, e As System.EventArgs) Handles btn戻る.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ポート設定_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
#End Region
#Region "ポート名取得"
    Public Function GetPortNames(ByRef ports() As String) As Boolean
        Try
            ports = SerialPort.GetPortNames()
            If ports.Length = 0 Then
                errmsg = "シリアル ポート名を照会できませんでした。"
            End If
        Catch ex As Win32Exception
            errmsg = "シリアル ポート名を照会できませんでした。"
        Catch ex As Exception
            errmsg = "不明なエラーです。"
        End Try

        If IsNothing(sp) Then
            Return False
        Else
            Return True
        End If

    End Function
#End Region
#Region "デフォルト設定"
    Private Sub btn血圧計_Click(sender As System.Object, e As System.EventArgs) Handles btn血圧計.Click
        cmbデータビット.Text = "8"
        cmbビット秒.Text = "9600"
        cmbパリティ.Text = "0"
        cmbストップビット.Text = "2"
        cmbフロー制御.Text = "なし"
    End Sub

    Private Sub btn身長体重計_Click(sender As System.Object, e As System.EventArgs) Handles btn身長体重計.Click
        cmbデータビット.Text = "8"
        cmbビット秒.Text = "9600"
        cmbパリティ.Text = "なし"
        cmbストップビット.Text = "1"
        cmbフロー制御.Text = "RTS/CTS"
    End Sub
#End Region
End Class