using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSYS
{
    class Booking
    {
        private int bookingId;
        private int memberId;
        private String className;

        public Booking()
        {
            this.bookingId = 100;
            this.memberId = 10000;
            this.className = "";
        }

        public Booking(int bookingId, int memberId, String className)
        {
            this.bookingId = bookingId;
            this.memberId = memberId;
            this.className = className;
        }

        public int getBookingId()
        {
            return this.bookingId;
        }

        public int getMemberId()
        {
            return this.memberId;
        }
        public String getClassName()
        {
            return this.className;
        }

        public void setBookingId(int BookingId)
        {
            bookingId = BookingId;
        }
        public void setMemberId(int MemberId)
        {
            memberId = MemberId;
        }
        public void setClassName(String ClassName)
        {
            className = ClassName;
        }

        public void addBooking()
        {
            //conect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query
            String sqlQuery = "INSERT INTO Bookings VALUES (" +
                this.bookingId + "," +
                this.memberId + ",'" +
                this.className + "')";

            //execute query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //close database
            conn.Close();
        }

        public void cancelBooking()
        {
            //connect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query
            String sqlQuery = "DELETE FROM Bookings WHERE Booking_Id = " + this.bookingId;

            //execute query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //close database
            conn.Close();
        }

        public static int getNextBookingId()
        {
            //conect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query
            String sqlQuery = "SELECT MAX(Booking_Id) FROM Bookings";

            //execute query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //is dr null
            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
            {
                nextId = 100;
            }
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            //close database
            conn.Close();

            return nextId;
        }
    }
}
