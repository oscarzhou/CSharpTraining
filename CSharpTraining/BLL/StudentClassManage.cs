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
    }
}
