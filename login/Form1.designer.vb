<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryManagement
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
        Me.InventoryMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.CheckOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderListPanel = New System.Windows.Forms.Panel()
        Me.OrderListDataGridView = New System.Windows.Forms.DataGridView()
        Me.OrderListLbl = New System.Windows.Forms.Label()
        Me.NameLbl = New System.Windows.Forms.Label()
        Me.PriceLbl = New System.Windows.Forms.Label()
        Me.DescriptionLbl = New System.Windows.Forms.Label()
        Me.Add = New System.Windows.Forms.Button()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BreakfastRadioBtn = New System.Windows.Forms.RadioButton()
        Me.DrinkRadioBtn = New System.Windows.Forms.RadioButton()
        Me.MfdDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ExpDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LunchRadioBtn = New System.Windows.Forms.RadioButton()
        Me.SnackRadioBtn = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AddItemPnl = New System.Windows.Forms.Panel()
        Me.InventoryMenuStrip.SuspendLayout()
        Me.OrderListPanel.SuspendLayout()
        CType(Me.OrderListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddItemPnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'InventoryMenuStrip
        '
        Me.InventoryMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckOrderToolStripMenuItem, Me.UpdateItemToolStripMenuItem})
        Me.InventoryMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.InventoryMenuStrip.Name = "InventoryMenuStrip"
        Me.InventoryMenuStrip.Size = New System.Drawing.Size(739, 24)
        Me.InventoryMenuStrip.TabIndex = 0
        Me.InventoryMenuStrip.Text = "MenuStrip1"
        '
        'CheckOrderToolStripMenuItem
        '
        Me.CheckOrderToolStripMenuItem.Name = "CheckOrderToolStripMenuItem"
        Me.CheckOrderToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.CheckOrderToolStripMenuItem.Text = "Check Order"
        '
        'UpdateItemToolStripMenuItem
        '
        Me.UpdateItemToolStripMenuItem.Name = "UpdateItemToolStripMenuItem"
        Me.UpdateItemToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.UpdateItemToolStripMenuItem.Text = "Update Food List"
        '
        'OrderListPanel
        '
        Me.OrderListPanel.BackColor = System.Drawing.Color.Gold
        Me.OrderListPanel.Controls.Add(Me.OrderListDataGridView)
        Me.OrderListPanel.Controls.Add(Me.OrderListLbl)
        Me.OrderListPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderListPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderListPanel.Location = New System.Drawing.Point(0, 24)
        Me.OrderListPanel.Name = "OrderListPanel"
        Me.OrderListPanel.Size = New System.Drawing.Size(739, 472)
        Me.OrderListPanel.TabIndex = 1
        '
        'OrderListDataGridView
        '
        Me.OrderListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderListDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.OrderListDataGridView.Location = New System.Drawing.Point(0, 60)
        Me.OrderListDataGridView.Name = "OrderListDataGridView"
        Me.OrderListDataGridView.Size = New System.Drawing.Size(739, 412)
        Me.OrderListDataGridView.TabIndex = 1
        '
        'OrderListLbl
        '
        Me.OrderListLbl.AutoSize = True
        Me.OrderListLbl.Location = New System.Drawing.Point(318, 27)
        Me.OrderListLbl.Name = "OrderListLbl"
        Me.OrderListLbl.Size = New System.Drawing.Size(78, 20)
        Me.OrderListLbl.TabIndex = 0
        Me.OrderListLbl.Text = "Order List"
        '
        'NameLbl
        '
        Me.NameLbl.AutoSize = True
        Me.NameLbl.Location = New System.Drawing.Point(99, 10)
        Me.NameLbl.Name = "NameLbl"
        Me.NameLbl.Size = New System.Drawing.Size(35, 13)
        Me.NameLbl.TabIndex = 0
        Me.NameLbl.Text = "Name"
        '
        'PriceLbl
        '
        Me.PriceLbl.AutoSize = True
        Me.PriceLbl.Location = New System.Drawing.Point(73, 33)
        Me.PriceLbl.Name = "PriceLbl"
        Me.PriceLbl.Size = New System.Drawing.Size(61, 13)
        Me.PriceLbl.TabIndex = 2
        Me.PriceLbl.Text = "Price in Rs."
        '
        'DescriptionLbl
        '
        Me.DescriptionLbl.AutoSize = True
        Me.DescriptionLbl.Location = New System.Drawing.Point(74, 65)
        Me.DescriptionLbl.Name = "DescriptionLbl"
        Me.DescriptionLbl.Size = New System.Drawing.Size(60, 13)
        Me.DescriptionLbl.TabIndex = 3
        Me.DescriptionLbl.Text = "Description"
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(412, 12)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(75, 23)
        Me.Add.TabIndex = 4
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(146, 7)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NameTextBox.TabIndex = 5
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(146, 33)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PriceTextBox.TabIndex = 6
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(146, 59)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(200, 72)
        Me.RichTextBox1.TabIndex = 7
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Mfd. Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Exp. Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(73, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Food Type:"
        '
        'BreakfastRadioBtn
        '
        Me.BreakfastRadioBtn.AutoSize = True
        Me.BreakfastRadioBtn.Location = New System.Drawing.Point(146, 189)
        Me.BreakfastRadioBtn.Name = "BreakfastRadioBtn"
        Me.BreakfastRadioBtn.Size = New System.Drawing.Size(70, 17)
        Me.BreakfastRadioBtn.TabIndex = 24
        Me.BreakfastRadioBtn.TabStop = True
        Me.BreakfastRadioBtn.Text = "Breakfast"
        Me.BreakfastRadioBtn.UseVisualStyleBackColor = True
        '
        'DrinkRadioBtn
        '
        Me.DrinkRadioBtn.AutoSize = True
        Me.DrinkRadioBtn.Location = New System.Drawing.Point(222, 189)
        Me.DrinkRadioBtn.Name = "DrinkRadioBtn"
        Me.DrinkRadioBtn.Size = New System.Drawing.Size(50, 17)
        Me.DrinkRadioBtn.TabIndex = 25
        Me.DrinkRadioBtn.TabStop = True
        Me.DrinkRadioBtn.Text = "Drink"
        Me.DrinkRadioBtn.UseVisualStyleBackColor = True
        '
        'MfdDateTimePicker
        '
        Me.MfdDateTimePicker.Location = New System.Drawing.Point(146, 137)
        Me.MfdDateTimePicker.Name = "MfdDateTimePicker"
        Me.MfdDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.MfdDateTimePicker.TabIndex = 28
        '
        'ExpDateTimePicker
        '
        Me.ExpDateTimePicker.Location = New System.Drawing.Point(146, 163)
        Me.ExpDateTimePicker.Name = "ExpDateTimePicker"
        Me.ExpDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.ExpDateTimePicker.TabIndex = 29
        '
        'LunchRadioBtn
        '
        Me.LunchRadioBtn.AutoSize = True
        Me.LunchRadioBtn.Location = New System.Drawing.Point(340, 189)
        Me.LunchRadioBtn.Name = "LunchRadioBtn"
        Me.LunchRadioBtn.Size = New System.Drawing.Size(55, 17)
        Me.LunchRadioBtn.TabIndex = 30
        Me.LunchRadioBtn.TabStop = True
        Me.LunchRadioBtn.Text = "Lunch"
        Me.LunchRadioBtn.UseVisualStyleBackColor = True
        '
        'SnackRadioBtn
        '
        Me.SnackRadioBtn.AutoSize = True
        Me.SnackRadioBtn.Location = New System.Drawing.Point(278, 189)
        Me.SnackRadioBtn.Name = "SnackRadioBtn"
        Me.SnackRadioBtn.Size = New System.Drawing.Size(56, 17)
        Me.SnackRadioBtn.TabIndex = 31
        Me.SnackRadioBtn.TabStop = True
        Me.SnackRadioBtn.Text = "Snack"
        Me.SnackRadioBtn.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(412, 47)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(412, 86)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(75, 23)
        Me.Delete.TabIndex = 34
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 260)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(737, 210)
        Me.DataGridView1.TabIndex = 35
        '
        'AddItemPnl
        '
        Me.AddItemPnl.BackColor = System.Drawing.Color.Ivory
        Me.AddItemPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddItemPnl.Controls.Add(Me.DataGridView1)
        Me.AddItemPnl.Controls.Add(Me.Delete)
        Me.AddItemPnl.Controls.Add(Me.Button3)
        Me.AddItemPnl.Controls.Add(Me.SnackRadioBtn)
        Me.AddItemPnl.Controls.Add(Me.LunchRadioBtn)
        Me.AddItemPnl.Controls.Add(Me.ExpDateTimePicker)
        Me.AddItemPnl.Controls.Add(Me.MfdDateTimePicker)
        Me.AddItemPnl.Controls.Add(Me.DrinkRadioBtn)
        Me.AddItemPnl.Controls.Add(Me.BreakfastRadioBtn)
        Me.AddItemPnl.Controls.Add(Me.Label9)
        Me.AddItemPnl.Controls.Add(Me.Label2)
        Me.AddItemPnl.Controls.Add(Me.Label1)
        Me.AddItemPnl.Controls.Add(Me.RichTextBox1)
        Me.AddItemPnl.Controls.Add(Me.PriceTextBox)
        Me.AddItemPnl.Controls.Add(Me.NameTextBox)
        Me.AddItemPnl.Controls.Add(Me.Add)
        Me.AddItemPnl.Controls.Add(Me.DescriptionLbl)
        Me.AddItemPnl.Controls.Add(Me.PriceLbl)
        Me.AddItemPnl.Controls.Add(Me.NameLbl)
        Me.AddItemPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddItemPnl.Location = New System.Drawing.Point(0, 24)
        Me.AddItemPnl.Name = "AddItemPnl"
        Me.AddItemPnl.Size = New System.Drawing.Size(739, 472)
        Me.AddItemPnl.TabIndex = 2
        '
        'InventoryManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 496)
        Me.Controls.Add(Me.OrderListPanel)
        Me.Controls.Add(Me.AddItemPnl)
        Me.Controls.Add(Me.InventoryMenuStrip)
        Me.MainMenuStrip = Me.InventoryMenuStrip
        Me.Name = "InventoryManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Management"
        Me.InventoryMenuStrip.ResumeLayout(False)
        Me.InventoryMenuStrip.PerformLayout()
        Me.OrderListPanel.ResumeLayout(False)
        Me.OrderListPanel.PerformLayout()
        CType(Me.OrderListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddItemPnl.ResumeLayout(False)
        Me.AddItemPnl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InventoryMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents CheckOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderListPanel As System.Windows.Forms.Panel
    Friend WithEvents OrderListDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents OrderListLbl As System.Windows.Forms.Label
    Friend WithEvents NameLbl As System.Windows.Forms.Label
    Friend WithEvents PriceLbl As System.Windows.Forms.Label
    Friend WithEvents DescriptionLbl As System.Windows.Forms.Label
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BreakfastRadioBtn As System.Windows.Forms.RadioButton
    Friend WithEvents DrinkRadioBtn As System.Windows.Forms.RadioButton
    Friend WithEvents MfdDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ExpDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LunchRadioBtn As System.Windows.Forms.RadioButton
    Friend WithEvents SnackRadioBtn As System.Windows.Forms.RadioButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents AddItemPnl As System.Windows.Forms.Panel

End Class
