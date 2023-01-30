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
    public partial class frmTopUpMemberWallet : Form
    {
        public frmTopUpMemberWallet()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
        }

        private void mnuTopUpMemberWallet_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTopUpMemberWallet topUpMember = new frmTopUpMemberWallet();
            topUpMember.Show();
        }

        private void mnuRegisterMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterMember registerMember = new frmRegisterMember();
            registerMember.Show();
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

        private void makeBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMakeBooking makeBooking = new frmMakeBooking();
            makeBooking.Show();
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

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            //Validate data
            //Validate MemberId
            //Must be in database

            //Amount must be numeric or include only one '.'
            //End of Validation

            //change amount
            txtCheckTotal.Visible = true;
            txtCheckTotal.Text += "starting amount and amount.";

            //update amount

            //Display Confirmation Message
            MessageBox.Show("Member has updated wallet successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            txtMemberId.Clear();
            txtAmount.Clear();
            txtCheckTotal.Text = "Total amount is € ";
        }
    }
}
