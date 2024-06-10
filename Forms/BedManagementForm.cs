using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lorica_Residences_Rental_Management_System.Forms
{
    public partial class BedManagementForm : Form
    {
        private readonly SQLController conn = new SQLController("localhost", "loricaresidence_boardinghouse", "rental", "LoricaHouse12345");
        private int Bedid;
        public BedManagementForm()
        {
            InitializeComponent();
            ShowBedTables();
        }

        private void ShowBedTables()
        {
            string query = "SELECT bed_management.bed_id, rooms.room_no, bed_management.bed_number, bed_management.daily_rent, " +
                "bed_management.monthly_rent, bed_management.bed_status FROM bed_management INNER JOIN rooms ON bed_management.room_id = rooms.room_id;";

            MySqlDataReader reader = conn.ExecuteQuery(query);

            if(reader != null)
            {
                while (reader.Read())
                {
                    int bedId = reader.GetInt32(0);
                    string roomNo = "RM-" + reader.GetInt32(1);
                    string bedNo = "B-" + reader.GetInt32(2);
                    double dailyRent = reader.GetDouble(3);
                    double monthlyRent = reader.GetDouble(4);
                    bool bed_status = reader.GetBoolean(5);
                    string status = "";

                    if(bed_status == true) {
                        status = "Occupied";
                    }
                    else
                    {
                        status = "Available";
                    }

                    BedGridView.Rows.Add(bedId, roomNo, bedNo, dailyRent, monthlyRent, status);
                }
            }
            else
            {
                MessageBox.Show("Error while retrieving data from database. Please Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.CloseReader(reader);
        }

        private void AddBedBTN_Click(object sender, EventArgs e)
        {
            int numofBeds = (int)NoofBedsNum.Value;
            int roomId;

            // Get the room_id based on the room number entered
            string getRoomIdQuery = "SELECT room_id FROM rooms WHERE room_no = @room_no";
            MySqlParameter[] roomIdParams = {new MySqlParameter("@room_no", RoomNoTXT.Text)};

            object roomIdResult = conn.ExecuteScalar(getRoomIdQuery, roomIdParams);

            if (roomIdResult != null)
            {
                roomId = Convert.ToInt32(roomIdResult);
            }
            else
            {
                MessageBox.Show("Room not found. Please check the room number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate daily rent and monthly rent inputs
            if (!double.TryParse(DailyRentTXT.Text, out double dailyRent))
            {
                MessageBox.Show("Invalid daily rent value. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(MonthlyRentTXT.Text, out double monthlyRent))
            {
                MessageBox.Show("Invalid monthly rent value. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /* Insert new Beds. */
            string query = "INSERT INTO bed_management(room_id, bed_number, daily_rent, monthly_rent, bed_status) VALUES(@room_id, @bed_number, @daily_rent, @monthly_rent, @status);";

            for (int i = 1; i <= numofBeds; i++)
            {
                MySqlParameter[] parameters = {
                    new MySqlParameter("@room_id", roomId),
                    new MySqlParameter("@bed_number", i),
                    new MySqlParameter("@daily_rent", dailyRent),
                    new MySqlParameter("@monthly_rent", monthlyRent),
                    new MySqlParameter("@status", false) // Assuming 0 means Available
                };

                bool result = conn.ExecuteNonQuery(query, parameters);

                if (!result)
                {
                    MessageBox.Show($"Error while adding bed number {i}. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Successfully Added New Beds", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshBedGridView();
            ResetValues();
        }

        private void ResetValues()
        {
            RoomNoTXT.Text = string.Empty;
            DailyRentTXT.Text = string.Empty;
            MonthlyRentTXT.Text= string.Empty;
        }

        private void RefreshBedGridView()
        {
            BedGridView.Rows.Clear();
            ShowBedTables();
        }

        private void EditBEdDetailsBTN_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBedBTN_Click(object sender, EventArgs e)
        {

        }

        private void BedGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (BedGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = BedGridView.SelectedRows[0];
                Bedid = Convert.ToInt32(selectedRow.Cells[0].Value);

                // Assuming the order of columns is as follows:
                // tenant_id, full_name, complete_address, email, contact_no, gender, profile_picture_link, valid_documents_link
                RoomNoTXT.Text = selectedRow.Cells[1].Value.ToString();
                BedIdTXT.Text = selectedRow.Cells[2].Value.ToString();
                DailyRentTXT.Text = selectedRow.Cells[3].Value.ToString();
                MonthlyRentTXT.Text = selectedRow.Cells[4].Value.ToString();
            }
        }
    }
}
