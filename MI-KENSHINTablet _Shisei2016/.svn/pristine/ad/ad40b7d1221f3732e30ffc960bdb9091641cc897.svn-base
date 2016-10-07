Imports Mi_KENSHINCommon
Imports Dac
Imports System.Configuration.ConfigurationManager
Imports Microsoft.VisualBasic

Public Class KenshinTabletBase

    ''' <summary>
    ''' 検診名
    ''' </summary>
    Public Property KenshinName As String

    Public Property ConnectInfo As List(Of String) = New List(Of String)
    Public Property RealTenKey As Boolean
    Private Property Result As String


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
        Me.Text = String.Empty

        Try
            Dim com As Common = New Common
            Dim config As Config = com.ReadConfig

            RealTenKey = config.RealTenKey
            ConnectInfo.Add(config.DSN)
            ConnectInfo.Add(config.DBName)
            ConnectInfo.Add(config.UserName)
            ConnectInfo.Add(config.Password)

            Tuuban.ConnectionInfo = ConnectInfo

            If RealTenKey Then
                Tuuban.txtTuban.Visible = True
                Tuuban.txtTuban.Size = Tuuban.lblTuban.Size
                Tuuban.txtTuban.Font = Tuuban.lblTuban.Font
                Tuuban.txtTuban.Location = Tuuban.lblTuban.Location
                Tuuban.lblTuban.Visible = False

            Else
                Tuuban.txtTuban.Visible = False
                Tuuban.lblTuban.Visible = True

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region



#Region "イベント"
    ''' <summary>
    ''' 終了イベント
    ''' </summary>
    ''' <remarks></remarks>
    Public Event Quit()

    ''' <summary>
    ''' 通番が確定されたイベント
    ''' </summary>
    ''' <param name="tuban"></param>
    ''' <remarks></remarks>
    Public Overridable Sub Tuuban_TubanDecision(personID As String, tuban As String) Handles Tuuban.TubanDecision

    End Sub

    ''' <summary>
    ''' 通番が確定されたイベント(実テンキー)
    ''' </summary>
    ''' <param name="tuban"></param>
    ''' <remarks></remarks>
    Public Overridable Sub Tuuban_TubanDecisionByKey(tuban As String) Handles Tuuban.TubanDecisionByKey

    End Sub

    ''' <summary>
    ''' Loadイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Overridable Sub KenshinTabletBase_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Tuuban.KenshinName = Me.KenshinName
        Me.lbl検診名.Text = String.Format(Me.lbl検診名.Text, Me.KenshinName)
    End Sub

    ''' <summary>
    ''' 終了ボタンイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Sub 終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click
        RaiseEvent Quit()
    End Sub

#End Region

#Region "その他メソッド"
    ''' <summary>
    ''' 通番をクリア
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ClearTuban()
        Tuuban.Clear()
    End Sub


    ''' <summary>
    ''' 初期フォーカスの設定
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub initFocus()
        Tuuban.txtTuban.Focus()
        Tuuban.txtTuban.Text = String.Empty
        Tuuban.lblName.Text = String.Empty
    End Sub

#End Region

End Class