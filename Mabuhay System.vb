Imports System.Data.SqlClient

Public Class Mabuhay_System

    Dim sqlCon As SqlConnection
    Const strCon As String = "Server=(local)\SQLEXPRESS; Database=ATMProject; Integrated Security=SSPI"
    Dim da As New SqlDataAdapter
    Dim indx1 As Integer
    Dim ext As Integer = 0
    Dim ctr As Integer = 0

    Dim Accnos As Integer
    Dim found As Boolean = False

    Sub TblRefresh()
        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()

        Dim cmd As New SqlCommand("SELECT * FROM AccountInfo", sqlCon)
        Dim dt As New DataTable
        da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Sub t4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t4.Click
        t1.Visible = False
        t2.Visible = False
        t3.Visible = False
        t4.Visible = False
        t5.Visible = False
        msTrans.Visible = False
        msMem.Visible = False
        msDepo.Visible = False
        menuTb.Visible = True
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        t1.Visible = True
        t2.Visible = True
        t3.Visible = True
        t4.Visible = True
        t5.Visible = True
        menuTb.Visible = False
    End Sub

    Private Sub a1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles a1.MouseHover
        a1.Top = 49
    End Sub
    Private Sub a1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles a1.MouseLeave
        a1.Top = 54
    End Sub

    Private Sub a2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles a2.MouseHover
        a2.Top = 49
    End Sub
    Private Sub a2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles a2.MouseLeave
        a2.Top = 54
    End Sub
    Private Sub a3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles a3.MouseHover
        a3.Top = 49
    End Sub

    Private Sub a3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles a3.MouseLeave
        a3.Top = 54
    End Sub
    Private Sub a4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles a4.MouseHover
        a4.Top = 49
    End Sub

    Private Sub a4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles a4.MouseLeave
        a4.Top = 54
    End Sub

    Private Sub a1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a1.Click
        msMem.Visible = True
        msTrans.Visible = False
        msDepo.Visible = False
        msTrans.Left = 691
        msDepo.Top = 562
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        Dim rowIndx As Integer = e.RowIndex
        indx1 = DataGridView1.Rows(rowIndx).Cells(0).Value
    End Sub

    Private Sub Mabuhay_System_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TblRefresh()
    End Sub

    Private Sub del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles del.Click
        If DataGridView1.RowCount = 0 Then
            MsgBox("Bank database is empty." & vbNewLine & "Cannot continue...")
        Else
            sqlCon = New SqlConnection(strCon)
            sqlCon.Open()

            DelAcc()
            TblRefresh()

        End If
    End Sub

    Private Sub a4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a4.Click
        msMem.Visible = False
        Me.Enabled = False
        Logout.Visible = True
    End Sub

    Private Sub logger_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logger.Tick
        menuTb.Visible = False
        PictureBox1.Top += 5
        ClientTitle.Top += 5
        PictureBox2.Top += 5
        ext += 1
        If ext >= 25 Then
            Login.Dispose()
            Login.Close()
        End If
    End Sub

    Private Sub a3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a3.Click
        msTrans.Visible = False
        msMem.Visible = False
        msDepo.Visible = True
        msDepo.Top = 88
        msTrans.Left = 691
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim code As Integer = Asc(e.KeyChar)

        If code = 13 Then
            Button1.Focus()
        End If
        If code >= 48 And code <= 57 Or code = 8 Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sqlRead As SqlDataReader
        Dim sqlCmd As SqlCommand


        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()

        sqlCmd = New SqlCommand("SELECT * FROM BankAccounts WHERE AccNo='" & TextBox2.Text & "'", sqlCon)
        sqlRead = sqlCmd.ExecuteReader

        If sqlRead.Read Then
            found = True
        End If

        If found = True Then
            Label10.Visible = True
            Label10.Text = "Account was found."
            Label7.Visible = True
            Label9.Visible = True
            TextBox1.Enabled = True
            Button6.Enabled = True
            clientBal2.Visible = True
            clientNm.Visible = True
            clientBal2.Text = "P" & sqlRead("accBal") & ".00"
            clientNm.Text = Client.clientNm.Text
            found = False
        Else
            Label10.Visible = True
            Label10.Text = "Account not taken."
            Button6.Enabled = False
            clientBal2.Visible = False
            Label7.Visible = False
            Label9.Visible = False
            clientBal2.Visible = False
            clientNm.Visible = False
            found = False
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim code As Integer = Asc(e.KeyChar)

        If code = 13 Then
            Button6.Focus()
        End If
        If code >= 48 And code <= 57 Or code = 8 Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Enabled = False
        Deposit_Security.Visible = True
    End Sub

    Private Sub a2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a2.Click
        t1.Visible = False
        t2.Visible = False
        t3.Visible = False
        t4.Visible = False
        t5.Visible = False
        msTrans.visible = True
        msMem.Visible = False
        msDepo.Visible = False
        menuTb.Visible = True
        msTrans.Left = 0
        msDepo.Top = 562
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Dim code As Integer = Asc(e.KeyChar)

        If code = 13 Then
            Button2.Focus()
        End If
        If code >= 48 And code <= 57 Or code = 8 Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()

        Dim cmd As New SqlCommand("SELECT * FROM Transactions WHERE accNo='" & TextBox3.Text & "'", sqlCon)
        Dim dt As New DataTable
        da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView2.DataSource = dt
        If DataGridView2.RowCount < 1 Then
            MsgBox("Account not yet taken.")
            DataGridView2.Visible = False
        Else
            DataGridView2.Visible = True
        End If

    End Sub

    Private Sub add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add.Click
        Me.Enabled = False
        New_Account.Visible = True
    End Sub
    Sub DelAcc()
        Dim sqlRead As SqlDataReader
        Dim sqlCmd As SqlCommand

        sqlCmd = New SqlCommand("SELECT * FROM AccountInfo WHERE AccountNo='" & indx1 & "'", sqlCon)
        sqlRead = sqlCmd.ExecuteReader

        If sqlRead.Read Then
            found = True
            Accnos = sqlRead("AccountNo")
        End If

        If found = True Then
            Deleter()
            found = False
        End If
    End Sub

    Sub Deleter()
        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()

        Dim cmd As New SqlCommand("DELETE FROM BankAccounts WHERE accNo=" & Accnos & "", sqlCon)
        cmd.ExecuteNonQuery()
        Dim sqlCmd2 As New SqlCommand("DELETE FROM AccountInfo WHERE accountNo=" & Accnos & "", sqlCon)
        sqlCmd2.ExecuteNonQuery()
        MsgBox("Serious offense was committed by this acount owner." & vbNewLine & "Account termination is enforced.")
    End Sub

    Private Sub edt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edt.Click
        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()

        Dim sqlRead As SqlDataReader
        Dim sqlCmd As SqlCommand

        sqlCmd = New SqlCommand("SELECT * FROM AccountInfo WHERE AccountNo='" & indx1 & "'", sqlCon)
        sqlRead = sqlCmd.ExecuteReader

        If sqlRead.Read Then
            Edit_Account.firstNm.Text = sqlRead("firstNm")
            Edit_Account.lastNm.Text = sqlRead("lastNm")
            Edit_Account.foneNo.Text = sqlRead("foneNo")
            Edit_Account.address.Text = sqlRead("address")
            Edit_Account.BridgeAccno.Text = sqlRead("accountNo")
        End If

        Me.Enabled = False
        Edit_Account.Visible = True
    End Sub
End Class