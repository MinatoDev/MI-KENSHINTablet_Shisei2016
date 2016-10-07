Public Class MessageWindow

    Public Property IconImage As String = String.Empty
    Public Property MessageString As String = String.Empty
    Public Property Caller As Object
    Public Property ButtonStyle As String = String.Empty

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Me.ControlBox = False
        Me.Text = String.Empty
    End Sub

    Private Sub MessageWindow_Load(sender As Object, e As EventArgs) Handles Me.Load

        Select Case ButtonStyle
            Case String.Empty, CommonConst.OK_ONLY
                btnはい.Visible = False
                btnいいえ.Visible = False
                btnOK.Visible = True
            Case CommonConst.YES_NO
                btnはい.Visible = True
                btnいいえ.Visible = True
                btnOK.Visible = False
        End Select

        Select Case IconImage
            Case CommonConst.INFO
                Me.picIcon.Image = My.Resources.information
            Case CommonConst.QUESTION
                Me.picIcon.Image = My.Resources.question
            Case CommonConst.EXCLAMATION
                Me.picIcon.Image = My.Resources.exclamation
        End Select

        Me.lblMsg.Text = MessageString

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Caller.Result = CommonConst.OK
        Me.Close()
    End Sub

    Private Sub btnはい_Click(sender As Object, e As EventArgs) Handles btnはい.Click
        Caller.Result = CommonConst.YES
        Me.Close()
    End Sub

    Private Sub btnいいえ_Click(sender As Object, e As EventArgs) Handles btnいいえ.Click
        Caller.Result = CommonConst.NO
        Me.Close()
    End Sub
End Class