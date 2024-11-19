using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicManagementDB_DataAccess
{
    public class clsDepartmentData
    {
        public static bool GetDepartmentByID(byte? DepartmentID, ref string DepartmentName, ref string DepartmentDescription, ref string DepartmentLocation)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Departments WHERE DepartmentID = @DepartmentID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DepartmentID", (object)DepartmentID ?? DBNull.Value);

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;


                                DepartmentName = (string)reader["DepartmentName"];
                                DepartmentDescription = (reader["DepartmentDescription"] != DBNull.Value) ? (string)reader["DepartmentDescription"] : null;
                                DepartmentLocation = (reader["DepartmentLocation"] != DBNull.Value) ? (string)reader["DepartmentLocation"] : null;
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
        public static bool GetDepartmentByDepartmentName(ref byte? DepartmentID, string DepartmentName, ref string DepartmentDescription, ref string DepartmentLocation)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Departments WHERE DepartmentName = @DepartmentName";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DepartmentName", (object)DepartmentName ?? DBNull.Value);

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;


                                DepartmentID = (byte?)reader["DepartmentID"];
                                DepartmentDescription = (reader["DepartmentDescription"] != DBNull.Value) ? (string)reader["DepartmentDescription"] : null;
                                DepartmentLocation = (reader["DepartmentLocation"] != DBNull.Value) ? (string)reader["DepartmentLocation"] : null;
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
        public static int AddNewDepartment(string DepartmentName, string DepartmentDescription, string DepartmentLocation)
        {
            int DepartmentID = -1;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO Departments (DepartmentName, DepartmentDescription, DepartmentLocation)
                            VALUES (@DepartmentName, @DepartmentDescription, @DepartmentLocation)
                            SELECT SCOPE_IDENTITY();";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@DepartmentName", DepartmentName);
                        command.Parameters.AddWithValue("@DepartmentDescription", (object)DepartmentDescription ?? DBNull.Value);
                        command.Parameters.AddWithValue("@DepartmentLocation", (object)DepartmentLocation ?? DBNull.Value);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if(result != null && int.TryParse(result.ToString(), out int insertedID))
                            DepartmentID = insertedID;
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return DepartmentID;
        }
        public static bool UpdateDepartment(byte? DepartmentID, string DepartmentName, string DepartmentDescription, string DepartmentLocation)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE Departments  
                            SET 
                            DepartmentName = @DepartmentName, 
                            DepartmentDescription = @DepartmentDescription, 
                            DepartmentLocation = @DepartmentLocation
                            WHERE DepartmentID = @DepartmentID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
                        command.Parameters.AddWithValue("@DepartmentName", DepartmentName);
                        command.Parameters.AddWithValue("@DepartmentDescription", (object)DepartmentDescription ?? DBNull.Value);
                        command.Parameters.AddWithValue("@DepartmentLocation", (object)DepartmentLocation ?? DBNull.Value);

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
        public static bool DeleteDepartment(byte? DepartmentID)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"Delete Departments 
                                where DepartmentID = @DepartmentID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DepartmentID", (object)DepartmentID ?? DBNull.Value);

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
        public static bool DoesDepartmentExist(byte? DepartmentID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT Found = 1 FROM Departments WHERE DepartmentID = @DepartmentID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DepartmentID", (object)DepartmentID ?? DBNull.Value);

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
        public static short TotalDoctorsByDepartmentID(byte? DepartmentID)
        {
            short TotalDoctors = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT COUNT(*) AS TotalDoctors FROM Doctors WHERE DepartmentID = @DepartmentID ";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DepartmentID", (object)DepartmentID ?? DBNull.Value);

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {


                                TotalDoctors = (short)reader["TotalDoctors"];
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
            }

            return TotalDoctors;
        }
        public static int TotalVisitsByDepartmentID(byte? DepartmentID)
        {
            int TotalVisits = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"SELECT COUNT(*) AS TotalVisits FROM Appointments 
INNER JOIN Doctors ON Appointments.DoctorID = Doctors.DoctorID
WHERE AppointmentStatus = 2 AND Doctors.DepartmentID = @DepartmentID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DepartmentID", (object)DepartmentID ?? DBNull.Value);

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {


                                TotalVisits = (int)reader["TotalVisits"];
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
            }

            return TotalVisits;
        }
        public static decimal TotalRevenueByDepartmentID(byte? DepartmentID)
        {
            decimal TotalRevenue = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"SELECT ISNULL(SUM(Payments.Amount),0) AS TotalRevenue FROM Appointments
INNER JOIN Payments ON Payments.PaymentID = Appointments.PaymentID
INNER JOIN Doctors ON Appointments.DoctorID = Doctors.DoctorID
WHERE Doctors.DepartmentID = @DepartmentID;";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DepartmentID", (object)DepartmentID ?? DBNull.Value);

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {


                                TotalRevenue = (decimal)reader["TotalRevenue"];
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
            }

            return TotalRevenue;
        }
        public static DataTable GetAllDepartments()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Departments";

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
