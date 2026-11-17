using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07
{
    internal class Transfer : Document 
    {
        public string FromPerson { get; set; }
        public string ToPerson { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }

        public Transfer(string title, DateTime regDate, DateTime execDate, string from, string to, string item, int qty, decimal value)
            : base(title, regDate, execDate)
        {
            FromPerson = from;
            ToPerson = to;
            ItemName = item;
            Quantity = qty;
            Value = value;
        }

        public void ConfirmTransfer()
        {
            Status = DocumentStatus.Completed;
            Console.WriteLine($"Передача ценностей от {FromPerson} к {ToPerson} подтверждена.");
        }

        public override string ToString()
        {
            return base.ToString() + $", От: {FromPerson}, Кому: {ToPerson}, Что: {ItemName} (Кол-во: {Quantity})";
        }
    }
}
