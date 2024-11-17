Imports System.Data.SqlClient

Public Class AdministratorsLogin

    Dim sqlCon As SqlConnection
    Dim sqlData As SqlDataAdapter
    Const strCon As String = "Server=(local)\SQLEXPRESS; Database=ATMProject; Integrated Security=SSPI"
    Dim found As Boolean = False

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If userNm.Text = "" Then
            MsgBox("Input your username.")
            userNm.Focus()
        ElseIf pWord.Text = "" Then
            MsgBox("Input your password.")
            pWord.Focus()
        Else
            Dim sqlRead As SqlDataReader
            Dim sqlCmd As SqlCommand

            sqlCon = New SqlConnection(strCon)
            sqlCon.Open()

            sqlCmd = New SqlCommand("SELECT * FROM Administrators WHERE userNm='" & userNm.Text & "' and password='" & pWord.Text & "'", sqlCon)
            sqlRead = sqlCmd.ExecuteReader

            If sqlRead.Read Then
                bridgeNo.Text = userNm.Text
                found = True
            End If

            If found = True Then
                MsgBox("Log in successful. Redirecting...")
                Me.Visible = False
                Mabuhay_System.Visible = True
            Else
                MsgBox("Username/password is not correct.")
            End If
        End If
    End Sub

    Private Sub pWord_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pWord.KeyPress
        Dim code As Integer = Asc(e.KeyChar)

        If code = 13 Then
            Button1.Focus()
        End If
        If code >= 48 And code <= 57 Or code = 8 Then
        Else
            e.Handled = True
        End If
    End Sub
End Class