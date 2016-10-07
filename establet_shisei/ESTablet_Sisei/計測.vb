Option Explicit On
#Region "変数等"
Imports System
Imports System.IO.Ports
Imports System.IO
Imports System.ComponentModel
Imports System.Text
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic
#End Region

Public Class 計測

#Region "変数等"
    Private portName As String
    Public errmsg As String = ""
    Private BaudRate As Integer
    Private Parity As IO.Ports.Parity
    Private DataBits As Integer
    Private StopBits As IO.Ports.StopBits
    Private FlowControl As String
    Private 現キー As String = ""
    Private wk As String = ""
    Private si As Serial = New Serial()
    Private usetab As Short
    Public kakutei As Boolean = False
    Private maecombo As Integer
    Private 身長コード, 体重コード, 腹囲コード, 座高コード, 血圧高1コード, 血圧低1コード, 血圧高2コード, 血圧低2コード As String
    Private 右1000コード, 右4000コード, 左1000コード, 左4000コード, 握力右コード, 握力左コード As String
    Dim genflg As Boolean = False
    Private zflg As Boolean = False
    Private AutoFlg As Boolean = False
    Private AutoNo As String

    '指定のINIファイルから文字列を取得する
    <DllImport("KERNEL32.DLL", CharSet:=CharSet.Auto)>
    Public Shared Function GetPrivateProfileString(ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String,
                    ByVal lpReturnedString As System.Text.StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    End Function
#End Region

#Region "初期化"

    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        Me.MinimumSize = New Size(1366, 768)
        Me.MaximumSize = New Size(1366, 768)

        Me.Icon = My.Resources.計測

        Dim strBuffer As New System.Text.StringBuilder
        strBuffer.Capacity = 20   'バッファのサイズを指定
        Dim ret As Integer

        ret = GetPrivateProfileString("身長体重", "身長", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        身長コード = strBuffer.ToString

        ret = GetPrivateProfileString("身長体重", "体重", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        体重コード = strBuffer.ToString

        ret = GetPrivateProfileString("身長体重", "腹囲", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        腹囲コード = strBuffer.ToString

        ret = GetPrivateProfileString("身長体重", "座高", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        座高コード = strBuffer.ToString

        ret = GetPrivateProfileString("血圧", "最高初回", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        血圧高1コード = strBuffer.ToString

        ret = GetPrivateProfileString("血圧", "最低初回", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        血圧低1コード = strBuffer.ToString

        ret = GetPrivateProfileString("血圧", "最高2回", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        血圧高2コード = strBuffer.ToString

        ret = GetPrivateProfileString("血圧", "最低2回", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        血圧低2コード = strBuffer.ToString

        ret = GetPrivateProfileString("聴力", "右1000", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        右1000コード = strBuffer.ToString

        ret = GetPrivateProfileString("聴力", "右4000", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        右4000コード = strBuffer.ToString

        ret = GetPrivateProfileString("聴力", "左1000", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        左1000コード = strBuffer.ToString

        ret = GetPrivateProfileString("聴力", "左4000", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        左4000コード = strBuffer.ToString

        ret = GetPrivateProfileString("握力", "握力（右）", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        握力右コード = strBuffer.ToString

        ret = GetPrivateProfileString("握力", "握力（左）", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        握力左コード = strBuffer.ToString


        se_close()
        Call initComPort()
        Call itemFalse()
        Call itemFalse聴力()

        If chk衣服分.Checked Then
            'lblgen.Visible = True
        End If

    End Sub

    Public Sub initComPort()
        portName = ""
        errmsg = ""
        portName = My.Settings.Port
        BaudRate = My.Settings.Speed
        Select Case My.Settings.Parity
            Case "0"
                Parity = IO.Ports.Parity.Space
            Case "1"
                Parity = IO.Ports.Parity.Mark
            Case "奇数"
                Parity = IO.Ports.Parity.Odd
            Case "偶数"
                Parity = IO.Ports.Parity.Even
            Case "なし"
                Parity = IO.Ports.Parity.None
        End Select
        DataBits = My.Settings.DataBit
        StopBits = My.Settings.StopBit

        Select Case My.Settings.FlowControl
            Case 0
                FlowControl = My.Settings.FlowControl

        End Select
        FlowControl = My.Settings.FlowControl


    End Sub


    Private Sub showinit()
        Call tabchanged()
    End Sub

#End Region

#Region "構造体定義"
    Private Structure format1
        Public レコード区分 As String
        Public センターコード As String
        Public 依頼者KEY As String
        Public 科コード・科名 As String
        Public 病棟コード病棟名 As String
        Public 入院外来区分 As String
        Public 提出医 As String
        Public 被験者ＩＤ As String
        Public カルテNo As String
        Public 被験者名 As String
        Public 性別 As String
        Public 年齢区分 As String
        Public 年齢 As String
        Public 生年月日区分 As String
        Public 年月日 As String
        Public 採取日 As String
        Public 採取時間 As String
        Public 項目数 As String
        Public 身長 As String
        Public 体重 As String
        Public 量 As String
        Public 単位 As String
        Public 妊娠週数 As String
        Public 透析前後 As String
        Public 至急報告 As String
        Public 依頼コメント内容 As String
        Public 予備 As String
    End Structure


    Private Structure format2
        Public レコード区分 As String
        Public センターコード As String
        Public 依頼者KEY As String
        Public 予備 As String
    End Structure

#End Region

#Region "Formイベント"
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnポート設定.Click
        ポート設定.ShowDialog()
    End Sub

    Private 検査項目情報(8) As String

    Private Sub 計測_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If Not IsNothing(sp) Then
            If sp.IsOpen Then
                sp.Close()
                sp.Dispose()
            End If
        End If
        Me.Dispose()
    End Sub

    Private Sub 計測_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("終了します。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub btn終了_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn終了.Click
        Me.Close()
    End Sub
#End Region

#Region "シリアルポート関連"
    'データ受信のためのデリゲート
    Private Delegate Sub myTextSet(ByVal data As String)

    'デリゲート本体
    Public Sub SetText(ByVal str As String)
        RcvDataToTextBox.AppendText(str)
        tmr.Enabled = True

        wk += RcvDataToTextBox.Text
    End Sub

    Private Sub sp_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles sp.DataReceived
        Dim aaa As String = ""

        Dim data As String = ""

        'シリアルポートをオープンしていない場合、処理を行わない.
        If sp.IsOpen = False Then
            Return
        End If


        ' シリアルポートからデータ受信
        Dim dat As Byte() = New Byte(sp.BytesToRead - 1) {}

        sp.Read(dat, 0, dat.GetLength(0))
        data = System.Text.Encoding.GetEncoding("ascii").GetString(dat)
        data = data.Replace(Chr(&H2), "")
        data = data.Replace(Chr(&H3), "")

        RcvDataToTextBox.Invoke(New myTextSet(AddressOf SetText), data)
        'sp.Close()

    End Sub

    Private Function getString(ByVal str As String) As String
        Const STX As String = Chr(&H2)
        Const ETX As String = Chr(&H3)

        If IsNothing(str) Then
            str = ""
        Else
            str = str.Replace(STX, "")
            str = str.Replace(ETX, "")
        End If

        Return str
    End Function

#End Region

#Region "身長・体重"

    Private Sub txt連番_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt連番.GotFocus
        txt身長.Focus()
    End Sub

    Private Sub fukuicheck()
        If chk腹囲.Checked Then
            lbl腹囲.Visible = True
            txt腹囲.Visible = True
            Label5.Visible = True
            txt腹囲少数.Visible = True
            lbl腹囲単位.Visible = True
        Else
            lbl腹囲.Visible = False
            txt腹囲.Visible = False
            Label5.Visible = False
            txt腹囲少数.Visible = False
            lbl腹囲単位.Visible = False
        End If
    End Sub

    Private Sub txt連番_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt連番.Click
        連番選択.oya = txt連番
        連番選択.種別 = "身長体重"
        連番選択.ShowDialog()
    End Sub

    Private Sub itemFalse()
        lbl身長.Enabled = False
        lbl体重.Enabled = False
        lbl腹囲.Enabled = False
        txt身長.Enabled = False
        txt体重.Enabled = False
        txt腹囲.Enabled = False
        Label3.Enabled = False
        Label4.Enabled = False
        Label5.Enabled = False
        txt身長少数.Enabled = False
        txt体重少数.Enabled = False
        txt腹囲少数.Enabled = False
        lbl身長単位.Enabled = False
        lbl体重単位.Enabled = False
        lbl腹囲単位.Enabled = False
        btn登録.Enabled = False
        btn身長計測.Enabled = True
    End Sub

    Public Sub itemTrue()
        lbl身長.Enabled = True
        lbl体重.Enabled = True
        lbl腹囲.Enabled = True
        txt身長.Enabled = True
        txt体重.Enabled = True
        txt腹囲.Enabled = True
        Label3.Enabled = True
        Label4.Enabled = True
        Label5.Enabled = True
        txt身長少数.Enabled = True
        txt体重少数.Enabled = True
        txt腹囲少数.Enabled = True
        lbl身長単位.Enabled = True
        lbl体重単位.Enabled = True
        lbl腹囲単位.Enabled = True
        btn登録.Enabled = True
        btn身長計測.Enabled = True
    End Sub



    Public Sub setcmb身体()
        Dim sql As String = ""
        Dim errmsg As String = ""
        Dim db As db = New db
        Dim dt As DataTable = Nothing
        Dim flg As Boolean = False
        Dim cnt As Integer = 0
        Dim wk() As String = Nothing
        Dim colname As String = ""
        With db
            Try
                zflg = False

                If txt連番.Text = "" Then
                    Call itemFalse()
                    lbl名前.Text = ""
                    Exit Try
                Else
                    Call itemTrue()
                End If

                sql = "select * from 被験者 where 日通番 = " + txt連番.Text
                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If
                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If
                If dt.Rows.Count = 0 Then
                    Exit Try
                End If
                lbl名前.Text = Trim(dt.Rows(0).Item("被験者名").ToString) + " 様"
                現キー = dt.Rows(0).Item("依頼者KEY")
                txtNo.Text = Right_(現キー.Trim, 8)
                If dt.Rows(0).Item("身長体重終了").ToString = "Y" Then
                    flg = True
                End If

                If dt.Rows(0).Item("体重減") = "Y" Then
                    genflg = True
                End If

                .close()
                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                For cnt = 1 To 5 Step 1
                    sql = "select  count(*) as cnt "
                    sql += "from 結果取込 "
                    sql += "where "
                    sql += "(項目コード1 = '0020140' "
                    sql += "or 項目コード2 = '0020140' "
                    sql += "or 項目コード3 = '0020140' "
                    sql += "or 項目コード4 = '0020140' "
                    sql += "or 項目コード5 = '0020140') "
                    sql += "and (依頼元KEY = '現キー')"

                    sql = sql.Replace("現キー", 現キー)
                    dt = .ExecuteSql(sql)
                    If errmsg <> "" Then
                        Throw New DBErrorException(errmsg)
                    End If
                    If dt.Rows(0).Item("cnt") = 0 Then
                        Continue For
                    Else
                        zflg = True
                        Exit For
                    End If
                Next

                If zflg Then
                    '座高があったら学校
                    chk腹囲.Visible = False
                    sql = "select 入力項目表示名称,単位名称,少数桁数 from 検査項目マスタ where 入力項目コード = '座高'"
                    sql = sql.Replace("座高", 座高コード)

                    dt = .ExecuteSql(sql)
                    If errmsg <> "" Then
                        Throw New DBErrorException(errmsg)
                    End If
                    If dt.Rows.Count = 0 Then
                        Exit Sub
                    End If
                    If zflg Then
                        lbl腹囲.Text = dt.Rows(0).Item("入力項目表示名称")
                        lbl腹囲単位.Text = dt.Rows(0).Item("単位名称")
                        txt腹囲少数.MaxLength = dt.Rows(0).Item("少数桁数")
                        lbl腹囲.Visible = True
                        txt腹囲.Visible = True
                        Label5.Visible = True
                        txt腹囲少数.Visible = True
                        lbl腹囲単位.Visible = True
                        chk腹囲.Checked = True
                    End If
                Else
                    chk腹囲.Visible = True
                    sql = "select 入力項目表示名称,単位名称,少数桁数 from 検査項目マスタ where 入力項目コード = '腹囲'"
                    sql = sql.Replace("腹囲", 腹囲コード)

                    dt = .ExecuteSql(sql)
                    lbl腹囲.Text = dt.Rows(0).Item("入力項目表示名称")
                    If errmsg <> "" Then
                        Throw New DBErrorException(errmsg)
                    End If
                    If dt.Rows.Count = 0 Then
                        Exit Sub
                    End If
                End If



                'すべての場合は再表示
                If flg Then
                    For cnt = 1 To 5 Step 1
                        sql = "select 検査結果値%%,個人連番 from 結果取込 "
                        sql += "where 項目コード%% = '身長' "
                        sql += "and trim(検査結果値%%) <> '' "
                        sql += " and 依頼元KEY = '" + 現キー + "'"
                        sql = sql.Replace("%%", cnt.ToString)
                        sql = sql.Replace("身長", 身長コード)

                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Continue For
                        End If
                        If cnt > 5 Then Exit For
                        colname = "検査結果値%%"
                        colname = colname.Replace("%%", cnt.ToString)
                        If Trim(dt.Rows(0).Item(colname)) <> "" Then
                            wk = Trim(dt.Rows(0).Item(colname)).Split(".")
                            txt身長.Text = wk(0)
                            txt身長少数.Text = wk(1)
                        End If
                    Next

                    For cnt = 1 To 5 Step 1
                        sql = "select 検査結果値%%,個人連番 from 結果取込 "
                        sql += "where 項目コード%% = '体重' "
                        sql += "and trim(検査結果値%%) <> '' "
                        sql += " and 依頼元KEY = '" + 現キー + "'"
                        sql = sql.Replace("%%", cnt.ToString)
                        sql = sql.Replace("体重", 体重コード)
                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Continue For
                        End If
                        If cnt > 5 Then Exit For
                        colname = "検査結果値%%"
                        colname = colname.Replace("%%", cnt.ToString)
                        If Trim(dt.Rows(0).Item(colname)) <> "" Then
                            wk = Trim(dt.Rows(0).Item(colname)).Split(".")

                            txt体重.Text = wk(0)
                            txt体重少数.Text = wk(1)

                            If genflg Then
                                'chk衣服分.Checked = True
                                'lblgen.Visible = True
                            Else
                                'chk衣服分.Checked = False
                                'lblgen.Visible = False
                            End If

                        End If
                    Next

                    For cnt = 1 To 5 Step 1
                        sql = "select 検査結果値%%,個人連番 from 結果取込 "
                        sql += "where 項目コード%% = '腹囲座高' "
                        sql += "and trim(検査結果値%%) <> '' "
                        sql += " and 依頼元KEY = '" + 現キー + "'"
                        sql = sql.Replace("%%", cnt.ToString)
                        If Not zflg Then
                            sql = sql.Replace("腹囲座高", 腹囲コード)
                        Else
                            sql = sql.Replace("腹囲座高", 座高コード)
                        End If
                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Continue For
                        End If
                        If cnt > 5 Then Exit For
                        colname = "検査結果値%%"
                        colname = colname.Replace("%%", cnt.ToString)
                        If Trim(dt.Rows(0).Item(colname)) <> "" Then
                            wk = Trim(dt.Rows(0).Item(colname)).Split(".")
                            txt腹囲.Text = wk(0)
                            txt腹囲少数.Text = wk(1)

                            Exit For
                        End If
                    Next
                Else
                    txt身長.Text = ""
                    txt体重.Text = ""
                    txt腹囲.Text = ""
                    txt身長少数.Text = ""
                    txt体重少数.Text = ""
                    txt腹囲少数.Text = ""

                End If
                .close()
            Catch ex As DBErrorException
                MsgBox(errmsg)
            Catch ex As Exception
                MsgBox(unkownError)
            Finally
                If Not IsNothing(.con) Then
                    .close()
                End If
            End Try
        End With
    End Sub

    '身長・身長体重の登録ボタン
    Private Sub btn登録_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn登録.Click
        Dim sql As String = ""
        Dim errmsg As String = ""
        Dim dt As DataTable = Nothing
        Dim db As db = New db
        Dim cnt As Integer
        Dim 個人通番 As Integer
        Dim atai As String = ""
        Dim fukuisql As String = ""
        Dim msg As String
        Dim over As String = ""
        Dim flg As Boolean = True

        With db
            Try
                If sp.IsOpen Then
                    sp.Close()
                End If

                If Not chkNewmeric(txt身長) Then
                    Exit Sub
                End If
                If Not chkNewmeric(txt身長少数) Then
                    Exit Sub
                End If

                If Not chkNewmeric(txt体重) Then
                    Exit Sub
                End If
                If Not chkNewmeric(txt体重少数) Then
                    Exit Sub
                End If
                If chk腹囲.Checked Then
                    If Not chkNewmeric(txt腹囲) Then
                        Exit Sub
                    End If
                    If Not chkNewmeric(txt腹囲少数) Then
                        Exit Sub
                    End If
                End If

                '********************身長閾値***********************
                Select Case chkRange("身長", Decimal.Parse(txt身長.Text + "." + txt身長少数.Text), errmsg)
                    Case 0
                        txt身長.ForeColor = Color.Black
                        txt身長少数.ForeColor = Color.Black
                    Case 1
                        txt身長.ForeColor = Color.Red
                        txt身長少数.ForeColor = Color.Red

                        over = "身長"
                        flg = False
                    Case 9
                        Throw New DBErrorException(errmsg)
                    Case 8
                        Throw New Exception(errmsg)
                End Select

                '********************体重閾値***********************
                Select Case chkRange("体重", Decimal.Parse(txt体重.Text + "." + txt体重少数.Text), errmsg)
                    Case 0
                        txt体重.ForeColor = Color.Black
                        txt体重少数.ForeColor = Color.Black
                    Case 1
                        txt体重.ForeColor = Color.Red
                        txt体重少数.ForeColor = Color.Red

                        If over = "" Then
                            over = "体重"
                        Else
                            over += "・体重"
                        End If
                        flg = False
                    Case 9
                        Throw New DBErrorException(errmsg)
                    Case 8
                        Throw New Exception(errmsg)
                End Select

                '********************腹囲閾値***********************
                If chk腹囲.Checked And Not zflg Then
                    Select Case chkRange("腹囲", Decimal.Parse(txt腹囲.Text + "." + txt腹囲少数.Text), errmsg)
                        Case 0
                            txt腹囲.ForeColor = Color.Black
                            txt腹囲少数.ForeColor = Color.Black
                        Case 1
                            txt腹囲.ForeColor = Color.Red
                            txt腹囲少数.ForeColor = Color.Red

                            If over = "" Then
                                over = "腹囲"
                            Else
                                over += "・腹囲"
                            End If
                            flg = False

                        Case 9
                            Throw New DBErrorException(errmsg)
                        Case 8
                            Throw New Exception(errmsg)
                    End Select
                End If

                If Not flg Then
                    msg = OverRangeMsg.Replace("%%", over)
                    If MessageBox.Show(msg, "閾値確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                        Exit Try
                    End If
                End If


                '身長
                sql = "select * from 結果取込 where 依頼元KEY = '" + 現キー + "' and "
                sql += "(trim(項目コード1)='身長' or "
                sql += "trim(項目コード2)='身長' or "
                sql += "trim(項目コード3)='身長' or "
                sql += "trim(項目コード4)='身長' or "
                sql += "trim(項目コード5)='身長')"
                sql = sql.Replace("身長", 身長コード)

                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                If Not .starttrn(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If
                If dt.Rows.Count > 0 Then
                    For cnt = 1 To 5 Step 1
                        If dt.Rows(0).Item("項目コード$$".Replace("$$", cnt.ToString)) = 身長コード Then
                            個人通番 = dt.Rows(0).Item("個人連番")
                            Exit For
                        End If
                    Next
                    atai = txt身長.Text + "." + txt身長少数.Text
                    atai = Space(8 - atai.Length) + atai
                    sql = "update 結果取込 set 検査結果値" + cnt.ToString + " = '" + atai + "' where 依頼元KEY = '$$依頼元KEY' and 個人連番 = " + 個人通番.ToString
                    sql = sql.Replace("$$依頼元KEY", 現キー)
                    If Not .execNonQTran(sql, errmsg) Then
                        Throw New DBErrorException(errmsg)
                    End If
                Else
                    'Error
                    MessageBox.Show("項目コードがみつかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Try
                End If



                '体重
                sql = "select * from 結果取込 where 依頼元KEY = '" + 現キー + "' and "
                sql += "(項目コード1='体重' or "
                sql += "項目コード2='体重' or "
                sql += "項目コード3='体重' or "
                sql += "項目コード4='体重' or "
                sql += "項目コード5='体重')"
                sql = sql.Replace("体重", 体重コード)

                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If

                If dt.Rows.Count > 0 Then
                    For cnt = 1 To 5 Step 1
                        If dt.Rows(0).Item("項目コード$$".Replace("$$", cnt.ToString)) = 体重コード Then
                            個人通番 = dt.Rows(0).Item("個人連番")
                            Exit For
                        End If
                    Next

                    If chk衣服分.Checked Then
                        '-1Kgします。
                        'atai = (Short.Parse(txt体重.Text) - 1).ToString + "." + txt体重少数.Text
                    Else
                        atai = txt体重.Text + "." + txt体重少数.Text
                    End If
                    atai = Space(8 - atai.Length) + atai
                    sql = "update 結果取込 set 検査結果値" + cnt.ToString + " = '" + atai + "' where 依頼元KEY = '$$依頼元KEY' and 個人連番 = " + 個人通番.ToString
                    sql = sql.Replace("$$依頼元KEY", 現キー)
                    If Not .execNonQTran(sql, errmsg) Then
                        Throw New DBErrorException(errmsg)
                    End If
                Else
                    'Error
                    MessageBox.Show("項目コードがみつかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Try
                End If


                If chk腹囲.Checked Then
                    If Not zflg Then
                        '腹囲
                        sql = "select * from 結果取込 where 依頼元KEY = '" + 現キー + "' and "
                        sql += "(項目コード1='腹囲' or "
                        sql += "項目コード2='腹囲' or "
                        sql += "項目コード3='腹囲' or "
                        sql += "項目コード4='腹囲' or "
                        sql += "項目コード5='腹囲') "
                        sql = sql.Replace("腹囲", 腹囲コード)

                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If

                        If dt.Rows.Count > 0 Then
                            For cnt = 1 To 5 Step 1
                                If dt.Rows(0).Item("項目コード$$".Replace("$$", cnt.ToString)) = 腹囲コード Then
                                    個人通番 = dt.Rows(0).Item("個人連番")
                                    Exit For
                                End If
                            Next
                            atai = txt腹囲.Text + "." + txt腹囲少数.Text
                            atai = Space(8 - atai.Length) + atai
                            sql = "update 結果取込 set 検査結果値" + cnt.ToString + " = '" + atai + "' where 依頼元KEY = '$$依頼元KEY' and 個人連番 = " + 個人通番.ToString
                            sql = sql.Replace("$$依頼元KEY", 現キー)
                            If Not .execNonQTran(sql, errmsg) Then
                                Throw New DBErrorException(errmsg)
                            End If
                            fukuisql = " ,腹囲終了='Y' "
                        Else
                            'Error
                            MessageBox.Show("項目コードがみつかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Try
                        End If
                    Else
                        '座高
                        sql = "select * from 結果取込 where 依頼元KEY = '" + 現キー + "' and "
                        sql += "(項目コード1='座高' or "
                        sql += "項目コード2='座高' or "
                        sql += "項目コード3='座高' or "
                        sql += "項目コード4='座高' or "
                        sql += "項目コード5='座高') "
                        sql = sql.Replace("座高", 座高コード)

                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If

                        If dt.Rows.Count > 0 Then
                            For cnt = 1 To 5 Step 1
                                If dt.Rows(0).Item("項目コード$$".Replace("$$", cnt.ToString)) = 座高コード Then
                                    個人通番 = dt.Rows(0).Item("個人連番")
                                    Exit For
                                End If
                            Next
                            atai = txt腹囲.Text + "." + txt腹囲少数.Text
                            atai = Space(8 - atai.Length) + atai
                            sql = "update 結果取込 set 検査結果値" + cnt.ToString + " = '" + atai + "' where 依頼元KEY = '$$依頼元KEY' and 個人連番 = " + 個人通番.ToString
                            sql = sql.Replace("$$依頼元KEY", 現キー)
                            If Not .execNonQTran(sql, errmsg) Then
                                Throw New DBErrorException(errmsg)
                            End If
                            fukuisql = " ,座高終了='Y' "
                        Else
                            'Error
                            MessageBox.Show("項目コードがみつかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Try
                        End If

                    End If

                End If

                sql = "update 被験者 set 身長体重終了 = 'Y' " + fukuisql + "where 依頼者KEY = '" + 現キー + "'"
                If Not .execNonQTran(sql, errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                'If chk衣服分.Checked Then  '衣服分差し引いたか
                'sql = "update 被験者 set 体重減 = 'Y'  where 依頼者KEY = '" + 現キー + "'"
                'Else
                sql = "update 被験者 set 体重減 = 'N'  where 依頼者KEY = '" + 現キー + "'"
                'End If
                If Not .execNonQTran(sql, errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If


                .committrn()
                .close()
                MessageBox.Show("登録しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If chkGo聴力.Checked Then
                    AutoFlg = True
                    AutoNo = txtNo.Text
                    txtNo聴力.Text = txtNo.Text
                    txt通番聴力.Text = txt連番.Text 
                    tb.SelectedTab = TabPage3
                    Call setcmb聴力()

                Else
                    txtNo.Focus()
                End If
                Call setcmb身体()
                txt連番.Text = ""
                txt身長.Text = ""
                txt体重.Text = ""
                txt腹囲.Text = ""
                txt身長少数.Text = ""
                txt体重少数.Text = ""
                txt腹囲少数.Text = ""
                txtNo.Text = ""
                lbl名前.Text = ""
                Call itemFalse()

            Catch ex As DBErrorException
                .rollbacktran()
                MsgBox(errmsg)
            Catch ex As Exception
                MsgBox(unkownError)
            Finally
                If Not IsNothing(.con) Then
                    .close()
                End If
            End Try
        End With
    End Sub


    Private Sub 計測_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call showinit()

    End Sub

    Private Sub chk腹囲_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk腹囲.CheckedChanged
        Call fukuicheck()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        se_close()
        btn身長計測.Enabled = True
    End Sub


#Region "身長・体重キー移動"
    Private Sub txt身長_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt身長.KeyPress
        'Enterやキーでビープ音が鳴らないようにする
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Or e.KeyChar = "." Then
            txt身長少数.Focus()
            e.Handled = True
        End If
        If Not chkNumeric(e.KeyChar, False) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt身長少数_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt身長少数.KeyPress
        'Enterキーでビープ音が鳴らないようにする
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Or e.KeyChar = "." Then
            e.Handled = True
            txt体重.Focus()
        End If
        If Not chkNumeric(e.KeyChar, False) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt体重_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt体重.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Or e.KeyChar = "." Then
            txt体重少数.Focus()
            e.Handled = True
        End If
        If Not chkNumeric(e.KeyChar, False) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt体重少数_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt体重少数.KeyPress
        'Enterキーでビープ音が鳴らないようにする
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Or e.KeyChar = "." Then
            e.Handled = True
            If chk腹囲.Checked Then
                txt腹囲.Focus()
            Else
                btn登録.Focus()
            End If
        End If
        If Not chkNumeric(e.KeyChar, False) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txt腹囲_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt腹囲.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Or e.KeyChar = "." Then
            txt腹囲少数.Focus()
            e.Handled = True
        End If
        If Not chkNumeric(e.KeyChar, False) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt腹囲少数_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt腹囲少数.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            btn登録.Focus()
        End If
        If Not chkNumeric(e.KeyChar, False) Then
            e.Handled = True
        End If
    End Sub
#End Region

    Private Sub chk衣服分_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk衣服分.Click
        If chk衣服分.Checked Then
            chk衣服分.Checked = True
            'lblgen.Visible = True
        Else
            chk衣服分.Checked = False
            lblgen.Visible = False
        End If
    End Sub


#End Region

#Region "血圧"

    Private Sub txtNo血圧_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNo血圧.TextChanged

    End Sub

    Private Sub lbl名前2_TextChanged(sender As Object, e As System.EventArgs) Handles lbl名前2.TextChanged, lbl名前.TextChanged
        If CType(sender, Label).Name = "lbl名前" Then
            txt身長.Focus()
        Else
            txt最高血圧1.Focus()
        End If
    End Sub

    Private Sub txt通番血圧_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt通番血圧.GotFocus
        txt最高血圧1.Focus()
    End Sub


    Private Sub txt通番血圧_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt通番血圧.Click
        連番選択.oya = txt通番血圧
        連番選択.種別 = "血圧"
        連番選択.ShowDialog()
    End Sub

    Private Sub txt通番血圧_TextChanged(sender As Object, e As System.EventArgs) Handles txt通番血圧.TextChanged, txt連番.TextChanged
        Dim sql As String
        Dim db As db = New db
        Dim dt As DataTable
        Dim tgt As TextBox = Nothing

        With db
            Try
                sql = "select 依頼者KEY from 被験者 where 日通番 = $1"
                sql = sql.Replace("$1", Integer.Parse(sender.Text)).ToString
                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If
                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If
                If dt.Rows.Count = 0 Then
                    Exit Try
                End If
                If CType(sender, TextBox).Name = "txt連番" Then
                    tgt = txtNo
                Else
                    tgt = txtNo血圧
                End If
                tgt.Text = Right_(dt.Rows(0).Item("依頼者KEY").ToString.Trim, 10)
                .close()

                If DirectCast(sender, TextBox).Name = "txt通番血圧" Then
                    Call setcmb血圧()
                Else
                    Call setcmb身体()
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
            Finally
                If Not IsNothing(.con) Then
                    .close()
                End If
            End Try
        End With
    End Sub


    Private Sub txtNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNo.KeyPress, txtNo血圧.KeyPress, txtNo聴力.KeyPress, txtNo握力.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
        End If
        If Not chkNumeric(e.KeyChar, True) Then
            e.Handled = True
        End If

    End Sub


    '血圧の登録ボタン
    Private Sub btn登録2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn登録2.Click
        Dim sql As String = ""
        Dim errmsg As String = ""
        Dim dt As DataTable = Nothing
        Dim db As db = New db
        Dim cnt As Integer
        Dim 個人通番 As Integer
        Dim atai As String = ""
        Dim over As String = ""
        Dim flg As Boolean = True
        Dim msg As String

        If sp.IsOpen Then
            sp.Close()
        End If

        If Not chkNewmeric(txt最高血圧1) Then
            Exit Sub
        End If
        If Not chkNewmeric(txt最低血圧1) Then
            Exit Sub
        End If

        If txt最高血圧2.Text <> "" And txt最低血圧2.Text <> "" Then
            If Not chkNewmeric(txt最高血圧2) Then
                Exit Sub
            End If
            If Not chkNewmeric(txt最低血圧2) Then
                Exit Sub
            End If

        End If

        If Short.Parse(txt最高血圧1.Text) < Short.Parse(txt最低血圧1.Text) Then
            MessageBox.Show("初回最低血圧が初回最高血圧よりも大きいです。", "値異常", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If txt最高血圧2.Text <> "" And txt最低血圧2.Text <> "" Then
            If Short.Parse(txt最高血圧2.Text) < Short.Parse(txt最低血圧2.Text) Then
                MessageBox.Show("二回目最低血圧が初回二回目最高血圧よりも大きいです。", "値異常", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
        End If


        With db
            Try
                '********************最高初回閾値***********************
                Select Case chkRange("血圧", Decimal.Parse(txt最高血圧1.Text), errmsg)
                    Case 0
                        txt最高血圧1.ForeColor = Color.Black
                    Case 1
                        txt最高血圧1.ForeColor = Color.Red

                        over = "最高血圧初回値"
                        flg = False
                    Case 9
                        Throw New DBErrorException(errmsg)
                    Case 8
                        Throw New Exception(errmsg)
                End Select


                '********************最低初回閾値***********************
                Select Case chkRange("血圧", Decimal.Parse(txt最低血圧1.Text), errmsg)
                    Case 0
                        txt最低血圧1.ForeColor = Color.Black
                    Case 1
                        txt最低血圧1.ForeColor = Color.Red

                        If over = "" Then
                            over = "最低血圧初回値"
                        Else
                            over += "・最低血圧初回値"
                        End If
                        flg = False
                    Case 9
                        Throw New DBErrorException(errmsg)
                    Case 8
                        Throw New Exception(errmsg)
                End Select

                '********************最高2回閾値***********************
                If txt最高血圧2.Text <> "" Then
                    Select Case chkRange("血圧", Decimal.Parse(txt最高血圧2.Text), errmsg)
                        Case 0
                            txt最高血圧2.ForeColor = Color.Black
                        Case 1
                            txt最高血圧2.ForeColor = Color.Red

                            If over = "" Then
                                over = "最高血圧2回値"
                            Else
                                over += "・最高血圧2回値"
                            End If
                            flg = False
                        Case 9
                            Throw New DBErrorException(errmsg)
                        Case 8
                            Throw New Exception(errmsg)
                    End Select
                End If


                '********************最低2回閾値***********************
                If txt最低血圧2.Text <> "" Then
                    Select Case chkRange("血圧", Decimal.Parse(txt最低血圧2.Text), errmsg)
                        Case 0
                            txt最低血圧2.ForeColor = Color.Black
                        Case 1
                            txt最低血圧2.ForeColor = Color.Red

                            If over <> "" Then
                                over = "最低血圧2回値"
                            Else
                                over += "・最低血圧2回値"
                            End If
                            flg = False
                        Case 9
                            Throw New DBErrorException(errmsg)
                        Case 8
                            Throw New Exception(errmsg)
                    End Select
                End If

                If Not flg Then
                    msg = OverRangeMsg.Replace("%%", over)
                    If MessageBox.Show(msg, "閾値確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                        Exit Try
                    End If
                End If


                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                '２回めがないとき
                If txt最高血圧2.Text = "" Or txt最低血圧2.Text = "" Then
                    sql = "select * from 閾値 where 名称 = '血圧1回不可'"
                    dt = .ExecuteSql(sql)
                    If IsNothing(dt) Then
                        Throw New DBErrorException(errmsg)
                    End If
                    If Decimal.Parse(txt最高血圧1.Text) > dt.Rows(0).Item("最高") Or Decimal.Parse(txt最低血圧1.Text) > dt.Rows(0).Item("最低") Then
                        MessageBox.Show("２回目の測定が必要です。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        txt最高血圧2.Focus()
                        Exit Try
                    End If
                End If


                '最高血圧  初回値
                sql = "select * from 結果取込 where 依頼元KEY = '" + 現キー + "' and "
                sql += "(項目コード1='最高初回' or "
                sql += "項目コード2='最高初回' or "
                sql += "項目コード3='最高初回' or "
                sql += "項目コード4='最高初回' or "
                sql += "項目コード5='最高初回')"
                sql = sql.Replace("最高初回", 血圧高1コード)


                If Not .starttrn(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If
                If dt.Rows.Count > 0 Then
                    For cnt = 1 To 5 Step 1
                        If dt.Rows(0).Item("項目コード$$".Replace("$$", cnt.ToString)) = 血圧高1コード Then
                            個人通番 = dt.Rows(0).Item("個人連番")
                            Exit For
                        End If
                    Next
                    atai = txt最高血圧1.Text
                    atai = Space(8 - atai.Length) + atai
                    sql = "update 結果取込 set 検査結果値" + cnt.ToString + " = '" + atai + "' where 依頼元KEY = '$$依頼元KEY' and 個人連番 = " + 個人通番.ToString
                    sql = sql.Replace("$$依頼元KEY", 現キー)
                    If Not .execNonQTran(sql, errmsg) Then
                        Throw New DBErrorException(errmsg)
                    End If
                Else
                    'Error
                    MessageBox.Show("項目コードがみつかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Try
                End If


                '最低血圧  初回値
                sql = "select * from 結果取込 where 依頼元KEY = '" + 現キー + "' and "
                sql += "(項目コード1='最低初回' or "
                sql += "項目コード2='最低初回' or "
                sql += "項目コード3='最低初回' or "
                sql += "項目コード4='最低初回' or "
                sql += "項目コード5='最低初回')"
                sql = sql.Replace("最低初回", 血圧低1コード)

                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If

                If dt.Rows.Count > 0 Then
                    For cnt = 1 To 5 Step 1
                        If dt.Rows(0).Item("項目コード$$".Replace("$$", cnt.ToString)) = 血圧低1コード Then
                            個人通番 = dt.Rows(0).Item("個人連番")
                            Exit For
                        End If
                    Next
                    atai = txt最低血圧1.Text
                    atai = Space(8 - atai.Length) + atai
                    sql = "update 結果取込 set 検査結果値" + cnt.ToString + " = '" + atai + "' where 依頼元KEY = '$$依頼元KEY' and 個人連番 = " + 個人通番.ToString
                    sql = sql.Replace("$$依頼元KEY", 現キー)
                    If Not .execNonQTran(sql, errmsg) Then
                        Throw New DBErrorException(errmsg)
                    End If
                Else
                    'Error
                    MessageBox.Show("項目コードがみつかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Try
                End If


                '最高血圧  ２回値
                sql = "select * from 結果取込 where 依頼元KEY = '" + 現キー + "' and "
                sql += "(項目コード1='最高2回' or "
                sql += "項目コード2='最高2回' or "
                sql += "項目コード3='最高2回' or "
                sql += "項目コード4='最高2回' or "
                sql += "項目コード5='最高2回') "
                sql = sql.Replace("最高2回", 血圧高2コード)

                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If

                If dt.Rows.Count > 0 Then
                    For cnt = 1 To 5 Step 1
                        If dt.Rows(0).Item("項目コード$$".Replace("$$", cnt.ToString)) = 血圧高2コード Then
                            個人通番 = dt.Rows(0).Item("個人連番")
                            Exit For
                        End If
                    Next
                    atai = txt最高血圧2.Text
                    atai = Space(8 - atai.Length) + atai
                    sql = "update 結果取込 set 検査結果値" + cnt.ToString + " = '" + atai + "' where 依頼元KEY = '$$依頼元KEY' and 個人連番 = " + 個人通番.ToString
                    sql = sql.Replace("$$依頼元KEY", 現キー)
                    If Not .execNonQTran(sql, errmsg) Then
                        Throw New DBErrorException(errmsg)
                    End If
                Else
                    'Error
                    MessageBox.Show("項目コードがみつかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Try
                End If


                '最低血圧  ２回値
                sql = "select * from 結果取込 where 依頼元KEY = '" + 現キー + "' and "
                sql += "(項目コード1='最低2回' or "
                sql += "項目コード2='最低2回' or "
                sql += "項目コード3='最低2回' or "
                sql += "項目コード4='最低2回' or "
                sql += "項目コード5='最低2回') "
                sql = sql.Replace("最低2回", 血圧低2コード)


                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If

                If dt.Rows.Count > 0 Then
                    For cnt = 1 To 5 Step 1
                        If dt.Rows(0).Item("項目コード$$".Replace("$$", cnt.ToString)) = 血圧低2コード Then
                            個人通番 = dt.Rows(0).Item("個人連番")
                            Exit For
                        End If
                    Next
                    atai = txt最低血圧2.Text
                    atai = Space(8 - atai.Length) + atai
                    sql = "update 結果取込 set 検査結果値" + cnt.ToString + " = '" + atai + "' where 依頼元KEY = '$$依頼元KEY' and 個人連番 = " + 個人通番.ToString
                    sql = sql.Replace("$$依頼元KEY", 現キー)
                    If Not .execNonQTran(sql, errmsg) Then
                        Throw New DBErrorException(errmsg)
                    End If
                Else
                    'Error
                    MessageBox.Show("項目コードがみつかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Try
                End If

                sql = "update 被験者 set 血圧終了 = 'Y' where 依頼者KEY = '" + 現キー + "'"
                If Not .execNonQTran(sql, errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                .committrn()
                .close()
                MessageBox.Show("登録しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call setcmb身体()
                txt通番血圧.Text = ""
                txt最高血圧1.Text = ""
                txt最低血圧1.Text = ""
                txt最高血圧2.Text = ""
                txt最低血圧2.Text = ""
                lbl名前2.Text = ""

                txt最高血圧1.ForeColor = Color.Black
                txt最低血圧1.ForeColor = Color.Black

                Me.AcceptButton = Nothing
                txtNo血圧.Text = ""
                txtNo血圧.Focus()
                Call itemFalse血圧()
            Catch ex As DBErrorException
                .rollbacktran()
                MsgBox(errmsg)
            Catch ex As Exception
                MsgBox(unkownError)
            Finally
                If Not IsNothing(.con) Then
                    .close()
                End If
            End Try
        End With

    End Sub


    Private Sub cmb日通番2_DropDown(ByVal sender As Object, ByVal e As System.EventArgs)
        'Call setCombo2()
    End Sub

    'Private Sub cmb日通番2_DropDownClosed(sender As Object, e As System.EventArgs)
    '        If maecombo <> cmb日通番2.SelectedIndex Then
    '           If txt最高血圧1.Text <> "" Or txt最低血圧1.Text <> "" Or txt最高血圧2.Text <> "" Or txt最低血圧2.Text <> "" Then
    '              If MessageBox.Show("未登録のデータは破棄されます。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
    '                 Call katsuatsuClr(btn血圧クリア1)
    '                Call katsuatsuClr(btn血圧クリア2)
    '           Else
    '              cmb日通番2.SelectedIndex = maecombo
    '             Exit Sub
    '            End If
    '       End If
    '  End If
    'End Sub


    Public Sub setcmb血圧()
        Dim sql As String = ""
        Dim errmsg As String = ""
        Dim db As db = New db
        Dim dt As DataTable = Nothing
        Dim flg As Boolean = False
        Dim colname As String = ""

        ' maecombo = cmb日通番2.SelectedIndex

        With db
            Try
                If txt通番血圧.Text = "" Then
                    Call itemFalse血圧()
                    lbl名前.Text = ""
                    Exit Try
                Else
                    Call itemTrue血圧()
                End If

                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                sql = "select * from 被験者 where 日通番 = " + txt通番血圧.Text
                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If
                lbl名前2.Text = Trim(dt.Rows(0).Item("被験者名").ToString) + " 様"
                現キー = dt.Rows(0).Item("依頼者KEY")
                txtNo血圧.Text = Right_(現キー.Trim, 8)
                If dt.Rows(0).Item("血圧終了").ToString = "Y" Then
                    flg = True
                End If

                'すべての場合は再表示
                If flg Then
                    For cnt = 1 To 5 Step 1
                        sql = "select 検査結果値%%,個人連番 from 結果取込 "
                        sql += "where 項目コード%% = '最高初回' "
                        sql += "and trim(検査結果値%%) <> '' "
                        sql += " and 依頼元KEY = '" + 現キー + "'"
                        sql = sql.Replace("%%", cnt.ToString)
                        sql = sql.Replace("最高初回", 血圧高1コード)
                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Continue For
                        End If
                        If cnt > 5 Then Exit For
                        colname = "検査結果値%%"
                        colname = colname.Replace("%%", cnt.ToString)
                        If Trim(dt.Rows(0).Item(colname)) <> "" Then
                            txt最高血圧1.Text = Trim(dt.Rows(0).Item(colname))
                        End If
                    Next

                    For cnt = 1 To 5 Step 1
                        sql = "select 検査結果値%%,個人連番 from 結果取込 "
                        sql += "where 項目コード%% = '最低初回' "
                        sql += "and trim(検査結果値%%) <> '' "
                        sql += " and 依頼元KEY = '" + 現キー + "'"
                        sql = sql.Replace("%%", cnt.ToString)
                        sql = sql.Replace("最低初回", 血圧低1コード)
                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Continue For
                        End If
                        If cnt > 5 Then Exit For
                        colname = "検査結果値%%"
                        colname = colname.Replace("%%", cnt.ToString)
                        If Trim(dt.Rows(0).Item(colname)) <> "" Then
                            txt最低血圧1.Text = Trim(dt.Rows(0).Item(colname))
                        End If
                    Next

                    For cnt = 1 To 5 Step 1
                        sql = "select 検査結果値%%,個人連番 from 結果取込 "
                        sql += "where 項目コード%% = '最高2回' "
                        sql += "and trim(検査結果値%%) <> '' "
                        sql += " and 依頼元KEY = '" + 現キー + "'"
                        sql = sql.Replace("%%", cnt.ToString)
                        sql = sql.Replace("最高2回", 血圧高2コード)
                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Continue For
                        End If
                        If cnt > 5 Then Exit For
                        colname = "検査結果値%%"
                        colname = colname.Replace("%%", cnt.ToString)
                        If Trim(dt.Rows(0).Item(colname)) <> "" Then
                            txt最高血圧2.Text = Trim(dt.Rows(0).Item(colname))
                        End If
                    Next

                    For cnt = 1 To 5 Step 1
                        sql = "select 検査結果値%%,個人連番 from 結果取込 "
                        sql += "where 項目コード%% = '最低2回' "
                        sql += "and trim(検査結果値%%) <> '' "
                        sql += " and 依頼元KEY = '" + 現キー + "'"
                        sql = sql.Replace("%%", cnt.ToString)
                        sql = sql.Replace("最低2回", 血圧低2コード)
                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Continue For
                        End If
                        If cnt > 5 Then Exit For
                        colname = "検査結果値%%"
                        colname = colname.Replace("%%", cnt.ToString)
                        If Trim(dt.Rows(0).Item(colname)) <> "" Then
                            txt最低血圧2.Text = Trim(dt.Rows(0).Item(colname))
                        End If
                    Next
                Else
                    txt最高血圧1.Text = ""
                    txt最高血圧2.Text = ""
                    txt最低血圧1.Text = ""
                    txt最低血圧2.Text = ""
                End If

                .close()
                txt最高血圧1.Focus()
            Catch ex As DBErrorException
                MsgBox(errmsg)
            Catch ex As Exception
                MsgBox(unkownError)
            End Try
        End With

    End Sub
    '血圧の通番コンボ触った時
    Private Sub cmb日通番2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub


    Private Sub btn血圧クリア1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn血圧クリア1.Click, btn血圧クリア2.Click
        Call katsuatsuClr(sender)
    End Sub

    Private Sub katsuatsuClr(ByVal sender As Object)
        If sender.name = "btn血圧クリア1" Then
            txt最高血圧1.Text = ""
            txt最低血圧1.Text = ""
            txt最高血圧1.Enabled = True
            txt最低血圧1.Enabled = True
        Else
            txt最高血圧2.Text = ""
            txt最低血圧2.Text = ""
            txt最高血圧2.Enabled = True
            txt最低血圧2.Enabled = True
        End If

    End Sub

    Public Sub itemFalse血圧()
        txt最高血圧1.Enabled = False
        txt最高血圧2.Enabled = False
        txt最低血圧1.Enabled = False
        txt最低血圧2.Enabled = False
        btn血圧クリア1.Enabled = False
        btn血圧クリア2.Enabled = False
        btn血圧計測.Enabled = True
        btn登録2.Enabled = False
        lbl最高血圧1.Enabled = False
        lbl最低血圧1.Enabled = False
        lbl最高血圧2.Enabled = False
        lbl最低血圧2.Enabled = False
        lbl最高血圧単位1.Enabled = False
        lbl最低血圧単位1.Enabled = False
        lbl最高血圧単位2.Enabled = False
        lbl最低血圧単位2.Enabled = False
        btn確定.Enabled = False
    End Sub

    Public Sub itemTrue血圧()
        txt最高血圧1.Enabled = True
        txt最低血圧1.Enabled = True
        txt最高血圧2.Enabled = True
        txt最低血圧2.Enabled = True
        btn血圧クリア1.Enabled = True
        btn血圧クリア2.Enabled = True
        btn血圧計測.Enabled = True
        btn登録2.Enabled = True
        lbl最高血圧1.Enabled = True
        lbl最低血圧1.Enabled = True
        lbl最高血圧2.Enabled = True
        lbl最低血圧2.Enabled = True
        lbl最高血圧単位1.Enabled = True
        lbl最低血圧単位1.Enabled = True
        lbl最高血圧単位2.Enabled = True
        lbl最低血圧単位2.Enabled = True
        btn確定.Enabled = True

    End Sub

    Private Sub btn確定_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn確定.Click
        If txt最高血圧1.Text = "" Or txt最低血圧1.Text = "" Then
            Exit Sub
        End If
        If MessageBox.Show("初回値を確定します。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            txt最高血圧1.Enabled = False
            txt最低血圧1.Enabled = False
            btn確定.Enabled = False
            btn血圧クリア1.Enabled = False
        End If
    End Sub
    Private Sub txtNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNo.KeyDown,
        txtNo血圧.KeyDown, txtNo聴力.KeyDown, txtNo握力.KeyDown

        Dim sql As String = ""
        Dim db As db = New db
        Dim dt As DataTable = Nothing
        Dim errmsg As String = ""
        Dim today As String = ""
        Dim errobj As Object = Nothing
        Dim 受診者ID As String = ""
        Dim Barcode As String = ""

        With db
            If e.KeyCode = Keys.Enter Then
                Try
                    If sender.Text.Length >= 8 Then
                        '至聖樣の個人IDは8桁
                        Dim wkobj As TextBox = New TextBox
                        sender.Text = Left_(sender.Text.trim, 8)
                        Barcode = sender.Text
                        wkobj = sender
                        Select Case CType(sender, TextBox).Name
                            Case "txtNo"
                                errobj = txtNo
                                txtNo.Text = CType(sender, TextBox).Text
                            Case "txtNo握力"
                                errobj = txtNo握力
                                txtNo握力.Text = CType(sender, TextBox).Text
                            Case "txtNo血圧"
                                errobj = txtNo血圧
                                txtNo血圧.Text = CType(sender, TextBox).Text
                            Case "txtNo聴力"
                                errobj = txtNo聴力
                                txtNo聴力.Text = CType(sender, TextBox).Text
                        End Select
                    Else
                        Exit Sub
                    End If
                    If Not IsNumeric(sender.Text) Then
                        errmsg = "個人番号が入力されていないか不正な値です。"
                        Throw New FormatException(errmsg)
                        Exit Try
                    End If

                    If Not .connect(errmsg) Then
                        Throw New DBErrorException(errmsg)
                    End If

                    sql = "select 依頼者KEY from 被験者"
                    dt = .ExecuteSql(sql)
                    If errmsg <> "" Then
                        Throw New DBErrorException(errmsg)
                    End If
                    If dt.Rows.Count = 0 Then
                        Exit Try
                    End If
                    today = Left_(dt.Rows(0).Item("依頼者KEY").ToString.Trim, 8)

                    ep.SetError(errobj, Nothing)
                    '受診者ID = Left_(txtNo.Text, 10).Trim
                    '本番はこうなる
                    '受診者ID = "00" + Left_(sender.Text.trim, 8)
                    'sql = "select 依頼者KEY,日通番,被験者名 from 被験者 where rtrim(依頼者KEY) = '" + today + 受診者ID + "' and 日通番 <> 0"
                    sql = "select 依頼者KEY,日通番,被験者名 from 被験者 where rtrim(依頼者KEY) = '" + today + "00" + CType(sender, TextBox).Text + "' and 日通番 <> 0"

                    dt = .ExecuteSql(sql)
                    If errmsg <> "" Then
                        Throw New DBErrorException(errmsg)
                    End If

                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("該当の個人番号がみつかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Exit Try
                    End If
                    Dim wk As Short = dt.Rows(0).Item("日通番")


                    Select Case CType(sender, TextBox).Name
                        Case "txtNo"
                            txt連番.Text = wk.ToString("000")
                            lbl名前.Text = Trim(dt.Rows(0).Item("被験者名").ToString) + " 様"
                            'txtNo.Text = ""

                            Call is検査対象(Barcode, 身長コード, db)
                            Call itemTrue()
                            Call setcmb身体()
                        Case "txtNo血圧"
                            txt通番血圧.Text = wk.ToString("000")
                            lbl名前2.Text = Trim(dt.Rows(0).Item("被験者名").ToString) + " 様"

                            'txtNo血圧.Text = ""
                            Call is検査対象(Barcode, 血圧高1コード, db)
                            Call itemTrue血圧()
                            Call setcmb血圧()
                        Case "txtNo聴力"
                            txt通番聴力.Text = wk.ToString("000")
                            lbl名前聴力.Text = Trim(dt.Rows(0).Item("被験者名").ToString) + " 様"
                            setcmb聴力()
                            cmb右1000.Focus()

                            Call is検査対象(Barcode, 右1000コード, db)
                            Call itemTrue聴力()

                        Case "txtNo握力"
                            txt通番握力.Text = wk.ToString("000")
                            lbl名前握力.Text = Trim(dt.Rows(0).Item("被験者名").ToString) + " 様"
                            cmb右1000.Focus()

                            If Not is検査対象(Barcode, 握力右コード, db) Then
                                txtNo握力.Text = ""
                                txt通番握力.Text = ""
                                lbl名前握力.Text = ""
                                Exit Try
                            End If
                            Call itemTrue握力()
                            Call setcmb握力()

                    End Select

                    .close()
                    If CType(sender, TextBox).Name = "txtNo聴力" Then
                        If chk登録ボタンへ移動する.Checked Then
                            btn聴力登録.Focus()
                        End If
                    End If
                Catch ex As FormatException
                    ep.SetError(errobj, errmsg)
                Catch ex As DBErrorException
                    MsgBox(errmsg)
                Catch ex As Exception
                    MsgBox(unkownError)
                Finally
                    If Not IsNothing(.con) Then
                        .close()
                    End If
                End Try
            End If

        End With

    End Sub

    Private Function is検査対象(code As String, itemcode As String, ByRef db As db) As Boolean
        Dim sql As String = ""
        Dim dt As DataTable
        Dim ret = True

        sql = "select count(*) as cnt from 結果取込 where right(trim(依頼元KEY),8) = '" + code + "' "
        sql += " and (項目コード1 = '" + itemcode + "' or "
        sql += " 項目コード2 = '" + itemcode + "' or "
        sql += " 項目コード3 = '" + itemcode + "' or "
        sql += " 項目コード4 = '" + itemcode + "' or "
        sql += " 項目コード5 = '" + itemcode + "')"
        With db
            dt = .ExecuteSql(sql)
            If dt.Rows(0).Item("cnt") = 0 Then
                ret = False
                MessageBox.Show("対象項目ではありません。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        End With
        Return ret
    End Function


#Region "血圧キー移動"
    Private Sub txt最高血圧1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt最高血圧1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            txt最低血圧1.Focus()
            e.Handled = True
        End If
        If Not chkNumeric(e.KeyChar, True) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt最低血圧1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt最低血圧1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            txt最高血圧2.Focus()
            e.Handled = True
        End If
        If Not chkNumeric(e.KeyChar, True) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt最高血圧2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt最高血圧2.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            txt最低血圧2.Focus()
            e.Handled = True
        End If
        If Not chkNumeric(e.KeyChar, True) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txt最低血圧2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt最低血圧2.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            btn登録2.Focus()
            e.Handled = True
        End If
        If Not chkNumeric(e.KeyChar, True) Then
            e.Handled = True
        End If

    End Sub
#End Region

#End Region

#Region "共用"
    Public Function GetPortNames(ByRef ports() As String) As Boolean
        Try
            ports = SerialPort.GetPortNames()
        Catch ex As Win32Exception
            errmsg = "シリアル ポート名を照会できませんでした。"
        Catch ex As Exception
            errmsg = "不明なエラーです。"
        End Try

        If IsNothing(sp) Then
            Return False
        Else
            Return True
        End If

    End Function


    Private Function chkNewmeric(ByVal chkobj As Object) As Boolean
        Dim errmsg As String = ""

        chkNewmeric = True
        Try
            If Not IsNumeric(chkobj.Text) Then
                errmsg = "値が不正または未入力です。"
                Throw (New FormatException(errmsg))
                Exit Try
            Else
                ep.SetError(chkobj, Nothing)
            End If

        Catch ex As FormatException
            ep.SetError(chkobj, errmsg)
            chkNewmeric = False
        Catch ex As Exception
            chkNewmeric = False
            MsgBox(unkownError)
        End Try

    End Function

    Private Function chkRange(ByVal itemname As String, ByVal val As Decimal, ByRef errmsg As String) As Integer
        Dim sql As String = ""
        Dim dt As DataTable = Nothing
        Dim db As db = New db
        Dim ret As Integer = 0

        With db
            Try
                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If
                sql = "select * from 閾値 where 名称 = '%%'"

                sql = sql.Replace("%%", itemname)
                dt = .ExecuteSql(sql)
                If IsNothing(dt) Then
                    Throw New DBErrorException(errmsg)
                End If
                If val < dt.Rows(0).Item("最低") Or val > dt.Rows(0).Item("最高") Then
                    ret = 1
                End If
                .close()
            Catch ex As DBErrorException
                errmsg = ex.Message
                ret = 9
            Catch ex As Exception
                errmsg = ex.Message
                ret = 8
            Finally
                If Not IsNothing(.con) Then
                    .close()
                End If
            End Try

            Return ret
        End With


    End Function

    '計測開始ボタン　身長・体重と血圧、聴力共用
    Private Sub btn身長計測_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn血圧計測.Click, btn身長計測.Click
        Cursor.Current = Cursors.WaitCursor

        txt最高血圧1.ForeColor = Color.Black
        txt最低血圧1.ForeColor = Color.Black

        Try
            Select Case tb.SelectedIndex
                Case 0
                    '身長体重
                    btn身長計測.Enabled = False
                    If txt身長.Text <> "" Or txt体重.Text <> "" Or txt腹囲.Text <> "" Or txt身長少数.Text <> "" Or txt体重少数.Text <> "" Or txt腹囲少数.Text <> "" Then
                        If MessageBox.Show("未登録のデータは破棄されます。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                            Exit Sub
                        End If
                    End If
                Case 1
                    '血圧
                    btn血圧計測.Enabled = False
                    If txt最高血圧2.Text <> "" Or txt最低血圧2.Text <> "" Then
                        If MessageBox.Show("未登録の2回目のデータは破棄されます。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                            Exit Sub
                        Else
                            txt最高血圧2.Text = ""
                            txt最低血圧2.Text = ""
                            txt最高血圧1.Text = ""
                            txt最低血圧1.Text = ""
                        End If
                    End If
                Case 2
                    '聴力
                    'ありえない
            End Select

            txt身長.Text = ""
            txt体重.Text = ""
            txt腹囲.Text = ""
            txt身長少数.Text = ""
            txt体重少数.Text = ""
            txt腹囲少数.Text = ""

            RcvDataToTextBox.Text = ""
            se_close()
            If Not open() Then
                MessageBox.Show("COMポートを開けません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                btn身長計測.Enabled = True
                sender.enabled = True
                Exit Try

            End If
            受信中.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
            btn身長計測.Enabled = True
            btn血圧計測.Enabled = True
            txt最高血圧1.Text = ""
            txt最低血圧1.Text = ""
            txt最高血圧2.Text = ""
            txt最低血圧2.Text = ""
            txt身長.Text = ""
            txt身長少数.Text = ""
            txt体重.Text = ""
            txt体重少数.Text = ""
            txt腹囲.Text = ""
            txt腹囲少数.Text = ""
        End Try

    End Sub

    Private Sub tb_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles tb.Selected
        Call tabchanged()
    End Sub


    'TABが切り替わった時にする。初期時は身長・身長体重
    Private Sub tabchanged()
        Dim sql As String = ""
        Dim db As db = New db
        Dim dt As DataTable = Nothing
        Dim errmsg As String = ""
        Dim cnt As Integer = Nothing

        With db
            Try
                Select Case tb.SelectedIndex
                    Case 0  '体重・身長
                        Me.Text = "身長・体重測定"
                        btnポート設定.Enabled = True

                        'lbl名前.Text = ""
                        'Call setCombo1()

                        If Not .connect(errmsg) Then
                            Throw New DBErrorException(errmsg)
                        End If

                        sql = "select 入力項目表示名称,単位名称,少数桁数 from 検査項目マスタ where 入力項目コード = '身長'"
                        sql = sql.Replace("身長", 身長コード)

                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Exit Sub
                        End If
                        lbl身長.Text = dt.Rows(0).Item("入力項目表示名称")
                        lbl身長単位.Text = dt.Rows(0).Item("単位名称").ToString
                        txt身長少数.MaxLength = dt.Rows(0).Item("少数桁数")

                        sql = "select 入力項目表示名称,単位名称,少数桁数 from 検査項目マスタ where 入力項目コード = '体重'"
                        sql = sql.Replace("体重", 体重コード)

                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Exit Sub
                        End If
                        lbl体重.Text = dt.Rows(0).Item("入力項目表示名称")
                        lbl体重単位.Text = dt.Rows(0).Item("単位名称")
                        txt体重少数.MaxLength = dt.Rows(0).Item("少数桁数")

                        sql = "select 入力項目表示名称,単位名称,少数桁数 from 検査項目マスタ where 入力項目コード = '腹囲'"
                        sql = sql.Replace("腹囲", 腹囲コード)

                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Exit Sub
                        End If
                        lbl腹囲.Text = dt.Rows(0).Item("入力項目表示名称")
                        lbl腹囲単位.Text = dt.Rows(0).Item("単位名称")
                        txt腹囲少数.MaxLength = dt.Rows(0).Item("少数桁数")

                        .close()
                        Call fukuicheck()

                    Case 1  '血圧
                        Me.Text = "血圧測定"
                        btnポート設定.Enabled = True

                        Call itemFalse血圧()
                        'lbl名前2.Text = ""
                        'Call setCombo2()
                        If Not .connect(errmsg) Then
                            Throw New DBErrorException(errmsg)
                        End If

                        sql = "select 入力項目表示名称,単位名称,少数桁数 from 検査項目マスタ where 入力項目コード = '最高初回'"
                        sql = sql.Replace("最高初回", 血圧高1コード)
                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Exit Sub
                        End If
                        lbl最高血圧1.Text = dt.Rows(0).Item("入力項目表示名称")
                        lbl最高血圧単位1.Text = dt.Rows(0).Item("単位名称")

                        sql = "select 入力項目表示名称,単位名称,少数桁数 from 検査項目マスタ where 入力項目コード = '最低初回'"
                        sql = sql.Replace("最低初回", 血圧低1コード)
                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Exit Sub
                        End If
                        lbl最低血圧1.Text = dt.Rows(0).Item("入力項目表示名称")
                        lbl最低血圧単位1.Text = dt.Rows(0).Item("単位名称")

                        sql = "select 入力項目表示名称,単位名称,少数桁数 from 検査項目マスタ where 入力項目コード = '最高2回'"
                        sql = sql.Replace("最高2回", 血圧高2コード)
                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Exit Sub
                        End If
                        lbl最高血圧2.Text = dt.Rows(0).Item("入力項目表示名称")
                        lbl最高血圧単位2.Text = dt.Rows(0).Item("単位名称")

                        sql = "select 入力項目表示名称,単位名称,少数桁数 from 検査項目マスタ where 入力項目コード = '最低2回'"
                        sql = sql.Replace("最低2回", 血圧低2コード)
                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Exit Sub
                        End If
                        lbl最低血圧2.Text = dt.Rows(0).Item("入力項目表示名称")
                        lbl最低血圧単位2.Text = dt.Rows(0).Item("単位名称")
                        'btn血圧計測.Enabled = True

                    Case 2
                        '聴力

                        If AutoFlg Then
                            txtNo聴力.Text = AutoNo + vbCrLf

                        End If


                        Me.Text = "聴力"
                        btnポート設定.Enabled = False
                        lbl名前聴力.Text = ""
                        cmb右1000.SelectedIndex = 0
                        cmb左1000.SelectedIndex = 0
                        cmb右4000.SelectedIndex = 0
                        cmb左4000.SelectedIndex = 0

                        If Not .connect(errmsg) Then
                            Throw New DBErrorException(errmsg)
                        End If

                        sql = "select 入力項目表示名称,単位名称,少数桁数 from 検査項目マスタ where 入力項目コード = '右1000'"
                        sql = sql.Replace("右1000", 右1000コード)
                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Exit Sub
                        End If
                        lbl右1000.Text = dt.Rows(0).Item("入力項目表示名称")

                        sql = "select 入力項目表示名称,単位名称,少数桁数 from 検査項目マスタ where 入力項目コード = '右4000'"
                        sql = sql.Replace("右4000", 右4000コード)
                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Exit Sub
                        End If
                        lbl右4000.Text = dt.Rows(0).Item("入力項目表示名称")

                        sql = "select 入力項目表示名称,単位名称,少数桁数 from 検査項目マスタ where 入力項目コード = '左1000'"
                        sql = sql.Replace("左1000", 左1000コード)
                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Exit Sub
                        End If
                        lbl左1000.Text = dt.Rows(0).Item("入力項目表示名称")

                        sql = "select 入力項目表示名称,単位名称,少数桁数 from 検査項目マスタ where 入力項目コード = '左4000'"
                        sql = sql.Replace("左4000", 左4000コード)
                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Exit Sub
                        End If
                        lbl左4000.Text = dt.Rows(0).Item("入力項目表示名称")

                    Case 3
                        '握力
                        btnポート設定.Enabled = False
                        itemFalse握力()

                        Me.Text = "握力"

                        If Not .connect(errmsg) Then
                            Throw New DBErrorException(errmsg)
                        End If

                        sql = "select 入力項目表示名称,単位名称,少数桁数 from 検査項目マスタ where 入力項目コード = '握力'"
                        sql = sql.Replace("握力", 握力右コード)

                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Exit Sub
                        End If
                        lbl握力右.Text = dt.Rows(0).Item("入力項目表示名称")
                        lbl握力右単位.Text = dt.Rows(0).Item("単位名称").ToString
                        txt握力右少数.MaxLength = dt.Rows(0).Item("少数桁数")

                        sql = "select 入力項目表示名称,単位名称,少数桁数 from 検査項目マスタ where 入力項目コード = '握力'"
                        sql = sql.Replace("握力", 握力左コード)

                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Exit Sub
                        End If
                        lbl握力左.Text = dt.Rows(0).Item("入力項目表示名称")
                        lbl握力左単位.Text = dt.Rows(0).Item("単位名称")
                        txt握力左少数.MaxLength = dt.Rows(0).Item("少数桁数")

                        .close()


                End Select

            Catch ex As DBErrorException
                MsgBox(errmsg)
            Catch ex As Exception
                MsgBox(unkownError)
            End Try
        End With

    End Sub

    Private Function open() As Boolean
        Try
            errmsg = ""

            ' シリアルポートのオープン
            sp.PortName = portName

            ' シリアルポートの通信速度指定
            sp.BaudRate = BaudRate

            ' シリアルポートのパリティ指定
            'sp.Parity = IO.Ports.Parity.None
            sp.Parity = Parity
            ' シリアルポートのビット数指定

            sp.DataBits = DataBits
            ' シリアルポートのストップビット指定
            'sp.StopBits = IO.Ports.StopBits.One
            sp.StopBits = StopBits

            '文字コードをセットする.
            sp.Encoding = Encoding.ASCII

            sp.Handshake = FlowControl

            sp.ReceivedBytesThreshold = 1

            ' シリアルポートのオープン
            sp.Open()

        Catch ex As UnauthorizedAccessException
            errmsg = "ポートへのアクセスが拒否されています。"
            sp = Nothing
        Catch ex As ArgumentOutOfRangeException
            errmsg = "このインスタンスの 1 つ以上のプロパティが無効です。"
            sp = Nothing
        Catch ex As ArgumentException
            errmsg = "ポート名が 'COM' で始まっていません。"
            sp = Nothing
        Catch ex As IOException
            errmsg = "ポートが無効状態です。"
            sp = Nothing
        Catch ex As InvalidOperationException
            errmsg = "指定されたポートが既に開いています。"
            sp = Nothing
        Catch ex As Exception
            errmsg = "不明なエラーです。"
            sp = Nothing
        End Try

        If IsNothing(sp) Then
            Return False
        Else
            Return True
        End If
    End Function


    Public Function se_close() As Boolean
        Try
            errmsg = ""
            sp.Close()
        Catch ex As IOException
            errmsg = "ポートが無効状態です。"
        Catch ex As Exception
            errmsg = "不明なエラーです。"
        End Try

        If errmsg = "" Then
            Return True
        Else
            Return False
        End If

    End Function



    Public Function clearInBuffer() As Boolean
        Try
            errmsg = ""
            sp.DiscardInBuffer()
        Catch ex As IOException
            errmsg = "ポートが無効状態です。"
        Catch ex As InvalidOperationException
            errmsg = "ストリームが閉じられました。"
            errmsg = "不明なエラーです。"
        End Try

        If errmsg = "" Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function clearOutBuffer() As Boolean
        Try
            errmsg = ""
            sp.DiscardOutBuffer()
        Catch ex As IOException
            errmsg = "ポートが無効状態です。"
        Catch ex As InvalidOperationException
            errmsg = "ストリームが閉じられました。"
            errmsg = "不明なエラーです。"
        End Try

        If errmsg = "" Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Delegate Sub Delegate_RcvDataToTextBox(ByVal data As String)

    Private Sub tmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr.Tick
        tmr.Enabled = False
        'MsgBox(RcvDataToTextBox.Text)

        Try
            btn血圧計測.Enabled = True
            btn身長計測.Enabled = True

            RcvDataToTextBox.Text = RcvDataToTextBox.Text.Replace(Chr(&H2), "") 'STXを除去
            RcvDataToTextBox.Text = RcvDataToTextBox.Text.Replace(Chr(&H3), "") 'ETXを除去
            Select Case tb.SelectedIndex
                Case 0  '身長・体重


                    'Dim dummy = "SY,  169.6cm,1:TZ,   73.0kg,02"
                    'RcvDataToTextBox.Text = dummy
                    Dim data() As String = RcvDataToTextBox.Text.Split(",")
                    Dim atai() As String = data(1).Split(".")
                    txt身長.Text = atai(0).Trim
                    txt身長少数.Text = atai(1).Replace("cm", "").Trim
                    atai = data(3).Split(".")
                    txt体重.Text = atai(0).Trim
                    txt体重少数.Text = atai(1).Replace("kg", "").Trim
                    btn身長計測.Enabled = True

                    Try

                    Catch ex As Exception

                    End Try
                Case 1  '血圧計
                    RcvDataToTextBox.Text = RcvDataToTextBox.Text.Replace("?", "") '謎の"?"を除去
                    'Dim dummy = "390101PM0435155111082vbCr390101PM0435155111082vbCr390101PM0435155111082vbCr"
                    'dummy = dummy.Replace("vbCr", vbCr)
                    'RcvDataToTextBox.Text = dummy
                    Dim data() As String = RcvDataToTextBox.Text.Split(vbCr)

                    If txt最高血圧1.Text = "" Then
                        '1回目
                        If IsNumeric(Mid_(data(0), 13, 3)) Then
                            txt最高血圧1.Text = Mid_(data(0), 13, 3)
                        End If
                        If IsNumeric(Mid_(data(0), 16, 3)) Then
                            txt最低血圧1.Text = Mid_(data(0), 16, 3)
                        End If

                        If IsNumeric(Mid_(data(1), 13, 3)) Then
                            txt最低血圧1.Text = Mid_(data(1), 16, 3)
                        End If

                        If IsNumeric(Mid_(data(1), 16, 3)) Then
                            txt最低血圧1.Text = Mid_(data(1), 16, 3)
                        End If

                        If IsNumeric(Mid_(data(2), 13, 3)) Then
                            txt最低血圧1.Text = Mid_(data(2), 16, 3)
                        End If

                        If IsNumeric(Mid_(data(2), 16, 3)) Then
                            txt最低血圧1.Text = Mid_(data(2), 16, 3)
                        End If

                        '必ず確定 2013/08/10
                        'btn確定.Enabled = False
                        'txt最高血圧1.Enabled = False
                        'txt最低血圧1.Enabled = False

                        Dim sql As StringBuilder = New StringBuilder
                        Dim dt As DataTable
                        Dim db As db = New db
                        sql.Clear()

                        'GoTo skip
                        With db
                            If Not .connect(errmsg) Then
                                Throw New DBErrorException(errmsg)
                            End If
                            sql.Append("select * from 閾値 where 名称 = '血圧1回不可'")
                            dt = .ExecuteSql(sql.ToString)
                            If errmsg <> "" Then
                                Throw New DBErrorException(errmsg)
                            End If
                            If dt.Rows.Count = 0 Then
                                Exit Sub
                            End If

                            If Short.Parse(txt最高血圧1.Text) > Short.Parse(dt.Rows(0).Item("最高")) Then
                                txt最高血圧1.ForeColor = Color.Red
                            Else
                                txt最高血圧1.ForeColor = Color.Black
                            End If

                            If Short.Parse(txt最低血圧1.Text) > Short.Parse(dt.Rows(0).Item("最低")) Then
                                txt最低血圧1.ForeColor = Color.Red
                            Else
                                txt最低血圧1.ForeColor = Color.Black
                            End If
                            .close()
                        End With
skip:
                        Me.AcceptButton = btn登録2
                        btn血圧クリア1.Enabled = True
                    Else
                        '2回目
                        If IsNumeric(Mid_(data(0), 13, 3)) Then
                            txt最高血圧2.Text = Mid_(data(0), 13, 3)
                        End If
                        If IsNumeric(Mid_(data(0), 16, 3)) Then
                            txt最低血圧2.Text = Mid_(data(0), 16, 3)
                        End If

                        If IsNumeric(Mid_(data(1), 13, 3)) Then
                            txt最低血圧2.Text = Mid_(data(1), 16, 3)
                        End If

                        If IsNumeric(Mid_(data(1), 16, 3)) Then
                            txt最低血圧2.Text = Mid_(data(1), 16, 3)
                        End If

                        If IsNumeric(Mid_(data(2), 13, 3)) Then
                            txt最低血圧2.Text = Mid_(data(2), 16, 3)
                        End If

                        If IsNumeric(Mid_(data(2), 16, 3)) Then
                            txt最低血圧2.Text = Mid_(data(2), 16, 3)
                        End If

                    End If
            End Select
            Cursor.Current = Cursors.Default
            If tb.SelectedIndex = 0 Then
                btn身長計測.Enabled = True
            Else
                btn身長計測.Enabled = True
            End If
            Me.Enabled = True
            sp.Close()
        Catch ex As DBErrorException
            MsgBox(errmsg)
        Catch ex As Exception
            MsgBox(unkownError)
        Finally
            受信中.Close()
            受信中.Dispose()
            btn身長計測.Enabled = True
            btn血圧計測.Enabled = True

            'txt最高血圧1.Text = ""
            'txt最低血圧1.Text = ""
            'txt最高血圧2.Text = ""
            'txt最低血圧2.Text = ""
            'txt身長.Text = ""
            'txt身長少数.Text = ""
            'txt体重.Text = ""
            'txt体重少数.Text = ""
            'txt腹囲.Text = ""
            'txt腹囲少数.Text = ""
        End Try
    End Sub

    Private Sub btn選択確定_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn選択確定.Click
        If MessageBox.Show("「" + tb.SelectedTab.Text + "」" + "に機能を固定します。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Select Case tb.SelectedIndex
                Case 0
                    usetab = 1
                Case 1
                    usetab = 2
                Case 2
                    usetab = 3
            End Select
            kakutei = True
            btn選択確定.Enabled = False
        End If
    End Sub

    Private Sub tb_Selecting(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles tb.Selecting
        If kakutei Then
            If e.TabPageIndex + 1 <> usetab Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Function chkNumeric(ByVal keychar As Char, ByVal ten As Boolean) As Boolean
        chkNumeric = True

        Select Case keychar
            Case "."
                If ten Then
                    chkNumeric = False
                    Exit Select
                End If
            Case Microsoft.VisualBasic.ChrW(Keys.Delete)
            Case Microsoft.VisualBasic.ChrW(Keys.Tab)
            Case Microsoft.VisualBasic.ChrW(Keys.Back)
            Case "0", "1", "2", "3", "4", "5,", "6", "7", "8", "9"
            Case Else
                chkNumeric = False
        End Select
    End Function



#End Region


#Region "聴力"

    Private Sub txt通番聴力_Click(sender As Object, e As System.EventArgs) Handles txt通番聴力.Click
        連番選択.oya = txt通番聴力
        連番選択.種別 = "聴力"
        連番選択.ShowDialog()
        cmb右1000.Focus()
    End Sub


    Private Sub btn聴力登録_Click(sender As System.Object, e As System.EventArgs) Handles btn聴力登録.Click
        Dim chkobj As ComboBox = New ComboBox
        Dim sql As String = ""
        Dim db As db = New db
        Dim dt As DataTable = Nothing
        Dim errmsg As String = ""

        Try
            If cmb右1000.SelectedIndex = -1 Then
                chkobj = cmb右1000
                Throw (New FormatException(errmsg))
            Else
                ep.SetError(chkobj, Nothing)
            End If

            If cmb右4000.SelectedIndex = -1 Then
                chkobj = cmb右4000
                Throw (New FormatException(errmsg))
            Else
                ep.SetError(chkobj, Nothing)
            End If

            If cmb左1000.SelectedIndex = -1 Then
                chkobj = cmb左1000
                Throw (New FormatException(errmsg))
            Else
                ep.SetError(chkobj, Nothing)
            End If

            If cmb左4000.SelectedIndex = -1 Then
                chkobj = cmb左4000
                Throw (New FormatException(errmsg))
            Else
                ep.SetError(chkobj, Nothing)
            End If

        Catch ex As FormatException
            errmsg = "選択してください。"
            ep.SetError(chkobj, errmsg)
            Exit Sub
        Catch ex As Exception
            MsgBox(unkownError)
            Exit Sub
        End Try

        With db
            Try
                Dim atai As String = ""
                Dim 個人通番 As Integer
                Dim cnt As Integer

                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                '右1000
                sql = "select * from 結果取込 where 依頼元KEY = '" + 現キー + "' and "
                sql += "(trim(項目コード1)='右1000' or "
                sql += "trim(項目コード2)='右1000' or "
                sql += "trim(項目コード3)='右1000' or "
                sql += "trim(項目コード4)='右1000' or "
                sql += "trim(項目コード5)='右1000')"
                sql = sql.Replace("右1000", 右1000コード)

                If Not .starttrn(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If
                If dt.Rows.Count > 0 Then
                    For cnt = 1 To 5 Step 1
                        If dt.Rows(0).Item("項目コード$$".Replace("$$", cnt.ToString)) = 右1000コード Then
                            個人通番 = dt.Rows(0).Item("個人連番")
                            Exit For
                        End If
                    Next
                    atai = IIf(cmb右1000.SelectedIndex = 0, "ｼﾖｹﾝﾅｼ", "ｼﾖｹﾝｱﾘ")
                    atai = atai + Space(8 - atai.Length)
                    sql = "update 結果取込 set 検査結果値" + cnt.ToString + " = '" + atai + "' where 依頼元KEY = '$$依頼元KEY' and 個人連番 = " + 個人通番.ToString
                    sql = sql.Replace("$$依頼元KEY", 現キー)
                    If Not .execNonQTran(sql, errmsg) Then
                        Throw New DBErrorException(errmsg)
                    End If
                Else
                    'Error
                    MessageBox.Show("項目コードがみつかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Try
                End If

                '右4000
                sql = "select * from 結果取込 where 依頼元KEY = '" + 現キー + "' and "
                sql += "(trim(項目コード1)='右4000' or "
                sql += "trim(項目コード2)='右4000' or "
                sql += "trim(項目コード3)='右4000' or "
                sql += "trim(項目コード4)='右4000' or "
                sql += "trim(項目コード5)='右4000')"
                sql = sql.Replace("右4000", 右4000コード)

                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If
                If dt.Rows.Count > 0 Then
                    For cnt = 1 To 5 Step 1
                        If dt.Rows(0).Item("項目コード$$".Replace("$$", cnt.ToString)) = 右4000コード Then
                            個人通番 = dt.Rows(0).Item("個人連番")
                            Exit For
                        End If
                    Next
                    atai = IIf(cmb右4000.SelectedIndex = 0, "ｼﾖｹﾝﾅｼ", "ｼﾖｹﾝｱﾘ")
                    atai = Space(8 - atai.Length) + atai
                    sql = "update 結果取込 set 検査結果値" + cnt.ToString + " = '" + atai + "' where 依頼元KEY = '$$依頼元KEY' and 個人連番 = " + 個人通番.ToString
                    sql = sql.Replace("$$依頼元KEY", 現キー)
                    If Not .execNonQTran(sql, errmsg) Then
                        Throw New DBErrorException(errmsg)
                    End If
                Else
                    'Error
                    MessageBox.Show("項目コードがみつかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Try
                End If

                '左1000
                sql = "select * from 結果取込 where 依頼元KEY = '" + 現キー + "' and "
                sql += "(trim(項目コード1)='左1000' or "
                sql += "trim(項目コード2)='左1000' or "
                sql += "trim(項目コード3)='左1000' or "
                sql += "trim(項目コード4)='左1000' or "
                sql += "trim(項目コード5)='左1000')"
                sql = sql.Replace("左1000", 左1000コード)

                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If
                If dt.Rows.Count > 0 Then
                    For cnt = 1 To 5 Step 1
                        If dt.Rows(0).Item("項目コード$$".Replace("$$", cnt.ToString)) = 左1000コード Then
                            個人通番 = dt.Rows(0).Item("個人連番")
                            Exit For
                        End If
                    Next
                    atai = IIf(cmb左1000.SelectedIndex = 0, "ｼﾖｹﾝﾅｼ", "ｼﾖｹﾝｱﾘ")
                    atai = Space(8 - atai.Length) + atai
                    sql = "update 結果取込 set 検査結果値" + cnt.ToString + " = '" + atai + "' where 依頼元KEY = '$$依頼元KEY' and 個人連番 = " + 個人通番.ToString
                    sql = sql.Replace("$$依頼元KEY", 現キー)
                    If Not .execNonQTran(sql, errmsg) Then
                        Throw New DBErrorException(errmsg)
                    End If
                Else
                    'Error
                    MessageBox.Show("項目コードがみつかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Try
                End If

                '左4000
                sql = "select * from 結果取込 where 依頼元KEY = '" + 現キー + "' and "
                sql += "(trim(項目コード1)='左4000' or "
                sql += "trim(項目コード2)='左4000' or "
                sql += "trim(項目コード3)='左4000' or "
                sql += "trim(項目コード4)='左4000' or "
                sql += "trim(項目コード5)='左4000')"
                sql = sql.Replace("左4000", 左4000コード)

                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If
                If dt.Rows.Count > 0 Then
                    For cnt = 1 To 5 Step 1
                        If dt.Rows(0).Item("項目コード$$".Replace("$$", cnt.ToString)) = 左4000コード Then
                            個人通番 = dt.Rows(0).Item("個人連番")
                            Exit For
                        End If
                    Next
                    atai = IIf(cmb左4000.SelectedIndex = 0, "ｼﾖｹﾝﾅｼ", "ｼﾖｹﾝｱﾘ")
                    atai = Space(8 - atai.Length) + atai
                    sql = "update 結果取込 set 検査結果値" + cnt.ToString + " = '" + atai + "' where 依頼元KEY = '$$依頼元KEY' and 個人連番 = " + 個人通番.ToString
                    sql = sql.Replace("$$依頼元KEY", 現キー)
                    If Not .execNonQTran(sql, errmsg) Then
                        Throw New DBErrorException(errmsg)
                    End If
                Else
                    'Error
                    MessageBox.Show("項目コードがみつかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Try
                End If


                sql = "update 被験者 set 聴力終了 ='Y' where 依頼者KEY = '$$依頼者KEY'"
                sql = sql.Replace("$$依頼者KEY", 現キー)
                If Not .execNonQTran(sql, errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If
                .committrn()
                .close()

                MessageBox.Show("登録しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call setcmb聴力()
                cmb右1000.SelectedIndex = 0
                cmb左1000.SelectedIndex = 0
                cmb右4000.SelectedIndex = 0
                cmb左4000.SelectedIndex = 0
                txtNo聴力.Text = ""
                txt通番聴力.Text = ""
            Catch ex As DBErrorException
                .rollbacktran()
                MsgBox(errmsg)
            Catch ex As Exception
                .rollbacktran()
                MsgBox(unkownError)
            Finally
                If Not IsNothing(.con) Then
                    .close()
                End If
            End Try
        End With
    End Sub

    Public Sub itemTrue聴力()
        lbl右1000.Enabled = True
        lbl左1000.Enabled = True
        lbl右4000.Enabled = True
        lbl左4000.Enabled = True
        cmb右1000.Enabled = True
        cmb左1000.Enabled = True
        cmb右4000.Enabled = True
        cmb左4000.Enabled = True
        btn聴力登録.Enabled = True
    End Sub

    Public Sub itemFalse聴力()
        lbl右1000.Enabled = False
        lbl左1000.Enabled = False
        lbl右4000.Enabled = False
        lbl左4000.Enabled = False
        cmb右1000.Enabled = False
        cmb左1000.Enabled = False
        cmb右4000.Enabled = False
        cmb左4000.Enabled = False
        btn聴力登録.Enabled = False
    End Sub

    Public Sub setcmb聴力()
        Dim sql As String = ""
        Dim errmsg As String = ""
        Dim db As db = New db
        Dim dt As DataTable = Nothing
        Dim flg As Boolean = False
        Dim colname As String = ""


        With db
            Try
                If txt通番聴力.Text = "" Then
                    Call itemFalse聴力()
                    lbl名前.Text = ""
                    Exit Try
                Else
                    Call itemTrue聴力()
                End If

                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                sql = "select * from 被験者 where 日通番 = " + Integer.Parse(txt通番聴力.Text).ToString
                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If
                lbl名前聴力.Text = Trim(dt.Rows(0).Item("被験者名").ToString) + " 様"
                現キー = dt.Rows(0).Item("依頼者KEY")
                txtNo聴力.Text = Right_(現キー.Trim, 8)
                If dt.Rows(0).Item("聴力終了").ToString = "Y" Then
                    flg = True
                End If

                If flg Then
                    For cnt = 1 To 5 Step 1
                        sql = "select 検査結果値%%,個人連番 from 結果取込 "
                        sql += "where 項目コード%% = '右1000' "
                        sql += "and trim(検査結果値%%) <> '' "
                        sql += " and 依頼元KEY = '" + 現キー + "'"
                        sql = sql.Replace("%%", cnt.ToString)
                        sql = sql.Replace("右1000", 右1000コード)
                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Continue For
                        End If
                        If cnt > 5 Then Exit For
                        colname = "検査結果値%%"
                        colname = colname.Replace("%%", cnt.ToString)
                        If Trim(dt.Rows(0).Item(colname)) <> "" Then
                            cmb右1000.SelectedIndex = IIf(Trim(dt.Rows(0).Item(colname)) = "ｼﾖｹﾝﾅｼ", 0, 1)
                        End If
                    Next

                    For cnt = 1 To 5 Step 1
                        sql = "select 検査結果値%%,個人連番 from 結果取込 "
                        sql += "where 項目コード%% = '右4000' "
                        sql += "and trim(検査結果値%%) <> '' "
                        sql += " and 依頼元KEY = '" + 現キー + "'"
                        sql = sql.Replace("%%", cnt.ToString)
                        sql = sql.Replace("右4000", 右4000コード)
                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Continue For
                        End If
                        If cnt > 5 Then Exit For
                        colname = "検査結果値%%"
                        colname = colname.Replace("%%", cnt.ToString)
                        If Trim(dt.Rows(0).Item(colname)) <> "" Then
                            cmb右4000.SelectedIndex = IIf(Trim(dt.Rows(0).Item(colname)) = "ｼﾖｹﾝﾅｼ", 0, 1)
                        End If
                    Next

                    For cnt = 1 To 5 Step 1
                        sql = "select 検査結果値%%,個人連番 from 結果取込 "
                        sql += "where 項目コード%% = '左1000' "
                        sql += "and trim(検査結果値%%) <> '' "
                        sql += " and 依頼元KEY = '" + 現キー + "'"
                        sql = sql.Replace("%%", cnt.ToString)
                        sql = sql.Replace("左1000", 左1000コード)
                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Continue For
                        End If
                        If cnt > 5 Then Exit For
                        colname = "検査結果値%%"
                        colname = colname.Replace("%%", cnt.ToString)
                        If Trim(dt.Rows(0).Item(colname)) <> "" Then
                            cmb左1000.SelectedIndex = IIf(Trim(dt.Rows(0).Item(colname)) = "ｼﾖｹﾝﾅｼ", 0, 1)
                        End If
                    Next

                    For cnt = 1 To 5 Step 1
                        sql = "select 検査結果値%%,個人連番 from 結果取込 "
                        sql += "where 項目コード%% = '左4000' "
                        sql += "and trim(検査結果値%%) <> '' "
                        sql += " and 依頼元KEY = '" + 現キー + "'"
                        sql = sql.Replace("%%", cnt.ToString)
                        sql = sql.Replace("左4000", 左4000コード)
                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Continue For
                        End If
                        If cnt > 5 Then Exit For
                        colname = "検査結果値%%"
                        colname = colname.Replace("%%", cnt.ToString)
                        If Trim(dt.Rows(0).Item(colname)) <> "" Then
                            cmb左4000.SelectedIndex = IIf(Trim(dt.Rows(0).Item(colname)) = "ｼﾖｹﾝﾅｼ", 0, 1)
                        End If
                    Next
                Else
                    cmb右1000.SelectedIndex = 0
                    cmb左1000.SelectedIndex = 0
                    cmb右4000.SelectedIndex = 0
                    cmb左4000.SelectedIndex = 0
                End If

                .close()
                cmb右1000.Focus()
            Catch ex As DBErrorException
                MsgBox(errmsg)
            Catch ex As Exception
                MsgBox(unkownError)
            Finally
                If Not IsNothing(.con) Then
                    .close()
                End If
            End Try
        End With

    End Sub


    Private Sub txtNo聴力_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNo聴力.TextChanged

    End Sub

    Private Sub txt通番聴力_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt通番聴力.TextChanged

    End Sub

#End Region


#Region "握力"
    Public Sub itemTrue握力()
        lbl握力右.Enabled = True
        lbl握力左.Enabled = True
        txt握力右整数.Enabled = True
        txt握力左整数.Enabled = True
        lbl握力右小数点.Enabled = True
        lbl握力左小数点.Enabled = True
        txt握力右少数.Enabled = True
        txt握力左少数.Enabled = True
        lbl握力右単位.Enabled = True
        lbl握力左単位.Enabled = True
        btn握力登録.Enabled = True
    End Sub

    Public Sub itemFalse握力()
        lbl握力右.Enabled = False
        lbl握力左.Enabled = False
        txt握力右整数.Enabled = False
        txt握力左整数.Enabled = False
        lbl握力右小数点.Enabled = False
        lbl握力左小数点.Enabled = False
        txt握力右少数.Enabled = False
        txt握力左少数.Enabled = False
        lbl握力右単位.Enabled = False
        lbl握力左単位.Enabled = False
        btn握力登録.Enabled = False
    End Sub

    Private Sub txt通番握力_Click(sender As Object, e As System.EventArgs) Handles txt通番握力.Click
        連番選択.oya = txt通番握力
        連番選択.種別 = "握力"
        連番選択.ShowDialog()
        txt握力右整数.Focus()
    End Sub

    Public Sub setcmb握力()
        Dim sql As String = ""
        Dim errmsg As String = ""
        Dim db As db = New db
        Dim dt As DataTable = Nothing
        Dim flg As Boolean = False
        Dim colname As String = ""


        With db
            Try
                If txt通番握力.Text = "" Then
                    Call itemFalse握力()
                    lbl名前.Text = ""
                    Exit Try
                Else
                    Call itemTrue握力()
                End If

                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                sql = "select * from 被験者 where 日通番 = " + Integer.Parse(txt通番握力.Text).ToString
                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If
                lbl名前握力.Text = Trim(dt.Rows(0).Item("被験者名").ToString) + " 様"
                現キー = dt.Rows(0).Item("依頼者KEY")
                txtNo握力.Text = Right_(現キー.Trim, 8)
                If dt.Rows(0).Item("握力終了").ToString = "Y" Then
                    flg = True
                End If

                If flg Then
                    For cnt = 1 To 5 Step 1
                        sql = "select 検査結果値%%,個人連番 from 結果取込 "
                        sql += "where 項目コード%% = '握力右' "
                        sql += "and trim(検査結果値%%) <> '' "
                        sql += " and 依頼元KEY = '" + 現キー + "'"
                        sql = sql.Replace("%%", cnt.ToString)
                        sql = sql.Replace("握力右", 握力右コード)
                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Continue For
                        End If
                        If cnt > 5 Then Exit For
                        colname = "検査結果値%%"
                        colname = colname.Replace("%%", cnt.ToString)
                        If Trim(dt.Rows(0).Item(colname)) <> "" Then
                            Dim wk() As String
                            wk = Trim(dt.Rows(0).Item(colname)).Split(".")
                            txt握力右整数.Text = wk(0)
                            txt握力右少数.Text = wk(1)
                        End If
                    Next

                    For cnt = 1 To 5 Step 1
                        sql = "select 検査結果値%%,個人連番 from 結果取込 "
                        sql += "where 項目コード%% = '握力左' "
                        sql += "and trim(検査結果値%%) <> '' "
                        sql += " and 依頼元KEY = '" + 現キー + "'"
                        sql = sql.Replace("%%", cnt.ToString)
                        sql = sql.Replace("握力左", 握力左コード)
                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        If dt.Rows.Count = 0 Then
                            Continue For
                        End If
                        If cnt > 5 Then Exit For
                        colname = "検査結果値%%"
                        colname = colname.Replace("%%", cnt.ToString)
                        If Trim(dt.Rows(0).Item(colname)) <> "" Then
                            Dim wk() As String
                            wk = Trim(dt.Rows(0).Item(colname)).Split(".")
                            txt握力左整数.Text = wk(0)
                            txt握力左少数.Text = wk(1)
                        End If
                    Next
                End If

                .close()
                txt握力右整数.Focus()
            Catch ex As DBErrorException
                MsgBox(errmsg)
            Catch ex As Exception
                MsgBox(unkownError)
            Finally
                If Not IsNothing(.con) Then
                    .close()
                End If
            End Try
        End With

    End Sub

    '握力の登録ボタン
    Private Sub btn握力登録_Click(sender As System.Object, e As System.EventArgs) Handles btn握力登録.Click

        Dim sql As String = ""
        Dim errmsg As String = ""
        Dim dt As DataTable = Nothing
        Dim db As db = New db
        Dim cnt As Integer
        Dim 個人通番 As Integer
        Dim atai As String = ""
        Dim fukuisql As String = ""
        Dim over As String = ""
        Dim flg As Boolean = True

        With db
            Try
                If sp.IsOpen Then
                    sp.Close()
                End If

                If Not chkNewmeric(txt握力右整数) Then
                    Exit Sub
                End If
                If Not chkNewmeric(txt握力右少数) Then
                    Exit Sub
                End If

                If Not chkNewmeric(txt握力左整数) Then
                    Exit Sub
                End If
                If Not chkNewmeric(txt握力左少数) Then
                    Exit Sub
                End If

                '握力右
                sql = "select * from 結果取込 where 依頼元KEY = '" + 現キー + "' and "
                sql += "(trim(項目コード1)='握力右' or "
                sql += "trim(項目コード2)='握力右' or "
                sql += "trim(項目コード3)='握力右' or "
                sql += "trim(項目コード4)='握力右' or "
                sql += "trim(項目コード5)='握力右')"
                sql = sql.Replace("握力右", 握力右コード)

                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                If Not .starttrn(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If
                If dt.Rows.Count > 0 Then
                    For cnt = 1 To 5 Step 1
                        If dt.Rows(0).Item("項目コード$$".Replace("$$", cnt.ToString)) = 握力右コード Then
                            個人通番 = dt.Rows(0).Item("個人連番")
                            Exit For
                        End If
                    Next
                    atai = txt握力右整数.Text + "." + txt握力右少数.Text
                    atai = Space(8 - atai.Length) + atai
                    sql = "update 結果取込 set 検査結果値" + cnt.ToString + " = '" + atai + "' where 依頼元KEY = '$$依頼元KEY' and 個人連番 = " + 個人通番.ToString
                    sql = sql.Replace("$$依頼元KEY", 現キー)
                    If Not .execNonQTran(sql, errmsg) Then
                        Throw New DBErrorException(errmsg)
                    End If
                Else
                    'Error
                    MessageBox.Show("項目コードがみつかりません。握力右" + sql, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Try
                End If



                '握力左
                sql = "select * from 結果取込 where 依頼元KEY = '" + 現キー + "' and "
                sql += "(項目コード1='握力左' or "
                sql += "項目コード2='握力左' or "
                sql += "項目コード3='握力左' or "
                sql += "項目コード4='握力左' or "
                sql += "項目コード5='握力左')"
                sql = sql.Replace("握力左", 握力左コード)

                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If

                If dt.Rows.Count > 0 Then
                    For cnt = 1 To 5 Step 1
                        If dt.Rows(0).Item("項目コード$$".Replace("$$", cnt.ToString)) = 握力左コード Then
                            個人通番 = dt.Rows(0).Item("個人連番")
                            Exit For
                        End If
                    Next

                    If chk衣服分.Checked Then
                        '-1Kgします。
                        atai = (Short.Parse(txt握力左整数.Text) - 1).ToString + "." + txt握力左少数.Text
                    Else
                        atai = txt握力左整数.Text + "." + txt握力左少数.Text
                    End If
                    atai = Space(8 - atai.Length) + atai
                    sql = "update 結果取込 set 検査結果値" + cnt.ToString + " = '" + atai + "' where 依頼元KEY = '$$依頼元KEY' and 個人連番 = " + 個人通番.ToString
                    sql = sql.Replace("$$依頼元KEY", 現キー)
                    If Not .execNonQTran(sql, errmsg) Then
                        Throw New DBErrorException(errmsg)
                    End If
                Else
                    'Error
                    MessageBox.Show("項目コードがみつかりません。握力左", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Try
                End If

                sql = "update 被験者 set 握力終了 = 'Y' " + fukuisql + "where 依頼者KEY = '" + 現キー + "'"
                If Not .execNonQTran(sql, errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                .committrn()
                .close()
                MessageBox.Show("登録しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call setcmb身体()
                txt通番握力.Text = ""
                txt握力右整数.Text = ""
                txt握力右少数.Text = ""
                txt握力左整数.Text = ""
                txt握力左少数.Text = ""
                txtNo握力.Text = ""
                lbl名前.Text = ""
                Call itemFalse握力()
                txtNo握力.Focus()
            Catch ex As DBErrorException
                .rollbacktran()
                MsgBox(errmsg)
            Catch ex As Exception
                MsgBox(unkownError)
            Finally
                If Not IsNothing(.con) Then
                    .close()
                End If
            End Try
        End With
    End Sub


    Private Sub txt握力右整数_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt握力右整数.KeyPress
        'Enterやキーでビープ音が鳴らないようにする
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Or e.KeyChar = "." Then
            txt握力右少数.Focus()
            e.Handled = True
        End If
        If Not chkNumeric(e.KeyChar, False) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txt握力右少数_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt握力右少数.KeyPress
        'Enterやキーでビープ音が鳴らないようにする
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Or e.KeyChar = "." Then
            txt握力左整数.Focus()
            e.Handled = True
        End If
        If Not chkNumeric(e.KeyChar, False) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txt握力左整数_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt握力左整数.KeyPress
        'Enterやキーでビープ音が鳴らないようにする
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Or e.KeyChar = "." Then
            txt握力左少数.Focus()
            e.Handled = True
        End If
        If Not chkNumeric(e.KeyChar, False) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txt握力左少数_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt握力左少数.KeyPress
        'Enterやキーでビープ音が鳴らないようにする
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Or e.KeyChar = "." Then
            btn握力登録.Focus()
            e.Handled = True
        End If
        If Not chkNumeric(e.KeyChar, False) Then
            e.Handled = True
        End If
    End Sub

#End Region




    Private Sub txtNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNo.TextChanged

    End Sub

    Private Sub txtNo聴力_MouseCaptureChanged(sender As Object, e As System.EventArgs) Handles txtNo聴力.MouseCaptureChanged

    End Sub
End Class