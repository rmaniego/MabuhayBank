Imports System.Data.SqlClient

Public Class Change_PIN

    Dim sqlCon As SqlConnection
    Const strCon As String = "Server=(local)\SQLEXPRESS; Database=ATMProject; Integrated Security=SSPI"
    Dim found As Boolean = False

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sqlRead As SqlDataReader
        Dim sqlCmd As SqlCommand

        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()

        sqlCmd = New SqlCommand("SELECT * FROM BankAccounts WHERE accPIN='" & oldPIN.Text & "'", sqlCon)
        sqlRead = sqlCmd.ExecuteReader

        If sqlRead.Read Then

            MsgBox("PIN was changed successfully.")
            Client.Enabled = True
            Me.Visible = False
            found = True
        Else
            MsgBox("Forced termination...")
            Client.Enabled = True
            Me.Visible = False
        End If

        If found = True Then
            Changer()
            found = False
        End If
    End Sub
    Sub Changer()
        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()

        If newPIN.Text = checker.Text Then
            Dim sqlCmd4 As New SqlCommand("UPDATE BankAccounts SET accPIN='" & newPIN.Text & "' WHERE accNo='" & Login.bridgeNo.Text & "'", sqlCon)
            sqlCmd4.ExecuteNonQuery()
        Else
            MsgBox("Check new PIN value. Forced termination...")
            Client.Enabled = True
            Me.Visible = False
        End If
    End Sub
End Class