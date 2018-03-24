Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class InventoryManagement
    Dim chk As String
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB; Integrated Security=true; Database=databseforProj")

    Private Sub CheckOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckOrderToolStripMenuItem.Click
        OrderListPanel.Visible = True
        AddItemPnl.Visible = False
    End Sub

    Private Sub UpdateItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateItemToolStripMenuItem.Click
        OrderListPanel.Visible = False
        AddItemPnl.Visible = True
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles Add.Click
        'Dim con As New SqlConnection("Data Source=(LocalDB)\v11.0; Integrated Security=true; Database=ChefDatabase")
        Dim cmd As New SqlCommand("insert into ChefTable1 values(@a,@b,@c,@d,@e,@f)", con)

        If BreakfastRadioBtn.Checked Then
            chk = "BreakFast"
        ElseIf DrinkRadioBtn.Checked Then
            chk = "Drinks"
        ElseIf SnackRadioBtn.Checked Then
            chk = "Snacks"
        ElseIf LunchRadioBtn.Checked Then
            chk = "Lunch"
        Else
            MessageBox.Show("Cannot Assign Empty")
        End If

        cmd.Parameters.AddWithValue("@a", NameTextBox.Text)
        cmd.Parameters.AddWithValue("@b", PriceTextBox.Text)
        cmd.Parameters.AddWithValue("@c", RichTextBox1.Text)
        cmd.Parameters.AddWithValue("@d", Date.Parse(MfdDateTimePicker.Text))
        cmd.Parameters.AddWithValue("@e", Date.Parse(ExpDateTimePicker.Text))
        cmd.Parameters.AddWithValue("@f", chk)


        con.Open()
        cmd.ExecuteNonQuery()

        con.Close()
        MessageBox.Show("Added successfully")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged

    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs)
        'Dim con As New SqlConnection("Data Source=(LocalDB)\v11.0; Integrated Security=true; Database=ChefDatabase")
        Dim cmd As New SqlCommand("Update ChefTable1 set Name=@a,PriceInRs=@b,Description=@c,MfdDate=@d,ExpDate=@e,FoodType=@f where Id=@id", con)
        cmd.Parameters.AddWithValue("@a", NameTextBox.Text)
        cmd.Parameters.AddWithValue("@b", PriceTextBox.Text)
        cmd.Parameters.AddWithValue("@c", RichTextBox1.Text)
        cmd.Parameters.AddWithValue("@d", Date.Parse(MfdDateTimePicker.Text))
        cmd.Parameters.AddWithValue("@e", Date.Parse(ExpDateTimePicker.Text))
        cmd.Parameters.AddWithValue("@f", chk)
        cmd.Parameters.AddWithValue("id", chk)


        con.Open()
        cmd.ExecuteNonQuery()

        con.Close()
        MessageBox.Show("Updated successfully")
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        'Dim con As New SqlConnection("Data Source=(LocalDB)\v11.0; Integrated Security=true; Database=ChefDatabase")
        Dim cmd As New SqlCommand("Delete from ChefTable1 where Id=@id", con)
        con.Open()
        cmd.Parameters.AddWithValue("id", id)
        cmd.ExecuteNonQuery()
        MessageBox.Show("deleted")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim c As String = ""


        If BreakfastRadioBtn.Checked Then
            c = "BreakFast"
        ElseIf DrinkRadioBtn.Checked Then
            c = "Drinks"
        ElseIf SnackRadioBtn.Checked Then
            c = "Snacks"
        ElseIf LunchRadioBtn.Checked Then
            c = "Lunch"
        Else
            MessageBox.Show("Cannot Assign Empty")
        End If



        'Dim con As New SqlConnection("Data Source=(LocalDB)\v11.0; Integrated Security=true; Database=ChefDatabase")
        Dim cmd As New SqlCommand("Update ChefTable1 set Name=@a,PriceInRs=@b,Description=@c,MfdDate=@d,ExpDate=@e,FoodType=@f where Id=@id", con)
        cmd.Parameters.AddWithValue("@a", NameTextBox.Text)
        cmd.Parameters.AddWithValue("@b", PriceTextBox.Text)
        cmd.Parameters.AddWithValue("@c", RichTextBox1.Text)
        cmd.Parameters.AddWithValue("@d", Date.Parse(MfdDateTimePicker.Text))
        cmd.Parameters.AddWithValue("@e", Date.Parse(ExpDateTimePicker.Text))
        cmd.Parameters.AddWithValue("@f", c)
        cmd.Parameters.AddWithValue("id", id)


        con.Open()
        cmd.ExecuteNonQuery()

        con.Close()
        MessageBox.Show("Updated successfully")
    End Sub

    Private Sub AddItemPnl_Paint(sender As Object, e As PaintEventArgs) Handles AddItemPnl.Paint
        'Dim con As New SqlConnection("Data Source=(LocalDB)\v11.0; Integrated Security=true; Database=ChefDatabase")
        Dim cmd As New SqlCommand("Select Id,Name,PriceInRs, Description, MfdDate, ExpDate, FoodType from ChefTable1", con)

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Dim id As Integer

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        NameTextBox.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        PriceTextBox.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        RichTextBox1.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        MfdDateTimePicker.Text = Date.Parse(DataGridView1.CurrentRow.Cells(4).Value.ToString())
        ExpDateTimePicker.Text = Date.Parse(DataGridView1.CurrentRow.Cells(5).Value.ToString())
        id = Convert.ToInt32(DataGridView1.CurrentRow.Cells(0).Value.ToString())
        Dim chked As String = DataGridView1.CurrentRow.Cells(6).Value.ToString()

        If chked = "BreakFast" Then
            BreakfastRadioBtn.Checked = True

        ElseIf chked = "Drinks" Then
            DrinkRadioBtn.Checked = True

        ElseIf chked = "Snacks" Then
            SnackRadioBtn.Checked = True

        Else
            LunchRadioBtn.Checked = True
        End If

    End Sub

    Private Sub InventoryManagementDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub OrderListPanel_Paint(sender As Object, e As PaintEventArgs) Handles OrderListPanel.Paint
        'Dim con As New SqlConnection("Data Source=(LocalDB)\v11.0; Integrated Security=true; Database=ChefDatabase")
        Dim cmd As New SqlCommand("Select Order_ID,Item_Name,Item_Per_Plate,Number_Of_Plate,Total_Amount from Transact_Food", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        OrderListDataGridView.DataSource = dt
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        OrderListDataGridView.Columns(0).Width = 139
        OrderListDataGridView.Columns(1).Width = 139
        OrderListDataGridView.Columns(2).Width = 139
        OrderListDataGridView.Columns(3).Width = 139
        OrderListDataGridView.Columns(4).Width = 139

    End Sub

    Private Sub OrderListDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrderListDataGridView.CellContentClick
        NameTextBox.Text = OrderListDataGridView.CurrentRow.Cells(1).Value.ToString()
        PriceTextBox.Text = OrderListDataGridView.CurrentRow.Cells(2).Value.ToString()
        RichTextBox1.Text = OrderListDataGridView.CurrentRow.Cells(3).Value.ToString()
        id = Convert.ToInt32(OrderListDataGridView.CurrentRow.Cells(0).Value.ToString())
        Dim chked As String = DataGridView1.CurrentRow.Cells(4).Value.ToString()

        If chked = "BreakFast" Then
            BreakfastRadioBtn.Checked = True

        ElseIf chked = "Drinks" Then
            DrinkRadioBtn.Checked = True

        ElseIf chked = "Snacks" Then
            SnackRadioBtn.Checked = True

        Else
            LunchRadioBtn.Checked = True
        End If
    End Sub

    Private Sub InventoryManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
