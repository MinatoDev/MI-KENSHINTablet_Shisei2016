<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Person
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
        Me.lblTuban = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTuban
        '
        Me.lblTuban.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTuban.Font = New System.Drawing.Font("MS UI Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTuban.Location = New System.Drawing.Point(3, 0)
        Me.lblTuban.Name = "lblTuban"
        Me.lblTuban.Size = New System.Drawing.Size(77, 71)
        Me.lblTuban.TabIndex = 0
        Me.lblTuban.Text = "999"
        Me.lblTuban.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblName.Font = New System.Drawing.Font("MS UI Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblName.Location = New System.Drawing.Point(86, 1)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(85, 71)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "999"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Person
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTuban)
        Me.Name = "Person"
        Me.Size = New System.Drawing.Size(88, 73)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTuban As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label

End Class
