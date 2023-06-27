Imports Microsoft.Web.WebView2.Core

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "HTMLResuscitator " & My.Application.Info.Version.ToString
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        Me.Text = Me.Text & " [ 正在取得檔案位置 ]"
        ofdHTMLName.ShowDialog()
        Dim filePath As String = ofdHTMLName.FileName
        lblFileName.Text = "網頁檔案：" & filePath
        txtFilePath.Text = filePath
        Me.Text = Me.Text & " [ 正在載入網頁 ]"
        Try
            wveHTMLLookup.Source = New Uri(txtFilePath.Text)
        Catch ex As UriFormatException
            MsgBox("完整的URL格式應包含http或https！", vbExclamation)
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
        Me.Text = "HTMLResuscitator " & My.Application.Info.Version.ToString
    End Sub

    Private Sub mnuSetting_Click(sender As Object, e As EventArgs) Handles mnuSetting.Click
        frmSetting.Show()
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        wveHTMLLookupResurf()
    End Sub

    Public Function AddHttpPrefix(ByVal url As String) As String
        If Not url.StartsWith("http://") AndAlso Not url.StartsWith("https://") Then
            ' 检查是否为文件路径格式
            If url.StartsWith("file://") Then
                Return url ' 已经是文件路径格式，无需修改
            Else
                ' 添加 http:// 前缀
                url = "http://" & url
            End If
        End If

        ' 检查是否为文件路径格式但没有前缀
        If IsSecondCharColon(url) Then
            url = "file:///" & url
        End If

        Return url
    End Function

    Private Sub grmMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' 設定 GroupBox 的寬度為表單的寬度
        GroupBox1.Width = Me.Width - 16 - 16 ' 考慮 GroupBox 的邊框寬度

        ' 設定 wveHTMLLookup 的寬度為表單的寬度，高度為表單高度減去 GroupBox 的高度再減去 21 像素
        wveHTMLLookup.Width = Me.Width - 16 - 16 ' 考慮 wveHTMLLookup 的邊框寬度
        wveHTMLLookup.Height = Me.Height - GroupBox1.Height - 21
    End Sub

    Private Sub chkTimeReload_Click(sender As Object, e As EventArgs) Handles chkTimeReload.Click
        chkTimeReload.Checked = Not (chkTimeReload.Checked)
        frmSetting.chkEnableTimer.Checked = chkTimeReload.Checked
        frmSetting.nudTimerTime.Enabled = frmSetting.chkEnableTimer.Checked
        tmrReload.Enabled = chkTimeReload.Checked
        Dim tmrReloadTime As Single = frmSetting.nudTimerTime.Value
        lblTmrReloadEnabled.Text = "自動重載啟用狀態：" & tmrReload.Enabled.ToString & "," & tmrReloadTime.ToString & "ms"
    End Sub

    Private Sub mnuShowHTML_Click(sender As Object, e As EventArgs) Handles mnuShowHTML.Click
        frmHTMLSourceCode.Show()
    End Sub

    Private Sub tmrReload_Tick(sender As Object, e As EventArgs) Handles tmrReload.Tick
        MsgBox("11")
        wveHTMLLookupResurf()
    End Sub

    Public Sub wveHTMLLookupResurf()
        Me.Text = Me.Text & "[ 正在載入網頁 ]"
        Dim urlBackup As String
        If txtFilePath.Text = "" Then
            Return
        End If
        Try
            urlBackup = txtFilePath.Text
            txtFilePath.Text = AddHttpPrefix(txtFilePath.Text)
            wveHTMLLookup.Source = New Uri(txtFilePath.Text)
        Catch ex As System.UriFormatException
            Dim filePath As String = txtFilePath.Text
            txtFilePath.Text = "file:///" & urlBackup
            wveHTMLLookup.Source = New Uri("file:///" & urlBackup)
        Catch ex As Exception
            MsgBox("錯誤：" & ex.Message, vbCritical)
        End Try
        Me.Text = "HTMLResuscitator " & My.Application.Info.Version.ToString
    End Sub

    Public Function IsSecondCharColon(ByVal text As String) As Boolean
        If text.Length >= 2 Then
            Dim secondChar As Char = text(1)
            Return secondChar = ":"c
        End If

        Return False
    End Function

    Private Sub mnuGithubRepo_Click(sender As Object, e As EventArgs) Handles mnuGithubRepo.Click
        Shell("explorer HTTP://tw.yahoo.com "), vbNormalFocus
    End Sub
End Class
