using System;

namespace a2ssdqub.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Forename { get; set; }
        public DateTime Dob { get; set; }
        public string Sex { get; set; }

        /// <summary>
        /// Creates CUSTOMER objects/records
        /// </summary>
        public Customer(string forename, DateTime dob, string sex)
        {
            // CusID will be auto-generated
            Forename = forename;
            Dob = dob;
            Sex = sex;
        }

        /// <summary>
        /// Retrieves CUSTOMER records as objects.
        /// </summary>
        public Customer(int id, string forename, DateTime dob, string sex)
        {
            Id = id;
            Forename = forename;
            Dob = dob;
            Sex = sex;
        }

        /// <summary>
        /// Formatting dates into strings.
        /// </summary>
        public string GetFormattedDate()
        {
            return string.Format("{0:dd/MM/yyyy}", Dob);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}", Id, Forename, GetFormattedDate(), Sex);
        }
    }
}