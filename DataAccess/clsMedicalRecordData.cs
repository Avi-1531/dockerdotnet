using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicManagementDB_DataAccess
{
    public class clsMedicalRecordData
    {
        public static bool GetMedicalRecordByID(int? MedicalRecordID, ref string Diagnosis, ref string Prescription, ref string Notes, ref int AppointmentID, ref short CreatedByUserID, ref DateTime CreatedAt)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM MedicalRecords WHERE MedicalRecordID = @MedicalRecordID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MedicalRecordID", (object)MedicalRecordID ?? DBNull.Value);

                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;


                                Diagnosis = (string)reader["Diagnosis"];
                                Prescription = (reader["Prescription"] != DBNull.Value) ? (string)reader["Prescription"] : null;
                                Notes = (reader["Notes"] != DBNull.Value) ? (string)reader["Notes"] : null;
                                AppointmentID = (int)reader["AppointmentID"];
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
        public static int AddNewMedicalRecord(string Diagnosis, string Prescription, string Notes,int AppointmentID, short CreatedByUserID, DateTime CreatedAt)
        {
            int MedicalRecordID = -1;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO MedicalRecords (Diagnosis, Prescription, Notes, CreatedByUserID, CreatedAt)
                            VALUES (@Diagnosis, @Prescription, @Notes, @CreatedByUserID, @CreatedAt)
                            SELECT SCOPE_IDENTITY();";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Diagnosis", Diagnosis);
                        command.Parameters.AddWithValue("@Prescription", (object)Prescription ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Notes", (object)Notes ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if(result != null && int.TryParse(result.ToString(), out int insertedID))
                            MedicalRecordID = insertedID;
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return MedicalRecordID;
        }
        public static bool UpdateMedicalRecord(int? MedicalRecordID, string Diagnosis, string Prescription, string Notes, int AppointmentID, short CreatedByUserID, DateTime CreatedAt)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE MedicalRecords  
                            SET 
                            Diagnosis = @Diagnosis, 
                            Prescription = @Prescription, 
                            Notes = @Notes, 
                            CreatedByUserID = @CreatedByUserID, 
                            CreatedAt = @CreatedAt
                            WHERE MedicalRecordID = @MedicalRecordID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
                        command.Parameters.AddWithValue("@Diagnosis", Diagnosis);
                        command.Parameters.AddWithValue("@Prescription", (object)Prescription ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Notes", (object)Notes ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
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
        public static bool DeleteMedicalRecord(int? MedicalRecordID)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"Delete MedicalRecords 
                                where MedicalRecordID = @MedicalRecordID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MedicalRecordID", (object)MedicalRecordID ?? DBNull.Value);

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
        public static bool DoesMedicalRecordExist(int? MedicalRecordID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT Found = 1 FROM MedicalRecords WHERE MedicalRecordID = @MedicalRecordID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MedicalRecordID", (object)MedicalRecordID ?? DBNull.Value);

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
        public static DataTable GetPatientMedicalRecords(int PatientID)
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("GetPatientMedicalRecords", connection))
                    {
                        command.Parameters.AddWithValue("@PatientID", PatientID);
                        command.CommandType = CommandType.StoredProcedure;
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
