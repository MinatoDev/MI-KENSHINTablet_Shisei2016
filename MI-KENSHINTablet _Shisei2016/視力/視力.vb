﻿Imports Mi_KENSHINCommon

''' <summary>
''' 視力入力
''' </summary>
''' <remarks></remarks>
Public Class 視力
    Inherits Mi_KENSHINCommon.KenshinTabletBase

#Region "プロパティ"
    ''' <summary>
    ''' 視力Logicクラス
    ''' </summary>
    Private Property Logic As 視力Logic

    ''' <summary>
    ''' 個人ID
    ''' </summary>
    Public Property PersonID As String

    ''' <summary>
    ''' メッセージの戻り
    ''' </summary>
    Public Property Result As String


#End Region

#Region "コンストラクタ"
    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Try
            Logic = New 視力Logic(Me)
            Me.KenshinName = CommonConst.SIRYOKU

        Catch ex As Exception
            Using msgwin As MessageWindow = New MessageWindow()
                msgwin.IconImage = CommonConst.EXCLAMATION
                msgwin.ButtonStyle = CommonConst.OK_ONLY
                msgwin.MessageString = ex.Message
                msgwin.Caller = Me
                msgwin.ShowDialog()
            End Using
            End
        End Try
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub
#End Region

#Region "イベント"

#Region "通番確定イベント"
    ''' <summary>
    ''' 通番確定イベント
    ''' </summary>
    ''' <param name="tuban"></param>
    ''' <remarks></remarks>
    Public Overrides Sub Tuuban_TubanDecision(personID As String, tuban As String)

        If Not Logic.IsExist(personID) Then
            MyBase.ClearTuban()
            tuban = String.Empty
        End If

        If Not tuban.Equals(String.Empty) Then
            Logic.TubanDecision(personID, tuban)
            Logic.ClearValues()
            Logic.InitDisplay(tuban)
        Else
            lbl矯正右.Enabled = False
            lbl矯正右値.Enabled = False
            lbl矯正右値.Text = String.Empty
            lbl矯正左.Enabled = False
            lbl矯正左.Enabled = False
            lbl矯正左値.Enabled = False
            lbl矯正左値.Text = String.Empty
            lbl裸眼右.Enabled = False
            lbl裸眼右値.Enabled = False
            lbl裸眼右値.Text = String.Empty
            lbl裸眼左.Enabled = False
            lbl裸眼左値.Enabled = False
            lbl裸眼左値.Text = String.Empty
            btnRegist.Enabled = False
        End If
    End Sub

#End Region

#Region "各計測値クリックイベント"
    ''' <summary>
    ''' 各計測値クリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Value_Click(sender As Object, e As EventArgs) Handles lbl裸眼右値.Click, lbl裸眼左値.Click, lbl矯正右値.Click, lbl矯正左値.Click
        Logic.Value_Click(sender)
    End Sub
#End Region
  
#Region "登録ボタンクリックイベント"

    ''' <summary>
    ''' 登録ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRegist_Click(sender As Object, e As EventArgs) Handles btnRegist.Click

        Using msgwin As MessageWindow = New MessageWindow()
            msgwin.IconImage = CommonConst.QUESTION
            msgwin.ButtonStyle = CommonConst.YES_NO
            msgwin.MessageString = CommonConst.REGIST_QUESTION
            msgwin.Caller = Me
            msgwin.ShowDialog()

            If Result <> "YES" Then
                Exit Sub
            End If
        End Using

        Try
            Logic.Regist()

        Catch ex As Exception
            Using msgwin As MessageWindow = New MessageWindow()
                msgwin.IconImage = CommonConst.EXCLAMATION
                msgwin.ButtonStyle = CommonConst.OK
                msgwin.MessageString = ex.Message
                msgwin.Caller = Me
                msgwin.ShowDialog()
            End Using
        End Try
    End Sub


#End Region

#Region "TextChangeイベント"
    ''' <summary>
    '''TextChangeイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub lbl矯正右値_TextChanged(sender As Object, e As EventArgs) Handles lbl矯正右値.TextChanged, lbl矯正左値.TextChanged, lbl裸眼右値.TextChanged, lbl裸眼左値.TextChanged
        If Logic Is Nothing Then
            Exit Sub
        End If
        Logic.FontChange(sender)
    End Sub
#End Region

#Region "ロードイベント"
    ''' <summary>
    ''' ロードイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub 視力_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Logic.Load(Me) Then
            End
        End If
    End Sub
#End Region

#Region "終了イベント"
    ''' <summary>
    ''' 終了イベント
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub 視力_Quit() Handles Me.Quit
        Using msgwin As MessageWindow = New MessageWindow()
            msgwin.IconImage = CommonConst.QUESTION
            msgwin.ButtonStyle = CommonConst.YES_NO
            msgwin.MessageString = CommonConst.QUIT_QUESTION
            msgwin.Caller = Me
            msgwin.ShowDialog()

            If Result <> "YES" Then
                Exit Sub
            End If
        End Using

        Me.Close()
        Me.Dispose()
    End Sub

#End Region

#Region "クリアボタンイベント"
    ''' <summary>
    ''' クリアボタンイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lbl矯正右値.Text = String.Empty
        lbl矯正左値.Text = String.Empty
        lbl裸眼右値.Text = String.Empty
        lbl裸眼左値.Text = String.Empty
    End Sub

#End Region

#End Region

End Class
