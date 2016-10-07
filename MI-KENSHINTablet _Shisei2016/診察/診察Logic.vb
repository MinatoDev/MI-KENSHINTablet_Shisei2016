﻿Imports System.Configuration.ConfigurationManager
Imports Dac
Imports Dac.Tables
Imports Mi_KENSHINCommon

''' <summary>
''' 診察Logicクラス
''' </summary>
''' <remarks></remarks>
Public Class 診察Logic

#Region "変数"
    ''' <summary>
    ''' 呼び出し元
    ''' </summary>
    Public Property Caller As 診察

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
    Public Sub New(parent As 診察)
        Caller = parent
        Dim Dac As DBAccess = New DBAccess

        Try
            Dac.ConnectInfo = Caller.ConnectInfo
            Caller.lbl診察.Text = Dac.GetInspectionItemMasterByPK(AppSettings("MedicalExamination")).入力項目表示名称.ToString.Replace("○", "")
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
        If psn.診察終了.Equals("Y") Then

            Dim result = Dac.GetKensindataByPersonalID(PersonID)

            Dim wkfont As System.Drawing.Font = New Font("MS UI Gothic", 72)
            If result.Count > 0 Then
                For Each rec In result
                    If rec.項目コード1 = AppSettings("MedicalExamination") Then
                        Caller.lbl所見値.Text = rec.検査結果値1.Trim
                    End If
                    If rec.項目コード2 = AppSettings("MedicalExamination") Then
                        Caller.lbl所見値.Text = rec.検査結果値2.Trim
                    End If
                    If rec.項目コード3 = AppSettings("MedicalExamination") Then
                        Caller.lbl所見値.Text = rec.検査結果値3.Trim
                    End If
                    If rec.項目コード4 = AppSettings("MedicalExamination") Then
                        Caller.lbl所見値.Text = rec.検査結果値4.Trim
                    End If
                    If rec.項目コード5 = AppSettings("MedicalExamination") Then
                        Caller.lbl所見値.Text = rec.検査結果値5.Trim
                    End If
                Next
                If Caller.lbl所見値.Text = "ｼﾖｹﾝﾅｼ" Then
                    Caller.lbl所見値.Text = "所見なし"
                Else
                    Caller.lbl所見値.Text = "所見あり"
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
        Caller.lbl所見値.Enabled = enabled
        Caller.lbl診察.Enabled = enabled
        Caller.btnRegist.Enabled = enabled
    End Sub

#End Region

#Region "すべての値をクリア"
    ''' <summary>
    ''' 値をクリアする
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ClearValues()
        Caller.lbl所見値.Text = String.Empty
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
            sc.KenshinName = "診察"
            sc.ItemName = Caller.lbl診察.Text

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

        If Caller.lbl所見値.Text.Equals(String.Empty) Then
            Throw New Common.No_InputException(Caller.lbl診察.Text + "が入力されていません。")
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
            data1.Code = AppSettings("MedicalExamination")
            If Caller.lbl所見値.Text.Equals("所見あり") Then
                data1.value = "ｼﾖｹﾝｱﾘ"
            Else
                data1.value = "ｼﾖｹﾝﾅｼ"
            End If
            datas.Add(data1)

            Dac.RegistKenshinData(datas)
            Dac.UpdateKenshinStatus(CommonConst.SHINSATSU, PersonID.Trim)

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
    Public Function Load(caller As 診察) As Boolean
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

        If Dac.IsInspectionCode(id, AppSettings("MedicalExamination")) Then
            Return True
        End If
        Return False
    End Function
End Class
