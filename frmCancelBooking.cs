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
            //valiadte BookingId
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

            //create Objects
            Booking cancelBooking = new Booking();
            Session changeClass = new Session();

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

            //check current time against class time for refund
            int currentDateYear = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            int currentDateMonth = DateTime.Now.Month;
            int currentDateDay = Convert.ToInt32(DateTime.Now.ToString("dd"));

            String classDate = Convert.ToDateTime(changeClass.getClassDate()).ToString("dd-MM-yyyy");
            Console.WriteLine(classDate);

            int classDateMonth = Convert.ToInt32(classDate.Substring(3,2));

            if (Convert.ToInt32(classDate.Substring(classDate.Length - 4)) == currentDateYear || Convert.ToInt32(classDate.Substring(classDate.Length - 4))  > currentDateYear)
            {
                if(currentDateMonth == classDateMonth)
                {
                    if (currentDateDay < Convert.ToInt32(classDate.Substring(0, 2) + 1))
                    {
                        //Refund money
                        refundMoney();
                        MessageBox.Show("Payment has been refunded to account", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Payment cannot be refunded as it is past the 24 hour refund time", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (currentDateMonth < classDateMonth)
                {
                    if (classDateMonth - currentDateMonth > 1)
                    {
                        //Refund money
                        refundMoney();
                        MessageBox.Show("Payment has been refunded to account", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (currentDateDay != 1)
                        {
                            //Refund money
                            refundMoney();
                            MessageBox.Show("Payment has been refunded to account", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Payment cannot be refunded as it is past the 24 hour refund time", "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Payment cannot be refunded as it is past the 24 hour refund time", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Payment cannot be refunded as it is past the 24 hour refund time", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //remove the data
            cancelBooking.cancelBooking();

            //invoke method
            changeClass.removeRegister();

            //Display Confirmation Message
            MessageBox.Show("Booking has cancelled successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            cboBookingId.SelectedIndex = -1;

            conn.Close();
        }

        private void frmCancelBooking_Load(object sender, EventArgs e)
        {
            //load all memberIDs
            DataSet dsM = Member.getMemberIds();

            for (int i = 0; i < dsM.Tables[0].Rows.Count; i++)
            {
                cboMemberId.Items.Add(dsM.Tables[0].Rows[i][0]);
            }

            //load all bookingIDs
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
            conn.Close();
            conn.Open();

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
            if (booking.getPaymentChoice() == 'W')
            {
                refundMember.setMemberWallet(memberWallet + classFee);
                refundMember.setMemberPoints(memberPoints);

                refundMember.bookedClass();
            }
            else
            {
                refundMember.setMemberWallet(memberWallet);
                refundMember.setMemberPoints(memberPoints + classFee);

                refundMember.bookedClass();
            }
        }
    }
}
