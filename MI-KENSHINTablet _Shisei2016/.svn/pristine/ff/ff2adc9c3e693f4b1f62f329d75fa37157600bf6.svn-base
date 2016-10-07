Imports Dac

Public Class Common

    '未入力エラーのクラス
    Class No_InputException
        Inherits Exception
        Public Sub New(ByVal msg As String)
            MyBase.New(msg)
        End Sub
    End Class

    Class AbnormalValueException
        Inherits Exception
        Public Sub New(ByVal msg As String)
            MyBase.New(msg)
        End Sub
    End Class

    Class NeedSecondMeasurementException
        Inherits Exception
        Public Sub New(ByVal msg As String)
            MyBase.New(msg)
        End Sub
    End Class

    Class KenshinCodeNotFoundException
        Inherits Exception
        Public Sub New(ByVal msg As String)
            MyBase.New(msg)
        End Sub
    End Class


    Public Sub SaveConfig(data As Config)
        'ConfigオブジェクトをXMLファイルに保存する
        '保存先のファイル名
        Dim fileName As String = "..\..\..\Mi-Kenshin.config"

        'XmlSerializerオブジェクトを作成
        'オブジェクトの型を指定する
        Dim serializer As New System.Xml.Serialization.XmlSerializer(GetType(Config))
        '書き込むファイルを開く（UTF-8 BOM無し）
        Using writer As New System.IO.StreamWriter(fileName, False, New System.Text.UTF8Encoding(False))
            'シリアル化し、XMLファイルに保存する
            serializer.Serialize(writer, data)
        End Using
    End Sub

    Public Function ReadConfig() As Config
        'XMLファイルをSampleClassオブジェクトに復元する
        '保存元のファイル名
        Dim fileName As String = "..\..\..\Mi-Kenshin.config"

        'XmlSerializerオブジェクトを作成
        Try
            Dim serializer As New System.Xml.Serialization.XmlSerializer(GetType(Config))
            '読み込むファイルを開く
            Using reader As New System.IO.StreamReader(fileName, New System.Text.UTF8Encoding(False))
                Dim data As Config = DirectCast(serializer.Deserialize(reader), Config)
                Return data
            End Using

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class
