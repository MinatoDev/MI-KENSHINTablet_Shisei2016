﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 計測
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
        Me.btn身長計測 = New System.Windows.Forms.Button()
        Me.btnポート設定 = New System.Windows.Forms.Button()
        Me.sp = New System.IO.Ports.SerialPort(Me.components)
        Me.tb = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chkGo聴力 = New System.Windows.Forms.CheckBox()
        Me.txt連番 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.lblgen = New System.Windows.Forms.Label()
        Me.chk衣服分 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkすべて身長 = New System.Windows.Forms.CheckBox()
        Me.txt腹囲 = New System.Windows.Forms.TextBox()
        Me.chk腹囲 = New System.Windows.Forms.CheckBox()
        Me.btn登録 = New System.Windows.Forms.Button()
        Me.lbl腹囲単位 = New System.Windows.Forms.Label()
        Me.lbl体重単位 = New System.Windows.Forms.Label()
        Me.lbl身長単位 = New System.Windows.Forms.Label()
        Me.txt腹囲少数 = New System.Windows.Forms.TextBox()
        Me.txt体重少数 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt身長少数 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt体重 = New System.Windows.Forms.TextBox()
        Me.txt身長 = New System.Windows.Forms.TextBox()
        Me.lbl腹囲 = New System.Windows.Forms.Label()
        Me.lbl体重 = New System.Windows.Forms.Label()
        Me.lbl名前 = New System.Windows.Forms.Label()
        Me.lbl身長 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txt通番血圧 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNo血圧 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl最高血圧1 = New System.Windows.Forms.Label()
        Me.chk血圧すべて = New System.Windows.Forms.CheckBox()
        Me.btn確定 = New System.Windows.Forms.Button()
        Me.btn血圧クリア2 = New System.Windows.Forms.Button()
        Me.btn血圧クリア1 = New System.Windows.Forms.Button()
        Me.btn血圧計測 = New System.Windows.Forms.Button()
        Me.btn登録2 = New System.Windows.Forms.Button()
        Me.lbl最低血圧単位2 = New System.Windows.Forms.Label()
        Me.lbl最高血圧単位2 = New System.Windows.Forms.Label()
        Me.txt最低血圧2 = New System.Windows.Forms.TextBox()
        Me.txt最高血圧2 = New System.Windows.Forms.TextBox()
        Me.lbl最低血圧2 = New System.Windows.Forms.Label()
        Me.lbl最高血圧2 = New System.Windows.Forms.Label()
        Me.lbl最低血圧単位1 = New System.Windows.Forms.Label()
        Me.lbl最高血圧単位1 = New System.Windows.Forms.Label()
        Me.txt最低血圧1 = New System.Windows.Forms.TextBox()
        Me.txt最高血圧1 = New System.Windows.Forms.TextBox()
        Me.lbl最低血圧1 = New System.Windows.Forms.Label()
        Me.lbl名前2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.chk登録ボタンへ移動する = New System.Windows.Forms.CheckBox()
        Me.btn聴力登録 = New System.Windows.Forms.Button()
        Me.cmb左4000 = New System.Windows.Forms.ComboBox()
        Me.lbl左4000 = New System.Windows.Forms.Label()
        Me.cmb左1000 = New System.Windows.Forms.ComboBox()
        Me.lbl左1000 = New System.Windows.Forms.Label()
        Me.cmb右4000 = New System.Windows.Forms.ComboBox()
        Me.lbl右4000 = New System.Windows.Forms.Label()
        Me.cmb右1000 = New System.Windows.Forms.ComboBox()
        Me.lbl右1000 = New System.Windows.Forms.Label()
        Me.txt通番聴力 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNo聴力 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkすべて聴力 = New System.Windows.Forms.CheckBox()
        Me.lbl名前聴力 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btn握力登録 = New System.Windows.Forms.Button()
        Me.lbl握力左単位 = New System.Windows.Forms.Label()
        Me.lbl握力右単位 = New System.Windows.Forms.Label()
        Me.txt握力左少数 = New System.Windows.Forms.TextBox()
        Me.lbl握力左小数点 = New System.Windows.Forms.Label()
        Me.txt握力右少数 = New System.Windows.Forms.TextBox()
        Me.lbl握力右小数点 = New System.Windows.Forms.Label()
        Me.txt握力左整数 = New System.Windows.Forms.TextBox()
        Me.txt握力右整数 = New System.Windows.Forms.TextBox()
        Me.lbl握力左 = New System.Windows.Forms.Label()
        Me.lbl握力右 = New System.Windows.Forms.Label()
        Me.txt通番握力 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNo握力 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl名前握力 = New System.Windows.Forms.Label()
        Me.RcvDataToTextBox = New System.Windows.Forms.TextBox()
        Me.ep = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.btn選択確定 = New System.Windows.Forms.Button()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tb.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn身長計測
        '
        Me.btn身長計測.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn身長計測.Location = New System.Drawing.Point(1115, 173)
        Me.btn身長計測.Name = "btn身長計測"
        Me.btn身長計測.Size = New System.Drawing.Size(187, 85)
        Me.btn身長計測.TabIndex = 99
        Me.btn身長計測.TabStop = False
        Me.btn身長計測.Text = "測定"
        Me.btn身長計測.UseVisualStyleBackColor = True
        '
        'btnポート設定
        '
        Me.btnポート設定.Font = New System.Drawing.Font("MS UI Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnポート設定.Location = New System.Drawing.Point(20, 663)
        Me.btnポート設定.Margin = New System.Windows.Forms.Padding(5)
        Me.btnポート設定.Name = "btnポート設定"
        Me.btnポート設定.Size = New System.Drawing.Size(353, 70)
        Me.btnポート設定.TabIndex = 7
        Me.btnポート設定.TabStop = False
        Me.btnポート設定.Text = "COMポート設定"
        Me.btnポート設定.UseVisualStyleBackColor = True
        '
        'sp
        '
        '
        'tb
        '
        Me.tb.Controls.Add(Me.TabPage1)
        Me.tb.Controls.Add(Me.TabPage2)
        Me.tb.Controls.Add(Me.TabPage3)
        Me.tb.Controls.Add(Me.TabPage4)
        Me.tb.Font = New System.Drawing.Font("メイリオ", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.tb.Location = New System.Drawing.Point(16, 32)
        Me.tb.Name = "tb"
        Me.tb.SelectedIndex = 0
        Me.tb.Size = New System.Drawing.Size(1332, 623)
        Me.tb.TabIndex = 8
        Me.tb.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chkGo聴力)
        Me.TabPage1.Controls.Add(Me.txt連番)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtNo)
        Me.TabPage1.Controls.Add(Me.lblgen)
        Me.TabPage1.Controls.Add(Me.chk衣服分)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.chkすべて身長)
        Me.TabPage1.Controls.Add(Me.txt腹囲)
        Me.TabPage1.Controls.Add(Me.btn身長計測)
        Me.TabPage1.Controls.Add(Me.chk腹囲)
        Me.TabPage1.Controls.Add(Me.btn登録)
        Me.TabPage1.Controls.Add(Me.lbl腹囲単位)
        Me.TabPage1.Controls.Add(Me.lbl体重単位)
        Me.TabPage1.Controls.Add(Me.lbl身長単位)
        Me.TabPage1.Controls.Add(Me.txt腹囲少数)
        Me.TabPage1.Controls.Add(Me.txt体重少数)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt身長少数)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txt体重)
        Me.TabPage1.Controls.Add(Me.txt身長)
        Me.TabPage1.Controls.Add(Me.lbl腹囲)
        Me.TabPage1.Controls.Add(Me.lbl体重)
        Me.TabPage1.Controls.Add(Me.lbl名前)
        Me.TabPage1.Controls.Add(Me.lbl身長)
        Me.TabPage1.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 57)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1324, 562)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "身長・体重"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chkGo聴力
        '
        Me.chkGo聴力.AutoSize = True
        Me.chkGo聴力.Font = New System.Drawing.Font("メイリオ", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chkGo聴力.Location = New System.Drawing.Point(960, 28)
        Me.chkGo聴力.Name = "chkGo聴力"
        Me.chkGo聴力.Size = New System.Drawing.Size(263, 52)
        Me.chkGo聴力.TabIndex = 1006
        Me.chkGo聴力.TabStop = False
        Me.chkGo聴力.Text = "聴力検査に飛ぶ"
        Me.chkGo聴力.UseVisualStyleBackColor = True
        '
        'txt連番
        '
        Me.txt連番.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt連番.Location = New System.Drawing.Point(325, 59)
        Me.txt連番.Name = "txt連番"
        Me.txt連番.ReadOnly = True
        Me.txt連番.Size = New System.Drawing.Size(129, 79)
        Me.txt連番.TabIndex = 1005
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("メイリオ", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 39)
        Me.Label6.TabIndex = 1004
        Me.Label6.Text = "個人番号"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNo
        '
        Me.txtNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNo.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtNo.Location = New System.Drawing.Point(17, 60)
        Me.txtNo.MaxLength = 17
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(291, 79)
        Me.txtNo.TabIndex = 1003
        Me.txtNo.TabStop = False
        '
        'lblgen
        '
        Me.lblgen.AutoSize = True
        Me.lblgen.ForeColor = System.Drawing.Color.Red
        Me.lblgen.Location = New System.Drawing.Point(903, 357)
        Me.lblgen.Name = "lblgen"
        Me.lblgen.Size = New System.Drawing.Size(253, 55)
        Me.lblgen.TabIndex = 110
        Me.lblgen.Text = "-1kgされます"
        Me.lblgen.Visible = False
        '
        'chk衣服分
        '
        Me.chk衣服分.AutoSize = True
        Me.chk衣服分.Font = New System.Drawing.Font("メイリオ", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk衣服分.Location = New System.Drawing.Point(616, 28)
        Me.chk衣服分.Name = "chk衣服分"
        Me.chk衣服分.Size = New System.Drawing.Size(288, 52)
        Me.chk衣服分.TabIndex = 109
        Me.chk衣服分.TabStop = False
        Me.chk衣服分.Text = "衣服分 -１㎏する"
        Me.chk衣服分.UseVisualStyleBackColor = True
        Me.chk衣服分.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(337, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 44)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "通番"
        '
        'chkすべて身長
        '
        Me.chkすべて身長.AutoSize = True
        Me.chkすべて身長.Font = New System.Drawing.Font("メイリオ", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chkすべて身長.Location = New System.Drawing.Point(490, 133)
        Me.chkすべて身長.Name = "chkすべて身長"
        Me.chkすべて身長.Size = New System.Drawing.Size(154, 40)
        Me.chkすべて身長.TabIndex = 107
        Me.chkすべて身長.Text = "すべて表示"
        Me.chkすべて身長.UseVisualStyleBackColor = True
        Me.chkすべて身長.Visible = False
        '
        'txt腹囲
        '
        Me.txt腹囲.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt腹囲.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt腹囲.Location = New System.Drawing.Point(562, 419)
        Me.txt腹囲.MaxLength = 3
        Me.txt腹囲.Name = "txt腹囲"
        Me.txt腹囲.Size = New System.Drawing.Size(131, 103)
        Me.txt腹囲.TabIndex = 6
        '
        'chk腹囲
        '
        Me.chk腹囲.AutoSize = True
        Me.chk腹囲.Font = New System.Drawing.Font("メイリオ", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk腹囲.Location = New System.Drawing.Point(960, 103)
        Me.chk腹囲.Name = "chk腹囲"
        Me.chk腹囲.Size = New System.Drawing.Size(263, 52)
        Me.chk腹囲.TabIndex = 18
        Me.chk腹囲.TabStop = False
        Me.chk腹囲.Text = "腹囲を計測する"
        Me.chk腹囲.UseVisualStyleBackColor = True
        '
        'btn登録
        '
        Me.btn登録.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn登録.Location = New System.Drawing.Point(1115, 458)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(192, 85)
        Me.btn登録.TabIndex = 8
        Me.btn登録.Text = "登録"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'lbl腹囲単位
        '
        Me.lbl腹囲単位.AutoSize = True
        Me.lbl腹囲単位.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl腹囲単位.Location = New System.Drawing.Point(814, 467)
        Me.lbl腹囲単位.Name = "lbl腹囲単位"
        Me.lbl腹囲単位.Size = New System.Drawing.Size(56, 55)
        Me.lbl腹囲単位.TabIndex = 16
        Me.lbl腹囲単位.Text = "--"
        '
        'lbl体重単位
        '
        Me.lbl体重単位.AutoSize = True
        Me.lbl体重単位.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl体重単位.Location = New System.Drawing.Point(814, 357)
        Me.lbl体重単位.Name = "lbl体重単位"
        Me.lbl体重単位.Size = New System.Drawing.Size(56, 55)
        Me.lbl体重単位.TabIndex = 15
        Me.lbl体重単位.Text = "--"
        '
        'lbl身長単位
        '
        Me.lbl身長単位.AutoSize = True
        Me.lbl身長単位.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl身長単位.Location = New System.Drawing.Point(814, 251)
        Me.lbl身長単位.Name = "lbl身長単位"
        Me.lbl身長単位.Size = New System.Drawing.Size(56, 55)
        Me.lbl身長単位.TabIndex = 14
        Me.lbl身長単位.Text = "--"
        '
        'txt腹囲少数
        '
        Me.txt腹囲少数.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt腹囲少数.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt腹囲少数.Location = New System.Drawing.Point(746, 419)
        Me.txt腹囲少数.Name = "txt腹囲少数"
        Me.txt腹囲少数.Size = New System.Drawing.Size(62, 103)
        Me.txt腹囲少数.TabIndex = 7
        '
        'txt体重少数
        '
        Me.txt体重少数.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt体重少数.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt体重少数.Location = New System.Drawing.Point(746, 309)
        Me.txt体重少数.Name = "txt体重少数"
        Me.txt体重少数.Size = New System.Drawing.Size(62, 103)
        Me.txt体重少数.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(693, 427)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 96)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(693, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 96)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "."
        '
        'txt身長少数
        '
        Me.txt身長少数.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt身長少数.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt身長少数.Location = New System.Drawing.Point(746, 199)
        Me.txt身長少数.Name = "txt身長少数"
        Me.txt身長少数.Size = New System.Drawing.Size(62, 103)
        Me.txt身長少数.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(693, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 96)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "."
        '
        'txt体重
        '
        Me.txt体重.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt体重.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt体重.Location = New System.Drawing.Point(562, 309)
        Me.txt体重.MaxLength = 3
        Me.txt体重.Name = "txt体重"
        Me.txt体重.Size = New System.Drawing.Size(131, 103)
        Me.txt体重.TabIndex = 4
        '
        'txt身長
        '
        Me.txt身長.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt身長.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt身長.Location = New System.Drawing.Point(562, 199)
        Me.txt身長.MaxLength = 3
        Me.txt身長.Name = "txt身長"
        Me.txt身長.Size = New System.Drawing.Size(131, 103)
        Me.txt身長.TabIndex = 2
        '
        'lbl腹囲
        '
        Me.lbl腹囲.AutoSize = True
        Me.lbl腹囲.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl腹囲.Location = New System.Drawing.Point(410, 421)
        Me.lbl腹囲.Name = "lbl腹囲"
        Me.lbl腹囲.Size = New System.Drawing.Size(96, 96)
        Me.lbl腹囲.TabIndex = 4
        Me.lbl腹囲.Text = "--"
        '
        'lbl体重
        '
        Me.lbl体重.AutoSize = True
        Me.lbl体重.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl体重.Location = New System.Drawing.Point(410, 308)
        Me.lbl体重.Name = "lbl体重"
        Me.lbl体重.Size = New System.Drawing.Size(96, 96)
        Me.lbl体重.TabIndex = 3
        Me.lbl体重.Text = "--"
        '
        'lbl名前
        '
        Me.lbl名前.AutoSize = True
        Me.lbl名前.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl名前.Location = New System.Drawing.Point(480, 84)
        Me.lbl名前.Name = "lbl名前"
        Me.lbl名前.Size = New System.Drawing.Size(98, 55)
        Me.lbl名前.TabIndex = 2
        Me.lbl名前.Text = "名前"
        '
        'lbl身長
        '
        Me.lbl身長.AutoSize = True
        Me.lbl身長.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl身長.Location = New System.Drawing.Point(410, 199)
        Me.lbl身長.Name = "lbl身長"
        Me.lbl身長.Size = New System.Drawing.Size(96, 96)
        Me.lbl身長.TabIndex = 0
        Me.lbl身長.Text = "--"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txt通番血圧)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtNo血圧)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.lbl最高血圧1)
        Me.TabPage2.Controls.Add(Me.chk血圧すべて)
        Me.TabPage2.Controls.Add(Me.btn確定)
        Me.TabPage2.Controls.Add(Me.btn血圧クリア2)
        Me.TabPage2.Controls.Add(Me.btn血圧クリア1)
        Me.TabPage2.Controls.Add(Me.btn血圧計測)
        Me.TabPage2.Controls.Add(Me.btn登録2)
        Me.TabPage2.Controls.Add(Me.lbl最低血圧単位2)
        Me.TabPage2.Controls.Add(Me.lbl最高血圧単位2)
        Me.TabPage2.Controls.Add(Me.txt最低血圧2)
        Me.TabPage2.Controls.Add(Me.txt最高血圧2)
        Me.TabPage2.Controls.Add(Me.lbl最低血圧2)
        Me.TabPage2.Controls.Add(Me.lbl最高血圧2)
        Me.TabPage2.Controls.Add(Me.lbl最低血圧単位1)
        Me.TabPage2.Controls.Add(Me.lbl最高血圧単位1)
        Me.TabPage2.Controls.Add(Me.txt最低血圧1)
        Me.TabPage2.Controls.Add(Me.txt最高血圧1)
        Me.TabPage2.Controls.Add(Me.lbl最低血圧1)
        Me.TabPage2.Controls.Add(Me.lbl名前2)
        Me.TabPage2.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 57)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1324, 562)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "血圧"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txt通番血圧
        '
        Me.txt通番血圧.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt通番血圧.Location = New System.Drawing.Point(325, 59)
        Me.txt通番血圧.Name = "txt通番血圧"
        Me.txt通番血圧.ReadOnly = True
        Me.txt通番血圧.Size = New System.Drawing.Size(129, 79)
        Me.txt通番血圧.TabIndex = 1007
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("メイリオ", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 39)
        Me.Label7.TabIndex = 1006
        Me.Label7.Text = "個人番号"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNo血圧
        '
        Me.txtNo血圧.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNo血圧.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtNo血圧.Location = New System.Drawing.Point(17, 60)
        Me.txtNo血圧.MaxLength = 17
        Me.txtNo血圧.Name = "txtNo血圧"
        Me.txtNo血圧.Size = New System.Drawing.Size(291, 79)
        Me.txtNo血圧.TabIndex = 1005
        Me.txtNo血圧.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(337, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 44)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "通番"
        '
        'lbl最高血圧1
        '
        Me.lbl最高血圧1.AutoSize = True
        Me.lbl最高血圧1.Font = New System.Drawing.Font("メイリオ", 40.0!)
        Me.lbl最高血圧1.Location = New System.Drawing.Point(185, 140)
        Me.lbl最高血圧1.Name = "lbl最高血圧1"
        Me.lbl最高血圧1.Size = New System.Drawing.Size(83, 81)
        Me.lbl最高血圧1.TabIndex = 17
        Me.lbl最高血圧1.Text = "--"
        Me.lbl最高血圧1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk血圧すべて
        '
        Me.chk血圧すべて.AutoSize = True
        Me.chk血圧すべて.Font = New System.Drawing.Font("メイリオ", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk血圧すべて.Location = New System.Drawing.Point(1032, 31)
        Me.chk血圧すべて.Name = "chk血圧すべて"
        Me.chk血圧すべて.Size = New System.Drawing.Size(154, 40)
        Me.chk血圧すべて.TabIndex = 106
        Me.chk血圧すべて.Text = "すべて表示"
        Me.chk血圧すべて.UseVisualStyleBackColor = True
        Me.chk血圧すべて.Visible = False
        '
        'btn確定
        '
        Me.btn確定.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn確定.Location = New System.Drawing.Point(895, 236)
        Me.btn確定.Name = "btn確定"
        Me.btn確定.Size = New System.Drawing.Size(114, 48)
        Me.btn確定.TabIndex = 105
        Me.btn確定.TabStop = False
        Me.btn確定.Text = "確定"
        Me.btn確定.UseVisualStyleBackColor = True
        Me.btn確定.Visible = False
        '
        'btn血圧クリア2
        '
        Me.btn血圧クリア2.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn血圧クリア2.Location = New System.Drawing.Point(895, 498)
        Me.btn血圧クリア2.Name = "btn血圧クリア2"
        Me.btn血圧クリア2.Size = New System.Drawing.Size(114, 45)
        Me.btn血圧クリア2.TabIndex = 103
        Me.btn血圧クリア2.TabStop = False
        Me.btn血圧クリア2.Text = "クリア"
        Me.btn血圧クリア2.UseVisualStyleBackColor = True
        '
        'btn血圧クリア1
        '
        Me.btn血圧クリア1.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn血圧クリア1.Location = New System.Drawing.Point(895, 290)
        Me.btn血圧クリア1.Name = "btn血圧クリア1"
        Me.btn血圧クリア1.Size = New System.Drawing.Size(114, 45)
        Me.btn血圧クリア1.TabIndex = 102
        Me.btn血圧クリア1.TabStop = False
        Me.btn血圧クリア1.Text = "クリア"
        Me.btn血圧クリア1.UseVisualStyleBackColor = True
        '
        'btn血圧計測
        '
        Me.btn血圧計測.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn血圧計測.Location = New System.Drawing.Point(1115, 173)
        Me.btn血圧計測.Name = "btn血圧計測"
        Me.btn血圧計測.Size = New System.Drawing.Size(187, 85)
        Me.btn血圧計測.TabIndex = 101
        Me.btn血圧計測.TabStop = False
        Me.btn血圧計測.Text = "測定"
        Me.btn血圧計測.UseVisualStyleBackColor = True
        '
        'btn登録2
        '
        Me.btn登録2.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn登録2.Location = New System.Drawing.Point(1115, 458)
        Me.btn登録2.Name = "btn登録2"
        Me.btn登録2.Size = New System.Drawing.Size(192, 85)
        Me.btn登録2.TabIndex = 100
        Me.btn登録2.TabStop = False
        Me.btn登録2.Text = "登録"
        Me.btn登録2.UseVisualStyleBackColor = True
        '
        'lbl最低血圧単位2
        '
        Me.lbl最低血圧単位2.AutoSize = True
        Me.lbl最低血圧単位2.Font = New System.Drawing.Font("メイリオ", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl最低血圧単位2.Location = New System.Drawing.Point(804, 500)
        Me.lbl最低血圧単位2.Name = "lbl最低血圧単位2"
        Me.lbl最低血圧単位2.Size = New System.Drawing.Size(46, 44)
        Me.lbl最低血圧単位2.TabIndex = 36
        Me.lbl最低血圧単位2.Text = "--"
        '
        'lbl最高血圧単位2
        '
        Me.lbl最高血圧単位2.AutoSize = True
        Me.lbl最高血圧単位2.Font = New System.Drawing.Font("メイリオ", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl最高血圧単位2.Location = New System.Drawing.Point(804, 393)
        Me.lbl最高血圧単位2.Name = "lbl最高血圧単位2"
        Me.lbl最高血圧単位2.Size = New System.Drawing.Size(46, 44)
        Me.lbl最高血圧単位2.TabIndex = 35
        Me.lbl最高血圧単位2.Text = "--"
        '
        'txt最低血圧2
        '
        Me.txt最低血圧2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt最低血圧2.Font = New System.Drawing.Font("メイリオ", 40.0!)
        Me.txt最低血圧2.Location = New System.Drawing.Point(676, 440)
        Me.txt最低血圧2.MaxLength = 3
        Me.txt最低血圧2.Name = "txt最低血圧2"
        Me.txt最低血圧2.Size = New System.Drawing.Size(122, 87)
        Me.txt最低血圧2.TabIndex = 34
        '
        'txt最高血圧2
        '
        Me.txt最高血圧2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt最高血圧2.Font = New System.Drawing.Font("メイリオ", 40.0!)
        Me.txt最高血圧2.Location = New System.Drawing.Point(676, 338)
        Me.txt最高血圧2.MaxLength = 3
        Me.txt最高血圧2.Name = "txt最高血圧2"
        Me.txt最高血圧2.Size = New System.Drawing.Size(122, 87)
        Me.txt最高血圧2.TabIndex = 32
        '
        'lbl最低血圧2
        '
        Me.lbl最低血圧2.AutoSize = True
        Me.lbl最低血圧2.Font = New System.Drawing.Font("メイリオ", 40.0!)
        Me.lbl最低血圧2.Location = New System.Drawing.Point(185, 446)
        Me.lbl最低血圧2.Name = "lbl最低血圧2"
        Me.lbl最低血圧2.Size = New System.Drawing.Size(83, 81)
        Me.lbl最低血圧2.TabIndex = 33
        Me.lbl最低血圧2.Text = "--"
        '
        'lbl最高血圧2
        '
        Me.lbl最高血圧2.AutoSize = True
        Me.lbl最高血圧2.Font = New System.Drawing.Font("メイリオ", 40.0!)
        Me.lbl最高血圧2.Location = New System.Drawing.Point(185, 344)
        Me.lbl最高血圧2.Name = "lbl最高血圧2"
        Me.lbl最高血圧2.Size = New System.Drawing.Size(83, 81)
        Me.lbl最高血圧2.TabIndex = 31
        Me.lbl最高血圧2.Text = "--"
        Me.lbl最高血圧2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl最低血圧単位1
        '
        Me.lbl最低血圧単位1.AutoSize = True
        Me.lbl最低血圧単位1.Font = New System.Drawing.Font("メイリオ", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl最低血圧単位1.Location = New System.Drawing.Point(804, 291)
        Me.lbl最低血圧単位1.Name = "lbl最低血圧単位1"
        Me.lbl最低血圧単位1.Size = New System.Drawing.Size(46, 44)
        Me.lbl最低血圧単位1.TabIndex = 30
        Me.lbl最低血圧単位1.Text = "--"
        '
        'lbl最高血圧単位1
        '
        Me.lbl最高血圧単位1.AutoSize = True
        Me.lbl最高血圧単位1.Font = New System.Drawing.Font("メイリオ", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl最高血圧単位1.Location = New System.Drawing.Point(804, 186)
        Me.lbl最高血圧単位1.Name = "lbl最高血圧単位1"
        Me.lbl最高血圧単位1.Size = New System.Drawing.Size(46, 44)
        Me.lbl最高血圧単位1.TabIndex = 29
        Me.lbl最高血圧単位1.Text = "--"
        '
        'txt最低血圧1
        '
        Me.txt最低血圧1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt最低血圧1.Font = New System.Drawing.Font("メイリオ", 40.0!)
        Me.txt最低血圧1.Location = New System.Drawing.Point(676, 236)
        Me.txt最低血圧1.MaxLength = 3
        Me.txt最低血圧1.Name = "txt最低血圧1"
        Me.txt最低血圧1.Size = New System.Drawing.Size(122, 87)
        Me.txt最低血圧1.TabIndex = 21
        '
        'txt最高血圧1
        '
        Me.txt最高血圧1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt最高血圧1.Font = New System.Drawing.Font("メイリオ", 40.0!)
        Me.txt最高血圧1.Location = New System.Drawing.Point(676, 134)
        Me.txt最高血圧1.MaxLength = 3
        Me.txt最高血圧1.Name = "txt最高血圧1"
        Me.txt最高血圧1.Size = New System.Drawing.Size(122, 87)
        Me.txt最高血圧1.TabIndex = 18
        '
        'lbl最低血圧1
        '
        Me.lbl最低血圧1.AutoSize = True
        Me.lbl最低血圧1.Font = New System.Drawing.Font("メイリオ", 40.0!)
        Me.lbl最低血圧1.Location = New System.Drawing.Point(185, 242)
        Me.lbl最低血圧1.Name = "lbl最低血圧1"
        Me.lbl最低血圧1.Size = New System.Drawing.Size(83, 81)
        Me.lbl最低血圧1.TabIndex = 20
        Me.lbl最低血圧1.Text = "--"
        '
        'lbl名前2
        '
        Me.lbl名前2.AutoSize = True
        Me.lbl名前2.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl名前2.Location = New System.Drawing.Point(480, 84)
        Me.lbl名前2.Name = "lbl名前2"
        Me.lbl名前2.Size = New System.Drawing.Size(98, 55)
        Me.lbl名前2.TabIndex = 11
        Me.lbl名前2.Text = "名前"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.chk登録ボタンへ移動する)
        Me.TabPage3.Controls.Add(Me.btn聴力登録)
        Me.TabPage3.Controls.Add(Me.cmb左4000)
        Me.TabPage3.Controls.Add(Me.lbl左4000)
        Me.TabPage3.Controls.Add(Me.cmb左1000)
        Me.TabPage3.Controls.Add(Me.lbl左1000)
        Me.TabPage3.Controls.Add(Me.cmb右4000)
        Me.TabPage3.Controls.Add(Me.lbl右4000)
        Me.TabPage3.Controls.Add(Me.cmb右1000)
        Me.TabPage3.Controls.Add(Me.lbl右1000)
        Me.TabPage3.Controls.Add(Me.txt通番聴力)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.txtNo聴力)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.chkすべて聴力)
        Me.TabPage3.Controls.Add(Me.lbl名前聴力)
        Me.TabPage3.Location = New System.Drawing.Point(4, 57)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1324, 562)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "聴力"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'chk登録ボタンへ移動する
        '
        Me.chk登録ボタンへ移動する.AutoSize = True
        Me.chk登録ボタンへ移動する.Font = New System.Drawing.Font("メイリオ", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk登録ボタンへ移動する.Location = New System.Drawing.Point(885, 31)
        Me.chk登録ボタンへ移動する.Name = "chk登録ボタンへ移動する"
        Me.chk登録ボタンへ移動する.Size = New System.Drawing.Size(359, 52)
        Me.chk登録ボタンへ移動する.TabIndex = 1021
        Me.chk登録ボタンへ移動する.TabStop = False
        Me.chk登録ボタンへ移動する.Text = "登録ボタンへ移動する"
        Me.chk登録ボタンへ移動する.UseVisualStyleBackColor = True
        '
        'btn聴力登録
        '
        Me.btn聴力登録.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn聴力登録.Location = New System.Drawing.Point(1115, 458)
        Me.btn聴力登録.Name = "btn聴力登録"
        Me.btn聴力登録.Size = New System.Drawing.Size(192, 85)
        Me.btn聴力登録.TabIndex = 1020
        Me.btn聴力登録.TabStop = False
        Me.btn聴力登録.Text = "登録"
        Me.btn聴力登録.UseVisualStyleBackColor = True
        '
        'cmb左4000
        '
        Me.cmb左4000.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb左4000.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb左4000.FormattingEnabled = True
        Me.cmb左4000.Items.AddRange(New Object() {"所見なし", "所見あり"})
        Me.cmb左4000.Location = New System.Drawing.Point(713, 412)
        Me.cmb左4000.Name = "cmb左4000"
        Me.cmb左4000.Size = New System.Drawing.Size(270, 80)
        Me.cmb左4000.TabIndex = 1019
        Me.cmb左4000.TabStop = False
        '
        'lbl左4000
        '
        Me.lbl左4000.AutoSize = True
        Me.lbl左4000.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl左4000.Location = New System.Drawing.Point(703, 354)
        Me.lbl左4000.Name = "lbl左4000"
        Me.lbl左4000.Size = New System.Drawing.Size(347, 55)
        Me.lbl左4000.TabIndex = 1018
        Me.lbl左4000.Text = "聴力（左）4000Hz"
        '
        'cmb左1000
        '
        Me.cmb左1000.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb左1000.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb左1000.FormattingEnabled = True
        Me.cmb左1000.Items.AddRange(New Object() {"所見なし", "所見あり"})
        Me.cmb左1000.Location = New System.Drawing.Point(713, 231)
        Me.cmb左1000.Name = "cmb左1000"
        Me.cmb左1000.Size = New System.Drawing.Size(270, 80)
        Me.cmb左1000.TabIndex = 1017
        Me.cmb左1000.TabStop = False
        '
        'lbl左1000
        '
        Me.lbl左1000.AutoSize = True
        Me.lbl左1000.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl左1000.Location = New System.Drawing.Point(703, 173)
        Me.lbl左1000.Name = "lbl左1000"
        Me.lbl左1000.Size = New System.Drawing.Size(347, 55)
        Me.lbl左1000.TabIndex = 1016
        Me.lbl左1000.Text = "聴力（左）1000Hz"
        '
        'cmb右4000
        '
        Me.cmb右4000.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb右4000.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb右4000.FormattingEnabled = True
        Me.cmb右4000.Items.AddRange(New Object() {"所見なし", "所見あり"})
        Me.cmb右4000.Location = New System.Drawing.Point(163, 412)
        Me.cmb右4000.Name = "cmb右4000"
        Me.cmb右4000.Size = New System.Drawing.Size(270, 80)
        Me.cmb右4000.TabIndex = 1015
        Me.cmb右4000.TabStop = False
        '
        'lbl右4000
        '
        Me.lbl右4000.AutoSize = True
        Me.lbl右4000.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl右4000.Location = New System.Drawing.Point(153, 354)
        Me.lbl右4000.Name = "lbl右4000"
        Me.lbl右4000.Size = New System.Drawing.Size(347, 55)
        Me.lbl右4000.TabIndex = 1014
        Me.lbl右4000.Text = "聴力（右）4000Hz"
        '
        'cmb右1000
        '
        Me.cmb右1000.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb右1000.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb右1000.FormattingEnabled = True
        Me.cmb右1000.Items.AddRange(New Object() {"所見なし", "所見あり"})
        Me.cmb右1000.Location = New System.Drawing.Point(163, 231)
        Me.cmb右1000.Name = "cmb右1000"
        Me.cmb右1000.Size = New System.Drawing.Size(270, 80)
        Me.cmb右1000.TabIndex = 1013
        Me.cmb右1000.TabStop = False
        '
        'lbl右1000
        '
        Me.lbl右1000.AutoSize = True
        Me.lbl右1000.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl右1000.Location = New System.Drawing.Point(153, 173)
        Me.lbl右1000.Name = "lbl右1000"
        Me.lbl右1000.Size = New System.Drawing.Size(347, 55)
        Me.lbl右1000.TabIndex = 1012
        Me.lbl右1000.Text = "聴力（右）1000Hz"
        '
        'txt通番聴力
        '
        Me.txt通番聴力.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt通番聴力.Location = New System.Drawing.Point(325, 59)
        Me.txt通番聴力.Name = "txt通番聴力"
        Me.txt通番聴力.ReadOnly = True
        Me.txt通番聴力.Size = New System.Drawing.Size(129, 79)
        Me.txt通番聴力.TabIndex = 1011
        Me.txt通番聴力.TabStop = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("メイリオ", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 39)
        Me.Label8.TabIndex = 1010
        Me.Label8.Text = "個人番号"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNo聴力
        '
        Me.txtNo聴力.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNo聴力.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtNo聴力.Location = New System.Drawing.Point(17, 60)
        Me.txtNo聴力.MaxLength = 17
        Me.txtNo聴力.Name = "txtNo聴力"
        Me.txtNo聴力.Size = New System.Drawing.Size(291, 79)
        Me.txtNo聴力.TabIndex = 1009
        Me.txtNo聴力.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("メイリオ", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(337, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 44)
        Me.Label9.TabIndex = 1008
        Me.Label9.Text = "通番"
        '
        'chkすべて聴力
        '
        Me.chkすべて聴力.AutoSize = True
        Me.chkすべて聴力.Font = New System.Drawing.Font("メイリオ", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chkすべて聴力.Location = New System.Drawing.Point(490, 133)
        Me.chkすべて聴力.Name = "chkすべて聴力"
        Me.chkすべて聴力.Size = New System.Drawing.Size(154, 40)
        Me.chkすべて聴力.TabIndex = 1007
        Me.chkすべて聴力.TabStop = False
        Me.chkすべて聴力.Text = "すべて表示"
        Me.chkすべて聴力.UseVisualStyleBackColor = True
        Me.chkすべて聴力.Visible = False
        '
        'lbl名前聴力
        '
        Me.lbl名前聴力.AutoSize = True
        Me.lbl名前聴力.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl名前聴力.Location = New System.Drawing.Point(480, 84)
        Me.lbl名前聴力.Name = "lbl名前聴力"
        Me.lbl名前聴力.Size = New System.Drawing.Size(98, 55)
        Me.lbl名前聴力.TabIndex = 1006
        Me.lbl名前聴力.Text = "名前"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btn握力登録)
        Me.TabPage4.Controls.Add(Me.lbl握力左単位)
        Me.TabPage4.Controls.Add(Me.lbl握力右単位)
        Me.TabPage4.Controls.Add(Me.txt握力左少数)
        Me.TabPage4.Controls.Add(Me.lbl握力左小数点)
        Me.TabPage4.Controls.Add(Me.txt握力右少数)
        Me.TabPage4.Controls.Add(Me.lbl握力右小数点)
        Me.TabPage4.Controls.Add(Me.txt握力左整数)
        Me.TabPage4.Controls.Add(Me.txt握力右整数)
        Me.TabPage4.Controls.Add(Me.lbl握力左)
        Me.TabPage4.Controls.Add(Me.lbl握力右)
        Me.TabPage4.Controls.Add(Me.txt通番握力)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.txtNo握力)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.lbl名前握力)
        Me.TabPage4.Location = New System.Drawing.Point(4, 57)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1324, 562)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "握力"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btn握力登録
        '
        Me.btn握力登録.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn握力登録.Location = New System.Drawing.Point(1115, 458)
        Me.btn握力登録.Name = "btn握力登録"
        Me.btn握力登録.Size = New System.Drawing.Size(192, 85)
        Me.btn握力登録.TabIndex = 1021
        Me.btn握力登録.TabStop = False
        Me.btn握力登録.Text = "登録"
        Me.btn握力登録.UseVisualStyleBackColor = True
        '
        'lbl握力左単位
        '
        Me.lbl握力左単位.AutoSize = True
        Me.lbl握力左単位.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl握力左単位.Location = New System.Drawing.Point(853, 333)
        Me.lbl握力左単位.Name = "lbl握力左単位"
        Me.lbl握力左単位.Size = New System.Drawing.Size(56, 55)
        Me.lbl握力左単位.TabIndex = 1020
        Me.lbl握力左単位.Text = "--"
        '
        'lbl握力右単位
        '
        Me.lbl握力右単位.AutoSize = True
        Me.lbl握力右単位.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl握力右単位.Location = New System.Drawing.Point(853, 227)
        Me.lbl握力右単位.Name = "lbl握力右単位"
        Me.lbl握力右単位.Size = New System.Drawing.Size(56, 55)
        Me.lbl握力右単位.TabIndex = 1019
        Me.lbl握力右単位.Text = "--"
        '
        'txt握力左少数
        '
        Me.txt握力左少数.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt握力左少数.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt握力左少数.Location = New System.Drawing.Point(785, 285)
        Me.txt握力左少数.Name = "txt握力左少数"
        Me.txt握力左少数.Size = New System.Drawing.Size(62, 103)
        Me.txt握力左少数.TabIndex = 1016
        '
        'lbl握力左小数点
        '
        Me.lbl握力左小数点.AutoSize = True
        Me.lbl握力左小数点.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl握力左小数点.Location = New System.Drawing.Point(732, 291)
        Me.lbl握力左小数点.Name = "lbl握力左小数点"
        Me.lbl握力左小数点.Size = New System.Drawing.Size(62, 96)
        Me.lbl握力左小数点.TabIndex = 1018
        Me.lbl握力左小数点.Text = "."
        '
        'txt握力右少数
        '
        Me.txt握力右少数.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt握力右少数.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt握力右少数.Location = New System.Drawing.Point(785, 175)
        Me.txt握力右少数.Name = "txt握力右少数"
        Me.txt握力右少数.Size = New System.Drawing.Size(62, 103)
        Me.txt握力右少数.TabIndex = 1013
        '
        'lbl握力右小数点
        '
        Me.lbl握力右小数点.AutoSize = True
        Me.lbl握力右小数点.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl握力右小数点.Location = New System.Drawing.Point(732, 183)
        Me.lbl握力右小数点.Name = "lbl握力右小数点"
        Me.lbl握力右小数点.Size = New System.Drawing.Size(62, 96)
        Me.lbl握力右小数点.TabIndex = 1017
        Me.lbl握力右小数点.Text = "."
        '
        'txt握力左整数
        '
        Me.txt握力左整数.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt握力左整数.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt握力左整数.Location = New System.Drawing.Point(601, 285)
        Me.txt握力左整数.MaxLength = 3
        Me.txt握力左整数.Name = "txt握力左整数"
        Me.txt握力左整数.Size = New System.Drawing.Size(131, 103)
        Me.txt握力左整数.TabIndex = 1015
        '
        'txt握力右整数
        '
        Me.txt握力右整数.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt握力右整数.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt握力右整数.Location = New System.Drawing.Point(601, 175)
        Me.txt握力右整数.MaxLength = 3
        Me.txt握力右整数.Name = "txt握力右整数"
        Me.txt握力右整数.Size = New System.Drawing.Size(131, 103)
        Me.txt握力右整数.TabIndex = 1012
        '
        'lbl握力左
        '
        Me.lbl握力左.AutoSize = True
        Me.lbl握力左.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl握力左.Location = New System.Drawing.Point(290, 291)
        Me.lbl握力左.Name = "lbl握力左"
        Me.lbl握力左.Size = New System.Drawing.Size(96, 96)
        Me.lbl握力左.TabIndex = 1014
        Me.lbl握力左.Text = "--"
        '
        'lbl握力右
        '
        Me.lbl握力右.AutoSize = True
        Me.lbl握力右.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl握力右.Location = New System.Drawing.Point(290, 182)
        Me.lbl握力右.Name = "lbl握力右"
        Me.lbl握力右.Size = New System.Drawing.Size(96, 96)
        Me.lbl握力右.TabIndex = 1011
        Me.lbl握力右.Text = "--"
        '
        'txt通番握力
        '
        Me.txt通番握力.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt通番握力.Location = New System.Drawing.Point(325, 59)
        Me.txt通番握力.Name = "txt通番握力"
        Me.txt通番握力.ReadOnly = True
        Me.txt通番握力.Size = New System.Drawing.Size(129, 79)
        Me.txt通番握力.TabIndex = 1010
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("メイリオ", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 39)
        Me.Label10.TabIndex = 1009
        Me.Label10.Text = "個人番号"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNo握力
        '
        Me.txtNo握力.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNo握力.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtNo握力.Location = New System.Drawing.Point(17, 60)
        Me.txtNo握力.MaxLength = 17
        Me.txtNo握力.Name = "txtNo握力"
        Me.txtNo握力.Size = New System.Drawing.Size(291, 79)
        Me.txtNo握力.TabIndex = 1008
        Me.txtNo握力.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("メイリオ", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(337, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 44)
        Me.Label11.TabIndex = 1007
        Me.Label11.Text = "通番"
        '
        'lbl名前握力
        '
        Me.lbl名前握力.AutoSize = True
        Me.lbl名前握力.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl名前握力.Location = New System.Drawing.Point(480, 84)
        Me.lbl名前握力.Name = "lbl名前握力"
        Me.lbl名前握力.Size = New System.Drawing.Size(98, 55)
        Me.lbl名前握力.TabIndex = 1006
        Me.lbl名前握力.Text = "名前"
        '
        'RcvDataToTextBox
        '
        Me.RcvDataToTextBox.Location = New System.Drawing.Point(450, -1)
        Me.RcvDataToTextBox.Multiline = True
        Me.RcvDataToTextBox.Name = "RcvDataToTextBox"
        Me.RcvDataToTextBox.Size = New System.Drawing.Size(56, 27)
        Me.RcvDataToTextBox.TabIndex = 100
        Me.RcvDataToTextBox.Visible = False
        '
        'ep
        '
        Me.ep.ContainerControl = Me
        '
        'tmr
        '
        Me.tmr.Interval = 800
        '
        'btn選択確定
        '
        Me.btn選択確定.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn選択確定.Location = New System.Drawing.Point(383, 663)
        Me.btn選択確定.Margin = New System.Windows.Forms.Padding(5)
        Me.btn選択確定.Name = "btn選択確定"
        Me.btn選択確定.Size = New System.Drawing.Size(235, 70)
        Me.btn選択確定.TabIndex = 101
        Me.btn選択確定.TabStop = False
        Me.btn選択確定.Text = "選択確定"
        Me.btn選択確定.UseVisualStyleBackColor = True
        '
        'btn終了
        '
        Me.btn終了.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn終了.Location = New System.Drawing.Point(1184, 664)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(160, 70)
        Me.btn終了.TabIndex = 106
        Me.btn終了.TabStop = False
        Me.btn終了.Text = "終了"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.計測.My.Resources.Resources.estSVlogo
        Me.PictureBox1.Location = New System.Drawing.Point(1091, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(253, 43)
        Me.PictureBox1.TabIndex = 107
        Me.PictureBox1.TabStop = False
        '
        '計測
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1268, 739)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn終了)
        Me.Controls.Add(Me.btn選択確定)
        Me.Controls.Add(Me.tb)
        Me.Controls.Add(Me.RcvDataToTextBox)
        Me.Controls.Add(Me.btnポート設定)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "計測"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "計測"
        Me.tb.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnポート設定 As System.Windows.Forms.Button
    Friend WithEvents sp As System.IO.Ports.SerialPort
    Friend WithEvents tb As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents chk腹囲 As System.Windows.Forms.CheckBox
    Friend WithEvents btn登録 As System.Windows.Forms.Button
    Friend WithEvents lbl腹囲単位 As System.Windows.Forms.Label
    Friend WithEvents lbl体重単位 As System.Windows.Forms.Label
    Friend WithEvents lbl身長単位 As System.Windows.Forms.Label
    Friend WithEvents txt腹囲少数 As System.Windows.Forms.TextBox
    Friend WithEvents txt体重少数 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt身長少数 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt腹囲 As System.Windows.Forms.TextBox
    Friend WithEvents txt体重 As System.Windows.Forms.TextBox
    Friend WithEvents txt身長 As System.Windows.Forms.TextBox
    Friend WithEvents lbl腹囲 As System.Windows.Forms.Label
    Friend WithEvents lbl体重 As System.Windows.Forms.Label
    Friend WithEvents lbl名前 As System.Windows.Forms.Label
    Friend WithEvents lbl身長 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lbl最低血圧単位1 As System.Windows.Forms.Label
    Friend WithEvents lbl最高血圧単位1 As System.Windows.Forms.Label
    Friend WithEvents txt最低血圧1 As System.Windows.Forms.TextBox
    Friend WithEvents txt最高血圧1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl最低血圧1 As System.Windows.Forms.Label
    Friend WithEvents lbl最高血圧1 As System.Windows.Forms.Label
    Friend WithEvents lbl名前2 As System.Windows.Forms.Label
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider
    Friend WithEvents RcvDataToTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btn身長計測 As System.Windows.Forms.Button
    Friend WithEvents lbl最低血圧単位2 As System.Windows.Forms.Label
    Friend WithEvents lbl最高血圧単位2 As System.Windows.Forms.Label
    Friend WithEvents txt最低血圧2 As System.Windows.Forms.TextBox
    Friend WithEvents txt最高血圧2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl最低血圧2 As System.Windows.Forms.Label
    Friend WithEvents lbl最高血圧2 As System.Windows.Forms.Label
    Friend WithEvents btn血圧計測 As System.Windows.Forms.Button
    Friend WithEvents btn登録2 As System.Windows.Forms.Button
    Friend WithEvents btn血圧クリア2 As System.Windows.Forms.Button
    Friend WithEvents btn血圧クリア1 As System.Windows.Forms.Button
    Friend WithEvents tmr As System.Windows.Forms.Timer
    Friend WithEvents btn選択確定 As System.Windows.Forms.Button
    Friend WithEvents btn確定 As System.Windows.Forms.Button
    Friend WithEvents btn終了 As System.Windows.Forms.Button
    Friend WithEvents chk血圧すべて As System.Windows.Forms.CheckBox
    Friend WithEvents chkすべて身長 As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chk衣服分 As System.Windows.Forms.CheckBox
    Friend WithEvents lblgen As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents txt連番 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNo血圧 As System.Windows.Forms.TextBox
    Friend WithEvents txt通番血圧 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents lbl右1000 As System.Windows.Forms.Label
    Friend WithEvents txt通番聴力 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNo聴力 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkすべて聴力 As System.Windows.Forms.CheckBox
    Friend WithEvents lbl名前聴力 As System.Windows.Forms.Label
    Friend WithEvents cmb右1000 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb左4000 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl左4000 As System.Windows.Forms.Label
    Friend WithEvents cmb左1000 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl左1000 As System.Windows.Forms.Label
    Friend WithEvents cmb右4000 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl右4000 As System.Windows.Forms.Label
    Friend WithEvents btn聴力登録 As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents txt通番握力 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNo握力 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl名前握力 As System.Windows.Forms.Label
    Friend WithEvents lbl握力左単位 As System.Windows.Forms.Label
    Friend WithEvents lbl握力右単位 As System.Windows.Forms.Label
    Friend WithEvents txt握力左少数 As System.Windows.Forms.TextBox
    Friend WithEvents lbl握力左小数点 As System.Windows.Forms.Label
    Friend WithEvents txt握力右少数 As System.Windows.Forms.TextBox
    Friend WithEvents lbl握力右小数点 As System.Windows.Forms.Label
    Friend WithEvents txt握力左整数 As System.Windows.Forms.TextBox
    Friend WithEvents txt握力右整数 As System.Windows.Forms.TextBox
    Friend WithEvents lbl握力左 As System.Windows.Forms.Label
    Friend WithEvents lbl握力右 As System.Windows.Forms.Label
    Friend WithEvents chk登録ボタンへ移動する As System.Windows.Forms.CheckBox
    Friend WithEvents btn握力登録 As System.Windows.Forms.Button
    Friend WithEvents chkGo聴力 As System.Windows.Forms.CheckBox
End Class
