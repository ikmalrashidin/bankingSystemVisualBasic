<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInterface
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBoxTime = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxDate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnTopUp = New System.Windows.Forms.Button()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Db_usersDataSet = New banking_system.db_usersDataSet()
        Me.Tbl_usersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_usersTableAdapter = New banking_system.db_usersDataSetTableAdapters.tbl_usersTableAdapter()
        Me.TableAdapterManager = New banking_system.db_usersDataSetTableAdapters.TableAdapterManager()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        CType(Me.Db_usersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_usersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxTime
        '
        Me.TextBoxTime.BackColor = System.Drawing.Color.Gold
        Me.TextBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxTime.ForeColor = System.Drawing.Color.White
        Me.TextBoxTime.Location = New System.Drawing.Point(339, 41)
        Me.TextBoxTime.Name = "TextBoxTime"
        Me.TextBoxTime.ReadOnly = True
        Me.TextBoxTime.Size = New System.Drawing.Size(204, 15)
        Me.TextBoxTime.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(269, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 24)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Time :"
        '
        'TextBoxDate
        '
        Me.TextBoxDate.BackColor = System.Drawing.Color.Gold
        Me.TextBoxDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxDate.Location = New System.Drawing.Point(338, 12)
        Me.TextBoxDate.Name = "TextBoxDate"
        Me.TextBoxDate.ReadOnly = True
        Me.TextBoxDate.Size = New System.Drawing.Size(205, 15)
        Me.TextBoxDate.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(272, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 24)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Date :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(257, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 18
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(162, 96)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(0, 17)
        Me.LinkLabel1.TabIndex = 19
        '
        'btnProfile
        '
        Me.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.ForeColor = System.Drawing.Color.Black
        Me.btnProfile.Location = New System.Drawing.Point(12, 12)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(130, 36)
        Me.btnProfile.TabIndex = 47
        Me.btnProfile.Text = "PROFILE"
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.Location = New System.Drawing.Point(630, 12)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(130, 36)
        Me.btnLogout.TabIndex = 48
        Me.btnLogout.Text = "LOG OUT"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnTopUp
        '
        Me.btnTopUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTopUp.ForeColor = System.Drawing.Color.Black
        Me.btnTopUp.Location = New System.Drawing.Point(147, 225)
        Me.btnTopUp.Name = "btnTopUp"
        Me.btnTopUp.Size = New System.Drawing.Size(130, 36)
        Me.btnTopUp.TabIndex = 49
        Me.btnTopUp.Text = "TOPUP"
        Me.btnTopUp.UseVisualStyleBackColor = True
        '
        'btnTransfer
        '
        Me.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransfer.ForeColor = System.Drawing.Color.Black
        Me.btnTransfer.Location = New System.Drawing.Point(470, 225)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(130, 36)
        Me.btnTransfer.TabIndex = 50
        Me.btnTransfer.Text = "TRANSFER"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(296, 225)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(155, 36)
        Me.Button3.TabIndex = 51
        Me.Button3.Text = "TOTAL EXPENSE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Db_usersDataSet
        '
        Me.Db_usersDataSet.DataSetName = "db_usersDataSet"
        Me.Db_usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_usersBindingSource
        '
        Me.Tbl_usersBindingSource.DataMember = "tbl_users"
        Me.Tbl_usersBindingSource.DataSource = Me.Db_usersDataSet
        '
        'Tbl_usersTableAdapter
        '
        Me.Tbl_usersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_expensesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_profileTableAdapter = Nothing
        Me.TableAdapterManager.tbl_settingsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_topupsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_transactionsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_usersTableAdapter = Me.Tbl_usersTableAdapter
        Me.TableAdapterManager.UpdateOrder = banking_system.db_usersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lblUsername
        '
        Me.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUsername.Location = New System.Drawing.Point(296, 95)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(155, 38)
        Me.lblUsername.TabIndex = 52
        '
        'lblBalance
        '
        Me.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBalance.Location = New System.Drawing.Point(296, 155)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(155, 38)
        Me.lblBalance.TabIndex = 53
        '
        'FrmInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.btnTopUp)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnProfile)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxTime)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxDate)
        Me.Controls.Add(Me.Label4)
        Me.Name = "FrmInterface"
        Me.Text = "INTERFACE"
        CType(Me.Db_usersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_usersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxTime As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxDate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnTopUp As Button
    Friend WithEvents btnTransfer As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Db_usersDataSet As db_usersDataSet
    Friend WithEvents Tbl_usersBindingSource As BindingSource
    Friend WithEvents Tbl_usersTableAdapter As db_usersDataSetTableAdapters.tbl_usersTableAdapter
    Friend WithEvents TableAdapterManager As db_usersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblBalance As Label
End Class
