Public Class 端末登録
#Region "変数"
    Public mode As String = ""
    'Public ipadd As String = ""
    Public ID As Integer

#End Region
#Region "初期化"
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Me.Icon = My.Resources.受付管理

        Me.MinimumSize = New Size(983, 728)
        Me.MaximumSize = New Size(983, 728)

        Me.PictureBox1.Image = My.Resources.estSVlogo
    End Sub
#End Region
#Region "登録"
    Private Sub btn登録_Click(sender As System.Object, e As System.EventArgs) Handles btn登録.Click
        Dim sql As String = ""
        Dim dt As DataTable = Nothing
        Dim errmsg As String = ""
        Dim db As db = New db
        Dim chkobj As Object = Nothing

        With db
            Try
                If Not chkNewmeric(txtIP4) Then
                    Exit Sub
                End If

                chkobj = txt端末名
                If txt端末名.Text = "" Then
                    errmsg = "端末名を入力してください。"
                    Throw (New FormatException(errmsg))
                Else
                    ep.SetError(chkobj, Nothing)
                End If

                chkobj = cmb用途
                If cmb用途.Text = "" Then
                    errmsg = "用途を選択してください。"
                    Throw (New FormatException(errmsg))
                Else
                    ep.SetError(chkobj, Nothing)
                End If
            Catch ex As DBErrorException
                MsgBox(errmsg)
            Catch ex As FormatException
                ep.SetError(chkobj, errmsg)
                Exit Sub
            Catch ex As Exception
                MsgBox(unkownError)
                Exit Sub
            End Try

            Try
                Dim ip As String = txtIP1.Text + "." + txtIP2.Text + "." + txtIP3.Text + "." + txtIP4.Text

                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If
                If Integer.Parse(txtIP4.Text) <= 0 Or Integer.Parse(txtIP4.Text) > 254 Then
                    errmsg = "IPアドレスの値が不正です。"
                    chkobj = txtIP4
                    ep.SetError(chkobj, errmsg)
                    Exit Try
                Else
                    ep.SetError(chkobj, Nothing)
                End If

                If mode = "追加" Then
                    '追加

                    sql = "select count(*) as cnt from 端末 where 端末IP ='" + ip + "'"
                    dt = .ExecuteSql(sql)
                    If errmsg <> "" Then
                        Throw New DBErrorException(errmsg)
                    End If

                    If dt.Rows(0).Item("cnt") <> 0 Then
                        errmsg = "入力されたIPアドレスはすでに登録されています。"
                        chkobj = txtIP4
                        ep.SetError(chkobj, errmsg)
                        Exit Try
                    Else
                        ep.SetError(chkobj, Nothing)
                    End If

                    sql = "insert into 端末(端末IP, 端末名, 用途, グループ, 備考) "
                    sql += "values('$$端末IP', '$$端末名', '$$用途', '$$グループ', '$$備考')"
                    sql = sql.Replace("$$端末IP", ip)
                    sql = sql.Replace("$$端末名", txt端末名.Text)
                    sql = sql.Replace("$$用途", cmb用途.Text)
                    sql = sql.Replace("$$グループ", txtグループ.Text)
                    sql = sql.Replace("$$備考", txt備考.Text)

                Else
                    '修正
                    sql = "update 端末 set 端末IP = '$$端末IP', 端末名 = '$$端末名', 用途 = '$$用途', グループ = '$$グループ', 備考 = '$$備考' "
                    sql += "where ID = '$$ID'"
                    sql = sql.Replace("$$端末IP", ip)
                    sql = sql.Replace("$$用途", cmb用途.Text)
                    sql = sql.Replace("$$グループ", txtグループ.Text)
                    sql = sql.Replace("$$備考", txt備考.Text)
                    sql = sql.Replace("$$端末名", txt端末名.Text)
                    sql = sql.Replace("$$ID", ID.ToString)

                End If
                If Not .execNonQ(sql, errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If
                MessageBox.Show("登録しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information)
                .close()
                MainForm.gridDisp()
                Me.Close()
                Me.Dispose()
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

#End Region
#Region "整数チェック"
    Private Function chkNewmeric(chkobj As Object) As Boolean
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

#End Region
#Region "Form Load"
    Private Sub 端末登録_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim sql As String = ""
        Dim dt As DataTable = Nothing
        Dim errmsg As String = ""
        Dim db As db = New db
        Dim ip() As String = Nothing

        With db
            Try
                If mode = "修正" Then
                    sql = "select * from 端末 where ID = " + ID.ToString
                    If Not .connect(errmsg) Then
                        Throw New DBErrorException(errmsg)
                    End If

                    If errmsg <> "" Then
                        Throw New DBErrorException(errmsg)
                    End If
                    dt = .ExecuteSql(sql)
                    If errmsg <> "" Then
                        Throw New DBErrorException(errmsg)
                    End If

                    Dim wk As String = dt.Rows(0).Item("端末IP").ToString
                    ip = wk.Split(".")
                    txtIP4.Text = ip(3)
                    txt端末名.Text = dt.Rows(0).Item("端末名").ToString
                    cmb用途.Text = dt.Rows(0).Item("用途").ToString
                    txtグループ.Text = dt.Rows(0).Item("グループ").ToString
                    txt備考.Text = dt.Rows(0).Item("備考").ToString
                    .close()
                End If
            Catch ex As DBErrorException

            Catch ex As Exception

            End Try
        End With

    End Sub

#End Region
#Region "戻る"
    Private Sub btn戻る_Click(sender As System.Object, e As System.EventArgs) Handles btn戻る.Click
        Me.Close()
        Me.Dispose()
    End Sub

#End Region
End Class