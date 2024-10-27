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

namespace UI.Departments
{
    public partial class frmDepartmentsManagement : Form
    {
        public frmDepartmentsManagement()
        {
            InitializeComponent();
        }
        private void _LoadData()
        {
            DataTable dt = clsDepartment.GetDepartments();
            dgvDepartments.DataSource = dt;

            if(dgvDepartments.Rows.Count > 0)
            {
                dgvDepartments.Columns[0].HeaderText = "Department ID";
                dgvDepartments.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvDepartments.Columns[1].HeaderText = "Department Name";
                dgvDepartments.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvDepartments.Columns[2].HeaderText = "Description";
                dgvDepartments.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvDepartments.Columns[3].HeaderText = "Department Location";
                dgvDepartments.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvDepartments.Rows[0].Selected = true;
            }

            lblRecordsValue.Text = dgvDepartments.Rows.Count.ToString();
            lblTotalDepartmentsValue.Text = dgvDepartments.Rows.Count.ToString();

        }
        private void _LoadStatistics(byte DepartmentID, string DepartmentName)
        {
            lblTotalDoctorsValue.Text = clsDepartment.TotalDoctorsByDepartmentID(DepartmentID).ToString();
            lblTotalDoctorsInDepartment.Text = $"Total Doctors in {DepartmentName} Department";

            lblTotalVisitsValue.Text = clsDepartment.TotalVisitsByDepartmentID(DepartmentID).ToString();
            TotalVisitOfDepartment.Text = $"Total Visits of {DepartmentName} Department";

            lblTotalRevenueValue.Text = clsDepartment.TotalRevenueByDepartmentID(DepartmentID).ToString("C");
            lblTotalRevenueOfDepartment.Text = $"Total Revenue of {DepartmentName} Department";

        }
        private void frmDepartmentsManagement_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        private void dgvDepartments_SelectionChanged(object sender, EventArgs e)
        {
            byte DepartmentID = Convert.ToByte(dgvDepartments.CurrentRow.Cells[0].Value);
            string DepartmentName = (string)dgvDepartments.CurrentRow.Cells[1].Value;
            _LoadStatistics(DepartmentID, DepartmentName);
        }
    }
}
