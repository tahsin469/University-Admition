using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace Application.Models
{
    public class StudentDbContext
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public List<Student> GetEmployees()
        {
            List<Student> StudentsList = new List<Student>();

            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("spGetStudents", con);

            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Student stu = new Student();
                stu.id = Convert.ToInt32(dr.GetValue(0).ToString());
                //emp.id = dr.GetInt32(0);
                //emp.id = Convert.ToInt32(dr.GetString(0));
                //emp.name = dr.GetString(1);
                stu.studentName = dr.GetValue(1).ToString();
                stu.fatherName = dr.GetValue(2).ToString();
                stu.fatherOccupation = dr.GetValue(3).ToString();
                stu.motherName = dr.GetValue(4).ToString();
                stu.motherOccupation = dr.GetValue(5).ToString();
                stu.dateOfBirth = dr.GetValue(6).ToString();
                stu.permanentAddresses = dr.GetValue(7).ToString();
                stu.presentAddress = dr.GetValue(8).ToString();
                stu.fatherMobileNumber = Convert.ToInt64(dr.GetValue(9).ToString());
                stu.motherMobileNumber = Convert.ToInt64(dr.GetValue(10).ToString());
                stu.legalGuardianName = dr.GetValue(11).ToString();
                stu.legalGuardianRelation = dr.GetValue(12).ToString();
                stu.legalGuardianOccupation = dr.GetValue(13).ToString();
                stu.legalGuardianMobileNumber = Convert.ToInt64(dr.GetValue(14).ToString());
                stu.nameOfTheUniversityPreviousStudied = dr.GetValue(15).ToString();
                stu.NOCnumber = Convert.ToInt64(dr.GetValue(16).ToString());
                stu.NOCdate = dr.GetValue(17).ToString();
                stu.theClassThatWantsToBeAdmitted = dr.GetValue(18).ToString();
                stu.admitionDate = dr.GetValue(19).ToString();
                StudentsList.Add(stu);
            }

            con.Close();

            return StudentsList;
        }

        public bool AddStudent(Student stu)
        {
            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("spAddStudent", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@studentName", stu.studentName);
            cmd.Parameters.AddWithValue("@fatherName", stu.fatherName);
            cmd.Parameters.AddWithValue("@fatherOccupation", stu.fatherOccupation);
            cmd.Parameters.AddWithValue("@motherName", stu.motherName);
            cmd.Parameters.AddWithValue("@motherOccupation", stu.motherOccupation);
            cmd.Parameters.AddWithValue("@dateOfBirth", stu.dateOfBirth);
            cmd.Parameters.AddWithValue("@presentAddress", stu.presentAddress);
            cmd.Parameters.AddWithValue("@permanentAddresses", stu.permanentAddresses);
            cmd.Parameters.AddWithValue("@fatherMobileNumber", stu.fatherMobileNumber);
            cmd.Parameters.AddWithValue("@motherMobileNumber", stu.motherMobileNumber);
            cmd.Parameters.AddWithValue("@legalGuardianName", stu.legalGuardianName);
            cmd.Parameters.AddWithValue("@legalGuardianRelation", stu.legalGuardianRelation);
            cmd.Parameters.AddWithValue("@legalGuardianOccupation", stu.legalGuardianOccupation);
            cmd.Parameters.AddWithValue("@legalGuardianMobileNumber", stu.legalGuardianMobileNumber);
            cmd.Parameters.AddWithValue("@nameOfTheUniversityPreviousStudied", stu.nameOfTheUniversityPreviousStudied);
            cmd.Parameters.AddWithValue("@NOCnumber", stu.NOCnumber);
            cmd.Parameters.AddWithValue("@NOCdate", stu.NOCdate);
            cmd.Parameters.AddWithValue("@theClassThatWantsToBeAdmitted", stu.theClassThatWantsToBeAdmitted);
            cmd.Parameters.AddWithValue("@admitionDate", stu.admitionDate);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateStudent(Student stu)
        {
            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("spUpdateStudent", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", stu.id);
            cmd.Parameters.AddWithValue("@studentName", stu.studentName);
            cmd.Parameters.AddWithValue("@fatherName", stu.fatherName);
            cmd.Parameters.AddWithValue("@fatherOccupation", stu.fatherOccupation);
            cmd.Parameters.AddWithValue("@motherName", stu.motherName);
            cmd.Parameters.AddWithValue("@motherOccupation", stu.motherOccupation);
            cmd.Parameters.AddWithValue("@dateOfBirth", stu.dateOfBirth);
            cmd.Parameters.AddWithValue("@presentAddress", stu.presentAddress);
            cmd.Parameters.AddWithValue("@permanentAddresses", stu.permanentAddresses);
            cmd.Parameters.AddWithValue("@fatherMobileNumber", stu.fatherMobileNumber);
            cmd.Parameters.AddWithValue("@motherMobileNumber", stu.motherMobileNumber);
            cmd.Parameters.AddWithValue("@legalGuardianName", stu.legalGuardianName);
            cmd.Parameters.AddWithValue("@legalGuardianRelation", stu.legalGuardianRelation);
            cmd.Parameters.AddWithValue("@legalGuardianOccupation", stu.legalGuardianOccupation);
            cmd.Parameters.AddWithValue("@legalGuardianMobileNumber", stu.legalGuardianMobileNumber);
            cmd.Parameters.AddWithValue("@nameOfTheUniversityPreviousStudied", stu.nameOfTheUniversityPreviousStudied);
            cmd.Parameters.AddWithValue("@NOCnumber", stu.NOCnumber);
            cmd.Parameters.AddWithValue("@NOCdate", stu.NOCdate);
            cmd.Parameters.AddWithValue("@theClassThatWantsToBeAdmitted", stu.theClassThatWantsToBeAdmitted);
            cmd.Parameters.AddWithValue("@admitionDate", stu.admitionDate);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteStudent(int id)
        {
            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("spDeleteStudent", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", id);     

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}