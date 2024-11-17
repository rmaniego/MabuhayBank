Public Class Edit_Account

    Private Sub addCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addCancel.Click
        Me.Visible = False
        Mabuhay_System.Enabled = True
        Mabuhay_System.Focus()
    End Sub

    Private Sub addCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addCreate.Click
        Save_Info.Visible = True
        Me.Visible = False
        Mabuhay_System.Enabled = True
        Mabuhay_System.Focus()
    End Sub
End Class