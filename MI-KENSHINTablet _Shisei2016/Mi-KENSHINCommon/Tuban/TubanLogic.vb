﻿Imports System.Windows.Forms
Imports System.Configuration.ConfigurationManager
Imports Dac
Imports Dac.Tables
Imports Mi_KENSHINCommon

''' <summary>
''' 通番ロジッククラス
''' </summary>
''' <remarks></remarks>
Public Class TubanLogic

#Region "プロパティ"
    ''' <summary>
    ''' 個人リスト
    ''' </summary>
    Private Property Persons As List(Of Person) = New List(Of Person)


    ''' <summary>
    ''' DB接続情報
    ''' </summary>
    Public Property ConnectionInfo As List(Of String) = New List(Of String)
#End Region

#Region "通番リストを表示する"
    ''' <summary>
    ''' 通番リストを表示する
    ''' </summary>
    ''' <param name="flp"></param>
    ''' <param name="kenshinName"></param>
    ''' <param name="flg"></param>
    ''' <remarks></remarks>
    Public Sub DisplayList(flp As FlowLayoutPanel, kenshinName As String, flg As Boolean)
        Dim Dac As DBAccess = New DBAccess()
        Dac.ConnectInfo = ConnectionInfo

        Dim dbPerson As List(Of 被験者) = Dac.GetPersonList(kenshinName)

        ClearList()

        For Each psn In dbPerson
            Dim person As Person = New Person
            person.PersonID = psn.依頼者KEY
            person.lblTuban.Text = psn.日通番.ToString
            person.lblName.Text = psn.被験者名

            Dim wkKenshin As String = String.Empty
            Select Case kenshinName
                Case CommonConst.SIRYOKU, CommonConst.SIRYOKU_SCHOOL
                    wkKenshin = psn.視力終了
                Case CommonConst.KETSUATSU
                    wkKenshin = psn.血圧終了
                Case CommonConst.SHINSATSU
                    wkKenshin = psn.診察終了
                Case CommonConst.CHYOURYOKU
                    wkKenshin = psn.聴力終了
                Case CommonConst.FUKUI
                    wkKenshin = psn.腹囲終了
                Case CommonConst.KENNYOU
                    wkKenshin = psn.尿検査終了
                Case CommonConst.AKURYOKU
                    wkKenshin = psn.握力終了
                Case CommonConst.HEIGHT, "身長・体重・腹囲"
                    wkKenshin = psn.身長体重終了
                Case Else

            End Select

            Persons.Add(person)

            ' 受診済かどうかで色を変える
            If wkKenshin.Equals("N") Then
                person.BackColor = Drawing.Color.Beige
                person.lblTuban.BackColor = Drawing.Color.Beige
                person.lblName.BackColor = Drawing.Color.Beige
                person.Visible = True
            Else
                person.BackColor = Drawing.Color.LightPink
                person.lblTuban.BackColor = Drawing.Color.LightPink
                person.lblName.BackColor = Drawing.Color.LightPink
                If Not flg Then
                    person.Visible = False
                    Continue For
                End If
            End If

        Next

        For Each cntl In Persons
            flp.Controls.Add(cntl)
        Next

    End Sub

#End Region

#Region "リストを破棄する。"
    ''' <summary>
    ''' リストを破棄する。
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ClearList()
        For Each cntl In Persons
            cntl.Dispose()
        Next
    End Sub

#End Region

    Friend Function InputCharValidation(KeyChar As String)
        Dim ret As Boolean = True

        Select Case KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"   '0～9
            Case ControlChars.Back
            Case ControlChars.Cr
            Case Else
                ret = False
        End Select
        Return ret
    End Function

    Friend Function ExitsTuban(tsuban As String) As String
        Dim ret As String = String.Empty
        Dim Dac As DBAccess = New DBAccess()

        Dim com As Common = New Common
        Dim config As Config = com.ReadConfig
        ConnectionInfo.Add(config.DSN)
        ConnectionInfo.Add(config.DBName)
        ConnectionInfo.Add(config.UserName)
        ConnectionInfo.Add(config.Password)

        Dac.ConnectInfo = ConnectionInfo

        If tsuban = "0" OrElse tsuban = String.Empty Then
            ret = String.Empty
        Else
            Dim dbPerson As 被験者 = Dac.GetPersonByTuban(tsuban)

            If dbPerson Is Nothing Then
                ret = String.Empty
            Else
                ret = dbPerson.依頼者KEY & "," & dbPerson.被験者名.Trim
            End If
        End If

        Return ret
    End Function

End Class

