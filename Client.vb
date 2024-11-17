Imports System.Data.SqlClient

Public Class Client
    Dim sqlCon As SqlConnection
    Const strCon As String = "Server=(local)\SQLEXPRESS; Database=ATMProject; Integrated Security=SSPI"
    Dim MessageCTR As Integer = 1
    Dim tempBal As Integer
    Private found As String = "False"
    Dim userNo As Integer
    Dim userPin As Integer

    Private Sub Messenger_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Messenger.Tick
        Message.Left -= 5
        If Message.Left = -200 And MessageCTR = 1 Then
            Message.Left = 640
            MessageCTR = 2
            Message.Text = "Your account is private. Don't share it!"
        ElseIf Message.Left = -300 And MessageCTR = 2 Then
            Message.Left = 640
            MessageCTR = 3
            Message.Text = "Like us in Facebook!"
        ElseIf Message.Left = -175 And MessageCTR = 3 Then
            Message.Left = 640
            MessageCTR = 4
            Message.Text = "Call us with our 24/7 number."
        ElseIf Message.Left = -200 And MessageCTR = 4 Then
            Message.Left = 640
            MessageCTR = 1
            Message.Text = "Thanks for banking with us!"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sqlRead As SqlDataReader
        Dim sqlCmd As SqlCommand

        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()

        sqlCmd = New SqlCommand("SELECT * FROM BankAccounts WHERE accNo='" & Login.bridgeNo.Text & "'", sqlCon)
        sqlRead = sqlCmd.ExecuteReader

        While sqlRead.Read
            clientBal.Text = "P" & sqlRead("accBal") & ".00"
            clientBal2.Text = "P" & sqlRead("accBal") & ".00"
            clientBal3.Text = "P" & sqlRead("accBal") & ".00"
        End While
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim sqlRead As SqlDataReader
        Dim sqlCmd As SqlCommand

        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()

        sqlCmd = New SqlCommand("SELECT * FROM BankAccounts WHERE accNo='" & Login.bridgeNo.Text & "'", sqlCon)
        sqlRead = sqlCmd.ExecuteReader

        While sqlRead.Read
            clientBal.Text = "P" & sqlRead("accBal") & ".00"
            clientBal2.Text = "P" & sqlRead("accBal") & ".00"
            clientBal3.Text = "P" & sqlRead("accBal") & ".00"
            If sqlRead("accBal") <= 500 Then
                MsgBox("Sorry, a P500.00 maintaining balance" & vbNewLine & "is required. Please deposit again or" & vbNewLine & "wait for your monthly pay.")
                TextBox1.Enabled = False
                Button1.Enabled = False
            ElseIf sqlRead("accBal") >= 501 Then
                TextBox1.Enabled = True
                Button1.Enabled = True
            End If
        End While
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim sqlRead As SqlDataReader
        Dim sqlCmd As SqlCommand

        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()

        sqlCmd = New SqlCommand("SELECT * FROM BankAccounts WHERE accNo='" & Login.bridgeNo.Text & "'", sqlCon)
        sqlRead = sqlCmd.ExecuteReader

        While sqlRead.Read
            clientBal.Text = "P" & sqlRead("accBal") & ".00"
            clientBal2.Text = "P" & sqlRead("accBal") & ".00"
            clientBal3.Text = "P" & sqlRead("accBal") & ".00"

            If sqlRead("accBal") <= 500 Then
                MsgBox("Sorry, a P500.00 maintaining balance" & vbNewLine & "is required. Please deposit again or" & vbNewLine & "wait for your monthly pay.")
                clientCheck.Enabled = False
            ElseIf sqlRead("accBal") >= 501 Then
                clientCheck.Enabled = True
            End If
        End While
        Me.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim sqlRead As SqlDataReader
        Dim sqlCmd As SqlCommand

        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()

        sqlCmd = New SqlCommand("SELECT * FROM BankAccounts", sqlCon)
        sqlRead = sqlCmd.ExecuteReader

        While sqlRead.Read
            If sqlRead("accNo") = Login.bridgeNo.Text And sqlRead("accNo") = clientCheck.Text Then
                found = "Own"
            ElseIf sqlRead("accNo") = clientCheck.Text And Not (sqlRead("accNo") = Login.bridgeNo.Text) Then
                found = "True"
            End If
        End While

        If found = "True" Then
            clientFound.Text = "Account was found."
            'clientFound.Text = "clientNo: " & Login.bridgeNo.Text & " clientCheck: " & clientCheck.Text
            clientTransfer.Enabled = True
            found = "False"
        ElseIf found = "Own" Then
            MsgBox("Cannot transfer to your account.")
            clientFound.Text = "Search for an account."
            clientTransfer.Enabled = False
            clientCheck.Focus()
            found = "False"
        ElseIf found = "False" Then
            clientFound.Text = "Account was not found."
            clientTransfer.Enabled = False
            found = "False"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sqlRead As SqlDataReader
        Dim sqlCmd As SqlCommand

        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()

        sqlCmd = New SqlCommand("SELECT * FROM BankAccounts WHERE accNo='" & Login.bridgeNo.Text & "'", sqlCon)
        sqlRead = sqlCmd.ExecuteReader

        While sqlRead.Read
            tempBal = sqlRead("accBal")
            clientBal.Text = "P" & sqlRead("accBal") & ".00"
            clientBal2.Text = "P" & sqlRead("accBal") & ".00"
            clientBal3.Text = "P" & sqlRead("accBal") & ".00"
            found = False
        End While

        If clientAmount.Text = "" Then
            MsgBox("Input a valid amount.")
            clientAmount.Focus()
        Else
            If clientAmount.Text > tempBal Then
                MsgBox("You do not have enough balance" & vbNewLine & "to continue.")
            Else
                Me.Enabled = False
                tempBal -= clientAmount.Text
                bridgeAmount.Text = tempBal
                Secure.Visible = True
            End If
        End If
    End Sub

    Private Sub clientAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles clientAmount.KeyPress
        Dim code As Integer = Asc(e.KeyChar)

        If code = 13 Then
            Button3.Focus()
        End If
        If code >= 48 And code <= 57 Or code = 8 Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub clientCheck_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles clientCheck.KeyPress
        Dim code As Integer = Asc(e.KeyChar)

        If code = 13 Then
            Button4.Focus()
        End If
        If code >= 48 And code <= 57 Or code = 8 Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Withdrawal_Check.Visible = True
        Me.Enabled = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim sqlRead As SqlDataReader
        Dim sqlCmd As SqlCommand

        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()

        sqlCmd = New SqlCommand("SELECT * FROM BankAccounts WHERE accNo='" & Login.bridgeNo.Text & "'", sqlCon)
        sqlRead = sqlCmd.ExecuteReader

        If sqlRead.Read Then
            Me.Enabled = False
            Change_PIN.Visible = True
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Panel2.Visible = False
        TabControl1.Visible = False
        Message.Visible = False
        t1.Visible = True
        t2.Visible = True
        t3.Visible = True
        t4.Visible = True
        t5.Visible = True
        Messenger.Enabled = False
    End Sub

    Private Sub t4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles t4.Click
        Dim sqlRead As SqlDataReader
        Dim sqlCmd As SqlCommand

        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()

        sqlCmd = New SqlCommand("SELECT * FROM AccountInfo WHERE accountNo='" & Login.bridgeNo.Text & "'", sqlCon)
        sqlRead = sqlCmd.ExecuteReader

        While sqlRead.Read
            If sqlRead("accountNo") < 10 Then
                clientNo.Text = "000" & sqlRead("accountNo")
            ElseIf sqlRead("accountNo") < 100 And sqlRead("accountNo") > 10 Then
                clientNo.Text = "00" & sqlRead("accountNo")
            ElseIf sqlRead("accountNo") < 1000 And sqlRead("accountNo") > 100 Then
                clientNo.Text = "0" & sqlRead("accountNo")
            End If
            clientNm.Text = "" & sqlRead("firstNm") & " " & sqlRead("lastNm")
        End While
        Panel2.Visible = True
        TabControl1.Visible = True
        Message.Visible = True
        t1.Visible = False
        t2.Visible = False
        t3.Visible = False
        t4.Visible = False
        t5.Visible = False
        Messenger.Enabled = True
    End Sub

    Private Sub Client_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel2.Visible = False
        TabControl1.Visible = False
        Message.Visible = False
        t1.Visible = True
        t2.Visible = True
        t3.Visible = True
        t4.Visible = True
        t5.Visible = True
        Messenger.Enabled = False
    End Sub
End Class