using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lorica_Residences_Rental_Management_System.Forms
{
    public partial class BedAssignmentForm : Form
    {
        SQLController conn = new SQLController("localhost", "loricaresidence_boardinghouse", "rental", "LoricaHouse12345");
        TenantForm name = new TenantForm();
        NameSeparator NameSeparator = new NameSeparator();

        public BedAssignmentForm()
        {
            InitializeComponent();
            ShowBedAssignments();
        }

        private void ShowBedAssignments()
        {

            string showAssign = "SELECT bed_assignment.assign_id, CONCAT(tenant.lname, ', ', tenant.fname, ' ', tenant.mname) AS full_name, " +
                "rooms.room_no, bed_management.bed_number, bed_assignment.date_started, bed_assignment.due_date FROM bed_assignment INNER JOIN " +
                "bed_management ON bed_assignment.bed_id = bed_management.bed_id INNER JOIN rooms ON bed_management.room_id = rooms.room_id " +
                "INNER JOIN tenant ON bed_assignment.tenant_id = tenant.tenant_id";

            MySqlDataReader assignDisplay = conn.ExecuteQuery(showAssign);

            if (assignDisplay != null) 
            {
                while (assignDisplay.Read())
                {
                    AssignBedGridView.Rows.Add(assignDisplay.GetInt32(0), assignDisplay.GetString(1), assignDisplay.GetInt32(2), 
                        assignDisplay.GetInt32(3), assignDisplay.GetDateTime(4), assignDisplay.GetDateTime(5));
                }
            }
            else
            {
                MessageBox.Show("Error while Displaying Data. Please Try Again", "Bed Assignment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private int TenantForeignKey(string fullname)
        {
            string lname = NameSeparator.GetLastNameFromFullName(fullname);
            string fname = NameSeparator.GetFirstNameFromFullName(fullname);
            string mname = NameSeparator.GetMiddleNameFromFullName(fullname);

            string getTenant = "SELECT tenant_id from tenant WHERE lname = @lname, fname = @fname, mname = @mname";
            MySqlParameter[] param =
            {
                new MySqlParameter("@lname", lname),
                new MySqlParameter("@fname", fname),
                new MySqlParameter("@mname", mname)
            };

            object result = conn.ExecuteScalar(getTenant, param);
            return Convert.ToInt32(result);
        }

        private int RoomNoForeignKey(int roomno)
        {
            string getRoomNo = "SELECT room_no FROM rooms WHERE room_no = @room_no";

            MySqlParameter[] param = {new MySqlParameter(getRoomNo, roomno)};
            object result = conn.ExecuteScalar(getRoomNo, param);
            return Convert.ToInt32(result);
        }

        private int bedNoForeignKey(int bedno, int roomno)
        {
            string getBedNo = "SELECT bed_number FROM bed_management WHERE bed_number = @bed AND room_id = @room";
            MySqlParameter[] param = { new MySqlParameter("@bed", bedno), new MySqlParameter("@room", roomno) };
            object result = conn.ExecuteScalar(getBedNo, param);
            return Convert.ToInt32(result);
        }

        private void AssignaTenantBTN_Click(object sender, EventArgs e)
        {
            string tenantName = TenantNameTXT.Text;
            int roomNo;
            int bedNo;

            // Validate RoomNoTXT input
            if (!int.TryParse(RoomNoTXT.Text, out roomNo))
            {
                MessageBox.Show("Invalid room number. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate BedNumberTXT input
            if (!int.TryParse(BedNumberTXT.Text, out bedNo))
            {
                MessageBox.Show("Invalid bed number. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime assignDate = AssignedDTPicker.Value.Date;
            DateTime dueDate = assignDate.AddMonths(1).AddDays(-1);

            try
            {
                string assignTenant = "INSERT INTO bed_assignment(tenant_id, room_id, bed_id, date_started, due_date) VALUES(@tenant_id, @room_id, @bed_id, @date_started, @due_date)";

                MySqlParameter[] param = {
            new MySqlParameter("@tenant_id", TenantForeignKey(tenantName)),
            new MySqlParameter("@room_id", RoomNoForeignKey(roomNo)),
            new MySqlParameter("@bed_id", bedNoForeignKey(bedNo, roomNo)),
            new MySqlParameter("@date_started", assignDate),
            new MySqlParameter("@due_date", dueDate)
        };

                bool result = conn.ExecuteNonQuery(assignTenant, param);

                if (result)
                {
                    MessageBox.Show("Successfully Added a New Tenant", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshAssignGridView();
                    ResetValues();
                }
                else
                {
                    MessageBox.Show("Error while adding a new tenant. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshAssignGridView()
        {
            AssignBedGridView.Rows.Clear();
            ShowBedAssignments();
        }

        private void ResetValues()
        {
            AssignedDTPicker.Value = DateTime.Now;
            TenantNameTXT.Text = "";
            RoomNoTXT.Text = "";
            BedNumberTXT.Text = "";
        }

        private void ReassignTenantBTN_Click(object sender, EventArgs e)
        {

        }

        private void DeleteAssignmentBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
