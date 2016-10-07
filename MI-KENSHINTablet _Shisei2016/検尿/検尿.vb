Imports Mi_KENSHINCommon

''' <summary>
''' 検尿クラス
''' </summary>
''' <remarks></remarks>
Public Class 検尿
    Inherits Mi_KENSHINCommon.KenshinTabletBase

#Region "プロパティ"
    ''' <summary>
    ''' 視力Logicクラス
    ''' </summary>
    Private Property Logic As 検尿Logic

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
            Logic = New 検尿Logic(Me)
            Me.KenshinName = CommonConst.KENNYOU

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
    ''' <summary>
    ''' 通番確定イベント
    ''' </summary>
    ''' <param name="tuban"></param>
    ''' <remarks></remarks>
    Public Overrides Sub Tuuban_TubanDecision(personID As String, tuban As String)


        If Not tuban.Equals(String.Empty) Then
            Logic.TubanDecision(personID, tuban)
            Logic.ClearValues()
            Logic.InitDisplay(tuban)
        Else
            lbl尿ウロビリ.Enabled = False
            lbl尿ウロビリ値.Enabled = False
            lbl尿潜血.Enabled = False
            lbl尿潜血値.Enabled = False
            lbl尿蛋白.Enabled = False
            lbl尿蛋白値.Enabled = False
            lbl尿糖.Enabled = False
            lbl尿糖値.Enabled = False
            btnRegist.Enabled = False
        End If
        Logic.IsExist(personID)
    End Sub


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
                msgwin.ButtonStyle = CommonConst.OK_ONLY
                msgwin.MessageString = ex.Message
                msgwin.Caller = Me
                msgwin.ShowDialog()
            End Using
        End Try
    End Sub

    ''' <summary>
    ''' 検尿値クリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub 検尿値_Click(sender As Object, e As EventArgs) Handles lbl尿糖値.Click, lbl尿蛋白値.Click, lbl尿ウロビリ値.Click, lbl尿潜血値.Click
        If DirectCast(sender, Label).Name = "lbl尿ウロビリ値" Then
            sender.tag = False
        Else
            sender.tag = True
        End If

        Dim tltle As String = String.Empty
        Select Case DirectCast(sender, Label).Name
            Case "lbl尿ウロビリ値"
                tltle = lbl尿ウロビリ.Text
            Case "lbl尿潜血値"
                tltle = lbl尿潜血.Text
            Case "lbl尿蛋白値"
                tltle = lbl尿蛋白.Text
            Case "lbl尿糖値"
                tltle = lbl尿糖.Text
        End Select
        Logic.Value_Click(sender, tltle)

    End Sub

    ''' <summary>
    ''' ロードイベント
    ''' </summary>
    Private Sub 検尿_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Logic.Load(Me) Then
            End
        End If
    End Sub

#Region "終了イベント"
    ''' <summary>
    ''' 終了イベント
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub 検尿_Quit() Handles Me.Quit
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

#End Region


End Class
