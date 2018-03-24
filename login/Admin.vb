Public Class Admin
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub
    Private Sub PictureBox1_enter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.BackColor = Color.Red
    End Sub
    Private Sub PictureBox1_leave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.BackColor = Color.Transparent
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timestatus.Text = DateTime.Now.ToLongTimeString + ",  " + DateTime.Now.DayOfWeek.ToString
    End Sub

    Private Sub adminlogoutBtn_Click(sender As Object, e As EventArgs) Handles adminlogoutBtn.Click
        falsePanelVisibility()
        pnl6.Visible = True
        Dim result As String
        result = MessageBox.Show("Do You Really Want To logout ??", "Confirf LogOut", MessageBoxButtons.YesNo)
        If result = vbYes Then
            loginform.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        falsePanelVisibility()
        pnl1.Visible = True
        Dim checkreportFrm As New AdminheckReport
        Dim frmChild As New Form
        For Each frmChild In Me.MdiChildren
            frmChild.Dispose()
        Next
        checkreportFrm.MdiParent = Me
        checkreportFrm.StartPosition = FormStartPosition.Manual
        checkreportFrm.Location = New Point(20, 10)
        checkreportFrm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles admincheckreportBTN.Click
        falsePanelVisibility()
        pnl1.Visible = True

        Dim checkreportFrm As New AdminheckReport
        Dim frmChild As New Form
        For Each frmChild In Me.MdiChildren
            frmChild.Dispose()
        Next
        checkreportFrm.MdiParent = Me
        checkreportFrm.StartPosition = FormStartPosition.Manual
        checkreportFrm.Location = New Point(20, 10)
        checkreportFrm.Show()

    End Sub

    Private Sub adminInventoryBTN_Click(sender As Object, e As EventArgs) Handles adminInventoryBTN.Click
        falsePanelVisibility()
        pnl2.Visible = True

        Dim adminInventoryManagementfrm As New AdminInventoryManagement
        Dim frmChild As New Form
        For Each frmChild In Me.MdiChildren
            frmChild.Dispose()
        Next
        adminInventoryManagementfrm.MdiParent = Me
        adminInventoryManagementfrm.StartPosition = FormStartPosition.Manual
        adminInventoryManagementfrm.Location = New Point(20, 10)
        adminInventoryManagementfrm.Show()

    End Sub

    Private Sub AdminManageUserBTN_Click(sender As Object, e As EventArgs) Handles AdminManageUserBTN.Click
        falsePanelVisibility()
        pnl4.Visible = True
        Dim manageuserfrm As New AdminManageUser
        Dim frmChild As New Form
        For Each frmChild In Me.MdiChildren
            frmChild.Dispose()
        Next
        manageuserfrm.MdiParent = Me
        manageuserfrm.StartPosition = FormStartPosition.Manual
        manageuserfrm.Location = New Point(20, 10)
        manageuserfrm.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles AdminCheckRequestBTN.Click
        falsePanelVisibility()
        pnl5.Visible = True

        If Not usernotification.Text = "" Then
            usernotification.Text = ""
        End If
        Dim checkuserrequestfrm As New AdminCheckUserRequest
        Dim frmChild As New Form
        For Each frmChild In Me.MdiChildren
            frmChild.Dispose()
        Next
        checkuserrequestfrm.MdiParent = Me
        checkuserrequestfrm.StartPosition = FormStartPosition.Manual
        checkuserrequestfrm.Location = New Point(20, 10)
        checkuserrequestfrm.Show()
    End Sub
    Private Sub ManageHover(sender As Object, e As EventArgs) Handles admincheckreportBTN.MouseHover,
        adminInventoryBTN.MouseHover, AdminCheckRequestBTN.MouseHover, AdminManageUserBTN.MouseHover, adminlogoutBtn.MouseHover
        Select Case sender.text.ToString
            Case "Check Report"
                falsePanelVisibility()
                pnl1.Visible = True

            Case "Inventory Management"
                falsePanelVisibility()
                pnl2.Visible = True

            Case "Manage User"
                falsePanelVisibility()
                pnl4.Visible = True

            Case "Message"
                falsePanelVisibility()
                pnl5.Visible = True
            Case "Log Out"
                falsePanelVisibility()
                pnl6.Visible = True
        End Select
    End Sub
    Public Sub falsePanelVisibility()
        pnl1.Visible = False
        pnl2.Visible = False
        pnl4.Visible = False
        pnl5.Visible = False
        pnl6.Visible = False
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class