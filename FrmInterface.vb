Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class FrmInterface
    Private loggedInUsername As String ' Field to store logged-in username

    ' Constructor that accepts username parameter
    Public Sub New(ByVal username As String)
        InitializeComponent()
        loggedInUsername = username ' Assign the passed username to loggedInUsername
    End Sub

    ' Load event to initialize the form
    Private Sub FrmInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Show current date and time
        TextBoxDate.Text = Now.ToString("D")
        TextBoxTime.Text = Now.ToString("T")

        ' Set the TextBox controls to read-only
        TextBoxDate.ReadOnly = True
        TextBoxTime.ReadOnly = True
        TextBoxDate.ForeColor = Color.Black
        TextBoxTime.ForeColor = Color.Black
        TextBoxDate.Enabled = False
        TextBoxTime.Enabled = False

        ' Retrieve and display user information
        DisplayUserInfo()
    End Sub

    ' Method to display user information
    Private Sub DisplayUserInfo()
        ' Adjust the connection string to ensure the correct path to your database file.
        Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ikmal\Documents\banking system(topup)\banking system\db_users.mdb"
        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()
                Dim command As New OleDbCommand("SELECT Username, Balance FROM tbl_users WHERE Username = @Username", connection)
                command.Parameters.AddWithValue("@Username", loggedInUsername) ' Use loggedInUsername to fetch the logged-in user's info

                Dim reader As OleDbDataReader = command.ExecuteReader()
                If reader.Read() Then
                    lblUsername.Text = reader("Username").ToString()
                    lblBalance.Text = Convert.ToDecimal(reader("Balance")).ToString("C")
                Else
                    MessageBox.Show("No data found for the logged-in user.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LogError(ex)
            End Try
        End Using
    End Sub

    ' Event handlers for buttons on the form
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        ' Open profile form
        Dim profileForm As New FrmProfile()
        profileForm.Show()
        Me.Hide() ' Hide current form
    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        Dim transferForm As New FrmTransfer(loggedInUsername)
        If transferForm.ShowDialog() = DialogResult.OK Then
            ' Transfer successful, refresh balance
            RefreshBalance(transferForm.TransferredAmount)
        End If
    End Sub

    Private Sub btnTopUp_Click(sender As Object, e As EventArgs) Handles btnTopUp.Click
        ' Open top-up form
        Dim userPIN As String = RetrieveUserPIN(loggedInUsername) ' Example function to retrieve PIN
        Dim topUpForm As New frmTopUp(loggedInUsername, userPIN)
        topUpForm.Show()
        Me.Hide() ' Hide current form
    End Sub

    Private Function RetrieveUserPIN(username As String) As String
        ' Example function to retrieve PIN from database or another source
        ' Replace with your actual logic to fetch PIN for the given username
        Return "1234" ' Example PIN; replace with your retrieval logic
    End Function

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Navigate to the login form
        Dim loginForm As New frmLogin()
        loginForm.Show()
        Me.Close() ' Close the current form
    End Sub

    ' Method to update balance after successful transfer
    Private Sub RefreshBalance(transferredAmount As Decimal)
        ' Update balance display
        Dim currentBalance As Decimal = Decimal.Parse(lblBalance.Text, Globalization.NumberStyles.Currency)
        lblBalance.Text = (currentBalance - transferredAmount).ToString("C")
    End Sub

    Private Sub LogError(ex As Exception)
        ' This method logs errors to a file for further investigation
        System.IO.File.AppendAllText("error_log.txt", DateTime.Now.ToString() & " - " & ex.ToString() & Environment.NewLine)
    End Sub
End Class

