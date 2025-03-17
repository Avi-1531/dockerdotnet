using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicManagementDB_DataAccess
{
    public class clsPaymentData
    {
        public static bool GetPaymentByID(int? PaymentID, ref decimal Amount, ref byte PaymentMethod, ref DateTime PaymentDate, ref short CreatedByUserID, ref DateTime CreatedAt)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetPaymentByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PaymentID", (object)PaymentID ?? DBNull.Value);

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;


                                Amount = (decimal)reader["Amount"];
                                PaymentMethod = (byte)reader["PaymentMethod"];
                                PaymentDate = (DateTime)reader["PaymentDate"];
                                CreatedByUserID = (short)reader["CreatedByUserID"];
                                CreatedAt = (DateTime)reader["CreatedAt"];
                            }
                            else
                                isFound = false;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                isFound = false;
            }

            return isFound;
        }
        public static int AddNewPayment(decimal Amount, byte PaymentMethod, DateTime PaymentDate, short CreatedByUserID, DateTime CreatedAt)
        {
            int PaymentID = -1;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("AddNewPayment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Amount", Amount);
                        command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                        command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if(result != null && int.TryParse(result.ToString(), out int insertedID))
                            PaymentID = insertedID;
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return PaymentID;
        }
        public static decimal GetTotalPaymentsAmount()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetTotalPaymentsAmount", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {

                                return (decimal)reader["TotalPaymentsAmount"];
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
            }

            return 0;
        }
        public static decimal GetAverageAmountPerPayment()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetAverageAmountPerPayment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {

                                return (decimal)reader["AverageAmountPerPayment"];
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
            }

            return 0;
        }
        public static int GetTotalPayments()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetTotalPayments", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {

                                return (int)reader["TotalPayments"];
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
            }

            return 0;
        }
        public static string GetMostUsedPaymentMethod()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetMostUsedPaymentMethod", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {

                                return (string)reader["MostUsedPaymentMethod"];
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
            }

            return "Not Known";
        }

        public static bool DoesPaymentExist(int? PaymentID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("DoesPaymentExist", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PaymentID", (object)PaymentID ?? DBNull.Value);

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

        public static DataTable GetAllPayments(short PageNumber, int PageSize, ref int Records)
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using(SqlCommand command = new SqlCommand("GetAllPayments", connection))
                    {
                        command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        command.Parameters.AddWithValue("@PageSize", PageSize);

                        command.CommandType = CommandType.StoredProcedure;

                        var recordsParam = command.Parameters.Add("@Records", SqlDbType.Int);
                        recordsParam.Direction = ParameterDirection.Output;

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if(reader.HasRows)
                            dt.Load(reader);
                        else
                            return dt;

                        Records = recordsParam.Value != DBNull.Value ? (int)recordsParam.Value : 0;
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
