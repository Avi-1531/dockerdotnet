namespace UI.Appointments
{
    partial class frmAppointmentsManagement
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
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.cmsAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddNewAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditPatientInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowDoctorInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPatientMedicalRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPatientInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmkDoctorInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCallPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtPageNumber = new System.Windows.Forms.TextBox();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.lblOfTotalPagesAndRows = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.cmsAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dgvAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgvAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppointments.ColumnHeadersHeight = 40;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAppointments.ContextMenuStrip = this.cmsAppointments;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAppointments.EnableHeadersVisualStyles = false;
            this.dgvAppointments.Location = new System.Drawing.Point(24, 252);
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointments.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAppointments.RowTemplate.Height = 35;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.ShowCellErrors = false;
            this.dgvAppointments.ShowCellToolTips = false;
            this.dgvAppointments.ShowEditingIcon = false;
            this.dgvAppointments.ShowRowErrors = false;
            this.dgvAppointments.Size = new System.Drawing.Size(1281, 532);
            this.dgvAppointments.TabIndex = 31;
            this.dgvAppointments.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAppointments_CellMouseDoubleClick);
            // 
            // cmsAppointments
            // 
            this.cmsAppointments.BackColor = System.Drawing.SystemColors.Control;
            this.cmsAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddNewAppointment,
            this.tsmiEditPatientInfo,
            this.tsmiShowDoctorInfo,
            this.tsmiPatientMedicalRecords,
            this.tsmiPatientInfo,
            this.tsmkDoctorInfo,
            this.tsmiCallPatient});
            this.cmsAppointments.Name = "cmsPerson";
            this.cmsAppointments.Size = new System.Drawing.Size(294, 214);
            // 
            // tsmiAddNewAppointment
            // 
            this.tsmiAddNewAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tsmiAddNewAppointment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiAddNewAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tsmiAddNewAppointment.Name = "tsmiAddNewAppointment";
            this.tsmiAddNewAppointment.Size = new System.Drawing.Size(293, 30);
            this.tsmiAddNewAppointment.Text = "Add New Appointment";
            this.tsmiAddNewAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiAddNewAppointment.Click += new System.EventHandler(this.tsmiAddNewAppointment_Click);
            // 
            // tsmiEditPatientInfo
            // 
            this.tsmiEditPatientInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tsmiEditPatientInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiEditPatientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tsmiEditPatientInfo.Name = "tsmiEditPatientInfo";
            this.tsmiEditPatientInfo.Size = new System.Drawing.Size(293, 30);
            this.tsmiEditPatientInfo.Text = "Edit Appointment";
            this.tsmiEditPatientInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiEditPatientInfo.Click += new System.EventHandler(this.tsmiEditAppointmentInfo_Click);
            // 
            // tsmiShowDoctorInfo
            // 
            this.tsmiShowDoctorInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tsmiShowDoctorInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiShowDoctorInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tsmiShowDoctorInfo.Name = "tsmiShowDoctorInfo";
            this.tsmiShowDoctorInfo.Size = new System.Drawing.Size(293, 30);
            this.tsmiShowDoctorInfo.Text = "Appointment Information";
            this.tsmiShowDoctorInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiShowDoctorInfo.Click += new System.EventHandler(this.tsmiShowDoctorInfo_Click);
            // 
            // tsmiPatientMedicalRecords
            // 
            this.tsmiPatientMedicalRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tsmiPatientMedicalRecords.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiPatientMedicalRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tsmiPatientMedicalRecords.Name = "tsmiPatientMedicalRecords";
            this.tsmiPatientMedicalRecords.Size = new System.Drawing.Size(293, 30);
            this.tsmiPatientMedicalRecords.Text = "Patient\'s Medical Records";
            this.tsmiPatientMedicalRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiPatientMedicalRecords.Click += new System.EventHandler(this.tsmiPatientMedicalRecords_Click);
            // 
            // tsmiPatientInfo
            // 
            this.tsmiPatientInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tsmiPatientInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiPatientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tsmiPatientInfo.Name = "tsmiPatientInfo";
            this.tsmiPatientInfo.Size = new System.Drawing.Size(293, 30);
            this.tsmiPatientInfo.Text = "Patient Information";
            this.tsmiPatientInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiPatientInfo.Click += new System.EventHandler(this.tsmiPatientInfo_Click);
            // 
            // tsmkDoctorInfo
            // 
            this.tsmkDoctorInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tsmkDoctorInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmkDoctorInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tsmkDoctorInfo.Name = "tsmkDoctorInfo";
            this.tsmkDoctorInfo.Size = new System.Drawing.Size(293, 30);
            this.tsmkDoctorInfo.Text = "Doctor Information";
            this.tsmkDoctorInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmkDoctorInfo.Click += new System.EventHandler(this.tsmkDoctorInfo_Click);
            // 
            // tsmiCallPatient
            // 
            this.tsmiCallPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tsmiCallPatient.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiCallPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tsmiCallPatient.Name = "tsmiCallPatient";
            this.tsmiCallPatient.Size = new System.Drawing.Size(293, 30);
            this.tsmiCallPatient.Text = "Call Patient";
            this.tsmiCallPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiCallPatient.Click += new System.EventHandler(this.tsmiCallPatient_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(448, 124);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(433, 40);
            this.lblHeader.TabIndex = 26;
            this.lblHeader.Text = "APPOINTMENTS MANAGEMENT";
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAddAppointment.BackgroundImage = global::UI.Properties.Resources.Add_NewV2;
            this.btnAddAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAppointment.FlatAppearance.BorderSize = 0;
            this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppointment.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAppointment.Location = new System.Drawing.Point(1248, 200);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(57, 50);
            this.btnAddAppointment.TabIndex = 33;
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
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
            "Appointment ID",
            "Patient Name",
            "Patient ID",
            "Doctor ID"});
            this.cbFilter.Location = new System.Drawing.Point(121, 213);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(245, 33);
            this.cbFilter.TabIndex = 32;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(24, 214);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(91, 30);
            this.lblFilterBy.TabIndex = 29;
            this.lblFilterBy.Text = "Filter By:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.Appointments;
            this.pictureBox1.Location = new System.Drawing.Point(598, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtSearch.Location = new System.Drawing.Point(372, 213);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(245, 34);
            this.txtSearch.TabIndex = 34;
            this.txtSearch.Visible = false;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnFind.BackgroundImage = global::UI.Properties.Resources.SearchV2;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(623, 212);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(34, 34);
            this.btnFind.TabIndex = 36;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Visible = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtPageNumber
            // 
            this.txtPageNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPageNumber.Enabled = false;
            this.txtPageNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPageNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtPageNumber.Location = new System.Drawing.Point(98, 811);
            this.txtPageNumber.Multiline = true;
            this.txtPageNumber.Name = "txtPageNumber";
            this.txtPageNumber.Size = new System.Drawing.Size(41, 25);
            this.txtPageNumber.TabIndex = 40;
            this.txtPageNumber.Text = "1";
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnNextPage.BackgroundImage = global::UI.Properties.Resources.right;
            this.btnNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.Location = new System.Drawing.Point(61, 806);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(31, 34);
            this.btnNextPage.TabIndex = 38;
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPreviousPage.BackgroundImage = global::UI.Properties.Resources.left;
            this.btnPreviousPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPreviousPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviousPage.FlatAppearance.BorderSize = 0;
            this.btnPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousPage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousPage.Location = new System.Drawing.Point(24, 806);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(31, 34);
            this.btnPreviousPage.TabIndex = 39;
            this.btnPreviousPage.UseVisualStyleBackColor = false;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // lblOfTotalPagesAndRows
            // 
            this.lblOfTotalPagesAndRows.AutoSize = true;
            this.lblOfTotalPagesAndRows.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfTotalPagesAndRows.Location = new System.Drawing.Point(145, 813);
            this.lblOfTotalPagesAndRows.Name = "lblOfTotalPagesAndRows";
            this.lblOfTotalPagesAndRows.Size = new System.Drawing.Size(101, 21);
            this.lblOfTotalPagesAndRows.TabIndex = 37;
            this.lblOfTotalPagesAndRows.Text = "of [????] (???)";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnCancel.BackgroundImage = global::UI.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(661, 211);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(41, 37);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAppointmentsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1329, 861);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPageNumber);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.lblOfTotalPagesAndRows);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnFind);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAppointmentsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAppointmentsManagement";
            this.Load += new System.EventHandler(this.frmAppointmentsManagement_Load);
            this.Shown += new System.EventHandler(this.frmAppointmentsManagement_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.cmsAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.ContextMenuStrip cmsAppointments;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditPatientInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDoctorInfo;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiPatientMedicalRecords;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtPageNumber;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Label lblOfTotalPagesAndRows;
        private System.Windows.Forms.ToolStripMenuItem tsmiPatientInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmkDoctorInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiCallPatient;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewAppointment;
        private System.Windows.Forms.Button btnCancel;
    }
}