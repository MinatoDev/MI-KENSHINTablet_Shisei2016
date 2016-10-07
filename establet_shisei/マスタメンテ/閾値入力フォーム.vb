Imports System.Media

Public Class 閾値入力フォーム
    Public shinki As Boolean
    Public row As DataRow


    Private Sub setItem()
        txt名称.Text = ""
        txt最低.Text = ""
        txt最高.Text = ""

        If Not shinki Then
            txt名称.Text = row.Item("名称").ToString
            txt最低.Text = IIf(IsDBNull(row.Item("最低")), "", row.Item("最低").ToString)
            txt最高.Text = IIf(IsDBNull(row.Item("最高")), "", row.Item("最高").ToString)
        End If
    End Sub

    Private Sub 閾値入力フォーム_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
                errobj = txt名称
                If txt名称.Text = "" Then
                    errmsg = "名称を入力してください。"
                    Throw New No_InputException(errmsg)
                Else
                    ep.SetError(errobj, Nothing)
                End If


                errobj = txt最低
                If Not IsNumeric(txt最低.Text) Then
                    errmsg = "最低は半角数字です。"
                    Throw New No_InputException(errmsg)
                Else
                    ep.SetError(errobj, Nothing)
                End If

                errobj = txt最高
                If Not IsNumeric(txt最高.Text) Then
                    errmsg = "最高は半角数字です。"
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

                If txt名称.Enabled = False Then
                    sql = "Update 閾値 "
                    sql += "SET "
                    sql += "最低 = " + txt最低.Text + ","
                    sql += "最高 = " + txt最高.Text + " "
                    sql += "WHERE "
                    sql += "名称 = '" + txt名称.Text + "'"
                    gorow = メンテView.selrow
                Else
                    sql = "insert into 閾値 "
                    sql += "(名称,最低,最高) "
                    sql += "values("
                    sql += "'" + txt名称.Text + "',"
                    sql += txt最低.Text + ","
                    sql += txt最高.Text + ")"
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

    Private Sub btn戻る_Click(sender As System.Object, e As System.EventArgs) Handles btn戻る.Click
        Me.Close()
    End Sub
End Class