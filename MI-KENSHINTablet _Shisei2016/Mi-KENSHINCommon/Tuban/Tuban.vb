Imports Dac
Imports System.Configuration
Imports Mi_KENSHINCommon

''' <summary>
''' 通番クラス
''' </summary>
''' <remarks></remarks>
Public Class Tuban

#Region "プロパティ"
    ''' <summary>
    ''' 個人ID
    ''' </summary>
    Public Property PersonID As String

    ''' <summary>
    ''' 対象検診名称
    ''' </summary>
    Public Property KenshinName As String

    ''' <summary>
    ''' 接続情報
    ''' </summary>
    Public Property ConnectionInfo As List(Of String) = New List(Of String)

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

    End Sub

#End Region

#Region "イベント"
    ''' <summary>
    ''' 通番選択イベント
    ''' </summary>
    ''' <param name="tuban"></param>
    ''' <remarks></remarks>
    Public Event TubanDecision(personID As String, tuban As String)

    ''' <summary>
    ''' 実テンキーからの入力確定
    ''' </summary>
    ''' <param name="tuban"></param>
    ''' <remarks></remarks>
    Public Event TubanDecisionByKey(tuban As String)


    ''' <summary>
    ''' 通番クリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub lblTuban_Click(sender As Object, e As EventArgs) Handles lblTuban.Click

        Using tlist As TubanList = New TubanList(Me)
            tlist.ConnectionInfo = ConnectionInfo
            tlist.ShowDialog()
        End Using

        RaiseEvent TubanDecision(PersonID, lblTuban.Text)
    End Sub
#End Region

    Private Sub txtTuban_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTuban.KeyPress
        Dim Logic As TubanLogic = New TubanLogic()
        If Not Logic.InputCharValidation(e.KeyChar) Then
            e.Handled = True
        End If

        lblName.Text = String.Empty
        If e.KeyChar = ControlChars.Cr Then
            Dim dummy As String = Logic.ExitsTuban(txtTuban.Text)
            If dummy = String.Empty Then
                Exit Sub
            Else
                Dim wk() As String = dummy.Split(",")
                PersonID = wk(0)
                lblName.Text += StrConv(wk(1), VbStrConv.Wide) & "様"
                RaiseEvent TubanDecision(Trim(PersonID), txtTuban.Text)
            End If
            e.Handled = True
        End If
    End Sub

    Public Sub TubanInit()
        txtTuban.Focus()
    End Sub

    Public Sub Clear()
        txtTuban.Text = String.Empty
        lblTuban.Text = String.Empty
        lblName.Text = String.Empty
    End Sub

End Class
