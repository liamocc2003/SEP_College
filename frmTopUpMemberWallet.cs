using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

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
            int count = 0;
            if (txtAmount.Text.Equals(""))
            {
                MessageBox.Show("Amount must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Focus();
                return;
            }
            for(int i=0; i<txtAmount.TextLength; i++)
            {
                if(txtAmount.Text.Any(char.IsLetter) == true)
                {
                    MessageBox.Show("Amount must be numerical", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAmount.Focus();
                    return;
                }
                if(txtAmount.Text.Any(char.IsPunctuation) == true)
                {
                    count++;
                }
                if(count > 1)
                {
                    MessageBox.Show("Amount cannot have more than 1 punctuation", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAmount.Focus();
                    return;
                }
            }
            //End of Validation

            //create Member Object
            Member topUpMemberWallet = new Member();

            //change data
            topUpMemberWallet.setMemberWallet(Convert.ToInt32(txtCurrentAmount.Text) + Convert.ToInt32(txtAmount.Text));

            //update the data
            topUpMemberWallet.updateMember();

            //Display Confirmation Message
            MessageBox.Show("Member has updated wallet successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            txtMemberId.Clear();
            txtAmount.Clear();
            txtCurrentAmount.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Validate data
            //Validate MemberId
            if (txtMemberId.Text.Equals(""))
            {
                MessageBox.Show("MemberId must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberId.Focus();
                return;
            }
            for (int i = 0; i < txtMemberId.TextLength; i++)
            {
                if (txtMemberId.Text.Any(char.IsLetter) == true)
                {
                    MessageBox.Show("MemberId contains a letter", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMemberId.Focus();
                    return;
                }
            }
            //end of validation

            //connect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //sql query
            String sqlQuery = "SELECT Member_Wallet FROM Members WHERE Member_Id = " + Convert.ToInt32(txtMemberId.Text);

            //execute query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("There are no members found with that Member ID");
            }
            else
            {
                txtCurrentAmount.Text = Convert.ToString(dr.GetFloat(8));
            }

            conn.Close();
        }
    }
}
