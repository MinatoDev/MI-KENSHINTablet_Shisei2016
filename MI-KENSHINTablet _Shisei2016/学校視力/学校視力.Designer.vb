﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 学校視力
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
        Me.lbl矯正左値 = New System.Windows.Forms.Label()
        Me.lbl矯正右値 = New System.Windows.Forms.Label()
        Me.lbl裸眼左値 = New System.Windows.Forms.Label()
        Me.lbl裸眼右値 = New System.Windows.Forms.Label()
        Me.lbl矯正左 = New System.Windows.Forms.Label()
        Me.lbl矯正右 = New System.Windows.Forms.Label()
        Me.lbl裸眼左 = New System.Windows.Forms.Label()
        Me.lbl裸眼右 = New System.Windows.Forms.Label()
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl矯正左値
        '
        Me.lbl矯正左値.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl矯正左値.BackColor = System.Drawing.Color.White
        Me.lbl矯正左値.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl矯正左値.Enabled = False
        Me.lbl矯正左値.Font = New System.Drawing.Font("MS UI Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl矯正左値.Location = New System.Drawing.Point(1122, 205)
        Me.lbl矯正左値.Name = "lbl矯正左値"
        Me.lbl矯正左値.Size = New System.Drawing.Size(90, 99)
        Me.lbl矯正左値.TabIndex = 1048
        Me.lbl矯正左値.Text = "A"
        Me.lbl矯正左値.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl矯正右値
        '
        Me.lbl矯正右値.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl矯正右値.BackColor = System.Drawing.Color.White
        Me.lbl矯正右値.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl矯正右値.Enabled = False
        Me.lbl矯正右値.Font = New System.Drawing.Font("MS UI Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl矯正右値.Location = New System.Drawing.Point(498, 205)
        Me.lbl矯正右値.Name = "lbl矯正右値"
        Me.lbl矯正右値.Size = New System.Drawing.Size(90, 99)
        Me.lbl矯正右値.TabIndex = 1047
        Me.lbl矯正右値.Text = "A"
        Me.lbl矯正右値.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl裸眼左値
        '
        Me.lbl裸眼左値.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl裸眼左値.BackColor = System.Drawing.Color.White
        Me.lbl裸眼左値.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl裸眼左値.Enabled = False
        Me.lbl裸眼左値.Font = New System.Drawing.Font("MS UI Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl裸眼左値.Location = New System.Drawing.Point(1122, 46)
        Me.lbl裸眼左値.Name = "lbl裸眼左値"
        Me.lbl裸眼左値.Size = New System.Drawing.Size(90, 99)
        Me.lbl裸眼左値.TabIndex = 1046
        Me.lbl裸眼左値.Text = "A"
        Me.lbl裸眼左値.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl裸眼右値
        '
        Me.lbl裸眼右値.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl裸眼右値.BackColor = System.Drawing.Color.White
        Me.lbl裸眼右値.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl裸眼右値.Enabled = False
        Me.lbl裸眼右値.Font = New System.Drawing.Font("MS UI Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl裸眼右値.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl裸眼右値.Location = New System.Drawing.Point(498, 53)
        Me.lbl裸眼右値.Name = "lbl裸眼右値"
        Me.lbl裸眼右値.Size = New System.Drawing.Size(90, 99)
        Me.lbl裸眼右値.TabIndex = 1045
        Me.lbl裸眼右値.Text = "A"
        Me.lbl裸眼右値.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl矯正左
        '
        Me.lbl矯正左.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl矯正左.Enabled = False
        Me.lbl矯正左.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl矯正左.Location = New System.Drawing.Point(640, 230)
        Me.lbl矯正左.Name = "lbl矯正左"
        Me.lbl矯正左.Size = New System.Drawing.Size(472, 72)
        Me.lbl矯正左.TabIndex = 1044
        Me.lbl矯正左.Text = "--"
        '
        'lbl矯正右
        '
        Me.lbl矯正右.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl矯正右.Enabled = False
        Me.lbl矯正右.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl矯正右.Location = New System.Drawing.Point(3, 230)
        Me.lbl矯正右.Name = "lbl矯正右"
        Me.lbl矯正右.Size = New System.Drawing.Size(472, 72)
        Me.lbl矯正右.TabIndex = 1043
        Me.lbl矯正右.Text = "--"
        '
        'lbl裸眼左
        '
        Me.lbl裸眼左.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl裸眼左.Enabled = False
        Me.lbl裸眼左.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl裸眼左.Location = New System.Drawing.Point(627, 72)
        Me.lbl裸眼左.Name = "lbl裸眼左"
        Me.lbl裸眼左.Size = New System.Drawing.Size(472, 72)
        Me.lbl裸眼左.TabIndex = 1042
        Me.lbl裸眼左.Text = "--"
        '
        'lbl裸眼右
        '
        Me.lbl裸眼右.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl裸眼右.Enabled = False
        Me.lbl裸眼右.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl裸眼右.Location = New System.Drawing.Point(3, 73)
        Me.lbl裸眼右.Name = "lbl裸眼右"
        Me.lbl裸眼右.Size = New System.Drawing.Size(472, 72)
        Me.lbl裸眼右.TabIndex = 1041
        Me.lbl裸眼右.Text = "--"
        '
        'btnRegist
        '
        Me.btnRegist.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegist.BackColor = System.Drawing.SystemColors.Control
        Me.btnRegist.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnRegist.Location = New System.Drawing.Point(1010, 671)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(192, 85)
        Me.btnRegist.TabIndex = 1049
        Me.btnRegist.Text = "登  録"
        Me.btnRegist.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.lbl裸眼右)
        Me.Panel1.Controls.Add(Me.lbl裸眼左)
        Me.Panel1.Controls.Add(Me.lbl矯正左値)
        Me.Panel1.Controls.Add(Me.lbl矯正右)
        Me.Panel1.Controls.Add(Me.lbl矯正右値)
        Me.Panel1.Controls.Add(Me.lbl矯正左)
        Me.Panel1.Controls.Add(Me.lbl裸眼右値)
        Me.Panel1.Controls.Add(Me.lbl裸眼左値)
        Me.Panel1.Location = New System.Drawing.Point(22, 145)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1228, 383)
        Me.Panel1.TabIndex = 1050
        '
        '学校視力
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 780)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRegist)
        Me.Name = "学校視力"
        Me.Text = "Form1"
        Me.Controls.SetChildIndex(Me.btnRegist, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl矯正左値 As System.Windows.Forms.Label
    Friend WithEvents lbl矯正右値 As System.Windows.Forms.Label
    Friend WithEvents lbl裸眼左値 As System.Windows.Forms.Label
    Friend WithEvents lbl裸眼右値 As System.Windows.Forms.Label
    Friend WithEvents lbl矯正左 As System.Windows.Forms.Label
    Friend WithEvents lbl矯正右 As System.Windows.Forms.Label
    Friend WithEvents lbl裸眼左 As System.Windows.Forms.Label
    Friend WithEvents lbl裸眼右 As System.Windows.Forms.Label
    Friend WithEvents btnRegist As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
