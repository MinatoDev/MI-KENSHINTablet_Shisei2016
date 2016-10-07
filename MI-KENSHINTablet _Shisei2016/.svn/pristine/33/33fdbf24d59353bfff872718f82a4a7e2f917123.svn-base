Imports System.Configuration
Imports Mi_KENSHINCommon

Public Class Setting
    Private Property Settings As Config = New Config
    Private Property com As Common = New Common

#Region "コンストラクタ"
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Me.ControlBox = Not Me.ControlBox
        Settings = com.ReadConfig()
    End Sub
#End Region

#Region "登録ボタンイベント"
    ''' <summary>
    ''' 登録ボタンイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn登録_Click(sender As Object, e As EventArgs) Handles btn登録.Click
        Settings.RealTenKey = Me.btnTenkty.Tag

        Settings.DSN = Me.txtDSN.Text
        Settings.DBName = Me.txtDBName.Text
        Settings.UserName = Me.txtUserName.Text
        Settings.Password = Me.txtPassword.Text
        com.SaveConfig(Settings)
        Me.Close()
    End Sub
#End Region

#Region "実テンキーボタンイベント"
    ''' <summary>
    ''' 実テンキーボタンイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnTenkty_Click(sender As Object, e As EventArgs) Handles btnTenkty.Click
        If btnTenkty.Text = "使用しない" Then
            btnTenkty.Tag = True
            btnTenkty.Text = "使用する"
        Else
            btnTenkty.Tag = False
            btnTenkty.Text = "使用しない"
        End If
    End Sub
#End Region

#Region "実テンキーボタンイベント"
    ''' <summary>
    ''' 実テンキーボタンイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Setting_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Settings.RealTenKey Then
            btnTenkty.Text = "使用する"
            btnTenkty.Tag = True
        Else
            btnTenkty.Text = "使用しない"
            btnTenkty.Tag = False

        End If
        Me.txtDSN.Text = Settings.DSN
        Me.txtDBName.Text = Settings.DBName
        Me.txtUserName.Text = Settings.UserName
        Me.txtPassword.Text = Settings.Password
    End Sub
#End Region

#Region "キャンセルボタンイベント"
    ''' <summary>
    ''' キャンセルボタンイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
#End Region

End Class