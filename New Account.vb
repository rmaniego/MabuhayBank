Imports System.Data.SqlClient

Public Class New_Account

    Dim sqlCon As SqlConnection
    Const strCon As String = "Server=(local)\SQLEXPRESS; Database=ATMProject; Integrated Security=SSPI"

    Private Sub addCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addCreate.Click
        Me.Visible = False
        ValidateNew.Visible = True
    End Sub

    Private Sub addCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addCancel.Click
        MsgBox("Process not completed.")
        Mabuhay_System.Enabled = True
        Mabuhay_System.Focus()
        Me.Visible = False
    End Sub
End Class
