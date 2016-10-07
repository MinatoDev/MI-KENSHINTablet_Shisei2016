<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.tab = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn開始 = New System.Windows.Forms.Button()
        Me.lstFiles = New System.Windows.Forms.ListBox()
        Me.btn参照 = New System.Windows.Forms.Button()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn送信 = New System.Windows.Forms.Button()
        Me.lstFiles2 = New System.Windows.Forms.ListBox()
        Me.btn参照2 = New System.Windows.Forms.Button()
        Me.txtFilePath2 = New System.Windows.Forms.TextBox()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ep = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab
        '
        Me.tab.Controls.Add(Me.TabPage1)
        Me.tab.Controls.Add(Me.TabPage2)
        Me.tab.Font = New System.Drawing.Font("メイリオ", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.tab.Location = New System.Drawing.Point(30, 86)
        Me.tab.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.tab.Name = "tab"
        Me.tab.SelectedIndex = 0
        Me.tab.Size = New System.Drawing.Size(1299, 584)
        Me.tab.TabIndex = 0
        Me.tab.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn開始)
        Me.TabPage1.Controls.Add(Me.lstFiles)
        Me.TabPage1.Controls.Add(Me.btn参照)
        Me.TabPage1.Controls.Add(Me.txtFilePath)
        Me.TabPage1.Location = New System.Drawing.Point(4, 53)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TabPage1.Size = New System.Drawing.Size(1291, 527)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "データ取込"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn開始
        '
        Me.btn開始.Enabled = False
        Me.btn開始.Location = New System.Drawing.Point(1180, 449)
        Me.btn開始.Margin = New System.Windows.Forms.Padding(4)
        Me.btn開始.Name = "btn開始"
        Me.btn開始.Size = New System.Drawing.Size(95, 57)
        Me.btn開始.TabIndex = 5
        Me.btn開始.Text = "開始"
        Me.btn開始.UseVisualStyleBackColor = True
        '
        'lstFiles
        '
        Me.lstFiles.FormattingEnabled = True
        Me.lstFiles.ItemHeight = 44
        Me.lstFiles.Location = New System.Drawing.Point(42, 150)
        Me.lstFiles.Margin = New System.Windows.Forms.Padding(4)
        Me.lstFiles.Name = "lstFiles"
        Me.lstFiles.Size = New System.Drawing.Size(1121, 356)
        Me.lstFiles.TabIndex = 4
        '
        'btn参照
        '
        Me.btn参照.Font = New System.Drawing.Font("メイリオ", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn参照.Location = New System.Drawing.Point(1180, 71)
        Me.btn参照.Margin = New System.Windows.Forms.Padding(4)
        Me.btn参照.Name = "btn参照"
        Me.btn参照.Size = New System.Drawing.Size(95, 49)
        Me.btn参照.TabIndex = 2
        Me.btn参照.Text = "参照"
        Me.btn参照.UseVisualStyleBackColor = True
        '
        'txtFilePath
        '
        Me.txtFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilePath.Location = New System.Drawing.Point(42, 71)
        Me.txtFilePath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(1121, 51)
        Me.txtFilePath.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn送信)
        Me.TabPage2.Controls.Add(Me.lstFiles2)
        Me.TabPage2.Controls.Add(Me.btn参照2)
        Me.TabPage2.Controls.Add(Me.txtFilePath2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 53)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TabPage2.Size = New System.Drawing.Size(1291, 527)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "結果送信"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn送信
        '
        Me.btn送信.Location = New System.Drawing.Point(1180, 449)
        Me.btn送信.Margin = New System.Windows.Forms.Padding(4)
        Me.btn送信.Name = "btn送信"
        Me.btn送信.Size = New System.Drawing.Size(95, 57)
        Me.btn送信.TabIndex = 11
        Me.btn送信.Text = "送信"
        Me.btn送信.UseVisualStyleBackColor = True
        '
        'lstFiles2
        '
        Me.lstFiles2.FormattingEnabled = True
        Me.lstFiles2.ItemHeight = 44
        Me.lstFiles2.Location = New System.Drawing.Point(42, 150)
        Me.lstFiles2.Margin = New System.Windows.Forms.Padding(4)
        Me.lstFiles2.Name = "lstFiles2"
        Me.lstFiles2.Size = New System.Drawing.Size(1121, 356)
        Me.lstFiles2.TabIndex = 10
        '
        'btn参照2
        '
        Me.btn参照2.Font = New System.Drawing.Font("メイリオ", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn参照2.Location = New System.Drawing.Point(1180, 71)
        Me.btn参照2.Margin = New System.Windows.Forms.Padding(4)
        Me.btn参照2.Name = "btn参照2"
        Me.btn参照2.Size = New System.Drawing.Size(95, 49)
        Me.btn参照2.TabIndex = 8
        Me.btn参照2.Text = "参照"
        Me.btn参照2.UseVisualStyleBackColor = True
        '
        'txtFilePath2
        '
        Me.txtFilePath2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilePath2.Location = New System.Drawing.Point(42, 71)
        Me.txtFilePath2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFilePath2.Name = "txtFilePath2"
        Me.txtFilePath2.Size = New System.Drawing.Size(1121, 51)
        Me.txtFilePath2.TabIndex = 7
        '
        'btn終了
        '
        Me.btn終了.Font = New System.Drawing.Font("メイリオ", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn終了.Location = New System.Drawing.Point(1220, 681)
        Me.btn終了.Margin = New System.Windows.Forms.Padding(4)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(109, 55)
        Me.btn終了.TabIndex = 99
        Me.btn終了.Text = "終了"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(496, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(320, 55)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "健診システム連携"
        '
        'ep
        '
        Me.ep.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ESTabletServer.My.Resources.Resources.estSVlogo
        Me.PictureBox1.Location = New System.Drawing.Point(1064, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(261, 43)
        Me.PictureBox1.TabIndex = 1004
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1276, 735)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn終了)
        Me.Controls.Add(Me.tab)
        Me.Font = New System.Drawing.Font("メイリオ", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "健診システム連携"
        Me.tab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tab As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btn終了 As System.Windows.Forms.Button
    Friend WithEvents btn開始 As System.Windows.Forms.Button
    Friend WithEvents lstFiles As System.Windows.Forms.ListBox
    Friend WithEvents btn参照 As System.Windows.Forms.Button
    Friend WithEvents txtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider
    Friend WithEvents btn送信 As System.Windows.Forms.Button
    Friend WithEvents lstFiles2 As System.Windows.Forms.ListBox
    Friend WithEvents btn参照2 As System.Windows.Forms.Button
    Friend WithEvents txtFilePath2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
