namespace Lorica_Residences_Rental_Management_System.Forms
{
    partial class TenantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TenantForm));
            this.TenantGridView = new System.Windows.Forms.DataGridView();
            this.tenant_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfileImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ValidDocuments = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UploadPDFBTN = new System.Windows.Forms.Button();
            this.ImageUploadBTN = new System.Windows.Forms.Button();
            this.DocumentTXT = new System.Windows.Forms.Label();
            this.ImagePathTXT = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ContactTXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EmailTXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddressTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GenderTXT = new System.Windows.Forms.TextBox();
            this.MNameTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FNameTXT = new System.Windows.Forms.TextBox();
            this.LNameTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.VerifyTenantBTN = new System.Windows.Forms.Button();
            this.RemoveTenantBTN = new System.Windows.Forms.Button();
            this.EditTenantBTN = new System.Windows.Forms.Button();
            this.AddTenantBTN = new System.Windows.Forms.Button();
            this.UploadImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.UploadDocumentDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.TenantGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TenantGridView
            // 
            this.TenantGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.TenantGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TenantGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenant_id,
            this.TenantName,
            this.HomeAddress,
            this.eMail,
            this.contact_no,
            this.Gender,
            this.ProfileImage,
            this.ValidDocuments});
            this.TenantGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TenantGridView.Location = new System.Drawing.Point(0, 306);
            this.TenantGridView.Name = "TenantGridView";
            this.TenantGridView.ReadOnly = true;
            this.TenantGridView.Size = new System.Drawing.Size(929, 436);
            this.TenantGridView.TabIndex = 0;
            this.TenantGridView.SelectionChanged += new System.EventHandler(this.TenantGridView_SelectionChanged);
            // 
            // tenant_id
            // 
            this.tenant_id.HeaderText = "Tenant Id";
            this.tenant_id.Name = "tenant_id";
            this.tenant_id.ReadOnly = true;
            this.tenant_id.Width = 75;
            // 
            // TenantName
            // 
            this.TenantName.HeaderText = "Tenant Name (Last, First, Middle)";
            this.TenantName.Name = "TenantName";
            this.TenantName.ReadOnly = true;
            this.TenantName.Width = 140;
            // 
            // HomeAddress
            // 
            this.HomeAddress.HeaderText = "Complete Address";
            this.HomeAddress.Name = "HomeAddress";
            this.HomeAddress.ReadOnly = true;
            this.HomeAddress.Width = 182;
            // 
            // eMail
            // 
            this.eMail.HeaderText = "Email";
            this.eMail.Name = "eMail";
            this.eMail.ReadOnly = true;
            this.eMail.Width = 114;
            // 
            // contact_no
            // 
            this.contact_no.HeaderText = "Contact Number";
            this.contact_no.Name = "contact_no";
            this.contact_no.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 75;
            // 
            // ProfileImage
            // 
            this.ProfileImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ProfileImage.HeaderText = "Tenant Image";
            this.ProfileImage.Name = "ProfileImage";
            this.ProfileImage.ReadOnly = true;
            this.ProfileImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProfileImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProfileImage.Width = 90;
            // 
            // ValidDocuments
            // 
            this.ValidDocuments.HeaderText = "Valid Documents";
            this.ValidDocuments.Name = "ValidDocuments";
            this.ValidDocuments.ReadOnly = true;
            this.ValidDocuments.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ValidDocuments.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ValidDocuments.Width = 110;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UploadPDFBTN);
            this.panel1.Controls.Add(this.ImageUploadBTN);
            this.panel1.Controls.Add(this.DocumentTXT);
            this.panel1.Controls.Add(this.ImagePathTXT);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.ContactTXT);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.EmailTXT);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.AddressTXT);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.GenderTXT);
            this.panel1.Controls.Add(this.MNameTXT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.FNameTXT);
            this.panel1.Controls.Add(this.LNameTXT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 309);
            this.panel1.TabIndex = 1;
            // 
            // UploadPDFBTN
            // 
            this.UploadPDFBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UploadPDFBTN.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadPDFBTN.Location = new System.Drawing.Point(489, 267);
            this.UploadPDFBTN.Name = "UploadPDFBTN";
            this.UploadPDFBTN.Size = new System.Drawing.Size(122, 23);
            this.UploadPDFBTN.TabIndex = 21;
            this.UploadPDFBTN.Text = "Upload PDF";
            this.UploadPDFBTN.UseVisualStyleBackColor = true;
            this.UploadPDFBTN.Click += new System.EventHandler(this.UploadPDFBTN_Click);
            // 
            // ImageUploadBTN
            // 
            this.ImageUploadBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImageUploadBTN.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageUploadBTN.Location = new System.Drawing.Point(489, 238);
            this.ImageUploadBTN.Name = "ImageUploadBTN";
            this.ImageUploadBTN.Size = new System.Drawing.Size(122, 23);
            this.ImageUploadBTN.TabIndex = 20;
            this.ImageUploadBTN.Text = "Upload an Image";
            this.ImageUploadBTN.UseVisualStyleBackColor = true;
            this.ImageUploadBTN.Click += new System.EventHandler(this.ImageUploadBTN_Click);
            // 
            // DocumentTXT
            // 
            this.DocumentTXT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DocumentTXT.AutoSize = true;
            this.DocumentTXT.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentTXT.Location = new System.Drawing.Point(150, 267);
            this.DocumentTXT.Name = "DocumentTXT";
            this.DocumentTXT.Size = new System.Drawing.Size(176, 16);
            this.DocumentTXT.TabIndex = 19;
            this.DocumentTXT.Text = "<<upload a PDF compilation>>";
            // 
            // ImagePathTXT
            // 
            this.ImagePathTXT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImagePathTXT.AutoSize = true;
            this.ImagePathTXT.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImagePathTXT.Location = new System.Drawing.Point(150, 237);
            this.ImagePathTXT.Name = "ImagePathTXT";
            this.ImagePathTXT.Size = new System.Drawing.Size(130, 16);
            this.ImagePathTXT.TabIndex = 18;
            this.ImagePathTXT.Text = "<<upload an image>>";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Valid Documents";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tenant Image";
            // 
            // ContactTXT
            // 
            this.ContactTXT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ContactTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactTXT.Location = new System.Drawing.Point(489, 177);
            this.ContactTXT.Name = "ContactTXT";
            this.ContactTXT.Size = new System.Drawing.Size(120, 24);
            this.ContactTXT.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(384, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Contact No.";
            // 
            // EmailTXT
            // 
            this.EmailTXT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTXT.Location = new System.Drawing.Point(129, 177);
            this.EmailTXT.Name = "EmailTXT";
            this.EmailTXT.Size = new System.Drawing.Size(252, 24);
            this.EmailTXT.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email";
            // 
            // AddressTXT
            // 
            this.AddressTXT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddressTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTXT.Location = new System.Drawing.Point(129, 149);
            this.AddressTXT.Name = "AddressTXT";
            this.AddressTXT.Size = new System.Drawing.Size(480, 24);
            this.AddressTXT.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Home Address";
            // 
            // GenderTXT
            // 
            this.GenderTXT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenderTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderTXT.Location = new System.Drawing.Point(445, 117);
            this.GenderTXT.Name = "GenderTXT";
            this.GenderTXT.Size = new System.Drawing.Size(164, 24);
            this.GenderTXT.TabIndex = 9;
            // 
            // MNameTXT
            // 
            this.MNameTXT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MNameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MNameTXT.Location = new System.Drawing.Point(445, 86);
            this.MNameTXT.Name = "MNameTXT";
            this.MNameTXT.Size = new System.Drawing.Size(164, 24);
            this.MNameTXT.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(302, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Middle Name";
            // 
            // FNameTXT
            // 
            this.FNameTXT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FNameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameTXT.Location = new System.Drawing.Point(129, 119);
            this.FNameTXT.Name = "FNameTXT";
            this.FNameTXT.Size = new System.Drawing.Size(164, 24);
            this.FNameTXT.TabIndex = 5;
            // 
            // LNameTXT
            // 
            this.LNameTXT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LNameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameTXT.Location = new System.Drawing.Point(129, 88);
            this.LNameTXT.Name = "LNameTXT";
            this.LNameTXT.Size = new System.Drawing.Size(164, 24);
            this.LNameTXT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(136)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tenant Informtion";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(209)))), ((int)(((byte)(207)))));
            this.panel2.Controls.Add(this.VerifyTenantBTN);
            this.panel2.Controls.Add(this.RemoveTenantBTN);
            this.panel2.Controls.Add(this.EditTenantBTN);
            this.panel2.Controls.Add(this.AddTenantBTN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(622, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 309);
            this.panel2.TabIndex = 0;
            // 
            // VerifyTenantBTN
            // 
            this.VerifyTenantBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.VerifyTenantBTN.FlatAppearance.BorderSize = 0;
            this.VerifyTenantBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerifyTenantBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyTenantBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(136)))), ((int)(((byte)(149)))));
            this.VerifyTenantBTN.Image = ((System.Drawing.Image)(resources.GetObject("VerifyTenantBTN.Image")));
            this.VerifyTenantBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VerifyTenantBTN.Location = new System.Drawing.Point(0, 150);
            this.VerifyTenantBTN.Name = "VerifyTenantBTN";
            this.VerifyTenantBTN.Size = new System.Drawing.Size(307, 50);
            this.VerifyTenantBTN.TabIndex = 4;
            this.VerifyTenantBTN.Text = "Verify Tenant";
            this.VerifyTenantBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VerifyTenantBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.VerifyTenantBTN.UseVisualStyleBackColor = true;
            this.VerifyTenantBTN.Click += new System.EventHandler(this.VerifyTenantBTN_Click);
            // 
            // RemoveTenantBTN
            // 
            this.RemoveTenantBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemoveTenantBTN.FlatAppearance.BorderSize = 0;
            this.RemoveTenantBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveTenantBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveTenantBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(136)))), ((int)(((byte)(149)))));
            this.RemoveTenantBTN.Image = ((System.Drawing.Image)(resources.GetObject("RemoveTenantBTN.Image")));
            this.RemoveTenantBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveTenantBTN.Location = new System.Drawing.Point(0, 100);
            this.RemoveTenantBTN.Name = "RemoveTenantBTN";
            this.RemoveTenantBTN.Size = new System.Drawing.Size(307, 50);
            this.RemoveTenantBTN.TabIndex = 2;
            this.RemoveTenantBTN.Text = "Remove Tenant";
            this.RemoveTenantBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveTenantBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemoveTenantBTN.UseVisualStyleBackColor = true;
            this.RemoveTenantBTN.Click += new System.EventHandler(this.RemoveTenantBTN_Click);
            // 
            // EditTenantBTN
            // 
            this.EditTenantBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditTenantBTN.FlatAppearance.BorderSize = 0;
            this.EditTenantBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditTenantBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTenantBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(136)))), ((int)(((byte)(149)))));
            this.EditTenantBTN.Image = ((System.Drawing.Image)(resources.GetObject("EditTenantBTN.Image")));
            this.EditTenantBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditTenantBTN.Location = new System.Drawing.Point(0, 50);
            this.EditTenantBTN.Name = "EditTenantBTN";
            this.EditTenantBTN.Size = new System.Drawing.Size(307, 50);
            this.EditTenantBTN.TabIndex = 1;
            this.EditTenantBTN.Text = "Edit Tenant";
            this.EditTenantBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditTenantBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditTenantBTN.UseVisualStyleBackColor = true;
            this.EditTenantBTN.Click += new System.EventHandler(this.EditTenantBTN_Click);
            // 
            // AddTenantBTN
            // 
            this.AddTenantBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddTenantBTN.FlatAppearance.BorderSize = 0;
            this.AddTenantBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTenantBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTenantBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(136)))), ((int)(((byte)(149)))));
            this.AddTenantBTN.Image = ((System.Drawing.Image)(resources.GetObject("AddTenantBTN.Image")));
            this.AddTenantBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddTenantBTN.Location = new System.Drawing.Point(0, 0);
            this.AddTenantBTN.Name = "AddTenantBTN";
            this.AddTenantBTN.Size = new System.Drawing.Size(307, 50);
            this.AddTenantBTN.TabIndex = 0;
            this.AddTenantBTN.Text = "Add New Tenant";
            this.AddTenantBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddTenantBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddTenantBTN.UseVisualStyleBackColor = true;
            this.AddTenantBTN.Click += new System.EventHandler(this.AddTenantBTN_Click);
            // 
            // UploadImageDialog
            // 
            this.UploadImageDialog.DefaultExt = "img, png";
            // 
            // UploadDocumentDialog
            // 
            this.UploadDocumentDialog.DefaultExt = "pdf";
            // 
            // TenantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(929, 742);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TenantGridView);
            this.Name = "TenantForm";
            this.Text = "TenantForm";
            ((System.ComponentModel.ISupportInitialize)(this.TenantGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TenantGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddTenantBTN;
        private System.Windows.Forms.TextBox GenderTXT;
        private System.Windows.Forms.TextBox MNameTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FNameTXT;
        private System.Windows.Forms.TextBox LNameTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button VerifyTenantBTN;
        private System.Windows.Forms.Button RemoveTenantBTN;
        private System.Windows.Forms.Button EditTenantBTN;
        private System.Windows.Forms.TextBox AddressTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ContactTXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EmailTXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button UploadPDFBTN;
        private System.Windows.Forms.Button ImageUploadBTN;
        private System.Windows.Forms.Label DocumentTXT;
        private System.Windows.Forms.Label ImagePathTXT;
        private System.Windows.Forms.OpenFileDialog UploadImageDialog;
        private System.Windows.Forms.OpenFileDialog UploadDocumentDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenant_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewImageColumn ProfileImage;
        private System.Windows.Forms.DataGridViewLinkColumn ValidDocuments;
    }
}