using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lorica_Residences_Rental_Management_System
{
    public partial class Dashboard : Form
    {
        /*Fields*/
        private Button CurrentBTN;
        private Form ActiveForm;

        /*Constructor*/
        public Dashboard()
        {
            InitializeComponent();
            BackBTN.Visible = false;
        }

        private void ActivateBTN(object SenderBTN)
        {
            if (SenderBTN != null)
            {
                if (CurrentBTN != (Button)SenderBTN)
                {
                    DisableBTN();
                    Color color = Color.FromArgb(231, 136, 149);
                    CurrentBTN = (Button)SenderBTN;
                    CurrentBTN.BackColor = color;
                    CurrentBTN.ForeColor = Color.White;
                    CurrentBTN.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    BackBTN.Visible = true;
                }
            }
        }

        private void DisableBTN()
        {
            foreach (Control PrevBTN in NavigationPanel.Controls)
            {
                PrevBTN.BackColor = Color.FromArgb(255, 228, 201);
                PrevBTN.ForeColor = Color.Black;
                PrevBTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }

            foreach(Control PrevBTN2 in panel2.Controls)
            {
                PrevBTN2.BackColor = Color.FromArgb(255, 228, 201);
                PrevBTN2.ForeColor = Color.Black;
                PrevBTN2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        private void OpenChildForm(Form ChildForm, object SenderBTN)
        {
            if(ActiveForm != null)
            {
                ActiveForm.Close();
            }

            ActivateBTN(SenderBTN);
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(ChildForm);
            this.DesktopPanel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        private void TenantsBTN_Click(object sender, EventArgs e)
        {
            //ActivateBTN(sender);
            OpenChildForm(new Forms.TenantForm(), sender);
        }

        private void RoomsBTN_Click(object sender, EventArgs e)
        {
            //ActivateBTN(sender);
            OpenChildForm(new Forms.RoomsForm(), sender);
        }

        private void BedsBTN_Click(object sender, EventArgs e)
        {
            //ActivateBTN(sender);
            OpenChildForm(new Forms.BedManagementForm(), sender);
        }

        private void BedAssignBTN_Click(object sender, EventArgs e)
        {
            //ActivateBTN(sender);
            OpenChildForm(new Forms.BedAssignmentForm(), sender);
        }

        private void UtilityBTN_Click(object sender, EventArgs e)
        {
            //ActivateBTN(sender);
            OpenChildForm(new Forms.UtilityBillsForm(), sender);
        }

        private void InvoiceBTN_Click(object sender, EventArgs e)
        {
            //ActivateBTN(sender);
            OpenChildForm(new Forms.InvoiceForm(), sender);
        }

        private void PaymentsBTN_Click(object sender, EventArgs e)
        {
            //ActivateBTN(sender);
            OpenChildForm(new Forms.PaymentForm(), sender);
        }

        private void PayHistoryBTN_Click(object sender, EventArgs e)
        {
            //ActivateBTN(sender);
            OpenChildForm(new Forms.PaymentHistoryView(), sender);
        }

        private void NoticeBrdBTN_Click(object sender, EventArgs e)
        {
            //ActivateBTN(sender);
            OpenChildForm(new Forms.NoticeBoardForm(), sender);
        }

        private void FeedbackBTN_Click(object sender, EventArgs e)
        {
            //ActivateBTN(sender);
            OpenChildForm(new Forms.FeedbackForm(), sender);
        }

        private void SupplyBTN_Click(object sender, EventArgs e)
        {
            //ActivateBTN(sender);
            OpenChildForm(new Forms.InventoryForm(), sender);
        }

        private void IncomeRptBTN_Click(object sender, EventArgs e)
        {
            //ActivateBTN(sender);
            OpenChildForm(new Forms.IncomeSummary(), sender);
        }

        private void CollectiblesBTN_Click(object sender, EventArgs e)
        {
            //ActivateBTN(sender);
            OpenChildForm(new Forms.CollectiblesReport(), sender);
        }

        private void SupplyReportBTN_Click(object sender, EventArgs e)
        {
            //ActivateBTN(sender);
            OpenChildForm(new Forms.InventorySummary(), sender);
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            if(ActiveForm != null)
            {
                ActiveForm.Close();
                DisableBTN();
                CurrentBTN = null;
                BackBTN.Visible = false;
            }
        }
    }
}
