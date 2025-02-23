namespace UI.Users
{
    partial class frmUsersManagement
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
            this.lblRecordsValue = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.cmsUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowPersonInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowLoginHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangeUserRole = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangeToAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangeToDoctor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangeToReceptionist = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActivateOrDeactivate = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.ctrlUserInfoVertical1 = new UI.Users.Controls.ctrlUserInfoVertical();
            this.cmsUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // cmsUsers
            // 
            this.cmsUsers.BackColor = System.Drawing.SystemColors.Control;
            this.cmsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddNewUser,
            this.toolStripMenuItem2,
            this.tsmiShowUserInfo,
            this.tsmiShowPersonInfo,
            this.tsmiShowLoginHistory,
            this.tsmiChangePassword,
            this.tsmiChangeUserRole,
            this.tsmiActivateOrDeactivate});
            this.cmsUsers.Name = "cmsPerson";
            this.cmsUsers.Size = new System.Drawing.Size(242, 244);
            // 
            // tsmiAddNewUser
            // 
            this.tsmiAddNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tsmiAddNewUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiAddNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tsmiAddNewUser.Name = "tsmiAddNewUser";
            this.tsmiAddNewUser.Size = new System.Drawing.Size(241, 30);
            this.tsmiAddNewUser.Text = "Add New User";
            this.tsmiAddNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiAddNewUser.Click += new System.EventHandler(this.tsmiAddNewUser_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(241, 30);
            this.toolStripMenuItem2.Text = "Edit User";
            this.toolStripMenuItem2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem2.Click += new System.EventHandler(this.tsmiEditUser_Click);
            // 
            // tsmiShowUserInfo
            // 
            this.tsmiShowUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tsmiShowUserInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiShowUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tsmiShowUserInfo.Name = "tsmiShowUserInfo";
            this.tsmiShowUserInfo.Size = new System.Drawing.Size(241, 30);
            this.tsmiShowUserInfo.Text = "Show User Info";
            this.tsmiShowUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiShowUserInfo.Click += new System.EventHandler(this.tsmiShowUserInfo_Click);
            // 
            // tsmiShowPersonInfo
            // 
            this.tsmiShowPersonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tsmiShowPersonInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiShowPersonInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tsmiShowPersonInfo.Name = "tsmiShowPersonInfo";
            this.tsmiShowPersonInfo.Size = new System.Drawing.Size(241, 30);
            this.tsmiShowPersonInfo.Text = "Show Person Info";
            this.tsmiShowPersonInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiShowPersonInfo.Click += new System.EventHandler(this.tsmiShowPersonInfo_Click);
            // 
            // tsmiShowLoginHistory
            // 
            this.tsmiShowLoginHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tsmiShowLoginHistory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiShowLoginHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tsmiShowLoginHistory.Name = "tsmiShowLoginHistory";
            this.tsmiShowLoginHistory.Size = new System.Drawing.Size(241, 30);
            this.tsmiShowLoginHistory.Text = "Show Login History";
            this.tsmiShowLoginHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiShowLoginHistory.Click += new System.EventHandler(this.tsmiShowLoginHistory_Click);
            // 
            // tsmiChangePassword
            // 
            this.tsmiChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tsmiChangePassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tsmiChangePassword.Name = "tsmiChangePassword";
            this.tsmiChangePassword.Size = new System.Drawing.Size(241, 30);
            this.tsmiChangePassword.Text = "Change Password";
            this.tsmiChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiChangePassword.Click += new System.EventHandler(this.tsmiChangePassword_Click);
            // 
            // tsmiChangeUserRole
            // 
            this.tsmiChangeUserRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tsmiChangeUserRole.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChangeToAdmin,
            this.tsmiChangeToDoctor,
            this.tsmiChangeToReceptionist});
            this.tsmiChangeUserRole.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiChangeUserRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tsmiChangeUserRole.Name = "tsmiChangeUserRole";
            this.tsmiChangeUserRole.Size = new System.Drawing.Size(241, 30);
            this.tsmiChangeUserRole.Text = "Change User Role";
            this.tsmiChangeUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiChangeUserRole.Click += new System.EventHandler(this.tsmiChangeUserRole_Click);
            // 
            // tsmiChangeToAdmin
            // 
            this.tsmiChangeToAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tsmiChangeToAdmin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiChangeToAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tsmiChangeToAdmin.Name = "tsmiChangeToAdmin";
            this.tsmiChangeToAdmin.Size = new System.Drawing.Size(321, 30);
            this.tsmiChangeToAdmin.Text = "Change Role to Admin";
            this.tsmiChangeToAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiChangeToAdmin.Click += new System.EventHandler(this.tsmiChangeToAdmin_Click);
            // 
            // tsmiChangeToDoctor
            // 
            this.tsmiChangeToDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tsmiChangeToDoctor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiChangeToDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tsmiChangeToDoctor.Name = "tsmiChangeToDoctor";
            this.tsmiChangeToDoctor.Size = new System.Drawing.Size(321, 30);
            this.tsmiChangeToDoctor.Text = "Change Role to Doctor";
            this.tsmiChangeToDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiChangeToDoctor.Click += new System.EventHandler(this.tsmiChangeToDoctor_Click);
            // 
            // tsmiChangeToReceptionist
            // 
            this.tsmiChangeToReceptionist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tsmiChangeToReceptionist.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiChangeToReceptionist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tsmiChangeToReceptionist.Name = "tsmiChangeToReceptionist";
            this.tsmiChangeToReceptionist.Size = new System.Drawing.Size(321, 30);
            this.tsmiChangeToReceptionist.Text = "Change Role To Receptionist";
            this.tsmiChangeToReceptionist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiChangeToReceptionist.Click += new System.EventHandler(this.tsmiChangeToReceptionist_Click);
            // 
            // tsmiActivateOrDeactivate
            // 
            this.tsmiActivateOrDeactivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tsmiActivateOrDeactivate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiActivateOrDeactivate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tsmiActivateOrDeactivate.Name = "tsmiActivateOrDeactivate";
            this.tsmiActivateOrDeactivate.Size = new System.Drawing.Size(241, 30);
            this.tsmiActivateOrDeactivate.Text = "Activate User";
            this.tsmiActivateOrDeactivate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiActivateOrDeactivate.Click += new System.EventHandler(this.tsmiActivateOrDeactivate_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeight = 40;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.ContextMenuStrip = this.cmsUsers;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.Location = new System.Drawing.Point(42, 240);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsers.RowTemplate.Height = 35;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.ShowCellErrors = false;
            this.dgvUsers.ShowCellToolTips = false;
            this.dgvUsers.ShowEditingIcon = false;
            this.dgvUsers.ShowRowErrors = false;
            this.dgvUsers.Size = new System.Drawing.Size(767, 560);
            this.dgvUsers.TabIndex = 21;
            this.dgvUsers.SelectionChanged += new System.EventHandler(this.dgvUsers_SelectionChanged);
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
            "User ID",
            "Person ID",
            "User Name",
            "Role",
            "Is Active"});
            this.cbFilter.Location = new System.Drawing.Point(140, 197);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(245, 33);
            this.cbFilter.TabIndex = 28;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(43, 198);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(91, 30);
            this.lblFilterBy.TabIndex = 27;
            this.lblFilterBy.Text = "Filter By:";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtSearch.Location = new System.Drawing.Point(391, 196);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(245, 34);
            this.txtSearch.TabIndex = 30;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // cbRole
            // 
            this.cbRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.DropDownWidth = 245;
            this.cbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.IntegralHeight = false;
            this.cbRole.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Receptionist"});
            this.cbRole.Location = new System.Drawing.Point(391, 197);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(245, 33);
            this.cbRole.TabIndex = 29;
            this.cbRole.Visible = false;
            this.cbRole.SelectedIndexChanged += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(512, 124);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(305, 40);
            this.lblHeader.TabIndex = 31;
            this.lblHeader.Text = "USERS MANAGEMENT";
            // 
            // cbIsActive
            // 
            this.cbIsActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsActive.DropDownWidth = 245;
            this.cbIsActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbIsActive.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.IntegralHeight = false;
            this.cbIsActive.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(391, 196);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(245, 33);
            this.cbIsActive.TabIndex = 33;
            this.cbIsActive.Visible = false;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.people;
            this.pictureBox1.Location = new System.Drawing.Point(598, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAddUser.BackgroundImage = global::UI.Properties.Resources.add_person;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(1230, 184);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(57, 50);
            this.btnAddUser.TabIndex = 26;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // ctrlUserInfoVertical1
            // 
            this.ctrlUserInfoVertical1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ctrlUserInfoVertical1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlUserInfoVertical1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ctrlUserInfoVertical1.Location = new System.Drawing.Point(816, 240);
            this.ctrlUserInfoVertical1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlUserInfoVertical1.Name = "ctrlUserInfoVertical1";
            this.ctrlUserInfoVertical1.Size = new System.Drawing.Size(471, 560);
            this.ctrlUserInfoVertical1.TabIndex = 34;
            // 
            // frmUsersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1329, 861);
            this.Controls.Add(this.ctrlUserInfoVertical1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblRecordsValue);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.cbRole);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUsersManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsersManagement";
            this.Load += new System.EventHandler(this.frmUsersManagement_Load);
            this.cmsUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblRecordsValue;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.ContextMenuStrip cmsUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox cbIsActive;
        private Controls.ctrlUserInfoVertical ctrlUserInfoVertical1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiActivateOrDeactivate;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowPersonInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeUserRole;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeToAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeToDoctor;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeToReceptionist;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowLoginHistory;
    }
}