using System;
using System.Data;
using System.Data.SqlClient;
using ClinicManagementDB_DataAccess;

namespace ClinicManagementDB_Business
{
    public class clsPayment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int? PaymentID { set; get; }
        public decimal Amount { set; get; }
        public byte PaymentMethod { set; get; }
        public DateTime PaymentDate { set; get; }
        public int? PaymentCardID { set; get; }
        public short CreatedByUserID { set; get; }
        public DateTime CreatedAt { set; get; }

        public clsPayment()
        {
            this.PaymentID = null;
            this.Amount = -1;
            this.PaymentMethod = 0;
            this.PaymentDate = DateTime.Now;
            this.PaymentCardID = null;
            this.CreatedByUserID = -1;
            this.CreatedAt = DateTime.Now;
            Mode = enMode.AddNew;
        }
        private clsPayment(int? PaymentID, decimal Amount, byte PaymentMethod, DateTime PaymentDate, int? PaymentCardID, short CreatedByUserID, DateTime CreatedAt)
        {
            this.PaymentID = PaymentID;
            this.Amount = Amount;
            this.PaymentMethod = PaymentMethod;
            this.PaymentDate = PaymentDate;
            this.PaymentCardID = PaymentCardID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedAt = CreatedAt;
            Mode = enMode.Update;
        }
        private bool _AddNewPayment()
        {
            this.PaymentID = (int?)clsPaymentData.AddNewPayment(this.Amount, this.PaymentMethod, this.PaymentDate, this.PaymentCardID, this.CreatedByUserID, this.CreatedAt);
            return (this.PaymentID != -1);
        }
        public static clsPayment Find(int? PaymentID)
        {
            decimal Amount = -1;
            byte PaymentMethod = 0;
            DateTime PaymentDate = DateTime.Now;
            int? PaymentCardID = null;
            short CreatedByUserID = -1;
            DateTime CreatedAt = DateTime.Now;

            bool IsFound = clsPaymentData.GetPaymentByID(PaymentID, ref Amount, ref PaymentMethod, ref PaymentDate, ref PaymentCardID, ref CreatedByUserID, ref CreatedAt);

            if(IsFound)
                return new clsPayment(PaymentID, Amount, PaymentMethod, PaymentDate, PaymentCardID, CreatedByUserID, CreatedAt);
            else
                return null;
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewPayment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
            return false;
        }
        public static bool DoesPaymentExist(int? PaymentID)
            => clsPaymentData.DoesPaymentExist(PaymentID);
        public static DataTable GetPayments()
            => clsPaymentData.GetAllPayments();

        public static decimal GetTotalPaymentsAmount() => clsPaymentData.GetTotalPaymentsAmount();
        public static decimal GetAverageAmountPerPayment() => clsPaymentData.GetAverageAmountPerPayment();
        public static int GetTotalPayments() => clsPaymentData.GetTotalPayments();
        public static string GetMostUsedPaymentMethod() => clsPaymentData.GetMostUsedPaymentMethod();
    }
}
