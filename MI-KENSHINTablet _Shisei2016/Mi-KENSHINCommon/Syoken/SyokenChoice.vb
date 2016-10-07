
''' <summary>
''' 診察値選択クラス
''' </summary>
''' <remarks></remarks>
Public Class btnClear

#Region "プロパティ"
    ''' <summary>
    ''' 呼び出し元
    ''' </summary>
    Public Property Caller As Label

    ''' <summary>
    ''' 検診名
    ''' </summary>
    Public Property KenshinName As String

    ''' <summary>
    ''' 項目名
    ''' </summary>
    Public Property ItemName As String

#End Region

#Region "コンストラクタ"
    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <param name="sender">呼び出し元</param>
    ''' <remarks></remarks>
    Public Sub New(sender As Label)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Caller = sender
        Me.ControlBox = False
        Me.Text = String.Empty

        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

    End Sub
#End Region

#Region "値クリック"
    ''' <summary>
    ''' 値クリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub 所見_Click(sender As Object, e As EventArgs) Handles btn所見あり.Click, btn所見なし.Click, btnクリア.Click

        If DirectCast(sender, Button).Name = "btnクリア" Then
            Caller.Text = String.Empty
        Else
            Caller.Text = DirectCast(sender, Button).Text
        End If
        Me.Close()
    End Sub
#End Region

#Region "キャンセルクリック"
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

#Region "ロードイベント"

    ''' <summary>
    ''' ロードイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClear_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl検診名.Text = String.Format(lbl検診名.Text, KenshinName)
        lblTitle.Text = ItemName
    End Sub

#End Region

End Class