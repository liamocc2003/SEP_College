using Oracle.ManagedDataAccess.Client;
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
    public partial class frmCancelBooking : Form
    {
        public frmCancelBooking()
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

        private void makeBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMakeBooking makeBooking = new frmMakeBooking();
            makeBooking.Show();
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

        private void btnCancelClass_Click(object sender, EventArgs e)
        {
            //valiadte ClassId
            if (cboBookingId.Text.Equals(""))
            {
                MessageBox.Show("Booking ID must be selected ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboBookingId.Focus();
                return;
            }
            //End of validation

            //connect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //sql query
            String sqlQuery = "SELECT * FROM Bookings WHERE Booking_Id = " + Convert.ToInt32(cboBookingId.Text);

            //create Booking Object
            Booking cancelBooking = new Booking();

            //execute query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("There are no bookings found with that Booking ID");
                return;
            }
            else
            {
                cancelBooking.setBookingId(Convert.ToInt32(cboBookingId.Text));
            }

            //remove the data
            cancelBooking.cancelBooking();

            //create session object
            Session changeClass = new Session();

            //invoke method
            changeClass.removeRegister();

            //Display Confirmation Message
            MessageBox.Show("Booking has cancelled successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //check current time against class time
            int currentDateYear = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            int currentDateMonth = Convert.ToInt32(DateTime.Now.ToString("M"));
            int currentDateDay = Convert.ToInt32(DateTime.Now.ToString("dd"));

            String classDate = changeClass.getClassDate();
            Console.WriteLine(classDate);

            int classDateMonth;

            if (classDate.Contains("JAN"))
            {
                classDateMonth = 1;
            }
            else if (classDate.Contains("FEB"))
            {
                classDateMonth = 2;
            }
            else if (classDate.Contains("MAR"))
            {
                classDateMonth = 3;
            }
            else if (classDate.Contains("APR"))
            {
                classDateMonth = 4;
            }
            else if (classDate.Contains("MAY"))
            {
                classDateMonth = 5;
            }
            else if (classDate.Contains("JUN"))
            {
                classDateMonth = 6;
            }
            else if (classDate.Contains("JUL"))
            {
                classDateMonth = 7;
            }
            else if (classDate.Contains("AUG"))
            {
                classDateMonth = 8;
            }
            else if (classDate.Contains("SEP"))
            {
                classDateMonth = 9;
            }
            else if (classDate.Contains("OCT"))
            {
                classDateMonth = 10;
            }
            else if (classDate.Contains("NOV"))
            {
                classDateMonth = 11;
            }
            else if (classDate.Contains("DEC"))
            {
                classDateMonth = 12;
            }
            else
            {
                MessageBox.Show("Error retrieving the Class Date", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (classDate.EndsWith(Convert.ToString(currentDateYear)) || classDate.EndsWith(Convert.ToString(currentDateYear + 1)))
            {
                if(currentDateMonth == classDateMonth)
                {
                    if (currentDateDay < Convert.ToInt32(classDate.Substring(0, 2)))
                    {
                        //include return of money
                        MessageBox.Show("Payment has been refunded to account", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Payment cannot be refunded as it is past the 24 hour refund time", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (currentDateMonth < classDateMonth)
                {
                    if (classDateMonth - currentDateMonth > 1)
                    {
                        //include return of money
                        MessageBox.Show("Payment has been refunded to account", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (currentDateDay != 1)
                        {
                            //include return of money
                            MessageBox.Show("Payment has been refunded to account", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Payment cannot be refunded as it is past the 24 hour refund time", "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Payment cannot be refunded as it is past the 24 hour refund time", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Payment cannot be refunded as it is past the 24 hour refund time", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Reset UI
            cboBookingId.SelectedIndex = -1;

            conn.Close();
        }

        private void frmCancelBooking_Load(object sender, EventArgs e)
        {
            DataSet dsB = Booking.getAllBookingIds();

            for (int i = 0; i < dsB.Tables[0].Rows.Count; i++)
            {
                cboBookingId.Items.Add(dsB.Tables[0].Rows[i][0]);
            }
        }

        private static void refundMoney()
        {
            //connect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //create Booking object
            Booking booking = new Booking();

            //create all variables
            int memberWallet = 0;
            int memberPoints = 0;
            int classFee = 0;

            //sql query
            String sqlQuery = "SELECT Member_Wallet,Member_Points FROM Members WHERE Member_Id = " + Convert.ToInt32(booking.getMemberId());

            //execute query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("There are no members found with that Booking ID");
                return;
            }
            else
            {
                memberWallet = dr.GetInt32(0);
                memberPoints = dr.GetInt32(1);
            }

            //create Class object
            Session getClassFee = new Session();

            //sql query
            sqlQuery = "SELECT Class_Fee FROM Sessions WHERE Class_Id = " + Convert.ToInt32(booking.getClassId());

            //execute query
            cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("There are no classes found with that Booking ID");
                return;
            }
            else
            {
                classFee = dr.GetInt32(0);
            }

            //create Class object
            Member refundMember = new Member();

            //change the data
            //find a way to check what payment option was selected
            if (true/*memberWallet is selected*/)
            {
                refundMember.setMemberWallet(memberWallet + classFee);
            }
            else
            {
                refundMember.setMemberPoints(memberPoints + classFee);
            }
        }
    }
}
