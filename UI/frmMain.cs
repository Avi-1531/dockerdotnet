using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmMain : Form
    {
        private void LoadForm(Form frm)
        {

            pnlMain.Controls.Clear();

            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(frm);
            pnlMain.Tag = frm;
            frm.Show();
        }
        public frmMain()
        {
            InitializeComponent();

        }

        private void _ShowNotImplementedFeatureMessage(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet.", "Feature Not Available",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
    }
}
