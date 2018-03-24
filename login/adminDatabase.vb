Imports System.Data.SqlClient

Public Class adminTransaction
    Dim value, SN, Nam, Rate, Qty, Tot, ran As String
    Dim c As Integer
    Dim Connection As New SqlConnection("Data Source= (LocalDB)\MSSQLLocalDB; Integrated Security = true; Database= databseforProj")

    Private Sub adminDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tooltip1 As New ToolTip()
        cboQuantity.SelectedIndex = 0
        cboCashier.SelectedIndex = 0
        tooltip1.SetToolTip(Me.btnSubmit, "Submit")
        RandomGenerate()

    End Sub

    Public Sub RandomGenerate()
        ' Dim Connection As New SqlConnection("Data Source= (LocalDB)\v11.0; Integrated Security = true; Database= ProjectDB")
        Dim Command As New SqlCommand("SELECT Count(*) FROM Transact_Food", Connection)

        Connection.Open()
        Dim cou As Int32 = CInt(Command.ExecuteScalar)
        Command.ExecuteNonQuery()
        Connection.Close()
        ran = 5001 + cou
        lblBillValue.Text = ran

    End Sub
    Dim i As Integer = 0
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
     
                nextCol()
      

    End Sub

    Public Sub nextCol()
        DataGridView1.Rows.Add()
        DataGridView1.Rows(i).Cells("coSN").Value = i + 1
        DataGridView1.Rows(i).Cells("coName").Value = cboFoodName.Text
        DataGridView1.Rows(i).Cells("coRate").Value = txtRate.Text
        DataGridView1.Rows(i).Cells("coQuantity").Value = cboQuantity.Text
        DataGridView1.Rows(i).Cells("Total").Value = txtRate.Text * cboQuantity.Text
        txtTotalAmt.Text = value + DataGridView1.Rows(i).Cells("Total").Value
        value = txtTotalAmt.Text
        i = i + 1
        Clear()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Private Sub Clear()
        cboQuantity.SelectedIndex = 0
        cboFoodName.SelectedIndex = 0
        txtRate.Text = ""
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim result As Integer = MessageBox.Show("Continue?", "Alert", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            datagrid()
        ElseIf result = DialogResult.No Then
            Me.Show()
        End If

    End Sub
    Private Sub datagrid()

        'Dim Connection As New SqlConnection("Data Source = (LocalDB)\v11.0; Integrated Security = true; Database = ProjectDB")


        Try
            Connection.Open()
            For x As Integer = 0 To DataGridView1.Rows.Count - 1
                Dim Command As New SqlCommand("INSERT INTO Transact_Food(Order_ID, Item_Name, Item_Per_Plate, Number_Of_Plate, Total_Amount) VALUES(@s,@n,@r,@q,@t)", Connection)
                SN = lblBillValue.Text
                Nam = DataGridView1.Rows(x).Cells(1).Value
                Rate = DataGridView1.Rows(x).Cells(2).Value
                Qty = DataGridView1.Rows(x).Cells(3).Value
                Tot = DataGridView1.Rows(x).Cells(4).Value

                Command.Parameters.AddWithValue("@s", SN)
                Command.Parameters.AddWithValue("@n", Nam)
                Command.Parameters.AddWithValue("@r", Rate)
                Command.Parameters.AddWithValue("@q", Qty)
                Command.Parameters.AddWithValue("@t", Tot)


                Command.ExecuteNonQuery()
            Next
            Connection.Close()
        Catch ex As Exception
        End Try

        pass()

    End Sub
  
    Private Sub pass()
        Pop_Up_Dialog.lblBillNo.Text = lblBillValue.Text
        Pop_Up_Dialog.lblGrossValue.Text = txtTotalAmt.Text
        Pop_Up_Dialog.lblNetValue.Text = txtTotalAmt.Text
        Pop_Up_Dialog.lblCashierValue.Text = cboCashier.SelectedItem
        Pop_Up_Dialog.Show()
    End Sub

    Private Sub txtReturnedAmt_TextChanged(sender As Object, e As EventArgs) Handles txtReturnedAmt.TextChanged
        txtReturnedAmt.Text = txtAmtCollected.Text - txtTotalAmt.Text
    End Sub

    Private Sub txtAmtCollected_Leave(sender As Object, e As EventArgs) Handles txtAmtCollected.Leave
        If txtAmtCollected.Text < txtTotalAmt.Text Then
            MessageBox.Show("Invalid Entry")
        Else
            txtReturnedAmt.Text = txtTotalAmt.Text - txtAmtCollected.Text
        End If
    End Sub

    Private Sub Choose()
        Dim s As String = cboFoodName.SelectedItem
        Connection.Open()
        ' Dim Connection As New SqlConnection("Data Source= (LocalDB)\v11.0; Integrated Security = true; Database= ProjectDB")
        'Dim Command As New SqlCommand()

        Dim da As New SqlDataAdapter("SELECT Price FROM Food_Price WHERE Food_Item = '" & s & "'", Connection)

        Dim dt As New DataTable()
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            txtRate.Text = dt.Rows(0).Item("Price").ToString()
        End If

        Connection.Close()


    End Sub




    Private Sub cboFoodName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFoodName.SelectedIndexChanged
        Choose()
    End Sub


    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick

    End Sub

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        cboFoodName.Text = DataGridView1.Rows(0).Cells(1).Value
        txtRate.Text = DataGridView1.Rows(0).Cells(2).Value
        cboQuantity.Text = DataGridView1.Rows(0).Cells(3).Value

    End Sub
End Class

