using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lorica_Residences_Rental_Management_System.Forms
{
    public partial class TenantForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private SQLController conn = new SQLController("localhost", "loricaresidence_boardinghouse", "rental", "LoricaHouse12345");
        private int Tenantid = 0;
        private static String ImagePath = "";
        private static String DocumentPath = "";

        public TenantForm()
        {
            InitializeComponent();
            TenantTables();
            TenantGridView.SelectionChanged += TenantGridView_SelectionChanged;
        }

        private void TenantTables()
        {
            string query = "SELECT tenant.tenant_id, CONCAT(tenant.lname, ', ', tenant.fname, ' ', tenant.mname) as full_name, tenant.complete_address, " +
                "tenant.email, tenant.contact_no, tenant.gender, tenant.profile_picture_link, tenant.valid_documents_link FROM tenant;";

            MySqlDataReader reader = conn.ExecuteQuery(query);

            if (reader != null)
            {
                while (reader.Read())
                {
                    int tenantId = reader.GetInt32(0);
                    string fullName = reader.GetString(1);
                    string completeAddress = reader.GetString(2);
                    string email = reader.GetString(3);
                    string contactNo = reader.GetString(4);
                    string gender = reader.GetString(5);
                    string profilePictureLink = reader.GetString(6);
                    string validDocumentsLink = reader.GetString(7);

                    Bitmap resizedImage = null;

                    try
                    {
                        // Load and resize the image
                        Bitmap originalImage = new Bitmap(profilePictureLink);
                        resizedImage = new Bitmap(originalImage, new Size(90, 90));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image for tenant ID {tenantId}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // You might want to set a default image in case of an error
                        resizedImage = new Bitmap(90, 90); // Create an empty bitmap or load a default image
                    }

                    // Add the row to the DataGridView
                    TenantGridView.Rows.Add(tenantId, fullName, completeAddress, email, contactNo, gender, resizedImage, validDocumentsLink);
                }
            }
        }

        private async void AddTenantBTN_Click(object sender, EventArgs e)
        {
            await Task.Delay(5);

            ImagePath = ImagePathTXT.Text;
            DocumentPath = DocumentTXT.Text;

            if(String.Equals(DocumentPath, "<<upload a PDF compilation>>"))
            {
                MessageBox.Show("Please Upload Proof of Verified Documents.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else if (String.Equals(ImagePath, "<<upload an image>>"))
            {
                ImagePath = @"C:\Users\loric\OneDrive\Documents\3rd year\2nd Sem\Event Driven Programming\Lorica Residences Rental Management System\Tenant\Images\default.png";
                AddTenant(ImagePath, DocumentPath);
            }
            else
            {
                AddTenant(ImagePath, DocumentPath);
            }
        }

        private void AddTenant(string ImagePath, string DocumentPath)
        {
            string query = "INSERT INTO tenant (lname, fname, mname, complete_address, email, contact_no, gender, profile_picture_link, valid_documents_link) " +
            "VALUES (@lname, @fname, @mname, @complete_address, @email, @contact_no, @gender, @profile_picture_link, @valid_documents_link);";

            MySqlParameter[] param = {
                new MySqlParameter("@lname", LNameTXT.Text),
                new MySqlParameter("@fname", FNameTXT.Text),
                new MySqlParameter("@mname", MNameTXT.Text),
                new MySqlParameter("@complete_address", AddressTXT.Text),
                new MySqlParameter("@email", EmailTXT.Text),
                new MySqlParameter("@contact_no", ContactTXT.Text),
                new MySqlParameter("@gender", GenderTXT.Text),
                new MySqlParameter("@profile_picture_link", ImagePath),
                new MySqlParameter("@valid_documents_link", DocumentPath)
            };

            bool result = conn.ExecuteNonQuery(query, param);

            if (result)
            {
                MessageBox.Show("Successfully Added a New Tenant", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshTenantGridView();
                ResetValues();
            }
        }

        private void EditTenantBTN_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE tenant SET email = @email, contact_no = @contact, gender = @gender, @profile_picture_link WHERE tenant_id = @tenant_id;";

            MySqlParameter[] update =
            {
                new MySqlParameter("@email", EmailTXT.Text),
                new MySqlParameter("@contact_no", ContactTXT.Text),
                new MySqlParameter("@gender", GenderTXT.Text),
                new MySqlParameter("@profile_picture_link", ImagePath),
                new MySqlParameter("@valid_documents_link", DocumentPath),
                new MySqlParameter("@tenant_id", Tenantid)
            };

            bool result = conn.ExecuteNonQuery(updateQuery, update);

            if (result)
            {
                MessageBox.Show("Tenant Information Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshTenantGridView();
                ResetValues();
            }
        }

        private void ResetValues()
        {
            ImagePath = "";
            DocumentPath = "";
            Tenantid = 0;
        }

        private void RemoveTenantBTN_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM tenant WHERE tenant_id = @tenant_id";

            MySqlParameter[] delete =
            {
                new MySqlParameter("@tenant_id", Tenantid)
            };

            bool result = conn.ExecuteNonQuery (deleteQuery, delete);

            if (result)
            {
                MessageBox.Show("Tenant now Removed From System.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TenantGridView.Refresh();
                RefreshTenantGridView();
            }
        }

        /*Calling from PHP API.*/
        private async void VerifyTenantBTN_Click(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost/loricaresidences/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                MessageBox.Show(responseBody, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message );
            }
        }

        private void ImageUploadBTN_Click(object sender, EventArgs e)
        {
            if(UploadImageDialog.ShowDialog() == DialogResult.OK)
            {
                ImagePathTXT.Text = UploadImageDialog.FileName;
            }
        }

        private void UploadPDFBTN_Click(object sender, EventArgs e)
        {
            if(UploadDocumentDialog.ShowDialog() == DialogResult.OK)
            {
                DocumentTXT.Text = UploadDocumentDialog.FileName;
            }
        }

        private void TenantGridView_SelectionChanged(object sender, EventArgs e)
        {
            NameSeparator nameSeparator = new NameSeparator();
            if (TenantGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = TenantGridView.SelectedRows[0];
                Tenantid = Convert.ToInt32(selectedRow.Cells[0].Value);

                // Assuming the order of columns is as follows:
                // tenant_id, full_name, complete_address, email, contact_no, gender, profile_picture_link, valid_documents_link
                LNameTXT.Text = nameSeparator.GetLastNameFromFullName(selectedRow.Cells[1].Value.ToString());
                FNameTXT.Text = nameSeparator.GetFirstNameFromFullName(selectedRow.Cells[1].Value.ToString());
                MNameTXT.Text = nameSeparator.GetMiddleNameFromFullName(selectedRow.Cells[1].Value.ToString());
                AddressTXT.Text = selectedRow.Cells[2].Value.ToString();
                EmailTXT.Text = selectedRow.Cells[3].Value.ToString();
                ContactTXT.Text = selectedRow.Cells[4].Value.ToString();
                GenderTXT.Text = selectedRow.Cells[5].Value.ToString();
                DocumentTXT.Text = selectedRow.Cells[7].Value.ToString();

                // Optionally, load the image to a PictureBox for preview if needed
                // PictureBoxProfile.Image = new Bitmap(ImagePathTXT.Text);
            }
        }

        private void RefreshTenantGridView()
        {
            TenantGridView.Rows.Clear();
            TenantTables();
        }
    }
}
