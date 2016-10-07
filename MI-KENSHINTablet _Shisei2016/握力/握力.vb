Imports Mi_KENSHINCommon
Imports Mi_KENSHINCommon.Common

Public Class 握力
    Inherits Mi_KENSHINCommon.KenshinTabletBase

#Region "プロパティ"
    ''' <summary>
    ''' 握力Logicクラス
    ''' </summary>
    Private Property Logic As 握力Logic

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
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        Try
            Logic = New 握力Logic(Me)
            Me.KenshinName = CommonConst.AKURYOKU

            If MyBase.RealTenKey Then
                Me.txt握力右値1.Top = lbl握力右.Top
                Me.txt握力右値2.Top = lbl握力右.Top
                Me.lblTen右.Top = lbl握力右.Top

                Me.txt握力左値1.Top = lbl握力左.Top
                Me.txt握力左値2.Top = lbl握力左.Top
                Me.lblTen左.Top = lbl握力左.Top

                Me.lbl握力右値.Visible = False
                Me.lbl握力左値.Visible = False

                Me.txt握力右値1.NextFocus = Me.txt握力右値2
                Me.txt握力右値2.NextFocus = Me.txt握力左値1
                Me.txt握力左値1.NextFocus = Me.txt握力左値2
                Me.txt握力左値2.NextFocus = Me.btnRegist

            Else
                Me.txt握力右値1.Visible = False
                Me.txt握力右値2.Visible = False
                Me.txt握力左値1.Visible = False
                Me.txt握力左値2.Visible = False
                Me.lblTen右.Visible = False
                Me.lblTen左.Visible = False
            End If

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

        If Not Logic.IsExist(personID) Then
            MyBase.ClearTuban()
            tuban = String.Empty
        End If

        If Not tuban.Equals(String.Empty) Then
            Logic.TubanDecision(personID, tuban)
            Logic.ClearValues()
            Logic.InitDisplay(tuban)
            lbl握力右値.Enabled = True
            lbl握力左値.Enabled = True
        Else
            lbl握力右値.Text = String.Empty
            lbl握力左値.Text = String.Empty
            lblTen右.Enabled = False
            lblTen左.Enabled = False
            lbl握力右.Enabled = False
            lbl握力右単位.Enabled = False
            lbl握力右値.Enabled = False
            lbl握力左.Enabled = False
            lbl握力左単位.Enabled = False
            lbl握力左値.Enabled = False
            btnRegist.Enabled = False

            txt握力右値1.Enabled = False
            txt握力右値1.Text = String.Empty
            txt握力右値2.Enabled = False
            txt握力右値2.Text = String.Empty
            txt握力左値1.Enabled = False
            txt握力左値1.Text = String.Empty
            txt握力左値2.Enabled = False
            txt握力左値2.Text = String.Empty

        End If
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
            If MyBase.RealTenKey Then
                lbl握力右値.Text = txt握力右値1.Text & "." & IIf(txt握力右値2.Text = String.Empty, "0", txt握力右値2.Text)
                lbl握力左値.Text = txt握力左値1.Text & "." & IIf(txt握力左値2.Text = String.Empty, "0", txt握力左値2.Text)

                If Microsoft.VisualBasic.Left(lbl握力右値.Text, 1) = "." Then
                    Throw New No_InputException(lbl握力右.Text + "が入力されていません。")
                End If
                If Microsoft.VisualBasic.Left(lbl握力左値.Text, 1) = "." Then
                    Throw New No_InputException(lbl握力左.Text + "が入力されていません。")
                End If
            Else
                If lbl握力右値.Text = String.Empty Then
                    Throw New No_InputException(lbl握力右.Text + "が入力されていません。")
                End If
                If lbl握力左値.Text = String.Empty Then
                    Throw New No_InputException(lbl握力左.Text + "が入力されていません。")
                End If

            End If

            Logic.Regist()

        Catch ex As Exception
            Using msgwin As MessageWindow = New MessageWindow()
                msgwin.IconImage = CommonConst.EXCLAMATION
                msgwin.ButtonStyle = CommonConst.OK_ONLY
                msgwin.MessageString = ex.Message
                msgwin.Caller = Me
                msgwin.ShowDialog()
            End Using
            'Logic.ClearValues()
        End Try
    End Sub

    ''' <summary>
    ''' 握力値クリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub 握力値_Click(sender As Object, e As EventArgs) Handles lbl握力右値.Click, lbl握力左値.Click
        'Logic.Value_Click(sender)

    End Sub

    ''' <summary>
    ''' ロードイベント
    ''' </summary>
    Private Sub 腹囲_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Logic.Load(Me) Then
            End
        End If
    End Sub

    Private Sub txt握力値_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt握力右値1.KeyPress, txt握力右値2.KeyPress, txt握力左値1.KeyPress, txt握力左値2.KeyPress
        If Not Logic.KeyInputValidation(sender, e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt握力値_TextChanged(sender As Object, e As EventArgs) Handles txt握力右値1.TextChanged, txt握力右値2.TextChanged, txt握力左値1.TextChanged, txt握力左値2.TextChanged
        DirectCast(sender, Mi_TextBox).ForeColor = Color.Black
    End Sub

    Private Sub txt握力値_Validated(sender As Object, e As EventArgs) Handles txt握力右値1.Validated, txt握力右値2.Validated, txt握力左値1.Validated, txt握力左値2.Validated
        Logic.腹囲値_Validated()
    End Sub

    Private Sub lbl握力右値_Click(sender As Object, e As EventArgs) Handles lbl握力右値.Click, lbl握力左値.Click
        Logic.Value_Click(sender)
    End Sub

    ''' <summary>
    ''' 終了イベント
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub 握力_Quit() Handles Me.Quit
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

    ''' <summary>
    ''' Enterイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRegist_Enter(sender As Object, e As EventArgs) Handles btnRegist.Enter
        btnRegist.PerformClick()
    End Sub

#End Region

End Class
