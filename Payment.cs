using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07
{
    internal class Payment : Document
    {
        public string InvoiceNumber { get; set; }
        public decimal Amount { get; set; }
        public string ServiceDescription { get; set; }

        public Payment(string title, DateTime regDate, DateTime execDate, string invoiceNumber, decimal amount, string description)
            : base(title, regDate, execDate)
        {
            InvoiceNumber = invoiceNumber;
            Amount = amount;
            ServiceDescription = description;
        }

        public override void CalculatePriority()
        {
            base.CalculatePriority();

            if (Amount > 10000m && Priority != DocumentPriority.Urgent)
            {
                Priority = DocumentPriority.High;
            }
        }

        public void MarkAsPaid()
        {
            Status = DocumentStatus.Completed;
            Console.WriteLine($"Счет {InvoiceNumber} на сумму {Amount} оплачен.");
        }

        public override string ToString()
        {
            return base.ToString() + $", Счет №{InvoiceNumber}, Сумма: {Amount} руб., Услуга: {ServiceDescription}";
        }
    }
}
