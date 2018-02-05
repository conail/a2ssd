using System.Collections.Generic;
using System.Configuration; // needed for _connectionString
using System.Data.SqlClient; // needed for SqlConnection
using a2ssdqub.Models; // to link to Models folder full of class-representations

namespace a2ssdqub.DAL
{
    public class CustomerDAL
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["konekt"].ConnectionString;

        public static int Add(Customer customer)
        {
            int lastID = -1; // -1 suggests failed INSERT, looks like T for Trouble

            using(var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var query = string.Format(@"
                    INSERT INTO CUSTOMERS 
                    OUTPUT INSERTED.CustID 
                    VALUES('{0}','{1}','{2}');", 
                    customer.Fname, customer.GetFormattedDate(), customer.Sex);

                var command = new SqlCommand(query, connection);

                lastID = (int) command.ExecuteScalar(); 

                connection.Close();
                return lastID;
            }
        }

        public static bool Update(Customer customer)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
              
                var query = string.Format(@"UPDATE CUSTOMERS 
                    SET Forename = '{0}', DoB = '{1}', Gender = '{2}' 
                    WHERE CustID = '{3}';", 
                    customer.Fname, customer.Dob, customer.Sex, 
                    customer.CusID);
            
                int rowsAffected = (new SqlCommand(query, connection)).ExecuteNonQuery();

                connection.Close();

                return rowsAffected == 1;
            }
        }

        /**
         * Deletes a single customer, specified by it's ID.
         */
        public static int Delete(int id) // better name: DeleteCusByID
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                
                var query = string.Format(@"
                    DELETE FROM Customers 
                    WHERE CustID = {0}", 
                    id
                );

                var command = new SqlCommand(query, connection);

                int rowsAffected = command.ExecuteNonQuery();

                connection.Close();

                return rowsAffected;
            }
        }

        public static List<Customer> Get()
        {
            var customerDetails = new List<Customer>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
              
                SqlCommand command = new SqlCommand(@"
                    SELECT * 
                    FROM Customers 
                    ORDER BY CustID", 
                    connection
                );

                // Executes the early stages of doing the command by figuring out how many results there'll be
                // Ensures size of result set isn't egregious
                var reader = command.ExecuteReader();

                // iterate through the result set; each iteration is 1 record
                while(reader.Read()) customerDetails.Add(new Customer(
                    reader.GetInt32(0), 
                    reader.GetString(1), 
                    reader.GetDateTime(2), 
                    reader.GetString(3)
                ));
      
                connection.Close();

                return customerDetails;
            }
        }

        public static Customer Get(int id)
        {
            Customer customer = null;

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand(string.Format(@"
                    SELECT CustID, Forename, DoB, Gender 
                    FROM Customers 
                    WHERE CustID = {0}", 
                    id
                ), 
                connection);

                var r = command.ExecuteReader();

                if (r.Read()) customer = new Customer(id, r.GetString(1), r.GetDateTime(2), r.GetString(3));

                connection.Close();

                return customer;
            }
        }
    }
}
