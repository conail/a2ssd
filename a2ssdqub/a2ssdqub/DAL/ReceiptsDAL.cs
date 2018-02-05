using System.Configuration;
using System.Data.SqlClient;
using a2ssdqub.Models;

namespace a2ssdqub.DAL
{
    public class ReceiptsDAL
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["konekt"].ConnectionString;

        public static int? Add(Receipt r)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var query = string.Format(@"
                    INSERT INTO RECEIPTS 
                    OUTPUT INSERTED.RecID 
                    VALUES('{0}','{1}','{2}','{3}');", 
                    r.IssueDate, r.Charged, r.Total, r.PaymentMethod
                );
                var command = new SqlCommand(query, connection);

                // get the result from the OUTPUT command in the SQL query
                var id = (int?) command.ExecuteScalar(); 

                connection.Close();

                return id;
            }
        }

        public static bool Update(Receipt r)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
            
                var query = string.Format(@"
                    UPDATE Receipts 
                    SET DateIssued = '{0}', CusToBill = '{1}', TotalDue = '{2}', PaymentMethod = '{3}' 
                    WHERE RecID = '{4}';", 
                    r.IssueDate, r.Charged, r.Total, r.PaymentMethod, 
                    r.Id
                );
                var command = new SqlCommand(query, connection);

                int rowsAffected = command.ExecuteNonQuery();

                connection.Close();

                return rowsAffected == 1;
            }
        }

        public static bool Delete(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = string.Format(@"
                    DELETE FROM Receipts
                    WHERE RecID = {0}", 
                    id
                );

                var command = new SqlCommand(query, connection);

                int rowsAffected = command.ExecuteNonQuery();

                connection.Close();

                return rowsAffected == 1;
            }
        }
    }
}