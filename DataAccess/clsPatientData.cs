using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicManagementDB_DataAccess
{
    public class clsPatientData
    {
        public static bool GetPatientByID(int? PatientID, ref int PersonID, ref string? BloodType, ref string? Allergies, ref string? MedicalHistory, ref string? EmergencyContactName, ref string? EmergencyContactPhone, ref short CreatedByUserID, ref DateTime CreatedAt, ref short? UpdatedByUserID, ref DateTime? UpdatedAt)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Patients WHERE PatientID = @PatientID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PatientID", (object)PatientID ?? DBNull.Value);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;


                                PersonID = (int)reader["PersonID"];
                                BloodType = (reader["BloodType"] != DBNull.Value) ? (string?)reader["BloodType"] : null;
                                Allergies = (reader["Allergies"] != DBNull.Value) ? (string?)reader["Allergies"] : null;
                                MedicalHistory = (reader["MedicalHistory"] != DBNull.Value) ? (string?)reader["MedicalHistory"] : null;
                                EmergencyContactName = (reader["EmergencyContactName"] != DBNull.Value) ? (string?)reader["EmergencyContactName"] : null;
                                EmergencyContactPhone = (reader["EmergencyContactPhone"] != DBNull.Value) ? (string?)reader["EmergencyContactPhone"] : null;
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
            catch (Exception ex)
            {
                isFound = false;
            }

            return isFound;
        }
        public static int AddNewPatient(int PersonID, string? BloodType, string? Allergies, string? MedicalHistory, string? EmergencyContactName, string? EmergencyContactPhone, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            int PatientID = -1;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO Patients (PersonID, BloodType, Allergies, MedicalHistory, EmergencyContactName, EmergencyContactPhone, CreatedByUserID, CreatedAt, UpdatedByUserID, UpdatedAt)
                            VALUES (@PersonID, @BloodType, @Allergies, @MedicalHistory, @EmergencyContactName, @EmergencyContactPhone, @CreatedByUserID, @CreatedAt, @UpdatedByUserID, @UpdatedAt)
                            SELECT SCOPE_IDENTITY();";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@BloodType", (object)BloodType ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Allergies", (object)Allergies ?? DBNull.Value);
                        command.Parameters.AddWithValue("@MedicalHistory", (object)MedicalHistory ?? DBNull.Value);
                        command.Parameters.AddWithValue("@EmergencyContactName", (object)EmergencyContactName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@EmergencyContactPhone", (object)EmergencyContactPhone ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedByUserID", (object)UpdatedByUserID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedAt", (object)UpdatedAt ?? DBNull.Value);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if(result != null && int.TryParse(result.ToString(), out int insertedID))
                            PatientID = insertedID;
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return PatientID;
        }
        public static bool UpdatePatient(int? PatientID, int PersonID, string? BloodType, string? Allergies, string? MedicalHistory, string? EmergencyContactName, string? EmergencyContactPhone, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE Patients  
                            SET 
                            PersonID = @PersonID, 
                            BloodType = @BloodType, 
                            Allergies = @Allergies, 
                            MedicalHistory = @MedicalHistory, 
                            EmergencyContactName = @EmergencyContactName, 
                            EmergencyContactPhone = @EmergencyContactPhone, 
                            CreatedByUserID = @CreatedByUserID, 
                            CreatedAt = @CreatedAt, 
                            UpdatedByUserID = @UpdatedByUserID, 
                            UpdatedAt = @UpdatedAt
                            WHERE PatientID = @PatientID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PatientID", PatientID);
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@BloodType", (object)BloodType ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Allergies", (object)Allergies ?? DBNull.Value);
                        command.Parameters.AddWithValue("@MedicalHistory", (object)MedicalHistory ?? DBNull.Value);
                        command.Parameters.AddWithValue("@EmergencyContactName", (object)EmergencyContactName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@EmergencyContactPhone", (object)EmergencyContactPhone ?? DBNull.Value);
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
        public static bool DeletePatient(int? PatientID)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"Delete Patients 
                                where PatientID = @PatientID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PatientID", (object)PatientID ?? DBNull.Value);

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
        public static bool DoesPatientExist(int? PatientID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT Found = 1 FROM Patients WHERE PatientID = @PatientID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PatientID", (object)PatientID  ?? DBNull.Value);

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
        public static DataTable GetAllPatients()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Patients";

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
