using DAL.Helper;
using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class StudentService
    {
        public List<Student> GetListByClassId(string className)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select * from [dbo].[Students] ");
            sqlBuilder.Append(
                "inner join [dbo].[StudentClass] on [dbo].[Students].ClassId = [dbo].[StudentClass].ClassId ");
            sqlBuilder.Append("where [dbo].[StudentClass].ClassName like '%{0}%'");


            string sql = string.Format(sqlBuilder.ToString(), className);

            try
            {
                List<Student> objStudents = new List<Student>();
                SqlDataReader objReaders = SQLHelper.GetDataReader(sql);
                while (objReaders.Read())
                {
                    objStudents.Add(new Student()
                    {
                        StudentId = Convert.ToInt32(objReaders["StudentId"]),
                        StudentName = objReaders["StudentName"].ToString(),
                        Gender = objReaders["Gender"].ToString(),
                        Birthday = Convert.ToDateTime(objReaders["Birthday"]),
                        StudentIdNo = objReaders["StudentIdNo"].ToString(),
                        CardNo = objReaders["CardNo"].ToString(),
                        PhoneNumber = objReaders["PhoneNumber"].ToString(),
                        StudentAddress = objReaders["StudentAddress"].ToString(),
                        ClassId = Convert.ToInt32(objReaders["ClassId"])
                    });
                }
                objReaders.Close();
                return objStudents;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int InsertStudent(Student objStudent)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append(
                "insert into [dbo].[Students] (StudentName, Gender, Birthday, StudentIdNo, CardNo, PhoneNumber, StudentAddress, ClassId) ");
            sqlBuilder.Append("values('{0}', '{1}', '{2}', {3}, '{4}', '{5}', '{6}', {7})");
            string sql = string.Format(sqlBuilder.ToString(), objStudent.StudentName, objStudent.Gender,
                objStudent.Birthday, objStudent.StudentIdNo, objStudent.CardNo, objStudent.PhoneNumber,
                objStudent.StudentAddress, objStudent.ClassId);

            try
            {
                return SQLHelper.Update(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        public Student GetStudent(string studentId)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select * from [dbo].[Students] where StudentId={0}");
            string sql = string.Format(sqlBuilder.ToString(), studentId);

            try
            {
                SqlDataReader objReader = SQLHelper.GetDataReader(sql);
                Student objStudent = new Student();
                if (objReader.Read())
                {
                    objStudent.StudentId = Convert.ToInt32(studentId);
                    objStudent.StudentName = objReader["StudentName"].ToString();
                    objStudent.Gender = objReader["Gender"].ToString();
                    objStudent.Birthday = Convert.ToDateTime(objReader["Birthday"]);
                    objStudent.StudentIdNo = objReader["StudentIdNo"].ToString();
                    objStudent.CardNo = objReader["CardNo"].ToString();
                    objStudent.PhoneNumber = objReader["PhoneNumber"].ToString();
                    objStudent.StudentAddress = objReader["StudentAddress"].ToString();
                    objStudent.ClassId = Convert.ToInt32(objReader["ClassId"]);

                }
                objReader.Close();
                return objStudent;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int EditStudent(Student objStudent)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("update [dbo].[Students] set StudentName='{0}', Gender='{1}', Birthday='{2}', ");
            sqlBuilder.Append(" StudentIdNo='{3}', CardNo='{4}', PhoneNumber='{5}',StudentAddress='{6}', ClassId={7}");
            sqlBuilder.Append(" where StudentId={8}");
            string sql = string.Format(sqlBuilder.ToString(), objStudent.StudentName, objStudent.Gender,
                objStudent.Birthday, objStudent.StudentIdNo, objStudent.CardNo, objStudent.PhoneNumber,
                objStudent.StudentAddress, objStudent.ClassId, objStudent.StudentId);

            try
            {
                return SQLHelper.Update(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
