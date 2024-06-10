namespace Lorica_Residences_Rental_Management_System.Forms
{
    partial class BedAssignmentForm
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BedAssignmentForm));
            this.AssignBedGridView = new System.Windows.Forms.DataGridView();
            this.assignId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeleteAssignmentBTN = new System.Windows.Forms.Button();
            this.ReassignTenantBTN = new System.Windows.Forms.Button();
            this.AssignaTenantBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AssignedDTPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.BedNumberTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RoomNoTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TenantNameTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AssignBedGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AssignBedGridView
            // 
            this.AssignBedGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AssignBedGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.AssignBedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssignBedGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assignId,
            this.TenantName,
            this.RoomNo,
            this.BedNo,
            this.DateStart,
            this.DueDate});
            this.AssignBedGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssignBedGridView.Location = new System.Drawing.Point(0, 189);
            this.AssignBedGridView.Name = "AssignBedGridView";
            this.AssignBedGridView.Size = new System.Drawing.Size(929, 553);
            this.AssignBedGridView.TabIndex = 5;
            // 
            // assignId
            // 
            this.assignId.HeaderText = "Assignment ID";
            this.assignId.Name = "assignId";
            this.assignId.ReadOnly = true;
            // 
            // TenantName
            // 
            this.TenantName.HeaderText = "Tenant Name";
            this.TenantName.Name = "TenantName";
            this.TenantName.ReadOnly = true;
            // 
            // RoomNo
            // 
            this.RoomNo.HeaderText = "Room Number";
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.ReadOnly = true;
            // 
            // BedNo
            // 
            this.BedNo.HeaderText = "Bed Number";
            this.BedNo.Name = "BedNo";
            this.BedNo.ReadOnly = true;
            // 
            // DateStart
            // 
            this.DateStart.HeaderText = "Start Date";
            this.DateStart.Name = "DateStart";
            this.DateStart.ReadOnly = true;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "Due Date";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(209)))), ((int)(((byte)(207)))));
            this.panel2.Controls.Add(this.DeleteAssignmentBTN);
            this.panel2.Controls.Add(this.ReassignTenantBTN);
            this.panel2.Controls.Add(this.AssignaTenantBTN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(622, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 189);
            this.panel2.TabIndex = 1;
            // 
            // DeleteAssignmentBTN
            // 
            this.DeleteAssignmentBTN.FlatAppearance.BorderSize = 0;
            this.DeleteAssignmentBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAssignmentBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAssignmentBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(136)))), ((int)(((byte)(149)))));
            this.DeleteAssignmentBTN.Image = ((System.Drawing.Image)(resources.GetObject("DeleteAssignmentBTN.Image")));
            this.DeleteAssignmentBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteAssignmentBTN.Location = new System.Drawing.Point(0, 100);
            this.DeleteAssignmentBTN.Name = "DeleteAssignmentBTN";
            this.DeleteAssignmentBTN.Size = new System.Drawing.Size(307, 50);
            this.DeleteAssignmentBTN.TabIndex = 2;
            this.DeleteAssignmentBTN.Text = "Remove Assignment";
            this.DeleteAssignmentBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteAssignmentBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteAssignmentBTN.UseVisualStyleBackColor = true;
            this.DeleteAssignmentBTN.Click += new System.EventHandler(this.DeleteAssignmentBTN_Click);
            // 
            // ReassignTenantBTN
            // 
            this.ReassignTenantBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReassignTenantBTN.FlatAppearance.BorderSize = 0;
            this.ReassignTenantBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReassignTenantBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReassignTenantBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(136)))), ((int)(((byte)(149)))));
            this.ReassignTenantBTN.Image = ((System.Drawing.Image)(resources.GetObject("ReassignTenantBTN.Image")));
            this.ReassignTenantBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReassignTenantBTN.Location = new System.Drawing.Point(0, 50);
            this.ReassignTenantBTN.Name = "ReassignTenantBTN";
            this.ReassignTenantBTN.Size = new System.Drawing.Size(307, 50);
            this.ReassignTenantBTN.TabIndex = 1;
            this.ReassignTenantBTN.Text = "Reassign a Tenant";
            this.ReassignTenantBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReassignTenantBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReassignTenantBTN.UseVisualStyleBackColor = true;
            this.ReassignTenantBTN.Click += new System.EventHandler(this.ReassignTenantBTN_Click);
            // 
            // AssignaTenantBTN
            // 
            this.AssignaTenantBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.AssignaTenantBTN.FlatAppearance.BorderSize = 0;
            this.AssignaTenantBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssignaTenantBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignaTenantBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(136)))), ((int)(((byte)(149)))));
            this.AssignaTenantBTN.Image = ((System.Drawing.Image)(resources.GetObject("AssignaTenantBTN.Image")));
            this.AssignaTenantBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AssignaTenantBTN.Location = new System.Drawing.Point(0, 0);
            this.AssignaTenantBTN.Name = "AssignaTenantBTN";
            this.AssignaTenantBTN.Size = new System.Drawing.Size(307, 50);
            this.AssignaTenantBTN.TabIndex = 0;
            this.AssignaTenantBTN.Text = "Assign a New Bed";
            this.AssignaTenantBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AssignaTenantBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AssignaTenantBTN.UseVisualStyleBackColor = true;
            this.AssignaTenantBTN.Click += new System.EventHandler(this.AssignaTenantBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.AssignedDTPicker);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BedNumberTXT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.RoomNoTXT);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TenantNameTXT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 189);
            this.panel1.TabIndex = 4;
            // 
            // AssignedDTPicker
            // 
            this.AssignedDTPicker.CustomFormat = "yyyy-mm-dd";
            this.AssignedDTPicker.Location = new System.Drawing.Point(411, 97);
            this.AssignedDTPicker.MinDate = new System.DateTime(2024, 6, 6, 17, 22, 9, 0);
            this.AssignedDTPicker.Name = "AssignedDTPicker";
            this.AssignedDTPicker.Size = new System.Drawing.Size(200, 26);
            this.AssignedDTPicker.TabIndex = 32;
            this.AssignedDTPicker.Value = new System.DateTime(2024, 6, 6, 17, 22, 9, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Start Date";
            // 
            // BedNumberTXT
            // 
            this.BedNumberTXT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedNumberTXT.Location = new System.Drawing.Point(143, 65);
            this.BedNumberTXT.Name = "BedNumberTXT";
            this.BedNumberTXT.Size = new System.Drawing.Size(146, 26);
            this.BedNumberTXT.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(136)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(149, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 36);
            this.label1.TabIndex = 28;
            this.label1.Text = "Assignment of Beds";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Bed Number";
            // 
            // RoomNoTXT
            // 
            this.RoomNoTXT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNoTXT.Location = new System.Drawing.Point(143, 97);
            this.RoomNoTXT.Name = "RoomNoTXT";
            this.RoomNoTXT.Size = new System.Drawing.Size(146, 26);
            this.RoomNoTXT.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Room Number";
            // 
            // TenantNameTXT
            // 
            this.TenantNameTXT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenantNameTXT.Location = new System.Drawing.Point(411, 62);
            this.TenantNameTXT.Name = "TenantNameTXT";
            this.TenantNameTXT.Size = new System.Drawing.Size(200, 26);
            this.TenantNameTXT.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tenant Name";
            // 
            // BedAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(929, 742);
            this.Controls.Add(this.AssignBedGridView);
            this.Controls.Add(this.panel1);
            this.Name = "BedAssignmentForm";
            this.Text = "BedAssignmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.AssignBedGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AssignBedGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DeleteAssignmentBTN;
        private System.Windows.Forms.Button ReassignTenantBTN;
        private System.Windows.Forms.Button AssignaTenantBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BedNumberTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RoomNoTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TenantNameTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker AssignedDTPicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
    }
}