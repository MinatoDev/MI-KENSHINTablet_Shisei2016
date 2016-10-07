Imports System.Runtime.InteropServices

Public Class 連番選択
    Public oya As Object
    Public 種別 As String

    '指定のINIファイルから文字列を取得する
    <DllImport("KERNEL32.DLL", CharSet:=CharSet.Auto)>
    Public Shared Function GetPrivateProfileString(ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String,
                    ByVal lpReturnedString As System.Text.StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    End Function

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Me.AcceptButton = btn選択
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub 連番選択_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim sql As String = ""
        Dim db As db = New db
        Dim dt As DataTable = Nothing
        Dim errmsg As String = ""

        With db
            Try
                lst通番.Items.Clear()
                sql = "select 日通番,被験者名 from 被験者 where $1 = 'N' and 日通番 <> 0 order by 日通番"
                Select Case 種別
                    Case "身長体重"
                        sql = sql.Replace("$1", "身長体重終了")
                    Case "血圧"
                        sql = sql.Replace("$1", "血圧終了")
                    Case "聴力"
                        sql = sql.Replace("$1", "聴力終了")
                    Case "握力"
                        sql = sql.Replace("$1", "握力終了")
                End Select

                .connect(errmsg)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If
                dt = .ExecuteSql(sql)
                If errmsg <> "" Then
                    Throw New DBErrorException(errmsg)
                End If
                If dt.Rows.Count = 0 Then
                    Exit Try
                End If

                Dim strBuffer As New System.Text.StringBuilder
                Dim chkcode As String = ""
                For cnt As Short = 0 To dt.Rows.Count - 1 Step 1
                    Select Case 計測.tb.SelectedIndex
                        Case 0
                            Dim ret As Integer = GetPrivateProfileString("通過管理", "身長", "", strBuffer, 20, ".\code.ini")
                            chkcode = strBuffer.ToString
                        Case 1
                            Dim ret As Integer = GetPrivateProfileString("通過管理", "血圧", "", strBuffer, 20, ".\code.ini")
                            chkcode = strBuffer.ToString
                        Case 2
                            Dim ret As Integer = GetPrivateProfileString("通過管理", "聴力", "", strBuffer, 20, ".\code.ini")
                            chkcode = strBuffer.ToString
                        Case 3
                            Dim ret As Integer = GetPrivateProfileString("通過管理", "握力", "", strBuffer, 20, ".\code.ini")
                            chkcode = strBuffer.ToString
                    End Select
                    If chkExitItem(Integer.Parse(dt.Rows(cnt).Item("日通番")), chkcode) Then
                        lst通番.Items.Add(Integer.Parse(dt.Rows(cnt).Item("日通番")).ToString("000") + " " + dt.Rows(cnt).Item("被験者名"))
                    End If
                Next
            Catch ex As DBErrorException
            Catch ex As Exception

            End Try
        End With

    End Sub

    Private Sub btn選択_Click(sender As System.Object, e As System.EventArgs) Handles btn選択.Click
        Dim wk() As String

        If lst通番.SelectedIndex <> -1 Then
            wk = lst通番.Items(lst通番.SelectedIndex).ToString.Trim.Split(" ")

            Select Case 種別
                Case "身長体重"
                    計測.txt連番.Text = wk(0)
                    計測.lbl名前.Text = wk(1)
                    計測.btn身長計測.Enabled = True
                    計測.txt身長.Focus()
                    '計測.AcceptButton = 計測.btn身長計測
                    計測.itemTrue()
                    計測.setcmb身体()
                Case "血圧"
                    計測.txt通番血圧.Text = wk(0)
                    計測.lbl名前2.Text = wk(1)
                    計測.btn血圧計測.Enabled = True
                    計測.txt最高血圧1.Focus()
                    '計測.AcceptButton = 計測.btn血圧計測
                    計測.itemTrue血圧()
                    計測.setcmb血圧()
                Case "聴力"
                    計測.txt通番聴力.Text = wk(0)
                    計測.lbl名前聴力.Text = wk(1)
                    計測.itemTrue聴力()
                    計測.setcmb聴力()
                Case "握力"
                    計測.txt通番握力.Text = wk(0)
                    計測.lbl名前握力.Text = wk(1)
                    計測.itemTrue握力()
                    計測.setcmb握力()
            End Select

            Me.Close()
            Me.Dispose()

        End If
    End Sub

    Private Sub lst通番_DoubleClick(sender As Object, e As System.EventArgs) Handles lst通番.DoubleClick
        Call btn選択_Click(sender, e)
    End Sub

    Private Sub lst通番_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles lst通番.SelectedIndexChanged
        btn選択.Enabled = True
    End Sub

    Private Sub chkすべて身長_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkすべて.CheckedChanged
        Dim sql As String = ""
        Dim db As db = New db
        Dim dt As DataTable = Nothing
        Dim errmsg As String = ""

        With db
            Try
                btn選択.Enabled = False
                lst通番.Items.Clear()
                If chkすべて.Checked Then
                    sql = "select 日通番,被験者名 from 被験者 where ($1 = 'N' or $1 = 'Y') and 日通番 <> 0 order by 日通番"
                    sql = sql.Replace("and $1 = 'Y'", "")
                Else
                    sql = "select 日通番,被験者名 from 被験者 where $1 = 'N' and 日通番 <> 0 order by 日通番"

                End If
                If 種別 = "身長体重" Then
                    sql = sql.Replace("$1", "身長体重終了")
                    If chkすべて.Checked Then
                        計測.chkすべて身長.Checked = True
                    Else
                        計測.chkすべて身長.Checked = False
                    End If
                Else
                    sql = sql.Replace("$1", "血圧終了")
                End If



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

                Dim strBuffer As New System.Text.StringBuilder
                Dim chkcode As String = ""
                For cnt As Short = 0 To dt.Rows.Count - 1 Step 1
                    Select Case 計測.tb.SelectedIndex
                        Case 0
                            Dim ret As Integer = GetPrivateProfileString("通過管理", "身長", "", strBuffer, 20, ".\code.ini")
                            chkcode = strBuffer.ToString
                        Case 1
                            Dim ret As Integer = GetPrivateProfileString("通過管理", "血圧", "", strBuffer, 20, ".\code.ini")
                            chkcode = strBuffer.ToString
                        Case 2
                            Dim ret As Integer = GetPrivateProfileString("通過管理", "聴力", "", strBuffer, 20, ".\code.ini")
                            chkcode = strBuffer.ToString
                        Case 3
                            Dim ret As Integer = GetPrivateProfileString("通過管理", "握力", "", strBuffer, 20, ".\code.ini")
                            chkcode = strBuffer.ToString
                    End Select
                    If chkExitItem(Integer.Parse(dt.Rows(cnt).Item("日通番")), chkcode) Then
                        lst通番.Items.Add(Integer.Parse(dt.Rows(cnt).Item("日通番")).ToString("000") + " " + dt.Rows(cnt).Item("被験者名"))
                    End If
                Next


            Catch ex As DBErrorException
            Catch ex As Exception

            End Try
        End With

    End Sub
End Class