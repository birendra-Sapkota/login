<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.userlabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.timestatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.usernotification = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnl6 = New System.Windows.Forms.Panel()
        Me.pnl5 = New System.Windows.Forms.Panel()
        Me.pnl4 = New System.Windows.Forms.Panel()
        Me.pnl2 = New System.Windows.Forms.Panel()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.adminlogoutBtn = New System.Windows.Forms.Button()
        Me.AdminCheckRequestBTN = New System.Windows.Forms.Button()
        Me.AdminManageUserBTN = New System.Windows.Forms.Button()
        Me.adminInventoryBTN = New System.Windows.Forms.Button()
        Me.admincheckreportBTN = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.userlabel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 59)
        Me.Panel1.TabIndex = 3
        '
        'userlabel
        '
        Me.userlabel.AutoSize = True
        Me.userlabel.Font = New System.Drawing.Font("Poor Richard", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userlabel.Location = New System.Drawing.Point(45, 14)
        Me.userlabel.Name = "userlabel"
        Me.userlabel.Size = New System.Drawing.Size(0, 22)
        Me.userlabel.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(340, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(678, 35)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Canteen Management System Admin Panel"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.RoyalBlue
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.login.My.Resources.Resources.b_close
        Me.PictureBox1.Location = New System.Drawing.Point(1251, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.timestatus, Me.usernotification})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 691)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1284, 9)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'timestatus
        '
        Me.timestatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.timestatus.Name = "timestatus"
        Me.timestatus.Size = New System.Drawing.Size(4, 4)
        '
        'usernotification
        '
        Me.usernotification.Name = "usernotification"
        Me.usernotification.Size = New System.Drawing.Size(0, 0)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.pnl6)
        Me.Panel2.Controls.Add(Me.pnl5)
        Me.Panel2.Controls.Add(Me.pnl4)
        Me.Panel2.Controls.Add(Me.pnl2)
        Me.Panel2.Controls.Add(Me.pnl1)
        Me.Panel2.Controls.Add(Me.adminlogoutBtn)
        Me.Panel2.Controls.Add(Me.AdminCheckRequestBTN)
        Me.Panel2.Controls.Add(Me.adminInventoryBTN)
        Me.Panel2.Controls.Add(Me.AdminManageUserBTN)
        Me.Panel2.Controls.Add(Me.admincheckreportBTN)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 632)
        Me.Panel2.TabIndex = 8
        '
        'pnl6
        '
        Me.pnl6.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pnl6.Location = New System.Drawing.Point(0, 420)
        Me.pnl6.Name = "pnl6"
        Me.pnl6.Size = New System.Drawing.Size(8, 77)
        Me.pnl6.TabIndex = 12
        Me.pnl6.Visible = False
        '
        'pnl5
        '
        Me.pnl5.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pnl5.Location = New System.Drawing.Point(3, 216)
        Me.pnl5.Name = "pnl5"
        Me.pnl5.Size = New System.Drawing.Size(8, 87)
        Me.pnl5.TabIndex = 12
        Me.pnl5.Visible = False
        '
        'pnl4
        '
        Me.pnl4.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pnl4.Location = New System.Drawing.Point(3, 109)
        Me.pnl4.Name = "pnl4"
        Me.pnl4.Size = New System.Drawing.Size(8, 87)
        Me.pnl4.TabIndex = 12
        Me.pnl4.Visible = False
        '
        'pnl2
        '
        Me.pnl2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pnl2.Location = New System.Drawing.Point(3, 309)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(8, 87)
        Me.pnl2.TabIndex = 11
        Me.pnl2.Visible = False
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pnl1.Location = New System.Drawing.Point(3, 6)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(8, 81)
        Me.pnl1.TabIndex = 10
        Me.pnl1.Visible = False
        '
        'adminlogoutBtn
        '
        Me.adminlogoutBtn.FlatAppearance.BorderSize = 0
        Me.adminlogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adminlogoutBtn.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.adminlogoutBtn.Location = New System.Drawing.Point(3, 420)
        Me.adminlogoutBtn.Name = "adminlogoutBtn"
        Me.adminlogoutBtn.Size = New System.Drawing.Size(194, 77)
        Me.adminlogoutBtn.TabIndex = 0
        Me.adminlogoutBtn.Text = "Log Out"
        Me.adminlogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.adminlogoutBtn.UseVisualStyleBackColor = True
        '
        'AdminCheckRequestBTN
        '
        Me.AdminCheckRequestBTN.FlatAppearance.BorderSize = 0
        Me.AdminCheckRequestBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdminCheckRequestBTN.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.AdminCheckRequestBTN.Location = New System.Drawing.Point(3, 216)
        Me.AdminCheckRequestBTN.Name = "AdminCheckRequestBTN"
        Me.AdminCheckRequestBTN.Size = New System.Drawing.Size(197, 87)
        Me.AdminCheckRequestBTN.TabIndex = 0
        Me.AdminCheckRequestBTN.Text = "Message"
        Me.AdminCheckRequestBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AdminCheckRequestBTN.UseVisualStyleBackColor = True
        '
        'AdminManageUserBTN
        '
        Me.AdminManageUserBTN.FlatAppearance.BorderSize = 0
        Me.AdminManageUserBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdminManageUserBTN.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.AdminManageUserBTN.Location = New System.Drawing.Point(6, 110)
        Me.AdminManageUserBTN.Name = "AdminManageUserBTN"
        Me.AdminManageUserBTN.Size = New System.Drawing.Size(197, 87)
        Me.AdminManageUserBTN.TabIndex = 0
        Me.AdminManageUserBTN.Text = "Manage User"
        Me.AdminManageUserBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AdminManageUserBTN.UseVisualStyleBackColor = True
        '
        'adminInventoryBTN
        '
        Me.adminInventoryBTN.FlatAppearance.BorderSize = 0
        Me.adminInventoryBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adminInventoryBTN.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.adminInventoryBTN.Location = New System.Drawing.Point(3, 310)
        Me.adminInventoryBTN.Name = "adminInventoryBTN"
        Me.adminInventoryBTN.Size = New System.Drawing.Size(197, 87)
        Me.adminInventoryBTN.TabIndex = 0
        Me.adminInventoryBTN.Text = "Inventory Management"
        Me.adminInventoryBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.adminInventoryBTN.UseVisualStyleBackColor = True
        '
        'admincheckreportBTN
        '
        Me.admincheckreportBTN.FlatAppearance.BorderSize = 0
        Me.admincheckreportBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.admincheckreportBTN.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.admincheckreportBTN.Location = New System.Drawing.Point(3, 6)
        Me.admincheckreportBTN.Name = "admincheckreportBTN"
        Me.admincheckreportBTN.Size = New System.Drawing.Size(197, 81)
        Me.admincheckreportBTN.TabIndex = 0
        Me.admincheckreportBTN.Text = "Check Report"
        Me.admincheckreportBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.admincheckreportBTN.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel3.Location = New System.Drawing.Point(237, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(26, 60)
        Me.Panel3.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Location = New System.Drawing.Point(200, 59)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1084, 13)
        Me.Panel4.TabIndex = 12
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 700)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents userlabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents timestatus As ToolStripStatusLabel
    Friend WithEvents usernotification As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AdminCheckRequestBTN As Button
    Friend WithEvents AdminManageUserBTN As Button
    Friend WithEvents adminInventoryBTN As Button
    Friend WithEvents admincheckreportBTN As Button
    Friend WithEvents adminlogoutBtn As Button
    Friend WithEvents pnl4 As Panel
    Friend WithEvents pnl2 As Panel
    Friend WithEvents pnl1 As Panel
    Friend WithEvents pnl5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pnl6 As Panel
    Friend WithEvents Panel4 As Panel
End Class
