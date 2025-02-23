namespace UI.Payment
{
    partial class frmPaymentsManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMostUsedPaymentMethodValue = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.lblTotalPaymentsValue = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAverageAmountPerPaymentValue = new System.Windows.Forms.Label();
            this.lblAverageAmountPerPayment = new System.Windows.Forms.Label();
            this.lblTotalPaymentsAmountValue = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblRecordsValue = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDepartments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsDepartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMostUsedPaymentMethodValue
            // 
            this.lblMostUsedPaymentMethodValue.AutoSize = true;
            this.lblMostUsedPaymentMethodValue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostUsedPaymentMethodValue.Location = new System.Drawing.Point(7, 12);
            this.lblMostUsedPaymentMethodValue.Name = "lblMostUsedPaymentMethodValue";
            this.lblMostUsedPaymentMethodValue.Size = new System.Drawing.Size(148, 65);
            this.lblMostUsedPaymentMethodValue.TabIndex = 16;
            this.lblMostUsedPaymentMethodValue.Text = "[????]";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.panel4.Controls.Add(this.lblMostUsedPaymentMethodValue);
            this.panel4.Controls.Add(this.label33);
            this.panel4.Location = new System.Drawing.Point(998, 679);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(289, 121);
            this.panel4.TabIndex = 22;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(12, 77);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(275, 25);
            this.label33.TabIndex = 16;
            this.label33.Text = "Is Most Used Payment Method";
            // 
            // lblTotalPaymentsValue
            // 
            this.lblTotalPaymentsValue.AutoSize = true;
            this.lblTotalPaymentsValue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaymentsValue.Location = new System.Drawing.Point(7, 12);
            this.lblTotalPaymentsValue.Name = "lblTotalPaymentsValue";
            this.lblTotalPaymentsValue.Size = new System.Drawing.Size(148, 65);
            this.lblTotalPaymentsValue.TabIndex = 16;
            this.lblTotalPaymentsValue.Text = "[????]";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(12, 77);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(141, 25);
            this.label22.TabIndex = 16;
            this.label22.Text = "Total Payments";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(117)))));
            this.panel3.Controls.Add(this.lblTotalPaymentsValue);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Location = new System.Drawing.Point(998, 533);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 121);
            this.panel3.TabIndex = 23;
            // 
            // lblAverageAmountPerPaymentValue
            // 
            this.lblAverageAmountPerPaymentValue.AutoSize = true;
            this.lblAverageAmountPerPaymentValue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageAmountPerPaymentValue.Location = new System.Drawing.Point(7, 12);
            this.lblAverageAmountPerPaymentValue.Name = "lblAverageAmountPerPaymentValue";
            this.lblAverageAmountPerPaymentValue.Size = new System.Drawing.Size(148, 65);
            this.lblAverageAmountPerPaymentValue.TabIndex = 16;
            this.lblAverageAmountPerPaymentValue.Text = "[????]";
            // 
            // lblAverageAmountPerPayment
            // 
            this.lblAverageAmountPerPayment.AutoSize = true;
            this.lblAverageAmountPerPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageAmountPerPayment.Location = new System.Drawing.Point(12, 77);
            this.lblAverageAmountPerPayment.Name = "lblAverageAmountPerPayment";
            this.lblAverageAmountPerPayment.Size = new System.Drawing.Size(270, 25);
            this.lblAverageAmountPerPayment.TabIndex = 16;
            this.lblAverageAmountPerPayment.Text = "Average Amount Per Payment";
            // 
            // lblTotalPaymentsAmountValue
            // 
            this.lblTotalPaymentsAmountValue.AutoSize = true;
            this.lblTotalPaymentsAmountValue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaymentsAmountValue.Location = new System.Drawing.Point(7, 12);
            this.lblTotalPaymentsAmountValue.Name = "lblTotalPaymentsAmountValue";
            this.lblTotalPaymentsAmountValue.Size = new System.Drawing.Size(148, 65);
            this.lblTotalPaymentsAmountValue.TabIndex = 16;
            this.lblTotalPaymentsAmountValue.Text = "[????]";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(117)))));
            this.panel2.Controls.Add(this.lblAverageAmountPerPaymentValue);
            this.panel2.Controls.Add(this.lblAverageAmountPerPayment);
            this.panel2.Location = new System.Drawing.Point(998, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 121);
            this.panel2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total Payments Amount";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.lblTotalPaymentsAmountValue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(998, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 121);
            this.panel1.TabIndex = 25;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(490, 141);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(348, 40);
            this.lblHeader.TabIndex = 17;
            this.lblHeader.Text = "PAYMENT MANAGEMENT";
            // 
            // lblRecordsValue
            // 
            this.lblRecordsValue.AutoSize = true;
            this.lblRecordsValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsValue.Location = new System.Drawing.Point(106, 803);
            this.lblRecordsValue.Name = "lblRecordsValue";
            this.lblRecordsValue.Size = new System.Drawing.Size(48, 21);
            this.lblRecordsValue.TabIndex = 18;
            this.lblRecordsValue.Text = "[????]";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(42, 802);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(69, 21);
            this.lblRecords.TabIndex = 19;
            this.lblRecords.Text = "Records:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.people;
            this.pictureBox1.Location = new System.Drawing.Point(598, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(216, 30);
            this.toolStripMenuItem1.Text = "Edit Department";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmsDepartments
            // 
            this.cmsDepartments.BackColor = System.Drawing.SystemColors.Control;
            this.cmsDepartments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.cmsDepartments.Name = "cmsPerson";
            this.cmsDepartments.Size = new System.Drawing.Size(217, 34);
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dgvPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgvPayments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPayments.ColumnHeadersHeight = 40;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPayments.ContextMenuStrip = this.cmsDepartments;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayments.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPayments.EnableHeadersVisualStyles = false;
            this.dgvPayments.Location = new System.Drawing.Point(42, 240);
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayments.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPayments.RowTemplate.Height = 35;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.ShowCellErrors = false;
            this.dgvPayments.ShowCellToolTips = false;
            this.dgvPayments.ShowEditingIcon = false;
            this.dgvPayments.ShowRowErrors = false;
            this.dgvPayments.Size = new System.Drawing.Size(937, 560);
            this.dgvPayments.TabIndex = 21;
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.DropDownWidth = 245;
            this.cbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.IntegralHeight = false;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "Patient ID",
            "Full Name"});
            this.cbFilter.Location = new System.Drawing.Point(139, 199);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(245, 33);
            this.cbFilter.TabIndex = 35;
            this.cbFilter.TextChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(42, 200);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(91, 30);
            this.lblFilterBy.TabIndex = 34;
            this.lblFilterBy.Text = "Filter By:";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtSearch.Location = new System.Drawing.Point(390, 198);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(245, 34);
            this.txtSearch.TabIndex = 37;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // frmPaymentsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1329, 861);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblRecordsValue);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.txtSearch);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPaymentsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPaymentManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPaymentsManagement_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsDepartments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMostUsedPaymentMethodValue;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblTotalPaymentsValue;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAverageAmountPerPaymentValue;
        private System.Windows.Forms.Label lblAverageAmountPerPayment;
        private System.Windows.Forms.Label lblTotalPaymentsAmountValue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblRecordsValue;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip cmsDepartments;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.TextBox txtSearch;
    }
}