Imports System.Runtime.InteropServices

Public Class chkPass
    Inherits UserControl

    Public title As String
    Public chkchar As String
    Public report As Boolean = False
    Public callhandle As IntPtr = 0
    Private Const WM_USER = &H400


    Private _checked As Integer = 0

   <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    Public Property checked() As Boolean
        Get
            Return _checked
        End Get

        Set(ByVal value As Boolean)
            _checked = value
            If value Then
                Me.lbl済.Text = Me.chkchar
            Else
                Me.lbl済.Text = ""
            End If
        End Set
    End Property

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        report = False
    End Sub


    Private Sub itemClick(sender As System.Object, e As System.EventArgs) Handles lblText.Click, lbl済.Click
        If checked Then
            checked = False
            lbl済.Text = ""
        Else
            checked = True
            lbl済.Text = Me.chkchar
        End If

        If callhandle <> 0 Then
            SendMessage(callhandle, WM_USER + 1, 0, Me.Handle)
        End If
    End Sub

    Private Sub chkPass_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.lblText.Text = title
        If Me.checked Then
            Me.lbl済.Text = chkchar
        Else
            Me.lbl済.Text = ""
        End If
    End Sub

End Class
