Imports System.Data.SqlClient
Public Class AdminCheckUserRequest
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=databseforProj;Integrated Security=True;database=databseforProj")
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cmd As New SqlCommand("Insert into message  Values(@a ,@b , @c, @d)", con)
        cmd.Parameters.AddWithValue("a", ComboBox1.Text)
        cmd.Parameters.AddWithValue("b", Now.Date.ToShortDateString)
        cmd.Parameters.AddWithValue("c", Now.ToShortTimeString)
        cmd.Parameters.AddWithValue("d", RichTextBox1.Text)

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully updated")
        ComboBox1.SelectedIndex = 0
        RichTextBox1.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RichTextBox1.Text = "Please arive to the admin section"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.Text = "Please arive to the admin section for the query related to the problem related with the software"

    End Sub
End Class