Imports Mi_KENSHINCommon
Imports Mi_KENSHINCommon.Common

Public Class 身長体重
    Inherits Mi_KENSHINCommon.KenshinTabletBase

#Region "プロパティ"
    ''' <summary>
    ''' 腹囲Logicクラス
    ''' </summary>
    Private Property Logic As 身長体重Logic

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
            Logic = New 身長体重Logic(Me)
            Me.KenshinName = CommonConst.HEIGHT & "・" & "体重・" & CommonConst.FUKUI

            If MyBase.RealTenKey Then
                Me.txt身長.Left = lbl身長値.Left
                Me.txt身長.Top = lbl身長値.Top
                Me.txt身長少数.Top = lbl身長値.Top
                Me.Label3.Top = lbl身長値.Top
                Me.lbl身長値.Visible = False

                Me.txt体重.Left = lbl体重値.Left
                Me.txt体重.Top = lbl体重値.Top
                Me.txt体重少数.Top = lbl体重値.Top
                Me.Label4.Top = lbl体重値.Top
                Me.lbl体重値.Visible = False

                Me.txt腹囲.Left = lbl腹囲値.Left
                Me.txt腹囲.Top = lbl腹囲値.Top
                Me.txt腹囲少数.Top = lbl腹囲値.Top
                Me.Label5.Top = lbl腹囲値.Top
                Me.lbl腹囲値.Visible = False

                Me.txt身長.NextFocus = Me.txt身長少数
                Me.txt身長少数.NextFocus = Me.txt体重
                Me.txt体重.NextFocus = Me.txt体重少数
                If btn腹囲.Text <> "腹囲実施する" Then
                    Me.txt体重少数.NextFocus = Me.txt腹囲
                Else
                    Me.txt体重少数.NextFocus = Me.btnRegist
                End If
                Me.txt腹囲.NextFocus = Me.txt腹囲少数
                Me.txt腹囲少数.NextFocus = Me.btnRegist

            Else
                Me.txt身長.Visible = False
                Me.txt身長少数.Visible = False
                Me.txt体重.Visible = False
                Me.txt体重少数.Visible = False
                Me.txt腹囲.Visible = False
                Me.txt腹囲少数.Visible = False
                Me.Label3.Visible = False
                Me.Label4.Visible = False
                Me.Label5.Visible = False
            End If

            If My.Settings.Is腹囲 Then
                btn腹囲.Text = "腹囲実施する"
            Else
                btn腹囲.Text = "腹囲実施しない"
            End If
            Logic.btn腹囲_Click(MyBase.RealTenKey)

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
            tuban = String.Empty
        End If

        If Not tuban.Equals(String.Empty) Then
            Logic.TubanDecision(personID, tuban)
            Logic.ClearValues()
            Logic.InitDisplay(tuban)
            btn腹囲.Enabled = True
        Else
            lbl身長.Enabled = False
            lbl身長単位.Enabled = False
            lbl身長値.Enabled = False
            lbl身長値.Text = String.Empty
            lbl体重.Enabled = False
            lbl体重単位.Enabled = False
            lbl体重値.Enabled = False
            lbl体重値.Text = String.Empty
            lbl腹囲.Enabled = False
            lbl腹囲単位.Enabled = False
            lbl腹囲値.Enabled = False
            lbl腹囲値.Text = String.Empty
            btnRegist.Enabled = False
            txt身長.Enabled = False
            txt身長.Text = String.Empty
            txt身長少数.Enabled = False
            txt身長少数.Text = String.Empty
            txt体重.Enabled = False
            txt体重.Text = String.Empty
            txt体重少数.Enabled = False
            txt体重少数.Text = String.Empty
            txt体重少数.Enabled = False
            txt腹囲.Enabled = False
            txt腹囲.Text = String.Empty
            txt腹囲少数.Enabled = False
            txt腹囲少数.Text = String.Empty
        End If
        'Logic.IsExist(personID)
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
                lbl身長値.Text = txt身長.Text & "." & IIf(txt身長少数.Text = String.Empty, "0", txt身長少数.Text)
                lbl体重値.Text = txt身長.Text & "." & IIf(txt体重少数.Text = String.Empty, "0", txt体重少数.Text)
                lbl腹囲値.Text = txt身長.Text & "." & IIf(txt腹囲少数.Text = String.Empty, "0", txt腹囲少数.Text)
            End If
            If Microsoft.VisualBasic.Left(lbl身長値.Text, 1) = "." Then
                Throw New No_InputException(lbl身長.Text + "が入力されていません。")
            End If
            If Microsoft.VisualBasic.Left(lbl体重値.Text, 1) = "." Then
                Throw New No_InputException(lbl体重.Text + "が入力されていません。")
            End If
            If Microsoft.VisualBasic.Left(lbl腹囲値.Text, 1) = "." Then
                Throw New No_InputException(lbl腹囲.Text + "が入力されていません。")
            End If

            Logic.Regist()
            btn腹囲.Enabled = False

        Catch ex As Exception
            Using msgwin As MessageWindow = New MessageWindow()
                msgwin.IconImage = CommonConst.EXCLAMATION
                msgwin.ButtonStyle = CommonConst.OK_ONLY
                msgwin.MessageString = ex.Message
                msgwin.Caller = Me
                msgwin.ShowDialog()
            End Using
            'Logic.ClearValues()
            btnRegist.Enabled = True
        End Try
    End Sub

    ''' <summary>
    ''' 値クリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub 値_Click(sender As Object, e As EventArgs) Handles lbl身長値.Click, lbl体重値.Click, lbl腹囲値.Click
        Logic.Value_Click(sender)

    End Sub

    ''' <summary>
    ''' ロードイベント
    ''' </summary>
    Private Sub 腹囲_Load(sender As Object, e As EventArgs) Handles Me.Load
        If btn腹囲.Text <> "腹囲実施する" Then
            Me.txt体重少数.NextFocus = Me.txt腹囲
        Else
            Me.txt体重少数.NextFocus = Me.btnRegist
        End If

        If Not Logic.Load(Me) Then
            End
        End If
    End Sub

    Private Sub 値_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt身長.KeyPress, txt体重.KeyPress, txt腹囲.KeyPress, txt身長少数.KeyPress, txt体重少数.KeyPress, txt腹囲少数.KeyPress
        If Not Logic.KeyInputValidation(sender, e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub 値_TextChanged(sender As Object, e As EventArgs) Handles txt身長.TextChanged, txt体重.TextChanged, txt腹囲.TextChanged, txt身長少数.TextChanged, txt体重少数.TextChanged, txt腹囲少数.TextChanged
        DirectCast(sender, Mi_TextBox).ForeColor = Color.Black
    End Sub

    Private Sub 値_Validated(sender As Object, e As EventArgs) Handles txt身長.Validated, txt体重.Validated, txt腹囲.Validated, txt身長少数.Validated, txt体重少数.Validated, txt腹囲少数.Validated
        Logic.値_Validated()
    End Sub

    Private Sub btn腹囲_Click(sender As Object, e As EventArgs) Handles btn腹囲.Click
        Call Logic.btn腹囲_Click(MyBase.RealTenKey)
        If btn腹囲.Text <> "腹囲実施する" Then
            Me.txt体重少数.NextFocus = Me.txt腹囲
        Else
            Me.txt体重少数.NextFocus = Me.btnRegist
        End If
    End Sub

    ''' <summary>
    ''' 終了イベント
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub 身長体重_Quit() Handles Me.Quit
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
