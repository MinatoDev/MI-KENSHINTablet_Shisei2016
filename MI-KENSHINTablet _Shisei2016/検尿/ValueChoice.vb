''' <summary>
''' 検尿値選択クラス
''' </summary>
''' <remarks></remarks>
Public Class ValueChoice
    Private Property Caller As Label

#Region "コンストラクタ"
    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <remarks></remarks>
    Public Sub New(sender As Label)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Caller = sender
        If Caller.Tag = False Then
            btnM.Enabled = False
        End If
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

    End Sub

#End Region

#Region "イベント"
    ''' <summary>
    ''' キャンセルボタンクリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' 各値ボタンクリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnM.Click, btnPM.Click, btnP.Click, btnPP.Click, btnPPP.Click, btnClear.Click

        If DirectCast(sender, Button).Name = "btnClear" Then
            Caller.Text = String.Empty
        Else
            Caller.Text = DirectCast(sender, Button).Text
        End If

        Me.Close()
    End Sub

#End Region

End Class