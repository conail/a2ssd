using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a2ssdqub.Models
{
    public class Customer
    {
        // Instance variables, as Properties
        // VISIBILITY MODIFIER??????????????????????? - private??
        public int Id { get; set; }
        public string Forename { get; set; }
        public DateTime Dob { get; set; }
        public string Sex { get; set; }

        /*
         * This is used when creating CUSTOMER objects/records
         */
        public Customer(string forename, DateTime dob, string sex)
        {
            // CusID will be auto-generated
            Forename = forename;
            Dob = dob;
            Sex = sex;
        }

        /*
         * This is used when retrieving CUSTOMER records as objects
         */
        public Customer(int id, string forename, DateTime dob, string sex)
        {
            Id = id;
            Forename = forename;
            Dob = dob;
            Sex = sex;
        }

        public Customer()
        {
            // default constructor lost without this
        }


        // Formatting dates into strings
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
