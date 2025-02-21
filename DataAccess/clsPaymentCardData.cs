using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicManagementDB_DataAccess
{
    public class clsPaymentCardData
    {
        public static bool GetPaymentCardByID(int? PaymentCardID, ref string CardNumber, ref string CardHolderName, ref DateTime ExpiryDate, ref short CreatedByUserID, ref DateTime CreatedAt)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM PaymentCards WHERE PaymentCardID = @PaymentCardID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentCardID", (object)PaymentCardID ?? DBNull.Value);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;


                                CardNumber = (string)reader["CardNumber"];
                                CardHolderName = (string)reader["CardHolderName"];
                                ExpiryDate = (DateTime)reader["ExpiryDate"];
                                CreatedByUserID = (short)reader["CreatedByUserID"];
                                CreatedAt = (DateTime)reader["CreatedAt"];
                            }
                            else
                                isFound = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }

            return isFound;
        }
        public static int AddNewPaymentCard(string CardNumber, string CardHolderName, DateTime ExpiryDate, short CreatedByUserID, DateTime CreatedAt)
        {
            int PaymentCardID = -1;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO PaymentCards (CardNumber, CardHolderName, ExpiryDate, CreatedByUserID, CreatedAt)
                            VALUES (@CardNumber, @CardHolderName, @ExpiryDate, @CreatedByUserID, @CreatedAt)
                            SELECT SCOPE_IDENTITY();";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@CardNumber", CardNumber);
                        command.Parameters.AddWithValue("@CardHolderName", CardHolderName);
                        command.Parameters.AddWithValue("@ExpiryDate", ExpiryDate);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if(result != null && int.TryParse(result.ToString(), out int insertedID))
                            PaymentCardID = insertedID;
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return PaymentCardID;
        }
        public static bool UpdatePaymentCard(int? PaymentCardID, string CardNumber, string CardHolderName, DateTime ExpiryDate, short CreatedByUserID, DateTime CreatedAt)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE PaymentCards  
                            SET 
                            CardNumber = @CardNumber, 
                            CardHolderName = @CardHolderName, 
                            ExpiryDate = @ExpiryDate, 
                            CreatedByUserID = @CreatedByUserID, 
                            CreatedAt = @CreatedAt
                            WHERE PaymentCardID = @PaymentCardID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PaymentCardID", PaymentCardID);
                        command.Parameters.AddWithValue("@CardNumber", CardNumber);
                        command.Parameters.AddWithValue("@CardHolderName", CardHolderName);
                        command.Parameters.AddWithValue("@ExpiryDate", ExpiryDate);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                return false;
            }

            return (rowsAffected > 0);
        }
        public static bool DeletePaymentCard(int? PaymentCardID)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"Delete PaymentCards 
                                where PaymentCardID = @PaymentCardID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentCardID", (object)PaymentCardID ?? DBNull.Value);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }

            }
            catch(Exception ex)
            {

            }

            return (rowsAffected > 0);
        }
        public static bool DoesPaymentCardExist(int? PaymentCardID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT Found = 1 FROM PaymentCards WHERE PaymentCardID = @PaymentCardID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentCardID", (object)PaymentCardID  ?? DBNull.Value);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        isFound = reader.HasRows;
                    }
                }
            }
            catch(Exception ex)
            {
                isFound = false;
            }

            return isFound;
        }
        public static DataTable GetAllPaymentCards()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM PaymentCards";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if(reader.HasRows)
                            dt.Load(reader);
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return dt;
        }
    }
}
