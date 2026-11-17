using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07
{
    internal class Order : Document
    {
        public string OrderNumber { get; set; }
        public string IssuedBy { get; set; }
        public string Description { get; set; }

        public Order(string title, DateTime regDate, DateTime execDate, string orderNumber, string issuedBy, string description)
            : base(title, regDate, execDate)
        {
            OrderNumber = orderNumber;
            IssuedBy = issuedBy;
            Description = description;
        }

        public override void CalculatePriority()
        {
            base.CalculatePriority();

            if (Priority == DocumentPriority.Medium)
                Priority = DocumentPriority.High;
        }

        public void Execute()
        {
            Status = DocumentStatus.Completed;
            Console.WriteLine($"Распоряжение {OrderNumber} выполнено.");
        }

        public override string ToString()
        {
            return base.ToString() + $", №{OrderNumber}, Кем выдано: {IssuedBy}";
        }
    }
}
