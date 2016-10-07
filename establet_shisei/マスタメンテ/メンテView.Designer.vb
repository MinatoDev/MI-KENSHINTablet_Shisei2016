<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class メンテView
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btn新規登録 = New System.Windows.Forms.Button()
        Me.btn編集 = New System.Windows.Forms.Button()
        Me.btn削除 = New System.Windows.Forms.Button()
        Me.btnCSV出力 = New System.Windows.Forms.Button()
        Me.btnCSV読込 = New System.Windows.Forms.Button()
        Me.btn戻る = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 50)
        Me.dgv.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 21
        Me.dgv.Size = New System.Drawing.Size(845, 595)
        Me.dgv.TabIndex = 0
        '
        'btn新規登録
        '
        Me.btn新規登録.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn新規登録.Location = New System.Drawing.Point(12, 669)
        Me.btn新規登録.Name = "btn新規登録"
        Me.btn新規登録.Size = New System.Drawing.Size(118, 48)
        Me.btn新規登録.TabIndex = 1
        Me.btn新規登録.Text = "新規登録"
        Me.btn新規登録.UseVisualStyleBackColor = True
        '
        'btn編集
        '
        Me.btn編集.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn編集.Location = New System.Drawing.Point(147, 669)
        Me.btn編集.Name = "btn編集"
        Me.btn編集.Size = New System.Drawing.Size(118, 48)
        Me.btn編集.TabIndex = 2
        Me.btn編集.Text = "編集"
        Me.btn編集.UseVisualStyleBackColor = True
        '
        'btn削除
        '
        Me.btn削除.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn削除.Location = New System.Drawing.Point(285, 669)
        Me.btn削除.Name = "btn削除"
        Me.btn削除.Size = New System.Drawing.Size(118, 48)
        Me.btn削除.TabIndex = 3
        Me.btn削除.Text = "削除"
        Me.btn削除.UseVisualStyleBackColor = True
        '
        'btnCSV出力
        '
        Me.btnCSV出力.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCSV出力.Location = New System.Drawing.Point(421, 669)
        Me.btnCSV出力.Name = "btnCSV出力"
        Me.btnCSV出力.Size = New System.Drawing.Size(118, 48)
        Me.btnCSV出力.TabIndex = 4
        Me.btnCSV出力.Text = "CSV出力"
        Me.btnCSV出力.UseVisualStyleBackColor = True
        '
        'btnCSV読込
        '
        Me.btnCSV読込.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCSV読込.Location = New System.Drawing.Point(556, 669)
        Me.btnCSV読込.Name = "btnCSV読込"
        Me.btnCSV読込.Size = New System.Drawing.Size(118, 48)
        Me.btnCSV読込.TabIndex = 5
        Me.btnCSV読込.Text = "CSV読込"
        Me.btnCSV読込.UseVisualStyleBackColor = True
        Me.btnCSV読込.Visible = False
        '
        'btn戻る
        '
        Me.btn戻る.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn戻る.Location = New System.Drawing.Point(748, 669)
        Me.btn戻る.Name = "btn戻る"
        Me.btn戻る.Size = New System.Drawing.Size(119, 48)
        Me.btn戻る.TabIndex = 7
        Me.btn戻る.Text = "戻る"
        Me.btn戻る.UseVisualStyleBackColor = True
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'メンテView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 729)
        Me.Controls.Add(Me.btn戻る)
        Me.Controls.Add(Me.btnCSV読込)
        Me.Controls.Add(Me.btnCSV出力)
        Me.Controls.Add(Me.btn削除)
        Me.Controls.Add(Me.btn編集)
        Me.Controls.Add(Me.btn新規登録)
        Me.Controls.Add(Me.dgv)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "メンテView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "項目マスタ一覧表示"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btn新規登録 As System.Windows.Forms.Button
    Friend WithEvents btn編集 As System.Windows.Forms.Button
    Friend WithEvents btn削除 As System.Windows.Forms.Button
    Friend WithEvents btnCSV出力 As System.Windows.Forms.Button
    Friend WithEvents btnCSV読込 As System.Windows.Forms.Button
    Friend WithEvents btn戻る As System.Windows.Forms.Button
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
End Class
