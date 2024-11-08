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

namespace UI.Patient
{
    public partial class frmPatientsManagement : Form
    {
        public frmPatientsManagement()
        {
            InitializeComponent();
        }

        DataTable dtPatients = null;
        private void _LoadData()
        {
            dtPatients = clsPatient.GetPatients();
            dgvPatients.DataSource = dtPatients;

            if(dgvPatients.Rows.Count > 0)
            {
                dgvPatients.Columns[0].HeaderText = "Patient ID";
                dgvPatients.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dgvPatients.Columns[1].HeaderText = "Person ID";
                dgvPatients.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dgvPatients.Columns[2].HeaderText = "Full Name";
                dgvPatients.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvPatients.Columns[3].HeaderText = "National ID";
                dgvPatients.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dgvPatients.Columns[4].HeaderText = "Blood Type";
                dgvPatients.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dgvPatients.Columns[5].HeaderText = "Allergies";
                dgvPatients.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dgvPatients.Columns[6].HeaderText = "Medical History";
                dgvPatients.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPatients.Columns[7].HeaderText = "E. Contact Name";
                dgvPatients.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPatients.Columns[8].HeaderText = "E. Contact Phone";
                dgvPatients.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }

            lblRecordsValue.Text = dgvPatients.Rows.Count.ToString();
        }
        private void frmPatientsManagement_Load(object sender, EventArgs e)
        {
            _LoadData();
            cbFilter.SelectedIndex = 0;
        }
        private void frmPatientsManagement_Shown(object sender, EventArgs e)
        {
            dgvPatients.ClearSelection();

        }
        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dtPatients != null)
                dtPatients.DefaultView.RowFilter = "";
            lblRecordsValue.Text = dgvPatients.Rows.Count.ToString();

            txtSearch.Visible = (cbFilter.Text != "None");

        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                dtPatients.DefaultView.RowFilter = "";
                lblRecordsValue.Text = dgvPatients.Rows.Count.ToString();
                return;
            }

            string Column = cbFilter.Text.Replace(" ", "");

            if(cbFilter.Text == "Person ID" || cbFilter.Text == "Patient ID")
            {
                dtPatients.DefaultView.RowFilter = string.Format("[{0}] = {1}", Column, txtSearch.Text.Trim());
            }
            else
            {
                dtPatients.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", Column, txtSearch.Text.Trim());
            }

            lblRecordsValue.Text = dgvPatients.Rows.Count.ToString();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilter.Text == "Person ID" || cbFilter.Text == "National ID"
              || cbFilter.Text == "Patient ID" || cbFilter.Text == "Phone")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            frmAddEditPatient frmAddEditPatient = new frmAddEditPatient();
            frmAddEditPatient.ShowDialog();
            _LoadData();
        }

        private void tsmiEditPatientInfo_Click(object sender, EventArgs e)
        {
            int PatientID = (int)dgvPatients.CurrentRow.Cells[0].Value;
            frmAddEditPatient frmAddEditPatient = new frmAddEditPatient(PatientID);
            frmAddEditPatient.ShowDialog();
            _LoadData();
        }

        private void tsmiShowPatientInfo_Click(object sender, EventArgs e)
        {
            int PatientID = (int)dgvPatients.CurrentRow.Cells[0].Value;
            frmPatientInfo frmPatientInfo = new frmPatientInfo(PatientID);
            frmPatientInfo.ShowDialog();
        }
    }
}
