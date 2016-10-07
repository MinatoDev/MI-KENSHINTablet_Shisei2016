<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setting
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
        Me.lblTenKey = New System.Windows.Forms.Label()
        Me.btnTenkty = New System.Windows.Forms.Button()
        Me.lblDSN = New System.Windows.Forms.Label()
        Me.txtDSN = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtDBName = New System.Windows.Forms.TextBox()
        Me.lblDBName = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btn登録 = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTenKey
        '
        Me.lblTenKey.AutoSize = True
        Me.lblTenKey.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTenKey.Location = New System.Drawing.Point(70, 70)
        Me.lblTenKey.Name = "lblTenKey"
        Me.lblTenKey.Size = New System.Drawing.Size(134, 29)
        Me.lblTenKey.TabIndex = 0
        Me.lblTenKey.Text = "実テンキー"
        '
        'btnTenkty
        '
        Me.btnTenkty.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnTenkty.Location = New System.Drawing.Point(233, 70)
        Me.btnTenkty.Name = "btnTenkty"
        Me.btnTenkty.Size = New System.Drawing.Size(202, 33)
        Me.btnTenkty.TabIndex = 1
        Me.btnTenkty.Tag = "false"
        Me.btnTenkty.Text = "使用しない"
        Me.btnTenkty.UseVisualStyleBackColor = True
        '
        'lblDSN
        '
        Me.lblDSN.AutoSize = True
        Me.lblDSN.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblDSN.Location = New System.Drawing.Point(70, 173)
        Me.lblDSN.Name = "lblDSN"
        Me.lblDSN.Size = New System.Drawing.Size(68, 29)
        Me.lblDSN.TabIndex = 2
        Me.lblDSN.Text = "DSN"
        '
        'txtDSN
        '
        Me.txtDSN.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtDSN.Location = New System.Drawing.Point(233, 171)
        Me.txtDSN.Name = "txtDSN"
        Me.txtDSN.Size = New System.Drawing.Size(273, 31)
        Me.txtDSN.TabIndex = 3
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(233, 292)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(273, 31)
        Me.txtUserName.TabIndex = 5
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(70, 294)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(138, 29)
        Me.lblUserName.TabIndex = 4
        Me.lblUserName.Text = "ユーザー名"
        '
        'txtDBName
        '
        Me.txtDBName.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtDBName.Location = New System.Drawing.Point(233, 233)
        Me.txtDBName.Name = "txtDBName"
        Me.txtDBName.Size = New System.Drawing.Size(273, 31)
        Me.txtDBName.TabIndex = 7
        '
        'lblDBName
        '
        Me.lblDBName.AutoSize = True
        Me.lblDBName.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblDBName.Location = New System.Drawing.Point(70, 235)
        Me.lblDBName.Name = "lblDBName"
        Me.lblDBName.Size = New System.Drawing.Size(79, 29)
        Me.lblDBName.TabIndex = 6
        Me.lblDBName.Text = "DB名"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(233, 354)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(273, 31)
        Me.txtPassword.TabIndex = 9
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(70, 356)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(129, 29)
        Me.lblPassword.TabIndex = 8
        Me.lblPassword.Text = "Password"
        '
        'btn登録
        '
        Me.btn登録.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn登録.Location = New System.Drawing.Point(233, 416)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(142, 48)
        Me.btn登録.TabIndex = 10
        Me.btn登録.Text = "登録"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(468, 416)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(142, 48)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "キャンセル"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(639, 476)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btn登録)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtDBName)
        Me.Controls.Add(Me.lblDBName)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtDSN)
        Me.Controls.Add(Me.lblDSN)
        Me.Controls.Add(Me.btnTenkty)
        Me.Controls.Add(Me.lblTenKey)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Setting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTenKey As System.Windows.Forms.Label
    Friend WithEvents btnTenkty As System.Windows.Forms.Button
    Friend WithEvents lblDSN As System.Windows.Forms.Label
    Friend WithEvents txtDSN As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txtDBName As System.Windows.Forms.TextBox
    Friend WithEvents lblDBName As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents btn登録 As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
