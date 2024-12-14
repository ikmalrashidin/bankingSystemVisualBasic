Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class FrmTransfer
    ' Database connection string
    Private connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ikmal\Documents\banking system(topup)\banking system\db_users.mdb"

    ' Logged-in username
    Private loggedInUsername As String

    ' Amount transferred
    Public Property TransferredAmount As Decimal

    ' Constructor that accepts username parameter
    Public Sub New(ByVal username As String)
        InitializeComponent()
        loggedInUsername = username ' Assign the passed username to loggedInUsername
        lblSender.Text = loggedInUsername ' Display sender's username
    End Sub

    ' Handles button clicks for transferring money
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        ' Validate the sender's bank account
        If Not ValidateBankAccount(lblSender.Text) Then
            Return
        End If

        ' Get the transfer type
        Dim transferType As String = GetTransferType()

        ' Ensure transfer type is selected
        If Not String.IsNullOrEmpty(transferType) Then
            ' Validate the receiver's username
            Dim receiverUsername As String = txtUsername.Text
            If Not ValidateReceiverUsername(receiverUsername) Then
                Return
            End If

            ' Get the amount to transfer
            Dim amount As Decimal
            If Not Decimal.TryParse(txtbxAmount.Text, amount) OrElse amount <= 0 Then
                MessageBox.Show("Please enter a valid amount.")
                Return
            End If

            ' Check if sender has sufficient balance
            If Not CheckSufficientBalance(loggedInUsername, amount) Then
                MessageBox.Show("Insufficient balance. Please enter a lower amount.")
                Return
            End If

            ' Prompt for PIN verification
            Dim enteredPin As String = InputBox("Please enter your PIN:", "PIN Verification")
            If String.IsNullOrWhiteSpace(enteredPin) Then
                MessageBox.Show("PIN entry cancelled.")
                Return
            End If

            If Not ValidatePin(loggedInUsername, enteredPin) Then
                MessageBox.Show("Invalid PIN. Please try again.")
                Return
            End If

            ' Deduct amount from sender's balance
            If DeductFromBalance(loggedInUsername, amount) Then
                ' Add the transaction to the database
                If AddTransactionToDatabase(loggedInUsername, receiverUsername, amount, DateTime.Now, transferType) Then
                    ' Set the transferred amount for interface form
                    TransferredAmount = amount
                    MessageBox.Show("Transfer successful.")
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    MessageBox.Show("Failed to complete the transfer.")
                    ' Revert the deducted amount on failure
                    AddToBalance(loggedInUsername, amount)
                End If
            Else
                MessageBox.Show("Failed to deduct amount from your balance.")
            End If
        Else
            MessageBox.Show("Please select a transfer type.")
        End If
    End Sub

    ' Validates the sender's bank account
    Private Function ValidateBankAccount(ByVal username As String) As Boolean
        If String.IsNullOrWhiteSpace(username) Then
            MessageBox.Show("Please enter a valid bank account number.")
            Return False
        End If
        ' Further validation logic can be added here
        Return True
    End Function

    ' Validates the receiver's username
    Private Function ValidateReceiverUsername(ByVal username As String) As Boolean
        If String.IsNullOrWhiteSpace(username) Then
            MessageBox.Show("Please enter a valid username.")
            Return False
        End If

        ' Check if the username exists in the database
        Using connection As New OleDbConnection(connectionString)
            Dim query As String = "SELECT COUNT(*) FROM tbl_users WHERE username = @username"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                Try
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    If count = 0 Then
                        MessageBox.Show("Username does not exist. Please re-enter the username.")
                        Return False
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                    Return False
                End Try
            End Using
        End Using
        Return True
    End Function

    ' Validates the user's PIN
    Private Function ValidatePin(ByVal username As String, ByVal pin As String) As Boolean
        Using connection As New OleDbConnection(connectionString)
            Dim query As String = "SELECT pin FROM tbl_users WHERE username = @username"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                Try
                    connection.Open()
                    Dim storedPin As String = Convert.ToString(command.ExecuteScalar())
                    If storedPin = pin Then
                        Return True
                    Else
                        Return False
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                    Return False
                End Try
            End Using
        End Using
    End Function

    ' Retrieves the selected transfer type
    Private Function GetTransferType() As String
        If chkQr.Checked Then
            Return "QR"
        ElseIf chkIT.Checked Then
            Return "Normal Transfer"
        Else
            Return String.Empty
        End If
    End Function

    ' Adds a transaction record to the database
    Private Function AddTransactionToDatabase(senderUsername As String, receiverUsername As String, amount As Decimal, transactionDate As DateTime, transactionType As String) As Boolean
        Dim query As String = "INSERT INTO tbl_transactions (sender_username, receiver_username, amount, transaction_date, transaction_type) VALUES (@sender_username, @receiver_username, @amount, @transaction_date, @transaction_type)"

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@sender_username", senderUsername)
                command.Parameters.AddWithValue("@receiver_username", receiverUsername)
                command.Parameters.AddWithValue("@amount", amount)
                command.Parameters.AddWithValue("@transaction_date", transactionDate)
                command.Parameters.AddWithValue("@transaction_type", transactionType)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    Return True
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                    Return False
                End Try
            End Using
        End Using
    End Function

    ' Checks if the sender has sufficient balance
    Private Function CheckSufficientBalance(ByVal username As String, ByVal amount As Decimal) As Boolean
        Dim currentBalance As Decimal = GetCurrentBalance(username)
        Return currentBalance >= amount
    End Function

    ' Retrieves the current balance of the user
    Private Function GetCurrentBalance(ByVal username As String) As Decimal
        Dim balance As Decimal = 0.0

        Using connection As New OleDbConnection(connectionString)
            Dim query As String = "SELECT Balance FROM tbl_users WHERE Username = @Username"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                Try
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        balance = Convert.ToDecimal(result)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using

        Return balance
    End Function

    ' Deducts the specified amount from the user's balance
    Private Function DeductFromBalance(ByVal username As String, ByVal amount As Decimal) As Boolean
        Dim currentBalance As Decimal = GetCurrentBalance(username)
        If currentBalance < amount Then
            Return False
        End If

        Dim newBalance As Decimal = currentBalance - amount

        ' Update the balance in the database
        Dim query As String = "UPDATE tbl_users SET Balance = @Balance WHERE Username = @Username"

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@Balance", newBalance)
                command.Parameters.AddWithValue("@Username", username)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    Return True
                Catch ex As Exception
                    MessageBox.Show("Error updating balance: " & ex.Message)
                    Return False
                End Try
            End Using
        End Using
    End Function

    ' Adds the specified amount to the user's balance
    Private Function AddToBalance(ByVal username As String, ByVal amount As Decimal) As Boolean
        Dim currentBalance As Decimal = GetCurrentBalance(username)
        Dim newBalance As Decimal = currentBalance + amount

        ' Update the balance in the database
        Dim query As String = "UPDATE tbl_users SET Balance = @Balance WHERE Username = @Username"

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@Balance", newBalance)
                command.Parameters.AddWithValue("@Username", username)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    Return True
                Catch ex As Exception
                    MessageBox.Show("Error updating balance: " & ex.Message)
                    Return False
                End Try
            End Using
        End Using
    End Function

    Private Sub FrmTransfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialization code here
    End Sub

    Private Sub txtbxAmount_TextChanged(sender As Object, e As EventArgs) Handles txtbxAmount.TextChanged
        ' Code to handle text change in amount textbox
    End Sub
End Class

