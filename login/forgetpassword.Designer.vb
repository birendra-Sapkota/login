<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgetpassword
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.submitreqBtn = New System.Windows.Forms.Button()
        Me.cancelforgetbox = New System.Windows.Forms.Button()
        Me.newpasswordtxtbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.conformpasswordtxtbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.forgetid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.forgetusernametxtbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(490, 10)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Lavender
        Me.Panel2.Controls.Add(Me.submitreqBtn)
        Me.Panel2.Controls.Add(Me.cancelforgetbox)
        Me.Panel2.Controls.Add(Me.newpasswordtxtbox)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.conformpasswordtxtbox)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.forgetid)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.forgetusernametxtbox)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(490, 289)
        Me.Panel2.TabIndex = 1
        '
        'submitreqBtn
        '
        Me.submitreqBtn.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitreqBtn.Location = New System.Drawing.Point(245, 223)
        Me.submitreqBtn.Name = "submitreqBtn"
        Me.submitreqBtn.Size = New System.Drawing.Size(115, 32)
        Me.submitreqBtn.TabIndex = 6
        Me.submitreqBtn.Text = "Submit"
        Me.submitreqBtn.UseVisualStyleBackColor = True
        '
        'cancelforgetbox
        '
        Me.cancelforgetbox.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelforgetbox.Location = New System.Drawing.Point(102, 223)
        Me.cancelforgetbox.Name = "cancelforgetbox"
        Me.cancelforgetbox.Size = New System.Drawing.Size(95, 32)
        Me.cancelforgetbox.TabIndex = 5
        Me.cancelforgetbox.Text = "Cancel"
        Me.cancelforgetbox.UseVisualStyleBackColor = True
        '
        'newpasswordtxtbox
        '
        Me.newpasswordtxtbox.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newpasswordtxtbox.Location = New System.Drawing.Point(235, 127)
        Me.newpasswordtxtbox.Name = "newpasswordtxtbox"
        Me.newpasswordtxtbox.Size = New System.Drawing.Size(157, 25)
        Me.newpasswordtxtbox.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(99, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "New Password"
        '
        'conformpasswordtxtbox
        '
        Me.conformpasswordtxtbox.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conformpasswordtxtbox.Location = New System.Drawing.Point(235, 163)
        Me.conformpasswordtxtbox.Name = "conformpasswordtxtbox"
        Me.conformpasswordtxtbox.Size = New System.Drawing.Size(157, 25)
        Me.conformpasswordtxtbox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(99, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = " Confirm Password"
        '
        'forgetid
        '
        Me.forgetid.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forgetid.Location = New System.Drawing.Point(235, 53)
        Me.forgetid.Name = "forgetid"
        Me.forgetid.Size = New System.Drawing.Size(157, 25)
        Me.forgetid.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(99, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "User-ID"
        '
        'forgetusernametxtbox
        '
        Me.forgetusernametxtbox.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forgetusernametxtbox.Location = New System.Drawing.Point(235, 90)
        Me.forgetusernametxtbox.Name = "forgetusernametxtbox"
        Me.forgetusernametxtbox.Size = New System.Drawing.Size(157, 25)
        Me.forgetusernametxtbox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(484, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Request admin for password Change"
        '
        'forgetpassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 299)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "forgetpassword"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "forgetpassword"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents submitreqBtn As Button
    Friend WithEvents cancelforgetbox As Button
    Friend WithEvents newpasswordtxtbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents conformpasswordtxtbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents forgetusernametxtbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents forgetid As TextBox
    Friend WithEvents Label5 As Label
End Class
