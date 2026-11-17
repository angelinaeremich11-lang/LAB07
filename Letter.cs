using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07
{
    internal class Letter : Document
    {
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }

        public Letter(string title, DateTime regDate, DateTime execDate, string sender, string recipient, string subject)
            : base(title, regDate, execDate)
        {
            Sender = sender;
            Recipient = recipient;
            Subject = subject;
        }

        public void MarkAsRead()
        {
            Status = DocumentStatus.Completed;
            Console.WriteLine($"Письмо от {Sender} прочитано.");
        }

        public override string ToString()
        {
            return base.ToString() + $", От: {Sender}, Кому: {Recipient}, Тема: {Subject}";
        }
    }
}
