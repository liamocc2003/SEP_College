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
    public partial class frmUpdateMember : Form
    {
        public frmUpdateMember()
        {
            InitializeComponent();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Validation

            //end of validation

            //conect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query
            String sqlQuery = "SELECT * " +
                "FROM Members WHERE Member_Id = " + Convert.ToInt32(cboMemberId.Text);

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
                txtForename.Text = dr.GetString(1);
                txtSurname.Text = dr.GetString(2);
                dtpDOB.Value = dr.GetDateTime(3);
                txtEircode.Text = dr.GetString(4);
                txtEmail.Text = dr.GetString(5);
                cboPaymentType.Text = dr.GetString(6);
            }

            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Validate data
            //Validate forename
            if (txtForename.Text.Equals(""))
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
            //End of Validation

            //Create Member Object
            Member updateMember = new Member();

            //change the data
            updateMember.setMemberId(Convert.ToInt32(cboMemberId.Text));
            updateMember.setForename(txtForename.Text);
            updateMember.setSurname(txtSurname.Text);
            updateMember.setDateOfBirth(dtpDOB.Value.ToString("dd-MMM-yyyy"));
            updateMember.setEircode(txtEircode.Text);
            updateMember.setEmail(txtEmail.Text);
            updateMember.setPaymentType(cboPaymentType.Text);
            updateMember.setMemberWallet(0);
            updateMember.setMemberPoints(0);

            //update the data
            updateMember.updateMember();

            //Display Confirmation Message
            MessageBox.Show("Member has been updated successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            cboMemberId.SelectedIndex = -1;
            txtForename.Clear();
            txtSurname.Clear();
            dtpDOB.Text = string.Empty;
            txtEircode.Clear();
            txtEmail.Clear();
            cboPaymentType.SelectedIndex = -1;
            cboMemberId.Focus();
        }

        private void frmUpdateMember_Load(object sender, EventArgs e)
        {
            //load memberIds in combobox

        }
    }
}
