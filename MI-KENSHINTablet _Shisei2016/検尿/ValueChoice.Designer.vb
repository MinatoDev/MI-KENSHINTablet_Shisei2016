<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ValueChoice
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPP = New System.Windows.Forms.Button()
        Me.btnP = New System.Windows.Forms.Button()
        Me.btnPM = New System.Windows.Forms.Button()
        Me.btnM = New System.Windows.Forms.Button()
        Me.btnPPP = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lbl検診名 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Font = New System.Drawing.Font("MS UI Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(1025, 638)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(181, 59)
        Me.btnCancel.TabIndex = 32
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "キャンセル"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnPP
        '
        Me.btnPP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPP.BackColor = System.Drawing.SystemColors.Control
        Me.btnPP.Font = New System.Drawing.Font("MS UI Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnPP.Location = New System.Drawing.Point(742, 118)
        Me.btnPP.Name = "btnPP"
        Me.btnPP.Size = New System.Drawing.Size(201, 110)
        Me.btnPP.TabIndex = 31
        Me.btnPP.TabStop = False
        Me.btnPP.Text = "++"
        Me.btnPP.UseVisualStyleBackColor = False
        '
        'btnP
        '
        Me.btnP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnP.BackColor = System.Drawing.SystemColors.Control
        Me.btnP.Font = New System.Drawing.Font("MS UI Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnP.Location = New System.Drawing.Point(507, 118)
        Me.btnP.Name = "btnP"
        Me.btnP.Size = New System.Drawing.Size(201, 110)
        Me.btnP.TabIndex = 30
        Me.btnP.TabStop = False
        Me.btnP.Text = "+"
        Me.btnP.UseVisualStyleBackColor = False
        '
        'btnPM
        '
        Me.btnPM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPM.BackColor = System.Drawing.SystemColors.Control
        Me.btnPM.Font = New System.Drawing.Font("MS UI Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnPM.Location = New System.Drawing.Point(275, 118)
        Me.btnPM.Name = "btnPM"
        Me.btnPM.Size = New System.Drawing.Size(201, 110)
        Me.btnPM.TabIndex = 29
        Me.btnPM.TabStop = False
        Me.btnPM.Text = "+-"
        Me.btnPM.UseVisualStyleBackColor = False
        '
        'btnM
        '
        Me.btnM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnM.BackColor = System.Drawing.SystemColors.Control
        Me.btnM.Font = New System.Drawing.Font("MS UI Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnM.Location = New System.Drawing.Point(40, 118)
        Me.btnM.Name = "btnM"
        Me.btnM.Size = New System.Drawing.Size(201, 110)
        Me.btnM.TabIndex = 28
        Me.btnM.TabStop = False
        Me.btnM.Text = "-"
        Me.btnM.UseVisualStyleBackColor = False
        '
        'btnPPP
        '
        Me.btnPPP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPPP.BackColor = System.Drawing.SystemColors.Control
        Me.btnPPP.Font = New System.Drawing.Font("MS UI Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnPPP.Location = New System.Drawing.Point(975, 118)
        Me.btnPPP.Name = "btnPPP"
        Me.btnPPP.Size = New System.Drawing.Size(201, 110)
        Me.btnPPP.TabIndex = 33
        Me.btnPPP.TabStop = False
        Me.btnPPP.Text = "+++"
        Me.btnPPP.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnPP)
        Me.Panel1.Controls.Add(Me.btnPPP)
        Me.Panel1.Controls.Add(Me.btnM)
        Me.Panel1.Controls.Add(Me.btnPM)
        Me.Panel1.Controls.Add(Me.btnP)
        Me.Panel1.Location = New System.Drawing.Point(30, 110)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1207, 383)
        Me.Panel1.TabIndex = 34
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnClear.Location = New System.Drawing.Point(975, 250)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(201, 110)
        Me.btnClear.TabIndex = 34
        Me.btnClear.TabStop = False
        Me.btnClear.Text = "クリア"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lbl検診名
        '
        Me.lbl検診名.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl検診名.AutoSize = True
        Me.lbl検診名.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl検診名.Location = New System.Drawing.Point(37, 696)
        Me.lbl検診名.Name = "lbl検診名"
        Me.lbl検診名.Size = New System.Drawing.Size(119, 29)
        Me.lbl検診名.TabIndex = 35
        Me.lbl検診名.Text = "【 検尿 】"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("MS UI Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(38, 62)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(54, 37)
        Me.lblTitle.TabIndex = 35
        Me.lblTitle.Text = "{0}"
        '
        'ValueChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 761)
        Me.Controls.Add(Me.lbl検診名)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ValueChoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPP As System.Windows.Forms.Button
    Friend WithEvents btnP As System.Windows.Forms.Button
    Friend WithEvents btnPM As System.Windows.Forms.Button
    Friend WithEvents btnM As System.Windows.Forms.Button
    Friend WithEvents btnPPP As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl検診名 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
End Class
