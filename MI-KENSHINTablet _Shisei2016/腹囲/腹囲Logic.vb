﻿Imports System.Configuration.ConfigurationManager
Imports System.Windows.Forms
Imports Dac.Tables
Imports Dac
Imports Mi_KENSHINCommon
Imports Mi_KENSHINCommon.Common
Imports System.Text

Public Class 腹囲Logic

#Region "変数"
    ''' <summary>
    ''' 呼び出し元
    ''' </summary>
    Public Property Caller As 腹囲

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
    Public Sub New(parent As 腹囲)
        Caller = parent
        Dim Dac As DBAccess = New DBAccess

        Try
            Dac.ConnectInfo = Caller.ConnectInfo

            Syousu = Dac.GetInspectionItemMasterByPK(AppSettings("GirthOfTheAbdomen")).少数桁数

            Caller.lbl腹囲.Text = Dac.GetInspectionItemMasterByPK(AppSettings("GirthOfTheAbdomen")).入力項目表示名称
            Caller.lbl腹囲単位.Text = Dac.GetInspectionItemMasterByPK(AppSettings("GirthOfTheAbdomen")).単位名称

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

        Caller.lbl腹囲値.ForeColor = Color.Black
        Caller.txt腹囲値.ForeColor = Color.Black
        Caller.txt腹囲値2.ForeColor = Color.Black

        Dim Dac As DBAccess = New DBAccess
        Dac.ConnectInfo = Caller.ConnectInfo

        Dim psn As 被験者 = Dac.GetPersonByTuban(tuban)
        If psn.腹囲終了.Equals("Y") Then

            Dim result = Dac.GetKensindataByPersonalID(PersonID)

            If result.Count > 0 Then
                For Each rec In result
                    Dim wk() As String
                    If rec.項目コード1 = AppSettings("GirthOfTheAbdomen") Then
                        Caller.lbl腹囲値.Text = rec.検査結果値1.Trim
                        wk = rec.検査結果値1.Trim.Split(".")
                        Caller.txt腹囲値.Text = wk(0)
                        If wk.Length = 1 Then
                            Caller.txt腹囲値2.Text = "0"
                        Else
                            Caller.txt腹囲値2.Text = wk(1)
                        End If
                    End If
                    If rec.項目コード2 = AppSettings("GirthOfTheAbdomen") Then
                        Caller.lbl腹囲値.Text = rec.検査結果値2.Trim
                        wk = rec.検査結果値2.Trim.Split(".")
                        Caller.txt腹囲値.Text = wk(0)
                        If wk.Length = 1 Then
                            Caller.txt腹囲値2.Text = "0"
                        Else
                            Caller.txt腹囲値2.Text = wk(1)
                        End If
                    End If
                    If rec.項目コード3 = AppSettings("GirthOfTheAbdomen") Then
                        Caller.lbl腹囲値.Text = rec.検査結果値3.Trim
                        wk = rec.検査結果値3.Trim.Split(".")
                        Caller.txt腹囲値.Text = wk(0)
                        If wk.Length = 1 Then
                            Caller.txt腹囲値2.Text = "0"
                        Else
                            Caller.txt腹囲値2.Text = wk(1)
                        End If
                    End If
                    If rec.項目コード4 = AppSettings("GirthOfTheAbdomen") Then
                        Caller.lbl腹囲値.Text = rec.検査結果値4.Trim
                        wk = rec.検査結果値4.Trim.Split(".")
                        Caller.txt腹囲値.Text = wk(0)
                        If wk.Length = 1 Then
                            Caller.txt腹囲値2.Text = "0"
                        Else
                            Caller.txt腹囲値2.Text = wk(1)
                        End If
                    End If
                    If rec.項目コード5 = AppSettings("GirthOfTheAbdomen") Then
                        Caller.lbl腹囲値.Text = rec.検査結果値5.Trim
                        wk = rec.検査結果値5.Trim.Split(".")
                        Caller.txt腹囲値.Text = wk(0)
                        If wk.Length = 1 Then
                            Caller.txt腹囲値2.Text = "0"
                        Else
                            Caller.txt腹囲値2.Text = wk(1)
                        End If
                    End If
                Next

            End If
        End If
        Caller.btnRegist.Focus()
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
        Caller.txt腹囲値.Focus()
    End Sub
#End Region

#Region "画面項目を使用不能にする"
    ''' <summary>
    ''' 画面項目を使用不能にする
    ''' </summary>
    ''' <param name="enabled"></param>
    ''' <remarks></remarks>
    Public Sub ChangeEnable(enabled As Boolean)
        Caller.lbl腹囲.Enabled = enabled
        Caller.lbl腹囲値.Enabled = enabled
        Caller.lbl腹囲単位.Enabled = enabled
        Caller.btnRegist.Enabled = enabled

        Caller.txt腹囲値.Enabled = enabled
        Caller.txt腹囲値2.Enabled = enabled
    End Sub

#End Region

#Region "すべての値をクリア"
    ''' <summary>
    ''' 値をクリアする
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ClearValues()
        Caller.lbl腹囲値.Text = String.Empty
        Caller.txt腹囲値.Text = String.Empty
        Caller.txt腹囲値2.Text = String.Empty
        Caller.btnRegist.Enabled = False
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
            tenkey.ItemName = Caller.lbl腹囲.Text
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


        ' 未入力
        If Caller.lbl腹囲値.Text.Equals(String.Empty) Then
            Throw New No_InputException(Caller.lbl腹囲.Text + "が入力されていません。")
        End If


        '********************腹囲閾値***********************
        Dim db As DBAccess = New DBAccess
        db.ConnectInfo = Caller.ConnectInfo

        Dim values As List(Of Decimal) = db.GetThresholdLevel(CommonConst.FUKUI)
        Dim errors As StringBuilder = New StringBuilder

        If Decimal.Parse(Caller.lbl腹囲値.Text) < values(0) Then
            Caller.lbl腹囲値.ForeColor = Color.Red
            errors.Append(Caller.lbl腹囲.Text)
        End If

        If Decimal.Parse(Caller.lbl腹囲値.Text) > values(1) Then
            Caller.lbl腹囲値.ForeColor = Color.Red
            errors.Append(Caller.lbl腹囲.Text)
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
                data1.Code = AppSettings("GirthOfTheAbdomen")
                data1.value = Caller.lbl腹囲値.Text
                datas.Add(data1)

                Dac.RegistKenshinData(datas)
                Dac.UpdateKenshinStatus(CommonConst.FUKUI, PersonID.Trim)

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

#Region "受診者がいるか？"
    ''' <summary>
    ''' 受診者がいるか？
    ''' </summary>
    ''' <param name="caller"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Load(caller As 腹囲) As Boolean
        Dim Dac As DBAccess = New DBAccess
        Dim ret As Boolean = True
        Dac.ConnectInfo = caller.ConnectInfo
        If Not Dac.IsTtherePerson(AppSettings("GirthOfTheAbdomen")) Then
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

    Friend Sub 腹囲値_Validated()
        Caller.lbl腹囲値.Text = Caller.txt腹囲値.Text & "." & IIf(Caller.txt腹囲値2.Text = String.Empty, "0", Caller.txt腹囲値2.Text)
    End Sub

    ''' <summary>
    ''' 検診対象者が指定された検診項目を受診するかどうか
    ''' </summary>
    ''' <param name="id"></param>
    ''' <remarks></remarks>
    Friend Function IsExist(id As String) As Boolean
        Dim Dac As DBAccess = New DBAccess
        Dac.ConnectInfo = Caller.ConnectInfo

        Return Dac.IsInspectionCode(id, AppSettings("GirthOfTheAbdomen"))
     
    End Function
End Class
