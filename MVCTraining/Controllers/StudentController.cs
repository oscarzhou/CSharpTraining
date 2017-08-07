using BLL;
using Model;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCTraining.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/

        public ActionResult Index()
        {
            return View("StudentManage");
        }

        public ActionResult GetList()
        {
            string queryClass = Request.Params["query"].ToString();

            List<Student> objStudents = new StudentManage().GetListByClassId(queryClass);
            ViewBag.className = queryClass;
            ViewBag.stuList = objStudents;

            return View("StudentManage");
        }

    }
}
