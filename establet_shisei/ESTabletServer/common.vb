Option Explicit On

Module common__

    'ネットワークドライブへの接続
    Public Declare Function WNetAddConnection Lib "mpr.dll" Alias "WNetAddConnectionA" (ByVal lpRemoteName As String, ByVal lpPassword As String, ByVal lpLocalName As String) As Integer
    'ネットワークドライブの切断
    '第2引数は、Windows終了時に接続を回復するかどうかを表す
    'Falseは、回復することを意味する
    Public Declare Function WNetCancelConnection Lib "mpr.dll" Alias "WNetCancelConnectionA" (ByVal lpName As String, Optional ByVal fForce As Boolean = False) As Boolean

    '*************************************************
    ' UDEX-i(血圧)送信コマンド                       *
    '*************************************************
    Public Const UDEX_COMMAND1 As String = Chr(&H2) + Chr(&H5) + Chr(&H3)
    Public Const UDEX_COMMAND2 As String = Chr(&H2) + Chr(&H41) + Chr(&H3)
    Public Const UDEX_COMMAND3 As String = Chr(&H2) + Chr(&H42) + Chr(&H3)
    Public Const UDEX_COMMAND4 As String = Chr(&H2) + Chr(&H54) + Chr(&H3)
    Public Const UDEX_COMMAND5 As String = Chr(&H2) + Chr(&H59) + Chr(&H3)
    Public Const UDEX_COMMAND6 As String = Chr(&H2) + Chr(&H43) + Chr(&H3)
    Public Const UDEX_COMMAND7 As String = Chr(&H2) + Chr(&H53) + Chr(&H3)
    Public Const UDEX_COMMAND8 As String = Chr(&H2) + Chr(&H52) + Chr(&H3)
    Public Const UDEX_COMMAND9 As String = Chr(&H2) + Chr(&H5A) + Chr(&H3)
    Public Const UDEX_COMMAND10 As String = Chr(&H2) + Chr(&H48) + Chr(&H3)
    Public Const UDEX_COMMAND11 As String = Chr(&H2) + Chr(&H55) + Chr(&H3)
    '*************************************************
    ' AD-6350送信コマンド                            *
    '*************************************************
    Public Const COMMAND6350_SY As String = Chr(&H2) + "SY" + Chr(&H3)  '身長データ出力
    Public Const COMMAND6350_ZK As String = Chr(&H2) + "ZK" + Chr(&H3)  '座高データ出力
    Public Const COMMAND6350_TZ As String = Chr(&H2) + "TZ" + Chr(&H3)  '体重データ出力
    Public Const COMMAND6350_ST As String = Chr(&H2) + "ST" + Chr(&H3)  '身長・体重データ出力
    Public Const COMMAND6350_MS As String = Chr(&H2) + "MS" + Chr(&H3)  '身長・体重計状態出力コマンド


    Public Const unkownError As String = "不明なエラーが発生しました。"
    Public Const OverRangeMsg As String = "%%が設定された値を超えています。" + vbCrLf + "このまま登録を続行しますか？"

    '*************************************************
    ' Left,Mid,Right いちいち書くの面倒だから        *
    '*************************************************
    Public Function Left_(ByVal str As String, ByVal pos As Integer) As String
        Return Microsoft.VisualBasic.Left(str, pos)
    End Function

    Public Function Mid_(ByVal str As String, ByVal pos As Integer, ByVal len As Integer) As String
        Return Microsoft.VisualBasic.Mid(str, pos, len)
    End Function

    Public Function Right_(ByVal str As String, ByVal pos As Integer) As String
        Return Microsoft.VisualBasic.Right(str, pos)
    End Function


    Public Sub ReadDBSetting(ByRef datasetting As DBSettings)

        '保存先のファイル名
        Dim fileName As String = System.IO.Directory.GetCurrentDirectory() + "\db.config"

        '＜XMLファイルから読み込む＞
        'XmlSerializerオブジェクトの作成
        Dim serializer2 As New System.Xml.Serialization.XmlSerializer(GetType(DBSettings))
        'ファイルを開く
        Dim fs2 As New System.IO.FileStream(fileName, System.IO.FileMode.Open)
        'XMLファイルから読み込み、逆シリアル化する
        datasetting = CType(serializer2.Deserialize(fs2), DBSettings)
        '閉じる
        fs2.Close()
    End Sub


    'ファイルエラーのクラス
    Class FileException
        Inherits Exception
        Public Sub New(ByVal msg As String)
            MyBase.New(msg)
        End Sub
    End Class

    'DBエラーのクラス
    Class DBErrorException
        Inherits Exception
        Public Sub New(ByVal msg As String)
            MyBase.New(msg)
        End Sub
    End Class

    'データなしエラーのクラス
    Class NoDataException
        Inherits Exception
        Public Sub New(ByVal msg As String)
            MyBase.New(msg)
        End Sub
    End Class

    '未入力エラーのクラス
    Class No_InputException
        Inherits Exception
        Public Sub New(ByVal msg As String)
            MyBase.New(msg)
        End Sub
    End Class

    '書式エラーのクラス
    Class FormatException
        Inherits Exception
        Public Sub New(ByVal msg As String)
            MyBase.New(msg)
        End Sub
    End Class

    '閾値エラーのクラス
    Class OutOfRangeException
        Inherits Exception
        Public Sub New(ByVal msg As String)
            MyBase.New(msg)
        End Sub
    End Class


End Module
