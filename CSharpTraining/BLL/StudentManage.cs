using DAL;
using Model;
using System.Collections.Generic;
using System.Web;

namespace BLL
{
    public class StudentManage
    {
        private StudentService objStudentService = new StudentService();
        public List<Student> GetListByClassId(string className)
        {
            if (className != null)
            {
                //将搜索条件保存到session
                HttpContext.Current.Session["query"] = className;
            }
            return objStudentService.GetListByClassId(className);
        }

        public int InsertStudent(Student objStudent)
        {
            return objStudentService.InsertStudent(objStudent);
        }

        public Student GetStudent(string studentId)
        {
            return objStudentService.GetStudent(studentId);
        }

        public int EditStudent(Student objStudent)
        {
            return objStudentService.EditStudent(objStudent);
        }

        public int DeleteStudent(string stuId)
        {
            return objStudentService.DeleteStudent(stuId);
        }
    }
}
