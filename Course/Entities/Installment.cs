using System;
using System.Globalization;

namespace Course.Entities
{
    class Installment
    {
        public double Amount { get; set; }
        public DateTime DueDate { get; set; }

        public Installment(double amount, DateTime dueDate)
        {
            Amount = amount;
            DueDate = dueDate;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("C");
        }
    }
}
