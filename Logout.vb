Public Class Logout

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Visible = False
        Mabuhay_System.Enabled = True
        Mabuhay_System.Focus()
        Mabuhay_System.logger.Enabled = True
    End Sub
End Class