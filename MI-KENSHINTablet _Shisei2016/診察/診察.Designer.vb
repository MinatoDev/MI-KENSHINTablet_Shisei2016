﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 診察
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
        Me.lbl所見値 = New System.Windows.Forms.Label()
        Me.lbl診察 = New System.Windows.Forms.Label()
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl所見値
        '
        Me.lbl所見値.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl所見値.BackColor = System.Drawing.Color.White
        Me.lbl所見値.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl所見値.Enabled = False
        Me.lbl所見値.Font = New System.Drawing.Font("MS UI Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl所見値.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl所見値.Location = New System.Drawing.Point(520, 14)
        Me.lbl所見値.Name = "lbl所見値"
        Me.lbl所見値.Size = New System.Drawing.Size(454, 99)
        Me.lbl所見値.TabIndex = 1039
        Me.lbl所見値.Text = "所見なし"
        Me.lbl所見値.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl診察
        '
        Me.lbl診察.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl診察.Enabled = False
        Me.lbl診察.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl診察.Location = New System.Drawing.Point(41, 28)
        Me.lbl診察.Name = "lbl診察"
        Me.lbl診察.Size = New System.Drawing.Size(457, 72)
        Me.lbl診察.TabIndex = 1038
        Me.lbl診察.Text = "--"
        '
        'btnRegist
        '
        Me.btnRegist.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegist.BackColor = System.Drawing.SystemColors.Control
        Me.btnRegist.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnRegist.Location = New System.Drawing.Point(1010, 662)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(192, 85)
        Me.btnRegist.TabIndex = 1042
        Me.btnRegist.Text = "登  録"
        Me.btnRegist.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.lbl診察)
        Me.Panel1.Controls.Add(Me.lbl所見値)
        Me.Panel1.Location = New System.Drawing.Point(34, 211)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1101, 154)
        Me.Panel1.TabIndex = 1043
        '
        '診察
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 800)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRegist)
        Me.Name = "診察"
        Me.Controls.SetChildIndex(Me.btnRegist, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl所見値 As System.Windows.Forms.Label
    Friend WithEvents lbl診察 As System.Windows.Forms.Label
    Friend WithEvents btnRegist As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
