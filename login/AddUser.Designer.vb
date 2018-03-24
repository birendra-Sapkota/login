<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FirstNameTxtBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LastNameTxtBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SalaryTxtBox = New System.Windows.Forms.TextBox()
        Me.EmailTxtBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.AddressTxtBox = New System.Windows.Forms.TextBox()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.WrkStartedDateTime = New System.Windows.Forms.DateTimePicker()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.radioMale = New System.Windows.Forms.RadioButton()
        Me.RadioFemale = New System.Windows.Forms.RadioButton()
        Me.UsertypeGrpBox = New System.Windows.Forms.ComboBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.passwordtxtbox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.usernametxtbox = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.userIdTxtbox = New System.Windows.Forms.MaskedTextBox()
        Me.PhoneNumberTxtBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UserId"
        '
        'SaveBtn
        '
        Me.SaveBtn.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.SaveBtn.Location = New System.Drawing.Point(226, 432)
        Me.SaveBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(124, 39)
        Me.SaveBtn.TabIndex = 12
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "First Name"
        '
        'FirstNameTxtBox
        '
        Me.FirstNameTxtBox.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.FirstNameTxtBox.Location = New System.Drawing.Point(226, 133)
        Me.FirstNameTxtBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FirstNameTxtBox.Name = "FirstNameTxtBox"
        Me.FirstNameTxtBox.Size = New System.Drawing.Size(194, 22)
        Me.FirstNameTxtBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Usertype"
        '
        'LastNameTxtBox
        '
        Me.LastNameTxtBox.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LastNameTxtBox.Location = New System.Drawing.Point(226, 186)
        Me.LastNameTxtBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LastNameTxtBox.Name = "LastNameTxtBox"
        Me.LastNameTxtBox.Size = New System.Drawing.Size(194, 22)
        Me.LastNameTxtBox.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(78, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Phone Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(471, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Work Started"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(471, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Salary"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(471, 314)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "E-Mail"
        '
        'SalaryTxtBox
        '
        Me.SalaryTxtBox.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.SalaryTxtBox.Location = New System.Drawing.Point(617, 201)
        Me.SalaryTxtBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SalaryTxtBox.Name = "SalaryTxtBox"
        Me.SalaryTxtBox.Size = New System.Drawing.Size(200, 22)
        Me.SalaryTxtBox.TabIndex = 9
        '
        'EmailTxtBox
        '
        Me.EmailTxtBox.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.EmailTxtBox.Location = New System.Drawing.Point(617, 314)
        Me.EmailTxtBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmailTxtBox.Name = "EmailTxtBox"
        Me.EmailTxtBox.Size = New System.Drawing.Size(200, 22)
        Me.EmailTxtBox.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(471, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(471, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Gender"
        '
        'AddressTxtBox
        '
        Me.AddressTxtBox.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.AddressTxtBox.Location = New System.Drawing.Point(617, 79)
        Me.AddressTxtBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AddressTxtBox.Name = "AddressTxtBox"
        Me.AddressTxtBox.Size = New System.Drawing.Size(200, 22)
        Me.AddressTxtBox.TabIndex = 6
        '
        'ClearBtn
        '
        Me.ClearBtn.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.ClearBtn.Location = New System.Drawing.Point(413, 429)
        Me.ClearBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(111, 44)
        Me.ClearBtn.TabIndex = 13
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'WrkStartedDateTime
        '
        Me.WrkStartedDateTime.Location = New System.Drawing.Point(617, 260)
        Me.WrkStartedDateTime.Name = "WrkStartedDateTime"
        Me.WrkStartedDateTime.Size = New System.Drawing.Size(200, 22)
        Me.WrkStartedDateTime.TabIndex = 10
        '
        'ExitBtn
        '
        Me.ExitBtn.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.ExitBtn.Location = New System.Drawing.Point(605, 434)
        Me.ExitBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(124, 39)
        Me.ExitBtn.TabIndex = 14
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'radioMale
        '
        Me.radioMale.AutoSize = True
        Me.radioMale.Location = New System.Drawing.Point(617, 133)
        Me.radioMale.Name = "radioMale"
        Me.radioMale.Size = New System.Drawing.Size(56, 20)
        Me.radioMale.TabIndex = 7
        Me.radioMale.TabStop = True
        Me.radioMale.Text = "Male"
        Me.radioMale.UseVisualStyleBackColor = True
        '
        'RadioFemale
        '
        Me.RadioFemale.AutoSize = True
        Me.RadioFemale.Location = New System.Drawing.Point(725, 131)
        Me.RadioFemale.Name = "RadioFemale"
        Me.RadioFemale.Size = New System.Drawing.Size(70, 20)
        Me.RadioFemale.TabIndex = 8
        Me.RadioFemale.TabStop = True
        Me.RadioFemale.Text = "Female"
        Me.RadioFemale.UseVisualStyleBackColor = True
        '
        'UsertypeGrpBox
        '
        Me.UsertypeGrpBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UsertypeGrpBox.FormattingEnabled = True
        Me.UsertypeGrpBox.Items.AddRange(New Object() {"Choose any One ", "Admin", "Accountant", "Chef"})
        Me.UsertypeGrpBox.Location = New System.Drawing.Point(226, 240)
        Me.UsertypeGrpBox.Name = "UsertypeGrpBox"
        Me.UsertypeGrpBox.Size = New System.Drawing.Size(194, 24)
        Me.UsertypeGrpBox.TabIndex = 4
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(471, 360)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(63, 16)
        Me.lbl.TabIndex = 0
        Me.lbl.Text = "Password"
        '
        'passwordtxtbox
        '
        Me.passwordtxtbox.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.passwordtxtbox.Location = New System.Drawing.Point(617, 360)
        Me.passwordtxtbox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.passwordtxtbox.Name = "passwordtxtbox"
        Me.passwordtxtbox.Size = New System.Drawing.Size(200, 22)
        Me.passwordtxtbox.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(74, 357)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "UserName"
        '
        'usernametxtbox
        '
        Me.usernametxtbox.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.usernametxtbox.Location = New System.Drawing.Point(220, 357)
        Me.usernametxtbox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.usernametxtbox.Name = "usernametxtbox"
        Me.usernametxtbox.Size = New System.Drawing.Size(200, 22)
        Me.usernametxtbox.TabIndex = 11
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(614, 294)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(170, 16)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "** Enter valid E-mail Address"
        Me.Label18.Visible = False
        '
        'userIdTxtbox
        '
        Me.userIdTxtbox.Location = New System.Drawing.Point(232, 76)
        Me.userIdTxtbox.Mask = "00000"
        Me.userIdTxtbox.Name = "userIdTxtbox"
        Me.userIdTxtbox.Size = New System.Drawing.Size(47, 22)
        Me.userIdTxtbox.TabIndex = 18
        '
        'PhoneNumberTxtBox
        '
        Me.PhoneNumberTxtBox.Location = New System.Drawing.Point(226, 299)
        Me.PhoneNumberTxtBox.Mask = "0000000000"
        Me.PhoneNumberTxtBox.Name = "PhoneNumberTxtBox"
        Me.PhoneNumberTxtBox.Size = New System.Drawing.Size(194, 22)
        Me.PhoneNumberTxtBox.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(391, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 22)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Add User "
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PhoneNumberTxtBox)
        Me.Controls.Add(Me.userIdTxtbox)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.UsertypeGrpBox)
        Me.Controls.Add(Me.RadioFemale)
        Me.Controls.Add(Me.radioMale)
        Me.Controls.Add(Me.WrkStartedDateTime)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.usernametxtbox)
        Me.Controls.Add(Me.passwordtxtbox)
        Me.Controls.Add(Me.EmailTxtBox)
        Me.Controls.Add(Me.SalaryTxtBox)
        Me.Controls.Add(Me.FirstNameTxtBox)
        Me.Controls.Add(Me.LastNameTxtBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.AddressTxtBox)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AddUser"
        Me.Size = New System.Drawing.Size(996, 525)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents FirstNameTxtBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LastNameTxtBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents SalaryTxtBox As TextBox
    Friend WithEvents EmailTxtBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents AddressTxtBox As TextBox
    Friend WithEvents ClearBtn As Button
    Friend WithEvents WrkStartedDateTime As DateTimePicker
    Friend WithEvents ExitBtn As Button
    Friend WithEvents radioMale As RadioButton
    Friend WithEvents RadioFemale As RadioButton
    Friend WithEvents UsertypeGrpBox As ComboBox
    Friend WithEvents lbl As Label
    Friend WithEvents passwordtxtbox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents usernametxtbox As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents userIdTxtbox As MaskedTextBox
    Friend WithEvents PhoneNumberTxtBox As MaskedTextBox
    Friend WithEvents Label11 As Label
End Class
