using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace GymSYS
{
    class Member
    {
        private int memberId;
        private String forename;
        private String surname;
        private String dateOfBirth;
        private String eircode;
        private String email;
        private String paymentType;
        private int memberWallet;
        private int memberPoints;

        public Member()
        {
            this.memberId = 10000;
            this.forename = "";
            this.surname = "";
            this.dateOfBirth = Convert.ToString(DateTime.Today);
            this.eircode = "";
            this.email = "";
            this.paymentType = "";
            this.memberWallet = 0;
            this.memberPoints = 0;
    }

        public Member(int memberId, String forename, String surname, String dateOfBirth, String eircode, String email, String paymentType, int memberWallet, int memberPoints)
        {
            this.memberId = memberId;
            this.forename = forename;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.eircode = eircode;
            this.email = email;
            this.paymentType = paymentType;
            this.memberWallet = memberWallet;
            this.memberPoints = memberPoints;
        }

        public int getMemberId()
        {
            return this.memberId;
        }
        public String getForename()
        {
            return this.forename;
        }
        public String getSurname()
        {
            return this.surname;
        }
        public String getDateOfBirth()
        {
            return this.dateOfBirth;
        }
        public String getEircode()
        {
            return this.eircode;
        }
        public String getEmail()
        {
            return this.email;
        }
        public String getPaymentType()
        {
            return this.paymentType;
        }
        public int getMemberWallet()
        {
            return this.memberWallet;
        }
        public int getMemberPoints()
        {
            return this.memberPoints;
        }

        public void setMemberId(int MemberId)
        {
            memberId=MemberId;
        }
        public void setForename(String Forename)
        {
            forename=Forename;
        }
        public void setSurname(String Surname)
        {
            surname=Surname;
        }
        public void setDateOfBirth(String DateOfBirth)
        {
            dateOfBirth=DateOfBirth;
        }
        public void setEircode(String Eircode)
        {
            eircode=Eircode;
        }
        public void setEmail(String Email)
        {
            email=Email;
        }
        public void setPaymentType(String PaymentType)
        {
            paymentType=PaymentType;
        }
        public void setMemberWallet(int MemberWallet)
        {
            memberWallet = MemberWallet;
        }
        public void setMemberPoints(int MemberPoints)
        {
            memberPoints = MemberPoints;
        }

        public void addMember()
        {
            //conect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query
            String sqlQuery = "INSERT INTO MEMBERS VALUES (" +
                this.memberId + ",'" +
                this.forename + "','" +
                this.surname + "','" +
                this.dateOfBirth + "','" +
                this.eircode + "','" +
                this.email + "','" +
                this.paymentType + "'," +
                this.memberWallet + "," +
                this.memberPoints + ")";

            //execute query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //close database
            conn.Close();
        }

        public void updateMember()
        {
            //conect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query
            String sqlQuery = "UPDATE Members SET " +
                "Member_Id = " + this.memberId + "," +
                "Forename = '" + this.forename + "'," +
                "Surname = '" + this.surname + "'," +
                "Date_Of_Birth = '" + this.dateOfBirth + "'," +
                "Eircode = '" + this.eircode + "'," +
                "Email = '" + this.email + "'," +
                "Payment_Type = '" + this.paymentType + "'," +
                "Member_Wallet = " + this.memberWallet + "," +
                "Member_Points = " + this.memberPoints +
                "WHERE Member_Id = " + this.memberId;

            //execute query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //close database
            conn.Close();
        }

        public static int getNextMemberId()
        {
            //conect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query
            String sqlQuery="SELECT MAX(Member_Id) FROM Members";

            //execute query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //is dr null
            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
            {
                nextId = 10000;
            }
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            //close database
            conn.Close();

            return nextId;
        }

        public static DataSet getMemberIds()
        {
            //open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query to execute
            String sqlQuery = "SELECT Member_Id FROM Members ORDER BY Member_Id ASC";

            //execute sql query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "membIds");

            //close db connection
            conn.Close();

            return ds;
        }

        public static DataSet getMemberDetails()
        {
            //open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query to execute
            String sqlQuery = "SELECT Member_Id,Member_Wallet FROM Members ORDER BY Member_Id ASC";

            //execute sql query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "membAll");

            //close db connection
            conn.Close();

            return ds;
        }

        public static int getWalletTotal()
        {
            //open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query to execute
            String sqlQuery = "SELECT SUM(Member_Wallet) FROM Members";

            //execute sql query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //is dr null
            int walletTotal;
            dr.Read();

            if (dr.IsDBNull(0))
            {
                walletTotal = 0;
            }
            else
            {
                walletTotal = dr.GetInt32(0);
            }

            //close db connection
            conn.Close();

            return walletTotal;
        }
    }
}
