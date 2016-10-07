Imports Dac
Imports System.Text
Imports System.Data.Odbc
Imports System.Configuration.ConfigurationManager

''' <summary>
''' データ・アクセスクラス
''' </summary>
''' <remarks></remarks>
Public Class DBAccess

#Region "データ登録用コンテナクラス"
    ''' <summary>
    ''' データ登録用コンテナクラス
    ''' </summary>
    ''' <remarks></remarks>
    Public Class DataContainer

        ''' <summary>
        ''' 依頼元KEY
        ''' </summary>
        Property Key As String

        ''' <summary>
        ''' 入力項目コード
        ''' </summary>
        Property Code As String

        ''' <summary>
        ''' 検査結果値
        ''' </summary>
        ''' <value></value>
        Property value As String
    End Class
#End Region

#Region "プロパティ"
    ''' <summary>
    ''' 接続情報
    ''' </summary>
    Public Property ConnectInfo As List(Of String) = New List(Of String)

#End Region

#Region "被験者"

    ''' <summary>
    ''' 通番から検診者情報を取得する
    ''' </summary>
    ''' <param name="tuban"></param>
    ''' <returns>被験者Entity</returns>
    ''' <remarks></remarks>
    Public Function GetPersonByTuban(tuban As String) As Dac.Tables.被験者

        Dim errmsg As String = String.Empty
        Dim db As DacFunc = New DacFunc(ConnectInfo)
        Dim sql As StringBuilder = New StringBuilder

        Try

            db.connect(errmsg)
            sql.Append("select * from 被験者 ")
            sql.Append("where 日通番 = ")
            sql.Append(tuban)
            Dim dt As DataTable = db.ExecuteSql(sql.ToString)

            Dim PersonEntity As List(Of Dac.Tables.被験者) = New List(Of Dac.Tables.被験者)

            SetPersonItems(dt, PersonEntity)

            db.close()
            Return PersonEntity(0)

        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    ''' <summary>
    ''' 受付済みのすべての検診者情報を取得する
    ''' </summary>
    ''' <returns>被験者Entityリスト</returns>
    ''' <remarks></remarks>
    ''' 
    Public Function GetPersonList(kenshinName As String) As List(Of Dac.Tables.被験者)

        Dim PersonEntity As List(Of Dac.Tables.被験者) = New List(Of Dac.Tables.被験者)
        Dim db As DacFunc = New DacFunc(ConnectInfo)

        Try
            Dim wkwhwere As StringBuilder = New StringBuilder
            Dim orwhere As String = String.Empty
            Select Case kenshinName
                '視力
                Case "視力"
                    wkwhwere.AppendLine("and 依頼者KEY in (")
                    wkwhwere.AppendLine("select ")
                    wkwhwere.AppendLine("依頼元KEY ")
                    wkwhwere.AppendLine("from 結果取込 ")
                    wkwhwere.AppendLine("where ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("NakedEyeR")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("NakedEyeR")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("NakedEyeR")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("NakedEyeR")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' ) ", AppSettings("NakedEyeR")))
                    wkwhwere.AppendLine("or ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("NakedEyeL")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("NakedEyeL")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("NakedEyeL")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("NakedEyeL")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' ) ", AppSettings("NakedEyeL")))
                    wkwhwere.AppendLine("or ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("CorrectedEyeR")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("CorrectedEyeR")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("CorrectedEyeR")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("CorrectedEyeR")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' ) ", AppSettings("CorrectedEyeR")))
                    wkwhwere.AppendLine("or ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("CorrectedEyeL")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("CorrectedEyeL")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("CorrectedEyeL")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("CorrectedEyeL")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' )) ", AppSettings("CorrectedEyeL")))
                    orwhere = wkwhwere.ToString

                    '血圧
                Case "血圧"
                    wkwhwere.AppendLine("and 依頼者KEY in (")
                    wkwhwere.AppendLine("select ")
                    wkwhwere.AppendLine("依頼元KEY ")
                    wkwhwere.AppendLine("from 結果取込 ")
                    wkwhwere.AppendLine("where ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("BloodPressureH1")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("BloodPressureH1")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("BloodPressureH1")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("BloodPressureH1")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' ) ", AppSettings("BloodPressureH1")))
                    wkwhwere.AppendLine("or ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("BloodPressureL1")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("BloodPressureL1")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("BloodPressureL1")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("BloodPressureL1")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' ) ", AppSettings("BloodPressureL1")))
                    wkwhwere.AppendLine("or ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("BloodPressureH2")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("BloodPressureH2")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("BloodPressureH2")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("BloodPressureH2")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' ) ", AppSettings("BloodPressureH2")))
                    wkwhwere.AppendLine("or ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("BloodPressureL2")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("BloodPressureL2")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("BloodPressureL2")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("BloodPressureL2")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' )) ", AppSettings("BloodPressureL2")))
                    orwhere = wkwhwere.ToString

                    '診察
                Case "診察"
                    wkwhwere.AppendLine("and 依頼者KEY in (")
                    wkwhwere.AppendLine("select ")
                    wkwhwere.AppendLine("依頼元KEY ")
                    wkwhwere.AppendLine("from 結果取込 ")
                    wkwhwere.AppendLine("where ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("MedicalExamination")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("MedicalExamination")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("MedicalExamination")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("MedicalExamination")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' )) ", AppSettings("MedicalExamination")))
                    orwhere = wkwhwere.ToString

                    '聴力
                Case "聴力"
                    wkwhwere.AppendLine("and 依頼者KEY in (")
                    wkwhwere.AppendLine("select ")
                    wkwhwere.AppendLine("依頼元KEY ")
                    wkwhwere.AppendLine("from 結果取込 ")
                    wkwhwere.AppendLine("where ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("HearingAbilityR1000")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("HearingAbilityR1000")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("HearingAbilityR1000")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("HearingAbilityR1000")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' ) ", AppSettings("HearingAbilityR1000")))
                    wkwhwere.AppendLine("or ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("HearingAbilityL1000")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("HearingAbilityL1000")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("HearingAbilityL1000")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("HearingAbilityL1000")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' ) ", AppSettings("HearingAbilityL1000")))
                    wkwhwere.AppendLine("or ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("HearingAbilityR4000")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("HearingAbilityR4000")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("HearingAbilityR4000")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("HearingAbilityR4000")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' ) ", AppSettings("HearingAbilityR4000")))
                    wkwhwere.AppendLine("or ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("HearingAbilityL4000")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("HearingAbilityL4000")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("HearingAbilityL4000")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("HearingAbilityL4000")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' )) ", AppSettings("HearingAbilityL4000")))
                    orwhere = wkwhwere.ToString

                    '腹囲
                Case "腹囲"
                    wkwhwere.AppendLine("and 依頼者KEY in (")
                    wkwhwere.AppendLine("select ")
                    wkwhwere.AppendLine("依頼元KEY ")
                    wkwhwere.AppendLine("from 結果取込 ")
                    wkwhwere.AppendLine("where ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("GirthOfTheAbdomen")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("GirthOfTheAbdomen")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("GirthOfTheAbdomen")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("GirthOfTheAbdomen")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' )) ", AppSettings("GirthOfTheAbdomen")))
                    orwhere = wkwhwere.ToString

                    '検尿
                Case "検尿"
                    wkwhwere.AppendLine("and 依頼者KEY in (")
                    wkwhwere.AppendLine("select ")
                    wkwhwere.AppendLine("依頼元KEY ")
                    wkwhwere.AppendLine("from 結果取込 ")
                    wkwhwere.AppendLine("where ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("UrineSugar")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("UrineSugar")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("UrineSugar")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("UrineSugar")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' ) ", AppSettings("UrineSugar")))
                    wkwhwere.AppendLine("or ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("UrineProtein")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("UrineProtein")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("UrineProtein")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("UrineProtein")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' ) ", AppSettings("UrineProtein")))
                    wkwhwere.AppendLine("or ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("UrineOccultBleeding")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("UrineOccultBleeding")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("UrineOccultBleeding")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("UrineOccultBleeding")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' ) ", AppSettings("UrineOccultBleeding")))
                    wkwhwere.AppendLine("or ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("UrineUrobilinogen")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("UrineUrobilinogen")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("UrineUrobilinogen")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("UrineUrobilinogen")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' )) ", AppSettings("UrineUrobilinogen")))
                    orwhere = wkwhwere.ToString

                    '握力
                Case "握力"
                    wkwhwere.AppendLine("and 依頼者KEY in (")
                    wkwhwere.AppendLine("select ")
                    wkwhwere.AppendLine("依頼元KEY ")
                    wkwhwere.AppendLine("from 結果取込 ")
                    wkwhwere.AppendLine("where ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("GripR")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("GripR")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("GripR")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("GripR")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' ) ", AppSettings("GripR")))
                    wkwhwere.AppendLine("or ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("GripL")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("GripL")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("GripL")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("GripL")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' )) ", AppSettings("GripL")))
                    orwhere = wkwhwere.ToString

                    '身長・体重・腹囲
                Case "身長", "身長・体重・腹囲"
                    wkwhwere.AppendLine("and 依頼者KEY in (")
                    wkwhwere.AppendLine("select ")
                    wkwhwere.AppendLine("依頼元KEY ")
                    wkwhwere.AppendLine("from 結果取込 ")
                    wkwhwere.AppendLine("where ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("HEIGHT")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("HEIGHT")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("HEIGHT")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("HEIGHT")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' ) ", AppSettings("HEIGHT")))
                    wkwhwere.AppendLine("or ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("WEIGHT")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("WEIGHT")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("WEIGHT")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("WEIGHT")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' ) ", AppSettings("WEIGHT")))
                    wkwhwere.AppendLine("or ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("GirthOfTheAbdomen")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("GirthOfTheAbdomen")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("GirthOfTheAbdomen")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("GirthOfTheAbdomen")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' )) ", AppSettings("GirthOfTheAbdomen")))
                    orwhere = wkwhwere.ToString

                    '学校視力
                Case "学校視力"
                    wkwhwere.AppendLine("and 依頼者KEY in (")
                    wkwhwere.AppendLine("select ")
                    wkwhwere.AppendLine("依頼元KEY ")
                    wkwhwere.AppendLine("from 結果取込 ")
                    wkwhwere.AppendLine("where ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("NakedEyeR_School")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("NakedEyeR_School")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("NakedEyeR_School")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("NakedEyeR_School")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' ) ", AppSettings("NakedEyeR_School")))
                    wkwhwere.AppendLine("or ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("NakedEyeL_School")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("NakedEyeL_School")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("NakedEyeL_School")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("NakedEyeL_School")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' ) ", AppSettings("NakedEyeL_School")))
                    wkwhwere.AppendLine("or ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("CorrectedEyeR_School")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("CorrectedEyeR_School")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("CorrectedEyeR_School")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("CorrectedEyeR_School")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' ) ", AppSettings("CorrectedEyeR_School")))
                    wkwhwere.AppendLine("or ( ")
                    wkwhwere.AppendLine(String.Format("項目コード1 = '{0}' or ", AppSettings("CorrectedEyeL_School")))
                    wkwhwere.AppendLine(String.Format("項目コード2 = '{0}' or ", AppSettings("CorrectedEyeL_School")))
                    wkwhwere.AppendLine(String.Format("項目コード3 = '{0}' or ", AppSettings("CorrectedEyeL_School")))
                    wkwhwere.AppendLine(String.Format("項目コード4 = '{0}' or ", AppSettings("CorrectedEyeL_School")))
                    wkwhwere.AppendLine(String.Format("項目コード5 = '{0}' )) ", AppSettings("CorrectedEyeL_School")))
                    orwhere = wkwhwere.ToString

            End Select


            Dim errmsg As String = String.Empty
            db.connect(errmsg)
            Dim sql As StringBuilder = New StringBuilder
            sql.Append("select * from 被験者 ")
            sql.Append("where 日通番 <> 0 ")
            sql.Append("{0} ")
            sql.Append("order by 日通番")

            Dim exSql As String = String.Format(sql.ToString, orwhere)
            Dim dt As DataTable = db.ExecuteSql(exSql)
            If Not dt Is Nothing Then
                SetPersonItems(dt, PersonEntity)
            End If

            db.close()
            Return PersonEntity

        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    ''' <summary>
    ''' すべての検診者情報を取得する
    ''' </summary>
    ''' <returns>被験者Entityリスト</returns>
    ''' <remarks></remarks>
    Public Function GetPersonListAll() As List(Of Dac.Tables.被験者)

        Dim PersonEntity As List(Of Dac.Tables.被験者) = New List(Of Dac.Tables.被験者)
        Dim db As DacFunc = New DacFunc(ConnectInfo)

        Try
            Dim errmsg As String = String.Empty
            db.connect(errmsg)
            Dim sql As StringBuilder = New StringBuilder
            sql.Append("select * from 被験者 ")

            Dim dt As DataTable = db.ExecuteSql(sql.ToString)
            If dt Is Nothing Then
                SetPersonItems(dt, PersonEntity)
            End If
            db.close()

            Return PersonEntity

        Catch ex As Exception
            Throw
        End Try

    End Function

    ''' <summary>
    ''' 被験者テーブルのデータをリストに設定する
    ''' </summary>
    ''' <param name="dt">DataTable</param>
    ''' <param name="PersonEntity">被験者Entityリスト</param>
    ''' <remarks></remarks>
    Public Sub SetPersonItems(dt As DataTable, ByRef PersonEntity As List(Of Dac.Tables.被験者))
        Try
            For Each rec In dt.Rows
                Dim record As Dac.Tables.被験者 = New Dac.Tables.被験者
                record.レコード区分 = rec.Item(0)
                record.センターコード = rec.Item(1)
                record.依頼者KEY = rec.Item(2)
                record.科コード科名 = rec.Item(3)
                record.病棟コード病棟名 = rec.Item(4)
                record.入院外来区分 = rec.Item(5)
                record.提出医 = rec.Item(6)
                record.被験者ＩＤ = rec.Item(7)
                record.カルテNo = rec.Item(8)
                record.被験者名 = rec.Item(9)
                record.性別 = rec.Item(10)
                record.年齢区分 = rec.Item(11)
                record.年齢 = rec.Item(12)
                record.生年月日区分 = rec.Item(13)
                record.年月日 = rec.Item(14)
                record.採取日 = rec.Item(15)
                record.採取時間 = rec.Item(16)
                record.項目数 = rec.Item(17)
                record.身長 = rec.Item(18)
                record.体重 = rec.Item(19)
                record.尿量 = rec.Item(20)
                record.尿単位 = rec.Item(21)
                record.妊娠週数 = rec.Item(22)
                record.透析前後 = rec.Item(23)
                record.至急報告 = rec.Item(24)
                record.依頼コメント内容 = rec.Item(25)
                record.予備 = rec.Item(26)
                record.日通番 = rec.Item(27)
                record.身長体重終了 = rec.Item(28)
                record.血圧終了 = rec.Item(29)
                record.腹囲終了 = rec.Item(30)
                record.視力終了 = rec.Item(31)
                record.聴力終了 = rec.Item(32)
                record.尿検査終了 = rec.Item(33)
                record.診察終了 = rec.Item(34)
                record.胸部X線終了 = rec.Item(35)
                record.腹部X線終了 = rec.Item(36)
                record.採血終了 = rec.Item(37)
                record.心電図終了 = rec.Item(38)
                record.眼底検査終了 = rec.Item(39)
                record.腹部エコー終了 = rec.Item(40)
                record.その他終了 = rec.Item(41)
                record.握力終了 = rec.Item(42)
                record.体重減 = rec.Item(43)

                PersonEntity.Add(record)
            Next

        Catch ex As Exception
            Throw
        End Try
    End Sub

#End Region

#Region "結果取込"

    ''' <summary>
    ''' 検査項目コードの件数を返す
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsTtherePerson(id As String) As Boolean

        Try
            Dim sql As StringBuilder = New StringBuilder
            sql.Append("select count(*) as cnt ")
            sql.Append("from 結果取込 ")
            sql.Append("where ")
            sql.Append("項目コード1 = '" + id + "' ")
            sql.Append("or 項目コード2 = '" + id + "' ")
            sql.Append("or 項目コード3 = '" + id + "' ")
            sql.Append("or 項目コード4 = '" + id + "' ")
            sql.Append("or 項目コード5 = '" + id + "'")

            Dim db As DacFunc = New DacFunc(ConnectInfo)
            Dim errmsg As String = String.Empty
            db.connect(errmsg)
            Dim dt As DataTable = db.ExecuteSql(sql.ToString)
            Dim ret As Boolean = True
            If Not dt Is Nothing Then
                If dt.Rows(0).Item("cnt") = 0 Then
                    ret = False
                End If
            Else
                Return False
            End If
            db.close()

            Return ret

        Catch ex As Exception
            Return False
        End Try

    End Function


    ''' <summary>
    ''' 検診対象者が指定された検診項目を受診するかどうか
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="code"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsInspectionCode(id As String, code As String) As Boolean

        Dim ret As Boolean = True
        Dim sql As StringBuilder = New StringBuilder

        sql.Append("select count(*) as cnt from 結果取込 ")
        sql.Append("where  依頼元KEY = '" + id + "' ")
        sql.Append("and (項目コード1 ='" + code + "' ")
        sql.Append("or 項目コード2 ='" + code + "' ")
        sql.Append("or 項目コード3 ='" + code + "' ")
        sql.Append("or 項目コード4 ='" + code + "' ")
        sql.Append("or 項目コード5 ='" + code + "')")

        Dim db As DacFunc = New DacFunc(ConnectInfo)
        Dim errmsg As String = String.Empty
        db.connect(errmsg)
        Using dt As DataTable = db.ExecuteSql(sql.ToString)
            If Not dt Is Nothing Then
                If dt.Rows(0).Item("cnt") = 0 Then
                    ret = False
                End If
            Else
                ret = False
            End If
        End Using
        db.close()

        Return ret

    End Function


    ''' <summary>
    ''' 依頼元KEYから結果取込を検索する
    ''' </summary>
    ''' <param name="personalID">依頼元KEY</param>
    ''' <returns>結果取込リスト</returns>
    ''' <remarks></remarks>
    Public Function GetKensindataByPersonalID(personalID As String) As List(Of Dac.Tables.結果取込)
        Dim ResultEntity As List(Of Dac.Tables.結果取込) = New List(Of Dac.Tables.結果取込)
        Dim db As DacFunc = New DacFunc(ConnectInfo)

        Try
            Dim errmsg As String = String.Empty
            db.connect(errmsg)
            Dim sql As StringBuilder = New StringBuilder
            sql.Append("select * from 結果取込 ")
            sql.Append("where 依頼元KEY = ")
            sql.Append("'" + personalID + "'")

            Dim dt As DataTable = db.ExecuteSql(sql.ToString)
            If Not dt Is Nothing Then
                SetResultItems(dt, ResultEntity)
            End If
            db.close()

            Return ResultEntity

        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' 結果取込テーブルのデータをリストに設定する
    ''' </summary>
    ''' <param name="dt">DataTAble</param>
    ''' <param name="ResultEntity">結果取込リスト</param>
    ''' <remarks></remarks>
    Public Sub SetResultItems(dt As DataTable, ByRef ResultEntity As List(Of Dac.Tables.結果取込))

        For Each rec In dt.Rows
            Dim record As Dac.Tables.結果取込 = New Dac.Tables.結果取込
            Try
                record.依頼元KEY = rec.Item("依頼元KEY")
                record.被験者名 = rec.Item("被験者名")

                If Not IsDBNull(rec.Item("項目コード1")) Then
                    record.項目コード1 = rec.Item("項目コード1")
                End If

                If Not IsDBNull(rec.Item("検査結果値1")) Then
                    record.検査結果値1 = rec.Item("検査結果値1")
                End If

                If Not IsDBNull(rec.Item("項目コード2")) Then
                    record.項目コード2 = rec.Item("項目コード2")
                End If

                If Not IsDBNull(rec.Item("検査結果値2")) Then
                    record.検査結果値2 = rec.Item("検査結果値2")
                End If

                If Not IsDBNull(rec.Item("項目コード3")) Then
                    record.項目コード3 = rec.Item("項目コード3")
                End If

                If Not IsDBNull(rec.Item("検査結果値3")) Then
                    record.検査結果値3 = rec.Item("検査結果値3")
                End If

                If Not IsDBNull(rec.Item("項目コード4")) Then
                    record.項目コード4 = rec.Item("項目コード4")
                End If

                If Not IsDBNull(rec.Item("検査結果値4")) Then
                    record.検査結果値4 = rec.Item("検査結果値4")
                End If

                If Not IsDBNull(rec.Item("項目コード5")) Then
                    record.項目コード5 = rec.Item("項目コード5")
                End If

                If Not IsDBNull(rec.Item("検査結果値5")) Then
                    record.検査結果値5 = rec.Item("検査結果値5")
                End If

                If Not IsDBNull(rec.Item("個人連番")) Then
                    record.個人連番 = rec.Item("個人連番")
                End If

                ResultEntity.Add(record)

            Catch ex As Exception
                Throw
            End Try
        Next

    End Sub

    ''' <summary>
    ''' 検診データを登録する
    ''' </summary>
    ''' <param name="data"></param>
    ''' <remarks></remarks>
    Public Sub RegistKenshinData(data As List(Of DBAccess.DataContainer))

        Dim errmsg As String = String.Empty
        Dim db As DacFunc = New DacFunc(ConnectInfo)
        Try
            db.connect(errmsg)

            'トランザクション開始
            db.tran = db.con.BeginTransaction(IsolationLevel.ReadCommitted)
            Dim sql As StringBuilder = New StringBuilder

            For Each regdata In data
                sql.Append("select * from 結果取込 ")
                sql.Append("where (項目コード1 = '" + regdata.Code + "' or ")
                sql.Append("項目コード2 = '" + regdata.Code + "' or ")
                sql.Append("項目コード3 = '" + regdata.Code + "' or ")
                sql.Append("項目コード4 = '" + regdata.Code + "' or ")
                sql.Append("項目コード5 = '" + regdata.Code + "') and ")
                sql.Append("依頼元KEY = '" + data(0).Key + "' ")

                Dim datatbl As DataTable = db.ExecuteSql(sql.ToString)

                If datatbl Is Nothing Then
                    sql.Clear()
                    Continue For
                End If


                Dim ResultEntity As List(Of Dac.Tables.結果取込) = New List(Of Dac.Tables.結果取込)
                SetResultItems(datatbl, ResultEntity)

                For Each res In ResultEntity
                    Dim atai As String = regdata.value
                    atai = Space(8 - atai.Length) + atai

                    sql.Clear()
                    sql.Append("update 結果取込 set ")
                    If res.項目コード1 = regdata.Code Then
                        sql.Append("検査結果値1 = '" + atai + "'")
                    End If
                    If res.項目コード2 = regdata.Code Then
                        sql.Append("検査結果値2 = '" + atai + "'")
                    End If
                    If res.項目コード3 = regdata.Code Then
                        sql.Append("検査結果値3 = '" + atai + "'")
                    End If
                    If res.項目コード4 = regdata.Code Then
                        sql.Append("検査結果値4 = '" + atai + "'")
                    End If
                    If res.項目コード5 = regdata.Code Then
                        sql.Append("検査結果値5 = '" + atai + "'")
                    End If
                    sql.Append(" where 依頼元KEY = '" + res.依頼元KEY + "' and ")
                    sql.Append("個人連番 = " + res.個人連番.ToString)

                    db.execNonQTran(sql.ToString, errmsg, db.con, db.tran)
                    sql.Clear()

                Next
            Next

            db.committrn()

        Catch ex As Exception
            db.rollbacktran()
            Throw
        End Try
    End Sub


    ''' <summary>
    ''' 検診ステータスを更新する
    ''' </summary>
    ''' <param name="kenshinCode"></param>
    ''' <param name="personID"></param>
    ''' <remarks></remarks>
    Public Sub UpdateKenshinStatus(kenshinCode As String, personID As String)

        Dim errmsg As String = String.Empty
        Dim db As DacFunc = New DacFunc(ConnectInfo)

        Try
            db.connect(errmsg)

            'トランザクション開始
            db.tran = db.con.BeginTransaction(IsolationLevel.ReadCommitted)
            Dim sql As StringBuilder = New StringBuilder

            sql.Append("update 被験者 ")
            Select Case kenshinCode
                Case "視力"
                    sql.Append("set 視力終了 = 'Y' ")
                Case "血圧"
                    sql.Append("set 血圧終了 = 'Y' ")
                Case "診察"
                    sql.Append("set 診察終了 = 'Y' ")
                Case "聴力"
                    sql.Append("set 聴力終了 = 'Y' ")
                Case "腹囲"
                    sql.Append("set 腹囲終了 = 'Y' ")
                Case "検尿"
                    sql.Append("set 尿検査終了 = 'Y' ")
                Case "握力"
                    sql.Append("set 握力終了 = 'Y' ")
                Case "身長"
                    sql.Append("set 身長体重終了 = 'Y' ")
                Case Else

            End Select
            sql.Append("where 依頼者KEY = '" + personID + "'")

            db.execNonQTran(sql.ToString, errmsg, db.con, db.tran)
            db.committrn()

        Catch ex As Exception
            db.rollbacktran()
            Throw
        End Try

    End Sub

#End Region

#Region "閾値"
    ''' <summary>
    ''' 名称から閾値を求める
    ''' </summary>
    ''' <param name="itemName">名称</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetThresholdLevel(itemName As String) As List(Of Decimal)
        Dim ret As List(Of Decimal) = New List(Of Decimal)

        Try
            Dim errmsg As String = String.Empty
            Dim db As DacFunc = New DacFunc(ConnectInfo)
            db.connect(errmsg)

            Dim sql As String = "select * from 閾値 where 名称 = '" + itemName + "'"
            Dim dt As DataTable = db.ExecuteSql(sql)
            If dt.Rows.Count = 0 Then
                Throw New DBErrorException(errmsg)
            End If
            ret.Add(dt.Rows(0).Item("最低"))
            ret.Add(dt.Rows(0).Item("最高"))
            db.close()
            Return ret
        Catch ex As Exception
            Throw
        End Try
    End Function
#End Region

#Region "検査項目マスタ"
    ''' <summary>
    ''' 検査項目マスタをPKで検索する
    ''' </summary>
    ''' <param name="code">入力項目コード</param>
    ''' <returns>検査項目マスタエンティティ</returns>
    ''' <remarks></remarks>
    Public Function GetInspectionItemMasterByPK(code As String) As Dac.Tables.検査項目マスタ

        Dim InspectionItemMasterEntity As List(Of Dac.Tables.検査項目マスタ) = New List(Of Dac.Tables.検査項目マスタ)
        Try

            Dim errmsg As String = String.Empty
            Dim db As DacFunc = New DacFunc(ConnectInfo)

            db.connect(errmsg)

            Dim sql As StringBuilder = New StringBuilder
            sql.Append("select * from 検査項目マスタ ")
            sql.Append("where 入力項目コード ='" + code + "'")

            Dim dt As DataTable = db.ExecuteSql(sql.ToString)
            If dt.Rows.Count > 0 Then
                SetInspectionItemMasterItems(dt, InspectionItemMasterEntity)
            End If

            db.close()
            Return InspectionItemMasterEntity.First
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' 検査項目マスタのデータをリストに設定する
    ''' </summary>
    ''' <param name="dt">DataTable</param>
    ''' <param name="InspectionItemMasterEntity">検査項目マスタエンティティ</param>
    ''' <remarks></remarks>
    Public Sub SetInspectionItemMasterItems(dt As DataTable, ByRef InspectionItemMasterEntity As List(Of Dac.Tables.検査項目マスタ))

        Try
            For Each rec In dt.Rows
                Dim record As Dac.Tables.検査項目マスタ = New Dac.Tables.検査項目マスタ
                If Not IsDBNull(rec.Item(0)) Then record.入力項目コード = rec.Item("入力項目コード")
                If Not IsDBNull(rec.Item(1)) Then record.入力項目表示名称 = rec.Item("入力項目表示名称")
                If Not IsDBNull(rec.Item(2)) Then record.入力形式 = rec.Item("入力形式")
                If Not IsDBNull(rec.Item(3)) Then record.少数桁数 = rec.Item("少数桁数")
                If Not IsDBNull(rec.Item(4)) Then record.単位名称 = rec.Item("単位名称")

                InspectionItemMasterEntity.Add(record)
            Next

        Catch ex As Exception
            Throw
        End Try

    End Sub

#End Region

End Class
