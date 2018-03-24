Public Class forgetpassword
    Private Sub cancelforgetbox_Click(sender As Object, e As EventArgs) Handles cancelforgetbox.Click
        Me.Close()
        loginform.Show()

    End Sub

    Private Sub submitreqBtn_Click(sender As Object, e As EventArgs) Handles submitreqBtn.Click
        Dim logfrm As New loginform
        logfrm.notific = "You have request from User"
        Me.Hide()
        logfrm.Show()

    End Sub
End Class