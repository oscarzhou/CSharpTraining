using BLL;
using Model;
using System;
using System.Web.Mvc;

namespace MVCTraining.Controllers
{
    public class SysAdminController : Controller
    {
        //
        // GET: /SysAdmin/

        public ActionResult Index()
        {
            return View("AdminLogin");
        }

        public ActionResult Login()
        {
            SysAdmin objSysAdmin = new SysAdmin()
            {
                LoginId = Convert.ToInt32(Request.Params["loginId"]),
                LoginPwd = Request.Params["loginPwd"].ToString()
            };

            objSysAdmin = new SysAdminManage().Login(objSysAdmin);
            if (objSysAdmin != null)
            {
                ViewData["info"] = "welcome: " + objSysAdmin.AdminName;
            }

            return View("AdminLogin");
        }

    }
}
