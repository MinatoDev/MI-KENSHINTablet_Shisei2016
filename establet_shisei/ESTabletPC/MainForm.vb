﻿Imports System.Runtime.InteropServices
Imports System.Text

Public Class MainForm

#Region "変数等"
    Private nowrow As Integer
    Private maecombo As Integer = -1
    Private 視力自動通番 As String
    Private 視力自動移動 As Boolean = False
    Private Const WM_USER = &H400

    Private ColsHead As DataTable = New DataTable

    Private Enum colNum
        通番 = 0
        個人番号
        お名前
        裸眼右
        裸眼左
        矯正右
        矯正左
        裸眼右・学校
        裸眼左・学校
        矯正右・学校
        矯正左・学校
        身長
        体重
        腹囲
        座高
        握力右
        握力左
        最高血圧初回
        最低血圧初回
        最高血圧２回
        最低血圧２回
        聴力右1000
        聴力左1000
        聴力右4000
        聴力左4000
        尿糖
        尿蛋白
        尿ウロビリ
        尿潜血
        内科診察
    End Enum

    Private Enum tabs
        受付 = 0
        通過管理 = 2
        端末管理 = 3
        視力 = 1
        結果表示 = 4
        未受付一覧 = 5
    End Enum

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
        Me.Icon = My.Resources.受付管理

        Me.MinimumSize = New Size(1366, 768)
        Me.MaximumSize = New Size(1366, 768)

        lblMsg1.Text = ""
        lblMsg2.Text = ""
        txtNo.Text = ""
        txtNo.Focus()

        setEnabl(False)
        dgv.AllowUserToAddRows = False       'データ追加禁止
        dgv.RowCount = 1
        dgv.ReadOnly = True                  '編集禁止
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect  '行選択モード
        dgv.RowHeadersVisible = False        'Rowヘッダは非表示
        dgv.MultiSelect = True               '複数行選択許可
        dgv.AllowUserToResizeRows = False    '行の高さの変更禁止
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Red
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        '並び替えができないようにする
        For Each c As DataGridViewColumn In dgv.Columns
            c.SortMode = DataGridViewColumnSortMode.NotSortable
        Next c

        PictureBox1.Image = My.Resources.estSVlogo

        chk身長体重.title = "身長・体重"
        chk身長体重.chkchar = "済"
        chk身長体重.checked = False

        chk腹囲.title = "腹囲"
        chk腹囲.chkchar = "済"
        chk腹囲.checked = False

        chk座高.title = "座高"
        chk座高.chkchar = "済"
        chk座高.checked = False

        chk血圧.title = "血圧"
        chk血圧.chkchar = "済"
        chk血圧.checked = False

        chk視力.title = "視力"
        chk視力.chkchar = "済"
        chk視力.checked = False

        chk聴力.title = "聴力"
        chk聴力.chkchar = "済"
        chk聴力.checked = False

        chk尿検査.title = "尿検査"
        chk尿検査.chkchar = "済"
        chk尿検査.checked = False

        chk診察.title = "診察"
        chk診察.chkchar = "済"
        chk診察.checked = False

        chk胸部X線.title = "胸部X線"
        chk胸部X線.chkchar = "済"
        chk胸部X線.checked = False

        chk腹部X線.title = "胃部X線"
        chk腹部X線.chkchar = "済"
        chk腹部X線.checked = False

        chk採血.title = "採血"
        chk採血.chkchar = "済"
        chk採血.checked = False

        chk心電図.title = "心電図"
        chk心電図.chkchar = "済"
        chk心電図.checked = False

        chk眼底検査.title = "眼底検査"
        chk眼底検査.chkchar = "済"
        chk眼底検査.checked = False

        chk腹部エコー.title = "腹部エコー"
        chk腹部エコー.chkchar = "済"
        chk腹部エコー.checked = False

        chk握力.title = "握力"
        chk握力.chkchar = "済"
        chk握力.checked = False

        chkその他.title = "その他"
        chkその他.chkchar = "済"
        chkその他.checked = False
        txtNo.Text = ""

        '視力
        cmb通番視力.IntegralHeight = False
        dp.IntegralHeight = False

        cmb裸眼右.IntegralHeight = False
        cmb裸眼左.IntegralHeight = False
        cmb矯正右.IntegralHeight = False
        cmb矯正左.IntegralHeight = False

        chkItem視力.title = "視力"
        chkItem視力.chkchar = "✓"
        chkItem視力.checked = True
        chkItem視力.callhandle = Me.Handle

        chkItem血圧.title = "血圧"
        chkItem血圧.chkchar = "✓"
        chkItem血圧.checked = True
        chkItem血圧.callhandle = Me.Handle

        chkItem検尿.title = "検尿"
        chkItem検尿.chkchar = "✓"
        chkItem検尿.checked = True
        chkItem検尿.callhandle = Me.Handle

        chkItem腹囲.title = "腹囲"
        chkItem腹囲.chkchar = "✓"
        chkItem腹囲.checked = True
        chkItem腹囲.callhandle = Me.Handle

        chkItem座高.title = "座高"
        chkItem座高.chkchar = "✓"
        chkItem座高.checked = True
        chkItem座高.callhandle = Me.Handle

        chkItem身長体重.title = "身長体重"
        chkItem身長体重.chkchar = "✓"
        chkItem身長体重.checked = True
        chkItem身長体重.callhandle = Me.Handle

        chkItem聴力.title = "聴力"
        chkItem聴力.chkchar = "✓"
        chkItem聴力.checked = True
        chkItem聴力.callhandle = Me.Handle

        chkItem握力.title = "握力"
        chkItem握力.chkchar = "✓"
        chkItem握力.checked = True
        chkItem握力.callhandle = Me.Handle


        chkItem内科検診.title = "内科検診"
        chkItem内科検診.chkchar = "✓"
        chkItem内科検診.checked = True
        chkItem内科検診.callhandle = Me.Handle



        '結果表示のカラムのため
        Dim colidx As Short = 0
        Dim strBuffer As New System.Text.StringBuilder

        ColsHead.Columns.Add("colString", GetType(String))
        ColsHead.Columns.Add("group", GetType(String))
        ColsHead.Columns.Add("pos", GetType(Short))
        ColsHead.Columns.Add("width", GetType(Short))
        ColsHead.Columns.Add("code", GetType(String))
        ColsHead.Columns.Add("enabled", GetType(Boolean))

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "通番"
        ColsHead.Rows(colidx).Item("pos") = colNum.通番
        ColsHead.Rows(colidx).Item("width") = 115
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "個人番号"
        ColsHead.Rows(colidx).Item("pos") = colNum.個人番号
        ColsHead.Rows(colidx).Item("width") = 220
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "お名前"
        ColsHead.Rows(colidx).Item("pos") = colNum.お名前
        ColsHead.Rows(colidx).Item("width") = 300
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "裸眼右"
        ColsHead.Rows(colidx).Item("group") = "視力"
        ColsHead.Rows(colidx).Item("pos") = colNum.裸眼右
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("視力", "裸眼視力右", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "裸眼左"
        ColsHead.Rows(colidx).Item("group") = "視力"
        ColsHead.Rows(colidx).Item("pos") = colNum.裸眼左
        ColsHead.Rows(colidx).Item("width") = 1400
        GetPrivateProfileString("視力", "裸眼視力左", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "矯正右"
        ColsHead.Rows(colidx).Item("group") = "視力"
        ColsHead.Rows(colidx).Item("pos") = colNum.矯正右
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("視力", "矯正視力右", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "矯正左"
        ColsHead.Rows(colidx).Item("group") = "視力"
        ColsHead.Rows(colidx).Item("pos") = colNum.矯正左
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("視力", "矯正視力左", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1


        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "裸眼右・学"
        ColsHead.Rows(colidx).Item("group") = "視力"
        ColsHead.Rows(colidx).Item("pos") = colNum.裸眼右・学校
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("視力", "裸眼視力（右）　学校用", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "裸眼左・学"
        ColsHead.Rows(colidx).Item("group") = "視力"
        ColsHead.Rows(colidx).Item("pos") = colNum.裸眼左・学校
        ColsHead.Rows(colidx).Item("width") = 1400
        GetPrivateProfileString("視力", "裸眼視力（左）　学校用", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "矯正右・学"
        ColsHead.Rows(colidx).Item("group") = "視力"
        ColsHead.Rows(colidx).Item("pos") = colNum.矯正右・学校
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("視力", "矯正視力（右）　学校用", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "矯正左・学"
        ColsHead.Rows(colidx).Item("group") = "視力"
        ColsHead.Rows(colidx).Item("pos") = colNum.矯正左・学校
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("視力", "矯正視力（左）　学校用", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1


        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "身長"
        ColsHead.Rows(colidx).Item("group") = "身長体重"
        ColsHead.Rows(colidx).Item("pos") = colNum.身長
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("身長体重", "身長", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "体重"
        ColsHead.Rows(colidx).Item("group") = "身長体重"
        ColsHead.Rows(colidx).Item("pos") = colNum.体重
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("身長体重", "体重", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "腹囲"
        ColsHead.Rows(colidx).Item("group") = "腹囲"
        ColsHead.Rows(colidx).Item("pos") = colNum.腹囲
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("身長体重", "腹囲", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "座高"
        ColsHead.Rows(colidx).Item("group") = "座高"
        ColsHead.Rows(colidx).Item("pos") = colNum.座高
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("身長体重", "座高", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "握力右"
        ColsHead.Rows(colidx).Item("group") = "握力"
        ColsHead.Rows(colidx).Item("pos") = colNum.握力右
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("握力", "握力（右）", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "握力左"
        ColsHead.Rows(colidx).Item("group") = "握力"
        ColsHead.Rows(colidx).Item("pos") = colNum.握力左
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("握力", "握力（左）", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "最高血圧初回"
        ColsHead.Rows(colidx).Item("group") = "血圧"
        ColsHead.Rows(colidx).Item("pos") = colNum.最高血圧初回
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("血圧", "最高初回", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "最低血圧初回"
        ColsHead.Rows(colidx).Item("group") = "血圧"
        ColsHead.Rows(colidx).Item("pos") = colNum.最低血圧初回
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("血圧", "最低初回", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "最高血圧２回"
        ColsHead.Rows(colidx).Item("group") = "血圧"
        ColsHead.Rows(colidx).Item("pos") = colNum.最高血圧２回
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("血圧", "最高2回", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "最低血圧２回"
        ColsHead.Rows(colidx).Item("group") = "血圧"
        ColsHead.Rows(colidx).Item("pos") = colNum.最低血圧２回
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("血圧", "最低2回", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "聴力右1000"
        ColsHead.Rows(colidx).Item("group") = "聴力"
        ColsHead.Rows(colidx).Item("pos") = colNum.聴力右1000
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("聴力", "右1000", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "聴力左1000"
        ColsHead.Rows(colidx).Item("group") = "聴力"
        ColsHead.Rows(colidx).Item("pos") = colNum.聴力左1000
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("聴力", "左1000", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "聴力右4000"
        ColsHead.Rows(colidx).Item("group") = "聴力"
        ColsHead.Rows(colidx).Item("pos") = colNum.聴力右4000
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("聴力", "右4000", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "聴力左4000"
        ColsHead.Rows(colidx).Item("group") = "聴力"
        ColsHead.Rows(colidx).Item("pos") = colNum.聴力左4000
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("聴力", "左4000", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "尿糖"
        ColsHead.Rows(colidx).Item("group") = "尿検査"
        ColsHead.Rows(colidx).Item("pos") = colNum.尿糖
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("尿検査", "尿糖", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "尿蛋白"
        ColsHead.Rows(colidx).Item("group") = "尿検査"
        ColsHead.Rows(colidx).Item("pos") = colNum.尿蛋白
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("尿検査", "尿蛋白", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "尿ウロビリ"
        ColsHead.Rows(colidx).Item("group") = "尿検査"
        ColsHead.Rows(colidx).Item("pos") = colNum.尿ウロビリ
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("尿検査", "尿ウロビリ", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "尿潜血"
        ColsHead.Rows(colidx).Item("group") = "尿検査"
        ColsHead.Rows(colidx).Item("pos") = colNum.尿潜血
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("尿検査", "尿潜血", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
        colidx += 1

        ColsHead.Rows.Add()
        ColsHead.Rows(colidx).Item("colString") = "内科診察"
        ColsHead.Rows(colidx).Item("group") = "内科検診"
        ColsHead.Rows(colidx).Item("pos") = colNum.内科診察
        ColsHead.Rows(colidx).Item("width") = 140
        GetPrivateProfileString("内科検診", "診察", "", strBuffer, strBuffer.Capacity, ".\code.ini")
        ColsHead.Rows(colidx).Item("code") = strBuffer.ToString
        ColsHead.Rows(colidx).Item("enabled") = True
    End Sub

#End Region
#Region "Formイベント"
    Private Sub MainForm_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated

        Select Case tab.SelectedIndex
            Case tabs.受付
                txtNo.Focus()
            Case tabs.通過管理
                btn完了.Focus()
            Case tabs.端末管理
            Case tabs.視力

        End Select

    End Sub
    Private Sub MainForm_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
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
        Call showinit()
    End Sub
    Private Sub btn終了_Click(sender As System.Object, e As System.EventArgs) Handles btn終了.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub dp_ValueChanged(sender As Object, e As System.EventArgs)
        Call showinit()
    End Sub

    Private Sub dp_DropDownClosed(sender As Object, e As System.EventArgs) Handles dp.DropDownClosed
        Call setfocusText()


    End Sub
    Private Sub dp_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles dp.SelectedIndexChanged
        Call setfocusText()
        Call setDantaiName()
    End Sub

#End Region

    Private Sub setDantaiName()

        Dim ymd As String = dp.Text.Replace("/", String.Empty)

        Dim db As db = New db
        Dim errmsg As String = String.Empty

        With db
            Try
                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                Dim sql As String = String.Format("select distinct 予備 as 団体名 from 被験者 where left(依頼者KEY, 8) = '{0}'", ymd)
                Using dt As DataTable = .ExecuteSql(sql)
                    If errmsg <> String.Empty Then
                        Throw New DBErrorException(errmsg)
                    End If

                    cmb団体名.Items.Clear()
                    cmb団体名.Items.Add("全て")
                    For Each nm As DataRow In dt.Rows
                        cmb団体名.Items.Add(nm("団体名"))
                    Next
                End Using
                cmb団体名.SelectedIndex = 0
            Catch ex As DBErrorException
                MsgBox(errmsg)
            Catch ex As Exception
                MsgBox(unkownError)
            End Try

        End With
    End Sub

#Region "受付"
    Private Sub txtNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNo.KeyDown
        Dim sql As String = ""
        Dim db As db = New db
        Dim dt As DataTable = Nothing
        Dim errmsg As String = ""
        Dim today As String = ""
        Dim errobj As Object = Nothing
        Dim 受診者ID As String = ""

        With db
            If e.KeyCode = Keys.Enter Then
                Try
                    If txtNo.Text.Length > 8 Then
                        '至聖樣の個人IDは8桁
                        txtNo.Text = Left_(txtNo.Text, 8)
                    End If
                    errobj = txtNo
                    If Not IsNumeric(txtNo.Text) Then
                        errmsg = "個人番号が入力されていないか不正な値です。"
                        Throw New FormatException(errmsg)
                        Exit Try
                    End If
                    ep.SetError(errobj, Nothing)
                    '受診者ID = Left_(txtNo.Text, 10).Trim
                    '本番はこうなる
                    受診者ID = "00" + Left_(txtNo.Text, 8).Trim

                    today = Date.Parse(dp.Text).ToString("yyyyMMdd")
                    sql = "select 依頼者KEY,日通番,被験者名 from 被験者 where rtrim(依頼者KEY) = '" + today + 受診者ID + "' "
                    If Not cmb団体名.Text = "全て" Then
                        sql += "and 予備 = '{0}'"
                        sql = String.Format(sql, cmb団体名.Text)
                    End If
                    If Not .connect(errmsg) Then
                        Throw New DBErrorException(errmsg)
                    End If

                    dt = .ExecuteSql(sql)
                    If errmsg <> "" Then
                        Throw New DBErrorException(errmsg)
                    End If

                    If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                        MessageBox.Show("該当の個人番号がみつかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Exit Try
                    End If


                    '受付済み？
                    If dt.Rows(0).Item("日通番") <> 0 Then
                        If chkExitItem(Date.Parse(dp.Text).ToString("yyyyMMdd") + "00" + txtNo.Text.Trim, "0030101") Then
                            If MessageBox.Show("個人番号" + txtNo.Text.Trim + "の方は連番" + dt.Rows(0).Item("日通番").ToString + "で受付済みです。" + vbCrLf + "通過管理を行いますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                tab.SelectedTab = tp通過管理
                                txt通番2.Text = dt.Rows(0).Item("日通番").ToString
                                Call チェック状態表示()
                                Exit Try
                            Else
                                txtNo.Text = ""
                                txtNo.Focus()
                                Exit Try
                            End If
                        End If
                    End If

                    lblName.Text = Trim(dt.Rows(0).Item("被験者名").ToString) + " 様"

                    sql = "update 被験者 set 日通番 = " + (Integer.Parse(txt通番.Text) + 1).ToString + " where  依頼者KEY = '" + Date.Parse(dp.Text).ToString("yyyyMMdd") + "00" + txtNo.Text.Trim + "  '"
                    If Not .execNonQ(sql, errmsg) Then
                        Throw New DBErrorException(errmsg)
                    End If

                    sql = "update 発番 set 通番 = 通番 + 1"
                    If Not .execNonQ(sql, errmsg) Then
                        Throw New DBErrorException(errmsg)
                    End If

                    lblMsg1.Text = "個人番号" + txtNo.Text + "は通番"
                    lblMsg2.Text = "で登録しました。"

                    txt通番.Text = (Integer.Parse(txt通番.Text) + 1).ToString("000")

                    sql = "select count(*) as cnt from 被験者 where 日通番 <> 0"
                    dt = .ExecuteSql(sql)
                    If errmsg <> "" Then
                        Throw New DBErrorException(errmsg)
                    End If
                    lbl人数.Text = dt.Rows(0).Item("cnt").ToString

                    .close()

                    If chkAuto.Checked Then
                        If chkExitItem(Date.Parse(dp.Text).ToString("yyyyMMdd") + "00" + txtNo.Text.Trim, "0030101") Then
                            '視力に行きます
                            視力自動通番 = txt通番.Text
                            cmb通番視力.Text = 視力自動通番
                            tab.SelectedTab = 視力
                            視力自動移動 = True
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
                    txtNo.Focus()
                    txtNo.Text = ""
                End Try
            End If

        End With
    End Sub
    Private Sub txt修正_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt修正.KeyPress
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub
    Private Sub btn修正_Click(sender As System.Object, e As System.EventArgs) Handles btn修正.Click
        Dim sql As String = ""
        Dim db As db = New db
        Dim errmsg As String = ""

        If txt修正.Text = String.Empty Then
            Exit Sub
        End If
        If Integer.Parse(txt修正.Text) < Integer.Parse(txt通番.Text) Then
            MessageBox.Show("発行済の通番より小さい値には設定できません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not IsNumeric(txt修正.Text) Then
            MessageBox.Show("入力された値が不正です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        txt通番.Text = Integer.Parse(txt修正.Text).ToString("000")
        txtNo.Focus()

        With db
            Try
                sql = "update 発番 set 通番 = " + txt修正.Text
                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If
                If Not .execNonQ(sql, errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

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
    Private Sub showinit()
        Dim sql As String = ""
        Dim dt As DataTable = Nothing
        Dim db As db = New db
        Dim errmsg As String = ""
        Dim fromdate As Date
        Dim cnt As Integer

        txtNo.Focus()
        Me.ActiveControl = Me.txtNo

        With db
            Try
                fromdate = Now.AddDays(-90)
                For cnt = 0 To 180 Step 1
                    dp.Items.Add(fromdate.ToString("yyyy/MM/dd"))
                    fromdate = fromdate.AddDays(1)
                Next

                dp.Text = Now.ToString("yyyy/MM/dd")

                sql = "select count(*) as cnt from 被験者 where 日通番 <> 0 and left(依頼者KEY,8) = '" + Date.Parse(dp.Text).ToString("yyyyMMdd") + "'"
                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If
                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If
                If dt.Rows(0).Item("cnt") = 0 Then
                    txt通番.Text = "000"
                    Exit Try
                Else
                    lbl人数.Text = dt.Rows(0).Item("cnt").ToString
                    sql = "select 通番 as mx from 発番"
                    dt = .ExecuteSql(sql)
                    If IsDBNull((dt.Rows(0).Item("mx"))) Then
                        Exit Try
                    End If
                    txt通番.Text = Integer.Parse(dt.Rows(0).Item("mx")).ToString("000")
                End If


                .close()
            Catch ex As DBErrorException
                MsgBox(ex.Message)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If Not IsNothing(.con) Then
                    .close()
                End If
            End Try
        End With


    End Sub
    Private Sub txt通番_GotFocus(sender As Object, e As System.EventArgs) Handles txt通番.GotFocus
        txtNo.Focus()
    End Sub
    Private Sub btnなし_Click(sender As System.Object, e As System.EventArgs) Handles btnなし.Click
        Dim sql As String = ""
        Dim errmsg = ""
        Dim db As db = New db

        lblMsg1.Text = "通番"
        lblMsg2.Text = "はスキップされました"

        txtNo.Focus()
        txtNo.Text = ""
        txt通番.Text = (Integer.Parse(txt通番.Text) + 1).ToString("000")
        With db
            Try
                sql = "update 発番 set 通番 = 通番 + 1"
                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If
                If Not .execNonQ(sql, errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If
                .close()
            Catch ex As DBErrorException
                MsgBox(errmsg)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If Not IsNothing(.con) Then
                    .close()
                End If
            End Try
        End With


    End Sub
    Private Sub setfocusText()
        Select Case tab.SelectedIndex
            Case 0
                Dim sql As String = ""
                Dim errmsg As String = ""
                Dim dt As DataTable = Nothing
                Dim db As db = New db
                With db
                    Try
                        sql = "select max(通番) as mx from 発番"
                        If Not .connect(errmsg) Then
                            Throw New DBErrorException(errmsg)
                        End If
                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If
                        txt通番.Text = Integer.Parse(dt.Rows(0).Item("mx")).ToString("000")

                        sql = "select count(*) as cnt from 被験者 where 日通番 <> 0 and left(依頼者KEY,8) = '" + Date.Parse(dp.Text).ToString("yyyyMMdd") + "'"
                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If

                        lbl人数.Text = dt.Rows(0).Item("cnt").ToString

                        sql = "select count(*) as cnt from 被験者 where left(依頼者KEY,8) = '" + Date.Parse(dp.Text).ToString("yyyyMMdd") + "'"

                        dt = .ExecuteSql(sql)
                        If errmsg <> "" Then
                            Throw New DBErrorException(errmsg)
                        End If

                        lbl取込総数.Text = Short.Parse(dt.Rows(0).Item("cnt")).ToString("000") + "名"


                        .close()
                        txtNo.Focus()
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
            Case 1
                txt通番2.Focus()
            Case 2

        End Select

    End Sub
    Private Sub txtNo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNo.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
        End If
        If Not chkNumeric(e.KeyChar, True) Then
            e.Handled = True
        End If
    End Sub
#End Region
#Region "通過管理"
    Private Sub txt通番2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt通番2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call チェック状態表示()
        End If
    End Sub
    Private Sub chkItemCode(obj As Object, objname As String, key As String, db As db)
        Dim code As String = ""
        Dim sql As String = ""
        Dim strBuffer As New System.Text.StringBuilder
        Dim dt As DataTable = Nothing
        Dim errmsg As String = ""

        With db

            Try
                strBuffer.Capacity = 20   'バッファのサイズを指定
                Dim ret As Integer
                ret = GetPrivateProfileString("通過管理", objname, "", strBuffer, strBuffer.Capacity, ".\code.ini")
                code = strBuffer.ToString

                sql = "select count(*) as cnt from 被験者データ where 依頼者KEY = '$$KEY' and (分析物コード1 = '$$分析物コード' or "
                sql += "分析物コード2 = '$$分析物コード' or 分析物コード3 = '$$分析物コード' or 分析物コード4 = '$$分析物コード' or 分析物コード5 = '$$分析物コード' or "
                sql += "分析物コード6 = '$$分析物コード' or 分析物コード7 = '$$分析物コード' or 分析物コード8 = '$$分析物コード' or 分析物コード9 = '$$分析物コード')"
                sql = sql.Replace("$$分析物コード", code)
                sql = sql.Replace("$$KEY", key)
                dt = .ExecuteSql(sql)
                If IsNothing(dt) Then
                    Throw New DBErrorException(errmsg)
                End If
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If

                If dt.Rows(0).Item("cnt") = 0 Then
                    obj.enabled = False
                Else
                    obj.enabled = True
                End If

            Catch ex As DBErrorException
                MsgBox(ex.Message)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End With


    End Sub
    Private Sub チェック状態表示()
        Dim sql As String = ""
        Dim dt As DataTable = Nothing
        Dim db As db = New db
        Dim errmsg As String = ""
        Dim errobj As Object
        With db
            Try
                If Integer.Parse(txt通番2.Text) = 0 Then
                    txt通番2.Text = ""
                    Exit Sub
                End If

                errobj = txt通番2
                If Not IsNumeric(txt通番2.Text) Then
                    errmsg = "通番が入力されていないか不正な値です。"
                    Throw New FormatException(errmsg)
                End If
                ep.SetError(errobj, Nothing)

                txt通番2.Focus()
                sql = "select * from 被験者 where 日通番 = " + txt通番2.Text + " and left(依頼者KEY, 8) = '" + Date.Parse(dp.Text).ToString("yyyyMMdd") + "'"
                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                dt = .ExecuteSql(sql)
                If IsNothing(dt) Then
                    Throw New DBErrorException(errmsg)
                End If
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If

                If dt.Rows.Count <> 0 Then
                    Call setEnabl(True)
                    'その人の健診項目にないものはチェック不能
                    Call chkItemCode(chk腹囲, "腹囲", dt.Rows(0).Item("依頼者KEY"), db)
                    Call chkItemCode(chk座高, "座高", dt.Rows(0).Item("依頼者KEY"), db)
                    Call chkItemCode(chk視力, "視力", dt.Rows(0).Item("依頼者KEY"), db)
                    If Not chk視力.checked Then
                        Call chkItemCode(chk視力, "視力(学)", dt.Rows(0).Item("依頼者KEY"), db)
                    End If
                    Call chkItemCode(chk聴力, "聴力", dt.Rows(0).Item("依頼者KEY"), db)
                    Call chkItemCode(chk尿検査, "尿検査", dt.Rows(0).Item("依頼者KEY"), db)
                    Call chkItemCode(chk診察, "診察", dt.Rows(0).Item("依頼者KEY"), db)
                    Call chkItemCode(chk胸部X線, "胸部X線", dt.Rows(0).Item("依頼者KEY"), db)
                    Call chkItemCode(chk採血, "採血", dt.Rows(0).Item("依頼者KEY"), db)
                    Call chkItemCode(chk心電図, "心電図", dt.Rows(0).Item("依頼者KEY"), db)
                    Call chkItemCode(chk眼底検査, "眼底検査", dt.Rows(0).Item("依頼者KEY"), db)
                    Call chkItemCode(chk腹部エコー, "腹部エコー", dt.Rows(0).Item("依頼者KEY"), db)
                    Call chkItemCode(chk腹部X線, "腹部X線", dt.Rows(0).Item("依頼者KEY"), db)
                    Call chkItemCode(chk血圧, "血圧", dt.Rows(0).Item("依頼者KEY"), db)
                    Call chkItemCode(chk握力, "握力", dt.Rows(0).Item("依頼者KEY"), db)

                    lbl名前2.Text = dt.Rows(0).Item("被験者名")

                    If dt.Rows(0).Item("身長体重終了") = "Y" Then
                        chk身長体重.checked = True
                    Else
                        chk身長体重.checked = False
                    End If

                    If dt.Rows(0).Item("血圧終了") = "Y" Then
                        chk血圧.checked = True
                    Else
                        chk血圧.checked = False
                    End If

                    If dt.Rows(0).Item("胸部X線終了") = "Y" Then
                        chk胸部X線.checked = True
                    Else
                        chk胸部X線.checked = False
                    End If

                    If dt.Rows(0).Item("腹部X線終了") = "Y" Then
                        chk腹部X線.checked = True
                    Else
                        chk腹部X線.checked = False
                    End If

                    If dt.Rows(0).Item("眼底検査終了") = "Y" Then
                        chk眼底検査.checked = True
                    Else
                        chk眼底検査.checked = False
                    End If

                    If dt.Rows(0).Item("腹囲終了") = "Y" Then
                        chk腹囲.checked = True
                    Else
                        chk腹囲.checked = False
                    End If

                    If dt.Rows(0).Item("座高終了") = "Y" Then
                        chk座高.checked = True
                    Else
                        chk座高.checked = False
                    End If

                    If dt.Rows(0).Item("視力終了") = "Y" Then
                        chk視力.checked = True
                    Else
                        chk視力.checked = False
                    End If

                    If dt.Rows(0).Item("聴力終了") = "Y" Then
                        chk聴力.checked = True
                    Else
                        chk聴力.checked = False
                    End If

                    If dt.Rows(0).Item("尿検査終了") = "Y" Then
                        chk尿検査.checked = True
                    Else
                        chk尿検査.checked = False
                    End If

                    If dt.Rows(0).Item("診察終了") = "Y" Then
                        chk診察.checked = True
                    Else
                        chk診察.checked = False
                    End If

                    If dt.Rows(0).Item("腹部エコー終了") = "Y" Then
                        chk腹部エコー.checked = True
                    Else
                        chk腹部エコー.checked = False
                    End If

                    If dt.Rows(0).Item("握力終了") = "Y" Then
                        chk握力.checked = True
                    Else
                        chk握力.checked = False
                    End If

                    If dt.Rows(0).Item("その他終了") = "Y" Then
                        chkその他.checked = True
                    Else
                        chkその他.checked = False
                    End If


                    If dt.Rows(0).Item("採血終了") = "Y" Then
                        chk採血.checked = True
                    Else
                        chk採血.checked = False
                    End If

                    If dt.Rows(0).Item("心電図終了") = "Y" Then
                        chk心電図.checked = True
                    Else
                        chk心電図.checked = False
                    End If

                    btn完了.Enabled = True
                    'Call setEnabl(True)
                Else
                    MessageBox.Show("該当の通番はみつかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Call setEnabl(False)
                    txt通番2.Text = ""
                    lbl名前2.Text = ""
                    btn完了.Enabled = False
                End If
                .close()
            Catch ex As FormatException
                MessageBox.Show(errmsg, "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Catch ex As DBErrorException
                MsgBox(errmsg)
            Catch ex As Exception
                .close()
                MsgBox(unkownError)
            Finally
                If Not IsNothing(.con) Then
                    .close()
                End If
            End Try
        End With

    End Sub
    Private Sub btn完了_Click(sender As System.Object, e As System.EventArgs) Handles btn完了.Click
        Dim sql As String = ""
        Dim errmsg As String = ""
        Dim db As db = New db

        With db
            Try
                sql = "update 被験者 set 身長体重終了 = '$$身長体重', 血圧終了 = '$$血圧終了',胸部X線終了 = '$$胸部X線終了',腹部X線終了 = '$$腹部X線終了',"
                sql += "眼底検査終了 = '$$眼底検査終了',腹囲終了 = '$$腹囲終了',座高終了 = '$$座高終了', 視力終了 = '$$視力終了',聴力終了 = '$$聴力終了',尿検査終了 = '$$尿検査終了',"
                sql += "診察終了 = '$$診察終了',腹部エコー終了 = '$$腹部エコー終了',握力終了 = '$$握力終了',その他終了 = '$$その他終了' where 日通番 = $$日通番"

                sql = sql.Replace("$$身長体重", IIf(chk身長体重.checked, "Y", "N"))
                sql = sql.Replace("$$血圧終了", IIf(chk血圧.checked, "Y", "N"))
                sql = sql.Replace("$$胸部X線終了", IIf(chk胸部X線.checked, "Y", "N"))
                sql = sql.Replace("$$腹部X線終了", IIf(chk腹部X線.checked, "Y", "N"))
                sql = sql.Replace("$$眼底検査終了", IIf(chk眼底検査.checked, "Y", "N"))
                sql = sql.Replace("$$腹囲終了", IIf(chk腹囲.checked, "Y", "N"))
                sql = sql.Replace("$$座高終了", IIf(chk座高.checked, "Y", "N"))
                sql = sql.Replace("$$握力終了", IIf(chk握力.checked, "Y", "N"))
                sql = sql.Replace("$$視力終了", IIf(chk視力.checked, "Y", "N"))
                sql = sql.Replace("$$聴力終了", IIf(chk聴力.checked, "Y", "N"))
                sql = sql.Replace("$$尿検査終了", IIf(chk尿検査.checked, "Y", "N"))
                sql = sql.Replace("$$診察終了", IIf(chk診察.checked, "Y", "N"))
                sql = sql.Replace("$$腹部エコー終了", IIf(chk腹部エコー.checked, "Y", "N"))
                sql = sql.Replace("$$その他終了", IIf(chkその他.checked, "Y", "N"))
                sql = sql.Replace("$$日通番", txt通番2.Text)
                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If
                If Not .execNonQ(sql, errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                MessageBox.Show("完了しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information)
                .close()
                Call setEnabl(False)
                btn完了.Enabled = False
                txt通番2.Text = ""
                txt通番2.Focus()
            Catch ex As DBErrorException
                MsgBox(errmsg)
            Catch ex As Exception
                MsgBox(unkownError)
            Finally
                lbl名前2.Text = ""
                If Not IsNothing(.con) Then
                    .close()
                End If
            End Try
        End With

    End Sub
    Private Sub setEnabl(flg As Boolean)
        chk身長体重.Enabled = flg
        chk血圧.Enabled = flg
        chk胸部X線.Enabled = flg
        chk腹部X線.Enabled = flg
        chk眼底検査.Enabled = flg
        chk腹囲.Enabled = flg
        chk視力.Enabled = flg
        chk聴力.Enabled = flg
        chk尿検査.Enabled = flg
        chk診察.Enabled = flg
        chk腹部エコー.Enabled = flg
        chkその他.Enabled = flg
        chk採血.Enabled = flg
        chk心電図.Enabled = flg

        chk身長体重.checked = False
        chk血圧.checked = False
        chk胸部X線.checked = False
        chk腹部X線.checked = False
        chk眼底検査.checked = False
        chk腹囲.checked = False
        chk視力.checked = False
        chk聴力.checked = False
        chk尿検査.checked = False
        chk診察.checked = False
        chk腹部エコー.checked = False
        chkその他.checked = False
        chk採血.checked = False
        chk心電図.checked = False

    End Sub
    Private Sub txt通番2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt通番2.KeyPress
        If Not chkNumeric(e.KeyChar, True) Then
            e.Handled = True
        End If
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
        End If
    End Sub


#End Region
#Region "視力"
    Private Sub itemEnable(flg As Boolean)
        cmb裸眼右.Enabled = flg
        cmb裸眼左.Enabled = flg
        cmb矯正右.Enabled = flg
        cmb矯正左.Enabled = flg
        lbl裸眼右.Enabled = flg
        lbl裸眼左.Enabled = flg
        lbl矯正右.Enabled = flg
        lbl矯正左.Enabled = flg
        btn登録.Enabled = flg
    End Sub
    Public Sub initEyesightItems()
        Dim ret As Integer
        Dim strBuffer As New System.Text.StringBuilder
        Dim code As String
        Dim sql As String = ""
        Dim dt As DataTable = Nothing
        Dim errmsg As String = ""
        Dim db As db = New db
        Dim cnt As Integer
        Dim wk As Integer = 0

        With db
            Try
                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                sql = "select 日通番,被験者名 from 被験者 where 日通番 <> 0 and 視力終了 = 'N' and left(依頼者KEY,8) = '" + Date.Parse(dp.Text).ToString("yyyyMMdd") + "' "
                sql += " order by 日通番 desc"
                dt = .ExecuteSql(sql)
                If IsNothing(dt) Then
                    Exit Try
                End If
                'GoTo aaa
                cmb通番視力.Items.Clear()
                cmb通番視力.Items.Add("")

                For cnt = 0 To dt.Rows.Count - 1 Step 1
                    wk = dt.Rows(cnt).Item("日通番")
                    If chkExitItem(wk, "0030101") Then
                        cmb通番視力.Items.Add(wk.ToString("000"))
                    End If
                Next
aaa:
                If 視力自動通番 <> "" Then
                    cmb通番視力.Text = 視力自動通番
                    視力自動通番 = ""
                End If


                '裸眼右
                ret = GetPrivateProfileString("視力", "裸眼視力右", "", strBuffer, strBuffer.Capacity, ".\code.ini")
                strBuffer.Capacity = 20   'バッファのサイズを指定
                code = strBuffer.ToString
                sql = "select 入力項目表示名称 from 検査項目マスタ where 入力項目コード = '" + code + "'"

                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If

                If dt.Rows.Count = 0 Then
                    MessageBox.Show("項目コードが見つかりません。【裸眼右】", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Try
                End If
                lbl裸眼右.Text = dt.Rows(0).Item("入力項目表示名称")

                '裸眼左
                ret = GetPrivateProfileString("視力", "裸眼視力左", "", strBuffer, strBuffer.Capacity, ".\code.ini")
                strBuffer.Capacity = 20   'バッファのサイズを指定
                code = strBuffer.ToString

                sql = "select 入力項目表示名称 from 検査項目マスタ where 入力項目コード = '" + code + "'"

                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If

                If dt.Rows.Count = 0 Then
                    MessageBox.Show("項目コードが見つかりません。【裸眼左】", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Try
                End If
                lbl裸眼左.Text = dt.Rows(0).Item("入力項目表示名称")


                '矯正右
                ret = GetPrivateProfileString("視力", "矯正視力右", "", strBuffer, strBuffer.Capacity, ".\code.ini")
                strBuffer.Capacity = 20   'バッファのサイズを指定
                code = strBuffer.ToString

                sql = "select 入力項目表示名称 from 検査項目マスタ where 入力項目コード = '" + code + "'"

                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If

                If dt.Rows.Count = 0 Then
                    MessageBox.Show("項目コードが見つかりません。【裸眼左】", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Try
                End If
                lbl矯正右.Text = dt.Rows(0).Item("入力項目表示名称")

                '矯正左
                ret = GetPrivateProfileString("視力", "矯正視力左", "", strBuffer, strBuffer.Capacity, ".\code.ini")
                strBuffer.Capacity = 20   'バッファのサイズを指定
                code = strBuffer.ToString

                sql = "select 入力項目表示名称 from 検査項目マスタ where 入力項目コード = '" + code + "'"

                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If

                If dt.Rows.Count = 0 Then
                    MessageBox.Show("項目コードが見つかりません。【裸眼左】", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Try
                End If
                lbl矯正左.Text = dt.Rows(0).Item("入力項目表示名称")

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
    Private Function chk視力data(obj As ComboBox, ByRef msg As String) As Integer
        Dim wk() As String = Nothing

        If obj.Text = "" Then
            chk視力data = 4
            Exit Function
        End If

        wk = obj.Text.Split(".")
        If wk.Length > 2 Then
            chk視力data = 1
            Exit Function
        End If

        If wk.Length = 1 Then
            chk視力data = 2
            Exit Function
        End If

        If Not IsNumeric(obj.Text) Then
            chk視力data = 3
            Exit Function
        End If

        Return 0
    End Function
    Private Sub btn登録_Click(sender As System.Object, e As System.EventArgs) Handles btn登録.Click
        Dim sql As String = ""
        Dim dt As DataTable = Nothing
        Dim errmsg As String = ""
        Dim db As db = New db
        Dim errobj As Object = Nothing

        Try
            If cmb裸眼右.Text = "" And cmb裸眼左.Text = "" And cmb矯正右.Text = "" And cmb矯正左.Text = "" Then
                errmsg = "入力されていません。"
                Throw New No_InputException(errmsg)
            End If


            errobj = cmb裸眼右
            cmb裸眼右.Text = cmb裸眼右.Text.Replace("0.1未満", "0.0")
            Select Case chk視力data(cmb裸眼右, errmsg)
                Case 1
                    errmsg = "裸眼右 " + "小数点が2つ以上あります。"
                    Throw New FormatException(errmsg)
                Case 2
                    errmsg = "裸眼右 " + "小数点がありません。"
                    Throw New FormatException(errmsg)
                Case 3
                    errmsg = "裸眼右 " + "入力された値が正しくありません。"
                    Throw New FormatException(errmsg)
                Case 4
                    'errmsg = "裸眼右 " + "入力されていません。"
                    'Throw New No_InputException(errmsg)
                Case 0
                    ep.SetError(errobj, Nothing)
            End Select

            errobj = cmb裸眼左
            cmb裸眼左.Text = cmb裸眼左.Text.Replace("0.1未満", "0.0")
            Select Case chk視力data(cmb裸眼左, errmsg)
                Case 1
                    errmsg = "裸眼左 " + "小数点が2つ以上あります。"
                    Throw New FormatException(errmsg)
                Case 2
                    errmsg = "裸眼左 " + "小数点がありません。"
                    Throw New FormatException(errmsg)
                Case 3
                    errmsg = "裸眼左 " + "入力された値が正しくありません。"
                    Throw New FormatException(errmsg)
                Case 4
                    'errmsg = "裸眼左 " + "入力されていません。"
                    'Throw New No_InputException(errmsg)
                Case 0
                    ep.SetError(errobj, Nothing)
            End Select

            errobj = cmb矯正右
            cmb矯正右.Text = cmb矯正右.Text.Replace("0.1未満", "0.0")
            Select Case chk視力data(cmb矯正右, errmsg)
                Case 1
                    errmsg = "矯正右 " + "小数点が2つ以上あります。"
                    Throw New FormatException(errmsg)
                Case 2
                    errmsg = "矯正右 " + "小数点がありません。"
                    Throw New FormatException(errmsg)
                Case 3
                    errmsg = "矯正右 " + "入力された値が正しくありません。"
                    Throw New FormatException(errmsg)
                Case 4
                    'errmsg = "矯正右 " + "入力されていません。"
                    'Throw New No_InputException(errmsg)
                Case 0
                    ep.SetError(errobj, Nothing)
            End Select

            errobj = cmb矯正左
            cmb矯正左.Text = cmb矯正左.Text.Replace("0.1未満", "0.0")
            Select Case chk視力data(cmb矯正左, errmsg)
                Case 1
                    errmsg = "矯正左 " + "小数点が2つ以上あります。"
                    Throw New FormatException(errmsg)
                Case 2
                    errmsg = "矯正左 " + "小数点がありません。"
                    Throw New FormatException(errmsg)
                Case 3
                    errmsg = "矯正左 " + "入力された値が正しくありません。"
                    Throw New FormatException(errmsg)
                Case 4
                    'errmsg = "矯正左 " + "入力されていません。"
                    'Throw New No_InputException(errmsg)
                Case 0
                    ep.SetError(errobj, Nothing)
            End Select
            If 視力自動移動 Then
                tab.SelectedTab = tp健診受付
                視力自動移動 = False
            End If
        Catch ex As No_InputException
            MessageBox.Show(errmsg, "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox(ex.Message)
            Exit Sub
        Catch ex As FormatException
            ep.SetError(errobj, ex.Message)
            MsgBox(ex.Message)
            Exit Sub
        Catch ex As Exception
            Exit Sub
        Finally

        End Try


        Dim 個人通番 As Integer
        Dim 現キー As String
        Dim strBuffer As New System.Text.StringBuilder
        Dim code As String
        Dim ret As Integer
        Dim atai As String
        Dim cnt As Integer
        With db
            Try
                sql = "select 依頼者KEY from 被験者 where 日通番 = " + cmb通番視力.Text
                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If
                If Not .starttrn(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If
                dt = .ExecuteSql(sql)
                If IsNothing(dt) Then
                    Throw New DBErrorException(errmsg)
                End If
                現キー = dt.Rows(0).Item("依頼者KEY")

                '***************************裸眼右****************************************
                strBuffer.Capacity = 20   'バッファのサイズを指定
                ret = GetPrivateProfileString("視力", "裸眼視力右", "", strBuffer, strBuffer.Capacity, ".\code.ini")
                code = strBuffer.ToString

                sql = "select * from 結果取込 where 依頼元KEY = '" + 現キー + "' and "
                sql += "(trim(項目コード1)='裸眼右' or "
                sql += "trim(項目コード2)='裸眼右' or "
                sql += "trim(項目コード3)='裸眼右' or "
                sql += "trim(項目コード4)='裸眼右' or "
                sql += "trim(項目コード5)='裸眼右')"
                sql = sql.Replace("裸眼右", code)

                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If
                If dt.Rows.Count > 0 Then
                    For cnt = 1 To 5 Step 1
                        If dt.Rows(0).Item("項目コード$$".Replace("$$", cnt.ToString)) = code Then
                            個人通番 = dt.Rows(0).Item("個人連番")
                            Exit For
                        End If
                    Next
                    atai = cmb裸眼右.Text
                    If atai = "0.0" Then
                        atai = "0.1未満"
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


                '***************************裸眼左****************************************
                ret = GetPrivateProfileString("視力", "裸眼視力左", "", strBuffer, strBuffer.Capacity, ".\code.ini")
                code = strBuffer.ToString

                sql = "select * from 結果取込 where 依頼元KEY = '" + 現キー + "' and "
                sql += "(trim(項目コード1)='裸眼左' or "
                sql += "trim(項目コード2)='裸眼左' or "
                sql += "trim(項目コード3)='裸眼左' or "
                sql += "trim(項目コード4)='裸眼左' or "
                sql += "trim(項目コード5)='裸眼左')"
                sql = sql.Replace("裸眼左", code)

                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If
                If dt.Rows.Count > 0 Then
                    For cnt = 1 To 5 Step 1
                        If dt.Rows(0).Item("項目コード$$".Replace("$$", cnt.ToString)) = code Then
                            個人通番 = dt.Rows(0).Item("個人連番")
                            Exit For
                        End If
                    Next
                    atai = cmb裸眼左.Text
                    If atai = "0.0" Then
                        atai = "0.1未満"
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


                '***************************矯正右****************************************
                ret = GetPrivateProfileString("視力", "矯正視力右", "", strBuffer, strBuffer.Capacity, ".\code.ini")
                code = strBuffer.ToString

                sql = "select * from 結果取込 where 依頼元KEY = '" + 現キー + "' and "
                sql += "(trim(項目コード1)='矯正右' or "
                sql += "trim(項目コード2)='矯正右' or "
                sql += "trim(項目コード3)='矯正右' or "
                sql += "trim(項目コード4)='矯正右' or "
                sql += "trim(項目コード5)='矯正右')"
                sql = sql.Replace("矯正右", code)

                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If
                If dt.Rows.Count > 0 Then
                    For cnt = 1 To 5 Step 1
                        If dt.Rows(0).Item("項目コード$$".Replace("$$", cnt.ToString)) = code Then
                            個人通番 = dt.Rows(0).Item("個人連番")
                            Exit For
                        End If
                    Next
                    atai = cmb矯正右.Text
                    If atai = "0.0" Then
                        atai = "0.1未満"
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

                '***************************矯正左****************************************
                ret = GetPrivateProfileString("視力", "矯正視力左", "", strBuffer, strBuffer.Capacity, ".\code.ini")
                code = strBuffer.ToString

                sql = "select * from 結果取込 where 依頼元KEY = '" + 現キー + "' and "
                sql += "(trim(項目コード1)='矯正左' or "
                sql += "trim(項目コード2)='矯正左' or "
                sql += "trim(項目コード3)='矯正左' or "
                sql += "trim(項目コード4)='矯正左' or "
                sql += "trim(項目コード5)='矯正左')"
                sql = sql.Replace("矯正左", code)

                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If
                If dt.Rows.Count > 0 Then
                    For cnt = 1 To 5 Step 1
                        If dt.Rows(0).Item("項目コード$$".Replace("$$", cnt.ToString)) = code Then
                            個人通番 = dt.Rows(0).Item("個人連番")
                            Exit For
                        End If
                    Next
                    atai = cmb矯正左.Text
                    If atai = "0.0" Then
                        atai = "0.1未満"
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

                sql = "update 被験者 set 視力終了 = 'Y' where 依頼者KEY = '" + 現キー + "'"
                If Not .execNonQTran(sql, errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                .committrn()
                MessageBox.Show("登録しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call itemEnable(False)
                cmb裸眼右.Text = ""
                cmb裸眼左.Text = ""
                cmb矯正右.Text = ""
                cmb矯正左.Text = ""
                cmb通番視力.Text = ""
                lbl名前視力.Text = ""
                cmb通番視力.Focus()
            Catch ex As DBErrorException
                .rollbacktran()
                MsgBox(ex.Message)
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
    Private Sub cmb通番視力_DropDown(sender As Object, e As System.EventArgs) Handles cmb通番視力.DropDown
        Dim sql As String
        Dim db As db = New db
        Dim dt As DataTable
        Dim errmsg As String = ""
        Dim cnt As Integer

        With db
            Try
                sql = "select 日通番 from 被験者 where left(依頼者KEY,8) = '" + Date.Parse(dp.Text).ToString("yyyyMMdd") + "' and 日通番 <> 0 "
                If chkすべて表示.Checked Then
                    'sql += " and 視力終了 = 'N'"
                Else
                    sql += " and 視力終了 = 'N'"
                End If
                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If
                dt = .ExecuteSql(sql)
                If IsNothing(dt) Then
                    Throw New DBErrorException(errmsg)
                End If

                cmb通番視力.Items.Clear()
                cmb通番視力.Items.Add("")
                For cnt = 0 To dt.Rows.Count - 1 Step 1
                    If chkExitItem(Integer.Parse(dt.Rows(cnt).Item("日通番")), "0030101") Then
                        cmb通番視力.Items.Add(Integer.Parse(dt.Rows(cnt).Item("日通番")).ToString("000"))
                    End If
                Next
                .close()

            Catch ex As Exception

            End Try
        End With
    End Sub
    Private Sub cmb通番視力_DropDownClosed(sender As Object, e As System.EventArgs) Handles cmb通番視力.DropDownClosed
        If maecombo <> cmb通番視力.SelectedIndex Then
            If cmb裸眼右.Text <> "" Or
               cmb裸眼左.Text <> "" Or
               cmb矯正右.Text <> "" Or
               cmb矯正左.Text <> "" Then
                If MessageBox.Show("未登録のデータは破棄されます。よろしいですか？", "確認",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    cmb裸眼右.Text = ""
                    cmb裸眼左.Text = ""
                    cmb矯正右.Text = ""
                    cmb矯正左.Text = ""
                Else
                    cmb通番視力.SelectedIndex = maecombo
                    Exit Sub
                End If
            End If
        End If

    End Sub
    Private Sub cmb通番視力_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmb通番視力.SelectedIndexChanged
        Dim sql As String = ""
        Dim dt As DataTable = Nothing
        Dim db As db = New db
        Dim errmsg As String = ""
        Dim code As String = ""
        Dim strBuffer As New System.Text.StringBuilder
        Dim ret As Integer
        Dim key As String

        With db
            Try
                If maecombo <> cmb通番視力.SelectedIndex And maecombo <> -1 Then
                    If cmb裸眼右.Text <> "" And cmb裸眼左.Text <> "" And cmb矯正右.Text <> "" And cmb矯正左.Text <> "" And cmb通番視力.Text <> "" And lbl名前視力.Text <> "" Then
                        If MessageBox.Show("未登録のデータは破棄されます。よろしいですか？", "確認",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                            Exit Sub
                        End If
                    End If
                End If


                maecombo = cmb通番視力.SelectedIndex

                If cmb通番視力.Text = "" Then
                    Call itemEnable(False)
                    cmb裸眼右.Text = ""
                    cmb裸眼左.Text = ""
                    cmb矯正右.Text = ""
                    cmb矯正左.Text = ""
                    cmb通番視力.Text = ""
                    lbl名前視力.Text = ""
                    cmb通番視力.Focus()
                    Exit Sub
                Else

                End If
                If Not IsNumeric(cmb通番視力.Text) And cmb通番視力.Text <> "" Then
                    MessageBox.Show("通番が不正な値です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    cmb通番視力.Text = ""
                    Exit Try
                End If
                sql = "select 被験者名,依頼者KEY from 被験者 where 日通番 = " + cmb通番視力.Text + " and left(依頼者KEY,8) = '" + Date.Parse(dp.Text).ToString("yyyyMMdd") + "'"
                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If
                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If
                If dt.Rows.Count = 0 Then
                    MessageBox.Show("入力された連番が見つかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    cmb通番視力.Text = ""
                    Exit Try
                End If
                lbl名前視力.Text = Trim(dt.Rows(0).Item("被験者名")).ToString + " 様"
                key = dt.Rows(0).Item("依頼者KEY")

                '***************初期表示 裸眼右*************************
                strBuffer.Capacity = 20   'バッファのサイズを指定
                ret = GetPrivateProfileString("視力", "裸眼視力右", "", strBuffer, strBuffer.Capacity, ".\code.ini")
                code = strBuffer.ToString

                sql = "select * from 結果取込 as a "
                sql += "inner join 被験者 as b on a.依頼元KEY = b.依頼者KEY "
                sql += "where 依頼元KEY = '" + key + "' and "
                sql += "日通番 = " + cmb通番視力.Text + " and (項目コード1 = '" + code + "' or 項目コード2 = '" + code + "' or "
                sql += "項目コード3 = '" + code + "' or 項目コード4 = '" + code + "' or 項目コード5 = '" + code + "')"
                dt = .ExecuteSql(sql)

                If Not IsDBNull(dt.Rows(0).Item("項目コード1")) Then
                    If dt.Rows(0).Item("項目コード1") = code Then
                        cmb裸眼右.Text = Trim(dt.Rows(0).Item("検査結果値1").ToString)
                    End If
                End If

                If Not IsDBNull(dt.Rows(0).Item("項目コード2")) Then
                    If dt.Rows(0).Item("項目コード2") = code Then
                        cmb裸眼右.Text = Trim(dt.Rows(0).Item("検査結果値2").ToString)
                    End If
                End If


                If Not IsDBNull(dt.Rows(0).Item("項目コード3")) Then
                    If dt.Rows(0).Item("項目コード3") = code Then
                        cmb裸眼右.Text = Trim(dt.Rows(0).Item("検査結果値3").ToString)
                    End If

                End If

                If Not IsDBNull(dt.Rows(0).Item("項目コード4")) Then
                    If dt.Rows(0).Item("項目コード4") = code Then
                        cmb裸眼右.Text = Trim(dt.Rows(0).Item("検査結果値4").ToString)
                    End If
                End If

                If Not IsDBNull(dt.Rows(0).Item("項目コード5")) Then
                    If dt.Rows(0).Item("項目コード5") = code Then
                        cmb裸眼右.Text = Trim(dt.Rows(0).Item("検査結果値5").ToString)
                    End If
                End If


                '***************初期表示 裸眼左*************************
                strBuffer.Capacity = 20   'バッファのサイズを指定
                ret = GetPrivateProfileString("視力", "裸眼視力左", "", strBuffer, strBuffer.Capacity, ".\code.ini")
                code = strBuffer.ToString

                sql = "select * from 結果取込 as a "
                sql += "inner join 被験者 as b on a.依頼元KEY = b.依頼者KEY "
                sql += "where 依頼元KEY = '" + key + "' and "
                sql += "日通番 = " + cmb通番視力.Text + " and (項目コード1 = '" + code + "' or 項目コード2 = '" + code + "' or "
                sql += "項目コード3 = '" + code + "' or 項目コード4 = '" + code + "' or 項目コード5 = '" + code + "')"
                dt = .ExecuteSql(sql)

                If Not IsDBNull(dt.Rows(0).Item("項目コード1")) Then
                    If dt.Rows(0).Item("項目コード1") = code Then
                        cmb裸眼左.Text = Trim(dt.Rows(0).Item("検査結果値1").ToString)
                    End If
                End If

                If Not IsDBNull(dt.Rows(0).Item("項目コード2")) Then
                    If dt.Rows(0).Item("項目コード2") = code Then
                        cmb裸眼左.Text = Trim(dt.Rows(0).Item("検査結果値2").ToString)
                    End If
                End If


                If Not IsDBNull(dt.Rows(0).Item("項目コード3")) Then
                    If dt.Rows(0).Item("項目コード3") = code Then
                        cmb裸眼左.Text = Trim(dt.Rows(0).Item("検査結果値3").ToString)
                    End If

                End If

                If Not IsDBNull(dt.Rows(0).Item("項目コード4")) Then
                    If dt.Rows(0).Item("項目コード4") = code Then
                        cmb裸眼左.Text = Trim(dt.Rows(0).Item("検査結果値4").ToString)
                    End If
                End If

                If Not IsDBNull(dt.Rows(0).Item("項目コード5")) Then
                    If dt.Rows(0).Item("項目コード5") = code Then
                        cmb裸眼左.Text = Trim(dt.Rows(0).Item("検査結果値5").ToString)
                    End If
                End If


                '***************初期表示 矯正右*************************
                strBuffer.Capacity = 20   'バッファのサイズを指定
                ret = GetPrivateProfileString("視力", "矯正視力右", "", strBuffer, strBuffer.Capacity, ".\code.ini")
                code = strBuffer.ToString

                sql = "select * from 結果取込 as a "
                sql += "inner join 被験者 as b on a.依頼元KEY = b.依頼者KEY "
                sql += "where 依頼元KEY = '" + key + "' and "
                sql += "日通番 = " + cmb通番視力.Text + " and (項目コード1 = '" + code + "' or 項目コード2 = '" + code + "' or "
                sql += "項目コード3 = '" + code + "' or 項目コード4 = '" + code + "' or 項目コード5 = '" + code + "')"
                dt = .ExecuteSql(sql)

                If Not IsDBNull(dt.Rows(0).Item("項目コード1")) Then
                    If dt.Rows(0).Item("項目コード1") = code Then
                        cmb矯正右.Text = Trim(dt.Rows(0).Item("検査結果値1").ToString)
                    End If
                End If

                If Not IsDBNull(dt.Rows(0).Item("項目コード2")) Then
                    If dt.Rows(0).Item("項目コード2") = code Then
                        cmb矯正右.Text = Trim(dt.Rows(0).Item("検査結果値2").ToString)
                    End If
                End If


                If Not IsDBNull(dt.Rows(0).Item("項目コード3")) Then
                    If dt.Rows(0).Item("項目コード3") = code Then
                        cmb矯正右.Text = Trim(dt.Rows(0).Item("検査結果値3").ToString)
                    End If

                End If

                If Not IsDBNull(dt.Rows(0).Item("項目コード4")) Then
                    If dt.Rows(0).Item("項目コード4") = code Then
                        cmb矯正右.Text = Trim(dt.Rows(0).Item("検査結果値4").ToString)
                    End If
                End If

                If Not IsDBNull(dt.Rows(0).Item("項目コード5")) Then
                    If dt.Rows(0).Item("項目コード5") = code Then
                        cmb矯正右.Text = Trim(dt.Rows(0).Item("検査結果値5").ToString)
                    End If
                End If


                '***************初期表示 矯正左*************************
                strBuffer.Capacity = 20   'バッファのサイズを指定
                ret = GetPrivateProfileString("視力", "矯正視力左", "", strBuffer, strBuffer.Capacity, ".\code.ini")
                code = strBuffer.ToString

                sql = "select * from 結果取込 as a "
                sql += "inner join 被験者 as b on a.依頼元KEY = b.依頼者KEY "
                sql += "where 依頼元KEY = '" + key + "' and "
                sql += "日通番 = " + cmb通番視力.Text + " and (項目コード1 = '" + code + "' or 項目コード2 = '" + code + "' or "
                sql += "項目コード3 = '" + code + "' or 項目コード4 = '" + code + "' or 項目コード5 = '" + code + "')"
                dt = .ExecuteSql(sql)

                If Not IsDBNull(dt.Rows(0).Item("項目コード1")) Then
                    If dt.Rows(0).Item("項目コード1") = code Then
                        cmb矯正左.Text = Trim(dt.Rows(0).Item("検査結果値1").ToString)
                    End If
                End If

                If Not IsDBNull(dt.Rows(0).Item("項目コード2")) Then
                    If dt.Rows(0).Item("項目コード2") = code Then
                        cmb矯正左.Text = Trim(dt.Rows(0).Item("検査結果値2").ToString)
                    End If
                End If


                If Not IsDBNull(dt.Rows(0).Item("項目コード3")) Then
                    If dt.Rows(0).Item("項目コード3") = code Then
                        cmb矯正左.Text = Trim(dt.Rows(0).Item("検査結果値3").ToString)
                    End If

                End If

                If Not IsDBNull(dt.Rows(0).Item("項目コード4")) Then
                    If dt.Rows(0).Item("項目コード4") = code Then
                        cmb矯正左.Text = Trim(dt.Rows(0).Item("検査結果値4").ToString)
                    End If
                End If

                If Not IsDBNull(dt.Rows(0).Item("項目コード5")) Then
                    If dt.Rows(0).Item("項目コード5") = code Then
                        cmb矯正左.Text = Trim(dt.Rows(0).Item("検査結果値5").ToString)
                    End If
                End If


                .close()
                Call itemEnable(True)
                cmb裸眼右.Focus()
            Catch ex As DBErrorException
                MsgBox(errmsg)
            Catch ex As Exception
                MsgBox(unkownError)
                MsgBox(ex.Message + vbCrLf + ex.StackTrace)
            Finally
                If Not IsNothing(.con) Then
                    .close()
                End If
            End Try
        End With
    End Sub
    Private Sub cmb裸眼右_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmb裸眼右.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            cmb裸眼左.Focus()
        End If
        If Not chkNumeric(e.KeyChar, False) Then
            e.Handled = True
        End If
    End Sub
    Private Sub cmb裸眼左_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmb裸眼左.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            cmb矯正右.Focus()
        End If
        If Not chkNumeric(e.KeyChar, False) Then
            e.Handled = True
        End If
    End Sub
    Private Sub cmb矯正右_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmb矯正右.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            cmb矯正左.Focus()
        End If
        If Not chkNumeric(e.KeyChar, False) Then
            e.Handled = True
        End If
    End Sub
    Private Sub cmb矯正左_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmb矯正左.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            btn登録.Focus()
        End If
        If Not chkNumeric(e.KeyChar, False) Then
            e.Handled = True
        End If
    End Sub

#End Region
#Region "端末情報"
    '端末情報グリッド表示
    Public Sub gridDisp()
        Dim db As db = New db
        Dim dt As DataTable = Nothing
        Dim sql As String = ""
        Dim errmsg As String = ""

        With db
            Try
                dgv.Refresh()

                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If
                sql = "select * from 端末"
                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If
                dgv.RowCount = dt.Rows.Count
                For cnt = 0 To dt.Rows.Count - 1 Step 1
                    dgv.Item(0, cnt).Value = dt.Rows(cnt).Item("端末IP")
                    dgv.Item(1, cnt).Value = dt.Rows(cnt).Item("端末名")
                    dgv.Item(2, cnt).Value = dt.Rows(cnt).Item("用途")
                    dgv.Item(3, cnt).Value = dt.Rows(cnt).Item("グループ")
                    dgv.Item(4, cnt).Value = dt.Rows(cnt).Item("備考")
                    dgv.Item(5, cnt).Value = dt.Rows(cnt).Item("ID").ToString     '不可視
                Next


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
    Private Sub bt追加_Click(sender As System.Object, e As System.EventArgs) Handles bt追加.Click
        端末登録.mode = "追加"
        端末登録.ShowDialog()
    End Sub
    Private Sub btn端末修正_Click(sender As System.Object, e As System.EventArgs) Handles btn端末修正.Click
        端末登録.mode = "修正"
        端末登録.ID = dgv.Item(5, nowrow).Value
        端末登録.ShowDialog()
    End Sub
    Private Sub dgv_RowEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.RowEnter
        nowrow = e.RowIndex
    End Sub
    Private Sub btn削除_Click(sender As System.Object, e As System.EventArgs) Handles btn削除.Click
        Dim sql As String = ""
        Dim errmsg As String = ""
        Dim db As db = New db

        If MessageBox.Show("選択されている端末を削除します。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        With db
            Try
                sql = "delete from 端末 where ID = " + dgv.Item(5, nowrow).Value.ToString
                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If
                If Not .execNonQ(sql, errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                Call gridDisp() '再表示
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


#End Region
#Region "共用"
    Private Sub dp_GotFocus(sender As Object, e As System.EventArgs)
        txtNo.Focus()
    End Sub
    Private Sub dp_TextChanged(sender As Object, e As System.EventArgs)
        txtNo.Focus()
    End Sub
    Private Sub tab_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles tab.SelectedIndexChanged
        Select Case tab.SelectedIndex
            Case tabs.受付        '健診受付
                Me.Text = "健診受付"
                Label2.Text = "健診受付"
                txtNo.Text = ""
                txtNo.Focus()
            Case tabs.通過管理   '通過管理
                Me.Text = "通過管理"
                Label2.Text = "通過管理"
                lbl名前2.Text = ""
                txt通番2.Focus()
            Case tabs.端末管理   '端末管理
                Me.Text = "端末管理"
                Label2.Text = "端末管理"
                Call gridDisp()
            Case tabs.視力
                Me.Text = "視力"
                Label2.Text = "視力"
                cmb通番視力.Focus()
                'lbl名前視力.Text = ""
                Call initEyesightItems()
            Case tabs.結果表示
                Me.Text = "結果表示"
                Label2.Text = "結果表示"
                Call resultDisplay()
            Case tabs.未受付一覧
                Me.Text = "未受付一覧"
                Call NonReceptionists()
        End Select
    End Sub
    Private Function chkNumeric(keychar As Char, ten As Boolean) As Boolean
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


#Region "結果表示"
    Private Sub btn全選択解除_Click(sender As System.Object, e As System.EventArgs) Handles btn全選択解除.Click
        If btn全選択解除.Text = "全選択" Then
            chkItem視力.checked = True
            chkItem血圧.checked = True
            chkItem検尿.checked = True
            chkItem腹囲.checked = True
            chkItem身長体重.checked = True
            chkItem聴力.checked = True
            btn全選択解除.Text = "全解除"
        Else
            chkItem視力.checked = False
            chkItem血圧.checked = False
            chkItem検尿.checked = False
            chkItem腹囲.checked = False
            chkItem身長体重.checked = False
            chkItem聴力.checked = False
            btn全選択解除.Text = "全選択"
        End If
    End Sub

    Private Sub resultDisplay()
        Dim sql As StringBuilder = New StringBuilder
        Dim db As db = New db
        Dim dtHikensha As DataTable = Nothing
        Dim errmsg As String = ""

        dgvResult.ReadOnly = True
        dgvResult.RowTemplate.Height = 50
        dgvResult.AllowUserToAddRows = False       'データ追加禁止
        dgvResult.RowCount = 0
        dgvResult.ReadOnly = True                  '編集禁止
        dgvResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect  '行選択モード
        dgvResult.RowHeadersVisible = False        'Rowヘッダは非表示
        dgvResult.MultiSelect = True               '複数行選択許可
        dgvResult.AllowUserToResizeRows = False    '行の高さの変更禁止
        dgvResult.ScrollBars = ScrollBars.Both
        dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvResult.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvResult.ColumnHeadersDefaultCellStyle.BackColor = Color.Red
        dgvResult.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        With db
            Try
                'カラム
                dgvResult.ColumnCount = ColsHead.Rows.Count
                For cnt As Short = 0 To ColsHead.Rows.Count - 1 Step 1
                    dgvResult.Columns(ColsHead.Rows(cnt).Item("pos")).HeaderText = ColsHead.Rows(cnt).Item("colString").ToString
                    dgvResult.Columns(ColsHead.Rows(cnt).Item("pos")).Width = Integer.Parse(ColsHead.Rows(cnt).Item("width").ToString)
                Next

                '通番とか
                sql.Append("select * from 被験者 where left(依頼者KEY,8) = 'YYYYMMDD' and 日通番 <> 0 ")
                If cmb団体名.Text <> "全て" Then
                    sql.Append("and 予備 = '" & cmb団体名.Text & "'")
                End If
                sql.Append("order by 日通番")
                sql.Replace("YYYYMMDD", dp.Text.Replace("/", ""))

                .connect(errmsg)
                dtHikensha = .ExecuteSql(sql.ToString)
                For cnt As Integer = 0 To dtHikensha.Rows.Count - 1 Step 1
                    dgvResult.RowCount += 1
                    dgvResult.Item(0, cnt).Value = Integer.Parse(dtHikensha.Rows(cnt).Item("日通番").ToString).ToString("000")
                    dgvResult.Item(1, cnt).Value = Right_(dtHikensha.Rows(cnt).Item("依頼者KEY").ToString, 10)
                    dgvResult.Item(2, cnt).Value = Trim(dtHikensha.Rows(cnt).Item("被験者名").ToString) + "様"
                Next

                'データ本体
                Dim wkdr() As DataRow = ColsHead.Select("", "pos")
                For colcnt As Short = 3 To wkdr.Length - 1 Step 1
                    For kencnt As Short = 0 To dtHikensha.Rows.Count - 1 Step 1
                        For cnt = 1 To 5 Step 1
                            With sql
                                .Clear()
                                .Append("select 検査結果値%%,個人連番 from 結果取込 ")
                                .Append("where 項目コード%% = 'ターゲット' ")
                                .Append("and trim(検査結果値%%) <> '' ")
                                .Append(" and 依頼元KEY = '" + dtHikensha.Rows(kencnt).Item("依頼者KEY").ToString + "'")
                                sql = sql.Replace("%%", cnt.ToString)
                                sql = sql.Replace("ターゲット", wkdr(colcnt).Item("code").ToString)
                                If dtHikensha.Rows(kencnt).Item("依頼者KEY").ToString = "201404040040071359  " Then
                                    Dim sss As String = ""
                                End If
                            End With
                            Dim dt As DataTable = .ExecuteSql(sql.ToString)
                            If dt.Rows.Count <> 0 Then
                                dgvResult.Item(colcnt, kencnt).Value = dt.Rows(0).Item(0).ToString
                                dt.Dispose()
                                Exit For
                            End If
                        Next
                    Next
                Next
                .close()
            Catch ex As Exception

                MsgBox(ex.Message)
            Finally
                If Not IsNothing(.con) Then
                    .close()
                End If
            End Try

        End With
    End Sub

#End Region

    Private Sub chkItem視力_Click(sender As Object, e As System.EventArgs) Handles chkItem視力.Click
        Dim aaa As String = ""
    End Sub

    Private Sub colshow(ByRef dr() As DataRow, sw As Boolean)

        For cnt As Integer = 0 To dr.Length - 1 Step 1
            dgvResult.Columns(dr(cnt).Item("pos")).Visible = sw
        Next


    End Sub

    ''' <summary>
    ''' WndProc WM_USER + 1をカスタムコントロールから受けるため
    ''' </summary>
    ''' <param name="m"></param>
    ''' <remarks></remarks>
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_USER + 1
                Dim aaa As Object = m.LParam
                Dim dr() As DataRow = ColsHead.Select("group = '視力'")
                Select Case m.LParam
                    Case chkItem視力.Handle
                        '視力のチェックが変化した
                        dr = ColsHead.Select("group = '視力'")
                        Call colshow(dr, chkItem視力.checked)
                    Case chkItem身長体重.Handle
                        '身長体重のチェックが変化した
                        dr = ColsHead.Select("group = '身長体重'")
                        Call colshow(dr, chkItem身長体重.checked)
                    Case chkItem聴力.Handle
                        '聴力のチェックが変化した
                        dr = ColsHead.Select("group = '聴力'")
                        Call colshow(dr, chkItem聴力.checked)
                    Case chkItem血圧.Handle
                        '血圧のチェックが変化した
                        dr = ColsHead.Select("group = '血圧'")
                        Call colshow(dr, chkItem血圧.checked)
                    Case chkItem腹囲.Handle
                        '腹囲のチェックが変化した
                        dr = ColsHead.Select("group = '腹囲'")
                        Call colshow(dr, chkItem腹囲.checked)
                    Case chkItem検尿.Handle
                        '検尿のチェックが変化した
                        dr = ColsHead.Select("group = '尿検査'")
                        Call colshow(dr, chkItem検尿.checked)
                    Case chkItem座高.Handle
                        '座高のチェックが変化した
                        dr = ColsHead.Select("group = '座高'")
                        Call colshow(dr, chkItem座高.checked)
                    Case chkItem握力.Handle
                        '握力のチェックが変化した
                        dr = ColsHead.Select("group = '握力'")
                        Call colshow(dr, chkItem握力.checked)

                    Case Else
                End Select
        End Select
        MyBase.WndProc(m)
    End Sub

    Private Sub txtNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNo.TextChanged

    End Sub

    Private Sub txt通番2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt通番2.TextChanged

    End Sub

    Private Sub lbl取込総数_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl取込総数.Click

    End Sub


#Region "未受付一覧"
    ''' <summary>
    ''' 未受付一覧タブ選択
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub NonReceptionists()
        Dim db As db = New db
        Dim Sql As String = "select trim(予備) as 団体名, right(trim(依頼者KEY),8) as 個人番号,被験者名 as お名前 from 被験者 where 日通番 = 0 "
        If cmb団体名.Text <> "全て" Then
            Sql += "and 予備 = '{0}'"
            Sql = String.Format(Sql, cmb団体名.Text)
        End If
        Sql += "order by 依頼者KEY"
        Dim errmsg As String = String.Empty

        With dgvNonReceptionists
            '全ての行の背景色を白色にする
            .RowsDefaultCellStyle.BackColor = Color.White
            '奇数行をライトシアンにする
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan

            .DataSource = Nothing
            .ReadOnly = True
            .RowTemplate.Height = 65
            .AllowUserToAddRows = False       'データ追加禁止
            .RowCount = 0
            .ReadOnly = True                  '編集禁止
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect  '行選択モード
            .RowHeadersVisible = False        'Rowヘッダは非表示
            .MultiSelect = True               '複数行選択許可
            .AllowUserToResizeRows = False    '行の高さの変更禁止
            .ScrollBars = ScrollBars.Both
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .ColumnHeadersDefaultCellStyle.BackColor = Color.Red
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With db
            Try
                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                Using dt As DataTable = db.ExecuteSql(Sql)
                    dgvNonReceptionists.DataSource = dt
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If Not IsNothing(.con) Then
                    .close()
                End If
            End Try
        End With

    End Sub

    ''' <summary>
    ''' 更新ボタン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRenew_Click(sender As System.Object, e As System.EventArgs) Handles btnRenew.Click
        Call NonReceptionists()
    End Sub
#End Region


    Private Sub cmb団体名_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmb団体名.SelectedIndexChanged
        resultDisplay()
        NonReceptionists()
    End Sub
End Class
