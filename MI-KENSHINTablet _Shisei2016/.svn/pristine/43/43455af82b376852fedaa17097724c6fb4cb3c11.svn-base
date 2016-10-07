''' <summary>
''' 個人表示用コントロール
''' </summary>
''' <remarks></remarks>
Public Class Person

    Public Property PersonID As String

    ''' <summary>
    ''' 個人が選択されたイベント定義
    ''' </summary>
    ''' <param name="tuban">通番</param>
    ''' <param name="name">氏名</param>
    ''' <remarks></remarks>
    Public Event PersonSelected(personId As String, tuban As String, name As String)

    ''' <summary>
    ''' イベントを発生させる
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Sub Clicked(sender As Object, e As EventArgs) Handles lblTuban.Click, lblName.Click
        RaiseEvent PersonSelected(PersonID, lblTuban.Text, StrConv(lblName.Text, VbStrConv.Wide))
    End Sub

End Class

