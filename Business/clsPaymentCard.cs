using System;
using System.Data;
using ClinicManagementDB_DataAccess;

namespace ClinicManagementDB_Business
{
    public class clsPaymentCard
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int? PaymentCardID { set; get; }
        public string CardNumber { set; get; }
        public string CardHolderName { set; get; }
        public DateTime ExpiryDate { set; get; }
        public short CreatedByUserID { set; get; }
        public DateTime CreatedAt { set; get; }

        public clsPaymentCard()
        {
            this.PaymentCardID = null;
            this.CardNumber = string.Empty;
            this.CardHolderName = string.Empty;
            this.ExpiryDate = DateTime.Now;
            this.CreatedByUserID = -1;
            this.CreatedAt = DateTime.Now;
            Mode = enMode.AddNew;
        }
        private clsPaymentCard(int? PaymentCardID, string CardNumber, string CardHolderName, DateTime ExpiryDate, short CreatedByUserID, DateTime CreatedAt)
        {
            this.PaymentCardID = PaymentCardID;
            this.CardNumber = CardNumber;
            this.CardHolderName = CardHolderName;
            this.ExpiryDate = ExpiryDate;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedAt = CreatedAt;
            Mode = enMode.Update;
        }
        private bool _AddNewPaymentCard()
        {
            this.PaymentCardID = (int?)clsPaymentCardData.AddNewPaymentCard(this.CardNumber, this.CardHolderName, this.ExpiryDate, this.CreatedByUserID, this.CreatedAt);
            return (this.PaymentCardID != -1);
        }
        private bool _UpdatePaymentCard()
            => clsPaymentCardData.UpdatePaymentCard(this.PaymentCardID, this.CardNumber, this.CardHolderName, this.ExpiryDate, this.CreatedByUserID, this.CreatedAt);
        public static clsPaymentCard Find(int? PaymentCardID)
        {
            string CardNumber = string.Empty;
            string CardHolderName = string.Empty;
            DateTime ExpiryDate = DateTime.Now;
            short CreatedByUserID = -1;
            DateTime CreatedAt = DateTime.Now;

            bool IsFound = clsPaymentCardData.GetPaymentCardByID(PaymentCardID, ref CardNumber, ref CardHolderName, ref ExpiryDate, ref CreatedByUserID, ref CreatedAt);

            if(IsFound)
                return new clsPaymentCard(PaymentCardID, CardNumber, CardHolderName, ExpiryDate, CreatedByUserID, CreatedAt);
            else
                return null;
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewPaymentCard())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdatePaymentCard();
            }
            return false;
        }
        public static bool DeletePaymentCard(int? PaymentCardID)
            => clsPaymentCardData.DeletePaymentCard(PaymentCardID);
        public static bool DoesPaymentCardExist(int? PaymentCardID)
            => clsPaymentCardData.DoesPaymentCardExist(PaymentCardID);
        public static DataTable GetPaymentCards()
            => clsPaymentCardData.GetAllPaymentCards();
    }
}
