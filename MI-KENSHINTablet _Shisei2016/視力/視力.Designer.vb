﻿Imports Mi_KENSHINCommon

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 視力
    Inherits KenshinTabletBase

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
        Me.lbl矯正左 = New System.Windows.Forms.Label()
        Me.lbl矯正右 = New System.Windows.Forms.Label()
        Me.lbl裸眼左 = New System.Windows.Forms.Label()
        Me.lbl裸眼右 = New System.Windows.Forms.Label()
        Me.lbl裸眼右値 = New System.Windows.Forms.Label()
        Me.lbl裸眼左値 = New System.Windows.Forms.Label()
        Me.lbl矯正右値 = New System.Windows.Forms.Label()
        Me.lbl矯正左値 = New System.Windows.Forms.Label()
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl矯正左
        '
        Me.lbl矯正左.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl矯正左.Enabled = False
        Me.lbl矯正左.Font = New System.Drawing.Font("メイリオ", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl矯正左.Location = New System.Drawing.Point(605, 241)
        Me.lbl矯正左.Name = "lbl矯正左"
        Me.lbl矯正左.Size = New System.Drawing.Size(366, 67)
        Me.lbl矯正左.TabIndex = 1034
        Me.lbl矯正左.Text = "--"
        '
        'lbl矯正右
        '
        Me.lbl矯正右.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl矯正右.Enabled = False
        Me.lbl矯正右.Font = New System.Drawing.Font("メイリオ", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl矯正右.Location = New System.Drawing.Point(20, 241)
        Me.lbl矯正右.Name = "lbl矯正右"
        Me.lbl矯正右.Size = New System.Drawing.Size(366, 67)
        Me.lbl矯正右.TabIndex = 1033
        Me.lbl矯正右.Text = "--"
        '
        'lbl裸眼左
        '
        Me.lbl裸眼左.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl裸眼左.Enabled = False
        Me.lbl裸眼左.Font = New System.Drawing.Font("メイリオ", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl裸眼左.Location = New System.Drawing.Point(609, 90)
        Me.lbl裸眼左.Name = "lbl裸眼左"
        Me.lbl裸眼左.Size = New System.Drawing.Size(366, 67)
        Me.lbl裸眼左.TabIndex = 1030
        Me.lbl裸眼左.Text = "--"
        '
        'lbl裸眼右
        '
        Me.lbl裸眼右.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl裸眼右.Enabled = False
        Me.lbl裸眼右.Font = New System.Drawing.Font("メイリオ", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl裸眼右.Location = New System.Drawing.Point(20, 84)
        Me.lbl裸眼右.Name = "lbl裸眼右"
        Me.lbl裸眼右.Size = New System.Drawing.Size(366, 67)
        Me.lbl裸眼右.TabIndex = 1029
        Me.lbl裸眼右.Text = "--"
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
        Me.lbl裸眼右値.Location = New System.Drawing.Point(392, 64)
        Me.lbl裸眼右値.Name = "lbl裸眼右値"
        Me.lbl裸眼右値.Size = New System.Drawing.Size(160, 94)
        Me.lbl裸眼右値.TabIndex = 1037
        Me.lbl裸眼右値.Text = "0.0"
        Me.lbl裸眼右値.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.lbl裸眼左値.Location = New System.Drawing.Point(981, 64)
        Me.lbl裸眼左値.Name = "lbl裸眼左値"
        Me.lbl裸眼左値.Size = New System.Drawing.Size(160, 94)
        Me.lbl裸眼左値.TabIndex = 1038
        Me.lbl裸眼左値.Text = "0.0"
        Me.lbl裸眼左値.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.lbl矯正右値.Location = New System.Drawing.Point(392, 214)
        Me.lbl矯正右値.Name = "lbl矯正右値"
        Me.lbl矯正右値.Size = New System.Drawing.Size(160, 94)
        Me.lbl矯正右値.TabIndex = 1039
        Me.lbl矯正右値.Text = "0.0"
        Me.lbl矯正右値.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.lbl矯正左値.Location = New System.Drawing.Point(981, 216)
        Me.lbl矯正左値.Name = "lbl矯正左値"
        Me.lbl矯正左値.Size = New System.Drawing.Size(160, 94)
        Me.lbl矯正左値.TabIndex = 1040
        Me.lbl矯正左値.Text = "0.0"
        Me.lbl矯正左値.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRegist
        '
        Me.btnRegist.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegist.BackColor = System.Drawing.SystemColors.Control
        Me.btnRegist.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnRegist.Location = New System.Drawing.Point(1049, 643)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(192, 85)
        Me.btnRegist.TabIndex = 1041
        Me.btnRegist.Text = "登  録"
        Me.btnRegist.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.lbl裸眼右)
        Me.Panel1.Controls.Add(Me.lbl裸眼左)
        Me.Panel1.Controls.Add(Me.lbl矯正左値)
        Me.Panel1.Controls.Add(Me.lbl矯正右)
        Me.Panel1.Controls.Add(Me.lbl矯正左)
        Me.Panel1.Controls.Add(Me.lbl矯正右値)
        Me.Panel1.Controls.Add(Me.lbl裸眼左値)
        Me.Panel1.Controls.Add(Me.lbl裸眼右値)
        Me.Panel1.Location = New System.Drawing.Point(22, 187)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1219, 416)
        Me.Panel1.TabIndex = 1042
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Font = New System.Drawing.Font("MS UI Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnClear.Location = New System.Drawing.Point(981, 345)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(160, 53)
        Me.btnClear.TabIndex = 1041
        Me.btnClear.Text = "クリア"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        '視力
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1278, 778)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRegist)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "視力"
        Me.Controls.SetChildIndex(Me.btnRegist, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl矯正左 As System.Windows.Forms.Label
    Friend WithEvents lbl矯正右 As System.Windows.Forms.Label
    Friend WithEvents lbl裸眼左 As System.Windows.Forms.Label
    Friend WithEvents lbl裸眼右 As System.Windows.Forms.Label
    Friend WithEvents lbl裸眼右値 As System.Windows.Forms.Label
    Friend WithEvents lbl裸眼左値 As System.Windows.Forms.Label
    Friend WithEvents lbl矯正右値 As System.Windows.Forms.Label
    Friend WithEvents lbl矯正左値 As System.Windows.Forms.Label
    Friend WithEvents btnRegist As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
