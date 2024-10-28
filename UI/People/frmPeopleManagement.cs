using ClinicManagementDB_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UI.People
{
    public partial class frmPeopleManagement : Form
    {
        DataTable dtPeople = null;
        public frmPeopleManagement()
        {
            InitializeComponent();
        }
        private void _LoadData()
        {
            dtPeople = clsPerson.GetPeople();
            dgvPeople.DataSource = dtPeople;

            if(dgvPeople.Rows.Count > 0)
            {
                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPeople.Columns[1].HeaderText = "Full Name";
                dgvPeople.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvPeople.Columns[2].HeaderText = "National ID";
                dgvPeople.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPeople.Columns[3].HeaderText = "Birth Date";
                dgvPeople.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPeople.Columns[4].HeaderText = "Gender";
                dgvPeople.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPeople.Columns[5].HeaderText = "Phone";
                dgvPeople.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPeople.Columns[6].HeaderText = "Email";
                dgvPeople.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPeople.Columns[7].HeaderText = "Country Name";
                dgvPeople.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPeople.Columns[8].HeaderText = "Created By";
                dgvPeople.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }

            lblRecordsValue.Text = dgvPeople.Rows.Count.ToString();
        }
        private void frmPeopleManagement_Load(object sender, EventArgs e)
        {
            _LoadData();
            cbFilter.SelectedIndex = 0;
        }
        private void frmPeopleManagement_Shown(object sender, EventArgs e)
        {
            dgvPeople.ClearSelection();

        }
        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtPeople.DefaultView.RowFilter = "";
            lblRecordsValue.Text = dgvPeople.Rows.Count.ToString();

            txtSearch.Visible = (cbFilter.Text != "None") && (cbFilter.Text != "Gender");
            cbGender.Visible = (cbFilter.Text == "Gender");

            if(txtSearch.Visible)
            {
                txtSearch.Text = "";
                txtSearch.Focus();
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                dtPeople.DefaultView.RowFilter = "";
                lblRecordsValue.Text = dgvPeople.Rows.Count.ToString();
                return;
            }

            string Column = cbFilter.Text.Replace(" ", "");

            if(cbFilter.Text == "Person ID")
            {
                dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", Column, txtSearch.Text.Trim());
            }
            else
            {
                dtPeople.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", Column, txtSearch.Text.Trim());
            }

            lblRecordsValue.Text = dgvPeople.Rows.Count.ToString();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilter.Text == "Person ID" || cbFilter.Text == "National ID"
              || cbFilter.Text == "Phone")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtPeople.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", "Gender", cbGender.Text);
            lblRecordsValue.Text = dgvPeople.Rows.Count.ToString();
        }
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.ShowDialog();
            _LoadData();
        }
        private void tsmPersonalInformation_Click(object sender, EventArgs e)
        {
            frmPersonInfo frmPersonInfo = new frmPersonInfo((int)dgvPeople.CurrentRow.Cells[0].Value);
            frmPersonInfo.ShowDialog();
        }
        private void tsmEditPersonalInformation_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frmAddEditPerson = new frmAddEditPerson((int)dgvPeople.CurrentRow.Cells[0].Value);
            frmAddEditPerson.ShowDialog();
            _LoadData();
        }
    }
}
