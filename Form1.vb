Imports System.Data.SqlClient

Public Class Login
    Dim sqlCon As SqlConnection
    Dim sqlData As SqlDataAdapter
    Const strCon As String = "Server=(local)\SQLEXPRESS; Database=ATMProject; Integrated Security=SSPI"
    Private found As Boolean = False
    Dim robot As Integer = 0
    Dim robot2 As Integer = 0


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If acNo.Text = "" Then
            MsgBox("Input your account number.")
            acNo.Focus()
        ElseIf acPIN.Text = "" Then
            MsgBox("Input your account PIN.")
            acPIN.Focus()
        Else
            Dim sqlRead As SqlDataReader
            Dim sqlCmd As SqlCommand

            sqlCon = New SqlConnection(strCon)
            sqlCon.Open()

            sqlCmd = New SqlCommand("SELECT * FROM BankAccounts WHERE accNo='" & acNo.Text & "' and accPIN='" & acPIN.Text & "'", sqlCon)
            sqlRead = sqlCmd.ExecuteReader

            If sqlRead.Read Then
                If sqlRead("accNo") = acNo.Text And sqlRead("accPIN") = acPIN.Text Then
                    found = True
                    bridgeNo.Text = acNo.Text
                Else
                    found = False
                End If
            End If

            If found = True Then
                Me.Visible = False
                Client.Visible = True
            Else
                robot += 1
                If robot <= 2 Then
                    MsgBox("You have limited retries. Check your inputs please.")
                End If
                acNo.Clear()
                acNo.Focus()
                acPIN.Clear()
            End If
        End If
    End Sub

    Private Sub Terminator_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Terminator.Tick
        If robot >= 3 Then
            If Not (robot2 >= 1) Then
                robot2 = 1
                MsgBox("System will be forced to terminate. Check again later.")
                Me.Dispose()
                Me.Close()
                Client.Dispose()
                Client.Close()
            End If
        End If
    End Sub

    Private Sub acNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles acNo.KeyPress
        Dim code As Integer = Asc(e.KeyChar)

        If code = 13 Then
            acPIN.Focus()
        End If
        If code >= 48 And code <= 57 Or code = 8 Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub acPIN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles acPIN.KeyPress
        Dim code As Integer = Asc(e.KeyChar)

        If code = 13 Then
            Button1.Focus()
        End If
        If code >= 48 And code <= 57 Or code = 8 Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Visible = False
        AdministratorsLogin.Visible = True
    End Sub
End Class
