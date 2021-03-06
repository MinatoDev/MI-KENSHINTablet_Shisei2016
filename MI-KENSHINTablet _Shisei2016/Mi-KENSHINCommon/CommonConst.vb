﻿''' <summary>
''' 共通定数クラス
''' </summary>
''' <remarks></remarks>
Public Class CommonConst

#Region "検診項目"
    Public Const SIRYOKU = "視力"
    Public Const SIRYOKU_SCHOOL = "学校視力"
    Public Const KETSUATSU = "血圧"
    Public Const SHINSATSU = "診察"
    Public Const CHYOURYOKU = "聴力"
    Public Const FUKUI = "腹囲"
    Public Const KENNYOU = "検尿"
    Public Const AKURYOKU = "握力"
    Public Const HEIGHT = "身長"
    Public Const WEIGHT = "体重"
#End Region

#Region "メッセージ"
    Public Const REGIST_COMP = "登録しました。"
    Public Const DONOT_CONNECT = "データベースに接続できませんでした。"
    Public Const OVER_RANGE As String = "%%が設定された値を超えています。このまま登録を続行しますか？"
    Public Const NEED_SECOND As String = "２回目の測定が必要です。"
    Public Const NO_PERSON As String = "受診者が一人もいません。" + vbCrLf + "終了します。"
    Public Const REGIST_QUESTION As String = "登録します、よろしいですか？"
    Public Const QUIT_QUESTION As String = "終了します、よろしいですか？"
#End Region

#Region "メッセージ応答"
    Public Const OK_ONLY As String = "OK"
    Public Const YES_NO As String = "YES_NO"
    Public Const OK As String = "OK"
    Public Const YES As String = "YES"
    Public Const NO As String = "NO"
#End Region

#Region "メッセージアイコン"
    Public Const INFO As String = "Information"
    Public Const QUESTION As String = "Question"
    Public Const EXCLAMATION As String = "Exclamation"
#End Region

#Region "その他"
    Public Const UNDER_01 = "0.1未満"
#End Region

End Class


