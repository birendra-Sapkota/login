<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminTransaction
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtFoodName = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblCollectedAmount = New System.Windows.Forms.Label()
        Me.lblReturnedAmount = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.cboFoodName = New System.Windows.Forms.ComboBox()
        Me.lblCashier = New System.Windows.Forms.Label()
        Me.cboCashier = New System.Windows.Forms.ComboBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtAmtCollected = New System.Windows.Forms.TextBox()
        Me.txtReturnedAmt = New System.Windows.Forms.TextBox()
        Me.cboQuantity = New System.Windows.Forms.ComboBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.coSN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTotalAmt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBillValue = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFoodName
        '
        Me.txtFoodName.AutoSize = True
        Me.txtFoodName.ForeColor = System.Drawing.Color.Black
        Me.txtFoodName.Location = New System.Drawing.Point(34, 24)
        Me.txtFoodName.Name = "txtFoodName"
        Me.txtFoodName.Size = New System.Drawing.Size(35, 13)
        Me.txtFoodName.TabIndex = 1
        Me.txtFoodName.Text = "Name"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.ForeColor = System.Drawing.Color.Black
        Me.lblQuantity.Location = New System.Drawing.Point(222, 24)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.TabIndex = 2
        Me.lblQuantity.Text = "Quantity"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.ForeColor = System.Drawing.Color.Black
        Me.lblRate.Location = New System.Drawing.Point(34, 57)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(30, 13)
        Me.lblRate.TabIndex = 3
        Me.lblRate.Text = "Rate"
        '
        'lblCollectedAmount
        '
        Me.lblCollectedAmount.AutoSize = True
        Me.lblCollectedAmount.ForeColor = System.Drawing.Color.Black
        Me.lblCollectedAmount.Location = New System.Drawing.Point(59, 405)
        Me.lblCollectedAmount.Name = "lblCollectedAmount"
        Me.lblCollectedAmount.Size = New System.Drawing.Size(90, 13)
        Me.lblCollectedAmount.TabIndex = 4
        Me.lblCollectedAmount.Text = "Amount Collected"
        '
        'lblReturnedAmount
        '
        Me.lblReturnedAmount.AutoSize = True
        Me.lblReturnedAmount.ForeColor = System.Drawing.Color.Black
        Me.lblReturnedAmount.Location = New System.Drawing.Point(58, 443)
        Me.lblReturnedAmount.Name = "lblReturnedAmount"
        Me.lblReturnedAmount.Size = New System.Drawing.Size(90, 13)
        Me.lblReturnedAmount.TabIndex = 5
        Me.lblReturnedAmount.Text = "Returned Amount"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(79, 364)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(70, 13)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "Total Amount"
        '
        'cboFoodName
        '
        Me.cboFoodName.FormattingEnabled = True
        Me.cboFoodName.Items.AddRange(New Object() {"", "BURGER", "PIZZA", "NOODLES", "MOMO", "CHOWMEIN", "PAKAUDA", "FRENCH FRY", "ROTI TARKARI", "PURI TARKARI", "MINERAL WATER", "TEA", "DRINKS"})
        Me.cboFoodName.Location = New System.Drawing.Point(75, 21)
        Me.cboFoodName.Name = "cboFoodName"
        Me.cboFoodName.Size = New System.Drawing.Size(121, 21)
        Me.cboFoodName.TabIndex = 7
        '
        'lblCashier
        '
        Me.lblCashier.AutoSize = True
        Me.lblCashier.ForeColor = System.Drawing.Color.Black
        Me.lblCashier.Location = New System.Drawing.Point(265, 364)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(42, 13)
        Me.lblCashier.TabIndex = 6
        Me.lblCashier.Text = "Cashier"
        '
        'cboCashier
        '
        Me.cboCashier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCashier.FormattingEnabled = True
        Me.cboCashier.Items.AddRange(New Object() {"ABC"})
        Me.cboCashier.Location = New System.Drawing.Point(326, 364)
        Me.cboCashier.Name = "cboCashier"
        Me.cboCashier.Size = New System.Drawing.Size(82, 21)
        Me.cboCashier.TabIndex = 7
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(75, 54)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(121, 20)
        Me.txtRate.TabIndex = 8
        '
        'txtAmtCollected
        '
        Me.txtAmtCollected.Location = New System.Drawing.Point(155, 402)
        Me.txtAmtCollected.Name = "txtAmtCollected"
        Me.txtAmtCollected.Size = New System.Drawing.Size(54, 20)
        Me.txtAmtCollected.TabIndex = 8
        '
        'txtReturnedAmt
        '
        Me.txtReturnedAmt.Location = New System.Drawing.Point(154, 443)
        Me.txtReturnedAmt.Name = "txtReturnedAmt"
        Me.txtReturnedAmt.ReadOnly = True
        Me.txtReturnedAmt.Size = New System.Drawing.Size(55, 20)
        Me.txtReturnedAmt.TabIndex = 8
        '
        'cboQuantity
        '
        Me.cboQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQuantity.FormattingEnabled = True
        Me.cboQuantity.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cboQuantity.Location = New System.Drawing.Point(274, 21)
        Me.cboQuantity.Name = "cboQuantity"
        Me.cboQuantity.Size = New System.Drawing.Size(42, 21)
        Me.cboQuantity.TabIndex = 7
        '
        'btnSubmit
        '
        Me.btnSubmit.ForeColor = System.Drawing.Color.Black
        Me.btnSubmit.Location = New System.Drawing.Point(42, 97)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 9
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(144, 97)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coSN, Me.coName, Me.coRate, Me.coQuantity, Me.Total})
        Me.DataGridView1.Location = New System.Drawing.Point(82, 167)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(322, 176)
        Me.DataGridView1.TabIndex = 11
        '
        'coSN
        '
        Me.coSN.HeaderText = "SN"
        Me.coSN.MinimumWidth = 3
        Me.coSN.Name = "coSN"
        Me.coSN.Width = 40
        '
        'coName
        '
        Me.coName.HeaderText = "Name"
        Me.coName.Name = "coName"
        Me.coName.Width = 60
        '
        'coRate
        '
        Me.coRate.HeaderText = "Rate"
        Me.coRate.Name = "coRate"
        Me.coRate.Width = 60
        '
        'coQuantity
        '
        Me.coQuantity.HeaderText = "Quantity"
        Me.coQuantity.Name = "coQuantity"
        Me.coQuantity.Width = 60
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'txtTotalAmt
        '
        Me.txtTotalAmt.Location = New System.Drawing.Point(155, 361)
        Me.txtTotalAmt.Name = "txtTotalAmt"
        Me.txtTotalAmt.ReadOnly = True
        Me.txtTotalAmt.Size = New System.Drawing.Size(54, 20)
        Me.txtTotalAmt.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboQuantity)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.lblQuantity)
        Me.GroupBox1.Controls.Add(Me.btnSubmit)
        Me.GroupBox1.Controls.Add(Me.txtRate)
        Me.GroupBox1.Controls.Add(Me.cboFoodName)
        Me.GroupBox1.Controls.Add(Me.txtFoodName)
        Me.GroupBox1.Controls.Add(Me.lblRate)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 143)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'btnOK
        '
        Me.btnOK.ForeColor = System.Drawing.Color.Black
        Me.btnOK.Location = New System.Drawing.Point(112, 486)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(86, 51)
        Me.btnOK.TabIndex = 13
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(238, 486)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(82, 51)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(381, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Bill No."
        '
        'lblBillValue
        '
        Me.lblBillValue.AutoSize = True
        Me.lblBillValue.Location = New System.Drawing.Point(445, 18)
        Me.lblBillValue.Name = "lblBillValue"
        Me.lblBillValue.Size = New System.Drawing.Size(0, 13)
        Me.lblBillValue.TabIndex = 14
        '
        'adminTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 549)
        Me.Controls.Add(Me.lblBillValue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtReturnedAmt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtAmtCollected)
        Me.Controls.Add(Me.cboCashier)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblCashier)
        Me.Controls.Add(Me.txtTotalAmt)
        Me.Controls.Add(Me.lblReturnedAmount)
        Me.Controls.Add(Me.lblCollectedAmount)
        Me.ForeColor = System.Drawing.Color.Black
        Me.MaximizeBox = False
        Me.Name = "adminTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFoodName As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents lblCollectedAmount As System.Windows.Forms.Label
    Friend WithEvents lblReturnedAmount As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents cboFoodName As System.Windows.Forms.ComboBox
    Friend WithEvents lblCashier As System.Windows.Forms.Label
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents cboQuantity As System.Windows.Forms.ComboBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents coSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coRate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents cboCashier As System.Windows.Forms.ComboBox
    Public WithEvents txtAmtCollected As System.Windows.Forms.TextBox
    Public WithEvents txtReturnedAmt As System.Windows.Forms.TextBox
    Public WithEvents lblBillValue As System.Windows.Forms.Label
    Public WithEvents txtTotalAmt As System.Windows.Forms.TextBox
End Class
