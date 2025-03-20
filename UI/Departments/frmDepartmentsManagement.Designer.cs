namespace UI.Departments
{
    partial class frmDepartmentsManagement
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
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.cmsDepartments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddNewDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblRecordsValue = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalDepartmentsValue = new System.Windows.Forms.Label();
            this.lblTotalDepartments = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalDoctorsValue = new System.Windows.Forms.Label();
            this.lblTotalDoctorsInDepartment = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalVisitsValue = new System.Windows.Forms.Label();
            this.lblTotalVisitOfDepartment = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbRiyalSymbol = new System.Windows.Forms.PictureBox();
            this.lblTotalRevenueValue = new System.Windows.Forms.Label();
            this.lblTotalRevenueOfDepartment = new System.Windows.Forms.Label();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.cmsDepartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRiyalSymbol)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.AllowUserToAddRows = false;
            this.dgvDepartments.AllowUserToDeleteRows = false;
            this.dgvDepartments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dgvDepartments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepartments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgvDepartments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDepartments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDepartments.ColumnHeadersHeight = 40;
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDepartments.ContextMenuStrip = this.cmsDepartments;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepartments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDepartments.EnableHeadersVisualStyles = false;
            this.dgvDepartments.Location = new System.Drawing.Point(42, 223);
            this.dgvDepartments.MultiSelect = false;
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.ReadOnly = true;
            this.dgvDepartments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDepartments.RowHeadersVisible = false;
            this.dgvDepartments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepartments.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDepartments.RowTemplate.Height = 35;
            this.dgvDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartments.ShowCellErrors = false;
            this.dgvDepartments.ShowCellToolTips = false;
            this.dgvDepartments.ShowEditingIcon = false;
            this.dgvDepartments.ShowRowErrors = false;
            this.dgvDepartments.Size = new System.Drawing.Size(767, 560);
            this.dgvDepartments.TabIndex = 11;
            this.dgvDepartments.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDepartments_CellMouseDoubleClick);
            this.dgvDepartments.SelectionChanged += new System.EventHandler(this.dgvDepartments_SelectionChanged);
            // 
            // cmsDepartments
            // 
            this.cmsDepartments.BackColor = System.Drawing.SystemColors.Control;
            this.cmsDepartments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddNewDepartment,
            this.toolStripMenuItem1});
            this.cmsDepartments.Name = "cmsPerson";
            this.cmsDepartments.Size = new System.Drawing.Size(262, 64);
            // 
            // tsmiAddNewDepartment
            // 
            this.tsmiAddNewDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tsmiAddNewDepartment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiAddNewDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tsmiAddNewDepartment.Name = "tsmiAddNewDepartment";
            this.tsmiAddNewDepartment.Size = new System.Drawing.Size(261, 30);
            this.tsmiAddNewDepartment.Text = "Add New Department";
            this.tsmiAddNewDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiAddNewDepartment.Click += new System.EventHandler(this.tsmiAddNewDepartment_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(261, 30);
            this.toolStripMenuItem1.Text = "Edit Department";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem1.Click += new System.EventHandler(this.tsmiEditDepartment_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(464, 124);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(400, 40);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "DEPARTMENT MANAGEMENT";
            // 
            // lblRecordsValue
            // 
            this.lblRecordsValue.AutoSize = true;
            this.lblRecordsValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsValue.Location = new System.Drawing.Point(106, 786);
            this.lblRecordsValue.Name = "lblRecordsValue";
            this.lblRecordsValue.Size = new System.Drawing.Size(48, 21);
            this.lblRecordsValue.TabIndex = 7;
            this.lblRecordsValue.Text = "[????]";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(42, 785);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(69, 21);
            this.lblRecords.TabIndex = 8;
            this.lblRecords.Text = "Records:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.Departments;
            this.pictureBox1.Location = new System.Drawing.Point(598, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.lblTotalDepartmentsValue);
            this.panel1.Controls.Add(this.lblTotalDepartments);
            this.panel1.Location = new System.Drawing.Point(827, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 121);
            this.panel1.TabIndex = 15;
            // 
            // lblTotalDepartmentsValue
            // 
            this.lblTotalDepartmentsValue.AutoSize = true;
            this.lblTotalDepartmentsValue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDepartmentsValue.Location = new System.Drawing.Point(7, 12);
            this.lblTotalDepartmentsValue.Name = "lblTotalDepartmentsValue";
            this.lblTotalDepartmentsValue.Size = new System.Drawing.Size(148, 65);
            this.lblTotalDepartmentsValue.TabIndex = 16;
            this.lblTotalDepartmentsValue.Text = "[????]";
            this.lblTotalDepartmentsValue.Visible = false;
            // 
            // lblTotalDepartments
            // 
            this.lblTotalDepartments.AutoSize = true;
            this.lblTotalDepartments.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDepartments.Location = new System.Drawing.Point(12, 77);
            this.lblTotalDepartments.Name = "lblTotalDepartments";
            this.lblTotalDepartments.Size = new System.Drawing.Size(217, 32);
            this.lblTotalDepartments.TabIndex = 16;
            this.lblTotalDepartments.Text = "Total Departments";
            this.lblTotalDepartments.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(117)))));
            this.panel2.Controls.Add(this.lblTotalDoctorsValue);
            this.panel2.Controls.Add(this.lblTotalDoctorsInDepartment);
            this.panel2.Location = new System.Drawing.Point(827, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 121);
            this.panel2.TabIndex = 15;
            // 
            // lblTotalDoctorsValue
            // 
            this.lblTotalDoctorsValue.AutoSize = true;
            this.lblTotalDoctorsValue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDoctorsValue.Location = new System.Drawing.Point(7, 12);
            this.lblTotalDoctorsValue.Name = "lblTotalDoctorsValue";
            this.lblTotalDoctorsValue.Size = new System.Drawing.Size(148, 65);
            this.lblTotalDoctorsValue.TabIndex = 16;
            this.lblTotalDoctorsValue.Text = "[????]";
            this.lblTotalDoctorsValue.Visible = false;
            // 
            // lblTotalDoctorsInDepartment
            // 
            this.lblTotalDoctorsInDepartment.AutoSize = true;
            this.lblTotalDoctorsInDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDoctorsInDepartment.Location = new System.Drawing.Point(12, 77);
            this.lblTotalDoctorsInDepartment.Name = "lblTotalDoctorsInDepartment";
            this.lblTotalDoctorsInDepartment.Size = new System.Drawing.Size(305, 25);
            this.lblTotalDoctorsInDepartment.TabIndex = 16;
            this.lblTotalDoctorsInDepartment.Text = "Total Doctors in [????] Department";
            this.lblTotalDoctorsInDepartment.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(117)))));
            this.panel3.Controls.Add(this.lblTotalVisitsValue);
            this.panel3.Controls.Add(this.lblTotalVisitOfDepartment);
            this.panel3.Location = new System.Drawing.Point(827, 516);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 121);
            this.panel3.TabIndex = 15;
            // 
            // lblTotalVisitsValue
            // 
            this.lblTotalVisitsValue.AutoSize = true;
            this.lblTotalVisitsValue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVisitsValue.Location = new System.Drawing.Point(7, 12);
            this.lblTotalVisitsValue.Name = "lblTotalVisitsValue";
            this.lblTotalVisitsValue.Size = new System.Drawing.Size(148, 65);
            this.lblTotalVisitsValue.TabIndex = 16;
            this.lblTotalVisitsValue.Text = "[????]";
            this.lblTotalVisitsValue.Visible = false;
            // 
            // lblTotalVisitOfDepartment
            // 
            this.lblTotalVisitOfDepartment.AutoSize = true;
            this.lblTotalVisitOfDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVisitOfDepartment.Location = new System.Drawing.Point(12, 77);
            this.lblTotalVisitOfDepartment.Name = "lblTotalVisitOfDepartment";
            this.lblTotalVisitOfDepartment.Size = new System.Drawing.Size(285, 25);
            this.lblTotalVisitOfDepartment.TabIndex = 16;
            this.lblTotalVisitOfDepartment.Text = "Total Visits of [????] Department";
            this.lblTotalVisitOfDepartment.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(91)))));
            this.panel4.Controls.Add(this.pbRiyalSymbol);
            this.panel4.Controls.Add(this.lblTotalRevenueValue);
            this.panel4.Controls.Add(this.lblTotalRevenueOfDepartment);
            this.panel4.Location = new System.Drawing.Point(827, 662);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(460, 121);
            this.panel4.TabIndex = 15;
            // 
            // pbRiyalSymbol
            // 
            this.pbRiyalSymbol.Image = global::UI.Properties.Resources.Saudi_Riyal_Symbol;
            this.pbRiyalSymbol.Location = new System.Drawing.Point(17, 27);
            this.pbRiyalSymbol.Name = "pbRiyalSymbol";
            this.pbRiyalSymbol.Size = new System.Drawing.Size(42, 47);
            this.pbRiyalSymbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRiyalSymbol.TabIndex = 41;
            this.pbRiyalSymbol.TabStop = false;
            this.pbRiyalSymbol.Visible = false;
            // 
            // lblTotalRevenueValue
            // 
            this.lblTotalRevenueValue.AutoSize = true;
            this.lblTotalRevenueValue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenueValue.Location = new System.Drawing.Point(56, 15);
            this.lblTotalRevenueValue.Name = "lblTotalRevenueValue";
            this.lblTotalRevenueValue.Size = new System.Drawing.Size(148, 65);
            this.lblTotalRevenueValue.TabIndex = 16;
            this.lblTotalRevenueValue.Text = "[????]";
            this.lblTotalRevenueValue.Visible = false;
            // 
            // lblTotalRevenueOfDepartment
            // 
            this.lblTotalRevenueOfDepartment.AutoSize = true;
            this.lblTotalRevenueOfDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenueOfDepartment.Location = new System.Drawing.Point(12, 77);
            this.lblTotalRevenueOfDepartment.Name = "lblTotalRevenueOfDepartment";
            this.lblTotalRevenueOfDepartment.Size = new System.Drawing.Size(313, 25);
            this.lblTotalRevenueOfDepartment.TabIndex = 16;
            this.lblTotalRevenueOfDepartment.Text = "Total Revenue of [????] Department";
            this.lblTotalRevenueOfDepartment.Visible = false;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAddDepartment.BackgroundImage = global::UI.Properties.Resources.Add_NewV2;
            this.btnAddDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDepartment.FlatAppearance.BorderSize = 0;
            this.btnAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDepartment.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDepartment.Location = new System.Drawing.Point(42, 167);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(57, 50);
            this.btnAddDepartment.TabIndex = 16;
            this.btnAddDepartment.UseVisualStyleBackColor = false;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // frmDepartmentsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1329, 861);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDepartments);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblRecordsValue);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDepartmentsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDepartmentsManagement";
            this.Load += new System.EventHandler(this.frmDepartmentsManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.cmsDepartments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRiyalSymbol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.ContextMenuStrip cmsDepartments;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblRecordsValue;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalDepartmentsValue;
        private System.Windows.Forms.Label lblTotalDepartments;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalDoctorsValue;
        private System.Windows.Forms.Label lblTotalDoctorsInDepartment;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalVisitsValue;
        private System.Windows.Forms.Label lblTotalVisitOfDepartment;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalRevenueValue;
        private System.Windows.Forms.Label lblTotalRevenueOfDepartment;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.PictureBox pbRiyalSymbol;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewDepartment;
    }
}