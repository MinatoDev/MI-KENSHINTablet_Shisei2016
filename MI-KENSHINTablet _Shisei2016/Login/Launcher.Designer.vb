﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Launcher
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pic身長 = New System.Windows.Forms.PictureBox()
        Me.pic握力 = New System.Windows.Forms.PictureBox()
        Me.picKennyou = New System.Windows.Forms.PictureBox()
        Me.picKetsuatu = New System.Windows.Forms.PictureBox()
        Me.picFukui = New System.Windows.Forms.PictureBox()
        Me.picChyouryoku = New System.Windows.Forms.PictureBox()
        Me.picShinsatsu = New System.Windows.Forms.PictureBox()
        Me.picGakkou = New System.Windows.Forms.PictureBox()
        Me.picShiryoku = New System.Windows.Forms.PictureBox()
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.pic身長, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic握力, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKennyou, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKetsuatu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFukui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChyouryoku, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShinsatsu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGakkou, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShiryoku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.pic身長)
        Me.Panel1.Controls.Add(Me.pic握力)
        Me.Panel1.Controls.Add(Me.picKennyou)
        Me.Panel1.Controls.Add(Me.picKetsuatu)
        Me.Panel1.Controls.Add(Me.picFukui)
        Me.Panel1.Controls.Add(Me.picChyouryoku)
        Me.Panel1.Controls.Add(Me.picShinsatsu)
        Me.Panel1.Controls.Add(Me.picGakkou)
        Me.Panel1.Controls.Add(Me.picShiryoku)
        Me.Panel1.Location = New System.Drawing.Point(56, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1136, 529)
        Me.Panel1.TabIndex = 9
        '
        'pic身長
        '
        Me.pic身長.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic身長.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic身長.Image = Global.Login.My.Resources.Resources.身長
        Me.pic身長.Location = New System.Drawing.Point(946, 67)
        Me.pic身長.Name = "pic身長"
        Me.pic身長.Size = New System.Drawing.Size(164, 175)
        Me.pic身長.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic身長.TabIndex = 9
        Me.pic身長.TabStop = False
        '
        'pic握力
        '
        Me.pic握力.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic握力.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic握力.Image = Global.Login.My.Resources.Resources.握力
        Me.pic握力.Location = New System.Drawing.Point(720, 280)
        Me.pic握力.Name = "pic握力"
        Me.pic握力.Size = New System.Drawing.Size(174, 175)
        Me.pic握力.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic握力.TabIndex = 8
        Me.pic握力.TabStop = False
        '
        'picKennyou
        '
        Me.picKennyou.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picKennyou.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picKennyou.Image = Global.Login.My.Resources.Resources.検尿
        Me.picKennyou.Location = New System.Drawing.Point(26, 67)
        Me.picKennyou.Name = "picKennyou"
        Me.picKennyou.Size = New System.Drawing.Size(174, 175)
        Me.picKennyou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKennyou.TabIndex = 1
        Me.picKennyou.TabStop = False
        '
        'picKetsuatu
        '
        Me.picKetsuatu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picKetsuatu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picKetsuatu.Image = Global.Login.My.Resources.Resources.血圧
        Me.picKetsuatu.Location = New System.Drawing.Point(258, 67)
        Me.picKetsuatu.Name = "picKetsuatu"
        Me.picKetsuatu.Size = New System.Drawing.Size(174, 175)
        Me.picKetsuatu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKetsuatu.TabIndex = 0
        Me.picKetsuatu.TabStop = False
        '
        'picFukui
        '
        Me.picFukui.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picFukui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFukui.Image = Global.Login.My.Resources.Resources.腹囲
        Me.picFukui.Location = New System.Drawing.Point(720, 67)
        Me.picFukui.Name = "picFukui"
        Me.picFukui.Size = New System.Drawing.Size(174, 175)
        Me.picFukui.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFukui.TabIndex = 7
        Me.picFukui.TabStop = False
        '
        'picChyouryoku
        '
        Me.picChyouryoku.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picChyouryoku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picChyouryoku.Image = Global.Login.My.Resources.Resources.聴力
        Me.picChyouryoku.Location = New System.Drawing.Point(26, 280)
        Me.picChyouryoku.Name = "picChyouryoku"
        Me.picChyouryoku.Size = New System.Drawing.Size(174, 175)
        Me.picChyouryoku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChyouryoku.TabIndex = 2
        Me.picChyouryoku.TabStop = False
        '
        'picShinsatsu
        '
        Me.picShinsatsu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picShinsatsu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picShinsatsu.Image = Global.Login.My.Resources.Resources.診察
        Me.picShinsatsu.Location = New System.Drawing.Point(258, 280)
        Me.picShinsatsu.Name = "picShinsatsu"
        Me.picShinsatsu.Size = New System.Drawing.Size(174, 175)
        Me.picShinsatsu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShinsatsu.TabIndex = 3
        Me.picShinsatsu.TabStop = False
        '
        'picGakkou
        '
        Me.picGakkou.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picGakkou.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picGakkou.Image = Global.Login.My.Resources.Resources.学校視力
        Me.picGakkou.Location = New System.Drawing.Point(490, 280)
        Me.picGakkou.Name = "picGakkou"
        Me.picGakkou.Size = New System.Drawing.Size(174, 175)
        Me.picGakkou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGakkou.TabIndex = 5
        Me.picGakkou.TabStop = False
        '
        'picShiryoku
        '
        Me.picShiryoku.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picShiryoku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picShiryoku.Image = Global.Login.My.Resources.Resources.視力
        Me.picShiryoku.Location = New System.Drawing.Point(490, 67)
        Me.picShiryoku.Name = "picShiryoku"
        Me.picShiryoku.Size = New System.Drawing.Size(174, 175)
        Me.picShiryoku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShiryoku.TabIndex = 4
        Me.picShiryoku.TabStop = False
        '
        'btnConfig
        '
        Me.btnConfig.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfig.Image = Global.Login.My.Resources.Resources._const
        Me.btnConfig.Location = New System.Drawing.Point(56, 721)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(110, 58)
        Me.btnConfig.TabIndex = 8
        Me.btnConfig.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Font = New System.Drawing.Font("MS UI Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnCancel.Image = Global.Login.My.Resources.Resources._exit
        Me.btnCancel.Location = New System.Drawing.Point(1060, 714)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(187, 65)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.TabStop = False
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 800)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnConfig)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Launcher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Launcher"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pic身長, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic握力, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKennyou, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKetsuatu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFukui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChyouryoku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShinsatsu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGakkou, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShiryoku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picKetsuatu As System.Windows.Forms.PictureBox
    Friend WithEvents picKennyou As System.Windows.Forms.PictureBox
    Friend WithEvents picChyouryoku As System.Windows.Forms.PictureBox
    Friend WithEvents picShinsatsu As System.Windows.Forms.PictureBox
    Friend WithEvents picShiryoku As System.Windows.Forms.PictureBox
    Friend WithEvents picGakkou As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents picFukui As System.Windows.Forms.PictureBox
    Friend WithEvents btnConfig As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pic握力 As System.Windows.Forms.PictureBox
    Friend WithEvents pic身長 As System.Windows.Forms.PictureBox
End Class
