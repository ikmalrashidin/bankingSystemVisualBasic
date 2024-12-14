Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class frmTopUp
    ' Database connection string
    Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ikmal\Documents\banking system(topup)\banking system\db_users.mdb"
    Dim con As New OleDbConnection(connectionString)
    Dim loggedInUsername As String  ' Field to store logged-in username
    Dim userPIN As String = ""  ' Field to store user's PIN

    ' Constructor that accepts username and PIN parameters
    Public Sub New(ByVal username As String, ByVal pin As String)
        InitializeComponent()
        loggedInUsername = username  ' Assign the passed username to loggedInUsername
        userPIN = pin  ' Assign the passed PIN to userPIN
    End Sub

    Private Sub frmTopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Any initialization code here
    End Sub

    ' MenuStrip: File -> Exit
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim interfaceForm As New FrmInterface(loggedInUsername)
        interfaceForm.Show()
        Me.Hide()
    End Sub

    ' MenuStrip: View -> Refresh
    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        ' Refresh the form or update data as needed
        ' Example: Reload top-up amounts
        LoadTopUpAmounts()
    End Sub

    ' MenuStrip: Top-Up -> $10
    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        ProcessTopUp(10.0)
    End Sub

    ' MenuStrip: Top-Up -> $20
    Private Sub ToolStripMenuItem20_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        ProcessTopUp(20.0)
    End Sub

    ' MenuStrip: Top-Up -> $30
    Private Sub ToolStripMenuItem30_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        ProcessTopUp(30.0)
    End Sub

    ' MenuStrip: Help -> Customer Service
    Private Sub CustomerServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerServiceToolStripMenuItem.Click
        ' Replace with actual customer service number
        MessageBox.Show("Call customer service at 01139935236.", "Customer Service", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' MenuStrip: Account -> Profile
    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileToolStripMenuItem.Click
        Dim profileForm As New FrmProfile()
        profileForm.Show()
        Me.Hide()
    End Sub

    ' MenuStrip: Account -> Balance
    Private Sub BalanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BalanceToolStripMenuItem.Click
        Dim interfaceForm As New FrmInterface(loggedInUsername)
        interfaceForm.Show()
        Me.Hide()
    End Sub

    ' Process top-up for a specific amount
    Private Sub ProcessTopUp(amount As Decimal)
        ' Validate amount (if needed)
        If amount <= 0 Then
            MessageBox.Show("Invalid top-up amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Retrieve stored PIN from the database for verification
        Dim storedPIN As String = GetStoredPIN(loggedInUsername)

        ' Prompt user for PIN verification
        Dim inputPIN As String = InputBox("Enter your PIN to confirm the top-up:", "PIN Verification")

        ' Check if entered PIN matches user's stored PIN
        If inputPIN <> storedPIN Then
            MessageBox.Show("Incorrect PIN. Top-up canceled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Calculate service charge (6%)
        Dim serviceCharge As Decimal = amount * 0.06
        Dim totalAmount As Decimal = amount - serviceCharge

        ' Insert into database and update balance
        Try
            con.Open()
            Dim transaction As OleDbTransaction = con.BeginTransaction()

            ' Insert top-up record
            Dim insertQuery As String = "INSERT INTO tbl_topups (username, amount, topup_date) VALUES (@Username, @Amount, @TopUpDate)"
            Using cmd As New OleDbCommand(insertQuery, con, transaction)
                cmd.Parameters.Add("@Username", OleDbType.VarChar).Value = loggedInUsername
                cmd.Parameters.Add("@Amount", OleDbType.Currency).Value = totalAmount
                cmd.Parameters.Add("@TopUpDate", OleDbType.Date).Value = DateTime.Now

                cmd.ExecuteNonQuery()
            End Using

            ' Update user balance
            Dim updateQuery As String = "UPDATE tbl_users SET balance = balance + @Amount WHERE username = @Username"
            Using cmd As New OleDbCommand(updateQuery, con, transaction)
                cmd.Parameters.Add("@Amount", OleDbType.Currency).Value = amount
                cmd.Parameters.Add("@Username", OleDbType.VarChar).Value = loggedInUsername

                cmd.ExecuteNonQuery()
            End Using

            transaction.Commit()

            MessageBox.Show("Top-up successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Navigate back to frmInterface
            Dim interfaceForm As New FrmInterface(loggedInUsername)
            interfaceForm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    ' Method to retrieve stored PIN from the database
    Private Function GetStoredPIN(username As String) As String
        Dim storedPIN As String = ""
        Try
            con.Open()
            Dim query As String = "SELECT pin FROM tbl_users WHERE username = @Username"
            Using cmd As New OleDbCommand(query, con)
                cmd.Parameters.Add("@Username", OleDbType.VarChar).Value = username
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    storedPIN = reader("pin").ToString()
                End If
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
        Return storedPIN
    End Function

    ' Example: Method to load top-up amounts or refresh data
    Private Sub LoadTopUpAmounts()
        ' Implement as needed to refresh or load data from database
        ' Example: Refresh list of available top-up amounts
    End Sub

    ' Numeric button click event handlers
    Private Sub btnNumeric_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, Btn3.Click,
                                                                           btn4.Click, btn5.Click, btn6.Click,
                                                                           btn7.Click, btn8.Click, btn9.Click,
                                                                           btn0.Click
        Dim button As Button = DirectCast(sender, Button)
        txtboxamount.Text += button.Text
    End Sub

    ' Button: Enter amount (example)
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' Example: Process top-up when Enter button is clicked
        If Not String.IsNullOrEmpty(txtboxamount.Text) Then
            Dim amount As Decimal
            If Decimal.TryParse(txtboxamount.Text, amount) Then
                ProcessTopUp(amount)
            Else
                MessageBox.Show("Invalid amount entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please enter an amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    ' Button: Clear amount input
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtboxamount.Text = ""
    End Sub
End Class