Imports IWshRuntimeLibrary
Imports System.Runtime.InteropServices
Imports System.IO

Public Class Installer

#Region "イベント"
    ''' <summary>
    ''' 開始クリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

            'マイドキュメントにコピー
            Dim InstallDir As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\Mi-KenshinTablet"
            If Not System.IO.Directory.Exists(InstallDir) Then
                System.IO.Directory.CreateDirectory(InstallDir)
            Else
            ' 削除ディレクトリ情報を取得
            Dim delDir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(InstallDir)

            '' サブディレクトリ内も含めすべてのファイルを取得する
            'Dim fileInfos() As System.IO.FileSystemInfo =
            '    delDir.GetFileSystemInfos("*", System.IO.SearchOption.AllDirectories)

            '' ファイル属性から読み取り専用属性を外す
            'For Each fileInfo As System.IO.FileSystemInfo In fileInfos

            '    ' ディレクトリまたはファイルであるかを判断する
            '    If ((fileInfo.Attributes And System.IO.FileAttributes.Directory) = System.IO.FileAttributes.Directory) Then
            '        ' ディレクトリの場合
            '        fileInfo.Attributes = System.IO.FileAttributes.Directory
            '    Else
            '        ' ファイルの場合
            '        fileInfo.Attributes = System.IO.FileAttributes.Normal
            '    End If
            'Next

            ' ディレクトリを削除（サブディレクトリを含む）
            delDir.Delete(True)

        End If

            My.Computer.FileSystem.CopyDirectory(".\Mi-Kenshin", InstallDir, FileIO.UIOption.AllDialogs, FileIO.UICancelOption.DoNothing)

            'ショートカットをデスクトップに作成
            Dim linkName As String = "検診.lnk"
            MakeShortCut(InstallDir & "\login\bin\Release\", linkName)

            'スタートアップに登録
            Dim deskTop As String = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\"
            Dim startUp As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\"
            System.IO.File.Copy(deskTop & linkName, startUp & linkName, True)
            MessageBox.Show("完了")

    End Sub

    ''' <summary>
    ''' 終了ボタンクリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Me.Close()
        Me.Dispose()
    End Sub
#End Region

#Region "ショートカット作成"
    ''' <summary>
    ''' ショートカット作成
    ''' </summary>
    ''' <param name="path"></param>
    ''' <remarks></remarks>
    Private Sub MakeShortCut(path As String, linkName As String)
        '作成するショートカットのパス 
        Dim shortcutPath As String = System.IO.Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory), linkName)
        'ショートカットのリンク先 
        Dim targetPath As String = path & "login.exe"

        'WshShellを作成 
        Dim shell As New IWshRuntimeLibrary.WshShell()
        'ショートカットのパスを指定して、WshShortcutを作成 
        Dim shortcut As IWshRuntimeLibrary.IWshShortcut = DirectCast(shell.CreateShortcut(shortcutPath), IWshRuntimeLibrary.IWshShortcut)
        'リンク先 
        shortcut.TargetPath = targetPath
        'コマンドパラメータ 「リンク先」の後ろに付く 
        shortcut.Arguments = String.Empty
        '作業フォルダ 
        shortcut.WorkingDirectory = path
        'ショートカットキー（ホットキー） 
        shortcut.Hotkey = String.Empty
        '実行時の大きさ 1が通常、3が最大化、7が最小化 
        shortcut.WindowStyle = 1
        'コメント 
        shortcut.Description = "Mi-Kenshin Tablet"
        'アイコンのパス 自分のEXEファイルのインデックス0のアイコン 
        'shortcut.IconLocation = Application.ExecutablePath + ",0"

        'ショートカットを作成 
        shortcut.Save()

        '後始末
        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(shortcut)
        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(shell)
    End Sub
#End Region


    Private Const ODBC_ADD_DSN As Integer = 1  ' データ ソースの追加

#Region "ODBC登録"
    <DllImport("ODBCCP32.DLL", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function SQLConfigDataSource(ByVal hwndParent As Integer,
                        ByVal fRequest As Integer,
                        ByVal lpszDriver As String,
                        ByVal lpszAttributes As String) As Integer
    End Function

    Private Sub odbc()
        Dim Driver As String
        Dim attribs As String

        Driver = "MySQL ODBC 5.3 Unicode Driver"
        attribs = "SERVER=" + txtIP.Text + Convert.ToChar(0)
        attribs += "DESCRIPTION=Mi-kenshinTab" + Convert.ToChar(0)
        attribs += "DSN=" + "establet_shisei" + Convert.ToChar(0)
        attribs += "DATABASE=" + "establet_shisei" + Convert.ToChar(0)
        attribs += "Trusted_Connection=yes" + Convert.ToChar(0)
        attribs += "User=root" + Convert.ToChar(0)
        attribs += "Password=root" + Convert.ToChar(0)

        Dim intRet As Integer = SQLConfigDataSource(0, ODBC_ADD_DSN, Driver, attribs)
        If intRet = 1 Then
            MessageBox.Show("完了")
        End If
    End Sub

    Private Sub btnODBC_Click(sender As Object, e As EventArgs) Handles btnODBC.Click
        odbc()
    End Sub

#End Region

End Class
