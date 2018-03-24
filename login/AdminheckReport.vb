Imports System.Data.SqlClient
Public Class AdminheckReport
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=databseforProj;Integrated Security=True; database=databseforProj")

    Private Sub AdminheckReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DailyRepo()
        MonthlyRepo()
        YearlyReport()
    End Sub
    Function DailyRepo()
        Dim totalOrder As Integer = 0
        Dim totalOderPayment As Integer = 0
        Dim totalIncome As Integer = 0
        Dim totalExpenses As Integer = 0
        Dim i As Integer = 0

        dailydatelbl.Text = Date.Now.ToShortDateString.ToString

        Dim cmdIncome As New SqlCommand("Select * from accTable where Date = @dat", con)
        cmdIncome.Parameters.AddWithValue("dat", Date.Now.ToShortDateString)

        Dim daI As New SqlDataAdapter(cmdIncome)
        Dim dtI As New DataTable()

        daI.Fill(dtI)
        datagridviewIncome.DataSource = dtI

        If datagridviewIncome.Rows.Count > 0 Then
            Dim cnt As Integer = datagridviewIncome.Rows.Count
            For i = 0 To (cnt - 2) Step 1

                totalOrder += Convert.ToInt32(datagridviewIncome.Rows(i).Cells("oderQuantity").Value.ToString)
                totalOderPayment += Convert.ToInt32(datagridviewIncome.Rows(i).Cells("TotalPayment").Value.ToString)
                totalIncome += Convert.ToInt32(datagridviewIncome.Rows(i).Cells("TotalPayment").Value.ToString)
            Next

            totOderlbl.Text = "Rs.  " + totalOrder.ToString
            totpaymentlbl.Text = "Rs.  " + totalOderPayment.ToString
            totIncomelbl.Text = "Rs.  " + totalIncome.ToString
            PLtotIncomelbl.Text = "Rs.  " + totalIncome.ToString

        Else
            MessageBox.Show("no item Found")

        End If

        Dim cmdexpense As New SqlCommand("Select * from chfTable where date = @cdat", con)
        cmdexpense.Parameters.AddWithValue("cdat", Date.Now.ToShortDateString.ToString)
        Dim daE As New SqlDataAdapter(cmdexpense)
        Dim dte As New DataTable
        daE.Fill(dte)

        datagridviewExpense.DataSource = dte

        If datagridviewExpense.Rows.Count > 0 Then
            Dim fcost As Integer
            Dim oCost As Integer

            Dim a As Integer
            Dim count As Integer = datagridviewExpense.Rows.Count - 1
            For a = 0 To count - 1 Step 1
                fcost += Convert.ToInt32(datagridviewExpense.Rows(a).Cells("FoodItemCost").Value.ToString())
                oCost += Convert.ToInt32(datagridviewExpense.Rows(0).Cells("OtherCost").Value.ToString())
            Next
            foodcostlbl.Text = "Rs.  " + fcost.ToString
            othercostlbl.Text = "Rs.  " + oCost.ToString
            Dim totalExpns As String = (fcost + oCost).ToString
            totalExpenselbl.Text = "Rs.  " + totalExpns
            PLtotalExpenselblxxx.Text = "Rs. " + totalExpns
            totalExpenses = Convert.ToInt32(totalExpns)
        End If

        Dim profitLoss As Integer = totalIncome - totalExpenses
        If profitLoss > 0 Then
            netProfit.Text = "Rs. " + profitLoss.ToString
            netlosslbl.Text = "Rs. 0"
            dailyReport.BackColor = Color.LightGreen
        ElseIf profitLoss < 0 Then
            netlosslbl.Text = "Rs. " + profitLoss.ToString
            netProfit.Text = "Rs. 0"
            dailyReport.BackColor = Color.IndianRed
        Else
            dailyReport.BackColor = Color.White
            netProfit.Text = "Rs. 0"
            netlosslbl.Text = "Rs. 0"
        End If
        Return 0
    End Function

    Function MonthlyRepo()
        Dim orderQnt As Integer
        Dim TotalPayment As Integer
        Dim totalExpenses As Integer

        'Monthly Income
        Dim cmdIncome As New SqlCommand("Select * from accTable where Month(Date) = @a", con)

        cmdIncome.Parameters.AddWithValue("a", Now.Date.Month)
        Dim daI As New SqlDataAdapter(cmdIncome)
        Dim dtI As New DataTable()
        daI.Fill(dtI)

        MonthlyIncomeDatagridView.DataSource = dtI
        If MonthlyIncomeDatagridView.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim cnt As Integer = MonthlyIncomeDatagridView.Rows.Count - 1
            For i = 0 To cnt - 1 Step 1
                orderQnt += Convert.ToInt32(MonthlyIncomeDatagridView.Rows(i).Cells("oderQuantity").Value.ToString)
                TotalPayment += Convert.ToInt32(MonthlyIncomeDatagridView.Rows(i).Cells("TotalPayment").Value.ToString)
            Next
            monthlyordernumber.Text = orderQnt.ToString
            monthlyOrderPayment.Text = TotalPayment.ToString
            MonthlyIncome.Text = TotalPayment.ToString
            MonthlyTotalIncome.Text = TotalPayment.ToString
        End If

        'Monthly Expenses


        Dim cmdexpense As New SqlCommand("Select * from chfTable where Month(date) = @cdat", con)
        cmdexpense.Parameters.AddWithValue("cdat", Date.Now.Month)
        Dim daE As New SqlDataAdapter(cmdexpense)
        Dim dte As New DataTable
        daE.Fill(dte)

        datagridviewExpense.DataSource = dte

        If datagridviewExpense.Rows.Count > 0 Then
            Dim fcost As Integer
            Dim oCost As Integer


            Dim a As Integer
            Dim count As Integer = datagridviewExpense.Rows.Count - 1
            For a = 0 To count - 1 Step 1
                fcost += Convert.ToInt32(datagridviewExpense.Rows(a).Cells("FoodItemCost").Value.ToString())
                oCost += Convert.ToInt32(datagridviewExpense.Rows(0).Cells("OtherCost").Value.ToString())
            Next


            MOnthlyFoodCost.Text = "Rs.  " + fcost.ToString
            MonthlyOtherCost.Text = "Rs.  " + oCost.ToString

            Dim totalExpns As String = (fcost + oCost).ToString
            MonthlyExpenses.Text = "Rs.  " + totalExpns
            MonthlyTotalExpenses.Text = "Rs. " + totalExpns
            totalExpenses = Convert.ToInt32(totalExpns)
        End If

        Dim profitLoss As Integer = TotalPayment - totalExpenses
        If profitLoss > 0 Then
            MonthlyPRofit.Text = "Rs. " + profitLoss.ToString
            MonthlyLoss.Text = "Rs. 0"
            monthlyReport.BackColor = Color.LightGreen
        ElseIf profitLoss < 0 Then
            MonthlyLoss.Text = "Rs. " + profitLoss.ToString
            MonthlyPRofit.Text = "Rs. 0"
            monthlyReport.BackColor = Color.IndianRed
        Else
            monthlyReport.BackColor = Color.White
            MonthlyPRofit.Text = "Rs. 0"
            MonthlyLoss.Text = "Rs. 0"
        End If

        Return 0
    End Function

    Function YearlyReport()

        'Monthly Income
        Dim TotalPayment As Integer
        Dim totalExpenses As Integer
        Dim ored As Integer = 0

        Dim cmdIncome As New SqlCommand("Select * from accTable where Year(Date) = @a", con)

        cmdIncome.Parameters.AddWithValue("a", Now.Date.Year)
        Dim daI As New SqlDataAdapter(cmdIncome)
        Dim dtI As New DataTable()
        daI.Fill(dtI)

        MonthlyIncomeDatagridView.DataSource = dtI
        If MonthlyIncomeDatagridView.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim cnt As Integer = MonthlyIncomeDatagridView.Rows.Count - 1
            For i = 0 To cnt - 1 Step 1
                ored += Convert.ToInt32(MonthlyIncomeDatagridView.Rows(i).Cells("oderQuantity").Value.ToString)
                TotalPayment += Convert.ToInt32(MonthlyIncomeDatagridView.Rows(i).Cells("TotalPayment").Value.ToString)
            Next
            orderno.Text = ored.ToString
            IncomePayment.Text = TotalPayment.ToString
            TotalIncomePayment.Text = TotalPayment.ToString
            PLInc.Text = TotalPayment.ToString
        End If

        'Monthly Expenses


        Dim cmdexpense As New SqlCommand("Select * from chfTable where Year(date) = @cdat", con)
        cmdexpense.Parameters.AddWithValue("cdat", Date.Now.Year)
        Dim daE As New SqlDataAdapter(cmdexpense)
        Dim dte As New DataTable
        daE.Fill(dte)

        datagridviewExpense.DataSource = dte

        If datagridviewExpense.Rows.Count > 0 Then
            Dim fcost As Integer
            Dim oCost As Integer


            Dim a As Integer
            Dim count As Integer = datagridviewExpense.Rows.Count - 1
            For a = 0 To count - 1 Step 1
                fcost += Convert.ToInt32(datagridviewExpense.Rows(a).Cells("FoodItemCost").Value.ToString())
                oCost += Convert.ToInt32(datagridviewExpense.Rows(0).Cells("OtherCost").Value.ToString())
            Next


            TCFood.Text = "Rs.  " + fcost.ToString
            TCBuy.Text = "Rs.  " + oCost.ToString

            Dim totalExpns As String = (fcost + oCost).ToString
            TCExpenses.Text = "Rs.  " + totalExpns
            PLExpen.Text = "Rs. " + totalExpns
            totalExpenses = Convert.ToInt32(totalExpns)
        End If

        Dim profitLoss As Integer = TotalPayment - totalExpenses
        If profitLoss > 0 Then
            Ynetprofit.Text = "Rs. " + profitLoss.ToString
            YNetloss.Text = "Rs. 0"
            yrReport.BackColor = Color.LightGreen

        ElseIf profitLoss < 0 Then
            YNetloss.Text = "Rs. " + profitLoss.ToString
            Ynetprofit.Text = "Rs. 0"
            yrReport.BackColor = Color.IndianRed
        Else
            yrReport.BackColor = Color.White
            Ynetprofit.Text = "Rs. 0"
            YNetloss.Text = "Rs. 0"
        End If
        Return 0
    End Function
End Class