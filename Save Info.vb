Imports System.Data.SqlClient

Public Class Save_Info

    Dim sqlCon As SqlConnection
    Const strCon As String = "Server=(local)\SQLEXPRESS; Database=ATMProject; Integrated Security=SSPI"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sqlRead As SqlDataReader
        Dim sqlCmd As SqlCommand

        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()

        sqlCmd = New SqlCommand("SELECT * FROM AccountInfo WHERE accountNo='" & Edit_Account.BridgeAccno.Text & "'", sqlCon)
        sqlRead = sqlCmd.ExecuteReader

        If sqlRead.Read Then

            UpInfo()

            MsgBox("Account was updated.")
            Mabuhay_System.TblRefresh()
            Mabuhay_System.Enabled = True
            Mabuhay_System.Focus()
            Me.Visible = False
        Else
            MsgBox("Forced termination...")
            Mabuhay_System.Enabled = True
            Me.Visible = False
        End If

    End Sub
    Sub UpInfo()
        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()

        Dim sqlCmd4 As New SqlCommand("UPDATE AccountInfo SET firstNm='" & Edit_Account.firstNm.Text & "', lastNm='" & Edit_Account.lastNm.Text & "', address='" & Edit_Account.address.Text & "', foneNo='" & Edit_Account.foneNo.Text & "' WHERE accountNo='" & Edit_Account.BridgeAccno.Text & "'", sqlCon)
        sqlCmd4.ExecuteNonQuery()
    End Sub
End Class