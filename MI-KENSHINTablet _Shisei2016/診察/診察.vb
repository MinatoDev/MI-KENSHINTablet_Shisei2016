﻿Imports Mi_KENSHINCommon

''' <summary>
''' 診察クラス
''' </summary>
''' <remarks></remarks>
Public Class 診察
    Inherits Mi_KENSHINCommon.KenshinTabletBase

#Region "プロパティ"
    ''' <summary>
    ''' 視力Logicクラス
    ''' </summary>
    Private Property Logic As 診察Logic

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
            Logic = New 診察Logic(Me)
            Me.KenshinName = CommonConst.SHINSATSU

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
            lbl所見値.Enabled = False
            lbl診察.Enabled = False
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
    Private Sub Value_Click(sender As Object, e As EventArgs) Handles lbl所見値.Click
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

#Region "終了イベント"
    ''' <summary>
    ''' 終了イベント
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub 診察_Quit() Handles Me.Quit
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

End Class
