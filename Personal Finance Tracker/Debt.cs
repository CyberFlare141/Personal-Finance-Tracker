using System;

namespace _20230104141_assingment_1
{
    // Represents a single debt record (either money the user owes, or money owed to the user).
    public class Debt
    {
        public int DebtId { get; set; }
        public string Name { get; set; } = "";
        public decimal OriginalAmount { get; set; }
        public decimal InterestRate { get; set; }
        public DateTime DueDate { get; set; }
        public string DebtType { get; set; } = "";   // "I Owe" or "Owed to Me"
        public decimal AmountPaid { get; set; }

        // Remaining balance still to be paid.
        public decimal GetOutstanding()
        {
            return OriginalAmount - AmountPaid;
        }

        // Auto-computes the status based on outstanding balance and due date.
        public string GetStatus()
        {
            decimal outstanding = GetOutstanding();

            if (outstanding <= 0)
                return "Paid";
            else if (DateTime.Today > DueDate.Date)
                return "Overdue";
            else
                return "Pending";
        }
    }
}
