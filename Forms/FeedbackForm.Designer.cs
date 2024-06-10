namespace Lorica_Residences_Rental_Management_System.Forms
{
    partial class FeedbackForm
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
            this.AssignBedGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TenantNameTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AssignaTenantBTN = new System.Windows.Forms.Button();
            this.BedNumberTXT = new System.Windows.Forms.TextBox();
            this.RoomNoTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ReassignTenantBTN = new System.Windows.Forms.Button();
            this.FeedbackMessageTXT = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ReplyTXT = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FeedbackId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateSent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AssignBedGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AssignBedGridView
            // 
            this.AssignBedGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AssignBedGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.AssignBedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssignBedGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FeedbackId,
            this.TenantName,
            this.DateSent,
            this.Message,
            this.Reply,
            this.Status});
            this.AssignBedGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssignBedGridView.Location = new System.Drawing.Point(0, 339);
            this.AssignBedGridView.Name = "AssignBedGridView";
            this.AssignBedGridView.Size = new System.Drawing.Size(929, 403);
            this.AssignBedGridView.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ReplyTXT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FeedbackMessageTXT);
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
            this.panel1.Size = new System.Drawing.Size(929, 339);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(136)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(115, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 36);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tenant Feedback";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Tenant Name";
            // 
            // TenantNameTXT
            // 
            this.TenantNameTXT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenantNameTXT.Location = new System.Drawing.Point(416, 97);
            this.TenantNameTXT.Name = "TenantNameTXT";
            this.TenantNameTXT.Size = new System.Drawing.Size(200, 26);
            this.TenantNameTXT.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Status";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(209)))), ((int)(((byte)(207)))));
            this.panel2.Controls.Add(this.ReassignTenantBTN);
            this.panel2.Controls.Add(this.AssignaTenantBTN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(622, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 339);
            this.panel2.TabIndex = 1;
            // 
            // AssignaTenantBTN
            // 
            this.AssignaTenantBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.AssignaTenantBTN.FlatAppearance.BorderSize = 0;
            this.AssignaTenantBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssignaTenantBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignaTenantBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(136)))), ((int)(((byte)(149)))));
            this.AssignaTenantBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AssignaTenantBTN.Location = new System.Drawing.Point(0, 0);
            this.AssignaTenantBTN.Name = "AssignaTenantBTN";
            this.AssignaTenantBTN.Size = new System.Drawing.Size(307, 50);
            this.AssignaTenantBTN.TabIndex = 0;
            this.AssignaTenantBTN.Text = "View Feedback";
            this.AssignaTenantBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AssignaTenantBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AssignaTenantBTN.UseVisualStyleBackColor = true;
            // 
            // BedNumberTXT
            // 
            this.BedNumberTXT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedNumberTXT.Location = new System.Drawing.Point(143, 65);
            this.BedNumberTXT.Name = "BedNumberTXT";
            this.BedNumberTXT.ReadOnly = true;
            this.BedNumberTXT.Size = new System.Drawing.Size(473, 26);
            this.BedNumberTXT.TabIndex = 29;
            // 
            // RoomNoTXT
            // 
            this.RoomNoTXT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNoTXT.Location = new System.Drawing.Point(143, 97);
            this.RoomNoTXT.Name = "RoomNoTXT";
            this.RoomNoTXT.ReadOnly = true;
            this.RoomNoTXT.Size = new System.Drawing.Size(210, 26);
            this.RoomNoTXT.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Date Sent";
            // 
            // ReassignTenantBTN
            // 
            this.ReassignTenantBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReassignTenantBTN.FlatAppearance.BorderSize = 0;
            this.ReassignTenantBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReassignTenantBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReassignTenantBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(136)))), ((int)(((byte)(149)))));
            this.ReassignTenantBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReassignTenantBTN.Location = new System.Drawing.Point(0, 50);
            this.ReassignTenantBTN.Name = "ReassignTenantBTN";
            this.ReassignTenantBTN.Size = new System.Drawing.Size(307, 50);
            this.ReassignTenantBTN.TabIndex = 1;
            this.ReassignTenantBTN.Text = "Send Reply";
            this.ReassignTenantBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReassignTenantBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReassignTenantBTN.UseVisualStyleBackColor = true;
            // 
            // FeedbackMessageTXT
            // 
            this.FeedbackMessageTXT.Location = new System.Drawing.Point(12, 173);
            this.FeedbackMessageTXT.Name = "FeedbackMessageTXT";
            this.FeedbackMessageTXT.ReadOnly = true;
            this.FeedbackMessageTXT.Size = new System.Drawing.Size(300, 160);
            this.FeedbackMessageTXT.TabIndex = 30;
            this.FeedbackMessageTXT.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Feedback Message";
            // 
            // ReplyTXT
            // 
            this.ReplyTXT.Location = new System.Drawing.Point(316, 173);
            this.ReplyTXT.Name = "ReplyTXT";
            this.ReplyTXT.ReadOnly = true;
            this.ReplyTXT.Size = new System.Drawing.Size(300, 160);
            this.ReplyTXT.TabIndex = 32;
            this.ReplyTXT.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Your Reply";
            // 
            // FeedbackId
            // 
            this.FeedbackId.FillWeight = 90F;
            this.FeedbackId.HeaderText = "Feedback Id";
            this.FeedbackId.Name = "FeedbackId";
            this.FeedbackId.ReadOnly = true;
            // 
            // TenantName
            // 
            this.TenantName.FillWeight = 150F;
            this.TenantName.HeaderText = "Tenant Name";
            this.TenantName.Name = "TenantName";
            this.TenantName.ReadOnly = true;
            // 
            // DateSent
            // 
            this.DateSent.HeaderText = "Date Sent";
            this.DateSent.Name = "DateSent";
            this.DateSent.ReadOnly = true;
            // 
            // Message
            // 
            this.Message.FillWeight = 250F;
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            // 
            // Reply
            // 
            this.Reply.FillWeight = 250F;
            this.Reply.HeaderText = "Owner Reply";
            this.Reply.Name = "Reply";
            this.Reply.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.FillWeight = 89F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(929, 742);
            this.Controls.Add(this.AssignBedGridView);
            this.Controls.Add(this.panel1);
            this.Name = "FeedbackForm";
            this.Text = "FeedbackForm";
            ((System.ComponentModel.ISupportInitialize)(this.AssignBedGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AssignBedGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TenantNameTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AssignaTenantBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox FeedbackMessageTXT;
        private System.Windows.Forms.TextBox BedNumberTXT;
        private System.Windows.Forms.TextBox RoomNoTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ReassignTenantBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox ReplyTXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeedbackId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateSent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reply;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}