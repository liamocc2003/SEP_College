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
    public partial class frmUpdateMember : Form
    {
        public frmUpdateMember()
        {
            InitializeComponent();
        }

        private void txtForename_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Validate data
            //Validate Forename
            String forename = txtForename.Text;
            for (int i = 0; i < txtForename.TextLength; i++)
            {
                if (forename.Any(char.IsDigit) == true)
                {
                    txtIssue.Visible = true;
                    txtIssue.Text = ("Forename contains a digit.");
                }
                else if (forename.Any(char.IsDigit) == false)
                {
                    txtIssue.Visible = false;
                    txtIssue.Clear();
                }
            }

            //Validate Surname
            String surname = txtSurname.Text;
            for (int i = 0; i < txtSurname.TextLength; i++)
            {
                if (surname.Any(char.IsDigit) == true)
                {
                    txtIssue.Visible = true;
                    txtIssue.Text = ("Surname contains a digit.");
                }
                else
                {
                    txtIssue.Visible = false;
                    txtIssue.Clear();
                }
            }
            //End of Validation

            //change the data

            //update the data

            //Display Confirmation Message
            MessageBox.Show("Member has been update successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            txtForename.Clear();
            txtSurname.Clear();
            txtEircode.Clear();
            txtEmail.Clear();
            cboPaymentType.SelectedIndex = -1;
            txtMemberId.Clear();
        }
    }
}
