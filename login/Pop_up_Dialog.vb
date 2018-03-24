Imports System.Data.SqlClient
Public Class Pop_Up_Dialog
    Dim j, c As Integer
    Dim i As Integer = 0
    Dim admin As New adminTransaction
    Dim ran As Integer
    Dim Connection As New SqlConnection("Data Source= (LocalDB)\MSSQLLocalDB; Integrated Security = true; Database= databseforProj")

    Private Sub Pop_Up_Dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGrid()
        Timer1.Start()
        Label14.Text = 0
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        btnExit.Visible = False
        btnPrint.Hide()
        Change()
        PrintDocument1.Print()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = DateTime.Now.ToString("yyy MMMM dd | h:mm:ss tt ")
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bit As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bit, New Rectangle(0, 0, Me.Width, Me.Height))
        e.Graphics.DrawImage(bit, 10, 10)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub DataGrid()

        Try

            Dim Command As New SqlCommand("SELECT * FROM Transact_Food WHERE Order_ID =" & lblBillNo.Text & "", Connection)
            Dim DataAdap As New SqlDataAdapter(Command)
            Dim DataTable As New DataTable()
            DataAdap.Fill(DataTable)
            DataGridView1.DataSource = DataTable
            Connection.Open()
            Command.ExecuteNonQuery()
            Connection.Close()
        Catch e As SqlException
        End Try

    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()

    End Sub

    Private Sub Change()
        ' Dim Connection As New SqlConnection("Data Source= (LocalDB)\v11.0; Integrated Security = True; Database = ProjectDB")
        Dim Command As New SqlCommand("INSERT INTO Transaction_Detail(Bill_No, Gross_Amount, Net_Amount, Cashier, Date_Issued) VALUES(@b,@g,@n,@c,@d)", Connection)
        Command.Parameters.AddWithValue("@b", lblBillNo.Text)
        Command.Parameters.AddWithValue("@g", lblGrossValue.Text)
        Command.Parameters.AddWithValue("@n", lblNetValue.Text)
        Command.Parameters.AddWithValue("@c", lblCashierValue.Text)
        Command.Parameters.AddWithValue("@d", lblDate.Text)
        Connection.Open()
        Command.ExecuteNonQuery()
        Connection.Close()

    End Sub
End Class