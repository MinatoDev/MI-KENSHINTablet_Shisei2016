Option Explicit On

Imports System.Media

Public Class MainForm
#Region "変数等"
    Private bbb As String
    Private ccc As String
    Private Property dt As DataTable

#End Region
#Region "初期化"
    Public Sub New()
        Try
            ' この呼び出しはデザイナーで必要です。
            InitializeComponent()

            ' InitializeComponent() 呼び出しの後で初期化を追加します。
            Me.Icon = My.Resources.TAK連携
            txtFilePath.Text = My.Settings.INputPath
            txtFilePath2.Text = My.Settings.OutputPath
            Me.MinimumSize = New Size(1366, 768)
            Me.MaximumSize = New Size(1366, 768)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region

#Region "取込"
    Private Sub btn開始_Click(sender As System.Object, e As System.EventArgs) Handles btn開始.Click
        Dim errobj As Object = Nothing
        Dim errmsg As String = ""
        Dim tgtDate As Date = Nothing
        Dim fname As String = ""
        Dim レコード区分 As String
        Dim センターコード As String
        Dim 依頼者KEY As String
        Dim 科コード・科名 As String
        Dim 病棟コード病棟名 As String
        Dim 入院外来区分 As String
        Dim 提出医 As String
        Dim 被験者ＩＤ As String
        Dim カルテNo As String
        Dim 被験者名 As String
        Dim 性別 As String
        Dim 年齢区分 As String
        Dim 年齢 As String
        Dim 生年月日区分 As String
        Dim 年月日 As String
        Dim 採取日 As String
        Dim 採取時間 As String
        Dim 項目数 As String
        Dim 身長 As String
        Dim 体重 As String
        Dim 量 As String
        Dim 単位 As String
        Dim 妊娠週数 As String
        Dim 透析前後 As String
        Dim 至急報告 As String
        Dim 依頼コメント内容 As String
        'Dim 予備 As String
        Dim 団体名称 As String

        Dim 分析物コード(8) As String
        Dim 識別コード(8) As String
        Dim 材料コード(8) As String
        Dim 測定法コード(8) As String
        Dim 負荷時間(8) As String
        Dim 予備2 As String

        Dim stBuffer As String
        Dim db As db = New db
        Dim sql As String = ""

        Dim nowkey As String = ""
        Dim 個人連番 As Integer = 0
        Dim maekey As String = ""
        Dim endflg As Boolean = False
        Dim cnt2 As Integer = 1
        Dim keys(0) As String
        Dim koumoku(0) As String
        Dim recs As Integer
        Dim keycnt As Integer = 0


        With db
            Try
                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                If Not .starttrn(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                sql = "select count(*) as cnt from 被験者"
                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If

                If dt.Rows(0).Item("cnt") <> 0 Then
                    If MessageBox.Show("前回のデータは消去されます。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                        .rollbacktran()
                        .close()
                        Exit Try
                    End If
                End If

                sql = "delete from  結果取込"
                If Not .execNonQTran(sql, errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                sql = "delete from 被験者データ"
                If Not .execNonQTran(sql, errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                sql = "ALTER TABLE 被験者データ AUTO_INCREMENT = 1"
                If Not .execNonQTran(sql, errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                sql = "delete from 被験者"
                If Not .execNonQTran(sql, errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                sql = "delete from 発番"
                If Not .execNonQTran(sql, errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                sql = "insert into 発番 (通番) values (0)"
                If Not .execNonQTran(sql, errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                errobj = txtFilePath
                If txtFilePath.Text = "" Then
                    errmsg = "ファイルのパスを設定してください"
                    Throw New No_InputException(errmsg)
                Else
                    ep.SetError(errobj, Nothing)
                End If
                tgtDate = Now

                fname = txtFilePath.Text

                Using reader As New System.IO.StreamReader(lstFiles.SelectedItem.ToString, System.Text.Encoding.Default)

                    While (reader.Peek() >= 0)
                        stBuffer = reader.ReadLine()
                        レコード区分 = Left_(stBuffer, 2)
                        If レコード区分 = "O1" Then
                            センターコード = Mid_(stBuffer, 3, 6)
                            依頼者KEY = Mid_(stBuffer, 9, 20)
                            科コード・科名 = Mid_(stBuffer, 29, 15)
                            病棟コード病棟名 = Mid_(stBuffer, 44, 15)
                            入院外来区分 = Mid_(stBuffer, 59, 1)
                            提出医 = Mid_(stBuffer, 60, 10)
                            被験者ＩＤ = Mid_(stBuffer, 70, 15)
                            カルテNo = Mid_(stBuffer, 85, 15)
                            被験者名 = Mid_(stBuffer, 100, 20)
                            性別 = Mid_(stBuffer, 120, 1)
                            年齢区分 = Mid_(stBuffer, 121, 1)
                            年齢 = Mid_(stBuffer, 122, 3)
                            生年月日区分 = Mid_(stBuffer, 125, 1)
                            年月日 = Mid_(stBuffer, 126, 6)
                            採取日 = Mid_(stBuffer, 132, 6)
                            採取時間 = Mid_(stBuffer, 138, 4)
                            項目数 = Mid_(stBuffer, 142, 3)
                            身長 = Mid_(stBuffer, 145, 4)
                            体重 = Mid_(stBuffer, 149, 4)
                            量 = Mid_(stBuffer, 153, 4)
                            単位 = Mid_(stBuffer, 157, 2)
                            妊娠週数 = Mid_(stBuffer, 159, 2)
                            透析前後 = Mid_(stBuffer, 161, 1)
                            至急報告 = Mid_(stBuffer, 162, 1)
                            依頼コメント内容 = Mid_(stBuffer, 163, 20)
                            団体名称 = Mid_(stBuffer, 183, 74)
                            '予備 = Mid_(stBuffer, 183, 74)

                            sql = "INSERT INTO 被験者 ("
                            sql += "`レコード区分`,"
                            sql += "`センターコード`,"
                            sql += "`依頼者KEY`,"
                            sql += "`科コード科名`,"
                            sql += "`病棟コード病棟名`,"
                            sql += "`入院外来区分`,"
                            sql += "`提出医`,"
                            sql += "`被験者ＩＤ`,"
                            sql += "`カルテNo`,"
                            sql += "`被験者名`,"
                            sql += "`性別`,"
                            sql += "`年齢区分`,"
                            sql += "`年齢`,"
                            sql += "`生年月日区分`,"
                            sql += "`年月日`,"
                            sql += "`採取日`,"
                            sql += "`採取時間`,"
                            sql += "`項目数`,"
                            sql += "`身長`,"
                            sql += "`体重`,"
                            sql += "`尿量`,"
                            sql += "`尿単位`,"
                            sql += "`妊娠週数`,"
                            sql += "`透析前後`,"
                            sql += "`至急報告`,"
                            sql += "`依頼コメント内容`,"
                            sql += "`予備`,"
                            sql += "`日通番`) "
                            sql += "values('[レコード区分]',"
                            sql += "'[センターコード]',"
                            sql += "'[依頼者KEY]',"
                            sql += "'[科コード科名]',"
                            sql += "'[病棟コード病棟名]',"
                            sql += "'[入院外来区分]',"
                            sql += "'[提出医]',"
                            sql += "'[被験者ＩＤ]',"
                            sql += "'[カルテNo]',"
                            sql += "'[被験者名]',"
                            sql += "'[性別]',"
                            sql += "'[年齢区分]',"
                            sql += "'[年齢]',"
                            sql += "'[生年月日区分]',"
                            sql += "'[年月日]',"
                            sql += "'[採取日]',"
                            sql += "'[採取時間]',"
                            sql += "'[項目数]',"
                            sql += "'[身長]',"
                            sql += "'[体重]',"
                            sql += "'[尿量]',"
                            sql += "'[尿単位]',"
                            sql += "'[妊娠週数]',"
                            sql += "'[透析前後]',"
                            sql += "'[至急報告]',"
                            sql += "'[依頼コメント内容]',"
                            sql += "'[予備]',"
                            sql += "[日通番])"
                            sql = sql.Replace("[レコード区分]", レコード区分)
                            sql = sql.Replace("[センターコード]", センターコード)
                            sql = sql.Replace("[依頼者KEY]", 依頼者KEY)
                            sql = sql.Replace("[科コード科名]", 科コード・科名)
                            sql = sql.Replace("[病棟コード病棟名]", 病棟コード病棟名)
                            sql = sql.Replace("[入院外来区分]", 入院外来区分)
                            sql = sql.Replace("[提出医]", 提出医)
                            sql = sql.Replace("[被験者ＩＤ]", 被験者ＩＤ)
                            sql = sql.Replace("[カルテNo]", カルテNo)
                            sql = sql.Replace("[被験者名]", 被験者名)
                            sql = sql.Replace("[性別]", 性別)
                            sql = sql.Replace("[年齢区分]", 年齢区分)
                            sql = sql.Replace("[年齢]", 年齢)
                            sql = sql.Replace("[生年月日区分]", 生年月日区分)
                            sql = sql.Replace("[年月日]", 年月日)
                            sql = sql.Replace("[採取日]", 採取日)
                            sql = sql.Replace("[採取時間]", 採取時間)
                            sql = sql.Replace("[項目数]", 項目数)
                            sql = sql.Replace("[身長]", 身長)
                            sql = sql.Replace("[体重]", 体重)
                            sql = sql.Replace("[尿量]", 量)
                            sql = sql.Replace("[尿単位]", 単位)
                            sql = sql.Replace("[妊娠週数]", 妊娠週数)
                            sql = sql.Replace("[透析前後]", 透析前後)
                            sql = sql.Replace("[至急報告]", 至急報告)
                            sql = sql.Replace("[依頼コメント内容]", 依頼コメント内容)
                            sql = sql.Replace("[予備]", 団体名称)
                            sql = sql.Replace("[日通番]", "0")

                        Else
                            センターコード = Mid_(stBuffer, 3, 6)
                            依頼者KEY = Mid_(stBuffer, 9, 20)
                            For idx = 0 To 8 Step 1
                                分析物コード(idx) = Mid_(stBuffer, 29 + (idx * 25), 7)
                                識別コード(idx) = Mid_(stBuffer, 29 + (idx * 25) + 7, 4)
                                材料コード(idx) = Mid_(stBuffer, 29 + (idx * 25) + 7 + 4, 3)
                                測定法コード(idx) = Mid_(stBuffer, 29 + (idx * 25) + 7 + 4 + 3, 3)
                                負荷時間(idx) = Mid_(stBuffer, 29 + (idx * 25) + 7 + 4 + 3 + 3, 10)
                            Next
                            予備2 = Mid_(stBuffer, 254, 3)

                            sql = "INSERT INTO `被験者データ`"
                            sql += "(`レコード区分`,"
                            sql += "`センターコード`,"
                            sql += "`依頼者KEY`,"
                            sql += "`分析物コード1`,"
                            sql += "`識別コード1`,"
                            sql += "`材料コード1`,"
                            sql += "`負荷時間1`,"
                            sql += "`分析物コード2`,"
                            sql += "`識別コード2`,"
                            sql += "`材料コード2`,"
                            sql += "`負荷時間2`,"
                            sql += "`分析物コード3`,"
                            sql += "`識別コード3`,"
                            sql += "`材料コード3`,"
                            sql += "`負荷時間3`,"
                            sql += "`分析物コード4`,"
                            sql += "`識別コード4`,"
                            sql += "`材料コード4`,"
                            sql += "`負荷時間4`,"
                            sql += "`分析物コード5`,"
                            sql += "`識別コード5`,"
                            sql += "`材料コード5`,"
                            sql += "`負荷時間5`,"
                            sql += "`分析物コード6`,"
                            sql += "`識別コード6`,"
                            sql += "`材料コード6`,"
                            sql += "`負荷時間6`,"
                            sql += "`分析物コード7`,"
                            sql += "`識別コード7`,"
                            sql += "`材料コード7`,"
                            sql += "`負荷時間7`,"
                            sql += "`分析物コード8`,"
                            sql += "`識別コード8`,"
                            sql += "`材料コード8`,"
                            sql += "`負荷時間8`,"
                            sql += "`分析物コード9`,"
                            sql += "`識別コード9`,"
                            sql += "`材料コード9`,"
                            sql += "`負荷時間9`,"
                            sql += "`予備`)"
                            sql += "VALUES"
                            sql += "("
                            sql += "'[レコード区分]',"
                            sql += "'[センターコード]',"
                            sql += "'[依頼者KEY]',"
                            sql += "'[分析物コード1]',"
                            sql += "'[識別コード1]',"
                            sql += "'[材料コード1]',"
                            sql += "'[負荷時間1]',"
                            sql += "'[分析物コード2]',"
                            sql += "'[識別コード2]',"
                            sql += "'[材料コード2]',"
                            sql += "'[負荷時間2]',"
                            sql += "'[分析物コード3]',"
                            sql += "'[識別コード3]',"
                            sql += "'[材料コード3]',"
                            sql += "'[負荷時間3]',"
                            sql += "'[分析物コード4]',"
                            sql += "'[識別コード4]',"
                            sql += "'[材料コード4]',"
                            sql += "'[負荷時間4]',"
                            sql += "'[分析物コード5]',"
                            sql += "'[識別コード5]',"
                            sql += "'[材料コード5]',"
                            sql += "'[負荷時間5]',"
                            sql += "'[分析物コード6]',"
                            sql += "'[識別コード6]',"
                            sql += "'[材料コード6]',"
                            sql += "'[負荷時間6]',"
                            sql += "'[分析物コード7]',"
                            sql += "'[識別コード7]',"
                            sql += "'[材料コード7]',"
                            sql += "'[負荷時間7]',"
                            sql += "'[分析物コード8]',"
                            sql += "'[識別コード8]',"
                            sql += "'[材料コード8]',"
                            sql += "'[負荷時間8]',"
                            sql += "'[分析物コード9]',"
                            sql += "'[識別コード9]',"
                            sql += "'[材料コード9]',"
                            sql += "'[負荷時間9]',"
                            sql += "'[予備]'"
                            sql += ");"
                            sql = sql.Replace("[レコード区分]", レコード区分)
                            sql = sql.Replace("[センターコード]", センターコード)
                            sql = sql.Replace("[依頼者KEY]", 依頼者KEY)
                            sql = sql.Replace("[分析物コード1]", 分析物コード(0))
                            sql = sql.Replace("[識別コード1]", 識別コード(0))
                            sql = sql.Replace("[材料コード1]", 材料コード(0))
                            sql = sql.Replace("[負荷時間1]", 負荷時間(0))
                            sql = sql.Replace("[分析物コード2]", 分析物コード(1))
                            sql = sql.Replace("[識別コード2]", 識別コード(1))
                            sql = sql.Replace("[材料コード2]", 材料コード(1))
                            sql = sql.Replace("[負荷時間2]", 負荷時間(1))
                            sql = sql.Replace("[分析物コード3]", 分析物コード(2))
                            sql = sql.Replace("[識別コード3]", 識別コード(2))
                            sql = sql.Replace("[材料コード3]", 材料コード(2))
                            sql = sql.Replace("[負荷時間3]", 負荷時間(2))
                            sql = sql.Replace("[分析物コード4]", 分析物コード(3))
                            sql = sql.Replace("[識別コード4]", 識別コード(3))
                            sql = sql.Replace("[材料コード4]", 材料コード(3))
                            sql = sql.Replace("[負荷時間4]", 負荷時間(3))
                            sql = sql.Replace("[分析物コード5]", 分析物コード(4))
                            sql = sql.Replace("[識別コード5]", 識別コード(4))
                            sql = sql.Replace("[材料コード5]", 材料コード(4))
                            sql = sql.Replace("[負荷時間5]", 負荷時間(4))
                            sql = sql.Replace("[分析物コード6]", 分析物コード(5))
                            sql = sql.Replace("[識別コード6]", 識別コード(5))
                            sql = sql.Replace("[材料コード6]", 材料コード(5))
                            sql = sql.Replace("[負荷時間6]", 負荷時間(5))
                            sql = sql.Replace("[分析物コード7]", 分析物コード(6))
                            sql = sql.Replace("[識別コード7]", 識別コード(6))
                            sql = sql.Replace("[材料コード7]", 材料コード(6))
                            sql = sql.Replace("[負荷時間7]", 負荷時間(6))
                            sql = sql.Replace("[分析物コード8]", 分析物コード(7))
                            sql = sql.Replace("[識別コード8]", 識別コード(7))
                            sql = sql.Replace("[材料コード8]", 材料コード(7))
                            sql = sql.Replace("[負荷時間8]", 負荷時間(7))
                            sql = sql.Replace("[分析物コード9]", 分析物コード(8))
                            sql = sql.Replace("[識別コード9]", 識別コード(8))
                            sql = sql.Replace("[材料コード9]", 材料コード(8))
                            sql = sql.Replace("[負荷時間9]", 負荷時間(8))
                            sql = sql.Replace("[予備]", 予備2)
                        End If
                        If Not .execNonQTran(sql, errmsg) Then
                            Throw New DBErrorException(errmsg)
                        End If
                    End While
                End Using


                '結果取込用のテーブルを作る
                sql = "select distinct 依頼者KEY from 被験者データ "
                dt = .ExecuteSql(sql)

                If dt.Rows.Count = 0 Then
                    Exit Sub
                End If
                For cnt = 0 To dt.Rows.Count - 1 Step 1
                    keys(cnt) = dt.Rows(cnt).Item("依頼者KEY")
                    Array.Resize(keys, keys.Length + 1)
                Next
                Array.Resize(keys, keys.Length - 1)

                For cnt = 0 To keys.Length - 1 Step 1
                    sql = "select * from 被験者データ where 依頼者KEY ='" + keys(cnt) + "'"
                    dt = .ExecuteSql(sql)
                    Dim itemcnt As Integer
                    recs = dt.Rows.Count
                    Dim renban As Integer = 1

                    '一人分の項目を配列に格納する。
                    Dim arrcnt = 0
                    Array.Resize(koumoku, 1)
                    For reccnt = 0 To recs - 1 Step 1
                        For itemcnt = 1 To 9 Step 1
                            koumoku(arrcnt) = IIf(IsDBNull(dt.Rows(reccnt).Item("分析物コード" + itemcnt.ToString)), Space(7), dt.Rows(reccnt).Item("分析物コード" + itemcnt.ToString))
                            arrcnt += 1
                            Array.Resize(koumoku, koumoku.Length + 1)
                        Next
                    Next
                    Array.Resize(koumoku, koumoku.Length - 1)
                    arrcnt -= 1

                    Dim inscnt As Integer
                    Dim namae As String = ""
                    Dim center As String = ""

                    '5項目ずつ登録する。
                    For inscnt = 0 To koumoku.Length - 1
                        sql = "select 被験者名,センターコード from 被験者 where 依頼者KEY = '" + keys(keycnt) + "'"
 
                        dt = .ExecuteSql(sql)
                        namae = dt.Rows(0).Item("被験者名")
                        center = dt.Rows(0).Item("センターコード")

                        sql = "INSERT INTO `結果取込`"
                        sql += "(`レコード区分`,"
                        sql += "`センターコード`,"
                        sql += "`依頼元KEY`,"
                        sql += "`受託者KEY`,"
                        sql += "`被験者名`,"
                        sql += "`報告状況コード`,"
                        sql += "`乳び`,"
                        sql += "`溶血`,"
                        sql += "`ビリルビン`,"
                        sql += "`空白`,"
                        sql += "`個人連番`)"
                        sql += " VALUES"
                        sql += "("
                        sql += "'[レコード区分]',"
                        sql += "'[センターコード]',"
                        sql += "'[依頼元KEY]',"
                        sql += "'[受託者KEY]',"
                        sql += "'[被験者名]',"
                        sql += "'[報告状況コード]',"
                        sql += "'[乳び]',"
                        sql += "'[溶血]',"
                        sql += "'[ビリルビン]',"
                        sql += "'[空白]',"
                        sql += "[個人連番]"
                        sql += ");"

                        sql = sql.Replace("[レコード区分]", "A1")
                        sql = sql.Replace("[センターコード]", center)
                        sql = sql.Replace("[依頼元KEY]", keys(cnt))
                        sql = sql.Replace("[受託者KEY]", "                    ")
                        sql = sql.Replace("[被験者名]", namae)
                        sql = sql.Replace("[報告状況コード]", " ")
                        sql = sql.Replace("[乳び]", "   ")
                        sql = sql.Replace("[溶血]", "   ")
                        sql = sql.Replace("[ビリルビン]", "        ")
                        sql = sql.Replace("[検査結果値]", " ")
                        sql = sql.Replace("[検査値形態]", " ")
                        sql = sql.Replace("[結果ｺﾒﾝﾄｺｰﾄﾞ1]", "   ")
                        sql = sql.Replace("[結果ｺﾒﾝﾄｺｰﾄﾞ2]", "   ")
                        sql = sql.Replace("[空白]", "  ")
                        sql = sql.Replace("[個人連番]", renban.ToString)

                        If Not .execNonQTran(sql, errmsg) Then
                            Throw New DBErrorException(errmsg)
                        End If

                        sql = "update 結果取込 set 項目コード1 = '" + koumoku(inscnt) + "' where 依頼元KEY = '" + keys(cnt) + "' and 個人連番 = " + renban.ToString
                        If Not .execNonQTran(sql, errmsg) Then
                            Throw New DBErrorException(errmsg)
                        End If

                        inscnt += 1
                        If inscnt > koumoku.Length - 1 Then
                            Exit For
                        End If
                        sql = "update 結果取込 set 項目コード2 = '" + koumoku(inscnt) + "' where 依頼元KEY = '" + keys(cnt) + "' and 個人連番 = " + renban.ToString
                        If Not .execNonQTran(sql, errmsg) Then
                            Throw New DBErrorException(errmsg)
                        End If

                        inscnt += 1
                        If inscnt > koumoku.Length - 1 Then
                            Exit For
                        End If
                        sql = "update 結果取込 set 項目コード3 = '" + koumoku(inscnt) + "' where 依頼元KEY = '" + keys(cnt) + "' and 個人連番 = " + renban.ToString
                        If Not .execNonQTran(sql, errmsg) Then
                            Throw New DBErrorException(errmsg)
                        End If

                        inscnt += 1
                        If inscnt > koumoku.Length - 1 Then
                            Exit For
                        End If
                        sql = "update 結果取込 set 項目コード4 = '" + koumoku(inscnt) + "' where 依頼元KEY = '" + keys(cnt) + "' and 個人連番 = " + renban.ToString
                        If Not .execNonQTran(sql, errmsg) Then
                            Throw New DBErrorException(errmsg)
                        End If

                        inscnt += 1
                        If inscnt > koumoku.Length - 1 Then
                            Exit For
                        End If
                        sql = "update 結果取込 set 項目コード5 = '" + koumoku(inscnt) + "' where 依頼元KEY = '" + keys(cnt) + "' and 個人連番 = " + renban.ToString
                        If Not .execNonQTran(sql, errmsg) Then
                            Throw New DBErrorException(errmsg)
                        End If

                        renban += 1
                    Next
                    keycnt += 1 '次の対象者へ。

                Next
                .committrn()
                My.Settings.INputPath = txtFilePath.Text
                My.Settings.Save()
                If MessageBox.Show("取込終了しました。" + vbCrLf + lstFiles.SelectedItem.ToString + "を削除しますか？", "完了", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    System.IO.File.Delete(lstFiles.SelectedItem.ToString)
                End If
                Call setlst1()
            Catch ex As FileException
                SystemSounds.Exclamation.Play()
                MsgBox(ex.Message)
            Catch ex As DBErrorException
                .rollbacktran()
                SystemSounds.Exclamation.Play()
                ep.SetError(errobj, errmsg)
            Catch ex As No_InputException
                SystemSounds.Exclamation.Play()
                ep.SetError(errobj, errmsg)
            Catch ex As Exception
                MsgBox(unkownError + bbb)
            Finally
                If Not IsNothing(.con) Then
                    .close()
                End If
            End Try

        End With
    End Sub
    Private Sub btn参照_Click(sender As System.Object, e As System.EventArgs) Handles btn参照.Click
        Dim fbd As New FolderBrowserDialog
        Dim files() As String = Nothing
        Dim cnt As Integer

        '上部に表示する説明テキストを指定する
        fbd.Description = "フォルダを指定してください。"
        'ルートフォルダを指定する
        'デフォルトでDesktop
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        '最初に選択するフォルダを指定する
        'RootFolder以下にあるフォルダである必要がある
        fbd.SelectedPath = "C:\Windows"
        'ユーザーが新しいフォルダを作成できるようにする
        'デフォルトでTrue
        fbd.ShowNewFolderButton = True

        'ダイアログを表示する
        If fbd.ShowDialog(Me) = DialogResult.OK Then
            '選択されたフォルダを表示する
            txtFilePath.Text = fbd.SelectedPath
        End If

        files = System.IO.Directory.GetFiles(txtFilePath.Text, "O*.DAT", System.IO.SearchOption.AllDirectories)

        If IsNothing(files) Then
            MessageBox.Show("対象のファイルがありません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        lstFiles.Items.Clear()
        For cnt = 0 To files.Length - 1 Step 1
            lstFiles.Items.Add(files(cnt))
        Next

    End Sub
    Private Sub setlst1()
        Dim files() As String = Nothing

        lstFiles.Items.Clear()
        files = System.IO.Directory.GetFiles(txtFilePath.Text, "O*.DAT", System.IO.SearchOption.AllDirectories)

        If IsNothing(files) Then
            Exit Sub
        End If

        For cnt = 0 To files.Length - 1 Step 1
            lstFiles.Items.Add(files(cnt))
        Next

        If lstFiles.Items.Count = 0 Then
            btn開始.Enabled = False
        End If
    End Sub
    Private Sub lstFiles_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstFiles.SelectedIndexChanged
        btn開始.Enabled = True
    End Sub

#End Region

#Region "送信"
    Private Sub btn参照2_Click(sender As System.Object, e As System.EventArgs) Handles btn参照2.Click
        Dim fbd As New FolderBrowserDialog

        '上部に表示する説明テキストを指定する
        fbd.Description = "フォルダを指定してください。"
        'ルートフォルダを指定する
        'デフォルトでDesktop
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        '最初に選択するフォルダを指定する
        'RootFolder以下にあるフォルダである必要がある
        fbd.SelectedPath = "C:\Windows"
        'ユーザーが新しいフォルダを作成できるようにする
        'デフォルトでTrue
        fbd.ShowNewFolderButton = True

        'ダイアログを表示する
        If fbd.ShowDialog(Me) = DialogResult.OK Then
            '選択されたフォルダを表示する
            txtFilePath2.Text = fbd.SelectedPath
        End If
    End Sub
    Private Sub btn送信_Click(sender As System.Object, e As System.EventArgs) Handles btn送信.Click
        Dim sql As String = ""
        Dim dt As DataTable = Nothing
        Dim db As db = New db
        Dim errmsg As String = ""
        Dim nowkey As String = ""
        Dim 個人連番 As Integer = 0
        Dim maekey As String = ""
        Dim endflg As Boolean = False
        Dim cnt As Integer
        Dim fname As String = ""
        Dim buff As String = ""
        Dim keys(0) As String
        Dim keyidx As Integer

        With db
            Try
                If txtFilePath2.Text = "" Then
                    MessageBox.Show("出力先フォルダを選択してください。", "選択", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If
                fname = txtFilePath2.Text
                fname += "\R"
                fname += Now.ToString("yyyyMMddHHmmss") + ".DAT"
                lstFiles2.Items.Add(fname)

                If System.IO.File.Exists(fname) Then
                    If MessageBox.Show("同名ファイルが存在します。上書きしますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If

                Using writer As New System.IO.StreamWriter(fname, False, System.Text.Encoding.GetEncoding("shift_jis"))
                    sql = "select distinct a.依頼元KEY,b.日通番 from 結果取込 as a "
                    sql += "inner join 被験者 as b where b.日通番 <> 0 "
                    sql += "and a.依頼元KEY=b.依頼者KEY"
                    dt = .ExecuteSql(sql)
                    If errmsg <> "" Then
                        Throw New DBErrorException(errmsg)
                    End If

                    Array.Resize(keys, dt.Rows.Count)
                    For cnt = 0 To dt.Rows.Count - 1 Step 1
                        keys(cnt) = dt.Rows(cnt).Item("依頼元KEY").ToString
                    Next

                    For keyidx = 0 To keys.Length - 1 Step 1
                        sql = "select * from 結果取込 where 依頼元KEY = '" + keys(keyidx) + "'"
                        dt = .ExecuteSql(sql)
                        For cnt = 0 To dt.Rows.Count - 1 Step 1
                            With dt.Rows(cnt)
                                buff = ""
                                buff += .Item("レコード区分").ToString.Trim + Space(2 - .Item("レコード区分").ToString.Trim.Length)
                                buff += .Item("センターコード").ToString.Trim + Space(6 - .Item("センターコード").ToString.Trim.Length)
                                buff += .Item("依頼元KEY").ToString.Trim + Space(20 - .Item("依頼元KEY").ToString.Trim.Length)
                                buff += .Item("受託者KEY").ToString.Trim + Space(20 - .Item("受託者KEY").ToString.Trim.Length)
                                buff += .Item("被験者名").ToString.Trim + Space(20 - .Item("被験者名").ToString.Trim.Length)
                                'buff += .Item("報告状況コード").ToString.Trim + Space(1 - .Item("報告状況コード").ToString.T
                                buff += "E"
                                buff += .Item("乳び").ToString.ToString.Trim + Space(3 - .Item("乳び").ToString.Trim.Length)
                                buff += .Item("溶血").ToString.Trim + Space(3 - .Item("溶血").ToString.Trim.Length)
                                buff += .Item("ビリルビン").ToString.Trim + Space(3 - .Item("ビリルビン").ToString.Trim.Length)

                                buff += .Item("項目コード1").ToString.Trim + Space(7 - .Item("項目コード1").ToString.Trim.Length)
                                buff += .Item("識別コード1").ToString.Trim + Space(2 - .Item("識別コード1").ToString.Trim.Length)
                                buff += .Item("材料コード1").ToString.Trim + Space(3 - .Item("材料コード1").ToString.Trim.Length)
                                buff += .Item("測定法コード1").ToString.Trim + Space(3 - .Item("測定法コード1").ToString.Trim.Length)
                                buff += .Item("項目コード枝番1").ToString.Trim + Space(2 - .Item("項目コード枝番1").ToString.Trim.Length)
                                buff += Space(8 - .Item("検査結果値1").ToString.Trim.Length) + .Item("検査結果値1").ToString.Trim
                                buff += .Item("検査値形態1").ToString.Trim + Space(1 - .Item("検査値形態1").ToString.Trim.Length)
                                buff += .Item("結果ｺﾒﾝﾄｺｰﾄﾞ11").ToString.Trim + Space(3 - .Item("結果ｺﾒﾝﾄｺｰﾄﾞ11").ToString.Trim.Length)
                                buff += .Item("結果ｺﾒﾝﾄｺｰﾄﾞ21").ToString.Trim + Space(3 - .Item("結果ｺﾒﾝﾄｺｰﾄﾞ21").ToString.Trim.Length)

                                buff += .Item("項目コード2").ToString.Trim + Space(7 - .Item("項目コード2").ToString.Trim.Length)
                                buff += .Item("識別コード2").ToString.Trim + Space(2 - .Item("識別コード2").ToString.Trim.Length)
                                buff += .Item("材料コード2").ToString.Trim + Space(3 - .Item("材料コード2").ToString.Trim.Length)
                                buff += .Item("測定法コード2").ToString.Trim + Space(3 - .Item("測定法コード2").ToString.Trim.Length)
                                buff += .Item("項目コード枝番2").ToString.Trim + Space(2 - .Item("項目コード枝番2").ToString.Trim.Length)
                                buff += Space(8 - .Item("検査結果値2").ToString.Trim.Length) + .Item("検査結果値2").ToString.Trim
                                buff += .Item("検査値形態2").ToString.Trim + Space(1 - .Item("検査値形態2").ToString.Trim.Length)
                                buff += .Item("結果ｺﾒﾝﾄｺｰﾄﾞ12").ToString.Trim + Space(3 - .Item("結果ｺﾒﾝﾄｺｰﾄﾞ12").ToString.Trim.Length)
                                buff += .Item("結果ｺﾒﾝﾄｺｰﾄﾞ22").ToString.Trim + Space(3 - .Item("結果ｺﾒﾝﾄｺｰﾄﾞ22").ToString.Trim.Length)

                                buff += .Item("項目コード3").ToString.Trim + Space(7 - .Item("項目コード3").ToString.Trim.Length)
                                buff += .Item("識別コード3").ToString.Trim + Space(2 - .Item("識別コード3").ToString.Trim.Length)
                                buff += .Item("材料コード3").ToString.Trim + Space(3 - .Item("材料コード3").ToString.Trim.Length)
                                buff += .Item("測定法コード3").ToString.Trim + Space(3 - .Item("測定法コード3").ToString.Trim.Length)
                                buff += .Item("項目コード枝番3").ToString.Trim + Space(2 - .Item("項目コード枝番3").ToString.Trim.Length)
                                buff += Space(8 - .Item("検査結果値3").ToString.Trim.Length) + .Item("検査結果値3").ToString.Trim
                                buff += .Item("検査値形態3").ToString.Trim + Space(1 - .Item("検査値形態3").ToString.Trim.Length)
                                buff += .Item("結果ｺﾒﾝﾄｺｰﾄﾞ13").ToString.Trim + Space(3 - .Item("結果ｺﾒﾝﾄｺｰﾄﾞ13").ToString.Trim.Length)
                                buff += .Item("結果ｺﾒﾝﾄｺｰﾄﾞ23").ToString.Trim + Space(3 - .Item("結果ｺﾒﾝﾄｺｰﾄﾞ23").ToString.Trim.Length)

                                buff += .Item("項目コード4").ToString.Trim + Space(7 - .Item("項目コード4").ToString.Trim.Length)
                                buff += .Item("識別コード4").ToString.Trim + Space(2 - .Item("識別コード4").ToString.Trim.Length)
                                buff += .Item("材料コード4").ToString.Trim + Space(3 - .Item("材料コード4").ToString.Trim.Length)
                                buff += .Item("測定法コード4").ToString.Trim + Space(3 - .Item("測定法コード4").ToString.Trim.Length)
                                buff += .Item("項目コード枝番4").ToString.Trim + Space(2 - .Item("項目コード枝番4").ToString.Trim.Length)
                                buff += Space(8 - .Item("検査結果値4").ToString.Trim.Length) + .Item("検査結果値4").ToString.Trim
                                buff += .Item("検査値形態4").ToString.Trim + Space(1 - .Item("検査値形態4").ToString.Trim.Length)
                                buff += .Item("結果ｺﾒﾝﾄｺｰﾄﾞ14").ToString.Trim + Space(3 - .Item("結果ｺﾒﾝﾄｺｰﾄﾞ14").ToString.Trim.Length)
                                buff += .Item("結果ｺﾒﾝﾄｺｰﾄﾞ24").ToString.Trim + Space(3 - .Item("結果ｺﾒﾝﾄｺｰﾄﾞ24").ToString.Trim.Length)

                                buff += .Item("項目コード5").ToString.Trim + Space(7 - .Item("項目コード5").ToString.Trim.Length)
                                buff += .Item("識別コード5").ToString.Trim + Space(2 - .Item("識別コード5").ToString.Trim.Length)
                                buff += .Item("材料コード5").ToString.Trim + Space(3 - .Item("材料コード5").ToString.Trim.Length)
                                buff += .Item("測定法コード5").ToString.Trim + Space(3 - .Item("測定法コード5").ToString.Trim.Length)
                                buff += .Item("項目コード枝番5").ToString.Trim + Space(2 - .Item("項目コード枝番5").ToString.Trim.Length)
                                buff += Space(8 - .Item("検査結果値5").ToString.Trim.Length) + .Item("検査結果値5").ToString.Trim
                                buff += .Item("検査値形態5").ToString.Trim + Space(1 - .Item("検査値形態5").ToString.Trim.Length)
                                buff += .Item("結果ｺﾒﾝﾄｺｰﾄﾞ15").ToString.Trim + Space(3 - .Item("結果ｺﾒﾝﾄｺｰﾄﾞ15").ToString.Trim.Length)
                                buff += .Item("結果ｺﾒﾝﾄｺｰﾄﾞ25").ToString.Trim + Space(3 - .Item("結果ｺﾒﾝﾄｺｰﾄﾞ25").ToString.Trim.Length)

                                buff += .Item("空白").ToString.Trim + Space(18 - .Item("空白").ToString.Trim.Length)
                                writer.Write(buff + vbCrLf)
                            End With

                        Next
                    Next
                    .close()
                End Using
                My.Settings.OutputPath = txtFilePath2.Text
                My.Settings.Save()
                MessageBox.Show("出力しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As DBErrorException
                MsgBox(errmsg)
            Catch ex As Exception
                MsgBox(unkownError)
            End Try
        End With

    End Sub
    Private Sub lstFiles2_Click(sender As Object, e As System.EventArgs) Handles lstFiles2.Click
        Dim aaa As String = ""
    End Sub

#End Region

#Region "Formイベント"
    Private Sub btn終了_Click(sender As System.Object, e As System.EventArgs) Handles btn終了.Click
        Me.Close()
    End Sub
    Private Sub MainForm_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Dim result As Boolean
        'result = WNetCancelConnection("O:", False)
        'result = WNetCancelConnection("R:", False)
        Me.Dispose()
    End Sub
    Private Sub MainForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("終了します。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.No Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub
    Private Sub MainForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Try
            Dim result As Integer
            'result = WNetAddConnection(My.Settings.INputPath, "", "O:")
            'result = WNetAddConnection(My.Settings.OutputPath, "", "R:")
            result = result

            If txtFilePath.Text <> "" Then
                Call setlst1()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region
 
End Class

