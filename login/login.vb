Imports System.Data.SqlClient
Public Class loginform
    Public notific As String
    Dim connection As New SqlConnection()

    Private Sub loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.BackColor = Color.White
        UsernameTextBox.Text = "Username"
        UsernameTextBox.ForeColor = Color.LightGray
        connection = New SqlConnection("Data Source =(LocalDB)\MSSQLLocalDB;Integrated Security = true; Database = databseforProj")
        TextBox3.BackColor = Color.White
        Passwordtxtbox.Text = "Password"
        Passwordtxtbox.ForeColor = Color.LightGray
        Try

        Catch ex As Exception
        Finally

        End Try
    End Sub

    Private Sub UsernameTextBox_gofocus(sender As Object, e As EventArgs) Handles UsernameTextBox.GotFocus

        If UsernameTextBox.Text = "Username" Then
            UsernameTextBox.ForeColor = Color.Black
            UsernameTextBox.Text = ""
        Else
            UsernameTextBox.ForeColor = Color.Black
        End If


    End Sub
    Private Sub UsernameTextBox_lostfocus(sender As Object, e As EventArgs) Handles UsernameTextBox.LostFocus

        If UsernameTextBox.Text = "" Then
            UsernameTextBox.Text = "Username"
            UsernameTextBox.ForeColor = Color.LightGray
        End If
    End Sub



    Private Sub PasswordTextBox_lostfocus(sender As Object, e As EventArgs) Handles Passwordtxtbox.GotFocus, CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            If Passwordtxtbox.Text = "Password" Then
                Passwordtxtbox.Text = ""
                Passwordtxtbox.PasswordChar = ""
                Passwordtxtbox.ForeColor = Color.Black
            Else
                Passwordtxtbox.ForeColor = Color.Black
            End If
        Else
            If Passwordtxtbox.Text = "Password" Then
                Passwordtxtbox.Text = ""
                Passwordtxtbox.PasswordChar = "*"
                Passwordtxtbox.ForeColor = Color.Black
            Else
                Passwordtxtbox.ForeColor = Color.Black
            End If
        End If

    End Sub
    Private Sub Passwordtxtbox_lostfocus(sender As Object, e As EventArgs) Handles Passwordtxtbox.LostFocus, CheckBox1.CheckedChanged

        If Passwordtxtbox.Text = "" And (CheckBox1.Checked Or Not CheckBox1.Checked) Then
            Passwordtxtbox.PasswordChar = ""
            Passwordtxtbox.ForeColor = Color.LightGray
            Passwordtxtbox.Text = "Password"

        Else
            If Not Passwordtxtbox.Text = "" And CheckBox1.Checked Then
                Passwordtxtbox.PasswordChar = ""

            ElseIf Not Passwordtxtbox.Text = "" And Not Passwordtxtbox.Text = "Password" And Not CheckBox1.Checked Then
                Passwordtxtbox.PasswordChar = "*"
            End If

        End If
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Application.Exit()

    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Label2.Visible = True
        Dim command As New SqlCommand("Select * from userlist where Username =@a AND Password = @b", connection)
        command.Parameters.AddWithValue("@a", UsernameTextBox.Text)
        command.Parameters.AddWithValue("@b", Passwordtxtbox.Text)

        Dim da As New SqlDataAdapter(command)
        Dim DT As New DataTable()
        da.Fill(DT)

        If (DT.Rows.Count > 0) Then
            Label2.Visible= False
            If DT.Rows(0)("Usertype") = "admin" Then
                Dim admn As New Admin
                admn.usernotification.Text = notific
                admn.usernotification.ForeColor = Color.Red
                admn.userlabel.Text = UsernameTextBox.Text
                admn.Show()
                Me.Close()
                connection.Close()

            ElseIf DT.Rows(0)("Usertype") = "accountant" Then
                Accountantvb.Show()
                Me.Close()
                connection.Close()

            ElseIf DT.Rows(0)("Usertype") = "chef" Then
                Chef.Show()
                Me.Close()
                connection.Close()
            ElseIf DT.Rows(0)("Usertype") = "waiter" Then
                Me.Close()
                'waiter.Show()
                connection.Close()
            End If
        Else
            Label2.Visible = False
            MessageBox.Show("Cannot find any registered User. Sorry!! :')")
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Close()
        forgetpassword.Show()
    End Sub
End Class
