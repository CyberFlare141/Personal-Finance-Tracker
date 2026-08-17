namespace _20230104141_assingment_1
{
    partial class DebtPaymentForm
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
            lblTitle = new Label();
            lblDebtLabel = new Label();
            cmbDebt = new ComboBox();
            lblAmountLabel = new Label();
            txtPaymentAmount = new TextBox();
            lblDateLabel = new Label();
            dtpPaymentDate = new DateTimePicker();
            lblPreview = new Label();
            btnCancel = new Button();
            btnConfirmPayment = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(150, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "💳 Make Payment";
            // 
            // lblDebtLabel
            // 
            lblDebtLabel.AutoSize = true;
            lblDebtLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDebtLabel.Location = new Point(20, 55);
            lblDebtLabel.Name = "lblDebtLabel";
            lblDebtLabel.Size = new Size(37, 17);
            lblDebtLabel.TabIndex = 1;
            lblDebtLabel.Text = "Debt";
            // 
            // cmbDebt
            // 
            cmbDebt.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDebt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDebt.FormattingEnabled = true;
            cmbDebt.Location = new Point(20, 75);
            cmbDebt.Name = "cmbDebt";
            cmbDebt.Size = new Size(320, 25);
            cmbDebt.TabIndex = 2;
            // 
            // lblAmountLabel
            // 
            lblAmountLabel.AutoSize = true;
            lblAmountLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmountLabel.Location = new Point(20, 113);
            lblAmountLabel.Name = "lblAmountLabel";
            lblAmountLabel.Size = new Size(112, 17);
            lblAmountLabel.TabIndex = 3;
            lblAmountLabel.Text = "Payment Amount (৳)";
            // 
            // txtPaymentAmount
            // 
            txtPaymentAmount.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPaymentAmount.Location = new Point(20, 133);
            txtPaymentAmount.Name = "txtPaymentAmount";
            txtPaymentAmount.Size = new Size(320, 25);
            txtPaymentAmount.TabIndex = 4;
            txtPaymentAmount.TextChanged += txtPaymentAmount_TextChanged;
            // 
            // lblDateLabel
            // 
            lblDateLabel.AutoSize = true;
            lblDateLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateLabel.Location = new Point(20, 171);
            lblDateLabel.Name = "lblDateLabel";
            lblDateLabel.Size = new Size(93, 17);
            lblDateLabel.TabIndex = 5;
            lblDateLabel.Text = "Payment Date";
            // 
            // dtpPaymentDate
            // 
            dtpPaymentDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpPaymentDate.Format = DateTimePickerFormat.Short;
            dtpPaymentDate.Location = new Point(20, 191);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new Size(320, 25);
            dtpPaymentDate.TabIndex = 6;
            // 
            // lblPreview
            // 
            lblPreview.AutoSize = true;
            lblPreview.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreview.ForeColor = Color.MediumPurple;
            lblPreview.Location = new Point(20, 229);
            lblPreview.Name = "lblPreview";
            lblPreview.Size = new Size(0, 19);
            lblPreview.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gainsboro;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(140, 265);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 34);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirmPayment
            // 
            btnConfirmPayment.BackColor = Color.MediumPurple;
            btnConfirmPayment.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmPayment.ForeColor = Color.White;
            btnConfirmPayment.Location = new Point(240, 265);
            btnConfirmPayment.Name = "btnConfirmPayment";
            btnConfirmPayment.Size = new Size(100, 34);
            btnConfirmPayment.TabIndex = 9;
            btnConfirmPayment.Text = "✔ Confirm Payment";
            btnConfirmPayment.UseVisualStyleBackColor = false;
            btnConfirmPayment.Click += btnConfirmPayment_Click;
            // 
            // DebtPaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(362, 320);
            Controls.Add(lblTitle);
            Controls.Add(lblDebtLabel);
            Controls.Add(cmbDebt);
            Controls.Add(lblAmountLabel);
            Controls.Add(txtPaymentAmount);
            Controls.Add(lblDateLabel);
            Controls.Add(dtpPaymentDate);
            Controls.Add(lblPreview);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirmPayment);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DebtPaymentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Make Payment";
            Load += DebtPaymentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDebtLabel;
        private ComboBox cmbDebt;
        private Label lblAmountLabel;
        private TextBox txtPaymentAmount;
        private Label lblDateLabel;
        private DateTimePicker dtpPaymentDate;
        private Label lblPreview;
        private Button btnCancel;
        private Button btnConfirmPayment;
    }
}
