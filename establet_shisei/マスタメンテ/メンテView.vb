Option Explicit On

Imports System.IO

Public Class メンテView
    Private dr() As DataRow = Nothing
    Private dt As DataTable = Nothing
    Public selrow As Integer = Nothing
    Public mode As String = ""
    Private firstrows As Long = 0
    Private chglst As ArrayList

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        dgv.ReadOnly = True
        'dgv.RowTemplate.Height = 50
        dgv.AllowUserToAddRows = False       'データ追加禁止
        dgv.RowCount = 0
        dgv.ReadOnly = True                  '編集禁止
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect  '行選択モード
        dgv.RowHeadersVisible = False        'Rowヘッダは非表示
        dgv.MultiSelect = False               '複数行選択非許可
        dgv.AllowUserToResizeRows = False    '行の高さの変更禁止
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Red
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.RowsDefaultCellStyle.BackColor = Color.White
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
        '並び替えができないようにする
        For Each c As DataGridViewColumn In dgv.Columns
            c.SortMode = DataGridViewColumnSortMode.NotSortable
        Next c

    End Sub

    Private Sub btn戻る_Click(sender As System.Object, e As System.EventArgs) Handles btn戻る.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btn新規登録_Click(sender As System.Object, e As System.EventArgs) Handles btn新規登録.Click
        Call EditRow(True, selrow)
    End Sub

    Private Sub btn編集_Click(sender As System.Object, e As System.EventArgs) Handles btn編集.Click
        Call EditRow(False, selrow)
    End Sub

    Private Sub EditRow(flg As Boolean, selrow As Integer)
        Select Case mode
            Case "項目"
                Using fm As 項目マスタ入力フォーム = New 項目マスタ入力フォーム
                    fm.shinki = flg
                    fm.txt入力項目コード.Enabled = flg
                    fm.row = dt.Rows(selrow)
                    fm.ShowDialog()
                End Using
            Case "閾値"
                Using fm As 閾値入力フォーム = New 閾値入力フォーム
                    fm.shinki = flg
                    fm.txt名称.Enabled = flg
                    fm.row = dt.Rows(selrow)
                    fm.ShowDialog()
                End Using

        End Select

    End Sub


    Private Sub メンテView_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Display()
    End Sub


    Public Sub Display()
        Dim sql As String = ""
        Dim db As db = New db
        Dim errmsg As String = ""

        With db
            Try
                Select Case mode
                    Case "項目"
                        sql = "select * from 検査項目マスタ order by 入力項目コード"
                    Case "閾値"
                        sql = "select * from 閾値"
                End Select
                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If

                dt = .ExecuteSql(sql.ToString)
                dgv.DataSource = dt
                firstrows = dt.Rows.Count

                dgv.Columns(0).Width = 120
                dgv.Columns(1).Width = 150

                .close()
            Catch ex As DBErrorException
                MessageBox.Show("DBエラーが発生しました。")
            Catch ex As Exception
                MessageBox.Show("不明なエラーが発生しました。")

            End Try
        End With

    End Sub

    Private Sub dgv_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentDoubleClick
        Call EditRow(False, selrow)
    End Sub

    Private Sub dgv_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellValueChanged
        chglst.Add(dgv(0, e.RowIndex)).ToString()

    End Sub

    Private Sub dgv_Click(sender As Object, e As System.EventArgs) Handles dgv.Click
        '選択されている行を表示
        Console.WriteLine("選択されている行")
        For Each r As DataGridViewRow In dgv.SelectedRows
            selrow = r.Index
        Next r
        selrow = selrow
    End Sub

    Private Sub btn削除_Click(sender As System.Object, e As System.EventArgs) Handles btn削除.Click
        Dim db As db = New db
        Dim sql As String = ""
        Dim errmsg As String = ""

        If MessageBox.Show("指定されているレコードを削除します。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        With db
            Try
                Select Case mode
                    Case "項目"
                        sql = "delete from 検査項目マスタ where 入力項目コード = '" + dgv(0, selrow).Value.ToString + "'"
                    Case "閾値"
                        sql = "delete from 閾値 where 名称 ='" + dgv(0, selrow).Value.ToString + "'"
                End Select
                If Not .connect(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If
                If Not .starttrn(errmsg) Then
                    Throw New DBErrorException(errmsg)
                End If
                .execNonQTran(sql, errmsg)

                .committrn()
                .close()
                Display()

            Catch ex As DBErrorException
                MessageBox.Show("DBエラーが発生しました。")
                .rollbacktran()
            Catch ex As Exception
                MessageBox.Show("不明なエラーが発生しました。")
            Finally
                If Not IsNothing(.con) Then
                    .close()
                End If

            End Try
        End With
    End Sub

    Private Sub btnCSV出力_Click(sender As System.Object, e As System.EventArgs) Handles btnCSV出力.Click
        Dim buff As String = ""
        Dim fname As String = ""

        Select Case mode
            Case "項目"
                sfd.FileName = "項目マスタ.csv"
            Case "閾値"
                sfd.FileName = "閾値.csv"
        End Select

        sfd.Filter = "CSVファイル(*.csv;*.CSV)|*.csv;*.CSV|すべてのファイル(*.*)|*.*"
        sfd.FilterIndex = 2
        sfd.Title = "保存先のファイルを選択してください"
        If sfd.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき

            Using writer As StreamWriter = New StreamWriter(sfd.FileName, False, System.Text.Encoding.GetEncoding("shift_jis"))
                For row = 0 To dgv.Rows.Count - 1 Step 1
                    For col = 0 To dgv.Columns.Count - 1 Step 1
                        buff += dgv(col, row).Value.ToString + ","
                    Next col

                    buff = Left_(buff, buff.Length - 1) + vbCrLf
                    writer.Write(buff)
                    buff = ""
                Next row
            End Using
            MessageBox.Show("CSVファィルの出力が終了しました。", "マスタメンテ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        sfd.Dispose()
    End Sub

End Class