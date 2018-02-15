<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginform
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
        Me.components = New System.ComponentModel.Container()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Passwordtxtbox = New System.Windows.Forms.TextBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 30.75!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(87, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(55, 114)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(212, 64)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 20
        Me.BunifuElipse2.TargetControl = Me.loginbtn
        '
        'loginbtn
        '
        Me.loginbtn.BackColor = System.Drawing.Color.Turquoise
        Me.loginbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.loginbtn.FlatAppearance.BorderSize = 0
        Me.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginbtn.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbtn.Image = Global.login.My.Resources.Resources.user
        Me.loginbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.loginbtn.Location = New System.Drawing.Point(96, 300)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(125, 46)
        Me.loginbtn.TabIndex = 3
        Me.loginbtn.Text = "LogIn"
        Me.loginbtn.UseVisualStyleBackColor = False
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UsernameTextBox.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.UsernameTextBox.Location = New System.Drawing.Point(76, 135)
        Me.UsernameTextBox.Multiline = True
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(174, 28)
        Me.UsernameTextBox.TabIndex = 1
        Me.UsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(55, 210)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(212, 64)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Passwordtxtbox
        '
        Me.Passwordtxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Passwordtxtbox.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.Passwordtxtbox.Location = New System.Drawing.Point(76, 231)
        Me.Passwordtxtbox.Multiline = True
        Me.Passwordtxtbox.Name = "Passwordtxtbox"
        Me.Passwordtxtbox.Size = New System.Drawing.Size(174, 28)
        Me.Passwordtxtbox.TabIndex = 2
        Me.Passwordtxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(109, 363)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(85, 13)
        Me.LinkLabel2.TabIndex = 4
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Forget password"
        '
        'cancelbtn
        '
        Me.cancelbtn.BackColor = System.Drawing.Color.Turquoise
        Me.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.cancelbtn.FlatAppearance.BorderSize = 0
        Me.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelbtn.Font = New System.Drawing.Font("Verdana", 7.25!)
        Me.cancelbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancelbtn.Location = New System.Drawing.Point(247, 428)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(50, 27)
        Me.cancelbtn.TabIndex = 3
        Me.cancelbtn.Text = "cancel"
        Me.cancelbtn.UseVisualStyleBackColor = False
        '
        'loginform
        '
        Me.AcceptButton = Me.loginbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.CancelButton = Me.cancelbtn
        Me.ClientSize = New System.Drawing.Size(336, 422)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.loginbtn)
        Me.Controls.Add(Me.Passwordtxtbox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loginform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Passwordtxtbox As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents loginbtn As Button
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents cancelbtn As Button
End Class
