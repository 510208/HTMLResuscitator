Public Class frmDonate
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Shell("explorer https://ko-fi.com/510208 ", vbNormalFocus)
    End Sub

    Private Sub btnPayPal_Click(sender As Object, e As EventArgs) Handles btnPayPal.Click
        Shell("explorer https://paypal.me/510208 ", vbNormalFocus)
    End Sub
End Class