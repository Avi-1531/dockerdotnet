using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicManagementDB_DataAccess
{
    public class clsDoctorData
    {
        public static bool GetDoctorByID(short? DoctorID, ref int PersonID, ref byte DepartmentID, ref string LicenseNumber, ref string Specialization, ref byte YearsOfExperience, ref DateTime HireDate, ref DateTime? EndDate, ref byte DoctorStatus, ref decimal? ConsultationFee, ref short DoctorUserID, ref short CreatedByUserID, ref DateTime CreatedAt, ref short? UpdatedByUserID, ref DateTime? UpdatedAt)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Doctors WHERE DoctorID = @DoctorID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DoctorID", (object)DoctorID ?? DBNull.Value);

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;


                                PersonID = (int)reader["PersonID"];
                                DepartmentID = (byte)reader["DepartmentID"];
                                LicenseNumber = (string)reader["LicenseNumber"];
                                Specialization = (string)reader["Specialization"];
                                YearsOfExperience = (byte)reader["YearsOfExperience"];
                                HireDate = (DateTime)reader["HireDate"];
                                EndDate = (reader["EndDate"] != DBNull.Value) ? (DateTime?)reader["EndDate"] : null;
                                DoctorStatus = (byte)reader["DoctorStatus"];
                                ConsultationFee = (reader["ConsultationFee"] != DBNull.Value) ? (decimal?)reader["ConsultationFee"] : null;
                                DoctorUserID = (short)reader["DoctorUserID"];
                                CreatedByUserID = (short)reader["CreatedByUserID"];
                                CreatedAt = (DateTime)reader["CreatedAt"];
                                UpdatedByUserID = (reader["UpdatedByUserID"] != DBNull.Value) ? (short?)reader["UpdatedByUserID"] : null;
                                UpdatedAt = (reader["UpdatedAt"] != DBNull.Value) ? (DateTime?)reader["UpdatedAt"] : null;
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
        public static int AddNewDoctor(int PersonID, byte DepartmentID, string LicenseNumber, string Specialization, byte YearsOfExperience, DateTime HireDate, DateTime? EndDate, byte DoctorStatus, decimal? ConsultationFee, short DoctorUserID, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            int DoctorID = -1;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO Doctors (PersonID, DepartmentID, LicenseNumber, Specialization, YearsOfExperience, HireDate, EndDate, DoctorStatus, ConsultationFee, DoctorUserID, CreatedByUserID, CreatedAt, UpdatedByUserID, UpdatedAt)
                            VALUES (@PersonID, @DepartmentID, @LicenseNumber, @Specialization, @YearsOfExperience, @HireDate, @EndDate, @DoctorStatus, @ConsultationFee, @DoctorUserID, @CreatedByUserID, @CreatedAt, @UpdatedByUserID, @UpdatedAt)
                            SELECT SCOPE_IDENTITY();";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
                        command.Parameters.AddWithValue("@LicenseNumber", LicenseNumber);
                        command.Parameters.AddWithValue("@Specialization", Specialization);
                        command.Parameters.AddWithValue("@YearsOfExperience", YearsOfExperience);
                        command.Parameters.AddWithValue("@HireDate", HireDate);
                        command.Parameters.AddWithValue("@EndDate", (object)EndDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@DoctorStatus", DoctorStatus);
                        command.Parameters.AddWithValue("@ConsultationFee", (object)ConsultationFee ?? DBNull.Value);
                        command.Parameters.AddWithValue("@DoctorUserID", DoctorUserID);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedByUserID", (object)UpdatedByUserID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedAt", (object)UpdatedAt ?? DBNull.Value);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if(result != null && int.TryParse(result.ToString(), out int insertedID))
                            DoctorID = insertedID;
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return DoctorID;
        }
        public static bool UpdateDoctor(short? DoctorID, int PersonID, byte DepartmentID, string LicenseNumber, string Specialization, byte YearsOfExperience, DateTime HireDate, DateTime? EndDate, byte DoctorStatus, decimal? ConsultationFee, short DoctorUserID, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE Doctors  
                            SET 
                            PersonID = @PersonID, 
                            DepartmentID = @DepartmentID, 
                            LicenseNumber = @LicenseNumber, 
                            Specialization = @Specialization, 
                            YearsOfExperience = @YearsOfExperience, 
                            HireDate = @HireDate, 
                            EndDate = @EndDate, 
                            DoctorStatus = @DoctorStatus, 
                            ConsultationFee = @ConsultationFee, 
                            DoctorUserID = @DoctorUserID, 
                            CreatedByUserID = @CreatedByUserID, 
                            CreatedAt = @CreatedAt, 
                            UpdatedByUserID = @UpdatedByUserID, 
                            UpdatedAt = @UpdatedAt
                            WHERE DoctorID = @DoctorID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
                        command.Parameters.AddWithValue("@LicenseNumber", LicenseNumber);
                        command.Parameters.AddWithValue("@Specialization", Specialization);
                        command.Parameters.AddWithValue("@YearsOfExperience", YearsOfExperience);
                        command.Parameters.AddWithValue("@HireDate", HireDate);
                        command.Parameters.AddWithValue("@EndDate", (object)EndDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@DoctorStatus", DoctorStatus);
                        command.Parameters.AddWithValue("@ConsultationFee", (object)ConsultationFee ?? DBNull.Value);
                        command.Parameters.AddWithValue("@DoctorUserID", DoctorUserID);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedByUserID", (object)UpdatedByUserID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedAt", (object)UpdatedAt ?? DBNull.Value);

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
        public static bool DeleteDoctor(short? DoctorID)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"Delete Doctors 
                                where DoctorID = @DoctorID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DoctorID", (object)DoctorID ?? DBNull.Value);

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
        public static bool DoesDoctorExist(short? DoctorID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT Found = 1 FROM Doctors WHERE DoctorID = @DoctorID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DoctorID", (object)DoctorID ?? DBNull.Value);

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
        public static DataTable GetAllDoctors()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"SELECT DoctorID, CONCAT(People.FirstName, ' ', People.LastName) AS FullName,
  Departments.DepartmentName, LicenseNumber, Specialization,
  YearsOfExperience, HireDate, 
CASE 
    WHEN EndDate IS NULL THEN 'Ongoing'
    ELSE CAST(EndDate AS VARCHAR)
END AS EndDate,
  CASE
	WHEN DoctorStatus = 1 THEN 'Active'
	WHEN DoctorStatus = 2 THEN 'On Leave'
	WHEN DoctorStatus = 3 THEN 'Resigned'
	WHEN DoctorStatus = 4 THEN 'Retired'
	WHEN DoctorStatus = 5 THEN 'Terminated'
  END AS Status,
  FORMAT(ConsultationFee, 'C', 'en-US') AS ConsultationFees
  FROM Doctors
  INNER JOIN People ON People.PersonID = Doctors.PersonID
  INNER JOIN Departments ON Departments.DepartmentID = Doctors.DepartmentID";

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
