﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageWindow
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
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnはい = New System.Windows.Forms.Button()
        Me.btnいいえ = New System.Windows.Forms.Button()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picIcon
        '
        Me.picIcon.Image = Global.Mi_KENSHINCommon.My.Resources.Resources.information
        Me.picIcon.Location = New System.Drawing.Point(37, 27)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(64, 64)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picIcon.TabIndex = 0
        Me.picIcon.TabStop = False
        '
        'lblMsg
        '
        Me.lblMsg.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(154, 9)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(637, 116)
        Me.lblMsg.TabIndex = 1
        Me.lblMsg.Text = "Label1"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.Control
        Me.btnOK.Font = New System.Drawing.Font("MS UI Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnOK.Location = New System.Drawing.Point(386, 128)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(109, 54)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnはい
        '
        Me.btnはい.BackColor = System.Drawing.SystemColors.Control
        Me.btnはい.Font = New System.Drawing.Font("MS UI Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnはい.Location = New System.Drawing.Point(271, 128)
        Me.btnはい.Name = "btnはい"
        Me.btnはい.Size = New System.Drawing.Size(109, 54)
        Me.btnはい.TabIndex = 3
        Me.btnはい.Text = "はい"
        Me.btnはい.UseVisualStyleBackColor = False
        '
        'btnいいえ
        '
        Me.btnいいえ.BackColor = System.Drawing.SystemColors.Control
        Me.btnいいえ.Font = New System.Drawing.Font("MS UI Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnいいえ.Location = New System.Drawing.Point(501, 128)
        Me.btnいいえ.Name = "btnいいえ"
        Me.btnいいえ.Size = New System.Drawing.Size(109, 54)
        Me.btnいいえ.TabIndex = 4
        Me.btnいいえ.Text = "いいえ"
        Me.btnいいえ.UseVisualStyleBackColor = False
        '
        'MessageWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(881, 194)
        Me.Controls.Add(Me.btnいいえ)
        Me.Controls.Add(Me.btnはい)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.picIcon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MessageWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MessageWindow"
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnはい As System.Windows.Forms.Button
    Friend WithEvents btnいいえ As System.Windows.Forms.Button
End Class
