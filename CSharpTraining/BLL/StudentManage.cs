using DAL;
using Model;
using System.Collections.Generic;

namespace BLL
{
    public class StudentManage
    {
        public List<Student> GetListByClassId(string className)
        {
            return new StudentService().GetListByClassId(className);
        }
    }
}
