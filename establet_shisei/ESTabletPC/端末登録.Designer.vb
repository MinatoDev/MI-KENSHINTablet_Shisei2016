<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 端末登録
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(端末登録))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIP1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIP2 = New System.Windows.Forms.TextBox()
        Me.txtIP4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIP3 = New System.Windows.Forms.TextBox()
        Me.txt端末名 = New System.Windows.Forms.TextBox()
        Me.txtグループ = New System.Windows.Forms.TextBox()
        Me.txt備考 = New System.Windows.Forms.TextBox()
        Me.btn登録 = New System.Windows.Forms.Button()
        Me.btn戻る = New System.Windows.Forms.Button()
        Me.cmb用途 = New System.Windows.Forms.ComboBox()
        Me.ep = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(114, 143)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "端末IP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(114, 228)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 55)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "端末名"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(152, 313)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 55)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "用途"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(102, 415)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 55)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "グループ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(140, 505)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 55)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "備考"
        '
        'txtIP1
        '
        Me.txtIP1.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtIP1.Location = New System.Drawing.Point(289, 133)
        Me.txtIP1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIP1.Name = "txtIP1"
        Me.txtIP1.ReadOnly = True
        Me.txtIP1.Size = New System.Drawing.Size(77, 63)
        Me.txtIP1.TabIndex = 5
        Me.txtIP1.TabStop = False
        Me.txtIP1.Text = "192"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(368, 151)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 55)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(480, 151)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 55)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "."
        '
        'txtIP2
        '
        Me.txtIP2.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtIP2.Location = New System.Drawing.Point(400, 133)
        Me.txtIP2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIP2.Name = "txtIP2"
        Me.txtIP2.ReadOnly = True
        Me.txtIP2.Size = New System.Drawing.Size(77, 63)
        Me.txtIP2.TabIndex = 7
        Me.txtIP2.TabStop = False
        Me.txtIP2.Text = "168"
        '
        'txtIP4
        '
        Me.txtIP4.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtIP4.Location = New System.Drawing.Point(620, 133)
        Me.txtIP4.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIP4.MaxLength = 3
        Me.txtIP4.Name = "txtIP4"
        Me.txtIP4.Size = New System.Drawing.Size(77, 63)
        Me.txtIP4.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(588, 151)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 55)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "."
        '
        'txtIP3
        '
        Me.txtIP3.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtIP3.Location = New System.Drawing.Point(512, 133)
        Me.txtIP3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIP3.Name = "txtIP3"
        Me.txtIP3.ReadOnly = True
        Me.txtIP3.Size = New System.Drawing.Size(77, 63)
        Me.txtIP3.TabIndex = 9
        Me.txtIP3.TabStop = False
        Me.txtIP3.Text = "100"
        '
        'txt端末名
        '
        Me.txt端末名.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt端末名.Location = New System.Drawing.Point(289, 223)
        Me.txt端末名.Margin = New System.Windows.Forms.Padding(4)
        Me.txt端末名.MaxLength = 20
        Me.txt端末名.Name = "txt端末名"
        Me.txt端末名.Size = New System.Drawing.Size(326, 63)
        Me.txt端末名.TabIndex = 2
        '
        'txtグループ
        '
        Me.txtグループ.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtグループ.Location = New System.Drawing.Point(289, 405)
        Me.txtグループ.Margin = New System.Windows.Forms.Padding(4)
        Me.txtグループ.MaxLength = 10
        Me.txtグループ.Name = "txtグループ"
        Me.txtグループ.Size = New System.Drawing.Size(188, 63)
        Me.txtグループ.TabIndex = 4
        '
        'txt備考
        '
        Me.txt備考.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt備考.Location = New System.Drawing.Point(289, 495)
        Me.txt備考.Margin = New System.Windows.Forms.Padding(4)
        Me.txt備考.MaxLength = 128
        Me.txt備考.Name = "txt備考"
        Me.txt備考.Size = New System.Drawing.Size(473, 63)
        Me.txt備考.TabIndex = 5
        '
        'btn登録
        '
        Me.btn登録.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn登録.Location = New System.Drawing.Point(628, 602)
        Me.btn登録.Margin = New System.Windows.Forms.Padding(4)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(140, 75)
        Me.btn登録.TabIndex = 16
        Me.btn登録.Text = "登録"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'btn戻る
        '
        Me.btn戻る.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn戻る.Location = New System.Drawing.Point(808, 606)
        Me.btn戻る.Margin = New System.Windows.Forms.Padding(4)
        Me.btn戻る.Name = "btn戻る"
        Me.btn戻る.Size = New System.Drawing.Size(146, 71)
        Me.btn戻る.TabIndex = 6
        Me.btn戻る.Text = "戻る"
        Me.btn戻る.UseVisualStyleBackColor = True
        '
        'cmb用途
        '
        Me.cmb用途.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb用途.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb用途.FormattingEnabled = True
        Me.cmb用途.Items.AddRange(New Object() {"", "腹囲", "視力", "学校視力", "聴力", "検尿", "診察", "血圧"})
        Me.cmb用途.Location = New System.Drawing.Point(289, 313)
        Me.cmb用途.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb用途.Name = "cmb用途"
        Me.cmb用途.Size = New System.Drawing.Size(188, 63)
        Me.cmb用途.TabIndex = 3
        '
        'ep
        '
        Me.ep.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(628, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(304, 63)
        Me.PictureBox1.TabIndex = 108
        Me.PictureBox1.TabStop = False
        '
        '端末登録
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(967, 689)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmb用途)
        Me.Controls.Add(Me.btn戻る)
        Me.Controls.Add(Me.btn登録)
        Me.Controls.Add(Me.txt備考)
        Me.Controls.Add(Me.txtグループ)
        Me.Controls.Add(Me.txt端末名)
        Me.Controls.Add(Me.txtIP4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtIP3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtIP2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtIP1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("メイリオ", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "端末登録"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "端末登録"
        CType(Me.ep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtIP1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtIP2 As System.Windows.Forms.TextBox
    Friend WithEvents txtIP4 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtIP3 As System.Windows.Forms.TextBox
    Friend WithEvents txt端末名 As System.Windows.Forms.TextBox
    Friend WithEvents txtグループ As System.Windows.Forms.TextBox
    Friend WithEvents txt備考 As System.Windows.Forms.TextBox
    Friend WithEvents btn登録 As System.Windows.Forms.Button
    Friend WithEvents btn戻る As System.Windows.Forms.Button
    Friend WithEvents cmb用途 As System.Windows.Forms.ComboBox
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
