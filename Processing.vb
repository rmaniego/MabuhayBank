Imports System.Data.SqlClient

Public Class Processing
    Dim sqlCon As SqlConnection
    Const strCon As String = "Server=(local)\SQLEXPRESS; Database=ATMProject; Integrated Security=SSPI"
    Dim found As Boolean = False
    Dim indx1 As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sqlRead As SqlDataReader
        Dim sqlCmd As SqlCommand

        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()

        sqlCmd = New SqlCommand("SELECT * FROM Administrators WHERE userNm='" & AdministratorsLogin.userNm.Text & "'", sqlCon)
        sqlRead = sqlCmd.ExecuteReader

        While sqlRead.Read
            If sqlRead("password") = secureCheck.Text Then
                found = True
            End If
        End While

        If found = True Then
            ValNewTrans()
            ValNewBnk()
            ValNewAcc()
            MsgBox("New account was succesfully added.")
            Mabuhay_System.TblRefresh()
            Me.Visible = False
            Mabuhay_System.Enabled = True
            Mabuhay_System.Focus()
        Else
            MsgBox("Forced termination. Invalid PIN")
            Me.Visible = False
            Mabuhay_System.Enabled = True
            Mabuhay_System.Focus()
        End If
    End Sub

    Sub ValNewTrans()
        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()
        Mabuhay_System.TblRefresh()

        indx1 = Mabuhay_System.DataGridView1.Rows(Mabuhay_System.DataGridView1.RowCount - 1).Cells(0).Value
        indx1 += 1
        Dim strInsert As String = "INSERT INTO Transactions VALUES('Deposit', '" & indx1 & "', '" & New_Account.accBal.Text & "', '" & Now.Date & "', '', '')"
        Dim strInsertAcc As New SqlCommand(strInsert, sqlCon)
        strInsertAcc.ExecuteNonQuery()
    End Sub
    Sub ValNewBnk()
        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()

        Dim strInsert As String = "INSERT INTO bankAccounts VALUES('" & indx1 & "', '" & ValidateNew.checker.Text & "', '" & New_Account.accBal.Text & "')"
        Dim strInsertAcc As New SqlCommand(strInsert, sqlCon)
        strInsertAcc.ExecuteNonQuery()
    End Sub
    Sub ValNewAcc()
        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()

        Dim strInsert As String = "INSERT INTO AccountInfo VALUES('" & New_Account.firstNm.Text & "', '" & New_Account.lastNm.Text & "','" & New_Account.address.Text & "', '" & New_Account.foneNo.Text & "')"
        Dim strInsertAcc As New SqlCommand(strInsert, sqlCon)
        strInsertAcc.ExecuteNonQuery()
    End Sub
End Class