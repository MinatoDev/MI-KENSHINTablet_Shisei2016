Option Explicit On

Imports System.Data.Odbc

Public Class db
    Public con As OdbcConnection
    Public tran As OdbcTransaction
    Public server As String
    Public dbname As String

    Public Function connect(ByRef errmsg As String) As Boolean
        Dim constr As String = String.Empty
        Dim datasetting As DBSettings = New DBSettings

        ReadDBSetting(datasetting)
        connect = True
        constr = ""
        constr += ";DSN=" + datasetting.DSN
        constr += ";Database=" + datasetting.Database
        constr += ";UID=" + datasetting.UID
        constr += ";PWD=" + datasetting.PWD

        If con Is Nothing Then
            con = New OdbcConnection
        End If
        con.ConnectionString = constr

        Try
            ' データベース接続を開く
            con.Open()
            If Not con.State = ConnectionState.Open Then
                Throw New DBErrorException("データベースに接続できません。")
            End If

        Catch ex As DBErrorException
            errmsg = "データベースに接続できません。" + ex.Message
            Return False
        Catch ex As Exception
            errmsg = "データベースに接続できません。" + ex.Message
            Return False
        End Try
        Return True
    End Function
    Public Function close() As Boolean
        Try
            If Not IsNothing(con) Then
                con.Close()
                con.Dispose()
                con = Nothing
            End If
        Catch ex As ApplicationException
            Throw New ApplicationException(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Public Function starttrn(ByRef errmsg As String) As Boolean
        tran = Nothing
        Try
            tran = con.BeginTransaction(IsolationLevel.ReadCommitted)
            If IsNothing(tran) Then
                Throw New DBErrorException("トランザクションが開始できません。")
            End If
        Catch ex As DBErrorException
            errmsg = ex.Message
            Return False
        Catch ex As Exception
            errmsg = ex.Message
            Return False
        End Try
        Return True
    End Function

    Public Function committrn() As Boolean
        Try
            tran.Commit()
            tran.Dispose()
        Catch ex As EvaluateException
            Return False
        End Try
        Return True
    End Function

    Public Function rollbacktran() As Boolean
        Try
            tran.Rollback()
            tran.Dispose()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function execNonQ(ByVal comstr As String, ByRef errmsg As String) As Boolean
        Try
            Dim sqlcmd As New OdbcCommand(comstr, con)
            'Dim sqlcmd As New OdbcCommand(comstr, con, tran)
            Dim adapter As New OdbcDataAdapter(sqlcmd)

            sqlcmd = con.CreateCommand
            sqlcmd.CommandTimeout = 300
            sqlcmd.CommandText = comstr
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            errmsg = ex.Message + vbCrLf + comstr
            Return False
        End Try
        Return True
    End Function

    Public Function execNonQTran(ByVal comstr As String, ByRef errmsg As String) As Boolean
        Try
            Dim sqlcmd As New OdbcCommand(comstr, con)

            sqlcmd = con.CreateCommand
            sqlcmd.CommandTimeout = 300
            sqlcmd.CommandText = comstr

            sqlcmd.Transaction = tran
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            errmsg = ex.Message + vbCrLf + comstr
            Return False
        End Try
        Return True
    End Function


    Public Function ExecuteSql(ByVal sql As String, Optional ByVal tot As Integer = -1) As DataTable
        Dim dt As New DataTable

        Try
            Dim sqlCommand As New OdbcCommand(sql, con, tran)
            Dim adapter As New OdbcDataAdapter(sqlCommand)

            adapter.Fill(dt)
            adapter.Dispose()
            sqlCommand.Dispose()
        Catch ex As Exception
            Return Nothing
        End Try

        Return dt
    End Function

End Class

Public Class DBSettings
    Private _DSN As String
    Private _Database As String
    Private _UID As String
    Private _PWD As String

    Public Property DSN() As String
        Get
            Return _DSN
        End Get
        Set(ByVal Value As String)
            _DSN = Value
        End Set
    End Property

    Public Property Database() As String
        Get
            Return _Database
        End Get
        Set(ByVal Value As String)
            _Database = Value
        End Set
    End Property

    Public Property UID() As String
        Get
            Return _UID
        End Get
        Set(ByVal Value As String)
            _UID = Value
        End Set
    End Property

    Public Property PWD() As String
        Get
            Return _PWD
        End Get
        Set(ByVal Value As String)
            _PWD = Value
        End Set
    End Property
End Class
