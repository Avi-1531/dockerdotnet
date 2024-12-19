using ClinicManagementDB_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.People;
using UI.Users;

namespace UI.Receptionist.Controls
{
    public partial class ctrlReceptionistInfo : UserControl
    {
        public ctrlReceptionistInfo()
        {
            InitializeComponent();
        }

        short _ReceptionistID;
        clsReceptionist _Receptionist;
        public void SetReceptionistID(short ReceptionistUD)
        {
            _Receptionist = clsReceptionist.Find(ReceptionistUD);

            if(_Receptionist == null)
            {
                ResetValues();
                return;
            }
            _LoadData();
        }
        public void ResetValues()
        {
            string NotExistValue = "[????]";
            lblReceptionistID.Text = NotExistValue;
            lblReceptionistUsername.Text = NotExistValue;
            lblPersonID.Text = NotExistValue;
            lblReceptionistStatus.Text = NotExistValue;
            lblHireDate.Text = NotExistValue;
            lblEndDate.Text = NotExistValue;
            lblCreatedByAt.Text = "Created By [??] At [??]";
            lblUpdatedByAt.Text = "Last Update By [??] At [??] ";
        }
        private void _LoadData()
        {
            lblReceptionistID.Text = _Receptionist.ReceptionistID.ToString();

            lblReceptionistUsername.Text = _Receptionist.ReceptionistUser.Username;
            lblPersonID.Text = _Receptionist.PersonID.ToString();
            lblReceptionistStatus.Text = _Receptionist.ReceptionistStatusString;
            lblHireDate.Text = _Receptionist.HireDate.ToShortDateString();

            if(_Receptionist.EndDate != null)
            {
                DateTime EndDate = (DateTime)_Receptionist.EndDate;
                lblEndDate.Text = EndDate.ToShortDateString();
            }
            else
            {
                lblEndDate.Text = "N/A";
            }

            // change
            lblCreatedByAt.Text = "Created By [??] At [??]";
            lblUpdatedByAt.Text = "Last Update By [??] At [??] ";
        }
        private void lblReceptionistUsername_Click(object sender, EventArgs e)
        {
            frmUserInfo frmUserInfo = new frmUserInfo(_Receptionist.ReceptionistUserID);
            frmUserInfo.ShowDialog();
        }
        private void lblPersonID_Click(object sender, EventArgs e)
        {
            frmPersonInfo frmPersonInfo = new frmPersonInfo((int)_Receptionist.PersonID);
            frmPersonInfo.ShowDialog();
        }
    }
}
