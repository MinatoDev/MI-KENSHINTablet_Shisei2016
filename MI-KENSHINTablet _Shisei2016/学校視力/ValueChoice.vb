﻿
Public Class ValueChoice

    Private Property Caller As Label

    Public Property ItemName As String = String.Empty

    Public Sub New(sender As Label)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Caller = sender

        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click, btnB.Click, btnC.Click, btnD.Click, btnClear.Click
        If DirectCast(sender, Button).Name = "btnClear" Then
            Caller.Text = String.Empty
        Else
            Caller.Text = DirectCast(sender, Button).Text
        End If
        Me.Close()
    End Sub

    Private Sub ValueChoice_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblItem.Text = ItemName
    End Sub
End Class