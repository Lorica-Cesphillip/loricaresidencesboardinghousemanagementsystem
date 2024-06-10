namespace Lorica_Residences_Rental_Management_System.Forms
{
    partial class RoomsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ImageUploadBTN = new System.Windows.Forms.Button();
            this.ImagePathTXT = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RoomNoTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeleteRoomBTN = new System.Windows.Forms.Button();
            this.EditRoomBTN = new System.Windows.Forms.Button();
            this.AddRoomBTN = new System.Windows.Forms.Button();
            this.RoomGridView = new System.Windows.Forms.DataGridView();
            this.RoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.DescriptionTXT = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.DescriptionTXT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ImageUploadBTN);
            this.panel1.Controls.Add(this.ImagePathTXT);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.RoomNoTXT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 189);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(136)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(149, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 36);
            this.label1.TabIndex = 28;
            this.label1.Text = "Room Management";
            // 
            // ImageUploadBTN
            // 
            this.ImageUploadBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImageUploadBTN.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageUploadBTN.Location = new System.Drawing.Point(490, 90);
            this.ImageUploadBTN.Name = "ImageUploadBTN";
            this.ImageUploadBTN.Size = new System.Drawing.Size(122, 23);
            this.ImageUploadBTN.TabIndex = 27;
            this.ImageUploadBTN.Text = "Upload an Image";
            this.ImageUploadBTN.UseVisualStyleBackColor = true;
            // 
            // ImagePathTXT
            // 
            this.ImagePathTXT.AutoSize = true;
            this.ImagePathTXT.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImagePathTXT.Location = new System.Drawing.Point(335, 93);
            this.ImagePathTXT.Name = "ImagePathTXT";
            this.ImagePathTXT.Size = new System.Drawing.Size(130, 16);
            this.ImagePathTXT.TabIndex = 26;
            this.ImagePathTXT.Text = "<<upload an image>>";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(226, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Room Image";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Description";
            // 
            // RoomNoTXT
            // 
            this.RoomNoTXT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNoTXT.Location = new System.Drawing.Point(132, 87);
            this.RoomNoTXT.Name = "RoomNoTXT";
            this.RoomNoTXT.Size = new System.Drawing.Size(88, 26);
            this.RoomNoTXT.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Room Number";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(209)))), ((int)(((byte)(207)))));
            this.panel2.Controls.Add(this.DeleteRoomBTN);
            this.panel2.Controls.Add(this.EditRoomBTN);
            this.panel2.Controls.Add(this.AddRoomBTN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(622, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 189);
            this.panel2.TabIndex = 1;
            // 
            // DeleteRoomBTN
            // 
            this.DeleteRoomBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteRoomBTN.FlatAppearance.BorderSize = 0;
            this.DeleteRoomBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRoomBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRoomBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(136)))), ((int)(((byte)(149)))));
            this.DeleteRoomBTN.Image = ((System.Drawing.Image)(resources.GetObject("DeleteRoomBTN.Image")));
            this.DeleteRoomBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteRoomBTN.Location = new System.Drawing.Point(0, 112);
            this.DeleteRoomBTN.Name = "DeleteRoomBTN";
            this.DeleteRoomBTN.Size = new System.Drawing.Size(307, 50);
            this.DeleteRoomBTN.TabIndex = 2;
            this.DeleteRoomBTN.Text = "Remove Boarding Room";
            this.DeleteRoomBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteRoomBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteRoomBTN.UseVisualStyleBackColor = true;
            this.DeleteRoomBTN.Click += new System.EventHandler(this.DeleteRoomBTN_Click);
            // 
            // EditRoomBTN
            // 
            this.EditRoomBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditRoomBTN.FlatAppearance.BorderSize = 0;
            this.EditRoomBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditRoomBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditRoomBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(136)))), ((int)(((byte)(149)))));
            this.EditRoomBTN.Image = ((System.Drawing.Image)(resources.GetObject("EditRoomBTN.Image")));
            this.EditRoomBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditRoomBTN.Location = new System.Drawing.Point(0, 62);
            this.EditRoomBTN.Name = "EditRoomBTN";
            this.EditRoomBTN.Size = new System.Drawing.Size(307, 50);
            this.EditRoomBTN.TabIndex = 1;
            this.EditRoomBTN.Text = "Edit Boarding Room";
            this.EditRoomBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditRoomBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditRoomBTN.UseVisualStyleBackColor = true;
            this.EditRoomBTN.Click += new System.EventHandler(this.EditRoomBTN_Click);
            // 
            // AddRoomBTN
            // 
            this.AddRoomBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddRoomBTN.FlatAppearance.BorderSize = 0;
            this.AddRoomBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRoomBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRoomBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(136)))), ((int)(((byte)(149)))));
            this.AddRoomBTN.Image = ((System.Drawing.Image)(resources.GetObject("AddRoomBTN.Image")));
            this.AddRoomBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddRoomBTN.Location = new System.Drawing.Point(0, 0);
            this.AddRoomBTN.Name = "AddRoomBTN";
            this.AddRoomBTN.Size = new System.Drawing.Size(307, 62);
            this.AddRoomBTN.TabIndex = 0;
            this.AddRoomBTN.Text = "Add New Boarding Room";
            this.AddRoomBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddRoomBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddRoomBTN.UseVisualStyleBackColor = true;
            this.AddRoomBTN.Click += new System.EventHandler(this.AddRoomBTN_Click);
            // 
            // RoomGridView
            // 
            this.RoomGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.RoomGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomId,
            this.RoomNo,
            this.Description,
            this.Image});
            this.RoomGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomGridView.Location = new System.Drawing.Point(0, 189);
            this.RoomGridView.Name = "RoomGridView";
            this.RoomGridView.Size = new System.Drawing.Size(929, 553);
            this.RoomGridView.TabIndex = 1;
            this.RoomGridView.SelectionChanged += new System.EventHandler(this.RoomGridView_SelectionChanged);
            // 
            // RoomId
            // 
            this.RoomId.HeaderText = "Room Id";
            this.RoomId.Name = "RoomId";
            // 
            // RoomNo
            // 
            this.RoomNo.HeaderText = "Room Number";
            this.RoomNo.Name = "RoomNo";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 480;
            // 
            // Image
            // 
            this.Image.HeaderText = "Room Image";
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Image.Width = 200;
            // 
            // DescriptionTXT
            // 
            this.DescriptionTXT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTXT.Location = new System.Drawing.Point(132, 117);
            this.DescriptionTXT.Name = "DescriptionTXT";
            this.DescriptionTXT.Size = new System.Drawing.Size(480, 66);
            this.DescriptionTXT.TabIndex = 29;
            this.DescriptionTXT.Text = "";
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(929, 742);
            this.Controls.Add(this.RoomGridView);
            this.Controls.Add(this.panel1);
            this.Name = "RoomsForm";
            this.Text = "RoomsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView RoomGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DeleteRoomBTN;
        private System.Windows.Forms.Button EditRoomBTN;
        private System.Windows.Forms.Button AddRoomBTN;
        private System.Windows.Forms.Button ImageUploadBTN;
        private System.Windows.Forms.Label ImagePathTXT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RoomNoTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.RichTextBox DescriptionTXT;
    }
}