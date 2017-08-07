using DAL;
using Model;
using System.Collections.Generic;

namespace BLL
{
    public class StudentManage
    {
        private StudentService objStudentService = new StudentService();
        public List<Student> GetListByClassId(string className)
        {
            return objStudentService.GetListByClassId(className);
        }

        public int InsertStudent(Student objStudent)
        {
            return objStudentService.InsertStudent(objStudent);
        }
    }
}
