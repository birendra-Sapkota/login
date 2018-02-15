Public Class loginform
    Private Sub loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.BackColor = Color.White
        UsernameTextBox.Text = "Username"
        UsernameTextBox.ForeColor = Color.LightGray

        TextBox2.BackColor = Color.White
        Passwordtxtbox.Text = "Password"
        Passwordtxtbox.ForeColor = Color.LightGray
    End Sub

    Private Sub UsernameTextBox_gofocus(sender As Object, e As EventArgs) Handles UsernameTextBox.GotFocus
        If UsernameTextBox.Text = "Username" Then
            UsernameTextBox.ForeColor = Color.Black
            UsernameTextBox.Text = ""
        Else
            UsernameTextBox.ForeColor= Color.Black
        End If


    End Sub
    Private Sub UsernameTextBox_lostfocus(sender As Object, e As EventArgs) Handles UsernameTextBox.LostFocus
        If UsernameTextBox.Text = "" Then
            UsernameTextBox.Text = "Username"
            UsernameTextBox.ForeColor = Color.LightGray
        End If
    End Sub



    Private Sub PasswordTextBox_lostfocus(sender As Object, e As EventArgs) Handles Passwordtxtbox.GotFocus
        If Passwordtxtbox.Text = "Password" Then
            Passwordtxtbox.Text = ""
            Passwordtxtbox.ForeColor = Color.Black
        Else
            Passwordtxtbox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub Passwordtxtbox_lostfocus(sender As Object, e As EventArgs) Handles Passwordtxtbox.LostFocus
        If Passwordtxtbox.Text = "" Then
            Passwordtxtbox.ForeColor = Color.LightGray
            Passwordtxtbox.Text = "Password"


        End If
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Application.Exit()

    End Sub
End Class
