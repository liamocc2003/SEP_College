﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
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
            this.classId = 100;
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

        public void addBooking()
        {
            //conect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query
            String sqlQuery = "INSERT INTO Bookings VALUES (" +
                this.bookingId + "," +
                this.memberId + ",'" +
                this.classId + "')";

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

        public static DataSet getAllBookingIds()
        {
            //open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query to execute
            String sqlQuery = "SELECT Booking_Id FROM Bookings ORDER BY Booking_Id ASC";

            //execute sql query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "BookingIds");

            //close db connection
            conn.Close();

            return ds;
        }
    }
}
