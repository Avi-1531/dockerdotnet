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

namespace UI.Appointments
{
    public partial class frmAppointmentsManagement : Form
    {
        public frmAppointmentsManagement()
        {
            InitializeComponent();
        }

        DataTable dtAppointments = null;
        private void _LoadData()
        {
            dtAppointments = clsAppointment.GetAppointments();
            dgvAppointments.DataSource = dtAppointments;

            if(dgvAppointments.Rows.Count > 0)
            {
                dgvAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvAppointments.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                
                dgvAppointments.Columns[1].HeaderText = "Patient ID";
                dgvAppointments.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dgvAppointments.Columns[2].HeaderText = "Patient Name";
                dgvAppointments.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                dgvAppointments.Columns[3].HeaderText = "Doctor ID";
                dgvAppointments.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dgvAppointments.Columns[4].HeaderText = "Appointment Date";
                dgvAppointments.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvAppointments.Columns[5].HeaderText = "Status";
                dgvAppointments.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvAppointments.Columns[6].HeaderText = "Is Paid";
                dgvAppointments.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dgvAppointments.Columns[7].HeaderText = "Payment ID";
                dgvAppointments.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            }

            lblRecordsValue.Text = dgvAppointments.Rows.Count.ToString();
        }
        private void frmAppointmentsManagement_Load(object sender, EventArgs e)
        {
            _LoadData();
            cbFilter.SelectedIndex = 0;
        }
        private void frmAppointmentsManagement_Shown(object sender, EventArgs e)
        {
            dgvAppointments.ClearSelection();

        }
        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dtAppointments != null)
                dtAppointments.DefaultView.RowFilter = "";

            lblRecordsValue.Text = dgvAppointments.Rows.Count.ToString();

            if(cbFilter.Text == "None")
            {
                txtSearch.Visible = false;
                cbStatus.Visible = false;
                return;
            }
            if(cbFilter.Text == "Status")
            {
                txtSearch.Visible = false;
                cbStatus.Visible = true;
            }
            else
            {
                txtSearch.Visible = true;
                cbStatus.Visible = false;
            }


        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                dtAppointments.DefaultView.RowFilter = "";
                lblRecordsValue.Text = dgvAppointments.Rows.Count.ToString();
                return;
            }

            string Column = cbFilter.Text.Replace(" ", "");

            if(cbFilter.Text == "Appointment ID" || cbFilter.Text == "Patient ID" || cbFilter.Text == "Doctor ID")
            {
                dtAppointments.DefaultView.RowFilter = string.Format("[{0}] = {1}", Column, txtSearch.Text.Trim());
            }
            else
            {
                dtAppointments.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", Column, txtSearch.Text.Trim());
            }

            lblRecordsValue.Text = dgvAppointments.Rows.Count.ToString();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilter.Text == "App. ID" || cbFilter.Text == "Patient ID" || cbFilter.Text == "Doctor ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtAppointments.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", "Status", cbStatus.Text);
            lblRecordsValue.Text = dgvAppointments.Rows.Count.ToString();
        }
        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            frmAddEditAppointment frmAddEditAppointment = new frmAddEditAppointment();
            frmAddEditAppointment.ShowDialog();
            _LoadData();
        }

    }
}
