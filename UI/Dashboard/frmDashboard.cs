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

namespace UI.Dashboard
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }
        private void _LoadData()
        {
            lblTodayAppointments.Text = clsAppointment.GetTodayAppointmentsCount().ToString();
            lblUpcomingAppointmentsThisWeek.Text = clsAppointment.GetWeeklyAppointmentsCount().ToString();
            lblAppointmentCreatedThisWeek.Text = clsAppointment.GetCreatedAppointmentsThisWeekCount().ToString();
            lblTotalPatients.Text = clsPatient.GetTotalPatients().ToString();
            lblNewPatientsThisWeek.Text = clsPatient.GetNewPatientsThisWeek().ToString();
            lblAveragePatientAge.Text = clsPatient.GetAveragePatientAge().ToString();
            lblTotalAvailableDoctors.Text = clsDoctor.GetTotalAvailableDoctors().ToString();
            lblAverageConsultationFee.Text = clsDoctor.GetAverageConsultationFee().ToString("C");
            lblTotalDepartments.Text = clsDepartment.GetTotalDepartments().ToString();
            lblWelcomeName.Text = $"Welcome {clsGlobal.CurrentUser.Person.FirstName}...";
            lblUsername.Text = $"@{clsGlobal.CurrentUser.Username}";
            lblDate.Text = DateTime.Now.ToString("d MMM yyyy");
            lblTime.Text = DateTime.Now.ToString("t");
    }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
