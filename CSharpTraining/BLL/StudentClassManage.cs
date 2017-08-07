using DAL;
using Model;
using System.Collections.Generic;

namespace BLL
{
    public class StudentClassManage
    {
        private StudentClassService objStudentClassService = new StudentClassService();

        public List<StudentClass> GetAllClasses()
        {
            return objStudentClassService.GetAllClasses();
        }

        public string GetClassNameById(string classId)
        {
            return objStudentClassService.GetClassNameById(classId);
        }
    }
}
