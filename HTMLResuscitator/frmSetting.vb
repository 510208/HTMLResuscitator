Public Class frmSetting
    Private Sub chkEnableTimer_Click(sender As Object, e As EventArgs) Handles chkEnableTimer.Click
        nudTimerTime.Enabled = chkEnableTimer.Checked
        frmMain.tmrReload.Enabled = chkEnableTimer.Checked
        frmMain.chkTimeReload.Checked = chkEnableTimer.Checked
    End Sub

    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles Me.Load
        nudTimerTime.Enabled = False
    End Sub

    Private Sub nudTimerTime_ValueChanged(sender As Object, e As EventArgs) Handles nudTimerTime.ValueChanged
        frmMain.tmrReload.Interval = nudTimerTime.Value
        frmMain.tmrReload.Enabled = chkEnableTimer.Checked
    End Sub
End Class