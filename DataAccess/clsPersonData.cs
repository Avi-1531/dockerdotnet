using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicManagementDB_DataAccess
{
    public class clsPersonData
    {
        public static bool GetPersonByID(int? PersonID, ref string FirstName, ref string SecondName, ref string? ThirdName, ref string LastName, ref string NationalID, ref DateTime BirthDate, ref bool Gender, ref string? Address, ref string Phone, ref string Email, ref byte CountryID, ref short CreatedByUserID, ref DateTime CreatedAt, ref short? UpdatedByUserID, ref DateTime? UpdatedAt)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM People WHERE PersonID = @PersonID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;


                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];
                                ThirdName = (reader["ThirdName"] != DBNull.Value) ? (string?)reader["ThirdName"] : null;
                                LastName = (string)reader["LastName"];
                                NationalID = (string)reader["NationalID"];
                                BirthDate = (DateTime)reader["BirthDate"];
                                Gender = (bool)reader["Gender"];
                                Address = (reader["Address"] != DBNull.Value) ? (string?)reader["Address"] : null;
                                Phone = (string)reader["Phone"];
                                Email = (string)reader["Email"];
                                CountryID = (byte)reader["CountryID"];
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
        public static int AddNewPerson(string FirstName, string SecondName, string? ThirdName, string LastName, string NationalID, DateTime BirthDate, bool Gender, string? Address, string Phone, string Email, byte CountryID, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            int PersonID = -1;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO People (FirstName, SecondName, ThirdName, LastName, NationalID, BirthDate, Gender, Address, Phone, Email, CountryID, CreatedByUserID, UpdatedByUserID, UpdatedAt)
                            VALUES (@FirstName, @SecondName, @ThirdName, @LastName, @NationalID, @BirthDate, @Gender, @Address, @Phone, @Email, @CountryID, @CreatedByUserID, @UpdatedByUserID, @UpdatedAt)
                            SELECT SCOPE_IDENTITY();";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);
                        command.Parameters.AddWithValue("@ThirdName", (object)ThirdName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@NationalID", NationalID);
                        command.Parameters.AddWithValue("@BirthDate", BirthDate);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@Address", (object)Address ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@CountryID", CountryID);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@UpdatedByUserID", (object)UpdatedByUserID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedAt", (object)UpdatedAt ?? DBNull.Value);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if(result != null && int.TryParse(result.ToString(), out int insertedID))
                            PersonID = insertedID;
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return PersonID;
        }
        public static bool UpdatePerson(int? PersonID, string FirstName, string SecondName, string? ThirdName, string LastName, string NationalID, DateTime BirthDate, bool Gender, string? Address, string Phone, string Email, byte CountryID, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE People  
                            SET 
                            FirstName = @FirstName, 
                            SecondName = @SecondName, 
                            ThirdName = @ThirdName, 
                            LastName = @LastName, 
                            NationalID = @NationalID, 
                            BirthDate = @BirthDate, 
                            Gender = @Gender, 
                            Address = @Address, 
                            Phone = @Phone, 
                            Email = @Email, 
                            CountryID = @CountryID, 
                            CreatedByUserID = @CreatedByUserID, 
                            CreatedAt = @CreatedAt, 
                            UpdatedByUserID = @UpdatedByUserID, 
                            UpdatedAt = @UpdatedAt
                            WHERE PersonID = @PersonID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);
                        command.Parameters.AddWithValue("@ThirdName", (object)ThirdName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@NationalID", NationalID);
                        command.Parameters.AddWithValue("@BirthDate", BirthDate);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@Address", (object)Address ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@CountryID", CountryID);
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
        public static bool DeletePerson(int? PersonID)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"Delete People 
                                where PersonID = @PersonID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);

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
        public static bool DoesPersonExist(int? PersonID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT Found = 1 FROM People WHERE PersonID = @PersonID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", (object)PersonID  ?? DBNull.Value);

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
        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"USE ClinicManagementDB;
SELECT People.PersonID, 
	  People.FirstName + ' ' + People.SecondName + ' ' + 
	  CASE 
	  WHEN People.ThirdName is NULL THEN ''
	  WHEN People.ThirdName is NOT NULL THEN People.ThirdName + ' '
	  END
	  + People.LastName AS FullName, 
	  People.NationalID, People.BirthDate, 
	  CASE 
	  WHEN People.Gender = 0 THEN 'Male'
	  WHEN People.Gender = 1 THEN 'Female'
	  END AS Gender,
      People.Phone, People.Email, Countries.CountryName, Users.Username AS CreatedBy
	  FROM People 
  INNER JOIN Countries ON People.CountryID = Countries.CountryID
  INNER JOIN Users ON People.CreatedByUserID = Users.UserID
  ORDER BY People.CreatedAt DESC;";

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
