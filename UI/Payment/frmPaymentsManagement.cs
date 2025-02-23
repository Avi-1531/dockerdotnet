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
using static ClinicManagementDB_Business.clsPayment;

namespace UI.Payment
{
    public partial class frmPaymentsManagement : Form
    {
        public frmPaymentsManagement()
        {
            InitializeComponent();
        }
        DataTable dtPayments;
        private void _LoadData()
        {
            dtPayments = clsPayment.GetPayments();
            dgvPayments.DataSource = dtPayments;

            if(dgvPayments.Rows.Count > 0)
            {
                dgvPayments.Columns[0].HeaderText = "Payment ID";
                dgvPayments.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPayments.Columns[1].HeaderText = "Patient ID";
                dgvPayments.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPayments.Columns[2].HeaderText = "Full Name";
                dgvPayments.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPayments.Columns[3].HeaderText = "Amount";
                dgvPayments.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPayments.Columns[4].HeaderText = "Method";
                dgvPayments.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPayments.Columns[5].HeaderText = "Payment Date";
                dgvPayments.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvPayments.Columns[6].HeaderText = "Created By";
                dgvPayments.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPayments.Columns[7].HeaderText = "Created At";
                dgvPayments.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


                dgvPayments.Rows[0].Selected = true;
            }

            lblRecordsValue.Text = dgvPayments.Rows.Count.ToString();
            lblTotalPaymentsValue.Text = dgvPayments.Rows.Count.ToString();
            _LoadStatistics();
        }
        private void _LoadStatistics()
        {
            lblTotalPaymentsAmountValue.Text = clsPayment.GetTotalPaymentsAmount().ToString("C");
            lblAverageAmountPerPaymentValue.Text = clsPayment.GetAverageAmountPerPayment().ToString("C");
            lblTotalPaymentsValue.Text = clsPayment.GetTotalPayments().ToString();
            lblMostUsedPaymentMethodValue.Text = clsPayment.GetMostUsedPaymentMethod();
        }
        private void frmPaymentsManagement_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                dtPayments.DefaultView.RowFilter = "";
                lblRecordsValue.Text = dgvPayments.Rows.Count.ToString();
                return;
            }

            string Column = cbFilter.Text.Replace(" ", "");
            if(cbFilter.Text == "Full Name")
                dtPayments.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", Column, txtSearch.Text.Trim());
            else
                dtPayments.DefaultView.RowFilter = string.Format("[{0}] = {1}", Column, txtSearch.Text.Trim());


            lblRecordsValue.Text = dgvPayments.Rows.Count.ToString();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilter.Text == "Patient ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dtPayments != null)
                dtPayments.DefaultView.RowFilter = "";

            lblRecordsValue.Text = dgvPayments.Rows.Count.ToString();

            txtSearch.Visible = (cbFilter.Text != "None");

            if(txtSearch.Visible)
            {
                txtSearch.Text = "";
                txtSearch.Focus();
            }
        }

    }
}
