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

        private void yearlyClassAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearlyClassAnalysis yearlyClassAnalysis = new frmYearlyClassAnalysis();
            yearlyClassAnalysis.Show();
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
            //valiadte MemberId
            if (cboMemberId.Text.Equals(""))
            {
                MessageBox.Show("Member ID must be selected ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMemberId.Focus();
                return;
            }

            //valiadte ClassId
            if (cboClassId.Text.Equals(""))
            {
                MessageBox.Show("Class ID must be selected ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboClassId.Focus();
                return;
            }

            //validate radio button
            if (rdbMemberWallet.Checked == false && rdbMemberPoints.Checked == false)
            {
                MessageBox.Show("An option for payment must be selected ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rdbMemberWallet.Focus();
                return;
            }

            //validate if member has already booked the class
            if (Booking.checkIfBooked() == true)
            {
                MessageBox.Show("The member has already booked this class", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //End of Validation

            //define variables
            Member memberDetails = new Member();
            Session sessionDetails = new Session();
            Booking bookClass = new Booking();

            int wallet = 0;
            int points = 0;
            String classDate = "";
            int classSize = 0;
            int classReg = 0;
            int classFee = 0;

            //conect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define Member sql query
            String sqlQuery = "SELECT Member_Wallet,Member_Points " +
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
                wallet = dr.GetInt32(0);
                points = dr.GetInt32(1);
            }

            //define Session sql query
            sqlQuery = "SELECT Class_Date,Class_Size,Class_Reg,Class_Fee " +
                "FROM Sessions WHERE Class_Id = " + Convert.ToInt32(cboClassId.Text);

            //execute query
            cmd = new OracleCommand(sqlQuery, conn);
            dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("There are no classes found with that Class ID");
                return;
            }
            else
            {
                classDate = dr.GetDateTime(0).ToString("dd-MMM-yyyy");
                classSize = dr.GetInt32(1);
                classReg = dr.GetInt32(2);
                classFee = dr.GetInt32(3);
            }

            //check if registered is lower than class size
            if (classReg < classSize)
            {
                //check which payment option is chosen
                if (rdbMemberWallet.Checked)
                {
                    //check amount in account is greater than or equal to class fee
                    if (wallet < classFee)
                    {
                        MessageBox.Show("Member does not have enough money in Member Wallet to book for Class", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        //reduce member wallet by class fee and increase member points
                        int newWallet = wallet - classFee;
                        memberDetails.setMemberWallet(newWallet);

                        int newPoints = points + classFee;
                        memberDetails.setMemberPoints(newPoints);

                        memberDetails.bookedClass();

                        //increment classReg
                        sessionDetails.getNextRegistered();

                        //Create Booking instance with values from form
                        bookClass = new Booking(Convert.ToInt32(txtBookingId.Text), Convert.ToInt32(cboMemberId.Text), Convert.ToInt32(cboClassId.Text), 'P', classDate);

                        //invoke method to add data to Booking Table
                        bookClass.addBooking();
                    }
                }
                else if (rdbMemberPoints.Checked)
                {
                    //check points in account is greater than or equal to class fee
                    if (points < classFee)
                    {
                        MessageBox.Show("Member does not have enough points in Member Points to register for Class", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        //reduce member points by class fee
                        memberDetails.setMemberWallet(wallet);

                        int newPoints = points - classFee;
                        memberDetails.setMemberPoints(newPoints);

                        memberDetails.bookedClass();

                        //incremenr classReg
                        sessionDetails.getNextRegistered();

                        //Create Booking instance with values from form
                        bookClass = new Booking(Convert.ToInt32(txtBookingId.Text), Convert.ToInt32(cboMemberId.Text), Convert.ToInt32(cboClassId.Text), 'P', classDate);

                        //invoke method to add data to Booking Table
                        bookClass.addBooking();
                    }
                }
            }
            else
            {
                MessageBox.Show("The class is currenty fully booked", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Confirmation Message
            MessageBox.Show("Booking has been completed successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtBookingId.Text = Booking.getNextBookingId().ToString("000");
            cboMemberId.SelectedIndex = -1;
            cboClassId.SelectedIndex = -1;
        }

        private void cboMemberId_SelectedIndexChanged(object sender, EventArgs e)
        {
            //conect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //create booking object
            Booking booking = new Booking();

            //set memberID and ClassID
            booking.setMemberId(Convert.ToInt32(cboMemberId.Text));
            booking.setClassId(Convert.ToInt32(cboClassId.Text));


        }
    }
}
