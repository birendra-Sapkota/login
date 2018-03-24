Public Class Chef
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        p1.Visible = True
        p3.Visible = False

        Dim chefCheckOrder As New InventoryManagement
        Dim frmChild As New Form
        For Each frmChild In Me.MdiChildren
            frmChild.Dispose()
        Next
        chefCheckOrder.MdiParent = Me
        chefCheckOrder.StartPosition = FormStartPosition.Manual
        chefCheckOrder.Location = New Point(20, 23)
        chefCheckOrder.Show()
    End Sub

    Private Sub Chef_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        p1.Visible = True
        p3.Visible = False
        Dim chefCheckOrder As New InventoryManagement
        Dim frmChild As New Form
        For Each frmChild In Me.MdiChildren
            frmChild.Dispose()
        Next
        chefCheckOrder.MdiParent = Me
        chefCheckOrder.StartPosition = FormStartPosition.Manual
        chefCheckOrder.Location = New Point(20, 23)
        chefCheckOrder.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As String
        result = MessageBox.Show("Do You Really Want To logout ??", "Confirmation", MessageBoxButtons.YesNo)
        If result = vbYes Then
            loginform.Show()
            Me.Hide()
        End If
    End Sub
End Class