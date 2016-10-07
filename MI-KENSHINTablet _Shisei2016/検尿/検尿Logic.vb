﻿Imports System.Configuration.ConfigurationManager
Imports System.Windows.Forms
Imports Dac.Tables
Imports Dac
Imports Mi_KENSHINCommon
Imports Mi_KENSHINCommon.Common
Imports System.Text

''' <summary>
''' 検尿ロジッククラス
''' </summary>
''' <remarks></remarks>
Public Class 検尿Logic

#Region "変数"
    ''' <summary>
    ''' 呼び出し元
    ''' </summary>
    Public Property Caller As 検尿

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
    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <param name="parent"></param>
    ''' <remarks></remarks>
    Public Sub New(parent As 検尿)
        Caller = parent
        Dim Dac As DBAccess = New DBAccess

        Try
            Dac.ConnectInfo = Caller.ConnectInfo

            Syousu = Dac.GetInspectionItemMasterByPK(AppSettings("UrineSugar")).少数桁数

            Caller.lbl尿糖.Text = Dac.GetInspectionItemMasterByPK(AppSettings("UrineSugar")).入力項目表示名称
            Caller.lbl尿蛋白.Text = Dac.GetInspectionItemMasterByPK(AppSettings("UrineProtein")).入力項目表示名称
            Caller.lbl尿ウロビリ.Text = Dac.GetInspectionItemMasterByPK(AppSettings("UrineUrobilinogen")).入力項目表示名称
            Caller.lbl尿潜血.Text = Dac.GetInspectionItemMasterByPK(AppSettings("UrineOccultBleeding")).入力項目表示名称
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

        Caller.lbl尿糖値.ForeColor = Color.Black
        Caller.lbl尿蛋白値.ForeColor = Color.Black
        Caller.lbl尿ウロビリ値.ForeColor = Color.Black
        Caller.lbl尿潜血値.ForeColor = Color.Black

        Dim Dac As DBAccess = New DBAccess
        Dac.ConnectInfo = Caller.ConnectInfo

        Dim psn As 被験者 = Dac.GetPersonByTuban(tuban)
        If psn.尿検査終了.Equals("Y") Then

            Dim result = Dac.GetKensindataByPersonalID(PersonID)

            If result.Count > 0 Then
                For Each rec In result
                    If rec.項目コード1 = AppSettings("UrineSugar") Then
                        If rec.検査結果値1 Is Nothing Then
                            rec.検査結果値1 = String.Empty
                        End If
                        Caller.lbl尿糖値.Text = rec.検査結果値1.Trim
                    End If
                    If rec.項目コード2 = AppSettings("UrineSugar") Then
                        If rec.検査結果値2 Is Nothing Then
                            rec.検査結果値2 = String.Empty
                        End If
                        Caller.lbl尿糖値.Text = rec.検査結果値2.Trim
                    End If
                    If rec.項目コード3 = AppSettings("UrineSugar") Then
                        If rec.検査結果値3 Is Nothing Then
                            rec.検査結果値3 = String.Empty
                        End If
                        Caller.lbl尿糖値.Text = rec.検査結果値3.Trim
                    End If
                    If rec.項目コード4 = AppSettings("UrineSugar") Then
                        If rec.検査結果値4 Is Nothing Then
                            rec.検査結果値4 = String.Empty
                        End If
                        Caller.lbl尿糖値.Text = rec.検査結果値4.Trim
                    End If
                    If rec.項目コード5 = AppSettings("UrineSugar") Then
                        If rec.検査結果値5 Is Nothing Then
                            rec.検査結果値5 = String.Empty
                        End If
                        Caller.lbl尿糖値.Text = rec.検査結果値5.Trim
                    End If
                Next

                For Each rec In result
                    If rec.項目コード1 = AppSettings("UrineProtein") Then
                        If rec.検査結果値1 Is Nothing Then
                            rec.検査結果値1 = String.Empty
                        End If
                        Caller.lbl尿蛋白値.Text = rec.検査結果値1.Trim
                    End If
                    If rec.項目コード2 = AppSettings("UrineProtein") Then
                        If rec.検査結果値2 Is Nothing Then
                            rec.検査結果値2 = String.Empty
                        End If
                        Caller.lbl尿蛋白値.Text = rec.検査結果値2.Trim
                    End If
                    If rec.項目コード3 = AppSettings("UrineProtein") Then
                        If rec.検査結果値3 Is Nothing Then
                            rec.検査結果値3 = String.Empty
                        End If
                        Caller.lbl尿蛋白値.Text = rec.検査結果値3.Trim
                    End If
                    If rec.項目コード4 = AppSettings("UrineProtein") Then
                        If rec.検査結果値4 Is Nothing Then
                            rec.検査結果値4 = String.Empty
                        End If
                        Caller.lbl尿蛋白値.Text = rec.検査結果値4.Trim
                    End If
                    If rec.項目コード5 = AppSettings("UrineProtein") Then
                        If rec.検査結果値5 Is Nothing Then
                            rec.検査結果値5 = String.Empty
                        End If
                        Caller.lbl尿蛋白値.Text = rec.検査結果値5.Trim
                    End If
                Next

                For Each rec In result
                    If rec.項目コード1 = AppSettings("UrineOccultBleeding") Then
                        If rec.検査結果値1 Is Nothing Then
                            rec.検査結果値1 = String.Empty
                        End If
                        Caller.lbl尿潜血値.Text = rec.検査結果値1.Trim
                    End If
                    If rec.項目コード2 = AppSettings("UrineOccultBleeding") Then
                        If rec.検査結果値2 Is Nothing Then
                            rec.検査結果値2 = String.Empty
                        End If
                        Caller.lbl尿潜血値.Text = rec.検査結果値2.Trim
                    End If
                    If rec.項目コード3 = AppSettings("UrineOccultBleeding") Then
                        If rec.検査結果値3 Is Nothing Then
                            rec.検査結果値3 = String.Empty
                        End If
                        Caller.lbl尿潜血値.Text = rec.検査結果値3.Trim
                    End If
                    If rec.項目コード4 = AppSettings("UrineOccultBleeding") Then
                        If rec.検査結果値4 Is Nothing Then
                            rec.検査結果値4 = String.Empty
                        End If
                        Caller.lbl尿潜血値.Text = rec.検査結果値4.Trim
                    End If
                    If rec.項目コード5 = AppSettings("UrineOccultBleeding") Then
                        If rec.検査結果値5 Is Nothing Then
                            rec.検査結果値5 = String.Empty
                        End If
                        Caller.lbl尿潜血値.Text = rec.検査結果値5.Trim
                    End If
                Next

                For Each rec In result
                    If rec.項目コード1 = AppSettings("UrineUrobilinogen") Then
                        If rec.検査結果値1 Is Nothing Then
                            rec.検査結果値1 = String.Empty
                        End If
                        Caller.lbl尿ウロビリ値.Text = rec.検査結果値1.Trim
                    End If
                    If rec.項目コード2 = AppSettings("UrineUrobilinogen") Then
                        If rec.検査結果値2 Is Nothing Then
                            rec.検査結果値2 = String.Empty
                        End If
                        Caller.lbl尿ウロビリ値.Text = rec.検査結果値2.Trim
                    End If
                    If rec.項目コード3 = AppSettings("UrineUrobilinogen") Then
                        If rec.検査結果値3 Is Nothing Then
                            rec.検査結果値3 = String.Empty
                        End If
                        Caller.lbl尿ウロビリ値.Text = rec.検査結果値3.Trim
                    End If
                    If rec.項目コード4 = AppSettings("UrineUrobilinogen") Then
                        If rec.検査結果値4 Is Nothing Then
                            rec.検査結果値4 = String.Empty
                        End If
                        Caller.lbl尿ウロビリ値.Text = rec.検査結果値4.Trim
                    End If
                    If rec.項目コード5 = AppSettings("UrineUrobilinogen") Then
                        If rec.検査結果値5 Is Nothing Then
                            rec.検査結果値5 = String.Empty
                        End If
                        Caller.lbl尿ウロビリ値.Text = rec.検査結果値5.Trim
                    End If
                Next
            End If
        End If
        ChangeEnable(True)
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
    End Sub
#End Region

#Region "画面項目を使用不能にする"
    ''' <summary>
    ''' 画面項目を使用不能にする
    ''' </summary>
    ''' <param name="enabled"></param>
    ''' <remarks></remarks>
    Public Sub ChangeEnable(enabled As Boolean)
        Caller.lbl尿糖値.Enabled = enabled
        Caller.lbl尿蛋白値.Enabled = enabled
        Caller.lbl尿ウロビリ値.Enabled = enabled
        Caller.lbl尿潜血値.Enabled = enabled
        Caller.lbl尿糖.Enabled = enabled
        Caller.lbl尿蛋白.Enabled = enabled
        Caller.lbl尿ウロビリ.Enabled = enabled
        Caller.lbl尿潜血.Enabled = enabled
        Caller.btnRegist.Enabled = enabled

    End Sub

#End Region

#Region "すべての値をクリア"
    ''' <summary>
    ''' 値をクリアする
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ClearValues()

        Caller.lbl尿糖値.Text = "-"
        Caller.lbl尿蛋白値.Text = "-"
        Caller.lbl尿ウロビリ値.Text = "+-"
        Caller.lbl尿潜血値.Text = "-"
        Caller.btnRegist.Enabled = False

    End Sub
#End Region

#Region "各値クリック時に選択画面を表示"
    ''' <summary>
    ''' 各値クリック時に選択画面を表示
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <remarks></remarks>
    Public Sub Value_Click(sender As Label, title As String)
        Using vc As ValueChoice = New ValueChoice(sender)
            vc.lblTitle.Text = String.Format(title)
            vc.ShowDialog()
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

            Validate()

            Dim datas As List(Of DBAccess.DataContainer) = New List(Of DBAccess.DataContainer)
            Dim Dac As DBAccess = New DBAccess
            Dac.ConnectInfo = Caller.ConnectInfo

            Dim data1 As DBAccess.DataContainer = New DBAccess.DataContainer
            data1.Key = PersonID.Trim
            data1.Code = AppSettings("UrineSugar")
            data1.value = Caller.lbl尿糖値.Text
            If data1.value <> String.Empty Then
                datas.Add(data1)
            End If

            Dim data2 As DBAccess.DataContainer = New DBAccess.DataContainer
            data2.Key = PersonID.Trim
            data2.Code = AppSettings("UrineProtein")
            data2.value = Caller.lbl尿蛋白値.Text
            If data2.value <> String.Empty Then
                datas.Add(data2)
            End If

            Dim data3 As DBAccess.DataContainer = New DBAccess.DataContainer
            data3.Key = PersonID.Trim
            data3.Code = AppSettings("UrineUrobilinogen")
            data3.value = Caller.lbl尿ウロビリ値.Text
            If data3.value <> String.Empty Then
                datas.Add(data3)
            End If

            Dim data4 As DBAccess.DataContainer = New DBAccess.DataContainer
            data4.Key = PersonID.Trim
            data4.Code = AppSettings("UrineOccultBleeding")
            data4.value = Caller.lbl尿潜血値.Text
            If data4.value <> String.Empty Then
                datas.Add(data4)
            End If

            Dac.RegistKenshinData(datas)
            Dac.UpdateKenshinStatus(CommonConst.KENNYOU, PersonID.Trim)

            'Using msgwin As MessageWindow = New MessageWindow()
            '    msgwin.IconImage = "Information"
            '    msgwin.MessageString = CommonConst.REGIST_COMP
            '    msgwin.Caller = Me
            '    msgwin.ShowDialog()
            'End Using
            ClearValues()
            Caller.ClearTuban()
            ChangeEnable(False)

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
    Public Sub Validate()

        If Caller.lbl尿ウロビリ値.Text.Equals(String.Empty) And
            Caller.lbl尿潜血値.Text.Equals(String.Empty) And
            Caller.lbl尿蛋白値.Text.Equals(String.Empty) And
            Caller.lbl尿糖値.Text.Equals(String.Empty) Then
            Throw New Common.No_InputException("何も入力されていません。")
        End If

    End Sub

#End Region

#Region "受診者がいるか？"
    ''' <summary>
    ''' 受診者がいるか？
    ''' </summary>
    ''' <param name="caller"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Load(caller As 検尿) As Boolean
        Dim Dac As DBAccess = New DBAccess
        Dim ret As Boolean = True
        Dac.ConnectInfo = caller.ConnectInfo

        If Not Dac.IsTtherePerson(AppSettings("UrineSugar")) Then
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

    ''' <summary>
    ''' 検診対象者が指定された検診項目を受診するかどうか
    ''' </summary>
    ''' <param name="id"></param>
    ''' <remarks></remarks>
    Friend Sub IsExist(id As String)
        Dim Dac As DBAccess = New DBAccess
        Dac.ConnectInfo = Caller.ConnectInfo

        Dim ret As Boolean
        ret = Dac.IsInspectionCode(id, AppSettings("UrineProtein"))
        Caller.lbl尿蛋白.Enabled = ret
        Caller.lbl尿蛋白値.Enabled = ret
        If Not ret Then
            Caller.lbl尿蛋白値.Text = String.Empty
        End If

        ret = Dac.IsInspectionCode(id, AppSettings("UrineSugar"))
        Caller.lbl尿糖.Enabled = ret
        Caller.lbl尿糖値.Enabled = ret
        If Not ret Then
            Caller.lbl尿糖値.Text = String.Empty
        End If

        ret = Dac.IsInspectionCode(id, AppSettings("UrineUrobilinogen"))
        Caller.lbl尿ウロビリ.Enabled = ret
        Caller.lbl尿ウロビリ値.Enabled = ret
        If Not ret Then
            Caller.lbl尿ウロビリ値.Text = String.Empty
        End If

        ret = Dac.IsInspectionCode(id, AppSettings("UrineOccultBleeding"))
        Caller.lbl尿潜血.Enabled = ret
        Caller.lbl尿潜血値.Enabled = ret
        If Not ret Then
            Caller.lbl尿潜血値.Text = String.Empty
        End If
    End Sub

#End Region
End Class
