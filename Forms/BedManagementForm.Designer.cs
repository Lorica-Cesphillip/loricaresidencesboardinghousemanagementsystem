namespace Lorica_Residences_Rental_Management_System.Forms
{
    partial class BedManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BedManagementForm));
            this.BedGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.BedIdTXT = new System.Windows.Forms.TextBox();
            this.NoofBedsNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.MonthlyRentTXT = new System.Windows.Forms.TextBox();
            this.DailyRentTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RoomNoTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeleteBedBTN = new System.Windows.Forms.Button();
            this.EditBEdDetailsBTN = new System.Windows.Forms.Button();
            this.AddBedBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BedGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoofBedsNum)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BedGridView
            // 
            this.BedGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BedGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.BedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BedGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.RoomNo,
            this.BedNumber,
            this.DayRent,
            this.MonthRent,
            this.BedStatus});
            this.BedGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BedGridView.Location = new System.Drawing.Point(0, 189);
            this.BedGridView.Name = "BedGridView";
            this.BedGridView.Size = new System.Drawing.Size(929, 553);
            this.BedGridView.TabIndex = 3;
            this.BedGridView.SelectionChanged += new System.EventHandler(this.BedGridView_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "Bed Id";
            this.id.Name = "id";
            // 
            // RoomNo
            // 
            this.RoomNo.HeaderText = "Room Number";
            this.RoomNo.Name = "RoomNo";
            // 
            // BedNumber
            // 
            this.BedNumber.HeaderText = "Bed Number";
            this.BedNumber.Name = "BedNumber";
            // 
            // DayRent
            // 
            this.DayRent.HeaderText = "Daily Rent";
            this.DayRent.Name = "DayRent";
            // 
            // MonthRent
            // 
            this.MonthRent.HeaderText = "Monthly Rent";
            this.MonthRent.Name = "MonthRent";
            // 
            // BedStatus
            // 
            this.BedStatus.HeaderText = "Bed Status";
            this.BedStatus.Name = "BedStatus";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BedIdTXT);
            this.panel1.Controls.Add(this.NoofBedsNum);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.MonthlyRentTXT);
            this.panel1.Controls.Add(this.DailyRentTXT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.RoomNoTXT);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 189);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Bed ID";
            // 
            // BedIdTXT
            // 
            this.BedIdTXT.Enabled = false;
            this.BedIdTXT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedIdTXT.Location = new System.Drawing.Point(143, 104);
            this.BedIdTXT.Name = "BedIdTXT";
            this.BedIdTXT.Size = new System.Drawing.Size(173, 26);
            this.BedIdTXT.TabIndex = 33;
            // 
            // NoofBedsNum
            // 
            this.NoofBedsNum.Location = new System.Drawing.Point(143, 74);
            this.NoofBedsNum.Name = "NoofBedsNum";
            this.NoofBedsNum.Size = new System.Drawing.Size(173, 26);
            this.NoofBedsNum.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Monthly Rent";
            // 
            // MonthlyRentTXT
            // 
            this.MonthlyRentTXT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlyRentTXT.Location = new System.Drawing.Point(435, 106);
            this.MonthlyRentTXT.Name = "MonthlyRentTXT";
            this.MonthlyRentTXT.Size = new System.Drawing.Size(173, 26);
            this.MonthlyRentTXT.TabIndex = 30;
            // 
            // DailyRentTXT
            // 
            this.DailyRentTXT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyRentTXT.Location = new System.Drawing.Point(435, 74);
            this.DailyRentTXT.Name = "DailyRentTXT";
            this.DailyRentTXT.Size = new System.Drawing.Size(173, 26);
            this.DailyRentTXT.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(136)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(149, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 36);
            this.label1.TabIndex = 28;
            this.label1.Text = "Bed Management";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(322, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Daily Rent";
            // 
            // RoomNoTXT
            // 
            this.RoomNoTXT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNoTXT.Location = new System.Drawing.Point(143, 136);
            this.RoomNoTXT.Name = "RoomNoTXT";
            this.RoomNoTXT.Size = new System.Drawing.Size(173, 26);
            this.RoomNoTXT.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Room Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Number of Beds";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(209)))), ((int)(((byte)(207)))));
            this.panel2.Controls.Add(this.DeleteBedBTN);
            this.panel2.Controls.Add(this.EditBEdDetailsBTN);
            this.panel2.Controls.Add(this.AddBedBTN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(622, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 189);
            this.panel2.TabIndex = 1;
            // 
            // DeleteBedBTN
            // 
            this.DeleteBedBTN.FlatAppearance.BorderSize = 0;
            this.DeleteBedBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBedBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBedBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(136)))), ((int)(((byte)(149)))));
            this.DeleteBedBTN.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBedBTN.Image")));
            this.DeleteBedBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteBedBTN.Location = new System.Drawing.Point(0, 100);
            this.DeleteBedBTN.Name = "DeleteBedBTN";
            this.DeleteBedBTN.Size = new System.Drawing.Size(307, 50);
            this.DeleteBedBTN.TabIndex = 2;
            this.DeleteBedBTN.Text = "Remove a Bed";
            this.DeleteBedBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteBedBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteBedBTN.UseVisualStyleBackColor = true;
            this.DeleteBedBTN.Click += new System.EventHandler(this.DeleteBedBTN_Click);
            // 
            // EditBEdDetailsBTN
            // 
            this.EditBEdDetailsBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditBEdDetailsBTN.FlatAppearance.BorderSize = 0;
            this.EditBEdDetailsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBEdDetailsBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBEdDetailsBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(136)))), ((int)(((byte)(149)))));
            this.EditBEdDetailsBTN.Image = ((System.Drawing.Image)(resources.GetObject("EditBEdDetailsBTN.Image")));
            this.EditBEdDetailsBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditBEdDetailsBTN.Location = new System.Drawing.Point(0, 50);
            this.EditBEdDetailsBTN.Name = "EditBEdDetailsBTN";
            this.EditBEdDetailsBTN.Size = new System.Drawing.Size(307, 50);
            this.EditBEdDetailsBTN.TabIndex = 1;
            this.EditBEdDetailsBTN.Text = "Edit Bed Details";
            this.EditBEdDetailsBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditBEdDetailsBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditBEdDetailsBTN.UseVisualStyleBackColor = true;
            this.EditBEdDetailsBTN.Click += new System.EventHandler(this.EditBEdDetailsBTN_Click);
            // 
            // AddBedBTN
            // 
            this.AddBedBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddBedBTN.FlatAppearance.BorderSize = 0;
            this.AddBedBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBedBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBedBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(136)))), ((int)(((byte)(149)))));
            this.AddBedBTN.Image = ((System.Drawing.Image)(resources.GetObject("AddBedBTN.Image")));
            this.AddBedBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBedBTN.Location = new System.Drawing.Point(0, 0);
            this.AddBedBTN.Name = "AddBedBTN";
            this.AddBedBTN.Size = new System.Drawing.Size(307, 50);
            this.AddBedBTN.TabIndex = 0;
            this.AddBedBTN.Text = "Add New Bed";
            this.AddBedBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBedBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBedBTN.UseVisualStyleBackColor = true;
            this.AddBedBTN.Click += new System.EventHandler(this.AddBedBTN_Click);
            // 
            // BedManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(929, 742);
            this.Controls.Add(this.BedGridView);
            this.Controls.Add(this.panel1);
            this.Name = "BedManagementForm";
            this.Text = "BedManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.BedGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoofBedsNum)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BedGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RoomNoTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DeleteBedBTN;
        private System.Windows.Forms.Button EditBEdDetailsBTN;
        private System.Windows.Forms.Button AddBedBTN;
        private System.Windows.Forms.TextBox MonthlyRentTXT;
        private System.Windows.Forms.TextBox DailyRentTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NoofBedsNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BedIdTXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedStatus;
    }
}