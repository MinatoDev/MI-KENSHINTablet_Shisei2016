Imports System.Configuration.ConfigurationManager
Imports Dac
Imports Dac.Tables
Imports Mi_KENSHINCommon

Public Class 学校視力Logic
#Region "変数"
    ''' <summary>
    ''' 呼び出し元
    ''' </summary>
    Public Property Caller As 学校視力

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
    Public Sub New(parent As 学校視力)
        Caller = parent
        Dim Dac As DBAccess = New DBAccess

        Try
            Dac.ConnectInfo = Caller.ConnectInfo
            Caller.lbl裸眼右.Text = Dac.GetInspectionItemMasterByPK(AppSettings("NakedEyeR_School")).入力項目表示名称
            Caller.lbl裸眼左.Text = Dac.GetInspectionItemMasterByPK(AppSettings("NakedEyeL_School")).入力項目表示名称
            Caller.lbl矯正右.Text = Dac.GetInspectionItemMasterByPK(AppSettings("CorrectedEyeR_School")).入力項目表示名称
            Caller.lbl矯正左.Text = Dac.GetInspectionItemMasterByPK(AppSettings("CorrectedEyeL_School")).入力項目表示名称
            ChangeEnable(False)
            ClearValues()

        Catch ex As Exception
            Throw
        End Try
    End Sub
#End Region

#Region "ロードイベント初期表示"
    ''' <summary>
    ''' ロードイベント
    ''' </summary>
    ''' <param name="caller"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Load(caller As 学校視力) As Boolean
        Dim Dac As DBAccess = New DBAccess
        Dim ret As Boolean = True
        Dac.ConnectInfo = caller.ConnectInfo
        If Not Dac.IsTtherePerson(AppSettings("NakedEyeR_School")) Then
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

#Region "初期表示"
    ''' <summary>
    ''' データがある場合は初期表示
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub InitDisplay(tuban As String)
        Dim Dac As DBAccess = New DBAccess
        Dac.ConnectInfo = Caller.ConnectInfo

        Dim psn As 被験者 = Dac.GetPersonByTuban(tuban)
        If psn.視力終了.Equals("Y") Then

            Dim result = Dac.GetKensindataByPersonalID(PersonID)

            If result.Count > 0 Then
                For Each rec In result
                    If rec.項目コード1 = AppSettings("NakedEyeR_School") Then
                        Caller.lbl裸眼右値.Text = rec.検査結果値1.Trim
                    End If
                    If rec.項目コード2 = AppSettings("NakedEyeR_School") Then
                        Caller.lbl裸眼右値.Text = rec.検査結果値2.Trim
                    End If
                    If rec.項目コード3 = AppSettings("NakedEyeR_School") Then
                        Caller.lbl裸眼右値.Text = rec.検査結果値3.Trim
                    End If
                    If rec.項目コード4 = AppSettings("NakedEyeR_School") Then
                        Caller.lbl裸眼右値.Text = rec.検査結果値4.Trim
                    End If
                    If rec.項目コード5 = AppSettings("NakedEyeR_School") Then
                        Caller.lbl裸眼右値.Text = rec.検査結果値5.Trim
                    End If
                Next


                For Each rec In result
                    If rec.項目コード1 = AppSettings("NakedEyeL_School") Then
                        Caller.lbl裸眼左値.Text = rec.検査結果値1.Trim
                    End If
                    If rec.項目コード2 = AppSettings("NakedEyeL_School") Then
                        Caller.lbl裸眼左値.Text = rec.検査結果値2.Trim
                    End If
                    If rec.項目コード3 = AppSettings("NakedEyeL_School") Then
                        Caller.lbl裸眼左値.Text = rec.検査結果値3.Trim
                    End If
                    If rec.項目コード4 = AppSettings("NakedEyeL_School") Then
                        Caller.lbl裸眼左値.Text = rec.検査結果値4.Trim
                    End If
                    If rec.項目コード5 = AppSettings("NakedEyeL_School") Then
                        Caller.lbl裸眼左値.Text = rec.検査結果値5.Trim
                    End If
                Next

                For Each rec In result
                    If rec.項目コード1 = AppSettings("CorrectedEyeR_School") Then
                        Caller.lbl矯正右値.Text = rec.検査結果値1.Trim
                    End If
                    If rec.項目コード2 = AppSettings("CorrectedEyeR_School") Then
                        Caller.lbl矯正右値.Text = rec.検査結果値2.Trim
                    End If
                    If rec.項目コード3 = AppSettings("CorrectedEyeR_School") Then
                        Caller.lbl矯正右値.Text = rec.検査結果値3.Trim
                    End If
                    If rec.項目コード4 = AppSettings("CorrectedEyeR_School") Then
                        Caller.lbl矯正右値.Text = rec.検査結果値4.Trim
                    End If
                    If rec.項目コード5 = AppSettings("CorrectedEyeR_School") Then
                        Caller.lbl矯正右値.Text = rec.検査結果値5.Trim
                    End If
                Next

                For Each rec In result
                    If rec.項目コード1 = AppSettings("CorrectedEyeL_School") Then
                        Caller.lbl矯正左値.Text = rec.検査結果値1.Trim
                    End If
                    If rec.項目コード2 = AppSettings("CorrectedEyeL_School") Then
                        Caller.lbl矯正左値.Text = rec.検査結果値2.Trim
                    End If
                    If rec.項目コード3 = AppSettings("CorrectedEyeL_School") Then
                        Caller.lbl矯正左値.Text = rec.検査結果値3.Trim
                    End If
                    If rec.項目コード4 = AppSettings("CorrectedEyeL_School") Then
                        Caller.lbl矯正左値.Text = rec.検査結果値4.Trim
                    End If
                    If rec.項目コード5 = AppSettings("CorrectedEyeL_School") Then
                        Caller.lbl矯正左値.Text = rec.検査結果値5.Trim
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

#Region "画面項目を使用不能・可能にする"
    ''' <summary>
    ''' 画面項目を使用不能・可能にする
    ''' </summary>
    ''' <param name="enabled"></param>
    ''' <remarks></remarks>
    Public Sub ChangeEnable(enabled As Boolean)
        Caller.lbl裸眼右.Enabled = enabled
        Caller.lbl裸眼左.Enabled = enabled
        Caller.lbl矯正右.Enabled = enabled
        Caller.lbl矯正左.Enabled = enabled
        Caller.lbl裸眼右値.Enabled = enabled
        Caller.lbl裸眼左値.Enabled = enabled
        Caller.lbl矯正右値.Enabled = enabled
        Caller.lbl矯正左値.Enabled = enabled
        Caller.btnRegist.Enabled = enabled
    End Sub

#End Region

#Region "すべての値をクリア"
    ''' <summary>
    ''' 値をクリアする
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ClearValues()
        Caller.lbl裸眼右値.Text = String.Empty
        Caller.lbl裸眼左値.Text = String.Empty
        Caller.lbl矯正右値.Text = String.Empty
        Caller.lbl矯正左値.Text = String.Empty
    End Sub
#End Region

#Region "各値クリック時に選択画面を表示"
    ''' <summary>
    ''' 各値クリック時に選択画面を表示
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <remarks></remarks>
    Public Sub Value_Click(sender As Label)
        Using vc As ValueChoice = New ValueChoice(sender)

            Select Case sender.Name
                Case Caller.lbl裸眼右値.Name
                    vc.ItemName = Caller.lbl裸眼右.Text
                Case Caller.lbl裸眼左値.Name
                    vc.ItemName = Caller.lbl裸眼左.Text
                Case Caller.lbl矯正右値.Name
                    vc.ItemName = Caller.lbl矯正右.Text
                Case Caller.lbl矯正左値.Name
                    vc.ItemName = Caller.lbl矯正左.Text
            End Select

            vc.ShowDialog()
        End Using

    End Sub

#End Region

#Region "入力チェック"
    ''' <summary>
    ''' 入力チェック
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Validate()

        If Caller.lbl裸眼右値.Text.Equals(String.Empty) And
            Caller.lbl裸眼左値.Text.Equals(String.Empty) And
            Caller.lbl矯正右値.Text.Equals(String.Empty) And
            Caller.lbl矯正左値.Text.Equals(String.Empty) Then
            Throw New Common.No_InputException("何も入力されていません。")
        End If

        'If Caller.lbl裸眼左値.Text.Equals(String.Empty) Then
        '    Throw New Common.No_InputException(Caller.lbl裸眼左.Text + "が入力されていません。")
        'End If

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
            data1.Code = AppSettings("NakedEyeR_School")
            data1.value = Caller.lbl裸眼右値.Text
            datas.Add(data1)

            Dim data2 As DBAccess.DataContainer = New DBAccess.DataContainer
            data2.Key = PersonID.Trim
            data2.Code = AppSettings("NakedEyeL_School")
            data2.value = Caller.lbl裸眼左値.Text
            datas.Add(data2)

            Dim data3 As DBAccess.DataContainer = New DBAccess.DataContainer
            data3.Key = PersonID.Trim
            data3.Code = AppSettings("CorrectedEyeR_School")
            data3.value = Caller.lbl矯正右値.Text
            datas.Add(data3)

            Dim data4 As DBAccess.DataContainer = New DBAccess.DataContainer
            data4.Key = PersonID.Trim
            data4.Code = AppSettings("CorrectedEyeL_School")
            data4.value = Caller.lbl矯正左値.Text
            datas.Add(data4)

            Dac.RegistKenshinData(datas)
            Dac.UpdateKenshinStatus(CommonConst.SIRYOKU, PersonID.Trim)

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

    ''' <summary>
    ''' 検診対象者が指定された検診項目を受診するかどうか
    ''' </summary>
    ''' <param name="id"></param>
    ''' <remarks></remarks>
    Friend Function IsExist(id As String) As Boolean
        Dim Dac As DBAccess = New DBAccess
        Dac.ConnectInfo = Caller.ConnectInfo

        If Dac.IsInspectionCode(id, AppSettings("NakedEyeR_School")) OrElse Dac.IsInspectionCode(id, AppSettings("NakedEyeL_School")) OrElse Dac.IsInspectionCode(id, AppSettings("CorrectedEyeR_School")) OrElse Dac.IsInspectionCode(id, AppSettings("CorrectedEyeL_School")) Then
            Return True
        End If
        Return False
    End Function
End Class
