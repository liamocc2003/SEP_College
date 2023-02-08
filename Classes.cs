using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace GymSYS
{
    class Classes
    {
        private int classId;
        private String className;
        private String classTeacher;
        private int classFee;

        public Classes()
        {
            this.classId = 100;
            this.className = "";
            this.classTeacher = "";
            this.classFee = 0;
        }

        public Classes(int classId, String className, String classTeacher, int classFee)
        {
            this.classId = classId;
            this.className = className;
            this.classTeacher = classTeacher;
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
        public void setClassFee(int ClassFee)
        {
            classFee = ClassFee;
        }

        public void addClass()
        {
            //conect to database
            OracleConnection conn = new OracleConnection(DBConnect.oracledb);

            //define sql query
            String sqlQuery = "INSERT INTO MEMBERS VALUES (" +
                this.classId + ",'" +
                this.className + "','" +
                this.classTeacher + "'," +
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
            String sqlQuery = "UPDATE Classes SET " +
                "Class_Id = " + this.classId + "," +
                "Class_Name = '" + this.className + "'," +
                "Class_Teacher = '" + this.classTeacher + "'," +
                "Class_Fee = " + this.classFee +
                "WHERE Member_Id = " + this.classId;

            //execute query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //close database
            conn.Close();
        }
        public static DataSet findClass(int classId)
        {
            return;
        }
    }
}
