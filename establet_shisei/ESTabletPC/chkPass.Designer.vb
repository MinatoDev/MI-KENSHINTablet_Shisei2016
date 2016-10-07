<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chkPass
    Inherits System.Windows.Forms.UserControl

    'UserControl はコンポーネント一覧をクリーンアップするために dispose をオーバーライドします。
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
        Me.lbl済 = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl済
        '
        Me.lbl済.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl済.Font = New System.Drawing.Font("メイリオ", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl済.ForeColor = System.Drawing.Color.Red
        Me.lbl済.Location = New System.Drawing.Point(8, 4)
        Me.lbl済.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lbl済.Name = "lbl済"
        Me.lbl済.Size = New System.Drawing.Size(53, 47)
        Me.lbl済.TabIndex = 1
        Me.lbl済.Text = "済"
        '
        'lblText
        '
        Me.lblText.Font = New System.Drawing.Font("メイリオ", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblText.Location = New System.Drawing.Point(64, 5)
        Me.lblText.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(264, 48)
        Me.lblText.TabIndex = 2
        Me.lblText.Text = "身長・体重"
        '
        'chkPass
        '
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.lbl済)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "chkPass"
        Me.Size = New System.Drawing.Size(336, 56)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl済 As System.Windows.Forms.Label
    Friend WithEvents lblText As System.Windows.Forms.Label

End Class
