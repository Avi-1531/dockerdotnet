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

namespace UI.Users
{
    public partial class frmUsersManagement : Form
    {
        DataTable dtUsers = null;
        public frmUsersManagement()
        {
            InitializeComponent();
        }
        private void frmUsersManagement_Load(object sender, EventArgs e)
        {
            _LoadData();
            cbFilter.SelectedIndex = 0;
        }
        private void _LoadData()
        {
            dtUsers = clsUser.GetUsers();
            dgvUsers.DataSource = dtUsers;

            if(dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvUsers.Columns[1].HeaderText = "Person ID";
                dgvUsers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvUsers.Columns[2].HeaderText = "User Name";
                dgvUsers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvUsers.Columns[3].HeaderText = "Is Active";
                dgvUsers.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvUsers.Columns[4].HeaderText = "Role";
                dgvUsers.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvUsers.Columns[5].HeaderText = "Last Login At";
                dgvUsers.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }

            lblRecordsValue.Text = dgvUsers.Rows.Count.ToString();
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtUsers.DefaultView.RowFilter = "";
            lblRecordsValue.Text = dgvUsers.Rows.Count.ToString();

            txtSearch.Visible = (cbFilter.Text != "None") && (cbFilter.Text != "Role") && (cbFilter.Text != "Is Active");
            cbRole.Visible = (cbFilter.Text == "Role");
            cbIsActive.Visible = (cbFilter.Text == "Is Active");

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
                dtUsers.DefaultView.RowFilter = "";
                lblRecordsValue.Text = dgvUsers.Rows.Count.ToString();
                return;
            }

            string Column = cbFilter.Text.Replace(" ", "");
            if(cbFilter.Text == "User Name")
                dtUsers.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", Column, txtSearch.Text.Trim());
            else
                dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", Column, txtSearch.Text.Trim());




            lblRecordsValue.Text = dgvUsers.Rows.Count.ToString();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilter.Text == "Person ID" || cbFilter.Text == "User ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtUsers.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", "IsActive", cbIsActive.Text);
            lblRecordsValue.Text = dgvUsers.Rows.Count.ToString();
        }
        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtUsers.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", "Role", cbRole.Text);
            lblRecordsValue.Text = dgvUsers.Rows.Count.ToString();
        }
        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvUsers.Rows.Count == 0)
            {
                ctrlUserInfoVertical1.ResetValues();
                return;
            }
            ctrlUserInfoVertical1.SetUserID((short)dgvUsers.CurrentRow.Cells[0].Value);
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddNewUser frmAddNewUser = new frmAddNewUser();
            frmAddNewUser.ShowDialog();
            _LoadData();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEditUser frmEditUser = new frmEditUser((short)dgvUsers.CurrentRow.Cells[0].Value);
            frmEditUser.ShowDialog();
            _LoadData();
        }
    }
}
