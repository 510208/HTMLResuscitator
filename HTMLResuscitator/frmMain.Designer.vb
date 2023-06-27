<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.wveHTMLLookup = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblFileName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTmrReloadEnabled = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ofdHTMLName = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetting = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkTimeReload = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShowHTML = New System.Windows.Forms.ToolStripMenuItem()
        Me.說明HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGithubRepo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrReload = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.wveHTMLLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'wveHTMLLookup
        '
        Me.wveHTMLLookup.AllowExternalDrop = True
        Me.wveHTMLLookup.CreationProperties = Nothing
        Me.wveHTMLLookup.DefaultBackgroundColor = System.Drawing.Color.White
        Me.wveHTMLLookup.Location = New System.Drawing.Point(12, 87)
        Me.wveHTMLLookup.Name = "wveHTMLLookup"
        Me.wveHTMLLookup.Size = New System.Drawing.Size(776, 338)
        Me.wveHTMLLookup.TabIndex = 0
        Me.wveHTMLLookup.ZoomFactor = 1.0R
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnReload)
        Me.GroupBox1.Controls.Add(Me.btnOpenFile)
        Me.GroupBox1.Controls.Add(Me.txtFilePath)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 54)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'btnReload
        '
        Me.btnReload.Location = New System.Drawing.Point(679, 18)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(91, 22)
        Me.btnReload.TabIndex = 5
        Me.btnReload.Text = "重新載入(&R)"
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(645, 18)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(28, 22)
        Me.btnOpenFile.TabIndex = 4
        Me.btnOpenFile.Text = "..."
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(129, 18)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(510, 22)
        Me.txtFilePath.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "網址或檔案位址(&U)："
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblFileName, Me.lblTmrReloadEnabled})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblFileName
        '
        Me.lblFileName.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblFileName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(90, 17)
        Me.lblFileName.Text = "網頁檔案：Null"
        '
        'lblTmrReloadEnabled
        '
        Me.lblTmrReloadEnabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblTmrReloadEnabled.Name = "lblTmrReloadEnabled"
        Me.lblTmrReloadEnabled.Size = New System.Drawing.Size(172, 17)
        Me.lblTmrReloadEnabled.Text = "自動重載啟動狀態：False, 0ms"
        '
        'ofdHTMLName
        '
        Me.ofdHTMLName.FileName = "OpenFileDialog1"
        Me.ofdHTMLName.Filter = "HTML檔案(*.html,*.htm)|*.htm;*.html|所有檔案(*.*)|*.*"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.說明HToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSetting, Me.chkTimeReload, Me.mnuShowHTML})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(57, 20)
        Me.mnuFile.Text = "檔案(&F)"
        '
        'mnuSetting
        '
        Me.mnuSetting.Name = "mnuSetting"
        Me.mnuSetting.Size = New System.Drawing.Size(186, 22)
        Me.mnuSetting.Text = "組態設定(&S)"
        '
        'chkTimeReload
        '
        Me.chkTimeReload.Name = "chkTimeReload"
        Me.chkTimeReload.Size = New System.Drawing.Size(186, 22)
        Me.chkTimeReload.Text = "啟用定時重新載入(&R)"
        '
        'mnuShowHTML
        '
        Me.mnuShowHTML.Name = "mnuShowHTML"
        Me.mnuShowHTML.Size = New System.Drawing.Size(186, 22)
        Me.mnuShowHTML.Text = "顯示HTML原始碼"
        '
        '說明HToolStripMenuItem
        '
        Me.說明HToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout, Me.mnuGithubRepo})
        Me.說明HToolStripMenuItem.Name = "說明HToolStripMenuItem"
        Me.說明HToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.說明HToolStripMenuItem.Text = "說明(&H)"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(198, 22)
        Me.mnuAbout.Text = "關於(&A)"
        '
        'mnuGithubRepo
        '
        Me.mnuGithubRepo.Name = "mnuGithubRepo"
        Me.mnuGithubRepo.Size = New System.Drawing.Size(198, 22)
        Me.mnuGithubRepo.Text = "GithHub遠端儲存庫(&G)"
        '
        'tmrReload
        '
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(764, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "還未載入網頁或原始檔"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.wveHTMLLookup)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "HTMLResuscitator"
        CType(Me.wveHTMLLookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents wveHTMLLookup As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnReload As Button
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblFileName As ToolStripStatusLabel
    Friend WithEvents ofdHTMLName As OpenFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuSetting As ToolStripMenuItem
    Friend WithEvents tmrReload As Timer
    Friend WithEvents chkTimeReload As ToolStripMenuItem
    Friend WithEvents lblTmrReloadEnabled As ToolStripStatusLabel
    Friend WithEvents mnuShowHTML As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents 說明HToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents mnuGithubRepo As ToolStripMenuItem
End Class
