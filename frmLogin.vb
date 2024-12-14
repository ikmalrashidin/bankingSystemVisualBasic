Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class frmLogin
    ' Create OleDbConnection Object
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ikmal\Downloads")

    ' Create OleDbCommand object
    Dim cmd As OleDbCommand

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If IsInputValid() Then
            Try
                con.Open()
                Dim loginQuery As String = "SELECT * FROM tbl_users WHERE Username = @Username AND [Password] = @Password AND Pin = @Pin"
                cmd = New OleDbCommand(loginQuery, con)
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@Password", txtPass.Text)
                cmd.Parameters.AddWithValue("@Pin", txtPin.Text)
                Dim dr As OleDbDataReader = cmd.ExecuteReader()

                If dr.Read() Then
                    Dim interfaceForm As New FrmInterface(txtUsername.Text) ' Pass username to FrmInterface
                    interfaceForm.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid username, password, or pin! Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ClearFields()
                End If

                dr.Close()
            Catch ex As OleDbException
                MessageBox.Show("Database error: " & ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LogError(ex)
            Catch ex As Exception
                MessageBox.Show("An unexpected error occurred: " & ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LogError(ex)
            Finally
                con.Close()
            End Try
        Else
            MessageBox.Show("Some information is missing! Please fill in all the fields.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function IsInputValid() As Boolean
        Return Not (String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPass.Text) OrElse String.IsNullOrWhiteSpace(txtPin.Text))
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtUsername.Text = ""
        txtPass.Text = ""
        txtPin.Text = ""
        txtUsername.Focus()
    End Sub

    Private Sub checkBxPass_CheckedChanged(sender As Object, e As EventArgs) Handles checkBxPass.CheckedChanged
        TogglePasswordVisibility(txtPass, checkBxPass)
    End Sub

    Private Sub checkBxPin_CheckedChanged(sender As Object, e As EventArgs) Handles checkBxPin.CheckedChanged
        TogglePasswordVisibility(txtPin, checkBxPin)
    End Sub

    Private Sub TogglePasswordVisibility(passwordField As TextBox, checkBox As CheckBox)
        If checkBox.Checked Then
            passwordField.PasswordChar = ControlChars.NullChar
        Else
            passwordField.PasswordChar = "•"c
        End If
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim registerForm As New frmRegister()
        registerForm.Show()
        Me.Hide()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Any initialization code can go here.
    End Sub

    Private Sub LogError(ex As Exception)
        ' This method logs errors to a file for further investigation
        System.IO.File.AppendAllText("error_log.txt", DateTime.Now.ToString() & " - " & ex.ToString() & Environment.NewLine)
    End Sub
End Class
