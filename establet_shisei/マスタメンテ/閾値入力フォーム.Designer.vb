<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 閾値入力フォーム
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
        Me.btn決定 = New System.Windows.Forms.Button()
        Me.btn戻る = New System.Windows.Forms.Button()
        Me.lbl最高 = New System.Windows.Forms.Label()
        Me.lbl最低 = New System.Windows.Forms.Label()
        Me.lbl名称 = New System.Windows.Forms.Label()
        Me.txt最高 = New System.Windows.Forms.TextBox()
        Me.txt最低 = New System.Windows.Forms.TextBox()
        Me.txt名称 = New System.Windows.Forms.TextBox()
        Me.ep = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn決定
        '
        Me.btn決定.Location = New System.Drawing.Point(173, 286)
        Me.btn決定.Name = "btn決定"
        Me.btn決定.Size = New System.Drawing.Size(96, 45)
        Me.btn決定.TabIndex = 4
        Me.btn決定.Text = "決定"
        Me.btn決定.UseVisualStyleBackColor = True
        '
        'btn戻る
        '
        Me.btn戻る.Location = New System.Drawing.Point(314, 286)
        Me.btn戻る.Name = "btn戻る"
        Me.btn戻る.Size = New System.Drawing.Size(96, 45)
        Me.btn戻る.TabIndex = 5
        Me.btn戻る.Text = "戻る"
        Me.btn戻る.UseVisualStyleBackColor = True
        '
        'lbl最高
        '
        Me.lbl最高.Font = New System.Drawing.Font("メイリオ", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl最高.Location = New System.Drawing.Point(61, 188)
        Me.lbl最高.Name = "lbl最高"
        Me.lbl最高.Size = New System.Drawing.Size(96, 31)
        Me.lbl最高.TabIndex = 18
        Me.lbl最高.Text = "最高"
        Me.lbl最高.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl最低
        '
        Me.lbl最低.Font = New System.Drawing.Font("メイリオ", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl最低.Location = New System.Drawing.Point(61, 115)
        Me.lbl最低.Name = "lbl最低"
        Me.lbl最低.Size = New System.Drawing.Size(96, 31)
        Me.lbl最低.TabIndex = 17
        Me.lbl最低.Text = "最低"
        Me.lbl最低.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl名称
        '
        Me.lbl名称.Font = New System.Drawing.Font("メイリオ", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl名称.Location = New System.Drawing.Point(56, 47)
        Me.lbl名称.Name = "lbl名称"
        Me.lbl名称.Size = New System.Drawing.Size(101, 31)
        Me.lbl名称.TabIndex = 15
        Me.lbl名称.Text = "名称"
        Me.lbl名称.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt最高
        '
        Me.txt最高.Font = New System.Drawing.Font("メイリオ", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt最高.Location = New System.Drawing.Point(204, 186)
        Me.txt最高.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt最高.MaxLength = 10
        Me.txt最高.Name = "txt最高"
        Me.txt最高.Size = New System.Drawing.Size(194, 36)
        Me.txt最高.TabIndex = 3
        '
        'txt最低
        '
        Me.txt最低.Font = New System.Drawing.Font("メイリオ", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt最低.Location = New System.Drawing.Point(204, 115)
        Me.txt最低.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt最低.MaxLength = 10
        Me.txt最低.Name = "txt最低"
        Me.txt最低.Size = New System.Drawing.Size(194, 36)
        Me.txt最低.TabIndex = 1
        '
        'txt名称
        '
        Me.txt名称.Font = New System.Drawing.Font("メイリオ", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt名称.Location = New System.Drawing.Point(204, 42)
        Me.txt名称.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt名称.MaxLength = 20
        Me.txt名称.Name = "txt名称"
        Me.txt名称.Size = New System.Drawing.Size(194, 36)
        Me.txt名称.TabIndex = 0
        '
        'ep
        '
        Me.ep.ContainerControl = Me
        '
        '閾値入力フォーム
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 394)
        Me.Controls.Add(Me.txt名称)
        Me.Controls.Add(Me.btn決定)
        Me.Controls.Add(Me.btn戻る)
        Me.Controls.Add(Me.lbl最高)
        Me.Controls.Add(Me.lbl最低)
        Me.Controls.Add(Me.lbl名称)
        Me.Controls.Add(Me.txt最高)
        Me.Controls.Add(Me.txt最低)
        Me.Name = "閾値入力フォーム"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "閾値入力フォーム"
        CType(Me.ep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn決定 As System.Windows.Forms.Button
    Friend WithEvents btn戻る As System.Windows.Forms.Button
    Friend WithEvents lbl最高 As System.Windows.Forms.Label
    Friend WithEvents lbl最低 As System.Windows.Forms.Label
    Friend WithEvents lbl名称 As System.Windows.Forms.Label
    Friend WithEvents txt最高 As System.Windows.Forms.TextBox
    Friend WithEvents txt最低 As System.Windows.Forms.TextBox
    Friend WithEvents txt名称 As System.Windows.Forms.TextBox
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider
End Class
