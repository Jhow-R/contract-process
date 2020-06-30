using Course.Services;
using System;
using System.Collections.Generic;

namespace Course.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public double TotalValue { get; set; }
        public DateTime Date { get; set; }
        public List<Installment> Installments { get; private set; }

        public Contract(int number, double totalValue, DateTime date)
        {
            Number = number;
            TotalValue = totalValue;
            Date = date;
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
