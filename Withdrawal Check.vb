Imports System.Data.SqlClient

Public Class Withdrawal_Check

    Dim sqlCon As SqlConnection
    Const strCon As String = "Server=(local)\SQLEXPRESS; Database=ATMProject; Integrated Security=SSPI"
    Dim found As Boolean = False
    Dim cc As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Client.TextBox1.Text = "" Then
            MsgBox("Enter amount to be withdrawed.")
        Else
            Dim sqlRead As SqlDataReader
            Dim sqlCmd As SqlCommand
            Dim amtBal As Integer

            sqlCon = New SqlConnection(strCon)
            sqlCon.Open()

            sqlCmd = New SqlCommand("SELECT * FROM BankAccounts WHERE accNo='" & Login.bridgeNo.Text & "'", sqlCon)
            sqlRead = sqlCmd.ExecuteReader

            While sqlRead.Read
                If sqlRead("accNo") = Login.bridgeNo.Text And sqlRead("accPIN") = withCheck.Text Then
                    found = True
                    amtBal = sqlRead("accBal")
                    cc = amtBal
                End If
            End While

            If found = True Then
                cc -= (Client.TextBox1.Text + 10)
                Me.Visible = False
                Client.Enabled = True
                Client.Focus()
                Updater()
                Inserter()
                found = False
            ElseIf found = False Then
                MsgBox("PIN is not correct. No transaction occured.")
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Visible = False
        Client.Enabled = True
    End Sub

    Sub Updater()
        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()
        Dim strUpdate As String = "UPDATE BankAccounts SET accBal='" & cc & "' WHERE accNo='" & Login.bridgeNo.Text & "' And accPIN ='" & withCheck.Text & "'"
        Dim sqlUpdateBal As New SqlCommand(strUpdate, sqlCon)
        sqlUpdateBal.ExecuteNonQuery()
    End Sub

    Sub Inserter()
        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()
        Dim sqlCmd6 As New SqlCommand("INSERT INTO Transactions VALUES('Withdraw', '" & Login.bridgeNo.Text & "', '" & Client.TextBox1.Text & "', '" & Now.Date & "', '', '10')", sqlCon)
        sqlCmd6.ExecuteNonQuery()
    End Sub
End Class