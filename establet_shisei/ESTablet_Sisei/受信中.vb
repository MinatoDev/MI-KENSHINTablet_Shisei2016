Public Class 受信中
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Me.ControlBox = False
        Me.Text = ""

    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        計測.sp.Close()
        計測.btn身長計測.Enabled = True
        計測.btn血圧計測.Enabled = True
        Me.Close()
        Me.Dispose()
    End Sub
End Class