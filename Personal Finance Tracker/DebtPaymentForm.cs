using System;
using System.Windows.Forms;

namespace _20230104141_assingment_1
{
    public partial class DebtPaymentForm : Form
    {
        private Debt selectedDebt;
        private DebtRepository objDebtRepo;

        public DebtPaymentForm(Debt debt, DebtRepository repo)
        {
            InitializeComponent();
            selectedDebt = debt;
            objDebtRepo = repo;
        }

        // Populates the debt's current outstanding balance when the dialog opens.
        private void DebtPaymentForm_Load(object sender, EventArgs e)
        {
            cmbDebt.Items.Clear();
            cmbDebt.Items.Add(selectedDebt.Name + " — Outstanding: ৳" + selectedDebt.GetOutstanding().ToString("N2"));
            cmbDebt.SelectedIndex = 0;

            dtpPaymentDate.Value = DateTime.Today;
            lblPreview.Text = "";
        }

        // Live-updates the "after payment" preview as the user types an amount.
        private void txtPaymentAmount_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPaymentAmount.Text, out decimal amount))
            {
                decimal remaining = selectedDebt.GetOutstanding() - amount;
                lblPreview.Text = "After payment: Outstanding = ৳" + remaining.ToString("N2");
            }
            else
            {
                lblPreview.Text = "";
            }
        }

        // Validates the payment and saves it, then closes the dialog with DialogResult.OK.
        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPaymentAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Enter a valid positive payment amount.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (amount > selectedDebt.GetOutstanding())
            {
                MessageBox.Show("Payment cannot exceed the outstanding balance of ৳"
                    + selectedDebt.GetOutstanding().ToString("N2"), "Invalid Payment",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DebtPayment payment = new DebtPayment();
            payment.DebtId = selectedDebt.DebtId;
            payment.Amount = amount;
            payment.PaymentDate = dtpPaymentDate.Value;

            objDebtRepo.AddPayment(payment);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
