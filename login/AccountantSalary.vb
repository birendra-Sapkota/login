Public Class AccountantSalary

    Private Sub AccountantSalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Admin.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Admin.Enabled = True
        Me.Close()
    End Sub
End Class