Imports System.Data.SqlClient

Public Class ValidateNew

    Dim sqlCon As SqlConnection
    Const strCon As String = "Server=(local)\SQLEXPRESS; Database=ATMProject; Integrated Security=SSPI"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sqlCon = New SqlConnection(strCon)
        sqlCon.Open()

        If newPIN.Text = checker.Text Then
            Me.Visible = False
            Processing.Visible = True
        Else
            MsgBox("Values must be the same.")
            newPIN.Clear()
            checker.Clear()
            newPIN.Focus()
        End If
    End Sub
End Class