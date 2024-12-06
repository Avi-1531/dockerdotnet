namespace UI.Receptionist
{
    partial class frmReceptionistManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvReceptionists = new System.Windows.Forms.DataGridView();
            this.cmsReceptionist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmPersonalInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditPersonalInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnAddReceptionist = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lblRecordsValue = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptionists)).BeginInit();
            this.cmsReceptionist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReceptionists
            // 
            this.dgvReceptionists.AllowUserToAddRows = false;
            this.dgvReceptionists.AllowUserToDeleteRows = false;
            this.dgvReceptionists.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dgvReceptionists.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReceptionists.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgvReceptionists.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReceptionists.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceptionists.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReceptionists.ColumnHeadersHeight = 40;
            this.dgvReceptionists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReceptionists.ContextMenuStrip = this.cmsReceptionist;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceptionists.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReceptionists.EnableHeadersVisualStyles = false;
            this.dgvReceptionists.Location = new System.Drawing.Point(24, 254);
            this.dgvReceptionists.MultiSelect = false;
            this.dgvReceptionists.Name = "dgvReceptionists";
            this.dgvReceptionists.ReadOnly = true;
            this.dgvReceptionists.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReceptionists.RowHeadersVisible = false;
            this.dgvReceptionists.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceptionists.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReceptionists.RowTemplate.Height = 35;
            this.dgvReceptionists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceptionists.ShowCellErrors = false;
            this.dgvReceptionists.ShowCellToolTips = false;
            this.dgvReceptionists.ShowEditingIcon = false;
            this.dgvReceptionists.ShowRowErrors = false;
            this.dgvReceptionists.Size = new System.Drawing.Size(1281, 560);
            this.dgvReceptionists.TabIndex = 11;
            // 
            // cmsReceptionist
            // 
            this.cmsReceptionist.BackColor = System.Drawing.SystemColors.Control;
            this.cmsReceptionist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPersonalInformation,
            this.tsmEditPersonalInformation});
            this.cmsReceptionist.Name = "cmsPerson";
            this.cmsReceptionist.Size = new System.Drawing.Size(293, 86);
            // 
            // tsmPersonalInformation
            // 
            this.tsmPersonalInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tsmPersonalInformation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmPersonalInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tsmPersonalInformation.Name = "tsmPersonalInformation";
            this.tsmPersonalInformation.Size = new System.Drawing.Size(292, 30);
            this.tsmPersonalInformation.Text = "Edit Receptionist";
            this.tsmPersonalInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmPersonalInformation.Click += new System.EventHandler(this.tsmPersonalInformation_Click);
            // 
            // tsmEditPersonalInformation
            // 
            this.tsmEditPersonalInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tsmEditPersonalInformation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmEditPersonalInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tsmEditPersonalInformation.Name = "tsmEditPersonalInformation";
            this.tsmEditPersonalInformation.Size = new System.Drawing.Size(292, 30);
            this.tsmEditPersonalInformation.Text = "Edit Personal Information";
            this.tsmEditPersonalInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(460, 124);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(409, 40);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "RECEPTIONIST MANAGEMENT";
            // 
            // btnAddReceptionist
            // 
            this.btnAddReceptionist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAddReceptionist.BackgroundImage = global::UI.Properties.Resources.add_person;
            this.btnAddReceptionist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddReceptionist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReceptionist.FlatAppearance.BorderSize = 0;
            this.btnAddReceptionist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReceptionist.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReceptionist.Location = new System.Drawing.Point(1248, 200);
            this.btnAddReceptionist.Name = "btnAddReceptionist";
            this.btnAddReceptionist.Size = new System.Drawing.Size(57, 50);
            this.btnAddReceptionist.TabIndex = 14;
            this.btnAddReceptionist.UseVisualStyleBackColor = false;
            this.btnAddReceptionist.Click += new System.EventHandler(this.btnAddReceptionist_Click);
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
            "Receptionist ID",
            "Full Name",
            "Status",
            "Receptionist User"});
            this.cbFilter.Location = new System.Drawing.Point(121, 213);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(245, 33);
            this.cbFilter.TabIndex = 12;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // lblRecordsValue
            // 
            this.lblRecordsValue.AutoSize = true;
            this.lblRecordsValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsValue.Location = new System.Drawing.Point(92, 819);
            this.lblRecordsValue.Name = "lblRecordsValue";
            this.lblRecordsValue.Size = new System.Drawing.Size(48, 21);
            this.lblRecordsValue.TabIndex = 7;
            this.lblRecordsValue.Text = "[????]";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(26, 819);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(69, 21);
            this.lblRecords.TabIndex = 8;
            this.lblRecords.Text = "Records:";
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(24, 214);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(91, 30);
            this.lblFilterBy.TabIndex = 9;
            this.lblFilterBy.Text = "Filter By:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.people;
            this.pictureBox1.Location = new System.Drawing.Point(598, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtSearch.Location = new System.Drawing.Point(372, 212);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(245, 34);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.DropDownWidth = 245;
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.IntegralHeight = false;
            this.cbStatus.Items.AddRange(new object[] {
            "Active",
            "On Leave",
            "Resigned",
            "Terminated"});
            this.cbStatus.Location = new System.Drawing.Point(372, 213);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(245, 33);
            this.cbStatus.TabIndex = 13;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // frmReceptionistManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1329, 861);
            this.Controls.Add(this.dgvReceptionists);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnAddReceptionist);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lblRecordsValue);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtSearch);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReceptionistManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReceptionistManagement";
            this.Load += new System.EventHandler(this.frmReceptionistManagement_Load);
            this.Shown += new System.EventHandler(this.frmReceptionistManagement_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptionists)).EndInit();
            this.cmsReceptionist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReceptionists;
        private System.Windows.Forms.ContextMenuStrip cmsReceptionist;
        private System.Windows.Forms.ToolStripMenuItem tsmPersonalInformation;
        private System.Windows.Forms.ToolStripMenuItem tsmEditPersonalInformation;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnAddReceptionist;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblRecordsValue;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}