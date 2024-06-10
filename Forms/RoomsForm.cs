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
    public partial class RoomsForm : Form
    {
        private SQLController conn = new SQLController("localhost", "loricaresidence_boardinghouse", "rental", "LoricaHouse12345");
        private string ImagePath;
        private int room_id, room_no;
        private string description;

        public RoomsForm()
        {
            InitializeComponent();
            RoomsTable();
        }

        private void RoomsTable()
        {
            string query = "SELECT * FROM loricaresidence_boardinghouse.rooms;";

            MySqlDataReader roomList = conn.ExecuteQuery(query);

            if (roomList != null)
            {
                while (roomList.Read()) 
                {
                    int roomId = roomList.GetInt32(0);
                    int roomNo = roomList.GetInt32(1);
                    string description = roomList.GetString(2);
                    string roomImage = roomList.GetString(3);

                    Bitmap resizedImage = null;

                    try
                    {
                        // Load and resize the image
                        Bitmap originalImage = new Bitmap(roomImage);
                        resizedImage = new Bitmap(originalImage, new Size(180, 150));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image for room ID {roomId}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // You might want to set a default image in case of an error
                        resizedImage = new Bitmap(180, 150); // Create an empty bitmap or load a default image
                    }

                    // Add the row to the DataGridView
                    RoomGridView.Rows.Add(roomId, roomNo, description, resizedImage);
                }
            }
        }

        private void AddRoomBTN_Click(object sender, EventArgs e)
        {
            ImagePath = ImagePathTXT.Text;

            if (String.Equals(ImagePath, "<<upload an image>>")){
                ImagePath = @"C:\Users\loric\OneDrive\Documents\3rd year\2nd Sem\Event Driven Programming\Lorica Residences Rental Management System\Tenant\Images\default.png";
                AddRoom(ImagePath);
            }
            else
            {
                AddRoom(ImagePath);
            }
        }

        private void AddRoom(string imgpath)
        {
            string query = "INSERT INTO rooms(room_no, description, image_link) VALUES (@room_no, @description, @image)";

            MySqlParameter[] param =
            {
                new MySqlParameter("@room_no", RoomNoTXT.Text),
                new MySqlParameter("@description", DescriptionTXT.Text),
                new MySqlParameter("@image", imgpath)
            };

            if (conn.ExecuteNonQuery(query, param))
            {
                MessageBox.Show("New Room Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RoomGridView.Refresh();
                ImagePath = "";
            }
        }

        private void EditRoomBTN_Click(object sender, EventArgs e)
        {
            string query = "UPDATE rooms SET room_no = @room_no, description = @description, image_link = @image WHERE room_id = @room_id";

            MySqlParameter[] param =
            {
                new MySqlParameter("@room_id", DescriptionTXT.Text),
                new MySqlParameter("@room_no", RoomNoTXT.Text),
                new MySqlParameter("@description", DescriptionTXT.Text),
                new MySqlParameter("@image", ImagePathTXT.Text)
            };

            if (conn.ExecuteNonQuery(query, param))
            {
                MessageBox.Show("Room Details Successfully Edited.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RoomGridView.Refresh();
                ImagePath = "";
            }
        }

        private void DeleteRoomBTN_Click(object sender, EventArgs e)
        {
            string removeRoom = "DELETE FROM rooms WHERE room_id = @room_id";
            MySqlParameter[] param = {new MySqlParameter("@room_id", room_id)};
            if (conn.ExecuteNonQuery(removeRoom, param))
            {
                MessageBox.Show("Room Successfully Removed.", "Rooms", MessageBoxButtons.OK, MessageBoxIcon.Information );
                ResetValues();
            }
        }

        private void RoomGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (RoomGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = RoomGridView.SelectedRows[0];

                room_id = Convert.ToInt32(selectedRow.Cells[0].Value);
                room_no = Convert.ToInt32(selectedRow.Cells[1].Value);
                description = selectedRow.Cells[2].Value.ToString();

                RoomNoTXT.Text = room_no.ToString();
                DescriptionTXT.Text = description;
            }
        }

        private void ResetValues()
        {
            RoomGridView.Rows.Clear();
            RoomsTable();
            room_id = 0;
            room_no = 0;
            description = "";
        }
    }
}
