<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHTMLSourceCode
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
        Me.txtHTMLCode = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtHTMLCode
        '
        Me.txtHTMLCode.Location = New System.Drawing.Point(12, 12)
        Me.txtHTMLCode.Multiline = True
        Me.txtHTMLCode.Name = "txtHTMLCode"
        Me.txtHTMLCode.Size = New System.Drawing.Size(776, 426)
        Me.txtHTMLCode.TabIndex = 0
        Me.txtHTMLCode.Text = "Null"
        '
        'frmHTMLSourceCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtHTMLCode)
        Me.Name = "frmHTMLSourceCode"
        Me.Text = "frmHTMLSourceCode"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtHTMLCode As TextBox
End Class
