using System.Collections.Generic;

namespace _20230104141_assingment_1
{
    public partial class Form1 : Form
    {
        private List<Transaction> transactions = new List<Transaction>();
        private DebtRepository objDebtRepo = new DebtRepository();

        public Form1()
        {
            InitializeComponent();

            this.Size = new Size(900, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            cmbCategory.Items.AddRange(new string[]
            {
                "Salary", "Freelance", "Food", "Transport", "Utilities", "Other"
            });

            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.ColumnHeadersVisible = true;
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.CellFormatting += dgvTransactions_CellFormatting;

            radIncome.Checked = true;
            UpdateSummary();

            // ---------- Debt Tracker setup ----------
            cmbDebtType.Items.AddRange(new string[] { "I Owe", "Owed to Me" });
            dgvDebts.CellFormatting += dgvDebts_CellFormatting;
            LoadDebtGrid();
        }

        private void button1_Click(object sender, EventArgs e)  // ADD button
        {
            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for the amount.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.",
                    "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // check if any radio button is active
            string type = "Expense";
            if (radIncome.Checked)
            {
                type = "Income";
            }

            Transaction newTransaction = new Transaction
            {
                Amount = amount,
                Category = cmbCategory.SelectedItem.ToString(),
                Type = type,
                Date = dtpDate.Value.Date,
                Notes = txtNotes.Text
            };

            transactions.Add(newTransaction);

            RefreshGrid();
            UpdateSummary();

            txtAmount.Clear();
            txtNotes.Clear();
        }

        private void RefreshGrid()
        {
            dgvTransactions.DataSource = null;
            dgvTransactions.DataSource = transactions;
            dgvTransactions.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)   // DELETE button
        {
            if (dgvTransactions.CurrentRow != null && dgvTransactions.CurrentRow.DataBoundItem != null)
            {
                Transaction selectedTransaction = (Transaction)dgvTransactions.CurrentRow.DataBoundItem;
                transactions.Remove(selectedTransaction);
                RefreshGrid();
                UpdateSummary();
            }
            else
            {
                MessageBox.Show("Please select a transaction to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateSummary()
        {
            decimal totalIncome = 0;
            decimal totalExpense = 0;

            foreach (Transaction t in transactions)
            {
                if (t.Type == "Income")
                {
                    totalIncome += t.Amount;
                }
                else if (t.Type == "Expense")
                {
                    totalExpense += t.Amount;
                }
            }

            decimal netBalance = totalIncome - totalExpense;

            lblTotalIncome.Text = "৳ " + totalIncome.ToString("N2");
            lblTotalExpenses.Text = "৳ " + totalExpense.ToString("N2");
            lblNetBalance.Text = "৳ " + netBalance.ToString("N2");


            lblNetBalance.ForeColor = netBalance < 0 ? Color.Red : Color.Green;
        }

        private void dgvTransactions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvTransactions.Columns[e.ColumnIndex].Name == "Amount" && e.Value != null)
            {
                string type = dgvTransactions.Rows[e.RowIndex].Cells["Type"].Value.ToString();
                decimal amount = (decimal)e.Value;

                if (type == "Income")
                {
                    e.Value = "+৳" + amount.ToString("N2");
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (type == "Expense")
                {
                    e.Value = "-৳" + amount.ToString("N2");
                    e.CellStyle.ForeColor = Color.Red;
                }

                e.FormattingApplied = true;
            }
        }

        //  Assignment 2 — Debt Management Module
        // Loads all debt records from the database into the grid and recalculates the summary bar.
        private void LoadDebtGrid()
        {
            List<Debt> debts = objDebtRepo.GetAllDebts();
            dgvDebts.Rows.Clear();

            decimal totalOutstanding = 0;
            decimal totalOwedToMe = 0;

            for (int i = 0; i < debts.Count; i++)
            {
                Debt debt = debts[i];
                decimal outstanding = debt.GetOutstanding();
                string status = debt.GetStatus();

                int rowIndex = dgvDebts.Rows.Add(
                    debt.DebtId,
                    debt.Name,
                    debt.DebtType,
                    "৳" + debt.OriginalAmount.ToString("N2"),
                    "৳" + debt.AmountPaid.ToString("N2"),
                    "৳" + outstanding.ToString("N2"),
                    debt.DueDate.ToString("dd/MM/yyyy"),
                    status
                );

                if (status == "Overdue")
                {
                    dgvDebts.Rows[rowIndex].DefaultCellStyle.BackColor = Color.MistyRose;
                }
                else if (status == "Paid")
                {
                    dgvDebts.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Honeydew;
                }

                if (debt.DebtType == "I Owe")
                    totalOutstanding += outstanding;
                else
                    totalOwedToMe += outstanding;
            }

            lblTotalOutstanding.Text = "৳ " + totalOutstanding.ToString("N2");
            lblTotalOwedToMe.Text = "৳ " + totalOwedToMe.ToString("N2");

            decimal netPosition = totalOwedToMe - totalOutstanding;
            lblNetDebtPosition.Text = "৳ " + netPosition.ToString("N2");
            lblNetDebtPosition.ForeColor = netPosition < 0 ? Color.Red : Color.Green;

            dgvDebts.ClearSelection();
        }

        // Colors the Status column based on Pending / Overdue / Paid.
        private void dgvDebts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null)
                return;

            string columnName = dgvDebts.Columns[e.ColumnIndex].Name;

            if (columnName == "colStatus")
            {
                string status = e.Value.ToString();
                if (status == "Overdue")
                    e.CellStyle.ForeColor = Color.DarkRed;
                else if (status == "Paid")
                    e.CellStyle.ForeColor = Color.DarkGreen;
                else if (status == "Pending")
                    e.CellStyle.ForeColor = Color.DarkOrange;
            }
            else if (columnName == "colType")               
            {
                string type = e.Value.ToString();
                if (type == "I Owe")
                    e.CellStyle.ForeColor = Color.DarkRed;
                else if (type == "Owed to Me")
                    e.CellStyle.ForeColor = Color.DarkGreen;
            }
            else if (columnName == "colOutstanding")         
            {
                string debtType = dgvDebts.Rows[e.RowIndex].Cells["colType"].Value?.ToString();
                if (debtType == "I Owe")
                    e.CellStyle.ForeColor = Color.DarkRed;
                else if (debtType == "Owed to Me")
                    e.CellStyle.ForeColor = Color.DarkGreen;
            }
        }

        // Validates the form fields (including the 0–100% interest rate rule) and saves a new debt record.
        private void btnAddDebt_Click(object sender, EventArgs e)
        {
            if (txtDebtName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a creditor / debtor name.",
                    "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtDebtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Amount must be a positive number.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtInterestRate.Text, out decimal rate) || rate < 0 || rate > 100)
            {
                MessageBox.Show("Interest rate must be between 0 and 100.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbDebtType.SelectedItem == null)
            {
                MessageBox.Show("Please select a debt type.",
                    "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Debt debt = new Debt();
            debt.Name = txtDebtName.Text.Trim();
            debt.OriginalAmount = amount;
            debt.InterestRate = rate;
            debt.DueDate = dtpDueDate.Value.Date;
            debt.DebtType = cmbDebtType.SelectedItem.ToString();

            objDebtRepo.AddDebt(debt);
            LoadDebtGrid();

            txtDebtName.Clear();
            txtDebtAmount.Clear();
            txtInterestRate.Clear();
        }

        // Deletes the currently selected debt record (with a confirmation prompt).
        private void btnDeleteDebt_Click(object sender, EventArgs e)
        {
            if (dgvDebts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a debt record to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Delete this debt record? This cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                int debtId = Convert.ToInt32(dgvDebts.SelectedRows[0].Cells["colDebtId"].Value);
                objDebtRepo.DeleteDebt(debtId);
                LoadDebtGrid();
            }
        }

        // Opens the modal DebtPaymentForm for the selected debt and reloads the grid if a payment was made.
        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            if (dgvDebts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a debt record first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int debtId = Convert.ToInt32(dgvDebts.SelectedRows[0].Cells["colDebtId"].Value);

            List<Debt> debts = objDebtRepo.GetAllDebts();
            Debt? selectedDebt = null;
            for (int i = 0; i < debts.Count; i++)
            {
                if (debts[i].DebtId == debtId)
                {
                    selectedDebt = debts[i];
                    break;
                }
            }

            if (selectedDebt == null)
            {
                return;
            }

            if (selectedDebt.GetOutstanding() <= 0)
            {
                MessageBox.Show("This debt is already fully paid.",
                    "Already Paid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DebtPaymentForm objPaymentForm = new DebtPaymentForm(selectedDebt, objDebtRepo);
            DialogResult result = objPaymentForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                LoadDebtGrid();
            }
        }

    }
}
