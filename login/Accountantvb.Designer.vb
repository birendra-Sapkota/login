<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accountantvb
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.userlabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pl1 = New System.Windows.Forms.Panel()
        Me.pl3 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.crtOderbtn = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Panel1.Controls.Add(Me.userlabel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1300, 53)
        Me.Panel1.TabIndex = 4
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
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 22.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(283, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(643, 38)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Canteen Management System Accountant Panel"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.login.My.Resources.Resources.b_close
        Me.PictureBox1.Location = New System.Drawing.Point(1236, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(193, -30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1107, 94)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Panel3.Controls.Add(Me.pl1)
        Me.Panel3.Controls.Add(Me.pl3)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.crtOderbtn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 53)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 647)
        Me.Panel3.TabIndex = 6
        '
        'pl1
        '
        Me.pl1.BackColor = System.Drawing.Color.SlateBlue
        Me.pl1.Location = New System.Drawing.Point(0, 17)
        Me.pl1.Name = "pl1"
        Me.pl1.Size = New System.Drawing.Size(8, 69)
        Me.pl1.TabIndex = 7
        Me.pl1.Visible = False
        '
        'pl3
        '
        Me.pl3.BackColor = System.Drawing.Color.SlateBlue
        Me.pl3.Location = New System.Drawing.Point(-3, 113)
        Me.pl3.Name = "pl3"
        Me.pl3.Size = New System.Drawing.Size(8, 69)
        Me.pl3.TabIndex = 7
        Me.pl3.Visible = False
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(0, 113)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(194, 69)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Log Out"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'crtOderbtn
        '
        Me.crtOderbtn.FlatAppearance.BorderSize = 0
        Me.crtOderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.crtOderbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.crtOderbtn.ForeColor = System.Drawing.Color.White
        Me.crtOderbtn.Location = New System.Drawing.Point(0, 17)
        Me.crtOderbtn.Name = "crtOderbtn"
        Me.crtOderbtn.Size = New System.Drawing.Size(197, 69)
        Me.crtOderbtn.TabIndex = 7
        Me.crtOderbtn.Text = "Create Order"
        Me.crtOderbtn.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(237, 37)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(26, 60)
        Me.Panel8.TabIndex = 11
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SlateBlue
        Me.Panel5.Location = New System.Drawing.Point(0, 17)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(8, 84)
        Me.Panel5.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SlateBlue
        Me.Panel6.Location = New System.Drawing.Point(0, 119)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(8, 84)
        Me.Panel6.TabIndex = 7
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.SlateBlue
        Me.Panel7.Location = New System.Drawing.Point(0, 218)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(8, 84)
        Me.Panel7.TabIndex = 7
        '
        'Accountantvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 700)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "Accountantvb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accountantvb"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents userlabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents crtOderbtn As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents pl1 As Panel
    Friend WithEvents pl3 As Panel
End Class
