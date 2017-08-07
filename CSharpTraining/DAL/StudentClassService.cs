using DAL.Helper;
using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class StudentClassService
    {
        public List<StudentClass> GetAllClasses()
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select * from [dbo].[StudentClass]");

            try
            {
                SqlDataReader objReaders = SQLHelper.GetDataReader(sqlBuilder.ToString());
                List<StudentClass> objStudentClasses = new List<StudentClass>();
                while (objReaders.Read())
                {
                    objStudentClasses.Add(new StudentClass()
                    {
                        ClassId = Convert.ToInt32(objReaders["ClassId"]),
                        ClassName = objReaders["ClassName"].ToString()
                    });
                }
                objReaders.Close();
                return objStudentClasses;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public string GetClassNameById(string classId)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select ClassName from [dbo].[StudentClass] where ClassId={0}");
            string sql = string.Format(sqlBuilder.ToString(), classId);

            try
            {
                return (string) SQLHelper.GetSigleObject(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
