﻿using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using a2ssdqub.Models;

namespace a2ssdqub.DAL
{
    public class ReceiptDAL
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["konekt"].ConnectionString;

        public static List<Receipt> Get()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var list = new List<Receipt>();
                connection.Open();

                var cmd = new SqlCommand(@"
                    SELECT r.DateIssued, r.TotalDue, r.PaymentMethod, r.CusToBill, r.RecID,
                        c.Forename, c.DoB, c.Gender, c.CustID
                    FROM Receipts r 
                    INNER JOIN Customers c ON c.CustID = r.CusToBill 
                    ORDER BY r.RecId;", 
                connection);

                var r = cmd.ExecuteReader();

                while (r.Read())
                {
                    var c = new Customer(r.GetInt32(8), r.GetString(5), r.GetDateTime(6), r.GetString(7));
                    var q = new Receipt(r.GetDateTime(0), r.GetDecimal(1), r.GetString(2), true, r.GetInt32(4), c);

                    list.Add(q);
                }

                connection.Close();
                return list;
            }
        }

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