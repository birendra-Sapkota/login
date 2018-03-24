Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class AddUser
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        checkValidation()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        clearField()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Hide()
    End Sub
    Function clearField()
        Label18.Visible = False
        userIdTxtbox.Text = ""
        FirstNameTxtBox.Text = ""
        LastNameTxtBox.Text = ""
        UsertypeGrpBox.SelectedIndex = 0
        PhoneNumberTxtBox.Text = ""
        usernametxtbox.Text = ""
        AddressTxtBox.Text = ""
        radioMale.Select()
        SalaryTxtBox.Text = ""
        WrkStartedDateTime.Text = ""
        EmailTxtBox.Text = ""
        passwordtxtbox.Text = ""
        Return 0
    End Function

    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearField()
    End Sub
    Private Sub addData()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=databseforProj;Integrated Security=True; database= databseforProj")
        Dim cmd As New SqlCommand("Insert into userDetail Values(@a, @b, @c, @d, @e, @f, @gg, @h, @i, @j,@k) ", con)
        cmd.Parameters.AddWithValue("a", userIdTxtbox.Text)
        cmd.Parameters.AddWithValue("b", FirstNameTxtBox.Text)
        cmd.Parameters.AddWithValue("c", LastNameTxtBox.Text)
        cmd.Parameters.AddWithValue("d", UsertypeGrpBox.Text)
        cmd.Parameters.AddWithValue("e", PhoneNumberTxtBox.Text)
        cmd.Parameters.AddWithValue("f", AddressTxtBox.Text)
        If radioMale.Checked Then
            cmd.Parameters.AddWithValue("gg", "male")
        ElseIf RadioFemale.Checked Then
            cmd.Parameters.AddWithValue("gg", "Female")
        End If
        cmd.Parameters.AddWithValue("h", SalaryTxtBox.Text)
        cmd.Parameters.AddWithValue("i", WrkStartedDateTime.Text)
        cmd.Parameters.AddWithValue("j", EmailTxtBox.Text)
        cmd.Parameters.AddWithValue("k", usernametxtbox.Text)

        Dim cmd2 As New SqlCommand("Insert into userlist(Username,Password,Usertype) values(@a2, @a3, @a4)", con)
        cmd2.Parameters.AddWithValue("a2", usernametxtbox.Text)
        cmd2.Parameters.AddWithValue("a3", passwordtxtbox.Text)
        cmd2.Parameters.AddWithValue("a4", UsertypeGrpBox.Text)

        con.Open()
        cmd.ExecuteNonQuery()
        cmd2.ExecuteNonQuery()
        MessageBox.Show("Data Inserted")
        clearField()
        con.Close()
    End Sub

    Function checkValidation()
        If userIdTxtbox.Text = "" Then
            MessageBox.Show("Please fill User ID Fild")
        ElseIf FirstNameTxtBox.Text = "" Then
            MessageBox.Show("Please fill Name Fild")
        ElseIf LastNameTxtBox.Text = "" Then
            MessageBox.Show("Please fill Name Fild")
        ElseIf UsertypeGrpBox.Text = "Choose any One " Then
            MessageBox.Show("Please choose any one of the user type")

        ElseIf PhoneNumberTxtBox.Text = "" Then
            MessageBox.Show("Please fill your phone Number")

        ElseIf userIdTxtbox.Text = "" Then
            MessageBox.Show("Please fill your Username")

        ElseIf AddressTxtBox.Text = "" Then
            MessageBox.Show("Please fill Address Fild")

        ElseIf SalaryTxtBox.Text = "" Then
            MessageBox.Show("Please enter in Salary Field")
        ElseIf Not Regex.IsMatch(EmailTxtBox.Text, "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$") Then
            MessageBox.Show("Please enter Your Correct Email Address")
            Label18.Visible = True

        ElseIf passwordtxtbox.Text = "" Then
            MessageBox.Show("please fill your password")
        Else
            addData()
        End If
        Return 0
    End Function


End Class
