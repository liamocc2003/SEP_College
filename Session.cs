﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace GymSYS
{
    class Session
    {
        private int classId;
        private String className;
        private String classTeacher;
        private int classSize;
        private String classDate;
        private int classDuration;
        private int classFee;

        public Session()
        {
            this.classId = 100;
            this.className = "";
            this.classTeacher = "";
            this.classSize = 0;
            this.classDate = Convert.ToString(DateTime.Today);
            this.classDuration = 0;
            this.classFee = 0;
        }

        public Session(int classId, String className, String classTeacher, int classSize, String classDate, int classDuration, int classFee)
        {
            this.classId = classId;
            this.className = className;
            this.classTeacher = classTeacher;
            this.classSize = classSize;
            this.classDate = classDate;
            this.classDuration = classDuration;
            this.classFee = classFee;
        }

        public int getClassId()
        {
            return this.classId;
        }
        public String getClassName()
        {
            return this.className;
        }
        public String getClassTeacher()
        {
            return this.classTeacher;
        }
        public int getClassSize()
        {
            return this.classSize;
        }
        public String getClassDate()
        {
            return this.classDate;
        }
        public int getClassDuration()
        {
            return this.classDuration;
        }
        public int getClassFee()
        {
            return this.classFee;
        }

        public void setClassId(int ClassId)
        {
            classId = ClassId;
        }
        public void setClassName(String ClassName)
        {
            className = ClassName;
        }
        public void setClassTeacher(String ClassTeacher)
        {
            classTeacher = ClassTeacher;
        }
        public void setClassSize(int ClassSize)
        {
            classSize = ClassSize;
        }
        public void setClassDate(String ClassDate)
        {
            classDate = ClassDate;
        }
        public void setClassDuration(int ClassDuration)
        {
            classDuration = ClassDuration;
        }
        public void setClassFee(int ClassFee)
        {
            classFee = ClassFee;
        }

        public void addClass()
        {
            //conect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query
            String sqlQuery = "INSERT INTO SESSIONS VALUES (" +
                this.classId + ",'" +
                this.className + "','" +
                this.classTeacher + "'," +
                this.classSize + ",'" +
                this.classDate + "'," +
                this.classDuration + "," +
                this.classFee + ")";

            //execute query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //close database
            conn.Close();
        }

        public void updateClass()
        {
            //conect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query
            String sqlQuery = "UPDATE SESSIONS SET " +
                "Class_Id = " + this.classId + "," +
                "Class_Name = '" + this.className + "'," +
                "Class_Teacher = '" + this.classTeacher + "'," +
                "Class_Size = " + this.classSize + "," +
                "Class_Date = '" + this.classDate + "'," +
                "Class_Duration = " + this.classDuration + "," +
                "Class_Fee = " + this.classFee +
                "WHERE Class_Id = " + this.classId;

            //execute query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //close database
            conn.Close();
        }

        public static int getNextClassId()
        {
            //conect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query
            String sqlQuery = "SELECT MAX(Class_Id) FROM SESSIONS";

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

        public void cancelClass()
        {
            //connect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query
            String sqlQuery = "DELETE FROM SESSIONS WHERE Class_Id = " + this.classId;

            //execute query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //close database
            conn.Close();
        }

        public static DataSet getClassIds()
        {
            //open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query to execute
            String sqlQuery = "SELECT Class_Id FROM Sessions ORDER BY Class_Id ASC";

            //execute sql query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "classIds");

            //close db connection
            conn.Close();

            return ds;
        }
    }
}
