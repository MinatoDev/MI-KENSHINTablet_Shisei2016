﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 血圧
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(血圧))
        Me.lbl最低血圧1 = New System.Windows.Forms.Label()
        Me.lbl最高血圧単位1 = New System.Windows.Forms.Label()
        Me.lbl最低血圧単位1 = New System.Windows.Forms.Label()
        Me.lbl最高血圧2 = New System.Windows.Forms.Label()
        Me.lbl最低血圧2 = New System.Windows.Forms.Label()
        Me.lbl最高血圧単位2 = New System.Windows.Forms.Label()
        Me.lbl最低血圧単位2 = New System.Windows.Forms.Label()
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.btn血圧クリア1 = New System.Windows.Forms.Button()
        Me.btn血圧クリア2 = New System.Windows.Forms.Button()
        Me.lbl最高血圧1 = New System.Windows.Forms.Label()
        Me.lbl最高血圧値1 = New System.Windows.Forms.Label()
        Me.lbl最低血圧値1 = New System.Windows.Forms.Label()
        Me.lbl最高血圧値2 = New System.Windows.Forms.Label()
        Me.lbl最低血圧値2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt最低血圧値2 = New Mi_KENSHINCommon.Mi_TextBox()
        Me.txt最高血圧値2 = New Mi_KENSHINCommon.Mi_TextBox()
        Me.txt最低血圧値1 = New Mi_KENSHINCommon.Mi_TextBox()
        Me.txt最高血圧値1 = New Mi_KENSHINCommon.Mi_TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl最低血圧1
        '
        Me.lbl最低血圧1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl最低血圧1.AutoSize = True
        Me.lbl最低血圧1.Font = New System.Drawing.Font("メイリオ", 40.0!)
        Me.lbl最低血圧1.Location = New System.Drawing.Point(19, 177)
        Me.lbl最低血圧1.Name = "lbl最低血圧1"
        Me.lbl最低血圧1.Size = New System.Drawing.Size(83, 81)
        Me.lbl最低血圧1.TabIndex = 108
        Me.lbl最低血圧1.Text = "--"
        '
        'lbl最高血圧単位1
        '
        Me.lbl最高血圧単位1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl最高血圧単位1.AutoSize = True
        Me.lbl最高血圧単位1.Font = New System.Drawing.Font("メイリオ", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl最高血圧単位1.Location = New System.Drawing.Point(661, 121)
        Me.lbl最高血圧単位1.Name = "lbl最高血圧単位1"
        Me.lbl最高血圧単位1.Size = New System.Drawing.Size(46, 44)
        Me.lbl最高血圧単位1.TabIndex = 110
        Me.lbl最高血圧単位1.Text = "--"
        '
        'lbl最低血圧単位1
        '
        Me.lbl最低血圧単位1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl最低血圧単位1.AutoSize = True
        Me.lbl最低血圧単位1.Font = New System.Drawing.Font("メイリオ", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl最低血圧単位1.Location = New System.Drawing.Point(661, 226)
        Me.lbl最低血圧単位1.Name = "lbl最低血圧単位1"
        Me.lbl最低血圧単位1.Size = New System.Drawing.Size(46, 44)
        Me.lbl最低血圧単位1.TabIndex = 111
        Me.lbl最低血圧単位1.Text = "--"
        '
        'lbl最高血圧2
        '
        Me.lbl最高血圧2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl最高血圧2.AutoSize = True
        Me.lbl最高血圧2.Font = New System.Drawing.Font("メイリオ", 40.0!)
        Me.lbl最高血圧2.Location = New System.Drawing.Point(19, 279)
        Me.lbl最高血圧2.Name = "lbl最高血圧2"
        Me.lbl最高血圧2.Size = New System.Drawing.Size(83, 81)
        Me.lbl最高血圧2.TabIndex = 112
        Me.lbl最高血圧2.Text = "--"
        Me.lbl最高血圧2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl最低血圧2
        '
        Me.lbl最低血圧2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl最低血圧2.AutoSize = True
        Me.lbl最低血圧2.Font = New System.Drawing.Font("メイリオ", 40.0!)
        Me.lbl最低血圧2.Location = New System.Drawing.Point(19, 381)
        Me.lbl最低血圧2.Name = "lbl最低血圧2"
        Me.lbl最低血圧2.Size = New System.Drawing.Size(83, 81)
        Me.lbl最低血圧2.TabIndex = 114
        Me.lbl最低血圧2.Text = "--"
        '
        'lbl最高血圧単位2
        '
        Me.lbl最高血圧単位2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl最高血圧単位2.AutoSize = True
        Me.lbl最高血圧単位2.Font = New System.Drawing.Font("メイリオ", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl最高血圧単位2.Location = New System.Drawing.Point(661, 328)
        Me.lbl最高血圧単位2.Name = "lbl最高血圧単位2"
        Me.lbl最高血圧単位2.Size = New System.Drawing.Size(46, 44)
        Me.lbl最高血圧単位2.TabIndex = 116
        Me.lbl最高血圧単位2.Text = "--"
        '
        'lbl最低血圧単位2
        '
        Me.lbl最低血圧単位2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl最低血圧単位2.AutoSize = True
        Me.lbl最低血圧単位2.Font = New System.Drawing.Font("メイリオ", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl最低血圧単位2.Location = New System.Drawing.Point(661, 424)
        Me.lbl最低血圧単位2.Name = "lbl最低血圧単位2"
        Me.lbl最低血圧単位2.Size = New System.Drawing.Size(46, 44)
        Me.lbl最低血圧単位2.TabIndex = 117
        Me.lbl最低血圧単位2.Text = "--"
        '
        'btnRegist
        '
        Me.btnRegist.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegist.BackColor = System.Drawing.SystemColors.Control
        Me.btnRegist.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnRegist.Location = New System.Drawing.Point(1054, 676)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(192, 85)
        Me.btnRegist.TabIndex = 118
        Me.btnRegist.TabStop = False
        Me.btnRegist.Text = "登録"
        Me.btnRegist.UseVisualStyleBackColor = False
        '
        'btn血圧クリア1
        '
        Me.btn血圧クリア1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn血圧クリア1.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn血圧クリア1.Location = New System.Drawing.Point(782, 220)
        Me.btn血圧クリア1.Name = "btn血圧クリア1"
        Me.btn血圧クリア1.Size = New System.Drawing.Size(114, 34)
        Me.btn血圧クリア1.TabIndex = 120
        Me.btn血圧クリア1.TabStop = False
        Me.btn血圧クリア1.Text = "クリア"
        Me.btn血圧クリア1.UseVisualStyleBackColor = True
        '
        'btn血圧クリア2
        '
        Me.btn血圧クリア2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn血圧クリア2.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn血圧クリア2.Location = New System.Drawing.Point(782, 428)
        Me.btn血圧クリア2.Name = "btn血圧クリア2"
        Me.btn血圧クリア2.Size = New System.Drawing.Size(114, 34)
        Me.btn血圧クリア2.TabIndex = 121
        Me.btn血圧クリア2.TabStop = False
        Me.btn血圧クリア2.Text = "クリア"
        Me.btn血圧クリア2.UseVisualStyleBackColor = True
        '
        'lbl最高血圧1
        '
        Me.lbl最高血圧1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl最高血圧1.AutoSize = True
        Me.lbl最高血圧1.Font = New System.Drawing.Font("メイリオ", 40.0!)
        Me.lbl最高血圧1.Location = New System.Drawing.Point(19, 75)
        Me.lbl最高血圧1.Name = "lbl最高血圧1"
        Me.lbl最高血圧1.Size = New System.Drawing.Size(83, 81)
        Me.lbl最高血圧1.TabIndex = 106
        Me.lbl最高血圧1.Text = "--"
        Me.lbl最高血圧1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl最高血圧値1
        '
        Me.lbl最高血圧値1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl最高血圧値1.BackColor = System.Drawing.Color.White
        Me.lbl最高血圧値1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl最高血圧値1.Enabled = False
        Me.lbl最高血圧値1.Font = New System.Drawing.Font("MS UI Gothic", 54.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl最高血圧値1.Location = New System.Drawing.Point(508, 75)
        Me.lbl最高血圧値1.Name = "lbl最高血圧値1"
        Me.lbl最高血圧値1.Size = New System.Drawing.Size(147, 70)
        Me.lbl最高血圧値1.TabIndex = 123
        Me.lbl最高血圧値1.Text = "000"
        Me.lbl最高血圧値1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl最低血圧値1
        '
        Me.lbl最低血圧値1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl最低血圧値1.BackColor = System.Drawing.Color.White
        Me.lbl最低血圧値1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl最低血圧値1.Enabled = False
        Me.lbl最低血圧値1.Font = New System.Drawing.Font("MS UI Gothic", 54.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl最低血圧値1.Location = New System.Drawing.Point(508, 177)
        Me.lbl最低血圧値1.Name = "lbl最低血圧値1"
        Me.lbl最低血圧値1.Size = New System.Drawing.Size(147, 70)
        Me.lbl最低血圧値1.TabIndex = 124
        Me.lbl最低血圧値1.Text = "000"
        Me.lbl最低血圧値1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl最高血圧値2
        '
        Me.lbl最高血圧値2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl最高血圧値2.BackColor = System.Drawing.Color.White
        Me.lbl最高血圧値2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl最高血圧値2.Enabled = False
        Me.lbl最高血圧値2.Font = New System.Drawing.Font("MS UI Gothic", 54.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl最高血圧値2.Location = New System.Drawing.Point(508, 279)
        Me.lbl最高血圧値2.Name = "lbl最高血圧値2"
        Me.lbl最高血圧値2.Size = New System.Drawing.Size(147, 70)
        Me.lbl最高血圧値2.TabIndex = 125
        Me.lbl最高血圧値2.Text = "000"
        Me.lbl最高血圧値2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl最低血圧値2
        '
        Me.lbl最低血圧値2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl最低血圧値2.BackColor = System.Drawing.Color.White
        Me.lbl最低血圧値2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl最低血圧値2.Enabled = False
        Me.lbl最低血圧値2.Font = New System.Drawing.Font("MS UI Gothic", 54.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl最低血圧値2.Location = New System.Drawing.Point(508, 381)
        Me.lbl最低血圧値2.Name = "lbl最低血圧値2"
        Me.lbl最低血圧値2.Size = New System.Drawing.Size(147, 70)
        Me.lbl最低血圧値2.TabIndex = 126
        Me.lbl最低血圧値2.Text = "000"
        Me.lbl最低血圧値2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.txt最低血圧値2)
        Me.Panel1.Controls.Add(Me.txt最高血圧値2)
        Me.Panel1.Controls.Add(Me.txt最低血圧値1)
        Me.Panel1.Controls.Add(Me.txt最高血圧値1)
        Me.Panel1.Controls.Add(Me.lbl最高血圧1)
        Me.Panel1.Controls.Add(Me.lbl最低血圧1)
        Me.Panel1.Controls.Add(Me.lbl最高血圧単位1)
        Me.Panel1.Controls.Add(Me.lbl最低血圧値2)
        Me.Panel1.Controls.Add(Me.lbl最低血圧単位1)
        Me.Panel1.Controls.Add(Me.lbl最高血圧値2)
        Me.Panel1.Controls.Add(Me.lbl最高血圧2)
        Me.Panel1.Controls.Add(Me.lbl最低血圧値1)
        Me.Panel1.Controls.Add(Me.lbl最低血圧2)
        Me.Panel1.Controls.Add(Me.lbl最高血圧値1)
        Me.Panel1.Controls.Add(Me.lbl最高血圧単位2)
        Me.Panel1.Controls.Add(Me.lbl最低血圧単位2)
        Me.Panel1.Controls.Add(Me.btn血圧クリア2)
        Me.Panel1.Controls.Add(Me.btn血圧クリア1)
        Me.Panel1.Location = New System.Drawing.Point(35, 128)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1192, 552)
        Me.Panel1.TabIndex = 127
        '
        'txt最低血圧値2
        '
        Me.txt最低血圧値2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt最低血圧値2.Location = New System.Drawing.Point(593, 375)
        Me.txt最低血圧値2.Name = "txt最低血圧値2"
        Me.txt最低血圧値2.NextFocus = Me.txt最低血圧値2
        Me.txt最低血圧値2.PrevFocus = Nothing
        Me.txt最低血圧値2.Size = New System.Drawing.Size(100, 19)
        Me.txt最低血圧値2.TabIndex = 130
        Me.txt最低血圧値2.TabStop = False
        '
        'txt最高血圧値2
        '
        Me.txt最高血圧値2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt最高血圧値2.Location = New System.Drawing.Point(593, 273)
        Me.txt最高血圧値2.Name = "txt最高血圧値2"
        Me.txt最高血圧値2.NextFocus = Nothing
        Me.txt最高血圧値2.PrevFocus = Nothing
        Me.txt最高血圧値2.Size = New System.Drawing.Size(100, 19)
        Me.txt最高血圧値2.TabIndex = 129
        Me.txt最高血圧値2.TabStop = False
        '
        'txt最低血圧値1
        '
        Me.txt最低血圧値1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt最低血圧値1.Location = New System.Drawing.Point(593, 168)
        Me.txt最低血圧値1.Name = "txt最低血圧値1"
        Me.txt最低血圧値1.NextFocus = Nothing
        Me.txt最低血圧値1.PrevFocus = Nothing
        Me.txt最低血圧値1.Size = New System.Drawing.Size(100, 19)
        Me.txt最低血圧値1.TabIndex = 128
        Me.txt最低血圧値1.TabStop = False
        '
        'txt最高血圧値1
        '
        Me.txt最高血圧値1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt最高血圧値1.Location = New System.Drawing.Point(593, 63)
        Me.txt最高血圧値1.Name = "txt最高血圧値1"
        Me.txt最高血圧値1.NextFocus = Nothing
        Me.txt最高血圧値1.PrevFocus = Nothing
        Me.txt最高血圧値1.Size = New System.Drawing.Size(100, 19)
        Me.txt最高血圧値1.TabIndex = 127
        Me.txt最高血圧値1.TabStop = False
        '
        '血圧
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 780)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRegist)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "血圧"
        Me.Controls.SetChildIndex(Me.btnRegist, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl最低血圧1 As System.Windows.Forms.Label
    Friend WithEvents lbl最高血圧単位1 As System.Windows.Forms.Label
    Friend WithEvents lbl最低血圧単位1 As System.Windows.Forms.Label
    Friend WithEvents lbl最高血圧2 As System.Windows.Forms.Label
    Friend WithEvents lbl最低血圧2 As System.Windows.Forms.Label
    Friend WithEvents lbl最高血圧単位2 As System.Windows.Forms.Label
    Friend WithEvents lbl最低血圧単位2 As System.Windows.Forms.Label
    Friend WithEvents btnRegist As System.Windows.Forms.Button
    Friend WithEvents btn血圧クリア1 As System.Windows.Forms.Button
    Friend WithEvents btn血圧クリア2 As System.Windows.Forms.Button
    Friend WithEvents lbl最高血圧1 As System.Windows.Forms.Label
    Friend WithEvents lbl最高血圧値1 As System.Windows.Forms.Label
    Friend WithEvents lbl最低血圧値1 As System.Windows.Forms.Label
    Friend WithEvents lbl最高血圧値2 As System.Windows.Forms.Label
    Friend WithEvents lbl最低血圧値2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt最高血圧値1 As Mi_KENSHINCommon.Mi_TextBox
    Friend WithEvents txt最低血圧値1 As Mi_KENSHINCommon.Mi_TextBox
    Friend WithEvents txt最低血圧値2 As Mi_KENSHINCommon.Mi_TextBox
    Friend WithEvents txt最高血圧値2 As Mi_KENSHINCommon.Mi_TextBox

End Class
