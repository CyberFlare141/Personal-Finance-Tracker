using System;

namespace _20230104141_assingment_1
{
    // Represents a single repayment made against a debt record.
    public class DebtPayment
    {
        public int DebtId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
