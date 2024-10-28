using System;
using System.Data;
using ClinicManagementDB_DataAccess;

namespace ClinicManagementDB_Business
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public short? UserID { set; get; }
        public int PersonID { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public byte Role { set; get; }
        public bool IsActive { set; get; }
        public DateTime? LastLoginAt { set; get; }
        public short CreatedByUserID { set; get; }
        public DateTime CreatedAt { set; get; }
        public short? UpdatedByUserID { set; get; }
        public DateTime? UpdatedAt { set; get; }
        public clsPerson Person { set; get; }
        public string IsActiveString
        {
            get
            {
                switch(this.IsActive)
                {
                    case false:
                        return "No";
                    default:
                        return "Yes";
                }
            }
        }
        public string RoleString
        {
            get
            {
                switch(this.Role)
                {
                    case 1:
                        return "Admin";
                    case 2:
                        return "Doctor";
                    case 3:
                        return "Receptionist";
                    default:
                        return "Not Known";
                }
            }
        }
        public clsUser()
        {
            this.UserID = null;
            this.PersonID = -1;
            this.Username = "";
            this.Password = "";
            this.Role = 0;
            this.IsActive = false;
            this.LastLoginAt = null;
            this.CreatedByUserID = -1;
            this.CreatedAt = DateTime.MinValue;
            this.UpdatedByUserID = null;
            this.UpdatedAt = null;
            this.Person = new clsPerson();
            Mode = enMode.AddNew;
        }
        private clsUser(short? UserID, int PersonID, string Username, string Password, byte Role, bool IsActive, DateTime? LastLoginAt, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.Username = Username;
            this.Password = Password;
            this.Role = Role;
            this.IsActive = IsActive;
            this.LastLoginAt = LastLoginAt;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedAt = CreatedAt;
            this.UpdatedByUserID = UpdatedByUserID;
            this.UpdatedAt = UpdatedAt;
            this.Person = clsPerson.Find(this.PersonID);
            Mode = enMode.Update;
        }
        private bool _AddNewUser()
        {
            this.UserID = (short?)clsUserData.AddNewUser(this.PersonID, this.Username, this.Password, this.Role, this.IsActive, this.LastLoginAt, this.CreatedByUserID, this.CreatedAt, this.UpdatedByUserID, this.UpdatedAt);
            return (this.UserID != -1);
        }
        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID, this.PersonID, this.Username, this.Password, this.Role, this.IsActive, this.LastLoginAt, this.CreatedByUserID, this.CreatedAt, this.UpdatedByUserID, this.UpdatedAt);
        }
        public static clsUser Find(short? UserID)
        {
            int PersonID = -1;
            string Username = "";
            string Password = "";
            byte Role = 0;
            bool IsActive = false;
            DateTime? LastLoginAt = null;
            short CreatedByUserID = -1;
            DateTime CreatedAt = DateTime.MinValue;
            short? UpdatedByUserID = null;
            DateTime? UpdatedAt = null;

            bool IsFound = clsUserData.GetUserByID(UserID, ref PersonID, ref Username, ref Password, ref Role, ref IsActive, ref LastLoginAt, ref CreatedByUserID, ref CreatedAt, ref UpdatedByUserID, ref UpdatedAt);

            if(IsFound)
                return new clsUser(UserID, PersonID, Username, Password, Role, IsActive, LastLoginAt, CreatedByUserID, CreatedAt, UpdatedByUserID, UpdatedAt);
            else
                return null;
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }
        public static string? GetUsernameByID(short? UserID) 
            => clsUserData.GetUsernameByID(UserID);
        public static bool DeleteUser(short? UserID)
        => clsUserData.DeleteUser(UserID);
        public static bool DoesUserExist(short? UserID)
        => clsUserData.DoesUserExist(UserID);
        public static DataTable GetUsers()
        => clsUserData.GetAllUsers();
    }
}
