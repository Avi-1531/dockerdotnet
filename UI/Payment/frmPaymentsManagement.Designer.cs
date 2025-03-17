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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.txtPageNumber = new System.Windows.Forms.TextBox();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.lblOfTotalPagesAndRows = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMostUsedPaymentMethodValue
            // 
            this.lblMostUsedPaymentMethodValue.AutoSize = true;
            this.lblMostUsedPaymentMethodValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostUsedPaymentMethodValue.Location = new System.Drawing.Point(9, 22);
            this.lblMostUsedPaymentMethodValue.Name = "lblMostUsedPaymentMethodValue";
            this.lblMostUsedPaymentMethodValue.Size = new System.Drawing.Size(100, 45);
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
            this.lblTotalPaymentsValue.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaymentsValue.Location = new System.Drawing.Point(7, 17);
            this.lblTotalPaymentsValue.Name = "lblTotalPaymentsValue";
            this.lblTotalPaymentsValue.Size = new System.Drawing.Size(114, 50);
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
            this.lblAverageAmountPerPaymentValue.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageAmountPerPaymentValue.Location = new System.Drawing.Point(7, 18);
            this.lblAverageAmountPerPaymentValue.Name = "lblAverageAmountPerPaymentValue";
            this.lblAverageAmountPerPaymentValue.Size = new System.Drawing.Size(114, 50);
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
            this.lblTotalPaymentsAmountValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaymentsAmountValue.Location = new System.Drawing.Point(9, 23);
            this.lblTotalPaymentsAmountValue.Name = "lblTotalPaymentsAmountValue";
            this.lblTotalPaymentsAmountValue.Size = new System.Drawing.Size(100, 45);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.Payments;
            this.pictureBox1.Location = new System.Drawing.Point(598, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dgvPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgvPayments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayments.ColumnHeadersHeight = 40;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayments.EnableHeadersVisualStyles = false;
            this.dgvPayments.Location = new System.Drawing.Point(42, 240);
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayments.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPayments.RowTemplate.Height = 35;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.ShowCellErrors = false;
            this.dgvPayments.ShowCellToolTips = false;
            this.dgvPayments.ShowEditingIcon = false;
            this.dgvPayments.ShowRowErrors = false;
            this.dgvPayments.Size = new System.Drawing.Size(937, 560);
            this.dgvPayments.TabIndex = 21;
            // 
            // txtPageNumber
            // 
            this.txtPageNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPageNumber.Enabled = false;
            this.txtPageNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPageNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtPageNumber.Location = new System.Drawing.Point(115, 812);
            this.txtPageNumber.Multiline = true;
            this.txtPageNumber.Name = "txtPageNumber";
            this.txtPageNumber.Size = new System.Drawing.Size(41, 25);
            this.txtPageNumber.TabIndex = 29;
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
            this.btnNextPage.Location = new System.Drawing.Point(78, 807);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(31, 34);
            this.btnNextPage.TabIndex = 27;
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
            this.btnPreviousPage.Location = new System.Drawing.Point(41, 807);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(31, 34);
            this.btnPreviousPage.TabIndex = 28;
            this.btnPreviousPage.UseVisualStyleBackColor = false;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // lblOfTotalPagesAndRows
            // 
            this.lblOfTotalPagesAndRows.AutoSize = true;
            this.lblOfTotalPagesAndRows.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfTotalPagesAndRows.Location = new System.Drawing.Point(162, 814);
            this.lblOfTotalPagesAndRows.Name = "lblOfTotalPagesAndRows";
            this.lblOfTotalPagesAndRows.Size = new System.Drawing.Size(101, 21);
            this.lblOfTotalPagesAndRows.TabIndex = 26;
            this.lblOfTotalPagesAndRows.Text = "of [????] (???)";
            // 
            // frmPaymentsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1329, 861);
            this.Controls.Add(this.txtPageNumber);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.lblOfTotalPagesAndRows);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvPayments);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPaymentsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.TextBox txtPageNumber;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Label lblOfTotalPagesAndRows;
    }
}