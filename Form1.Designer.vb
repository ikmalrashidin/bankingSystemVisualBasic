<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassCf = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.checkBxPass = New System.Windows.Forms.CheckBox()
        Me.textNoPhone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAdress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPostal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.checkBxPin = New System.Windows.Forms.CheckBox()
        Me.txtPinCf = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPin = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(184, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GET STARTED WITH CROSO BANK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(17, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username :"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(126, 96)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(190, 31)
        Me.txtUsername.TabIndex = 2
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.White
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(126, 146)
        Me.txtPass.Multiline = True
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPass.Size = New System.Drawing.Size(190, 31)
        Me.txtPass.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(22, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password :"
        '
        'txtPassCf
        '
        Me.txtPassCf.BackColor = System.Drawing.Color.White
        Me.txtPassCf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassCf.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassCf.Location = New System.Drawing.Point(126, 203)
        Me.txtPassCf.Multiline = True
        Me.txtPassCf.Name = "txtPassCf"
        Me.txtPassCf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassCf.Size = New System.Drawing.Size(190, 31)
        Me.txtPassCf.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(17, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 46)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Confirm " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password :"
        '
        'checkBxPass
        '
        Me.checkBxPass.AutoSize = True
        Me.checkBxPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checkBxPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBxPass.Font = New System.Drawing.Font("Nirmala UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBxPass.ForeColor = System.Drawing.Color.Black
        Me.checkBxPass.Location = New System.Drawing.Point(181, 240)
        Me.checkBxPass.Name = "checkBxPass"
        Me.checkBxPass.Size = New System.Drawing.Size(131, 23)
        Me.checkBxPass.TabIndex = 7
        Me.checkBxPass.Text = "Show Password"
        Me.checkBxPass.UseVisualStyleBackColor = True
        '
        'textNoPhone
        '
        Me.textNoPhone.BackColor = System.Drawing.Color.White
        Me.textNoPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textNoPhone.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textNoPhone.Location = New System.Drawing.Point(122, 284)
        Me.textNoPhone.Multiline = True
        Me.textNoPhone.Name = "textNoPhone"
        Me.textNoPhone.Size = New System.Drawing.Size(190, 31)
        Me.textNoPhone.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(18, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "No.Phone :"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(122, 334)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(190, 31)
        Me.txtEmail.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(51, 334)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Email :"
        '
        'txtAdress
        '
        Me.txtAdress.BackColor = System.Drawing.Color.White
        Me.txtAdress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAdress.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdress.Location = New System.Drawing.Point(477, 96)
        Me.txtAdress.Multiline = True
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(256, 81)
        Me.txtAdress.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(387, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Address :"
        '
        'txtPostal
        '
        Me.txtPostal.BackColor = System.Drawing.Color.White
        Me.txtPostal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPostal.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostal.Location = New System.Drawing.Point(477, 198)
        Me.txtPostal.Multiline = True
        Me.txtPostal.Name = "txtPostal"
        Me.txtPostal.Size = New System.Drawing.Size(190, 31)
        Me.txtPostal.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(358, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 23)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Postal Code :"
        '
        'checkBxPin
        '
        Me.checkBxPin.AutoSize = True
        Me.checkBxPin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checkBxPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBxPin.Font = New System.Drawing.Font("Nirmala UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBxPin.ForeColor = System.Drawing.Color.Black
        Me.checkBxPin.Location = New System.Drawing.Point(579, 343)
        Me.checkBxPin.Name = "checkBxPin"
        Me.checkBxPin.Size = New System.Drawing.Size(88, 23)
        Me.checkBxPin.TabIndex = 20
        Me.checkBxPin.Text = "Show Pin"
        Me.checkBxPin.UseVisualStyleBackColor = True
        '
        'txtPinCf
        '
        Me.txtPinCf.BackColor = System.Drawing.Color.White
        Me.txtPinCf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPinCf.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPinCf.Location = New System.Drawing.Point(477, 306)
        Me.txtPinCf.Multiline = True
        Me.txtPinCf.Name = "txtPinCf"
        Me.txtPinCf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPinCf.Size = New System.Drawing.Size(190, 31)
        Me.txtPinCf.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(355, 311)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 23)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Confirm Pin :"
        '
        'txtPin
        '
        Me.txtPin.BackColor = System.Drawing.Color.White
        Me.txtPin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPin.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPin.Location = New System.Drawing.Point(477, 249)
        Me.txtPin.Multiline = True
        Me.txtPin.Name = "txtPin"
        Me.txtPin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPin.Size = New System.Drawing.Size(190, 31)
        Me.txtPin.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(426, 254)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 23)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Pin :"
        '
        'btnRegister
        '
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.ForeColor = System.Drawing.Color.Black
        Me.btnRegister.Location = New System.Drawing.Point(324, 373)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(161, 36)
        Me.btnRegister.TabIndex = 21
        Me.btnRegister.Text = "REGISTER"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(342, 424)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(129, 36)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(300, 473)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(217, 23)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Already have an account ?"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(351, 505)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 23)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Back to Login"
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(806, 556)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.checkBxPin)
        Me.Controls.Add(Me.txtPinCf)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPin)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPostal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAdress)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.textNoPhone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.checkBxPass)
        Me.Controls.Add(Me.txtPassCf)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRegister"
        Me.Text = "Registiration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassCf As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents checkBxPass As CheckBox
    Friend WithEvents textNoPhone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAdress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPostal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents checkBxPin As CheckBox
    Friend WithEvents txtPinCf As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPin As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
