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
            // 获取用户输入数据
            SysAdmin objSysAdmin = new SysAdmin()
            {
                LoginId = Convert.ToInt32(Request.Params["loginId"]),
                LoginPwd = Request.Params["loginPwd"]
            };
            //调用业务逻辑
            objSysAdmin = new SysAdminManage().Login(objSysAdmin);


            //保存数据 
            if (objSysAdmin != null)
            {
                ViewData["info"] = "welcome: " + objSysAdmin.AdminName;
                return RedirectToAction("Index", "Student");
            }
            else
            {
                ViewData["info"] = "user name or password error!";
                return View("AdminLogin");
            }

        }

    }
}
