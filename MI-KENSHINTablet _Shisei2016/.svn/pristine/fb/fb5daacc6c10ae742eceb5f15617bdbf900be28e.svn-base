''' <summary>
''' テンキークラス
''' </summary>
''' <remarks></remarks>
Public Class Tenkey

#Region "プロパティ"
    ''' <summary>
    ''' 整数桁数
    ''' </summary>
    Public Property Seisu As Nullable(Of Integer)

    ''' <summary>
    ''' 少数桁数
    ''' </summary>
    Public Property Syousu As Nullable(Of Integer)

    ''' <summary>
    ''' 呼び出し元
    ''' </summary>mhxcxcxcxc
    Public Property Cntl As Object

    ''' <summary>
    ''' 対象項目名
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ItemName As String = String.Empty


    ''' <summary>
    ''' ロジッククラス
    ''' </summary>
    Private Property Logic As TenkeyLogic = New TenkeyLogic

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
        Me.ControlBox = False
        Me.WindowState = FormWindowState.Maximized
    End Sub
#End Region

#Region "イベント"
    ''' <summary>
    ''' テンキーボタンクリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Tenkey_Click(sender As Object, e As EventArgs) Handles btnClear.Click, ButtonDot.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click, btnDel.Click
        Try
            If Not Logic.InputKey(Me, sender) Then
                Exit Sub
            End If
        Catch ex As Exception
            Throw
        End Try

    End Sub


    ''' <summary>
    ''' 決定ボタンクリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        Cntl.text = lblAtai.Text
        Me.Close()
        Me.Dispose()
    End Sub

    ''' <summary>
    ''' キャンセルボタンクリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()

    End Sub

    ''' <summary>
    ''' ロードイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Tenkey_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Syousu Is Nothing OrElse Syousu = 0 Then
            ButtonDot.Enabled = False
        End If
        lblItemName.Text = ItemName
    End Sub

#End Region

End Class