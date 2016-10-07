Option Explicit On

Public Class マスタメンテ
    Private selmas As String = ""

    Private Sub btn終了_Click(sender As System.Object, e As System.EventArgs) Handles btn終了.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnItem_Click(sender As System.Object, e As System.EventArgs) Handles btnItem.Click
        メンテView.mode = "項目"
        メンテView.ShowDialog()
    End Sub

    Private Sub btn閾値_Click(sender As System.Object, e As System.EventArgs) Handles btn閾値.Click
        メンテView.mode = "閾値"
        メンテView.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim db As db = New db
        Dim sql As String = ""
        Dim errmsg As String = ""
        Dim errobj As Object = Nothing
        Dim gorow As Integer = 0

        With db
            Try

                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                If Not .starttrn(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                sql = Me.TextBox1.Text
                If Not .execNonQTran(sql, errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                sql = Me.TextBox1.Text

                .committrn()
                MessageBox.Show("実行しました。", "確認", MessageBoxButtons.OK)
                Me.Close()
                Me.Dispose()

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
