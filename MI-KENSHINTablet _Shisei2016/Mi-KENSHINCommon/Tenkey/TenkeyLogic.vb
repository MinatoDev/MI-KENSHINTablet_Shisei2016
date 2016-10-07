''' <summary>
''' テンキーロジッククラス
''' </summary>
''' <remarks></remarks>
Public Class TenkeyLogic

    ''' <summary>
    ''' キーが押された処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="btn"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InputKey(sender As Tenkey, btn As Button) As Boolean
        Try
            If btn.Text = "CLEAR" Then
                sender.lblAtai.Text = String.Empty
                Return True
            End If

            Dim mx As Integer = sender.Seisu
            If sender.lblAtai.Text.IndexOf(".") <> -1 Then
                mx += 2
            End If
            If sender.lblAtai.Text.Length >= mx AndAlso IsNumeric(btn.Text) Then
                '入力文字数が整数桁数と同じですべて数字
                Return False
            End If

            Dim work() As String = sender.lblAtai.Text.Split(".")
            If work.Length = 2 Then
                If work(1).Length = sender.Syousu Then
                    Return False
                End If
            End If

            With sender
                Select Case btn.Text
                    Case "０"
                        .lblAtai.Text += "0"
                    Case "１"
                        .lblAtai.Text += "1"
                    Case "２"
                        .lblAtai.Text += "2"
                    Case "３"
                        .lblAtai.Text += "3"
                    Case "４"
                        .lblAtai.Text += "4"
                    Case "５"
                        .lblAtai.Text += "5"
                    Case "６"
                        .lblAtai.Text += "6"
                    Case "７"
                        .lblAtai.Text += "7"
                    Case "８"
                        .lblAtai.Text += "8"
                    Case "９"
                        .lblAtai.Text += "9"
                    Case "．"
                        If .Text.IndexOf(".") <> -1 Or .lblAtai.Text = String.Empty Then
                            .lblAtai.Text = String.Empty
                            Exit Select
                        End If
                        '"."が２つ以上
                        If work.Length > 1 Then
                            Exit Select
                        End If
                        .lblAtai.Text += "."
                    Case "ＤＥＬ"
                        If .lblAtai.Text.Length = 0 Then
                            Exit Select
                        Else
                            .lblAtai.Text = Microsoft.VisualBasic.Left(.lblAtai.Text, .lblAtai.Text.Length - 1)
                        End If
                    Case "CLEAR"
                        .lblAtai.Text = String.Empty
                End Select
            End With
            Return True

        Catch ex As Exception
            Throw
        End Try
    End Function


End Class
