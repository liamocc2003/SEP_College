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
    public partial class frmScheduleClass : Form
    {
        public frmScheduleClass()
        {
            InitializeComponent();
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

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
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

        private void yearlyClassAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearlyClassAnalysis yearlyClassAnalysis = new frmYearlyClassAnalysis();
            yearlyClassAnalysis.Show();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            //Validate all data

            //End of Validation

            //Create Member instance with values from form
            Session scheduleClass = new Session(Convert.ToInt32(txtClassId.Text), txtClassName.Text,
                txtClassTeacher.Text, Convert.ToInt32(txtClassSize.Text), 0, dtpClassDate.Value.ToString("dd-MMM-yyyy"),
                Convert.ToInt32(txtClassDuration.Text), Convert.ToInt32(txtClassFee.Text));

            //invoke method to add data to Members Table
            scheduleClass.addClass();

            //Confirmation Message
            MessageBox.Show("Class has been scheduled successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtClassId.Text = Session.getNextClassId().ToString("000");
            txtClassName.Clear();
            txtClassTeacher.Clear();
            txtClassSize.Clear();
            dtpClassDate.Text = string.Empty;
            txtClassDuration.Clear();
            txtClassFee.Clear();
        }

        private void frmScheduleClass_Load(object sender, EventArgs e)
        {
            //get next ClassId
            txtClassId.Text = Session.getNextClassId().ToString("000");

            //set classDate to a minuimum of today
            dtpClassDate.MinDate = DateTime.Today;
        }
    }
}
