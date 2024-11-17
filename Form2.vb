Imports System.Data.SqlClient

Public Class Secure
    Dim sqlCon As SqlConnection
    Const strCon As String = "Server=(local)\SQLEXPRESS; Database=ATMProject; Integrated Security=SSPI"
    Private found As Boolean = False
    Dim amt As Integer
    Dim amt2 As Integer
    Dim transfCharge As Integer = 10
    Dim balFinal As Integer

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Visible = False
        'TabControl1.TabPage4.focus()
        Client.Enabled = True
        Client.clientCheck.Clear()
        Client.clientAmount.Clear()
        Client.clientTransfer.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If secureCheck.Text = "" Then
            MsgBox("Re-enter PIN.")
        Else
            Dim sqlRead As SqlDataReader
            Dim sqlCmd As SqlCommand

            sqlCon = New SqlConnection(strCon)
            sqlCon.Open()

            sqlCmd = New SqlCommand("SELECT * FROM BankAccounts", sqlCon)
            sqlRead = sqlCmd.ExecuteReader

            While sqlRead.Read
                If sqlRead("accNo") = Login.bridgeNo.Text Then
                    found = True
                    amt = "" & sqlRead("accBal")
                End If
                If sqlRead("accNo") = Client.clientCheck.Text Then
                    found = True
                    amt2 = "" & sqlRead("accBal")
                End If
            End While

            If found = True Then
                MsgBox("Transaction was successful.")
                Me.Visible = False
                found = False
                ToDBS()
                Client.Enabled = True
            ElseIf found = False Then
                MsgBox("Transaction will terminate.")
                Me.Visible = False
                found = False
                Client.Enabled = True
            End If
        End If

    End Sub

    Private Sub Secure_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = False
    End Sub
    Private Sub ToDBS()
        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()

        balFinal = amt - (10 + Client.clientAmount.Text)
        Dim sqlCmd2 As New SqlCommand("UPDATE BankAccounts SET accBal='" & balFinal & "' WHERE accPIN='" & secureCheck.Text & "' And accNo ='" & Login.bridgeNo.Text & "'", sqlCon)
        sqlCmd2.ExecuteNonQuery()

        Dim bb As Integer = amt2 + Client.clientAmount.Text
        Dim sqlCmd4 As New SqlCommand("UPDATE BankAccounts SET accBal='" & bb & "' WHERE accNo='" & Client.clientCheck.Text & "'", sqlCon)
        sqlCmd4.ExecuteNonQuery()

        'Dim aa As Integer = amt + Client.clientAmount.Text
        Dim sqlCmd3 As New SqlCommand("INSERT INTO Transactions VALUES('Transfer', '" & Login.bridgeNo.Text & "', '" & Client.clientAmount.Text & "', '" & Now.Date & "', '" & Client.clientCheck.Text & "', '10')", sqlCon)
        sqlCmd3.ExecuteNonQuery()
        Client.clientCheck.Clear()
        Client.clientAmount.Clear()
        Client.clientTransfer.Enabled = False

    End Sub
End Class