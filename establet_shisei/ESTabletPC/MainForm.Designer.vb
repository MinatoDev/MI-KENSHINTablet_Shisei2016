﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.tab = New System.Windows.Forms.TabControl()
        Me.tp健診受付 = New System.Windows.Forms.TabPage()
        Me.chkAuto = New System.Windows.Forms.CheckBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lbl人数 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMsg2 = New System.Windows.Forms.Label()
        Me.lblMsg1 = New System.Windows.Forms.Label()
        Me.btnなし = New System.Windows.Forms.Button()
        Me.btn修正 = New System.Windows.Forms.Button()
        Me.txt修正 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt通番 = New System.Windows.Forms.TextBox()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.視力 = New System.Windows.Forms.TabPage()
        Me.chkすべて表示 = New System.Windows.Forms.CheckBox()
        Me.cmb通番視力 = New System.Windows.Forms.ComboBox()
        Me.btn登録 = New System.Windows.Forms.Button()
        Me.cmb矯正左 = New System.Windows.Forms.ComboBox()
        Me.cmb矯正右 = New System.Windows.Forms.ComboBox()
        Me.lbl矯正左 = New System.Windows.Forms.Label()
        Me.lbl矯正右 = New System.Windows.Forms.Label()
        Me.cmb裸眼左 = New System.Windows.Forms.ComboBox()
        Me.cmb裸眼右 = New System.Windows.Forms.ComboBox()
        Me.lbl裸眼左 = New System.Windows.Forms.Label()
        Me.lbl裸眼右 = New System.Windows.Forms.Label()
        Me.lbl名前視力 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tp通過管理 = New System.Windows.Forms.TabPage()
        Me.lbl名前2 = New System.Windows.Forms.Label()
        Me.btn完了 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt通番2 = New System.Windows.Forms.TextBox()
        Me.tp端末管理 = New System.Windows.Forms.TabPage()
        Me.btn削除 = New System.Windows.Forms.Button()
        Me.btn端末修正 = New System.Windows.Forms.Button()
        Me.bt追加 = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.端末IP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.端末名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.用途 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.グループ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.備考 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tp表示 = New System.Windows.Forms.TabPage()
        Me.dgvResult = New System.Windows.Forms.DataGridView()
        Me.連番 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.個人番号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.お名前 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.裸眼右 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.裸眼左 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.矯正右 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.矯正左 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn全選択解除 = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnRenew = New System.Windows.Forms.Button()
        Me.dgvNonReceptionists = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.ep = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dp = New System.Windows.Forms.ComboBox()
        Me.lbl取込総数 = New System.Windows.Forms.Label()
        Me.cmb団体名 = New System.Windows.Forms.ComboBox()
        Me.chk握力 = New 受付管理.chkPass()
        Me.chk座高 = New 受付管理.chkPass()
        Me.chkその他 = New 受付管理.chkPass()
        Me.chk腹部エコー = New 受付管理.chkPass()
        Me.chk眼底検査 = New 受付管理.chkPass()
        Me.chk心電図 = New 受付管理.chkPass()
        Me.chk採血 = New 受付管理.chkPass()
        Me.chk腹部X線 = New 受付管理.chkPass()
        Me.chk胸部X線 = New 受付管理.chkPass()
        Me.chk診察 = New 受付管理.chkPass()
        Me.chk尿検査 = New 受付管理.chkPass()
        Me.chk聴力 = New 受付管理.chkPass()
        Me.chk視力 = New 受付管理.chkPass()
        Me.chk腹囲 = New 受付管理.chkPass()
        Me.chk血圧 = New 受付管理.chkPass()
        Me.chk身長体重 = New 受付管理.chkPass()
        Me.chkItem握力 = New 受付管理.chkPass()
        Me.chkItem座高 = New 受付管理.chkPass()
        Me.chkItem内科検診 = New 受付管理.chkPass()
        Me.chkItem聴力 = New 受付管理.chkPass()
        Me.chkItem身長体重 = New 受付管理.chkPass()
        Me.chkItem腹囲 = New 受付管理.chkPass()
        Me.chkItem検尿 = New 受付管理.chkPass()
        Me.chkItem血圧 = New 受付管理.chkPass()
        Me.chkItem視力 = New 受付管理.chkPass()
        Me.tab.SuspendLayout()
        Me.tp健診受付.SuspendLayout()
        Me.視力.SuspendLayout()
        Me.tp通過管理.SuspendLayout()
        Me.tp端末管理.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp表示.SuspendLayout()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvNonReceptionists, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab
        '
        Me.tab.Controls.Add(Me.tp健診受付)
        Me.tab.Controls.Add(Me.視力)
        Me.tab.Controls.Add(Me.tp通過管理)
        Me.tab.Controls.Add(Me.tp端末管理)
        Me.tab.Controls.Add(Me.tp表示)
        Me.tab.Controls.Add(Me.TabPage1)
        Me.tab.Font = New System.Drawing.Font("メイリオ", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.tab.Location = New System.Drawing.Point(14, 112)
        Me.tab.Margin = New System.Windows.Forms.Padding(5)
        Me.tab.Name = "tab"
        Me.tab.SelectedIndex = 0
        Me.tab.Size = New System.Drawing.Size(1324, 544)
        Me.tab.TabIndex = 101
        '
        'tp健診受付
        '
        Me.tp健診受付.Controls.Add(Me.chkAuto)
        Me.tp健診受付.Controls.Add(Me.lblName)
        Me.tp健診受付.Controls.Add(Me.lbl人数)
        Me.tp健診受付.Controls.Add(Me.Label5)
        Me.tp健診受付.Controls.Add(Me.Label4)
        Me.tp健診受付.Controls.Add(Me.lblMsg2)
        Me.tp健診受付.Controls.Add(Me.lblMsg1)
        Me.tp健診受付.Controls.Add(Me.btnなし)
        Me.tp健診受付.Controls.Add(Me.btn修正)
        Me.tp健診受付.Controls.Add(Me.txt修正)
        Me.tp健診受付.Controls.Add(Me.Label1)
        Me.tp健診受付.Controls.Add(Me.txt通番)
        Me.tp健診受付.Controls.Add(Me.txtNo)
        Me.tp健診受付.Font = New System.Drawing.Font("メイリオ", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.tp健診受付.Location = New System.Drawing.Point(4, 57)
        Me.tp健診受付.Margin = New System.Windows.Forms.Padding(5)
        Me.tp健診受付.Name = "tp健診受付"
        Me.tp健診受付.Padding = New System.Windows.Forms.Padding(5)
        Me.tp健診受付.Size = New System.Drawing.Size(1316, 483)
        Me.tp健診受付.TabIndex = 2
        Me.tp健診受付.Text = "健診受付"
        Me.tp健診受付.UseVisualStyleBackColor = True
        '
        'chkAuto
        '
        Me.chkAuto.AutoSize = True
        Me.chkAuto.Checked = True
        Me.chkAuto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAuto.Location = New System.Drawing.Point(888, 46)
        Me.chkAuto.Name = "chkAuto"
        Me.chkAuto.Size = New System.Drawing.Size(295, 52)
        Me.chkAuto.TabIndex = 1032
        Me.chkAuto.TabStop = False
        Me.chkAuto.Text = "自動で視力に移動"
        Me.chkAuto.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblName.Location = New System.Drawing.Point(485, 129)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 72)
        Me.lblName.TabIndex = 1021
        '
        'lbl人数
        '
        Me.lbl人数.Font = New System.Drawing.Font("メイリオ", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl人数.Location = New System.Drawing.Point(163, 423)
        Me.lbl人数.Name = "lbl人数"
        Me.lbl人数.Size = New System.Drawing.Size(73, 38)
        Me.lbl人数.TabIndex = 1004
        Me.lbl人数.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl人数.UseCompatibleTextRendering = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("メイリオ", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 418)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 38)
        Me.Label5.TabIndex = 1003
        Me.Label5.Text = "受付人数"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("メイリオ", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 39)
        Me.Label4.TabIndex = 1002
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMsg2
        '
        Me.lblMsg2.AutoSize = True
        Me.lblMsg2.Font = New System.Drawing.Font("メイリオ", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblMsg2.Location = New System.Drawing.Point(713, 301)
        Me.lblMsg2.Name = "lblMsg2"
        Me.lblMsg2.Size = New System.Drawing.Size(0, 52)
        Me.lblMsg2.TabIndex = 1001
        Me.lblMsg2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMsg1
        '
        Me.lblMsg1.Font = New System.Drawing.Font("メイリオ", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblMsg1.Location = New System.Drawing.Point(18, 301)
        Me.lblMsg1.Name = "lblMsg1"
        Me.lblMsg1.Size = New System.Drawing.Size(473, 38)
        Me.lblMsg1.TabIndex = 1000
        Me.lblMsg1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnなし
        '
        Me.btnなし.Font = New System.Drawing.Font("メイリオ", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnなし.Location = New System.Drawing.Point(271, 46)
        Me.btnなし.Name = "btnなし"
        Me.btnなし.Size = New System.Drawing.Size(193, 43)
        Me.btnなし.TabIndex = 999
        Me.btnなし.TabStop = False
        Me.btnなし.Text = "個人番号なし"
        Me.btnなし.UseVisualStyleBackColor = True
        '
        'btn修正
        '
        Me.btn修正.Font = New System.Drawing.Font("メイリオ", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn修正.Location = New System.Drawing.Point(1196, 405)
        Me.btn修正.Name = "btn修正"
        Me.btn修正.Size = New System.Drawing.Size(109, 58)
        Me.btn修正.TabIndex = 4
        Me.btn修正.TabStop = False
        Me.btn修正.Text = "修正"
        Me.btn修正.UseVisualStyleBackColor = True
        '
        'txt修正
        '
        Me.txt修正.Font = New System.Drawing.Font("メイリオ", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt修正.Location = New System.Drawing.Point(1077, 405)
        Me.txt修正.MaxLength = 3
        Me.txt修正.Name = "txt修正"
        Me.txt修正.Size = New System.Drawing.Size(106, 55)
        Me.txt修正.TabIndex = 999
        Me.txt修正.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(923, 415)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 48)
        Me.Label1.TabIndex = 2
        '
        'txt通番
        '
        Me.txt通番.BackColor = System.Drawing.Color.Blue
        Me.txt通番.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt通番.Font = New System.Drawing.Font("メイリオ", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt通番.ForeColor = System.Drawing.Color.White
        Me.txt通番.Location = New System.Drawing.Point(509, 234)
        Me.txt通番.Name = "txt通番"
        Me.txt通番.ReadOnly = True
        Me.txt通番.Size = New System.Drawing.Size(198, 151)
        Me.txt通番.TabIndex = 1
        Me.txt通番.TabStop = False
        '
        'txtNo
        '
        Me.txtNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNo.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtNo.Location = New System.Drawing.Point(24, 98)
        Me.txtNo.MaxLength = 10
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(440, 103)
        Me.txtNo.TabIndex = 0
        Me.txtNo.TabStop = False
        '
        '視力
        '
        Me.視力.Controls.Add(Me.chkすべて表示)
        Me.視力.Controls.Add(Me.cmb通番視力)
        Me.視力.Controls.Add(Me.btn登録)
        Me.視力.Controls.Add(Me.cmb矯正左)
        Me.視力.Controls.Add(Me.cmb矯正右)
        Me.視力.Controls.Add(Me.lbl矯正左)
        Me.視力.Controls.Add(Me.lbl矯正右)
        Me.視力.Controls.Add(Me.cmb裸眼左)
        Me.視力.Controls.Add(Me.cmb裸眼右)
        Me.視力.Controls.Add(Me.lbl裸眼左)
        Me.視力.Controls.Add(Me.lbl裸眼右)
        Me.視力.Controls.Add(Me.lbl名前視力)
        Me.視力.Controls.Add(Me.Label6)
        Me.視力.Location = New System.Drawing.Point(4, 57)
        Me.視力.Name = "視力"
        Me.視力.Padding = New System.Windows.Forms.Padding(3)
        Me.視力.Size = New System.Drawing.Size(1316, 483)
        Me.視力.TabIndex = 5
        Me.視力.Text = "視力"
        Me.視力.UseVisualStyleBackColor = True
        '
        'chkすべて表示
        '
        Me.chkすべて表示.AutoSize = True
        Me.chkすべて表示.Location = New System.Drawing.Point(621, 113)
        Me.chkすべて表示.Name = "chkすべて表示"
        Me.chkすべて表示.Size = New System.Drawing.Size(199, 52)
        Me.chkすべて表示.TabIndex = 1031
        Me.chkすべて表示.Text = "すべて表示"
        Me.chkすべて表示.UseVisualStyleBackColor = True
        '
        'cmb通番視力
        '
        Me.cmb通番視力.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb通番視力.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb通番視力.FormattingEnabled = True
        Me.cmb通番視力.Location = New System.Drawing.Point(427, 23)
        Me.cmb通番視力.Name = "cmb通番視力"
        Me.cmb通番視力.Size = New System.Drawing.Size(188, 104)
        Me.cmb通番視力.Sorted = True
        Me.cmb通番視力.TabIndex = 1030
        '
        'btn登録
        '
        Me.btn登録.Enabled = False
        Me.btn登録.Location = New System.Drawing.Point(1183, 412)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(120, 54)
        Me.btn登録.TabIndex = 1029
        Me.btn登録.TabStop = False
        Me.btn登録.Text = "登録"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'cmb矯正左
        '
        Me.cmb矯正左.Enabled = False
        Me.cmb矯正左.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb矯正左.FormattingEnabled = True
        Me.cmb矯正左.Items.AddRange(New Object() {"", "1.5", "1.2", "1.0", "0.9", "0.8", "0.7", "0.6", "0.5", "0.4", "0.3", "0.2", "0.1", "0.0"})
        Me.cmb矯正左.Location = New System.Drawing.Point(1020, 307)
        Me.cmb矯正左.MaxLength = 3
        Me.cmb矯正左.Name = "cmb矯正左"
        Me.cmb矯正左.Size = New System.Drawing.Size(192, 80)
        Me.cmb矯正左.TabIndex = 1028
        Me.cmb矯正左.TabStop = False
        '
        'cmb矯正右
        '
        Me.cmb矯正右.Enabled = False
        Me.cmb矯正右.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb矯正右.FormattingEnabled = True
        Me.cmb矯正右.Items.AddRange(New Object() {"", "1.5", "1.2", "1.0", "0.9", "0.8", "0.7", "0.6", "0.5", "0.4", "0.3", "0.2", "0.1", "0.0"})
        Me.cmb矯正右.Location = New System.Drawing.Point(1020, 192)
        Me.cmb矯正右.MaxLength = 3
        Me.cmb矯正右.Name = "cmb矯正右"
        Me.cmb矯正右.Size = New System.Drawing.Size(192, 80)
        Me.cmb矯正右.TabIndex = 1027
        Me.cmb矯正右.TabStop = False
        '
        'lbl矯正左
        '
        Me.lbl矯正左.Enabled = False
        Me.lbl矯正左.Font = New System.Drawing.Font("メイリオ", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl矯正左.Location = New System.Drawing.Point(661, 313)
        Me.lbl矯正左.Name = "lbl矯正左"
        Me.lbl矯正左.Size = New System.Drawing.Size(366, 72)
        Me.lbl矯正左.TabIndex = 1026
        Me.lbl矯正左.Text = "--"
        '
        'lbl矯正右
        '
        Me.lbl矯正右.Enabled = False
        Me.lbl矯正右.Font = New System.Drawing.Font("メイリオ", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl矯正右.Location = New System.Drawing.Point(661, 195)
        Me.lbl矯正右.Name = "lbl矯正右"
        Me.lbl矯正右.Size = New System.Drawing.Size(366, 72)
        Me.lbl矯正右.TabIndex = 1025
        Me.lbl矯正右.Text = "--"
        '
        'cmb裸眼左
        '
        Me.cmb裸眼左.Enabled = False
        Me.cmb裸眼左.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb裸眼左.FormattingEnabled = True
        Me.cmb裸眼左.Items.AddRange(New Object() {"", "1.5", "1.2", "1.0", "0.9", "0.8", "0.7", "0.6", "0.5", "0.4", "0.3", "0.2", "0.1", "0.0"})
        Me.cmb裸眼左.Location = New System.Drawing.Point(448, 302)
        Me.cmb裸眼左.MaxLength = 3
        Me.cmb裸眼左.Name = "cmb裸眼左"
        Me.cmb裸眼左.Size = New System.Drawing.Size(192, 80)
        Me.cmb裸眼左.TabIndex = 1024
        Me.cmb裸眼左.TabStop = False
        '
        'cmb裸眼右
        '
        Me.cmb裸眼右.Enabled = False
        Me.cmb裸眼右.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb裸眼右.FormattingEnabled = True
        Me.cmb裸眼右.Items.AddRange(New Object() {"", "1.5", "1.2", "1.0", "0.9", "0.8", "0.7", "0.6", "0.5", "0.4", "0.3", "0.2", "0.1", "0.0"})
        Me.cmb裸眼右.Location = New System.Drawing.Point(448, 187)
        Me.cmb裸眼右.MaxLength = 3
        Me.cmb裸眼右.Name = "cmb裸眼右"
        Me.cmb裸眼右.Size = New System.Drawing.Size(192, 80)
        Me.cmb裸眼右.TabIndex = 1023
        Me.cmb裸眼右.TabStop = False
        '
        'lbl裸眼左
        '
        Me.lbl裸眼左.Enabled = False
        Me.lbl裸眼左.Font = New System.Drawing.Font("メイリオ", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl裸眼左.Location = New System.Drawing.Point(76, 314)
        Me.lbl裸眼左.Name = "lbl裸眼左"
        Me.lbl裸眼左.Size = New System.Drawing.Size(366, 72)
        Me.lbl裸眼左.TabIndex = 1022
        Me.lbl裸眼左.Text = "--"
        '
        'lbl裸眼右
        '
        Me.lbl裸眼右.Enabled = False
        Me.lbl裸眼右.Font = New System.Drawing.Font("メイリオ", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl裸眼右.Location = New System.Drawing.Point(76, 195)
        Me.lbl裸眼右.Name = "lbl裸眼右"
        Me.lbl裸眼右.Size = New System.Drawing.Size(366, 72)
        Me.lbl裸眼右.TabIndex = 1021
        Me.lbl裸眼右.Text = "--"
        '
        'lbl名前視力
        '
        Me.lbl名前視力.AutoSize = True
        Me.lbl名前視力.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl名前視力.Location = New System.Drawing.Point(637, 38)
        Me.lbl名前視力.Name = "lbl名前視力"
        Me.lbl名前視力.Size = New System.Drawing.Size(126, 72)
        Me.lbl名前視力.TabIndex = 1020
        Me.lbl名前視力.Text = "名前"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(286, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 72)
        Me.Label6.TabIndex = 1005
        Me.Label6.Text = "通番"
        '
        'tp通過管理
        '
        Me.tp通過管理.Controls.Add(Me.chk握力)
        Me.tp通過管理.Controls.Add(Me.chk座高)
        Me.tp通過管理.Controls.Add(Me.chkその他)
        Me.tp通過管理.Controls.Add(Me.chk腹部エコー)
        Me.tp通過管理.Controls.Add(Me.chk眼底検査)
        Me.tp通過管理.Controls.Add(Me.chk心電図)
        Me.tp通過管理.Controls.Add(Me.chk採血)
        Me.tp通過管理.Controls.Add(Me.chk腹部X線)
        Me.tp通過管理.Controls.Add(Me.chk胸部X線)
        Me.tp通過管理.Controls.Add(Me.chk診察)
        Me.tp通過管理.Controls.Add(Me.chk尿検査)
        Me.tp通過管理.Controls.Add(Me.chk聴力)
        Me.tp通過管理.Controls.Add(Me.chk視力)
        Me.tp通過管理.Controls.Add(Me.chk腹囲)
        Me.tp通過管理.Controls.Add(Me.chk血圧)
        Me.tp通過管理.Controls.Add(Me.chk身長体重)
        Me.tp通過管理.Controls.Add(Me.lbl名前2)
        Me.tp通過管理.Controls.Add(Me.btn完了)
        Me.tp通過管理.Controls.Add(Me.Label3)
        Me.tp通過管理.Controls.Add(Me.txt通番2)
        Me.tp通過管理.Location = New System.Drawing.Point(4, 57)
        Me.tp通過管理.Name = "tp通過管理"
        Me.tp通過管理.Padding = New System.Windows.Forms.Padding(3)
        Me.tp通過管理.Size = New System.Drawing.Size(1316, 483)
        Me.tp通過管理.TabIndex = 3
        Me.tp通過管理.Text = "通過管理"
        Me.tp通過管理.UseVisualStyleBackColor = True
        '
        'lbl名前2
        '
        Me.lbl名前2.AutoSize = True
        Me.lbl名前2.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl名前2.Location = New System.Drawing.Point(562, 43)
        Me.lbl名前2.Name = "lbl名前2"
        Me.lbl名前2.Size = New System.Drawing.Size(126, 72)
        Me.lbl名前2.TabIndex = 1019
        Me.lbl名前2.Text = "名前"
        '
        'btn完了
        '
        Me.btn完了.Enabled = False
        Me.btn完了.Location = New System.Drawing.Point(1183, 415)
        Me.btn完了.Name = "btn完了"
        Me.btn完了.Size = New System.Drawing.Size(120, 54)
        Me.btn完了.TabIndex = 102
        Me.btn完了.TabStop = False
        Me.btn完了.Text = "完了"
        Me.btn完了.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(256, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 72)
        Me.Label3.TabIndex = 1004
        Me.Label3.Text = "通番"
        '
        'txt通番2
        '
        Me.txt通番2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt通番2.Font = New System.Drawing.Font("メイリオ", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt通番2.Location = New System.Drawing.Point(409, 24)
        Me.txt通番2.MaxLength = 3
        Me.txt通番2.Name = "txt通番2"
        Me.txt通番2.Size = New System.Drawing.Size(130, 103)
        Me.txt通番2.TabIndex = 101
        Me.txt通番2.TabStop = False
        '
        'tp端末管理
        '
        Me.tp端末管理.Controls.Add(Me.btn削除)
        Me.tp端末管理.Controls.Add(Me.btn端末修正)
        Me.tp端末管理.Controls.Add(Me.bt追加)
        Me.tp端末管理.Controls.Add(Me.dgv)
        Me.tp端末管理.Location = New System.Drawing.Point(4, 57)
        Me.tp端末管理.Name = "tp端末管理"
        Me.tp端末管理.Padding = New System.Windows.Forms.Padding(3)
        Me.tp端末管理.Size = New System.Drawing.Size(1316, 483)
        Me.tp端末管理.TabIndex = 4
        Me.tp端末管理.Text = "端末管理"
        Me.tp端末管理.UseVisualStyleBackColor = True
        '
        'btn削除
        '
        Me.btn削除.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn削除.Location = New System.Drawing.Point(1087, 393)
        Me.btn削除.Name = "btn削除"
        Me.btn削除.Size = New System.Drawing.Size(140, 77)
        Me.btn削除.TabIndex = 10001
        Me.btn削除.TabStop = False
        Me.btn削除.Text = "削除"
        Me.btn削除.UseVisualStyleBackColor = True
        '
        'btn端末修正
        '
        Me.btn端末修正.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn端末修正.Location = New System.Drawing.Point(1087, 229)
        Me.btn端末修正.Name = "btn端末修正"
        Me.btn端末修正.Size = New System.Drawing.Size(140, 72)
        Me.btn端末修正.TabIndex = 10000
        Me.btn端末修正.TabStop = False
        Me.btn端末修正.Text = "修正"
        Me.btn端末修正.UseVisualStyleBackColor = True
        '
        'bt追加
        '
        Me.bt追加.Font = New System.Drawing.Font("メイリオ", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.bt追加.Location = New System.Drawing.Point(1087, 51)
        Me.bt追加.Name = "bt追加"
        Me.bt追加.Size = New System.Drawing.Size(140, 71)
        Me.bt追加.TabIndex = 9999
        Me.bt追加.TabStop = False
        Me.bt追加.Text = "追加"
        Me.bt追加.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.端末IP, Me.端末名, Me.用途, Me.グループ, Me.備考, Me.ID})
        Me.dgv.Location = New System.Drawing.Point(25, 51)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowTemplate.Height = 21
        Me.dgv.Size = New System.Drawing.Size(994, 419)
        Me.dgv.TabIndex = 9999
        Me.dgv.TabStop = False
        '
        '端末IP
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.端末IP.DefaultCellStyle = DataGridViewCellStyle1
        Me.端末IP.HeaderText = "端末IP"
        Me.端末IP.MaxInputLength = 15
        Me.端末IP.Name = "端末IP"
        Me.端末IP.ReadOnly = True
        Me.端末IP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.端末IP.Width = 200
        '
        '端末名
        '
        Me.端末名.HeaderText = "端末名"
        Me.端末名.Name = "端末名"
        Me.端末名.ReadOnly = True
        Me.端末名.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.端末名.Width = 150
        '
        '用途
        '
        Me.用途.HeaderText = "用途"
        Me.用途.Name = "用途"
        Me.用途.ReadOnly = True
        Me.用途.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'グループ
        '
        Me.グループ.HeaderText = "グループ"
        Me.グループ.Name = "グループ"
        Me.グループ.ReadOnly = True
        Me.グループ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        '備考
        '
        Me.備考.HeaderText = "備考"
        Me.備考.Name = "備考"
        Me.備考.ReadOnly = True
        Me.備考.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.備考.Width = 200
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ID.Visible = False
        '
        'tp表示
        '
        Me.tp表示.Controls.Add(Me.chkItem握力)
        Me.tp表示.Controls.Add(Me.chkItem座高)
        Me.tp表示.Controls.Add(Me.chkItem内科検診)
        Me.tp表示.Controls.Add(Me.chkItem聴力)
        Me.tp表示.Controls.Add(Me.chkItem身長体重)
        Me.tp表示.Controls.Add(Me.chkItem腹囲)
        Me.tp表示.Controls.Add(Me.chkItem検尿)
        Me.tp表示.Controls.Add(Me.chkItem血圧)
        Me.tp表示.Controls.Add(Me.chkItem視力)
        Me.tp表示.Controls.Add(Me.dgvResult)
        Me.tp表示.Controls.Add(Me.btn全選択解除)
        Me.tp表示.Location = New System.Drawing.Point(4, 57)
        Me.tp表示.Name = "tp表示"
        Me.tp表示.Padding = New System.Windows.Forms.Padding(3)
        Me.tp表示.Size = New System.Drawing.Size(1316, 483)
        Me.tp表示.TabIndex = 6
        Me.tp表示.Text = "結果表示"
        Me.tp表示.UseVisualStyleBackColor = True
        '
        'dgvResult
        '
        Me.dgvResult.AllowUserToAddRows = False
        Me.dgvResult.AllowUserToDeleteRows = False
        Me.dgvResult.ColumnHeadersHeight = 60
        Me.dgvResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.連番, Me.個人番号, Me.お名前, Me.裸眼右, Me.裸眼左, Me.矯正右, Me.矯正左})
        Me.dgvResult.Location = New System.Drawing.Point(32, 167)
        Me.dgvResult.Name = "dgvResult"
        Me.dgvResult.ReadOnly = True
        Me.dgvResult.RowTemplate.Height = 21
        Me.dgvResult.Size = New System.Drawing.Size(1207, 294)
        Me.dgvResult.TabIndex = 7
        Me.dgvResult.TabStop = False
        '
        '連番
        '
        Me.連番.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.連番.HeaderText = "連番"
        Me.連番.Name = "連番"
        Me.連番.ReadOnly = True
        Me.連番.Width = 109
        '
        '個人番号
        '
        Me.個人番号.HeaderText = "個人番号"
        Me.個人番号.Name = "個人番号"
        Me.個人番号.ReadOnly = True
        Me.個人番号.Width = 173
        '
        'お名前
        '
        Me.お名前.HeaderText = "お名前"
        Me.お名前.Name = "お名前"
        Me.お名前.ReadOnly = True
        Me.お名前.Width = 141
        '
        '裸眼右
        '
        Me.裸眼右.HeaderText = "裸眼右"
        Me.裸眼右.Name = "裸眼右"
        Me.裸眼右.ReadOnly = True
        Me.裸眼右.Width = 141
        '
        '裸眼左
        '
        Me.裸眼左.HeaderText = "裸眼左"
        Me.裸眼左.Name = "裸眼左"
        Me.裸眼左.ReadOnly = True
        Me.裸眼左.Width = 141
        '
        '矯正右
        '
        Me.矯正右.HeaderText = "矯正右"
        Me.矯正右.Name = "矯正右"
        Me.矯正右.ReadOnly = True
        Me.矯正右.Width = 141
        '
        '矯正左
        '
        Me.矯正左.HeaderText = "矯正左"
        Me.矯正左.Name = "矯正左"
        Me.矯正左.ReadOnly = True
        Me.矯正左.Width = 141
        '
        'btn全選択解除
        '
        Me.btn全選択解除.Location = New System.Drawing.Point(-4, 210)
        Me.btn全選択解除.Name = "btn全選択解除"
        Me.btn全選択解除.Size = New System.Drawing.Size(125, 49)
        Me.btn全選択解除.TabIndex = 6
        Me.btn全選択解除.TabStop = False
        Me.btn全選択解除.Text = "全選択"
        Me.btn全選択解除.UseVisualStyleBackColor = True
        Me.btn全選択解除.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnRenew)
        Me.TabPage1.Controls.Add(Me.dgvNonReceptionists)
        Me.TabPage1.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 57)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1316, 483)
        Me.TabPage1.TabIndex = 7
        Me.TabPage1.Text = "未受付一覧"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnRenew
        '
        Me.btnRenew.Location = New System.Drawing.Point(1168, 424)
        Me.btnRenew.Name = "btnRenew"
        Me.btnRenew.Size = New System.Drawing.Size(76, 36)
        Me.btnRenew.TabIndex = 9
        Me.btnRenew.Text = "更  新"
        Me.btnRenew.UseVisualStyleBackColor = True
        Me.btnRenew.Visible = False
        '
        'dgvNonReceptionists
        '
        Me.dgvNonReceptionists.AllowUserToAddRows = False
        Me.dgvNonReceptionists.AllowUserToDeleteRows = False
        Me.dgvNonReceptionists.ColumnHeadersHeight = 60
        Me.dgvNonReceptionists.Location = New System.Drawing.Point(32, 20)
        Me.dgvNonReceptionists.Name = "dgvNonReceptionists"
        Me.dgvNonReceptionists.ReadOnly = True
        Me.dgvNonReceptionists.RowTemplate.Height = 21
        Me.dgvNonReceptionists.Size = New System.Drawing.Size(1212, 600)
        Me.dgvNonReceptionists.TabIndex = 8
        Me.dgvNonReceptionists.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(825, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 52)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "健診受付"
        '
        'btn終了
        '
        Me.btn終了.Font = New System.Drawing.Font("メイリオ", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn終了.Location = New System.Drawing.Point(1214, 664)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(130, 66)
        Me.btn終了.TabIndex = 102
        Me.btn終了.TabStop = False
        Me.btn終了.Text = "終了"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'ep
        '
        Me.ep.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.受付管理.My.Resources.Resources.estSVlogo
        Me.PictureBox1.Location = New System.Drawing.Point(1085, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(253, 43)
        Me.PictureBox1.TabIndex = 1003
        Me.PictureBox1.TabStop = False
        '
        'dp
        '
        Me.dp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dp.Font = New System.Drawing.Font("メイリオ", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.dp.FormattingEnabled = True
        Me.dp.Location = New System.Drawing.Point(606, 19)
        Me.dp.Name = "dp"
        Me.dp.Size = New System.Drawing.Size(213, 52)
        Me.dp.TabIndex = 1004
        Me.dp.TabStop = False
        '
        'lbl取込総数
        '
        Me.lbl取込総数.AutoSize = True
        Me.lbl取込総数.Font = New System.Drawing.Font("メイリオ", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl取込総数.Location = New System.Drawing.Point(973, 26)
        Me.lbl取込総数.Name = "lbl取込総数"
        Me.lbl取込総数.Size = New System.Drawing.Size(74, 44)
        Me.lbl取込総数.TabIndex = 1005
        Me.lbl取込総数.Text = "000"
        '
        'cmb団体名
        '
        Me.cmb団体名.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb団体名.Font = New System.Drawing.Font("メイリオ", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb団体名.FormattingEnabled = True
        Me.cmb団体名.Location = New System.Drawing.Point(18, 21)
        Me.cmb団体名.Name = "cmb団体名"
        Me.cmb団体名.Size = New System.Drawing.Size(567, 49)
        Me.cmb団体名.TabIndex = 1006
        Me.cmb団体名.TabStop = False
        '
        'chk握力
        '
        Me.chk握力.checked = False
        Me.chk握力.Enabled = False
        Me.chk握力.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk握力.Location = New System.Drawing.Point(971, 281)
        Me.chk握力.Margin = New System.Windows.Forms.Padding(8)
        Me.chk握力.Name = "chk握力"
        Me.chk握力.Size = New System.Drawing.Size(262, 61)
        Me.chk握力.TabIndex = 1034
        Me.chk握力.TabStop = False
        '
        'chk座高
        '
        Me.chk座高.checked = False
        Me.chk座高.Enabled = False
        Me.chk座高.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk座高.Location = New System.Drawing.Point(365, 217)
        Me.chk座高.Margin = New System.Windows.Forms.Padding(8)
        Me.chk座高.Name = "chk座高"
        Me.chk座高.Size = New System.Drawing.Size(262, 61)
        Me.chk座高.TabIndex = 1033
        Me.chk座高.TabStop = False
        '
        'chkその他
        '
        Me.chkその他.checked = False
        Me.chkその他.Enabled = False
        Me.chkその他.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chkその他.Location = New System.Drawing.Point(971, 343)
        Me.chkその他.Margin = New System.Windows.Forms.Padding(8)
        Me.chkその他.Name = "chkその他"
        Me.chkその他.Size = New System.Drawing.Size(262, 61)
        Me.chkその他.TabIndex = 1032
        Me.chkその他.TabStop = False
        '
        'chk腹部エコー
        '
        Me.chk腹部エコー.checked = False
        Me.chk腹部エコー.Enabled = False
        Me.chk腹部エコー.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk腹部エコー.Location = New System.Drawing.Point(971, 155)
        Me.chk腹部エコー.Margin = New System.Windows.Forms.Padding(8)
        Me.chk腹部エコー.Name = "chk腹部エコー"
        Me.chk腹部エコー.Size = New System.Drawing.Size(262, 61)
        Me.chk腹部エコー.TabIndex = 1031
        Me.chk腹部エコー.TabStop = False
        '
        'chk眼底検査
        '
        Me.chk眼底検査.checked = False
        Me.chk眼底検査.Enabled = False
        Me.chk眼底検査.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk眼底検査.Location = New System.Drawing.Point(673, 343)
        Me.chk眼底検査.Margin = New System.Windows.Forms.Padding(8)
        Me.chk眼底検査.Name = "chk眼底検査"
        Me.chk眼底検査.Size = New System.Drawing.Size(262, 61)
        Me.chk眼底検査.TabIndex = 1030
        Me.chk眼底検査.TabStop = False
        '
        'chk心電図
        '
        Me.chk心電図.checked = False
        Me.chk心電図.Enabled = False
        Me.chk心電図.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk心電図.Location = New System.Drawing.Point(673, 281)
        Me.chk心電図.Margin = New System.Windows.Forms.Padding(8)
        Me.chk心電図.Name = "chk心電図"
        Me.chk心電図.Size = New System.Drawing.Size(262, 61)
        Me.chk心電図.TabIndex = 1029
        Me.chk心電図.TabStop = False
        '
        'chk採血
        '
        Me.chk採血.checked = False
        Me.chk採血.Enabled = False
        Me.chk採血.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk採血.Location = New System.Drawing.Point(971, 217)
        Me.chk採血.Margin = New System.Windows.Forms.Padding(8)
        Me.chk採血.Name = "chk採血"
        Me.chk採血.Size = New System.Drawing.Size(262, 61)
        Me.chk採血.TabIndex = 1028
        Me.chk採血.TabStop = False
        '
        'chk腹部X線
        '
        Me.chk腹部X線.checked = False
        Me.chk腹部X線.Enabled = False
        Me.chk腹部X線.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk腹部X線.Location = New System.Drawing.Point(673, 155)
        Me.chk腹部X線.Margin = New System.Windows.Forms.Padding(8)
        Me.chk腹部X線.Name = "chk腹部X線"
        Me.chk腹部X線.Size = New System.Drawing.Size(262, 61)
        Me.chk腹部X線.TabIndex = 1027
        Me.chk腹部X線.TabStop = False
        '
        'chk胸部X線
        '
        Me.chk胸部X線.checked = False
        Me.chk胸部X線.Enabled = False
        Me.chk胸部X線.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk胸部X線.Location = New System.Drawing.Point(365, 343)
        Me.chk胸部X線.Margin = New System.Windows.Forms.Padding(8)
        Me.chk胸部X線.Name = "chk胸部X線"
        Me.chk胸部X線.Size = New System.Drawing.Size(262, 61)
        Me.chk胸部X線.TabIndex = 1026
        Me.chk胸部X線.TabStop = False
        '
        'chk診察
        '
        Me.chk診察.checked = False
        Me.chk診察.Enabled = False
        Me.chk診察.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk診察.Location = New System.Drawing.Point(365, 281)
        Me.chk診察.Margin = New System.Windows.Forms.Padding(8)
        Me.chk診察.Name = "chk診察"
        Me.chk診察.Size = New System.Drawing.Size(262, 61)
        Me.chk診察.TabIndex = 1025
        Me.chk診察.TabStop = False
        '
        'chk尿検査
        '
        Me.chk尿検査.checked = False
        Me.chk尿検査.Enabled = False
        Me.chk尿検査.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk尿検査.Location = New System.Drawing.Point(673, 217)
        Me.chk尿検査.Margin = New System.Windows.Forms.Padding(8)
        Me.chk尿検査.Name = "chk尿検査"
        Me.chk尿検査.Size = New System.Drawing.Size(262, 61)
        Me.chk尿検査.TabIndex = 1024
        Me.chk尿検査.TabStop = False
        '
        'chk聴力
        '
        Me.chk聴力.checked = False
        Me.chk聴力.Enabled = False
        Me.chk聴力.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk聴力.Location = New System.Drawing.Point(365, 155)
        Me.chk聴力.Margin = New System.Windows.Forms.Padding(8)
        Me.chk聴力.Name = "chk聴力"
        Me.chk聴力.Size = New System.Drawing.Size(262, 61)
        Me.chk聴力.TabIndex = 1023
        Me.chk聴力.TabStop = False
        '
        'chk視力
        '
        Me.chk視力.checked = False
        Me.chk視力.Enabled = False
        Me.chk視力.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk視力.Location = New System.Drawing.Point(36, 343)
        Me.chk視力.Margin = New System.Windows.Forms.Padding(8)
        Me.chk視力.Name = "chk視力"
        Me.chk視力.Size = New System.Drawing.Size(262, 61)
        Me.chk視力.TabIndex = 1022
        Me.chk視力.TabStop = False
        '
        'chk腹囲
        '
        Me.chk腹囲.checked = False
        Me.chk腹囲.Enabled = False
        Me.chk腹囲.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk腹囲.Location = New System.Drawing.Point(36, 217)
        Me.chk腹囲.Margin = New System.Windows.Forms.Padding(8)
        Me.chk腹囲.Name = "chk腹囲"
        Me.chk腹囲.Size = New System.Drawing.Size(262, 61)
        Me.chk腹囲.TabIndex = 1021
        Me.chk腹囲.TabStop = False
        '
        'chk血圧
        '
        Me.chk血圧.checked = False
        Me.chk血圧.Enabled = False
        Me.chk血圧.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk血圧.Location = New System.Drawing.Point(36, 281)
        Me.chk血圧.Margin = New System.Windows.Forms.Padding(8)
        Me.chk血圧.Name = "chk血圧"
        Me.chk血圧.Size = New System.Drawing.Size(262, 61)
        Me.chk血圧.TabIndex = 1020
        Me.chk血圧.TabStop = False
        '
        'chk身長体重
        '
        Me.chk身長体重.checked = False
        Me.chk身長体重.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk身長体重.Location = New System.Drawing.Point(36, 155)
        Me.chk身長体重.Margin = New System.Windows.Forms.Padding(8)
        Me.chk身長体重.Name = "chk身長体重"
        Me.chk身長体重.Size = New System.Drawing.Size(296, 61)
        Me.chk身長体重.TabIndex = 1005
        Me.chk身長体重.TabStop = False
        '
        'chkItem握力
        '
        Me.chkItem握力.checked = False
        Me.chkItem握力.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chkItem握力.Location = New System.Drawing.Point(176, 100)
        Me.chkItem握力.Margin = New System.Windows.Forms.Padding(8)
        Me.chkItem握力.Name = "chkItem握力"
        Me.chkItem握力.Size = New System.Drawing.Size(168, 56)
        Me.chkItem握力.TabIndex = 10
        Me.chkItem握力.TabStop = False
        '
        'chkItem座高
        '
        Me.chkItem座高.checked = False
        Me.chkItem座高.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chkItem座高.Location = New System.Drawing.Point(711, 30)
        Me.chkItem座高.Margin = New System.Windows.Forms.Padding(8)
        Me.chkItem座高.Name = "chkItem座高"
        Me.chkItem座高.Size = New System.Drawing.Size(171, 56)
        Me.chkItem座高.TabIndex = 9
        Me.chkItem座高.TabStop = False
        '
        'chkItem内科検診
        '
        Me.chkItem内科検診.checked = False
        Me.chkItem内科検診.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chkItem内科検診.Location = New System.Drawing.Point(340, 100)
        Me.chkItem内科検診.Margin = New System.Windows.Forms.Padding(8)
        Me.chkItem内科検診.Name = "chkItem内科検診"
        Me.chkItem内科検診.Size = New System.Drawing.Size(217, 56)
        Me.chkItem内科検診.TabIndex = 8
        Me.chkItem内科検診.TabStop = False
        '
        'chkItem聴力
        '
        Me.chkItem聴力.checked = False
        Me.chkItem聴力.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chkItem聴力.Location = New System.Drawing.Point(23, 100)
        Me.chkItem聴力.Margin = New System.Windows.Forms.Padding(8)
        Me.chkItem聴力.Name = "chkItem聴力"
        Me.chkItem聴力.Size = New System.Drawing.Size(161, 56)
        Me.chkItem聴力.TabIndex = 5
        Me.chkItem聴力.TabStop = False
        '
        'chkItem身長体重
        '
        Me.chkItem身長体重.checked = False
        Me.chkItem身長体重.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chkItem身長体重.Location = New System.Drawing.Point(933, 30)
        Me.chkItem身長体重.Margin = New System.Windows.Forms.Padding(8)
        Me.chkItem身長体重.Name = "chkItem身長体重"
        Me.chkItem身長体重.Size = New System.Drawing.Size(217, 56)
        Me.chkItem身長体重.TabIndex = 4
        Me.chkItem身長体重.TabStop = False
        '
        'chkItem腹囲
        '
        Me.chkItem腹囲.checked = False
        Me.chkItem腹囲.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chkItem腹囲.Location = New System.Drawing.Point(509, 30)
        Me.chkItem腹囲.Margin = New System.Windows.Forms.Padding(8)
        Me.chkItem腹囲.Name = "chkItem腹囲"
        Me.chkItem腹囲.Size = New System.Drawing.Size(171, 56)
        Me.chkItem腹囲.TabIndex = 3
        Me.chkItem腹囲.TabStop = False
        '
        'chkItem検尿
        '
        Me.chkItem検尿.checked = False
        Me.chkItem検尿.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chkItem検尿.Location = New System.Drawing.Point(340, 30)
        Me.chkItem検尿.Margin = New System.Windows.Forms.Padding(8)
        Me.chkItem検尿.Name = "chkItem検尿"
        Me.chkItem検尿.Size = New System.Drawing.Size(170, 56)
        Me.chkItem検尿.TabIndex = 2
        Me.chkItem検尿.TabStop = False
        '
        'chkItem血圧
        '
        Me.chkItem血圧.checked = False
        Me.chkItem血圧.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chkItem血圧.Location = New System.Drawing.Point(176, 30)
        Me.chkItem血圧.Margin = New System.Windows.Forms.Padding(8)
        Me.chkItem血圧.Name = "chkItem血圧"
        Me.chkItem血圧.Size = New System.Drawing.Size(168, 56)
        Me.chkItem血圧.TabIndex = 1
        Me.chkItem血圧.TabStop = False
        '
        'chkItem視力
        '
        Me.chkItem視力.checked = False
        Me.chkItem視力.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chkItem視力.Location = New System.Drawing.Point(23, 30)
        Me.chkItem視力.Margin = New System.Windows.Forms.Padding(8)
        Me.chkItem視力.Name = "chkItem視力"
        Me.chkItem視力.Size = New System.Drawing.Size(170, 56)
        Me.chkItem視力.TabIndex = 0
        Me.chkItem視力.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1274, 735)
        Me.Controls.Add(Me.cmb団体名)
        Me.Controls.Add(Me.lbl取込総数)
        Me.Controls.Add(Me.dp)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tab)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn終了)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "受付管理"
        Me.tab.ResumeLayout(False)
        Me.tp健診受付.ResumeLayout(False)
        Me.tp健診受付.PerformLayout()
        Me.視力.ResumeLayout(False)
        Me.視力.PerformLayout()
        Me.tp通過管理.ResumeLayout(False)
        Me.tp通過管理.PerformLayout()
        Me.tp端末管理.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp表示.ResumeLayout(False)
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvNonReceptionists, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tab As System.Windows.Forms.TabControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn終了 As System.Windows.Forms.Button
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider
    Friend WithEvents tp通過管理 As System.Windows.Forms.TabPage
    Friend WithEvents txt通番2 As System.Windows.Forms.TextBox
    Friend WithEvents btn完了 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tp端末管理 As System.Windows.Forms.TabPage
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents lbl名前2 As System.Windows.Forms.Label
    Friend WithEvents bt追加 As System.Windows.Forms.Button
    Friend WithEvents btn端末修正 As System.Windows.Forms.Button
    Friend WithEvents btn削除 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dp As System.Windows.Forms.ComboBox
    Friend WithEvents chk身長体重 As 受付管理.chkPass
    Friend WithEvents chk血圧 As 受付管理.chkPass
    Friend WithEvents chk腹囲 As 受付管理.chkPass
    Friend WithEvents chk視力 As 受付管理.chkPass
    Friend WithEvents chk聴力 As 受付管理.chkPass
    Friend WithEvents chk尿検査 As 受付管理.chkPass
    Friend WithEvents chk診察 As 受付管理.chkPass
    Friend WithEvents chk胸部X線 As 受付管理.chkPass
    Friend WithEvents chk腹部X線 As 受付管理.chkPass
    Friend WithEvents chk採血 As 受付管理.chkPass
    Friend WithEvents chk心電図 As 受付管理.chkPass
    Friend WithEvents chk眼底検査 As 受付管理.chkPass
    Friend WithEvents chk腹部エコー As 受付管理.chkPass
    Friend WithEvents chkその他 As 受付管理.chkPass
    Friend WithEvents 端末IP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 端末名 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 用途 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents グループ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 備考 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 視力 As System.Windows.Forms.TabPage
    Friend WithEvents lbl名前視力 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb裸眼右 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl裸眼左 As System.Windows.Forms.Label
    Friend WithEvents lbl裸眼右 As System.Windows.Forms.Label
    Friend WithEvents cmb矯正左 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb矯正右 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl矯正左 As System.Windows.Forms.Label
    Friend WithEvents lbl矯正右 As System.Windows.Forms.Label
    Friend WithEvents cmb裸眼左 As System.Windows.Forms.ComboBox
    Friend WithEvents btn登録 As System.Windows.Forms.Button
    Friend WithEvents cmb通番視力 As System.Windows.Forms.ComboBox
    Friend WithEvents chkすべて表示 As System.Windows.Forms.CheckBox
    Friend WithEvents tp健診受付 As System.Windows.Forms.TabPage
    Friend WithEvents chkAuto As System.Windows.Forms.CheckBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lbl人数 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMsg2 As System.Windows.Forms.Label
    Friend WithEvents lblMsg1 As System.Windows.Forms.Label
    Friend WithEvents btnなし As System.Windows.Forms.Button
    Friend WithEvents btn修正 As System.Windows.Forms.Button
    Friend WithEvents txt修正 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt通番 As System.Windows.Forms.TextBox
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents lbl取込総数 As System.Windows.Forms.Label
    Friend WithEvents tp表示 As System.Windows.Forms.TabPage
    Friend WithEvents btn全選択解除 As System.Windows.Forms.Button
    Friend WithEvents dgvResult As System.Windows.Forms.DataGridView
    Friend WithEvents 連番 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 個人番号 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents お名前 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 裸眼右 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 裸眼左 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 矯正右 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 矯正左 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkItem内科検診 As 受付管理.chkPass
    Friend WithEvents chkItem聴力 As 受付管理.chkPass
    Friend WithEvents chkItem身長体重 As 受付管理.chkPass
    Friend WithEvents chkItem腹囲 As 受付管理.chkPass
    Friend WithEvents chkItem検尿 As 受付管理.chkPass
    Friend WithEvents chkItem血圧 As 受付管理.chkPass
    Friend WithEvents chkItem視力 As 受付管理.chkPass
    Friend WithEvents chkItem座高 As 受付管理.chkPass
    Friend WithEvents chk座高 As 受付管理.chkPass
    Friend WithEvents chk握力 As 受付管理.chkPass
    Friend WithEvents chkItem握力 As 受付管理.chkPass
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgvNonReceptionists As System.Windows.Forms.DataGridView
    Friend WithEvents btnRenew As System.Windows.Forms.Button
    Friend WithEvents cmb団体名 As System.Windows.Forms.ComboBox

End Class
