Public Class AdminManageUser


    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        AddUser1.Visible = True
        UpdateUser1.Visible = False
        UserList1.Visible = False
        Salary1.Visible = False

    End Sub

    Private Sub UpdateUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateUserToolStripMenuItem.Click
        UpdateUser1.Visible = True
        UserList1.Visible = False
        AddUser1.Visible = False
        Salary1.Visible = False
    End Sub

    Private Sub ListOfUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfUsersToolStripMenuItem.Click
        UpdateUser1.Visible = False
        AddUser1.Visible = False
        UserList1.Visible = True
        Salary1.Visible = False
    End Sub

    Private Sub AdminManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryToolStripMenuItem.Click
        UpdateUser1.Visible = False
        AddUser1.Visible = False
        UserList1.Visible = False
        Salary1.Visible = True
    End Sub
End Class