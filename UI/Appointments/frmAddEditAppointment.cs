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
using UI.Global;

namespace UI.Appointments
{
    public partial class frmAddEditAppointment : Form
    {
        enum enMode { Add, Edit }
        enMode _FormMode;
        clsAppointment _Appointment;
        public frmAddEditAppointment()
        {
            InitializeComponent();
            _FormMode = enMode.Add;
            this.Text = "Add New Appointment";
            lblHeader.Text = "ADD Appointment";
            _Appointment = new clsAppointment();
        }
        public frmAddEditAppointment(int AppointmentID)
        {
            InitializeComponent();
            _FormMode = enMode.Edit;
            this.Text = "Edit Appointment";
            lblHeader.Text = "EDIT Appointment";
            _Appointment = clsAppointment.Find(AppointmentID);
        }
        private void frmAddOrUpdateAppointment_Load(object sender, EventArgs e)
        {
            _SetConstraints();
            _LoadData();
        }
        private void _LoadData()
        {
            if(_Appointment.AppointmentID == null)
                return;

            dtpAppointmentDate.Value = _Appointment.AppointmentDate;
            dtpAppointmentTime.Value = _Appointment.AppointmentDate;
            txtAppointmentStatus.Text = _Appointment.AppointmentStatusString;

            if(_Appointment.IsPaid)
            {
                btnPay.Visible = false;
                lblPaymentID.Visible = true;
                lblPaymentID.Text = _Appointment.PaymentID?.ToString();
            }
            else
            {
                btnPay.Visible = true;
                lblPaymentID.Visible = false;
            }

            if(_Appointment.HasMedicalRecord())
            {
                btnAdd.Visible = false;
                lblMedicalRecord.Visible = true;
                lblMedicalRecord.Text = _Appointment.GetMedicalRecordID()?.ToString();
            }
            else
            {
                btnAdd.Visible = true;
                lblMedicalRecord.Visible = false;
            }
        }
        private void _Save()
        {

            if(!_CheckConstrint())
                return;

            TimeSpan TimePart = dtpAppointmentTime.Value.TimeOfDay;
            DateTime DatePart = dtpAppointmentDate.Value.Date;

            DateTime AppointmentDate = DatePart.Add(TimePart);

            _Appointment.AppointmentDate = AppointmentDate;
            _Appointment.AppointmentStatus = 1;
            _Appointment.PatientID = (int)ctrlSmallPatientFinder1.SelectedPatient.PatientID;
            _Appointment.DoctorID = (short)ctrlctrlSmallDoctorFinder1.SelectedDoctor.DoctorID;

            if(_FormMode == enMode.Add)
            {
                _Appointment.CreatedByUserID = 1; //change
                _Appointment.CreatedAt = DateTime.Now;
            }
            else
            {
                _Appointment.UpdatedByUserID = 1; //change
                _Appointment.UpdatedAt = DateTime.Now;
            }

            if(MessageBox.Show("Are you sure you want to save this Appointment?", "Confirm Save",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(_Appointment.Save())
                {
                    MessageBox.Show("Appointment saved successfully.", "Save Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _FormMode = enMode.Edit;
                    this.Text = "Edit Appointment";
                    lblHeader.Text = "EDIT Appointment";
                    txtAppointmentStatus.Text = _Appointment.AppointmentStatusString;
                }
                else
                {
                    MessageBox.Show("An error occurred while saving the Appointment. Please try again.",
                        "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool _CheckConstrint()
        {
            TimeSpan TimePart = dtpAppointmentTime.Value.TimeOfDay;
            DateTime DatePart = dtpAppointmentDate.Value.Date;
            DateTime AppointmentDate = DatePart.Add(TimePart);
                        
            TimeSpan StartTime = new TimeSpan(8, 0, 0);
            TimeSpan EndTime = new TimeSpan(16, 0, 0);

            if(ctrlctrlSmallDoctorFinder1.SelectedDoctor.IsDoctorAvailable(AppointmentDate))
            {
                MessageBox.Show("The doctor is not available at the selected time.");
                return false;
            }

            if(!(TimePart <= EndTime && TimePart >= StartTime))
            {
                Console.WriteLine("Invalid appointment time! Must be between 8 AM and 4 PM.");
                return false;
            }

            if(ctrlSmallPatientFinder1.SelectedPatient == null)
            {
                MessageBox.Show("Please select a patient.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if(ctrlctrlSmallDoctorFinder1.SelectedDoctor == null)
            {
                MessageBox.Show("Please select a doctor.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void _SetConstraints()
        {
            dtpAppointmentDate.MinDate = DateTime.Now;
            dtpAppointmentDate.MaxDate = DateTime.Now.AddMonths(6);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet.", "Feature Not Available",
      MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet.", "Feature Not Available",
      MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
    }
}
