﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 腹囲
    Inherits Mi_KENSHINCommon.KenshinTabletBase

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
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt腹囲値2 = New Mi_KENSHINCommon.Mi_TextBox()
        Me.txt腹囲値 = New Mi_KENSHINCommon.Mi_TextBox()
        Me.lbl腹囲値 = New System.Windows.Forms.Label()
        Me.lblTen = New System.Windows.Forms.Label()
        Me.lbl腹囲単位 = New System.Windows.Forms.Label()
        Me.lbl腹囲 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRegist
        '
        Me.btnRegist.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegist.BackColor = System.Drawing.SystemColors.Control
        Me.btnRegist.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnRegist.Location = New System.Drawing.Point(1010, 654)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(192, 85)
        Me.btnRegist.TabIndex = 1043
        Me.btnRegist.Text = "登  録"
        Me.btnRegist.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.txt腹囲値2)
        Me.Panel1.Controls.Add(Me.lbl腹囲値)
        Me.Panel1.Controls.Add(Me.lblTen)
        Me.Panel1.Controls.Add(Me.lbl腹囲単位)
        Me.Panel1.Controls.Add(Me.txt腹囲値)
        Me.Panel1.Controls.Add(Me.lbl腹囲)
        Me.Panel1.Location = New System.Drawing.Point(62, 167)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1140, 315)
        Me.Panel1.TabIndex = 1044
        '
        'txt腹囲値2
        '
        Me.txt腹囲値2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt腹囲値2.Font = New System.Drawing.Font("MS UI Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt腹囲値2.Location = New System.Drawing.Point(608, 180)
        Me.txt腹囲値2.MaxLength = 1
        Me.txt腹囲値2.Name = "txt腹囲値2"
        Me.txt腹囲値2.NextFocus = Me.btnRegist
        Me.txt腹囲値2.PrevFocus = Nothing
        Me.txt腹囲値2.Size = New System.Drawing.Size(56, 103)
        Me.txt腹囲値2.TabIndex = 1051
        '
        'txt腹囲値
        '
        Me.txt腹囲値.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt腹囲値.Font = New System.Drawing.Font("MS UI Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt腹囲値.Location = New System.Drawing.Point(385, 180)
        Me.txt腹囲値.MaxLength = 3
        Me.txt腹囲値.Name = "txt腹囲値"
        Me.txt腹囲値.NextFocus = Me.txt腹囲値2
        Me.txt腹囲値.PrevFocus = Nothing
        Me.txt腹囲値.Size = New System.Drawing.Size(158, 103)
        Me.txt腹囲値.TabIndex = 1050
        '
        'lbl腹囲値
        '
        Me.lbl腹囲値.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl腹囲値.BackColor = System.Drawing.Color.White
        Me.lbl腹囲値.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl腹囲値.Font = New System.Drawing.Font("MS UI Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl腹囲値.Location = New System.Drawing.Point(385, 83)
        Me.lbl腹囲値.Name = "lbl腹囲値"
        Me.lbl腹囲値.Size = New System.Drawing.Size(263, 94)
        Me.lbl腹囲値.TabIndex = 1049
        Me.lbl腹囲値.Text = "000.0"
        Me.lbl腹囲値.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTen
        '
        Me.lblTen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTen.Font = New System.Drawing.Font("MS UI Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTen.Location = New System.Drawing.Point(549, 197)
        Me.lblTen.Name = "lblTen"
        Me.lblTen.Size = New System.Drawing.Size(53, 99)
        Me.lblTen.TabIndex = 1052
        Me.lblTen.Text = "．"
        '
        'lbl腹囲単位
        '
        Me.lbl腹囲単位.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl腹囲単位.AutoSize = True
        Me.lbl腹囲単位.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl腹囲単位.Location = New System.Drawing.Point(654, 125)
        Me.lbl腹囲単位.Name = "lbl腹囲単位"
        Me.lbl腹囲単位.Size = New System.Drawing.Size(72, 72)
        Me.lbl腹囲単位.TabIndex = 1048
        Me.lbl腹囲単位.Text = "--"
        '
        'lbl腹囲
        '
        Me.lbl腹囲.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl腹囲.AutoSize = True
        Me.lbl腹囲.Font = New System.Drawing.Font("MS UI Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl腹囲.Location = New System.Drawing.Point(166, 83)
        Me.lbl腹囲.Name = "lbl腹囲"
        Me.lbl腹囲.Size = New System.Drawing.Size(138, 97)
        Me.lbl腹囲.TabIndex = 1047
        Me.lbl腹囲.Text = "--"
        Me.lbl腹囲.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '腹囲
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 780)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRegist)
        Me.Name = "腹囲"
        Me.Controls.SetChildIndex(Me.btnRegist, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRegist As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt腹囲値2 As Mi_KENSHINCommon.Mi_TextBox
    Friend WithEvents txt腹囲値 As Mi_KENSHINCommon.Mi_TextBox
    Friend WithEvents lbl腹囲値 As System.Windows.Forms.Label
    Friend WithEvents lblTen As System.Windows.Forms.Label
    Friend WithEvents lbl腹囲単位 As System.Windows.Forms.Label
    Friend WithEvents lbl腹囲 As System.Windows.Forms.Label

End Class
