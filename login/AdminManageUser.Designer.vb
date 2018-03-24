<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminManageUser
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUser1 = New login.AddUser()
        Me.UpdateUser1 = New login.updateUser()
        Me.UserList1 = New login.UserList()
        Me.Salary1 = New login.Salary()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(362, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "User Management"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Location = New System.Drawing.Point(29, 34)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(941, 10)
        Me.Panel3.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1035, 38)
        Me.Panel1.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalaryToolStripMenuItem, Me.AddUserToolStripMenuItem, Me.UpdateUserToolStripMenuItem, Me.ListOfUsersToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(29, 40)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(428, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalaryToolStripMenuItem
        '
        Me.SalaryToolStripMenuItem.Name = "SalaryToolStripMenuItem"
        Me.SalaryToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.SalaryToolStripMenuItem.Text = "Salary"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.AddUserToolStripMenuItem.Text = " add User"
        '
        'UpdateUserToolStripMenuItem
        '
        Me.UpdateUserToolStripMenuItem.Name = "UpdateUserToolStripMenuItem"
        Me.UpdateUserToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.UpdateUserToolStripMenuItem.Text = "Update User"
        '
        'ListOfUsersToolStripMenuItem
        '
        Me.ListOfUsersToolStripMenuItem.Name = "ListOfUsersToolStripMenuItem"
        Me.ListOfUsersToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.ListOfUsersToolStripMenuItem.Text = "List Of users"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem1.Text = " "
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem2.Text = " "
        '
        'AddUser1
        '
        Me.AddUser1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddUser1.Location = New System.Drawing.Point(29, 68)
        Me.AddUser1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AddUser1.Name = "AddUser1"
        Me.AddUser1.Size = New System.Drawing.Size(979, 489)
        Me.AddUser1.TabIndex = 4
        Me.AddUser1.Visible = False
        '
        'UpdateUser1
        '
        Me.UpdateUser1.Location = New System.Drawing.Point(29, 68)
        Me.UpdateUser1.Name = "UpdateUser1"
        Me.UpdateUser1.Size = New System.Drawing.Size(991, 489)
        Me.UpdateUser1.TabIndex = 5
        Me.UpdateUser1.Visible = False
        '
        'UserList1
        '
        Me.UserList1.Location = New System.Drawing.Point(12, 81)
        Me.UserList1.Name = "UserList1"
        Me.UserList1.Size = New System.Drawing.Size(1008, 499)
        Me.UserList1.TabIndex = 6
        '
        'Salary1
        '
        Me.Salary1.Location = New System.Drawing.Point(13, 81)
        Me.Salary1.Name = "Salary1"
        Me.Salary1.Size = New System.Drawing.Size(1008, 499)
        Me.Salary1.TabIndex = 7
        Me.Salary1.Visible = False
        '
        'AdminManageUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 575)
        Me.Controls.Add(Me.Salary1)
        Me.Controls.Add(Me.UserList1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UpdateUser1)
        Me.Controls.Add(Me.AddUser1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminManageUser"
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents AddUser1 As AddUser
    Friend WithEvents UpdateUser1 As updateUser
    Friend WithEvents UserList1 As UserList
    Friend WithEvents Salary1 As Salary
End Class
