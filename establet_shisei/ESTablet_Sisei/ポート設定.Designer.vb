<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ポート設定
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
        Me.cmbPort = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbビット秒 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbパリティ = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbストップビット = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbフロー制御 = New System.Windows.Forms.ComboBox()
        Me.btn設定 = New System.Windows.Forms.Button()
        Me.btn戻る = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbデータビット = New System.Windows.Forms.ComboBox()
        Me.ep = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.sp = New System.IO.Ports.SerialPort(Me.components)
        Me.btn血圧計 = New System.Windows.Forms.Button()
        Me.btn身長体重計 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbPort
        '
        Me.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPort.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbPort.FormattingEnabled = True
        Me.cmbPort.Location = New System.Drawing.Point(440, 149)
        Me.cmbPort.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(238, 63)
        Me.cmbPort.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(219, 157)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 55)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "使用ポート"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(239, 311)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 55)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ビット/秒"
        '
        'cmbビット秒
        '
        Me.cmbビット秒.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbビット秒.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbビット秒.FormattingEnabled = True
        Me.cmbビット秒.Items.AddRange(New Object() {"", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200"})
        Me.cmbビット秒.Location = New System.Drawing.Point(440, 303)
        Me.cmbビット秒.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.cmbビット秒.Name = "cmbビット秒"
        Me.cmbビット秒.Size = New System.Drawing.Size(238, 63)
        Me.cmbビット秒.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(258, 387)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 55)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "パリティ"
        '
        'cmbパリティ
        '
        Me.cmbパリティ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbパリティ.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbパリティ.FormattingEnabled = True
        Me.cmbパリティ.Items.AddRange(New Object() {"", "なし", "奇数", "偶数", "1", "0"})
        Me.cmbパリティ.Location = New System.Drawing.Point(440, 380)
        Me.cmbパリティ.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.cmbパリティ.Name = "cmbパリティ"
        Me.cmbパリティ.Size = New System.Drawing.Size(238, 63)
        Me.cmbパリティ.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(145, 465)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(283, 55)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "ストップビット"
        '
        'cmbストップビット
        '
        Me.cmbストップビット.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbストップビット.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbストップビット.FormattingEnabled = True
        Me.cmbストップビット.Items.AddRange(New Object() {"", "1", "1.5", "2"})
        Me.cmbストップビット.Location = New System.Drawing.Point(440, 457)
        Me.cmbストップビット.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.cmbストップビット.Name = "cmbストップビット"
        Me.cmbストップビット.Size = New System.Drawing.Size(238, 63)
        Me.cmbストップビット.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(219, 544)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 55)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "フロー制御"
        '
        'cmbフロー制御
        '
        Me.cmbフロー制御.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbフロー制御.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbフロー制御.FormattingEnabled = True
        Me.cmbフロー制御.Items.AddRange(New Object() {"", "なし", "XON/XOFF", "RTS/CTS", "XON/XOFF + RTS/CTS"})
        Me.cmbフロー制御.Location = New System.Drawing.Point(440, 536)
        Me.cmbフロー制御.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.cmbフロー制御.Name = "cmbフロー制御"
        Me.cmbフロー制御.Size = New System.Drawing.Size(552, 63)
        Me.cmbフロー制御.TabIndex = 5
        '
        'btn設定
        '
        Me.btn設定.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn設定.Location = New System.Drawing.Point(865, 648)
        Me.btn設定.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.btn設定.Name = "btn設定"
        Me.btn設定.Size = New System.Drawing.Size(147, 77)
        Me.btn設定.TabIndex = 6
        Me.btn設定.Text = "設定"
        Me.btn設定.UseVisualStyleBackColor = True
        '
        'btn戻る
        '
        Me.btn戻る.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn戻る.Location = New System.Drawing.Point(1024, 648)
        Me.btn戻る.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.btn戻る.Name = "btn戻る"
        Me.btn戻る.Size = New System.Drawing.Size(147, 77)
        Me.btn戻る.TabIndex = 7
        Me.btn戻る.Text = "戻る"
        Me.btn戻る.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(182, 229)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(246, 55)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "データビット"
        '
        'cmbデータビット
        '
        Me.cmbデータビット.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbデータビット.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbデータビット.FormattingEnabled = True
        Me.cmbデータビット.Items.AddRange(New Object() {"", "7", "8"})
        Me.cmbデータビット.Location = New System.Drawing.Point(440, 226)
        Me.cmbデータビット.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.cmbデータビット.Name = "cmbデータビット"
        Me.cmbデータビット.Size = New System.Drawing.Size(238, 63)
        Me.cmbデータビット.TabIndex = 1
        '
        'ep
        '
        Me.ep.ContainerControl = Me
        '
        'btn血圧計
        '
        Me.btn血圧計.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn血圧計.Location = New System.Drawing.Point(838, 152)
        Me.btn血圧計.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.btn血圧計.Name = "btn血圧計"
        Me.btn血圧計.Size = New System.Drawing.Size(333, 54)
        Me.btn血圧計.TabIndex = 14
        Me.btn血圧計.Text = "血圧計設定"
        Me.btn血圧計.UseVisualStyleBackColor = True
        '
        'btn身長体重計
        '
        Me.btn身長体重計.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn身長体重計.Location = New System.Drawing.Point(838, 220)
        Me.btn身長体重計.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.btn身長体重計.Name = "btn身長体重計"
        Me.btn身長体重計.Size = New System.Drawing.Size(333, 54)
        Me.btn身長体重計.TabIndex = 15
        Me.btn身長体重計.Text = "身長・体重計設定"
        Me.btn身長体重計.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.計測.My.Resources.Resources.estSVlogo
        Me.PictureBox1.Location = New System.Drawing.Point(914, 16)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(257, 39)
        Me.PictureBox1.TabIndex = 108
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(441, 37)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(209, 55)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "ポート設定"
        '
        'ポート設定
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1186, 739)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn身長体重計)
        Me.Controls.Add(Me.btn血圧計)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbデータビット)
        Me.Controls.Add(Me.btn戻る)
        Me.Controls.Add(Me.btn設定)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbフロー制御)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbストップビット)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbパリティ)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbビット秒)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbPort)
        Me.Font = New System.Drawing.Font("メイリオ", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "ポート設定"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ポート設定"
        CType(Me.ep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbPort As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbビット秒 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbパリティ As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbストップビット As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbフロー制御 As System.Windows.Forms.ComboBox
    Friend WithEvents btn設定 As System.Windows.Forms.Button
    Friend WithEvents btn戻る As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbデータビット As System.Windows.Forms.ComboBox
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider
    Friend WithEvents sp As System.IO.Ports.SerialPort
    Friend WithEvents btn血圧計 As System.Windows.Forms.Button
    Friend WithEvents btn身長体重計 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
