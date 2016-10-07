Imports System.Configuration
Imports Mi_KENSHINCommon

''' <summary>
''' ランチャークラス
''' </summary>
''' <remarks></remarks>
Public Class Launcher

#Region "コンストラクタ"
    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Me.WindowState = FormWindowState.Maximized

    End Sub
#End Region

#Region "イベント"
    ''' <summary>
    ''' キャンセルクリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' ピクチャーボックスクリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub pic_Click(sender As Object, e As EventArgs) Handles picKennyou.Click, picFukui.Click, picGakkou.Click, picKetsuatu.Click, picShinsatsu.Click, picShiryoku.Click, picChyouryoku.Click, pic握力.Click, pic身長.Click
        Dim cuurDir As String = System.IO.Directory.GetCurrentDirectory()
        Dim exeDir As String = "\..\..\..\[##]\bin\Release\[##].exe"

        Select Case DirectCast(sender, PictureBox).Name
            Case "picKennyou"
                exeDir = exeDir.Replace("[##]", "検尿")
            Case "picKetsuatu"
                exeDir = exeDir.Replace("[##]", "血圧")
            Case "picChyouryoku"
                exeDir = exeDir.Replace("[##]", "聴力")
            Case "picFukui"
                exeDir = exeDir.Replace("[##]", "腹囲")
            Case "picShinsatsu"
                exeDir = exeDir.Replace("[##]", "診察")
            Case "picShiryoku"
                exeDir = exeDir.Replace("[##]", "視力")
            Case "picGakkou"
                exeDir = exeDir.Replace("[##]", "学校視力")
            Case "pic握力"
                exeDir = exeDir.Replace("[##]", "握力")
            Case "pic身長"
                exeDir = exeDir.Replace("[##]", "身長体重")
        End Select

        Try
            Me.Visible = True
            Login.Visible = False
            Using p As System.Diagnostics.Process = System.Diagnostics.Process.Start(cuurDir + exeDir)
                p.WaitForExit()
            End Using
            Me.Visible = True
            Login.Visible = False
        Catch ex As Exception

        End Try
    End Sub

#End Region

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click

        Using configEdit = New Setting
            configEdit.ShowDialog()
        End Using
    End Sub
End Class