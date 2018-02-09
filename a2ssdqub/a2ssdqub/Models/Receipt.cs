using System;

namespace a2ssdqub.Models
{
    public class Receipt
    {
        public int? Id { get; set; }
        public DateTime IssueDate { get; set; }
        public Decimal Total { get; set; }
        public string PaymentMethod { get; set; }
        public bool Charged { get; set; }
        public Customer Customer { get; set; }

        public Receipt(DateTime issueDate, Decimal total, string paymentMethod, bool charged, int? id, Customer customer)
        {
            Id = id;
            IssueDate = issueDate;
            Total = total;
            PaymentMethod = paymentMethod;
            Charged = charged;
            Customer = customer;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", this.Id, this.Customer.Forename);
        }
    }
}
