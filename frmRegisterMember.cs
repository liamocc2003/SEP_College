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
    public partial class frmRegisterMember : Form
    {
        public frmRegisterMember()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
        }

        private void mnuUpdateMember_Click(object sender, EventArgs e)
        {
            this.Close();
            frmUpdateMember updateMember=new frmUpdateMember();
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


        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Validate all data
            //Validate forename
            if(txtForename.Text.Equals(""))
            {
                MessageBox.Show("Forename must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Focus();
                return;
            }
            for (int i = 0; i < txtForename.TextLength; i++)
            {
                if (txtForename.Text.Any(char.IsDigit) == true)
                {
                    MessageBox.Show("Forename contains a digit", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtForename.Focus();
                    return;
                }
            }

            //Validate surname
            if (txtSurname.Text.Equals(""))
            {
                MessageBox.Show("Surname must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return;
            }
            for (int i = 0; i < txtSurname.TextLength; i++)
            {
                if (txtSurname.Text.Any(char.IsDigit) == true)
                {
                    MessageBox.Show("Surname contains a digit", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSurname.Focus();
                    return;
                }
            }

            //Validate Eircode
            if (txtEircode.Text.Equals(""))
            {
                MessageBox.Show("Eircode must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEircode.Focus();
                return;
            }
            for (int i = 0; i <txtEircode.TextLength; i++)
            {
                if (Char.IsDigit(txtEircode.Text[0]) || Char.IsLetter(txtEircode.Text[1]) ||
                    Char.IsLetter(txtEircode.Text[2]) || Char.IsDigit(txtEircode.Text[3]) ||
                    Char.IsDigit(txtEircode.Text[4]) || Char.IsLetter(txtEircode.Text[6]))
                {
                    MessageBox.Show("Eircode is invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEircode.Focus();
                    return;
                }
            }

            //Validate Email
            if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Email must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            else if (txtEmail.Text.Contains("@") == false || txtEmail.Text.Contains(".com") == false||
                     txtEmail.Text.Contains(".ie") == false)
            {
                MessageBox.Show("Email is not valid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            //Validate paymentType
            if (cboPaymentType.Text.Equals(""))
            {
                MessageBox.Show("Payment Type must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPaymentType.Focus();
                return;
            }
            //End of Validation

            //Create Member instance with values from form
            Member registerMember = new Member(Convert.ToInt32(txtMemberId.Text), txtForename.Text, txtSurname.Text,
                dtpDOB.Value.ToString("dd-MMM-yyyy"), txtEircode.Text, txtEmail.Text, cboPaymentType.Text, 0, 0);

            //invoke method to add data to Members Table
            registerMember.addMember();

            //Confirmation Message
            MessageBox.Show("Member has been added successfully", "Success", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtMemberId.Text = Member.getNextMemberId().ToString("00000");
            txtForename.Clear();
            txtSurname.Clear();
            dtpDOB.Text = string.Empty;
            txtEircode.Clear();
            txtEmail.Clear();
            cboPaymentType.SelectedIndex = -1;
            txtForename.Focus();
        }

        private void frmRegisterMember_Load(object sender, EventArgs e)
        {
            //set max date to 16 years ago
            dtpDOB.MaxDate = DateTime.Today.AddYears(-16);

            //get next MemberId
            txtMemberId.Text = Member.getNextMemberId().ToString("00000");
        }
    }
}
