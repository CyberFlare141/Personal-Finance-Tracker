using System;

namespace _20230104141_assingment_1
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
    }
}