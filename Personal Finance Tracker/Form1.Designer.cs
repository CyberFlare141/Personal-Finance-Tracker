namespace _20230104141_assingment_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Amount = new Label();
            txtAmount = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNotes = new TextBox();
            cmbCategory = new ComboBox();
            radExpense = new RadioButton();
            radIncome = new RadioButton();
            dtpDate = new DateTimePicker();
            button1 = new Button();
            lblTotalIncome = new Label();
            lblTotalExpenses = new Label();
            lblNetBalance = new Label();
            dgvTransactions = new DataGridView();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            groupBox2 = new GroupBox();
            label7 = new Label();
            button2 = new Button();
            tabControl1 = new TabControl();
            tabFinance = new TabPage();
            tabDebtTracker = new TabPage();
            groupBoxAddDebt = new GroupBox();
            lblDebtName = new Label();
            txtDebtName = new TextBox();
            lblDebtAmount = new Label();
            txtDebtAmount = new TextBox();
            lblInterestRate = new Label();
            txtInterestRate = new TextBox();
            lblDueDate = new Label();
            dtpDueDate = new DateTimePicker();
            lblDebtType = new Label();
            cmbDebtType = new ComboBox();
            btnAddDebt = new Button();
            dgvDebts = new DataGridView();
            colDebtId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colOriginal = new DataGridViewTextBoxColumn();
            colPaid = new DataGridViewTextBoxColumn();
            colOutstanding = new DataGridViewTextBoxColumn();
            colDueDate = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            btnMakePayment = new Button();
            btnDeleteDebt = new Button();
            panelOutstanding = new Panel();
            lblOutstandingTitle = new Label();
            lblTotalOutstanding = new Label();
            panelOwedToMe = new Panel();
            lblOwedToMeTitle = new Label();
            lblTotalOwedToMe = new Label();
            panelNetPosition = new Panel();
            lblNetPositionTitle = new Label();
            lblNetDebtPosition = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabFinance.SuspendLayout();
            tabDebtTracker.SuspendLayout();
            groupBoxAddDebt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDebts).BeginInit();
            panelOutstanding.SuspendLayout();
            panelOwedToMe.SuspendLayout();
            panelNetPosition.SuspendLayout();
            SuspendLayout();
            // 
            // Amount
            // 
            Amount.AutoSize = true;
            Amount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Amount.Location = new Point(20, 45);
            Amount.Name = "Amount";
            Amount.Size = new Size(95, 21);
            Amount.TabIndex = 0;
            Amount.Text = "Amount (৳)";
            // 
            // txtAmount
            // 
            txtAmount.BackColor = SystemColors.GradientInactiveCaption;
            txtAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(20, 69);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(260, 29);
            txtAmount.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 114);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 2;
            label1.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 246);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 3;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 313);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 4;
            label3.Text = "Notes";
            // 
            // txtNotes
            // 
            txtNotes.BackColor = SystemColors.GradientInactiveCaption;
            txtNotes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNotes.Location = new Point(23, 339);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(257, 29);
            txtNotes.TabIndex = 5;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = SystemColors.GradientInactiveCaption;
            cmbCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(20, 138);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(260, 29);
            cmbCategory.TabIndex = 6;
            // 
            // radExpense
            // 
            radExpense.AutoSize = true;
            radExpense.Location = new Point(134, 207);
            radExpense.Name = "radExpense";
            radExpense.Size = new Size(100, 29);
            radExpense.TabIndex = 1;
            radExpense.TabStop = true;
            radExpense.Text = "Expense";
            radExpense.UseVisualStyleBackColor = true;
            // 
            // radIncome
            // 
            radIncome.AutoSize = true;
            radIncome.Location = new Point(25, 207);
            radIncome.Name = "radIncome";
            radIncome.Size = new Size(94, 29);
            radIncome.TabIndex = 0;
            radIncome.TabStop = true;
            radIncome.Text = "Income";
            radIncome.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDate.Location = new Point(23, 268);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(260, 29);
            dtpDate.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(23, 378);
            button1.Name = "button1";
            button1.Size = new Size(260, 34);
            button1.TabIndex = 9;
            button1.Text = "+ Add Transaction";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalIncome.ForeColor = Color.DarkGreen;
            lblTotalIncome.Location = new Point(23, 45);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(147, 30);
            lblTotalIncome.TabIndex = 11;
            lblTotalIncome.Text = "Total Income";
            // 
            // lblTotalExpenses
            // 
            lblTotalExpenses.AutoSize = true;
            lblTotalExpenses.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalExpenses.ForeColor = Color.IndianRed;
            lblTotalExpenses.Location = new Point(21, 45);
            lblTotalExpenses.Name = "lblTotalExpenses";
            lblTotalExpenses.Size = new Size(167, 30);
            lblTotalExpenses.TabIndex = 12;
            lblTotalExpenses.Text = "Total Expenses";
            // 
            // lblNetBalance
            // 
            lblNetBalance.AutoSize = true;
            lblNetBalance.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNetBalance.Location = new Point(38, 45);
            lblNetBalance.Name = "lblNetBalance";
            lblNetBalance.Size = new Size(137, 30);
            lblNetBalance.TabIndex = 13;
            lblNetBalance.Text = "Net Balance";
            // 
            // dgvTransactions
            // 
            dgvTransactions.BackgroundColor = SystemColors.ButtonHighlight;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.GridColor = SystemColors.ScrollBar;
            dgvTransactions.Location = new Point(333, 133);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.Size = new Size(520, 341);
            dgvTransactions.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblTotalIncome);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 89);
            panel1.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 13);
            label4.Name = "label4";
            label4.Size = new Size(182, 30);
            label4.TabIndex = 18;
            label4.Text = "↑ TOTAL INCOME";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblTotalExpenses);
            panel2.Location = new Point(304, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 89);
            panel2.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 13);
            label5.Name = "label5";
            label5.Size = new Size(199, 30);
            label5.TabIndex = 19;
            label5.Text = "↓ TOTAL EXPENSES";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(lblNetBalance);
            panel3.Location = new Point(591, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 89);
            panel3.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 13);
            label6.Name = "label6";
            label6.Size = new Size(181, 30);
            label6.TabIndex = 19;
            label6.Text = "𓍝 NET BALANCE";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(radExpense);
            groupBox2.Controls.Add(Amount);
            groupBox2.Controls.Add(radIncome);
            groupBox2.Controls.Add(txtAmount);
            groupBox2.Controls.Add(dtpDate);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cmbCategory);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtNotes);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 121);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(294, 441);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "+ Add Transaction";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(23, 186);
            label7.Name = "label7";
            label7.Size = new Size(42, 21);
            label7.TabIndex = 10;
            label7.Text = "Type";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(657, 492);
            button2.Name = "button2";
            button2.Size = new Size(196, 36);
            button2.TabIndex = 21;
            button2.Text = "🗑 Delete Selected";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnDelete_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabFinance);
            tabControl1.Controls.Add(tabDebtTracker);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(884, 561);
            tabControl1.TabIndex = 22;
            // 
            // tabFinance
            // 
            tabFinance.BackColor = Color.OldLace;
            tabFinance.Controls.Add(button2);
            tabFinance.Controls.Add(groupBox2);
            tabFinance.Controls.Add(panel3);
            tabFinance.Controls.Add(panel2);
            tabFinance.Controls.Add(panel1);
            tabFinance.Controls.Add(dgvTransactions);
            tabFinance.Location = new Point(4, 26);
            tabFinance.Name = "tabFinance";
            tabFinance.Padding = new Padding(3);
            tabFinance.Size = new Size(876, 531);
            tabFinance.TabIndex = 0;
            tabFinance.Text = "📋 Finance";
            // 
            // tabDebtTracker
            // 
            tabDebtTracker.BackColor = Color.OldLace;
            tabDebtTracker.Controls.Add(groupBoxAddDebt);
            tabDebtTracker.Controls.Add(dgvDebts);
            tabDebtTracker.Controls.Add(btnMakePayment);
            tabDebtTracker.Controls.Add(btnDeleteDebt);
            tabDebtTracker.Controls.Add(panelOutstanding);
            tabDebtTracker.Controls.Add(panelOwedToMe);
            tabDebtTracker.Controls.Add(panelNetPosition);
            tabDebtTracker.Location = new Point(4, 26);
            tabDebtTracker.Name = "tabDebtTracker";
            tabDebtTracker.Padding = new Padding(3);
            tabDebtTracker.Size = new Size(876, 531);
            tabDebtTracker.TabIndex = 1;
            tabDebtTracker.Text = "💼 Debt Tracker";
            // 
            // groupBoxAddDebt
            // 
            groupBoxAddDebt.BackColor = Color.White;
            groupBoxAddDebt.Controls.Add(lblDebtName);
            groupBoxAddDebt.Controls.Add(txtDebtName);
            groupBoxAddDebt.Controls.Add(lblDebtAmount);
            groupBoxAddDebt.Controls.Add(txtDebtAmount);
            groupBoxAddDebt.Controls.Add(lblInterestRate);
            groupBoxAddDebt.Controls.Add(txtInterestRate);
            groupBoxAddDebt.Controls.Add(lblDueDate);
            groupBoxAddDebt.Controls.Add(dtpDueDate);
            groupBoxAddDebt.Controls.Add(lblDebtType);
            groupBoxAddDebt.Controls.Add(cmbDebtType);
            groupBoxAddDebt.Controls.Add(btnAddDebt);
            groupBoxAddDebt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxAddDebt.Location = new Point(12, 12);
            groupBoxAddDebt.Name = "groupBoxAddDebt";
            groupBoxAddDebt.Size = new Size(264, 400);
            groupBoxAddDebt.TabIndex = 0;
            groupBoxAddDebt.TabStop = false;
            groupBoxAddDebt.Text = "+ Add Debt Record";
            // 
            // lblDebtName
            // 
            lblDebtName.AutoSize = true;
            lblDebtName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDebtName.Location = new Point(16, 40);
            lblDebtName.Name = "lblDebtName";
            lblDebtName.Size = new Size(149, 17);
            lblDebtName.TabIndex = 0;
            lblDebtName.Text = "Creditor / Debtor Name";
            // 
            // txtDebtName
            // 
            txtDebtName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDebtName.Location = new Point(16, 60);
            txtDebtName.Name = "txtDebtName";
            txtDebtName.Size = new Size(230, 25);
            txtDebtName.TabIndex = 1;
            // 
            // lblDebtAmount
            // 
            lblDebtAmount.AutoSize = true;
            lblDebtAmount.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDebtAmount.Location = new Point(16, 98);
            lblDebtAmount.Name = "lblDebtAmount";
            lblDebtAmount.Size = new Size(108, 17);
            lblDebtAmount.TabIndex = 2;
            lblDebtAmount.Text = "Total Amount (৳)";
            // 
            // txtDebtAmount
            // 
            txtDebtAmount.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDebtAmount.Location = new Point(16, 118);
            txtDebtAmount.Name = "txtDebtAmount";
            txtDebtAmount.Size = new Size(230, 25);
            txtDebtAmount.TabIndex = 3;
            // 
            // lblInterestRate
            // 
            lblInterestRate.AutoSize = true;
            lblInterestRate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInterestRate.Location = new Point(16, 156);
            lblInterestRate.Name = "lblInterestRate";
            lblInterestRate.Size = new Size(104, 17);
            lblInterestRate.TabIndex = 4;
            lblInterestRate.Text = "Interest Rate (%)";
            // 
            // txtInterestRate
            // 
            txtInterestRate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInterestRate.Location = new Point(16, 176);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(230, 25);
            txtInterestRate.TabIndex = 5;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDueDate.Location = new Point(16, 214);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(62, 17);
            lblDueDate.TabIndex = 6;
            lblDueDate.Text = "Due Date";
            // 
            // dtpDueDate
            // 
            dtpDueDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDueDate.Format = DateTimePickerFormat.Short;
            dtpDueDate.Location = new Point(16, 234);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(230, 25);
            dtpDueDate.TabIndex = 7;
            // 
            // lblDebtType
            // 
            lblDebtType.AutoSize = true;
            lblDebtType.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDebtType.Location = new Point(16, 272);
            lblDebtType.Name = "lblDebtType";
            lblDebtType.Size = new Size(67, 17);
            lblDebtType.TabIndex = 8;
            lblDebtType.Text = "Debt Type";
            // 
            // cmbDebtType
            // 
            cmbDebtType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDebtType.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDebtType.FormattingEnabled = true;
            cmbDebtType.Location = new Point(16, 292);
            cmbDebtType.Name = "cmbDebtType";
            cmbDebtType.Size = new Size(230, 25);
            cmbDebtType.TabIndex = 9;
            // 
            // btnAddDebt
            // 
            btnAddDebt.BackColor = Color.MediumPurple;
            btnAddDebt.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddDebt.ForeColor = Color.White;
            btnAddDebt.Location = new Point(16, 340);
            btnAddDebt.Name = "btnAddDebt";
            btnAddDebt.Size = new Size(230, 34);
            btnAddDebt.TabIndex = 10;
            btnAddDebt.Text = "+ Add Debt";
            btnAddDebt.UseVisualStyleBackColor = false;
            btnAddDebt.Click += btnAddDebt_Click;
            // 
            // dgvDebts
            // 
            dgvDebts.AllowUserToAddRows = false;
            dgvDebts.AllowUserToDeleteRows = false;
            dgvDebts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDebts.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDebts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDebts.Columns.AddRange(new DataGridViewColumn[] { colDebtId, colName, colType, colOriginal, colPaid, colOutstanding, colDueDate, colStatus });
            dgvDebts.GridColor = SystemColors.ScrollBar;
            dgvDebts.Location = new Point(292, 12);
            dgvDebts.Name = "dgvDebts";
            dgvDebts.ReadOnly = true;
            dgvDebts.RowHeadersVisible = false;
            dgvDebts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDebts.Size = new Size(561, 340);
            dgvDebts.TabIndex = 11;
            // 
            // colDebtId
            // 
            colDebtId.HeaderText = "DebtId";
            colDebtId.Name = "colDebtId";
            colDebtId.ReadOnly = true;
            colDebtId.Visible = false;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colType
            // 
            colType.HeaderText = "Type";
            colType.Name = "colType";
            colType.ReadOnly = true;
            // 
            // colOriginal
            // 
            colOriginal.HeaderText = "Original Amount";
            colOriginal.Name = "colOriginal";
            colOriginal.ReadOnly = true;
            // 
            // colPaid
            // 
            colPaid.HeaderText = "Amount Paid";
            colPaid.Name = "colPaid";
            colPaid.ReadOnly = true;
            // 
            // colOutstanding
            // 
            colOutstanding.HeaderText = "Outstanding";
            colOutstanding.Name = "colOutstanding";
            colOutstanding.ReadOnly = true;
            // 
            // colDueDate
            // 
            colDueDate.HeaderText = "Due Date";
            colDueDate.Name = "colDueDate";
            colDueDate.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // btnMakePayment
            // 
            btnMakePayment.BackColor = Color.White;
            btnMakePayment.FlatAppearance.BorderColor = Color.MediumPurple;
            btnMakePayment.FlatStyle = FlatStyle.Flat;
            btnMakePayment.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMakePayment.ForeColor = Color.MediumPurple;
            btnMakePayment.Location = new Point(597, 360);
            btnMakePayment.Name = "btnMakePayment";
            btnMakePayment.Size = new Size(128, 34);
            btnMakePayment.TabIndex = 12;
            btnMakePayment.Text = "💳 Make Payment";
            btnMakePayment.UseVisualStyleBackColor = false;
            btnMakePayment.Click += btnMakePayment_Click;
            // 
            // btnDeleteDebt
            // 
            btnDeleteDebt.BackColor = Color.White;
            btnDeleteDebt.FlatAppearance.BorderColor = Color.Red;
            btnDeleteDebt.FlatStyle = FlatStyle.Flat;
            btnDeleteDebt.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteDebt.ForeColor = Color.Red;
            btnDeleteDebt.Location = new Point(731, 360);
            btnDeleteDebt.Name = "btnDeleteDebt";
            btnDeleteDebt.Size = new Size(122, 34);
            btnDeleteDebt.TabIndex = 13;
            btnDeleteDebt.Text = "🗑 Delete Selected";
            btnDeleteDebt.UseVisualStyleBackColor = false;
            btnDeleteDebt.Click += btnDeleteDebt_Click;
            // 
            // panelOutstanding
            // 
            panelOutstanding.BackColor = Color.White;
            panelOutstanding.Controls.Add(lblOutstandingTitle);
            panelOutstanding.Controls.Add(lblTotalOutstanding);
            panelOutstanding.Location = new Point(292, 415);
            panelOutstanding.Name = "panelOutstanding";
            panelOutstanding.Size = new Size(180, 95);
            panelOutstanding.TabIndex = 14;
            // 
            // lblOutstandingTitle
            // 
            lblOutstandingTitle.AutoSize = true;
            lblOutstandingTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutstandingTitle.Location = new Point(10, 13);
            lblOutstandingTitle.Name = "lblOutstandingTitle";
            lblOutstandingTitle.Size = new Size(164, 17);
            lblOutstandingTitle.TabIndex = 0;
            lblOutstandingTitle.Text = "↓ Total Debt Outstanding";
            // 
            // lblTotalOutstanding
            // 
            lblTotalOutstanding.AutoSize = true;
            lblTotalOutstanding.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalOutstanding.ForeColor = Color.IndianRed;
            lblTotalOutstanding.Location = new Point(10, 42);
            lblTotalOutstanding.Name = "lblTotalOutstanding";
            lblTotalOutstanding.Size = new Size(73, 25);
            lblTotalOutstanding.TabIndex = 1;
            lblTotalOutstanding.Text = "৳ 0.00";
            // 
            // panelOwedToMe
            // 
            panelOwedToMe.BackColor = Color.White;
            panelOwedToMe.Controls.Add(lblOwedToMeTitle);
            panelOwedToMe.Controls.Add(lblTotalOwedToMe);
            panelOwedToMe.Location = new Point(484, 415);
            panelOwedToMe.Name = "panelOwedToMe";
            panelOwedToMe.Size = new Size(180, 95);
            panelOwedToMe.TabIndex = 15;
            // 
            // lblOwedToMeTitle
            // 
            lblOwedToMeTitle.AutoSize = true;
            lblOwedToMeTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOwedToMeTitle.Location = new Point(10, 13);
            lblOwedToMeTitle.Name = "lblOwedToMeTitle";
            lblOwedToMeTitle.Size = new Size(128, 17);
            lblOwedToMeTitle.TabIndex = 0;
            lblOwedToMeTitle.Text = "↑ Total Owed to Me";
            // 
            // lblTotalOwedToMe
            // 
            lblTotalOwedToMe.AutoSize = true;
            lblTotalOwedToMe.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalOwedToMe.ForeColor = Color.DarkGreen;
            lblTotalOwedToMe.Location = new Point(10, 42);
            lblTotalOwedToMe.Name = "lblTotalOwedToMe";
            lblTotalOwedToMe.Size = new Size(73, 25);
            lblTotalOwedToMe.TabIndex = 1;
            lblTotalOwedToMe.Text = "৳ 0.00";
            // 
            // panelNetPosition
            // 
            panelNetPosition.BackColor = Color.White;
            panelNetPosition.Controls.Add(lblNetPositionTitle);
            panelNetPosition.Controls.Add(lblNetDebtPosition);
            panelNetPosition.Location = new Point(676, 415);
            panelNetPosition.Name = "panelNetPosition";
            panelNetPosition.Size = new Size(180, 95);
            panelNetPosition.TabIndex = 16;
            // 
            // lblNetPositionTitle
            // 
            lblNetPositionTitle.AutoSize = true;
            lblNetPositionTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNetPositionTitle.Location = new Point(10, 13);
            lblNetPositionTitle.Name = "lblNetPositionTitle";
            lblNetPositionTitle.Size = new Size(142, 17);
            lblNetPositionTitle.TabIndex = 0;
            lblNetPositionTitle.Text = "⚖ Net Debt Position";
            // 
            // lblNetDebtPosition
            // 
            lblNetDebtPosition.AutoSize = true;
            lblNetDebtPosition.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNetDebtPosition.Location = new Point(10, 42);
            lblNetDebtPosition.Name = "lblNetDebtPosition";
            lblNetDebtPosition.Size = new Size(73, 25);
            lblNetDebtPosition.TabIndex = 1;
            lblNetDebtPosition.Text = "৳ 0.00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(884, 561);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Personal Finance Tracker";
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabFinance.ResumeLayout(false);
            tabDebtTracker.ResumeLayout(false);
            groupBoxAddDebt.ResumeLayout(false);
            groupBoxAddDebt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDebts).EndInit();
            panelOutstanding.ResumeLayout(false);
            panelOutstanding.PerformLayout();
            panelOwedToMe.ResumeLayout(false);
            panelOwedToMe.PerformLayout();
            panelNetPosition.ResumeLayout(false);
            panelNetPosition.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // ---------- Assignment 1 fields (unchanged) ----------
        private Label Amount;
        private MaskedTextBox txtAmount;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNotes;
        private ComboBox cmbCategory;
        private RadioButton radExpense;
        private RadioButton radIncome;
        private DateTimePicker dtpDate;
        private Button button1;
        private Label lblTotalIncome;
        private Label lblTotalExpenses;
        private Label lblNetBalance;
        private DataGridView dgvTransactions;
        private EventHandler label2_Click;
        private EventHandler lblTotalIncome_Click;
        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private Label label5;
        private Panel panel3;
        private Label label6;
        private GroupBox groupBox2;
        private Button button2;
        private Label label7;

        public EventHandler Form1_Load { get; private set; }

        // ---------- Assignment 2 fields (Debt Tracker) ----------
        private TabControl tabControl1;
        private TabPage tabFinance;
        private TabPage tabDebtTracker;
        private GroupBox groupBoxAddDebt;
        private Label lblDebtName;
        private TextBox txtDebtName;
        private Label lblDebtAmount;
        private TextBox txtDebtAmount;
        private Label lblInterestRate;
        private TextBox txtInterestRate;
        private Label lblDueDate;
        private DateTimePicker dtpDueDate;
        private Label lblDebtType;
        private ComboBox cmbDebtType;
        private Button btnAddDebt;
        private DataGridView dgvDebts;
        private DataGridViewTextBoxColumn colDebtId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colOriginal;
        private DataGridViewTextBoxColumn colPaid;
        private DataGridViewTextBoxColumn colOutstanding;
        private DataGridViewTextBoxColumn colDueDate;
        private DataGridViewTextBoxColumn colStatus;
        private Button btnMakePayment;
        private Button btnDeleteDebt;
        private Panel panelOutstanding;
        private Label lblOutstandingTitle;
        private Label lblTotalOutstanding;
        private Panel panelOwedToMe;
        private Label lblOwedToMeTitle;
        private Label lblTotalOwedToMe;
        private Panel panelNetPosition;
        private Label lblNetPositionTitle;
        private Label lblNetDebtPosition;
    }
}
