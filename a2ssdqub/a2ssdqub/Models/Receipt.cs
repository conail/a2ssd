using System;

namespace a2ssdqub.Models
{
    public class Receipt
    {
        public int? Id { get; set; }
        public DateTime IssueDate { get; set; }
        public float Total { get; set; }
        public string PaymentMethod { get; set; }
        public bool Charged { get; set; }

        public Receipt(DateTime issueDate, float total, string paymentMethod, bool charged, int? id)
        {
            Id = id;
            IssueDate = issueDate;
            Total = total;
            PaymentMethod = paymentMethod;
            Charged = charged;
        }
    }
}
