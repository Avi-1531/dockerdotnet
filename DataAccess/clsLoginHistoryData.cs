using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicManagementDB_DataAccess
{
    public class clsLoginHistoryData
    {
        public static bool GetLoginHistoryByID(int? LoginHistoryID, ref short UserID, ref DateTime LoginTime, ref DateTime? LogoutTime)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM LoginHistory WHERE LoginHistoryID = @LoginHistoryID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LoginHistoryID", (object)LoginHistoryID ?? DBNull.Value);

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;


                                UserID = (short)reader["UserID"];
                                LoginTime = (DateTime)reader["LoginTime"];
                                LogoutTime = (reader["LogoutTime"] != DBNull.Value) ? (DateTime?)reader["LogoutTime"] : null;
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
        public static int AddNewLoginHistory(short UserID, DateTime LoginTime, DateTime? LogoutTime)
        {
            int LoginHistoryID = -1;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO LoginHistory (UserID, LoginTime, LogoutTime)
                            VALUES (@UserID, @LoginTime, @LogoutTime)
                            SELECT SCOPE_IDENTITY();";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@LoginTime", LoginTime);
                        command.Parameters.AddWithValue("@LogoutTime", (object)LogoutTime ?? DBNull.Value);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if(result != null && int.TryParse(result.ToString(), out int insertedID))
                            LoginHistoryID = insertedID;
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return LoginHistoryID;
        }
        public static bool UpdateLoginHistory(int? LoginHistoryID, short UserID, DateTime LoginTime, DateTime? LogoutTime)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE LoginHistory  
                            SET 
                            UserID = @UserID, 
                            LoginTime = @LoginTime, 
                            LogoutTime = @LogoutTime
                            WHERE LoginHistoryID = @LoginHistoryID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@LoginHistoryID", LoginHistoryID);
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@LoginTime", LoginTime);
                        command.Parameters.AddWithValue("@LogoutTime", (object)LogoutTime ?? DBNull.Value);

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
        public static bool DeleteLoginHistory(int? LoginHistoryID)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"Delete LoginHistory 
                                where LoginHistoryID = @LoginHistoryID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LoginHistoryID", (object)LoginHistoryID ?? DBNull.Value);

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
        public static bool DoesLoginHistoryExist(int? LoginHistoryID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT Found = 1 FROM LoginHistory WHERE LoginHistoryID = @LoginHistoryID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LoginHistoryID", (object)LoginHistoryID ?? DBNull.Value);

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
        public static DataTable GetAllLoginHistory()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM LoginHistory";

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
