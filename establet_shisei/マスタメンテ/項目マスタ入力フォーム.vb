Option Explicit On
Imports マスタメンテ.db
Imports System.Media


Public Class 項目マスタ入力フォーム
    Public row As DataRow
    Public shinki As Boolean = False

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
    End Sub

    Private Sub setItem()
        txt入力項目コード.Text = ""
        txt入力項目表示名称.Text = ""
        txt入力形式.Text = ""
        txt少数桁数.Text = ""
        txt単位名称.Text = ""

        Select Case メンテView.mode
            Case "項目"
                txt入力項目コード.Text = row.Item("入力項目コード").ToString
                txt入力項目表示名称.Text = IIf(IsDBNull(row.Item("入力項目表示名称")), "", row.Item("入力項目表示名称").ToString)
                txt入力形式.Text = IIf(IsDBNull(row.Item("入力形式")), "", row.Item("入力形式").ToString)
                txt少数桁数.Text = IIf(IsDBNull(row.Item("少数桁数")), "", row.Item("少数桁数").ToString)
                txt単位名称.Text = IIf(IsDBNull(row.Item("単位名称")), "", row.Item("単位名称").ToString)
            Case "閾値"


        End Select
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btn戻る.Click
        Me.Close()
    End Sub

    Private Sub 項目マスタ入力フォーム_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Not IsNothing(row) Then
            If shinki Then
                Exit Sub
            End If
            Call setItem()
        End If

    End Sub

    Private Sub btn決定_Click(sender As System.Object, e As System.EventArgs) Handles btn決定.Click
        Dim db As db = New db
        Dim sql As String = ""
        Dim errmsg As String = ""
        Dim errobj As Object = Nothing
        Dim gorow As Integer = 0

        With db
            Try
                errobj = txt入力項目コード
                If txt入力項目コード.Text = "" Then
                    errmsg = "入力項目コードを入力してください。"
                    Throw New No_InputException(errmsg)
                Else
                    ep.SetError(errobj, Nothing)
                End If

                errobj = txt入力項目表示名称
                If txt入力項目表示名称.Text = "" Then
                    errmsg = "入力項目表示名称を入力してください。"
                    Throw New No_InputException(errmsg)
                Else
                    ep.SetError(errobj, Nothing)
                End If

                errobj = txt少数桁数
                If Not IsNumeric(txt少数桁数.Text) Then
                    errmsg = "少数桁数は半角数字です。"
                    Throw New No_InputException(errmsg)
                Else
                    ep.SetError(errobj, Nothing)
                End If

                If MessageBox.Show("登録します。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> Windows.Forms.DialogResult.Yes Then
                    Exit Sub
                End If

                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                If Not .starttrn(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                If txt入力項目コード.Enabled = False Then
                    sql = "Update 検査項目マスタ "
                    sql += "SET "
                    sql += "入力項目コード = '" + txt入力項目コード.Text + "',"
                    sql += "入力項目表示名称 = '" + txt入力項目表示名称.Text + "',"
                    sql += "入力形式 = '" + txt入力形式.Text + "',"
                    sql += "少数桁数 = '" + txt少数桁数.Text + "',"
                    sql += "単位名称 = '" + txt単位名称.Text + "' "
                    sql += "WHERE "
                    sql += "入力項目コード = '" + txt入力項目コード.Text + "'"
                    gorow = メンテView.selrow
                Else
                    sql = "insert into 検査項目マスタ "
                    sql += "(入力項目コード,入力項目表示名称,入力形式,少数桁数,単位名称) "
                    sql += "values("
                    sql += "'" + txt入力項目コード.Text + "',"
                    sql += "'" + txt入力項目表示名称.Text + "',"
                    sql += "'" + txt入力形式.Text + "',"
                    sql += "'" + txt少数桁数.Text + "',"
                    sql += "'" + txt単位名称.Text + "')"
                    gorow = メンテView.selrow + 1
                End If

                If Not .execNonQTran(sql, errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                .committrn()
                MessageBox.Show("登録しました。", "確認", MessageBoxButtons.OK)
                メンテView.Display()
                メンテView.dgv.FirstDisplayedScrollingRowIndex = gorow
                Me.Close()
                Me.Dispose()
            Catch ex As No_InputException
                SystemSounds.Exclamation.Play()
                ep.SetError(errobj, errmsg)

            Catch ex As DBErrorException
                .rollbacktran()
                MessageBox.Show("DBエラーが発生しました。")
                .rollbacktran()
            Catch ex As Exception
                MessageBox.Show("不明なエラーが発生しました。")
            End Try
            If Not IsNothing(.con) Then
                .close()
            End If

        End With


    End Sub

End Class


