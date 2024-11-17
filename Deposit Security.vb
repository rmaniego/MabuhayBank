Imports System.Data.SqlClient

Public Class Deposit_Security

    Dim sqlCon As SqlConnection
    Const strCon As String = "Server=(local)\SQLEXPRESS; Database=ATMProject; Integrated Security=SSPI"
    Dim found As Boolean = False
    Dim found2 As Boolean = False
    Dim dep As Integer

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Mabuhay_System.Enabled = True
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If secureCheck.Text = "" Then
            MsgBox("Re-enter PIN.")
        Else
            Dim sqlRead As SqlDataReader
            Dim sqlCmd As SqlCommand

            sqlCon = New SqlConnection(strCon)
            sqlCon.Open()

            sqlCmd = New SqlCommand("SELECT * FROM Administrators WHERE userNm='" & AdministratorsLogin.userNm.Text & "' AND password='" & secureCheck.Text & "'", sqlCon)
            sqlRead = sqlCmd.ExecuteReader

            If sqlRead.Read Then
                found = True
            Else
                found = False
            End If

            If found = True Then
                balreader()

                Me.Visible = False
                Mabuhay_System.Enabled = True
                Mabuhay_System.Focus()
                found = False
            Else
                MsgBox("Check again later.")
                found = False
            End If
        End If
    End Sub
    Sub balreader()
        Dim sqlRead As SqlDataReader
        Dim sqlCmd As SqlCommand

        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()

        sqlCmd = New SqlCommand("SELECT * FROM BankAccounts WHERE accNo='" & Mabuhay_System.TextBox2.Text & "'", sqlCon)
        sqlRead = sqlCmd.ExecuteReader

        If sqlRead.Read Then
            dep = sqlRead("accBal")
            dep += Mabuhay_System.TextBox1.Text
            Mabuhay_System.clientBal2.Text = dep
            found2 = True
        Else
            found2 = False
        End If

    End Sub
    Sub depositer()

        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()

        Dim strUpdate2 As String = "UPDATE BankAccounts SET accBal='" & dep & "' WHERE accNo='" & Login.bridgeNo.Text & "' And accPIN ='" & secureCheck.Text & "'"
        Dim sqlUpdateBal2 As New SqlCommand(strUpdate2, sqlCon)
        sqlUpdateBal2.ExecuteNonQuery()
    End Sub
End Class