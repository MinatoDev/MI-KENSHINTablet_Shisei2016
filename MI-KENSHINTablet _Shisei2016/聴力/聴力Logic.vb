﻿Imports System.Configuration.ConfigurationManager
Imports Dac
Imports Dac.Tables
Imports Mi_KENSHINCommon

''' <summary>
''' 聴力ロジッククラス
''' </summary>
''' <remarks></remarks>
Public Class 聴力Logic
#Region "変数"
    ''' <summary>
    ''' 呼び出し元
    ''' </summary>
    Public Property Caller As 聴力

    ''' <summary>
    ''' 個人ID
    ''' </summary>
    Public Property PersonID As String

    ''' <summary>
    ''' メッセージの戻り
    ''' </summary>
    Public Property Result As String

#End Region

#Region "コンストラクタ"
    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <param name="parent"></param>
    ''' <remarks></remarks>
    Public Sub New(parent As 聴力)
        Caller = parent
        Dim Dac As DBAccess = New DBAccess

        Try
            Dac.ConnectInfo = Caller.ConnectInfo
            Caller.lbl聴力R1000.Text = Dac.GetInspectionItemMasterByPK(AppSettings("HearingAbilityR1000")).入力項目表示名称.ToString
            Caller.lbl聴力L1000.Text = Dac.GetInspectionItemMasterByPK(AppSettings("HearingAbilityL1000")).入力項目表示名称.ToString
            Caller.lbl聴力R4000.Text = Dac.GetInspectionItemMasterByPK(AppSettings("HearingAbilityR4000")).入力項目表示名称.ToString
            Caller.lbl聴力L4000.Text = Dac.GetInspectionItemMasterByPK(AppSettings("HearingAbilityL4000")).入力項目表示名称.ToString
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
        Dim Dac As DBAccess = New DBAccess
        Dac.ConnectInfo = Caller.ConnectInfo

        Dim psn As 被験者 = Dac.GetPersonByTuban(tuban)
        If psn.聴力終了.Equals("Y") Then

            Dim result = Dac.GetKensindataByPersonalID(PersonID)

            If result.Count > 0 Then
                For Each rec In result
                    If rec.項目コード1 = AppSettings("HearingAbilityR1000") Then
                        Caller.lbl聴力R1000値.Text = rec.検査結果値1.Trim
                    End If
                    If rec.項目コード2 = AppSettings("HearingAbilityR1000") Then
                        Caller.lbl聴力R1000値.Text = rec.検査結果値2.Trim
                    End If
                    If rec.項目コード3 = AppSettings("HearingAbilityR1000") Then
                        Caller.lbl聴力R1000値.Text = rec.検査結果値3.Trim
                    End If
                    If rec.項目コード4 = AppSettings("HearingAbilityR1000") Then
                        Caller.lbl聴力R1000値.Text = rec.検査結果値4.Trim
                    End If
                    If rec.項目コード5 = AppSettings("HearingAbilityR1000") Then
                        Caller.lbl聴力R1000値.Text = rec.検査結果値5.Trim
                    End If
                Next
                If Caller.lbl聴力R1000値.Text = "ｼﾖｹﾝﾅｼ" Then
                    Caller.lbl聴力R1000値.Text = "所見なし"
                Else
                    If Caller.lbl聴力R1000値.Text = String.Empty Then
                        Caller.lbl聴力R1000値.Text = String.Empty
                    Else
                        Caller.lbl聴力R1000値.Text = "所見あり"
                    End If
                End If

                For Each rec In result
                    If rec.項目コード1 = AppSettings("HearingAbilityL1000") Then
                        Caller.lbl聴力L1000値.Text = rec.検査結果値1.Trim
                    End If
                    If rec.項目コード2 = AppSettings("HearingAbilityL1000") Then
                        Caller.lbl聴力L1000値.Text = rec.検査結果値2.Trim
                    End If
                    If rec.項目コード3 = AppSettings("HearingAbilityL1000") Then
                        Caller.lbl聴力L1000値.Text = rec.検査結果値3.Trim
                    End If
                    If rec.項目コード4 = AppSettings("HearingAbilityL1000") Then
                        Caller.lbl聴力L1000値.Text = rec.検査結果値4.Trim
                    End If
                    If rec.項目コード5 = AppSettings("HearingAbilityL1000") Then
                        Caller.lbl聴力L1000値.Text = rec.検査結果値5.Trim
                    End If
                Next
                If Caller.lbl聴力L1000値.Text = "ｼﾖｹﾝﾅｼ" Then
                    Caller.lbl聴力L1000値.Text = "所見なし"
                Else
                    If Caller.lbl聴力L1000値.Text = String.Empty Then
                        Caller.lbl聴力L1000値.Text = String.Empty
                    Else
                        Caller.lbl聴力L1000値.Text = "所見あり"
                    End If
                End If

                For Each rec In result
                    If rec.項目コード1 = AppSettings("HearingAbilityR4000") Then
                        Caller.lbl聴力R4000値.Text = rec.検査結果値1.Trim
                    End If
                    If rec.項目コード2 = AppSettings("HearingAbilityR4000") Then
                        Caller.lbl聴力R4000値.Text = rec.検査結果値2.Trim
                    End If
                    If rec.項目コード3 = AppSettings("HearingAbilityR4000") Then
                        Caller.lbl聴力R4000値.Text = rec.検査結果値3.Trim
                    End If
                    If rec.項目コード4 = AppSettings("HearingAbilityR4000") Then
                        Caller.lbl聴力R4000値.Text = rec.検査結果値4.Trim
                    End If
                    If rec.項目コード5 = AppSettings("HearingAbilityR4000") Then
                        Caller.lbl聴力R4000値.Text = rec.検査結果値5.Trim
                    End If
                Next
                If Caller.lbl聴力R4000値.Text = "ｼﾖｹﾝﾅｼ" Then
                    Caller.lbl聴力R4000値.Text = "所見なし"
                Else
                    If Caller.lbl聴力R4000値.Text = String.Empty Then
                        Caller.lbl聴力R4000値.Text = String.Empty
                    Else
                        Caller.lbl聴力R4000値.Text = "所見あり"
                    End If
                End If

                For Each rec In result
                    If rec.項目コード1 = AppSettings("HearingAbilityL4000") Then
                        Caller.lbl聴力L4000値.Text = rec.検査結果値1.Trim
                    End If
                    If rec.項目コード2 = AppSettings("HearingAbilityL4000") Then
                        Caller.lbl聴力L4000値.Text = rec.検査結果値2.Trim
                    End If
                    If rec.項目コード3 = AppSettings("HearingAbilityL4000") Then
                        Caller.lbl聴力L4000値.Text = rec.検査結果値3.Trim
                    End If
                    If rec.項目コード4 = AppSettings("HearingAbilityL4000") Then
                        Caller.lbl聴力L4000値.Text = rec.検査結果値4.Trim
                    End If
                    If rec.項目コード5 = AppSettings("HearingAbilityL4000") Then
                        Caller.lbl聴力L4000値.Text = rec.検査結果値5.Trim
                    End If
                Next
                If Caller.lbl聴力L4000値.Text = "ｼﾖｹﾝﾅｼ" Then
                    Caller.lbl聴力L4000値.Text = "所見なし"
                Else
                    If Caller.lbl聴力L4000値.Text = String.Empty Then
                        Caller.lbl聴力L4000値.Text = String.Empty
                    Else
                        Caller.lbl聴力L4000値.Text = "所見あり"
                    End If
                End If
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
        Caller.lbl聴力R1000値.Enabled = enabled
        Caller.lbl聴力R1000.Enabled = enabled
        Caller.lbl聴力L1000値.Enabled = enabled
        Caller.lbl聴力L1000.Enabled = enabled
        Caller.lbl聴力R4000値.Enabled = enabled
        Caller.lbl聴力R4000.Enabled = enabled
        Caller.lbl聴力L4000値.Enabled = enabled
        Caller.lbl聴力L4000.Enabled = enabled
        Caller.btnRegist.Enabled = enabled
    End Sub

#End Region

#Region "すべての値をクリア"
    ''' <summary>
    ''' 値をクリアする
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ClearValues()
        Caller.lbl聴力R1000値.Text = "所見なし"
        Caller.lbl聴力L1000値.Text = "所見なし"
        Caller.lbl聴力R4000値.Text = "所見なし"
        Caller.lbl聴力L4000値.Text = "所見なし"
        Caller.btnRegist.Enabled = False
    End Sub
#End Region

#Region "各値クリック時に選択画面を表示"
    ''' <summary>
    ''' 各値クリック時に選択画面を表示
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <remarks></remarks>
    Public Sub Value_Click(sender As Label)
        Using sc As btnClear = New btnClear(sender)
            sc.KenshinName = "聴力"

            Select Case sender.Name
                Case Caller.lbl聴力R1000値.Name
                    sc.ItemName = Caller.lbl聴力R1000.Text
                Case Caller.lbl聴力R4000値.Name
                    sc.ItemName = Caller.lbl聴力R4000.Text
                Case Caller.lbl聴力L1000値.Name
                    sc.ItemName = Caller.lbl聴力L1000.Text
                Case Caller.lbl聴力L4000値.Name
                    sc.ItemName = Caller.lbl聴力L4000.Text
            End Select
            sc.ShowDialog()
        End Using

    End Sub

#End Region

#Region "入力チェック"
    ''' <summary>
    ''' 入力チェック
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Validate()

        If Caller.lbl聴力R1000値.Text.Equals(String.Empty) And
           Caller.lbl聴力L1000値.Text.Equals(String.Empty) And
           Caller.lbl聴力R4000値.Text.Equals(String.Empty) And
           Caller.lbl聴力L4000値.Text.Equals(String.Empty) Then
            Throw New Common.No_InputException("何も入力されていません。")
        End If

    End Sub

#End Region

#Region "検診値を登録する"
    ''' <summary>
    ''' DBに登録する
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Regist()
        Try
            ' 入力チェック
            Validate()

            Dim datas As List(Of DBAccess.DataContainer) = New List(Of DBAccess.DataContainer)
            Dim Dac As DBAccess = New DBAccess
            Dac.ConnectInfo = Caller.ConnectInfo

            Dim data1 As DBAccess.DataContainer = New DBAccess.DataContainer
            data1.Key = PersonID.Trim
            data1.Code = AppSettings("HearingAbilityR1000")
            If Caller.lbl聴力R1000値.Text.Equals("所見あり") Then
                data1.value = "ｼﾖｹﾝｱﾘ"
            Else
                If Caller.lbl聴力R1000値.Text.Equals(String.Empty) Then
                    data1.value = String.Empty
                Else
                    data1.value = "ｼﾖｹﾝﾅｼ"
                End If
            End If
            datas.Add(data1)


            Dim data2 As DBAccess.DataContainer = New DBAccess.DataContainer
            data2.Key = PersonID.Trim
            data2.Code = AppSettings("HearingAbilityL1000")
            If Caller.lbl聴力L1000値.Text.Equals("所見あり") Then
                data2.value = "ｼﾖｹﾝｱﾘ"
            Else
                If Caller.lbl聴力L1000値.Text.Equals(String.Empty) Then
                    data2.value = String.Empty
                Else
                    data2.value = "ｼﾖｹﾝﾅｼ"
                End If
            End If
            datas.Add(data2)

            Dim data3 As DBAccess.DataContainer = New DBAccess.DataContainer
            data3.Key = PersonID.Trim
            data3.Code = AppSettings("HearingAbilityR4000")
            If Caller.lbl聴力R4000値.Text.Equals("所見あり") Then
                data3.value = "ｼﾖｹﾝｱﾘ"
            Else
                If Caller.lbl聴力R4000値.Text.Equals(String.Empty) Then
                    data3.value = String.Empty
                Else
                    data3.value = "ｼﾖｹﾝﾅｼ"
                End If
            End If
            datas.Add(data3)

            Dim data4 As DBAccess.DataContainer = New DBAccess.DataContainer
            data4.Key = PersonID.Trim
            data4.Code = AppSettings("HearingAbilityL4000")
            If Caller.lbl聴力L4000値.Text.Equals("所見あり") Then
                data4.value = "ｼﾖｹﾝｱﾘ"
            Else
                If Caller.lbl聴力L4000値.Text.Equals(String.Empty) Then
                    data4.value = String.Empty
                Else
                    data4.value = "ｼﾖｹﾝﾅｼ"
                End If
            End If
            datas.Add(data4)


            Dac.RegistKenshinData(datas)
            Dac.UpdateKenshinStatus(CommonConst.CHYOURYOKU, PersonID.Trim)

            'Using msgwin As MessageWindow = New MessageWindow()
            '    msgwin.IconImage = CommonConst.INFO
            '    msgwin.ButtonStyle = CommonConst.OK_ONLY
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

#Region "受診者がいるか？"
    ''' <summary>
    ''' 受診者がいるか？
    ''' </summary>
    ''' <param name="caller"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Load(caller As 聴力) As Boolean
        Dim Dac As DBAccess = New DBAccess
        Dim ret As Boolean = True
        Dac.ConnectInfo = caller.ConnectInfo
        If Not Dac.IsTtherePerson(AppSettings("MedicalExamination")) Then
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

        Dim ret As Boolean
        If Dac.IsInspectionCode(id, AppSettings("HearingAbilityR1000")) OrElse Dac.IsInspectionCode(id, AppSettings("HearingAbilityL1000")) OrElse Dac.IsInspectionCode(id, AppSettings("HearingAbilityR4000")) OrElse Dac.IsInspectionCode(id, AppSettings("HearingAbilityL4000")) Then
            Return True
        End If
        Return False
    End Function
End Class
