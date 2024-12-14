<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransfer
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkQr = New System.Windows.Forms.CheckBox()
        Me.chkIT = New System.Windows.Forms.CheckBox()
        Me.txtbxAmount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSender = New System.Windows.Forms.Label()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(293, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(222, 54)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "TRANSFER"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(356, 205)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(275, 31)
        Me.txtUsername.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(218, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 28)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Username :"
        '
        'chkQr
        '
        Me.chkQr.AutoSize = True
        Me.chkQr.Location = New System.Drawing.Point(286, 300)
        Me.chkQr.Name = "chkQr"
        Me.chkQr.Size = New System.Drawing.Size(49, 20)
        Me.chkQr.TabIndex = 15
        Me.chkQr.Text = "QR"
        Me.chkQr.UseVisualStyleBackColor = True
        '
        'chkIT
        '
        Me.chkIT.AutoSize = True
        Me.chkIT.Location = New System.Drawing.Point(399, 300)
        Me.chkIT.Name = "chkIT"
        Me.chkIT.Size = New System.Drawing.Size(120, 20)
        Me.chkIT.TabIndex = 16
        Me.chkIT.Text = "Instant Transfer"
        Me.chkIT.UseVisualStyleBackColor = True
        '
        'txtbxAmount
        '
        Me.txtbxAmount.Location = New System.Drawing.Point(356, 251)
        Me.txtbxAmount.Multiline = True
        Me.txtbxAmount.Name = "txtbxAmount"
        Me.txtbxAmount.Size = New System.Drawing.Size(275, 31)
        Me.txtbxAmount.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 251)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 28)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Amount :"
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(658, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(130, 36)
        Me.btnBack.TabIndex = 48
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(147, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 28)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Sender Username :"
        '
        'lblSender
        '
        Me.lblSender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSender.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSender.Location = New System.Drawing.Point(337, 162)
        Me.lblSender.Name = "lblSender"
        Me.lblSender.Size = New System.Drawing.Size(188, 28)
        Me.lblSender.TabIndex = 50
        '
        'btnPay
        '
        Me.btnPay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPay.ForeColor = System.Drawing.Color.Black
        Me.btnPay.Location = New System.Drawing.Point(302, 349)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(130, 36)
        Me.btnPay.TabIndex = 51
        Me.btnPay.Text = "PAY !"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'FrmTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.lblSender)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtbxAmount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkIT)
        Me.Controls.Add(Me.chkQr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FrmTransfer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkQr As CheckBox
    Friend WithEvents chkIT As CheckBox
    Friend WithEvents txtbxAmount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSender As Label
    Friend WithEvents btnPay As Button
End Class
