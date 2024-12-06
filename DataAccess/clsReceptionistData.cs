using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicManagementDB_DataAccess
{
    public class clsReceptionistData
    {
        public static bool GetReceptionistByID(short? ReceptionistID, ref int PersonID, ref DateTime HireDate, ref DateTime? EndDate, ref byte ReceptionistStatus, ref short ReceptionistUserID, ref short CreatedByUserID, ref DateTime CreatedAt, ref short? UpdatedByUserID, ref DateTime? UpdatedAt)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Receptionists WHERE ReceptionistID = @ReceptionistID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReceptionistID", (object)ReceptionistID ?? DBNull.Value);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;


                                PersonID = (int)reader["PersonID"];
                                HireDate = (DateTime)reader["HireDate"];
                                EndDate = (reader["EndDate"] != DBNull.Value) ? (DateTime?)reader["EndDate"] : null;
                                ReceptionistStatus = (byte)reader["ReceptionistStatus"];
                                ReceptionistUserID = (short)reader["ReceptionistUserID"];
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
        public static int AddNewReceptionist(int PersonID, DateTime HireDate, DateTime? EndDate, byte ReceptionistStatus, short ReceptionistUserID, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            int ReceptionistID = -1;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO Receptionists (PersonID, HireDate, EndDate, ReceptionistStatus, ReceptionistUserID, CreatedByUserID, CreatedAt, UpdatedByUserID, UpdatedAt)
                            VALUES (@PersonID, @HireDate, @EndDate, @ReceptionistStatus, @ReceptionistUserID, @CreatedByUserID, @CreatedAt, @UpdatedByUserID, @UpdatedAt)
                            SELECT SCOPE_IDENTITY();";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@HireDate", HireDate);
                        command.Parameters.AddWithValue("@EndDate", (object)EndDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ReceptionistStatus", ReceptionistStatus);
                        command.Parameters.AddWithValue("@ReceptionistUserID", ReceptionistUserID);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedByUserID", (object)UpdatedByUserID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedAt", (object)UpdatedAt ?? DBNull.Value);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if(result != null && int.TryParse(result.ToString(), out int insertedID))
                            ReceptionistID = insertedID;
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return ReceptionistID;
        }
        public static bool UpdateReceptionist(short? ReceptionistID, int PersonID, DateTime HireDate, DateTime? EndDate, byte ReceptionistStatus, short ReceptionistUserID, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE Receptionists  
                            SET 
                            PersonID = @PersonID, 
                            HireDate = @HireDate, 
                            EndDate = @EndDate, 
                            ReceptionistStatus = @ReceptionistStatus, 
                            ReceptionistUserID = @ReceptionistUserID, 
                            CreatedByUserID = @CreatedByUserID, 
                            CreatedAt = @CreatedAt, 
                            UpdatedByUserID = @UpdatedByUserID, 
                            UpdatedAt = @UpdatedAt
                            WHERE ReceptionistID = @ReceptionistID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@ReceptionistID", ReceptionistID);
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@HireDate", HireDate);
                        command.Parameters.AddWithValue("@EndDate", (object)EndDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ReceptionistStatus", ReceptionistStatus);
                        command.Parameters.AddWithValue("@ReceptionistUserID", ReceptionistUserID);
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
        public static bool DeleteReceptionist(short? ReceptionistID)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"Delete Receptionists 
                                where ReceptionistID = @ReceptionistID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReceptionistID", (object)ReceptionistID ?? DBNull.Value);

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
        public static bool DoesReceptionistExist(short? ReceptionistID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT Found = 1 FROM Receptionists WHERE ReceptionistID = @ReceptionistID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReceptionistID", (object)ReceptionistID  ?? DBNull.Value);

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
        public static int? GetPersonID(short? ReceptionistID)
        {
            int? PersonID = null;
            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT PersonID FROM Receptionists WHERE ReceptionistID = @ReceptionistID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReceptionistID", (object)ReceptionistID ?? DBNull.Value);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if(reader.Read())
                        {
                            PersonID = (int?)reader["PersonID"];
                        }
                    }
                }
            }
            catch(Exception ex)
            {
            }

            return PersonID;
        }
        public static bool DoesReceptionistExistByPersonID(int? PersonID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT Found = 1 FROM Receptionist WHERE PersonID = @PersonID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);

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
        public static bool DoesUsernameUsedByAnotherReceptionist(short? ReceptionistID, string Username)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"      DECLARE @TempReceptionistID INT;
    SET @TempReceptionistID = @ReceptionistID;
	IF (@TempReceptionistID IS NULL)
	BEGIN
		SELECT Found = 1 FROM Receptionists 
		INNER JOIN Users ON Users.UserID = Receptionists.ReceptionistUserID
		WHERE Username = @Username
	END
	ELSE 
	BEGIN
		SELECT Found = 1 
		FROM Receptionists 
		INNER JOIN Users ON Users.UserID = Receptionists.ReceptionistUserID
		WHERE ReceptionistID <> @TempReceptionistID AND Username = @Username;
	END";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReceptionistID", (object)ReceptionistID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Username", Username);

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

        public static DataTable GetAllReceptionists()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"			
            SELECT ReceptionistID, People.Firstname + ' ' + People.Lastname AS Fullname,
			HireDate, CASE 
			WHEN EndDate IS NULL THEN 'Ongoing'
			ELSE CAST(EndDate AS VARCHAR)
			END AS EndDate, 
			CASE 
			WHEN ReceptionistStatus = 1 THEN 'Active'
			WHEN ReceptionistStatus = 2 THEN 'On Leave'
			WHEN ReceptionistStatus = 3 THEN 'Resigned'
			WHEN ReceptionistStatus = 4 THEN 'Terminated'
			ELSE  'Not Known'
			END AS Status, 
			Users.Username AS ReceptionistUser
			FROM Receptionists
			INNER JOIN People ON People.PersonID = Receptionists.PersonID
			INNER JOIN Users ON Users.UserID = Receptionists.ReceptionistUserID";

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
