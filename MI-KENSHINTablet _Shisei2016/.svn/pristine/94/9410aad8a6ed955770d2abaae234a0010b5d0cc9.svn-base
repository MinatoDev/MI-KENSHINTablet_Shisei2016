Imports System.Windows.Forms


''' <summary>
''' 通番リスト表示選択クラス
''' </summary>
''' <remarks></remarks>
Public Class TubanList

#Region "変数"
    ''' <summary>
    ''' ロジッククラスのインスタンス
    ''' </summary>
    ''' <remarks></remarks>
    Private logic As TubanLogic = New TubanLogic

    ''' <summary>
    ''' 呼び出し元
    ''' </summary>
    ''' <remarks></remarks>
    Private Caller As Tuban

#End Region

#Region "プロパティ"
    ''' <summary>
    ''' 接続情報
    ''' </summary>
    Public Property ConnectionInfo As List(Of String) = New List(Of String)
#End Region

#Region "コンストラクタ"
    Public Sub New(parent)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        Caller = parent
        flp.FlowDirection = FlowDirection.LeftToRight
        Me.WindowState = FormWindowState.Maximized

    End Sub
#End Region

#Region "ロードイベント"
    ''' <summary>
    ''' ロードイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TubanList_Load(sender As Object, e As EventArgs) Handles Me.Load
        logic.ConnectionInfo = ConnectionInfo
        logic.DisplayList(flp, Caller.KenshinName, False)

        AddEvent()
    End Sub
#End Region

#Region "キャンセルボタンイベント"
    ''' <summary>
    ''' キャンセルボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Caller.lblTuban.Text = String.Empty
        Caller.lblName.Text = String.Empty
        flp.Visible = False
        logic.ClearList()
        flp.Visible = True
        Me.Close()
    End Sub
#End Region

#Region "個人が選択されたイベント"
    ''' <summary>.
    ''' 個人が選択されたイベント
    ''' </summary>
    ''' <param name="number"></param>
    ''' <param name="name"></param>
    ''' <remarks></remarks>
    Private Sub OnPersonSelected(personID As String, number As String, name As String)
        Caller.lblTuban.Text = number
        Caller.lblName.Text = name.Trim + "様"
        Caller.PersonID = personID
        Me.Close()
    End Sub

#End Region

#Region "allクリック"
    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        If btnAll.Text = "すべて表示" Then
            flp.Visible = False
            logic.DisplayList(flp, Caller.KenshinName, True)
            btnAll.Text = "未通過表示"
            flp.Visible = True
        Else
            flp.Visible = False
            logic.DisplayList(flp, Caller.KenshinName, False)
            btnAll.Text = "すべて表示"
            flp.Visible = True

        End If
        AddEvent()
    End Sub

#End Region

#Region "イベント追加"
    ''' <summary>
    ''' イベント追加
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AddEvent()
        For Each cntl In flp.Controls
            Dim person As Person = DirectCast(cntl, Person)
            AddHandler person.PersonSelected, AddressOf Me.OnPersonSelected
        Next
    End Sub

#End Region

    ''' <summary>
    ''' ▲ボタンイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub upper_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        flp.AutoScrollPosition = New Point(-flp.AutoScrollPosition.X + 0, -flp.AutoScrollPosition.Y + 30)
    End Sub

    ''' <summary>
    ''' ▼ボタンイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub down_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        flp.AutoScrollPosition = New Point(-flp.AutoScrollPosition.X + 0, -flp.AutoScrollPosition.Y - 30)
    End Sub
End Class
