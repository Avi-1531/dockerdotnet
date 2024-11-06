using System;
using System.Data;
using ClinicManagementDB_DataAccess;

namespace ClinicManagementDB_Business
{
    public class clsPatient
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int? PatientID { set; get; }
        public int PersonID { set; get; }
        public string? BloodType { set; get; }
        public string? Allergies { set; get; }
        public string? MedicalHistory { set; get; }
        public string? EmergencyContactName { set; get; }
        public string? EmergencyContactPhone { set; get; }
        public short CreatedByUserID { set; get; }
        public DateTime CreatedAt { set; get; }
        public short? UpdatedByUserID { set; get; }
        public DateTime? UpdatedAt { set; get; }

        public clsPatient()
        {
            this.PatientID = null;
            this.PersonID = -1;
            this.BloodType = null;
            this.Allergies = null;
            this.MedicalHistory = null;
            this.EmergencyContactName = null;
            this.EmergencyContactPhone = null;
            this.CreatedByUserID = -1;
            this.CreatedAt = DateTime.Now;
            this.UpdatedByUserID = null;
            this.UpdatedAt = null;
            Mode = enMode.AddNew;
        }
        private clsPatient(int? PatientID, int PersonID, string? BloodType, string? Allergies, string? MedicalHistory, string? EmergencyContactName, string? EmergencyContactPhone, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            this.PatientID = PatientID;
            this.PersonID = PersonID;
            this.BloodType = BloodType;
            this.Allergies = Allergies;
            this.MedicalHistory = MedicalHistory;
            this.EmergencyContactName = EmergencyContactName;
            this.EmergencyContactPhone = EmergencyContactPhone;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedAt = CreatedAt;
            this.UpdatedByUserID = UpdatedByUserID;
            this.UpdatedAt = UpdatedAt;
            Mode = enMode.Update;
        }
        private bool _AddNewPatient()
        {
            this.PatientID = (int?)clsPatientData.AddNewPatient(this.PersonID, this.BloodType, this.Allergies, this.MedicalHistory, this.EmergencyContactName, this.EmergencyContactPhone, this.CreatedByUserID, this.CreatedAt, this.UpdatedByUserID, this.UpdatedAt);
            return (this.PatientID != -1);
        }
        private bool _UpdatePatient()
            => clsPatientData.UpdatePatient(this.PatientID, this.PersonID, this.BloodType, this.Allergies, this.MedicalHistory, this.EmergencyContactName, this.EmergencyContactPhone, this.CreatedByUserID, this.CreatedAt, this.UpdatedByUserID, this.UpdatedAt);
        public static clsPatient Find(int? PatientID)
        {
            int PersonID = -1;
            string? BloodType = null;
            string? Allergies = null;
            string? MedicalHistory = null;
            string? EmergencyContactName = null;
            string? EmergencyContactPhone = null;
            short CreatedByUserID = -1;
            DateTime CreatedAt = DateTime.Now;
            short? UpdatedByUserID = null;
            DateTime? UpdatedAt = null;

            bool IsFound = clsPatientData.GetPatientByID(PatientID, ref PersonID, ref BloodType, ref Allergies, ref MedicalHistory, ref EmergencyContactName, ref EmergencyContactPhone, ref CreatedByUserID, ref CreatedAt, ref UpdatedByUserID, ref UpdatedAt);

            if(IsFound)
                return new clsPatient(PatientID, PersonID, BloodType, Allergies, MedicalHistory, EmergencyContactName, EmergencyContactPhone, CreatedByUserID, CreatedAt, UpdatedByUserID, UpdatedAt);
            else
                return null;
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewPatient())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdatePatient();
            }
            return false;
        }
        public static bool DeletePatient(int? PatientID)
            => clsPatientData.DeletePatient(PatientID);
        public static bool DoesPatientExist(int? PatientID)
            => clsPatientData.DoesPatientExist(PatientID);
        public static DataTable GetPatients()
            => clsPatientData.GetAllPatients();
    }
}
