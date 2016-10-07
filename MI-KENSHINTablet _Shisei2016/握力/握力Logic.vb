﻿Imports System.Configuration.ConfigurationManager
Imports System.Windows.Forms
Imports Dac.Tables
Imports Dac
Imports Mi_KENSHINCommon
Imports Mi_KENSHINCommon.Common
Imports System.Text

Public Class 握力Logic

#Region "変数"
    ''' <summary>
    ''' 呼び出し元
    ''' </summary>
    Public Property Caller As 握力

    ''' <summary>
    ''' 個人ID
    ''' </summary>
    Public Property PersonID As String

    ''' <summary>
    ''' MessageWindowの応答
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Result As String

    ''' <summary>
    ''' 少数桁数
    ''' </summary>
    Public Property Syousu As Nullable(Of Integer)


#End Region

#Region "コンストラクタ"
    Public Sub New(parent As 握力)
        Caller = parent
        Dim Dac As DBAccess = New DBAccess

        Try
            Dac.ConnectInfo = Caller.ConnectInfo

            Syousu = Dac.GetInspectionItemMasterByPK(AppSettings("GripR")).少数桁数

            Caller.lbl握力右.Text = Dac.GetInspectionItemMasterByPK(AppSettings("GripR")).入力項目表示名称
            Caller.lbl握力左.Text = Dac.GetInspectionItemMasterByPK(AppSettings("GripL")).入力項目表示名称
            Caller.lbl握力右単位.Text = Dac.GetInspectionItemMasterByPK(AppSettings("GripR")).単位名称
            Caller.lbl握力左単位.Text = Dac.GetInspectionItemMasterByPK(AppSettings("GripL")).単位名称

            ChangeEnable(False)
            ClearValues()

        Catch ex As Exception
            Throw
        End Try
    End Sub
#End Region

#Region "初期表示"
    ''' <summary>
    ''' データがある場合は初期表示
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub InitDisplay(tuban As String)

        Caller.lbl握力右.ForeColor = Color.Black
        Caller.lbl握力左.ForeColor = Color.Black

        Dim Dac As DBAccess = New DBAccess
        Dac.ConnectInfo = Caller.ConnectInfo

        Dim psn As 被験者 = Dac.GetPersonByTuban(tuban)
        If psn.握力終了.Equals("Y") Then

            Dim result = Dac.GetKensindataByPersonalID(PersonID)

            If result.Count > 0 Then
                Dim wk() As String
                For Each rec In result
                    If rec.項目コード1 = AppSettings("GripR") Then
                        wk = rec.検査結果値1.Trim.Split(".")
                        Caller.lbl握力右値.Text = rec.検査結果値1.Trim
                        Caller.txt握力右値1.Text = wk(0)
                        If wk.Length = 2 Then
                            Caller.txt握力右値2.Text = wk(1)
                        Else
                            Caller.txt握力右値2.Text = "0"
                        End If
                        Exit For
                    End If
                    If rec.項目コード2 = AppSettings("GripR") Then
                        wk = rec.検査結果値2.Trim.Split(".")
                        Caller.lbl握力右値.Text = rec.検査結果値2.Trim
                        Caller.txt握力右値1.Text = wk(0)
                        If wk.Length = 2 Then
                            Caller.txt握力右値2.Text = wk(1)
                        Else
                            Caller.txt握力右値2.Text = "0"
                        End If
                        Exit For
                    End If
                    If rec.項目コード3 = AppSettings("GripR") Then
                        wk = rec.検査結果値3.Trim.Split(".")
                        Caller.lbl握力右値.Text = rec.検査結果値3.Trim
                        Caller.txt握力右値1.Text = wk(0)
                        If wk.Length = 2 Then
                            Caller.txt握力右値2.Text = wk(1)
                        Else
                            Caller.txt握力右値2.Text = "0"
                        End If
                        Exit For
                    End If
                    If rec.項目コード4 = AppSettings("GripR") Then
                        wk = rec.検査結果値4.Trim.Split(".")
                        Caller.lbl握力右値.Text = rec.検査結果値4.Trim
                        Caller.txt握力右値1.Text = wk(0)
                        If wk.Length = 2 Then
                            Caller.txt握力右値2.Text = wk(1)
                        Else
                            Caller.txt握力右値2.Text = "0"
                        End If
                        Exit For
                    End If
                    If rec.項目コード5 = AppSettings("GripR") Then
                        wk = rec.検査結果値5.Trim.Split(".")
                        Caller.lbl握力右値.Text = rec.検査結果値5.Trim
                        Caller.txt握力右値1.Text = wk(0)
                        If wk.Length = 2 Then
                            Caller.txt握力右値2.Text = wk(1)
                        Else
                            Caller.txt握力右値2.Text = "0"
                        End If
                        Exit For
                    End If
                Next

                For Each rec In result
                    If rec.項目コード1 = AppSettings("GripL") Then
                        wk = rec.検査結果値1.Trim.Split(".")
                        Caller.lbl握力左値.Text = rec.検査結果値1.Trim
                        Caller.txt握力左値1.Text = wk(0)
                        If wk.Length = 2 Then
                            Caller.txt握力左値2.Text = wk(1)
                        Else
                            Caller.txt握力左値2.Text = "0"
                        End If
                        Exit For
                    End If
                    If rec.項目コード2 = AppSettings("GripL") Then
                        wk = rec.検査結果値2.Trim.Split(".")
                        Caller.lbl握力左値.Text = rec.検査結果値2.Trim
                        Caller.txt握力左値1.Text = wk(0)
                        If wk.Length = 2 Then
                            Caller.txt握力左値2.Text = wk(1)
                        Else
                            Caller.txt握力左値2.Text = "0"
                        End If
                        Exit For
                    End If
                    If rec.項目コード3 = AppSettings("GripL") Then
                        wk = rec.検査結果値3.Trim.Split(".")
                        Caller.lbl握力左値.Text = rec.検査結果値3.Trim
                        Caller.txt握力左値1.Text = wk(0)
                        If wk.Length = 2 Then
                            Caller.txt握力左値2.Text = wk(1)
                        Else
                            Caller.txt握力左値2.Text = "0"
                        End If
                        Exit For
                    End If
                    If rec.項目コード4 = AppSettings("GripL") Then
                        wk = rec.検査結果値4.Trim.Split(".")
                        Caller.lbl握力左値.Text = rec.検査結果値4.Trim
                        Caller.txt握力左値1.Text = wk(0)
                        If wk.Length = 2 Then
                            Caller.txt握力左値2.Text = wk(1)
                        Else
                            Caller.txt握力左値2.Text = "0"
                        End If
                        Exit For
                    End If
                    If rec.項目コード5 = AppSettings("GripL") Then
                        wk = rec.検査結果値5.Trim.Split(".")
                        Caller.lbl握力左値.Text = rec.検査結果値5.Trim
                        Caller.txt握力左値1.Text = wk(0)
                        If wk.Length = 2 Then
                            Caller.txt握力左値2.Text = wk(1)
                        Else
                            Caller.txt握力左値2.Text = "0"
                        End If
                        Exit For
                    End If
                Next
            End If
        End If
        ChangeEnable(True)
    End Sub

#End Region

#Region "画面項目を使用不能にする"
    ''' <summary>
    ''' 画面項目を使用不能にする
    ''' </summary>
    ''' <param name="enabled"></param>
    ''' <remarks></remarks>
    Public Sub ChangeEnable(enabled As Boolean)
        Caller.lbl握力右.Enabled = enabled
        Caller.lbl握力左.Enabled = enabled
        Caller.lbl握力右単位.Enabled = enabled
        Caller.lbl握力左単位.Enabled = enabled
        Caller.btnRegist.Enabled = enabled

        Caller.txt握力右値1.Enabled = enabled
        Caller.txt握力右値2.Enabled = enabled
        Caller.txt握力左値1.Enabled = enabled
        Caller.txt握力左値2.Enabled = enabled
    End Sub

#End Region

#Region "すべての値をクリア"
    ''' <summary>
    ''' 値をクリアする
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ClearValues()
        Caller.lbl握力右値.Text = String.Empty
        Caller.lbl握力左値.Text = String.Empty
        Caller.txt握力右値1.Text = String.Empty
        Caller.txt握力左値1.Text = String.Empty
        Caller.txt握力右値2.Text = String.Empty
        Caller.txt握力左値2.Text = String.Empty
        Caller.btnRegist.Enabled = False
    End Sub
#End Region

#Region "通番確定ロジック"
    ''' <summary>
    ''' 通番確定ロジック
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub TubanDecision(id As String, tuban As String)
        PersonID = id
        Caller.PersonID = PersonID
        ChangeEnable(True)
        Caller.txt握力右値1.Focus()
    End Sub
#End Region

#Region "各値クリック時にテンキーを表示"
    ''' <summary>
    ''' 各値クリック時にテンキーを表示
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <remarks></remarks>
    Public Sub Value_Click(sender As Label)
        Using tenkey As Tenkey = New Tenkey()
            If sender.Name = "lbl握力右値" Then
                tenkey.ItemName = Caller.lbl握力右.Text
            Else
                tenkey.ItemName = Caller.lbl握力左.Text
            End If
            tenkey.Syousu = 1
            tenkey.Seisu = 3
            tenkey.Cntl = sender
            tenkey.ShowDialog()
        End Using
    End Sub
#End Region

#Region "検診値を登録する"
    ''' <summary>
    ''' DBに登録する
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Regist()
        Try
            If Validate() Then

                Dim datas As List(Of DBAccess.DataContainer) = New List(Of DBAccess.DataContainer)
                Dim Dac As DBAccess = New DBAccess
                Dac.ConnectInfo = Caller.ConnectInfo

                Dim data1 As DBAccess.DataContainer = New DBAccess.DataContainer
                data1.Key = PersonID.Trim
                data1.Code = AppSettings("GripR")
                data1.value = Caller.lbl握力右値.Text
                datas.Add(data1)

                Dim data2 As DBAccess.DataContainer = New DBAccess.DataContainer
                data2.Key = PersonID.Trim
                data2.Code = AppSettings("GripL")
                data2.value = Caller.lbl握力左値.Text
                datas.Add(data2)

                Dac.RegistKenshinData(datas)
                Dac.UpdateKenshinStatus(CommonConst.AKURYOKU, PersonID.Trim)

                'Using msgwin As MessageWindow = New MessageWindow()
                '    msgwin.IconImage = "Information"
                '    msgwin.MessageString = CommonConst.REGIST_COMP
                '    msgwin.Caller = Me
                '    msgwin.ShowDialog()
                'End Using
                ClearValues()
                Caller.ClearTuban()
                ChangeEnable(False)
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

#End Region

#Region "入力チェック"
    ''' <summary>
    ''' 入力チェック
    ''' </summary>
    ''' <remarks></remarks>
    Public Function Validate() As Boolean

        ' 未入力
        If Caller.lbl握力右値.Text.Equals(String.Empty) Then
            Throw New No_InputException(Caller.lbl握力右.Text + "が入力されていません。")
        End If
        If Caller.lbl握力左値.Text.Equals(String.Empty) Then
            Throw New No_InputException(Caller.lbl握力左値.Text + "が入力されていません。")
        End If

        Return True
    End Function
#End Region

#Region "数字だけ入力可"
    Friend Function KeyInputValidation(tatget As Mi_TextBox, code As String) As Boolean
        Dim ret As Boolean = True

        Select Case code
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"   '0～9
            Case ControlChars.Back
            Case ControlChars.Cr, "."
                tatget.NextFocus.Focus()
                ret = False
            Case Else
                ret = False
        End Select

        Return ret
    End Function
#End Region

#Region "データの同期"
    ''' <summary>
    ''' データの同期
    ''' </summary>
    ''' <remarks></remarks>
    Friend Sub 腹囲値_Validated()
        Caller.lbl握力右値.Text = Caller.txt握力右値1.Text & "." & IIf(Caller.txt握力右値2.Text = String.Empty, "0", Caller.txt握力右値2.Text)
        Caller.lbl握力左値.Text = Caller.txt握力左値1.Text & "." & IIf(Caller.txt握力左値2.Text = String.Empty, "0", Caller.txt握力左値2.Text)
    End Sub
#End Region

#Region "受診者がいるか？"
    ''' <summary>
    ''' 受診者がいるか？
    ''' </summary>
    ''' <param name="caller"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Load(caller As 握力) As Boolean
        Dim Dac As DBAccess = New DBAccess
        Dim ret As Boolean = True
        Dac.ConnectInfo = caller.ConnectInfo
        If Not Dac.IsTtherePerson(AppSettings("GripR")) Then
            Using msgwin As MessageWindow = New MessageWindow
                msgwin.IconImage = CommonConst.EXCLAMATION
                msgwin.ButtonStyle = CommonConst.OK_ONLY
                msgwin.MessageString = CommonConst.NO_PERSON
                msgwin.Caller = caller
                msgwin.ShowDialog()
                ret = False
            End Using
        End If
        Return ret
    End Function

#End Region

    ''' <summary>
    ''' 検診対象者が指定された検診項目を受診するかどうか
    ''' </summary>
    ''' <param name="id"></param>
    ''' <remarks></remarks>
    Friend Function IsExist(id As String) As Boolean
        Dim Dac As DBAccess = New DBAccess
        Dac.ConnectInfo = Caller.ConnectInfo

        If Dac.IsInspectionCode(id, AppSettings("GripR")) OrElse Dac.IsInspectionCode(id, AppSettings("GripL")) Then
            Return True
        End If
        Return False
    End Function

End Class
