using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSYS
{
    public partial class frmMakeBooking : Form
    {
        public frmMakeBooking()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
        }

        private void mnuRegisterMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterMember registerMember = new frmRegisterMember();
            registerMember.Show();
        }

        private void mnuUpdateMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateMember updateMember = new frmUpdateMember();
            updateMember.Show();
        }

        private void mnuTopUpMemberWallet_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTopUpMemberWallet topUpMember = new frmTopUpMemberWallet();
            topUpMember.Show();
        }

        private void scheduleClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmScheduleClass scheduleClass = new frmScheduleClass();
            scheduleClass.Show();
        }

        private void updateClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateClass updateClass = new frmUpdateClass();
            updateClass.Show();
        }

        private void cancelClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancelClass cancelClass = new frmCancelClass();
            cancelClass.Show();
        }

        private void cancelBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancelBooking cancelBooking = new frmCancelBooking();
            cancelBooking.Show();
        }

        private void yearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearlyRevenueAnalysis yearlyRevenueAnalysis = new frmYearlyRevenueAnalysis();
            yearlyRevenueAnalysis.Show();
        }

        private void frmMakeBooking_Load(object sender, EventArgs e)
        {
            //get next BookingId
            txtBookingId.Text = Booking.getNextBookingId().ToString("000");

            //load classIds into comboBox
            DataSet dsC = Session.getClassIds();
            
            for(int i = 0; i < dsC.Tables[0].Rows.Count; i++)
            {
                cboClassId.Items.Add(dsC.Tables[0].Rows[i][0]);
            }

            //load memberIds into comboBox
            DataSet dsM = Member.getMemberIds();

            for(int i = 0; i < dsM.Tables[0].Rows.Count; i++)
            {
                cboMemberId.Items.Add(dsM.Tables[0].Rows[i][0]);
            }
        }

        private void btnBookClass_Click(object sender, EventArgs e)
        {
            //Validate all data

            //End of Validation

            //Create Booking instance with values from form
            Booking bookClass = new Booking(Convert.ToInt32(txtBookingId.Text), Convert.ToInt32(cboMemberId.Text), Convert.ToInt32(cboClassId.Text));

            //invoke method to add data to Booking Table
            bookClass.addBooking();

            //Confirmation Message
            MessageBox.Show("Booking has been completed successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtBookingId.Text = Booking.getNextBookingId().ToString("000");
            cboMemberId.SelectedIndex = -1;
            cboClassId.SelectedIndex = -1;
        }
    }
}
