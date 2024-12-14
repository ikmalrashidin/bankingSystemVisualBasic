Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class frmRegister
    ' Adjust the connection string to ensure the correct path to your database file.
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ikmal\Documents\banking system(topup)\banking system\db_users.mdb")

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Any initialization code can go here.
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If IsInputValid() Then
            If txtPass.Text = txtPassCf.Text AndAlso txtPin.Text = txtPinCf.Text Then
                RegisterUser()
            Else
                MessageBox.Show("Passwords or pin do not match. Please re-enter.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ClearPasswords()
            End If
        Else
            MessageBox.Show("Some information is missing! Please fill in all the fields.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function IsInputValid() As Boolean
        Return Not (String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPass.Text) OrElse
                    String.IsNullOrWhiteSpace(txtPassCf.Text) OrElse String.IsNullOrWhiteSpace(textNoPhone.Text) OrElse
                    String.IsNullOrWhiteSpace(txtEmail.Text) OrElse String.IsNullOrWhiteSpace(txtAdress.Text) OrElse
                    String.IsNullOrWhiteSpace(txtPostal.Text) OrElse String.IsNullOrWhiteSpace(txtPin.Text) OrElse
                    String.IsNullOrWhiteSpace(txtPinCf.Text))
    End Function

    Private Sub RegisterUser()
        Try
            con.Open()
            Dim registerQuery As String = "INSERT INTO tbl_users (Username, [Password], NoPhone, Email, [Address], Postal, Pin) VALUES (@Username, @Password, @NoPhone, @Email, @Address, @Postal, @Pin)"
            Using cmd As New OleDbCommand(registerQuery, con)
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@Password", txtPass.Text)
                cmd.Parameters.AddWithValue("@NoPhone", textNoPhone.Text)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@Address", txtAdress.Text)
                cmd.Parameters.AddWithValue("@Postal", txtPostal.Text)
                cmd.Parameters.AddWithValue("@Pin", txtPin.Text)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Your account has been successfully created.", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
        Catch ex As OleDbException
            MessageBox.Show("Database error: " & ex.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LogError(ex)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LogError(ex)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub checkBxPass_CheckedChanged(sender As Object, e As EventArgs) Handles checkBxPass.CheckedChanged
        TogglePasswordVisibility(txtPass, txtPassCf, checkBxPass)
    End Sub

    Private Sub checkBxPin_CheckedChanged(sender As Object, e As EventArgs) Handles checkBxPin.CheckedChanged
        TogglePasswordVisibility(txtPin, txtPinCf, checkBxPin)
    End Sub

    Private Sub TogglePasswordVisibility(passwordField1 As TextBox, passwordField2 As TextBox, checkBox As CheckBox)
        If checkBox.Checked Then
            passwordField1.PasswordChar = ControlChars.NullChar
            passwordField2.PasswordChar = ControlChars.NullChar
        Else
            passwordField1.PasswordChar = "•"c
            passwordField2.PasswordChar = "•"c
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtUsername.Text = ""
        txtPass.Text = ""
        txtPassCf.Text = ""
        textNoPhone.Text = ""
        txtEmail.Text = ""
        txtAdress.Text = ""
        txtPostal.Text = ""
        txtPin.Text = ""
        txtPinCf.Text = ""
        txtUsername.Focus()
    End Sub

    Private Sub ClearPasswords()
        txtPass.Text = ""
        txtPassCf.Text = ""
        txtPin.Text = ""
        txtPinCf.Text = ""
        txtPass.Focus()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim loginForm As New frmLogin()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub TestConnection()
        Try
            con.Open()
            MessageBox.Show("Connection successful!", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Connection failed: " & ex.Message, "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub LogError(ex As Exception)
        ' This method logs errors to a file for further investigation
        System.IO.File.AppendAllText("error_log.txt", DateTime.Now.ToString() & " - " & ex.ToString() & Environment.NewLine)
    End Sub
End Class

