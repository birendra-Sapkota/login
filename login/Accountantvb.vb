Public Class Accountantvb



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pl1.Visible = False
        pl3.Visible = True
        Dim result As String
        result = MessageBox.Show("Do You Really Want To logout ??", "Confirmation", MessageBoxButtons.YesNo)
        If result = vbYes Then
            loginform.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Accountantvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pl1.Visible = True
        pl3.Visible = False
        Dim adminData As New adminTransaction

        Dim frmChild As New Form
        For Each frmChild In Me.MdiChildren
            frmChild.Dispose()
        Next
        adminData.MdiParent = Me
        adminData.StartPosition = FormStartPosition.Manual
        adminData.Location = New Point(20, 10)
        adminData.Show()

    End Sub

    Private Sub crtOderbtn_Click(sender As Object, e As EventArgs) Handles crtOderbtn.Click
        Dim frmChild As New Form
        For Each frmChild In Me.MdiChildren
            frmChild.Dispose()
        Next
        Dim adminData As New adminTransaction

        adminData.MdiParent = Me
        adminData.StartPosition = FormStartPosition.Manual
        adminData.Location = New Point(20, 10)
        adminData.Show()
    End Sub
End Class