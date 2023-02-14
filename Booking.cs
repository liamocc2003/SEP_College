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
        private int classId;

        public Booking()
        {
            this.bookingId = 100;
            this.memberId = 10000;
            this.classId. = 100;
        }

        public Booking(int bookingId, int memberId, int classId)
        {
            this.bookingId = bookingId;
            this.memberId = memberId;
            this.classId = classId;
        }

        public int getBookingId()
        {
            return this.bookingId;
        }

        public int getMemberId()
        {
            return this.memberId;
        }
        public int getClassId()
        {
            return this.classId;
        }

        public void setBookingId(int BookingId)
        {
            bookingId = BookingId;
        }
        public void setMemberId(int MemberId)
        {
            memberId = MemberId;
        }
        public void setClassId(int ClassId)
        {
            classId = ClassId;
        }

        public void bookClass()
        {
            //conect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query
            String sqlQuery = "INSERT INTO Bookings VALUES (" +
                this.bookingId

            //execute query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //close database
            conn.Close();
        }

        public void cancelClass()
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
    }
}
