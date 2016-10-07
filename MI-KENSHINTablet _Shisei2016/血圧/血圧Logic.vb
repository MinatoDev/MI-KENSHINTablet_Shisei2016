﻿Imports System.Configuration.ConfigurationManager
Imports System.Windows.Forms
Imports Dac.Tables
Imports Dac
Imports Mi_KENSHINCommon
Imports Mi_KENSHINCommon.Common
Imports System.Text

''' <summary>
''' 血圧Logicクラス
''' </summary>
''' <remarks></remarks>
Public Class 血圧Logic

#Region "変数"
    ''' <summary>
    ''' 呼び出し元
    ''' </summary>
    Public Property Caller As 血圧

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
    Public Sub New(parent As 血圧)
        Caller = parent
        Dim Dac As DBAccess = New DBAccess

        Try
            Dac.ConnectInfo = Caller.ConnectInfo

            Syousu = Dac.GetInspectionItemMasterByPK(AppSettings("BloodPressureH1")).少数桁数

            Caller.lbl最高血圧1.Text = Dac.GetInspectionItemMasterByPK(AppSettings("BloodPressureH1")).入力項目表示名称
            Caller.lbl最高血圧単位1.Text = Dac.GetInspectionItemMasterByPK(AppSettings("BloodPressureH1")).単位名称
            Caller.lbl最高血圧2.Text = Dac.GetInspectionItemMasterByPK(AppSettings("BloodPressureH2")).入力項目表示名称
            Caller.lbl最高血圧単位2.Text = Dac.GetInspectionItemMasterByPK(AppSettings("BloodPressureH2")).単位名称
            Caller.lbl最低血圧1.Text = Dac.GetInspectionItemMasterByPK(AppSettings("BloodPressureL1")).入力項目表示名称
            Caller.lbl最低血圧単位1.Text = Dac.GetInspectionItemMasterByPK(AppSettings("BloodPressureL1")).単位名称
            Caller.lbl最低血圧2.Text = Dac.GetInspectionItemMasterByPK(AppSettings("BloodPressureL2")).入力項目表示名称
            Caller.lbl最低血圧単位2.Text = Dac.GetInspectionItemMasterByPK(AppSettings("BloodPressureL2")).単位名称

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

        Caller.lbl最高血圧値1.ForeColor = Color.Black
        Caller.lbl最低血圧値1.ForeColor = Color.Black
        Caller.lbl最高血圧値2.ForeColor = Color.Black
        Caller.lbl最低血圧値2.ForeColor = Color.Black

        Caller.txt最高血圧値1.ForeColor = Color.Black
        Caller.txt最低血圧値1.ForeColor = Color.Black
        Caller.txt最高血圧値2.ForeColor = Color.Black
        Caller.txt最低血圧値2.ForeColor = Color.Black

        Dim Dac As DBAccess = New DBAccess
        Dac.ConnectInfo = Caller.ConnectInfo

        Dim psn As 被験者 = Dac.GetPersonByTuban(tuban)
        If psn.血圧終了.Equals("Y") Then

            Dim result = Dac.GetKensindataByPersonalID(PersonID)

            If result.Count > 0 Then
                For Each rec In result
                    If rec.項目コード1 = AppSettings("BloodPressureH1") Then
                        Caller.lbl最高血圧値1.Text = rec.検査結果値1.Trim
                        Caller.txt最高血圧値1.Text = rec.検査結果値1.Trim
                    End If
                    If rec.項目コード2 = AppSettings("BloodPressureH1") Then
                        Caller.lbl最高血圧値1.Text = rec.検査結果値2.Trim
                        Caller.txt最高血圧値1.Text = rec.検査結果値2.Trim
                    End If
                    If rec.項目コード3 = AppSettings("BloodPressureH1") Then
                        Caller.lbl最高血圧値1.Text = rec.検査結果値3.Trim
                        Caller.txt最高血圧値1.Text = rec.検査結果値3.Trim
                    End If
                    If rec.項目コード4 = AppSettings("BloodPressureH1") Then
                        Caller.lbl最高血圧値1.Text = rec.検査結果値4.Trim
                        Caller.txt最高血圧値1.Text = rec.検査結果値4.Trim
                    End If
                    If rec.項目コード5 = AppSettings("BloodPressureH1") Then
                        Caller.lbl最高血圧値1.Text = rec.検査結果値5.Trim
                        Caller.txt最高血圧値1.Text = rec.検査結果値5.Trim
                    End If
                Next

                For Each rec In result
                    If rec.項目コード1 = AppSettings("BloodPressureL1") Then
                        Caller.lbl最低血圧値1.Text = rec.検査結果値1.Trim
                        Caller.txt最低血圧値1.Text = rec.検査結果値1.Trim
                    End If
                    If rec.項目コード2 = AppSettings("BloodPressureL1") Then
                        Caller.lbl最低血圧値1.Text = rec.検査結果値2.Trim
                        Caller.txt最低血圧値1.Text = rec.検査結果値2.Trim
                    End If
                    If rec.項目コード3 = AppSettings("BloodPressureL1") Then
                        Caller.lbl最低血圧値1.Text = rec.検査結果値3.Trim
                        Caller.txt最低血圧値1.Text = rec.検査結果値3.Trim
                    End If
                    If rec.項目コード4 = AppSettings("BloodPressureL1") Then
                        Caller.lbl最低血圧値1.Text = rec.検査結果値4.Trim
                        Caller.txt最低血圧値1.Text = rec.検査結果値4.Trim
                    End If
                    If rec.項目コード5 = AppSettings("BloodPressureL1") Then
                        Caller.lbl最低血圧値1.Text = rec.検査結果値5.Trim
                        Caller.txt最低血圧値1.Text = rec.検査結果値5.Trim
                    End If
                Next

                For Each rec In result
                    If rec.項目コード1 = AppSettings("BloodPressureH2") Then
                        Caller.lbl最高血圧値2.Text = rec.検査結果値1.Trim
                        Caller.txt最高血圧値2.Text = rec.検査結果値1.Trim
                    End If
                    If rec.項目コード2 = AppSettings("BloodPressureH2") Then
                        Caller.lbl最高血圧値2.Text = rec.検査結果値2.Trim
                        Caller.txt最高血圧値2.Text = rec.検査結果値2.Trim
                    End If
                    If rec.項目コード3 = AppSettings("BloodPressureH2") Then
                        Caller.lbl最高血圧値2.Text = rec.検査結果値3.Trim
                        Caller.txt最高血圧値2.Text = rec.検査結果値3.Trim
                    End If
                    If rec.項目コード4 = AppSettings("BloodPressureH2") Then
                        Caller.lbl最高血圧値2.Text = rec.検査結果値4.Trim
                        Caller.txt最高血圧値2.Text = rec.検査結果値4.Trim
                    End If
                    If rec.項目コード5 = AppSettings("BloodPressureH2") Then
                        Caller.lbl最高血圧値2.Text = rec.検査結果値5.Trim
                        Caller.txt最高血圧値2.Text = rec.検査結果値5.Trim
                    End If
                Next

                For Each rec In result
                    If rec.項目コード1 = AppSettings("BloodPressureL2") Then
                        Caller.lbl最低血圧値2.Text = rec.検査結果値1.Trim
                        Caller.txt最低血圧値2.Text = rec.検査結果値1.Trim
                    End If
                    If rec.項目コード2 = AppSettings("BloodPressureL2") Then
                        Caller.lbl最低血圧値2.Text = rec.検査結果値2.Trim
                        Caller.txt最低血圧値2.Text = rec.検査結果値2.Trim
                    End If
                    If rec.項目コード3 = AppSettings("BloodPressureL2") Then
                        Caller.lbl最低血圧値2.Text = rec.検査結果値3.Trim
                        Caller.txt最低血圧値2.Text = rec.検査結果値3.Trim
                    End If
                    If rec.項目コード4 = AppSettings("BloodPressureL2") Then
                        Caller.lbl最低血圧値2.Text = rec.検査結果値4.Trim
                        Caller.txt最低血圧値2.Text = rec.検査結果値4.Trim
                    End If
                    If rec.項目コード5 = AppSettings("BloodPressureL2") Then
                        Caller.lbl最低血圧値2.Text = rec.検査結果値5.Trim
                        Caller.txt最低血圧値2.Text = rec.検査結果値5.Trim
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
        Caller.lbl最高血圧1.Enabled = enabled
        Caller.lbl最低血圧1.Enabled = enabled
        Caller.lbl最高血圧2.Enabled = enabled
        Caller.lbl最低血圧2.Enabled = enabled
        Caller.lbl最高血圧値1.Enabled = enabled
        Caller.lbl最高血圧値2.Enabled = enabled
        Caller.lbl最低血圧値1.Enabled = enabled
        Caller.lbl最低血圧値2.Enabled = enabled
        Caller.lbl最高血圧単位1.Enabled = enabled
        Caller.lbl最低血圧単位1.Enabled = enabled
        Caller.lbl最高血圧単位2.Enabled = enabled
        Caller.lbl最低血圧単位2.Enabled = enabled
        Caller.btnRegist.Enabled = enabled

    End Sub

#End Region

#Region "すべての値をクリア"
    ''' <summary>
    ''' 値をクリアする
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ClearValues()

        Caller.lbl最高血圧値1.Text = String.Empty
        Caller.lbl最低血圧値1.Text = String.Empty
        Caller.lbl最高血圧値2.Text = String.Empty
        Caller.lbl最低血圧値2.Text = String.Empty

        Caller.txt最高血圧値1.Text = String.Empty
        Caller.txt最低血圧値1.Text = String.Empty
        Caller.txt最高血圧値2.Text = String.Empty
        Caller.txt最低血圧値2.Text = String.Empty

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
        Using tenkey As Tenkey = New Tenkey()
            Select Case DirectCast(sender, Label).Name
                Case "lbl最高血圧値1"
                    tenkey.ItemName = Caller.lbl最高血圧1.Text
                Case "lbl最高血圧値2"
                    tenkey.ItemName = Caller.lbl最高血圧2.Text
                Case "lbl最低血圧値1"
                    tenkey.ItemName = Caller.lbl最低血圧1.Text
                Case "lbl最低血圧値2"
                    tenkey.ItemName = Caller.lbl最低血圧2.Text
            End Select
            tenkey.Syousu = Syousu
            tenkey.Seisu = 3
            tenkey.Cntl = sender
            tenkey.ShowDialog()
        End Using
    End Sub
#End Region

#Region "入力チェック"
    ''' <summary>
    ''' 入力チェック
    ''' </summary>
    ''' <remarks></remarks>
    Public Function Validate() As Boolean

        Try
            ' 未入力
            If Caller.lbl最高血圧値1.Text.Equals(String.Empty) Then
                Throw New No_InputException(Caller.lbl最高血圧1.Text + "が入力されていません。")
            End If

            If Caller.lbl最低血圧値1.Text.Equals(String.Empty) Then
                Throw New No_InputException(Caller.lbl最低血圧1.Text + "が入力されていません。")
            End If

            '２回めがないとき
            If Caller.lbl最高血圧値2.Text = "" Or Caller.lbl最低血圧値2.Text = "" Then
                Dim Dac As DBAccess = New DBAccess
                Dac.ConnectInfo = Caller.ConnectInfo

                Dim retvalue As List(Of Decimal) = Dac.GetThresholdLevel("血圧1回不可")

                If (Decimal.Parse(Caller.lbl最低血圧値1.Text) > retvalue(0)) Or Decimal.Parse(Caller.lbl最高血圧値1.Text) > retvalue(1) Then
                    Throw New NeedSecondMeasurementException(CommonConst.NEED_SECOND)
                End If
            End If


            ' 最低値が最大値より大きい
            If Short.Parse(Caller.lbl最高血圧値1.Text) < Short.Parse(Caller.lbl最低血圧値1.Text) Then
                Throw New AbnormalValueException(Caller.lbl最低血圧1.Text.Replace(" ", "") + "が" + Caller.lbl最高血圧1.Text.Replace(" ", "") + "よりも大きいです。")
            End If

            If Caller.lbl最高血圧値2.Text <> "" And Caller.lbl最低血圧値2.Text <> "" Then
                If Short.Parse(Caller.lbl最高血圧値2.Text) < Short.Parse(Caller.lbl最低血圧値2.Text) Then
                    Throw New AbnormalValueException(Caller.lbl最低血圧2.Text.Replace(" ", "") + "が" + Caller.lbl最高血圧2.Text.Replace(" ", "") + "よりも大きいです。")
                    Exit Function
                End If
            End If

            '********************最高初回閾値***********************
            Dim db As DBAccess = New DBAccess
            db.ConnectInfo = Caller.ConnectInfo

            Dim values As List(Of Decimal) = db.GetThresholdLevel("血圧")
            Dim errors As StringBuilder = New StringBuilder

            If Decimal.Parse(Caller.lbl最高血圧値1.Text) < values(0) Then
                Caller.lbl最高血圧値1.ForeColor = Color.Red
                Caller.txt最高血圧値1.ForeColor = Color.Red
                errors.Append(Caller.lbl最高血圧1.Text.Replace(" ", ""))
            End If

            If Decimal.Parse(Caller.lbl最高血圧値1.Text) > values(1) Then
                Caller.lbl最高血圧値1.ForeColor = Color.Red
                Caller.txt最高血圧値1.ForeColor = Color.Red
                If errors.Length <> 0 Then errors.Append("・")
                errors.Append(Caller.lbl最高血圧1.Text.Replace(" ", ""))
            End If

            '********************最低初回閾値***********************
            If Decimal.Parse(Caller.lbl最低血圧値1.Text) < values(0) Then
                Caller.lbl最低血圧値1.ForeColor = Color.Red
                Caller.txt最低血圧値1.ForeColor = Color.Red
                If errors.Length <> 0 Then errors.Append("・")
                errors.Append(Caller.lbl最低血圧1.Text.Replace(" ", ""))
            End If

            If Decimal.Parse(Caller.lbl最低血圧値1.Text) > values(1) Then
                Caller.lbl最低血圧値1.ForeColor = Color.Red
                Caller.txt最低血圧値1.ForeColor = Color.Red
                If errors.Length <> 0 Then errors.Append("・")
                errors.Append(Caller.lbl最低血圧1.Text.Replace(" ", ""))
            End If

            If Not Caller.lbl最高血圧値2.Text = String.Empty Then
                '********************最高2回閾値***********************
                If Decimal.Parse(Caller.lbl最高血圧値2.Text) < values(0) Then
                    Caller.lbl最高血圧値2.ForeColor = Color.Red
                    Caller.txt最高血圧値2.ForeColor = Color.Red
                    If errors.Length <> 0 Then errors.Append("・")
                    errors.Append(Caller.lbl最高血圧2.Text.Replace(" ", ""))
                End If

                If Decimal.Parse(Caller.lbl最高血圧値2.Text) > values(1) Then
                    Caller.lbl最高血圧値2.ForeColor = Color.Red
                    Caller.txt最高血圧値2.ForeColor = Color.Red
                    If errors.Length <> 0 Then errors.Append("・")
                    errors.Append(Caller.lbl最高血圧2.Text.Replace(" ", ""))
                End If
            End If

            If Not Caller.lbl最低血圧値2.Text = String.Empty Then
                '********************最低2回閾値***********************
                If Decimal.Parse(Caller.lbl最低血圧値2.Text) < values(0) Then
                    Caller.lbl最低血圧値2.ForeColor = Color.Red
                    Caller.txt最低血圧値2.ForeColor = Color.Red
                    If errors.Length <> 0 Then errors.Append("・")
                    errors.Append(Caller.lbl最低血圧2.Text.Replace(" ", ""))
                End If

                If Decimal.Parse(Caller.lbl最低血圧値2.Text) > values(1) Then
                    Caller.lbl最低血圧値2.ForeColor = Color.Red
                    Caller.txt最低血圧値2.ForeColor = Color.Red
                    If errors.Length <> 0 Then errors.Append("・")
                    errors.Append(Caller.lbl最低血圧2.Text.Replace(" ", ""))
                End If
            End If

            If errors.Length > 0 Then
                Dim msg As String = CommonConst.OVER_RANGE.Replace("%%", errors.ToString)
                Using msgwin As MessageWindow = New MessageWindow()
                    Result = String.Empty
                    msgwin.IconImage = CommonConst.EXCLAMATION
                    msgwin.ButtonStyle = CommonConst.YES_NO
                    msgwin.MessageString = msg
                    msgwin.Caller = Me
                    msgwin.ShowDialog()
                End Using
                If Result <> CommonConst.YES Then
                    Return False
                End If
            End If
            Return True

        Catch ex As AbnormalValueException
            Throw
        Catch ex As NeedSecondMeasurementException
            Throw
        Catch ex As No_InputException
            Throw
        Catch ex As Exception
            Throw
        End Try
    End Function
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
                data1.Code = AppSettings("BloodPressureH1")
                data1.value = Caller.lbl最高血圧値1.Text
                datas.Add(data1)

                Dim data2 As DBAccess.DataContainer = New DBAccess.DataContainer
                data2.Key = PersonID.Trim
                data2.Code = AppSettings("BloodPressureL1")
                data2.value = Caller.lbl最低血圧値1.Text
                datas.Add(data2)

                Dim data3 As DBAccess.DataContainer = New DBAccess.DataContainer
                data3.Key = PersonID.Trim
                data3.Code = AppSettings("BloodPressureH2")
                data3.value = Caller.lbl最高血圧値2.Text
                datas.Add(data3)

                Dim data4 As DBAccess.DataContainer = New DBAccess.DataContainer
                data4.Key = PersonID.Trim
                data4.Code = AppSettings("BloodPressureL2")
                data4.value = Caller.lbl最低血圧値2.Text
                datas.Add(data4)

                Dac.RegistKenshinData(datas)
                Dac.UpdateKenshinStatus(CommonConst.KETSUATSU, PersonID.Trim)

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
        Catch ex As AbnormalValueException
            Throw
        Catch ex As NeedSecondMeasurementException
            Throw
        Catch ex As No_InputException
            Throw
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub Clear1st()
        Caller.lbl最高血圧値1.Text = String.Empty
        Caller.lbl最低血圧値1.Text = String.Empty
        Caller.txt最高血圧値1.Text = String.Empty
        Caller.txt最低血圧値1.Text = String.Empty
    End Sub

    Public Sub Clear2nd()
        Caller.lbl最高血圧値2.Text = String.Empty
        Caller.lbl最低血圧値2.Text = String.Empty
        Caller.txt最高血圧値2.Text = String.Empty
        Caller.txt最低血圧値2.Text = String.Empty
    End Sub
#End Region

#Region "受診者がいるか？"
    ''' <summary>
    ''' 受診者がいるか？
    ''' </summary>
    ''' <param name="caller"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Load(caller As 血圧) As Boolean
        Dim Dac As DBAccess = New DBAccess
        Dim ret As Boolean = True
        Dac.ConnectInfo = caller.ConnectInfo
        If Not Dac.IsTtherePerson(AppSettings("BloodPressureH1")) Then
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

    Friend Function KeyInputValidation(tatget As Mi_TextBox, code As String) As Boolean
        Dim ret As Boolean = True

        Select Case code
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"   '0～9
            Case ControlChars.Back
            Case ControlChars.Cr
                tatget.NextFocus.Focus()
                ret = False
            Case Else
                ret = False
        End Select

        Return ret
    End Function

    ''' <summary>
    ''' ラベルとテキストボックスの同期
    ''' </summary>
    ''' <remarks></remarks>
    Friend Sub 血圧値_Validated()
        Caller.lbl最高血圧値1.Text = Caller.txt最高血圧値1.Text
        Caller.lbl最高血圧値2.Text = Caller.txt最高血圧値2.Text
        Caller.lbl最低血圧値1.Text = Caller.txt最低血圧値1.Text
        Caller.lbl最低血圧値2.Text = Caller.txt最低血圧値2.Text

    End Sub

    ''' <summary>
    ''' 検診対象者が指定された検診項目を受診するかどうか
    ''' </summary>
    ''' <param name="id"></param>
    ''' <remarks></remarks>
    Friend Function IsExist(id As String) As Boolean
        Dim Dac As DBAccess = New DBAccess
        Dac.ConnectInfo = Caller.ConnectInfo

        If Dac.IsInspectionCode(id, AppSettings("BloodPressureH1")) OrElse Dac.IsInspectionCode(id, AppSettings("BloodPressureL1")) OrElse Dac.IsInspectionCode(id, AppSettings("BloodPressureH2")) OrElse Dac.IsInspectionCode(id, AppSettings("BloodPressureL2")) Then
            Return True
        End If
        Return False
    End Function

End Class
