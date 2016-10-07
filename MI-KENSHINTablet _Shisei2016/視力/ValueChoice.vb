
''' <summary>
''' 視力値選択クラス
''' </summary>
''' <remarks></remarks>
Public Class ValueChoice

#Region "プロパティ"
    ''' <summary>
    ''' 呼び出し元
    ''' </summary>
    Private Property Caller As Label
#End Region

#Region "コンストラクタ"
    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <param name="parent">呼び出し元</param>
    ''' <remarks></remarks>
    Public Sub New(parent As Label)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Caller = parent
        Me.ControlBox = False
        Me.Text = String.Empty

        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub
#End Region

#Region "イベント"
    ''' <summary>
    ''' 各値クリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Value_Click(sender As Object, e As EventArgs) Handles btn15.Click, btn12.Click, btn10.Click, btn09.Click,
                                                                      btn08.Click, btn07.Click, btn06.Click, btn05.Click,
                                                                      btn04.Click, btn03.Click, btn02.Click,
                                                                      btn01.Click, btnUnder01.Click, btnClear.Click
        If DirectCast(sender, Button).Name = "btnClear" Then
            Caller.Text = String.Empty
        Else
            Caller.Text = DirectCast(sender, Button).Text
        End If
        Me.Close()
    End Sub

    ''' <summary>
    ''' キャンセルクリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
#End Region

End Class