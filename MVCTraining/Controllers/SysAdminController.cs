using BLL;
using Model;
using System.Web.Mvc;
using System.Web.Security;

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

        [HttpPost]
        public ActionResult Login(SysAdmin objSysAdmin)
        {
            //调用业务逻辑
            objSysAdmin = new SysAdminManage().Login(objSysAdmin);
            if (objSysAdmin.AdminName != null)
            {
                //为当前用户名提供一个身份验证票证，并将该票证添加到Cookie
                FormsAuthentication.SetAuthCookie(objSysAdmin.AdminName, false);
                ViewData["info"] = "welcome: " + objSysAdmin.AdminName;
                return RedirectToAction("Index", "Student");
            }
            else
            {
                ViewData["info"] = "user name or password error!";
                return View("AdminLogin");
            }
        }

        [Authorize]
        public ActionResult AdminExit(SysAdmin objSysAdmin)
        {
            FormsAuthentication.SignOut();//从浏览器中删除Forms身份验证票证
            Session["CurrentAdmin"] = null;//从Session中清除
            return View("AdminLogin");//返回登录页面
        }





        //public ActionResult Login(string loginId, string loginPwd)
        //{
        //    // 获取用户输入数据
        //    SysAdmin objSysAdmin = new SysAdmin()
        //    {
        //        LoginId = Convert.ToInt32(loginId),
        //        LoginPwd = loginPwd
        //    };
        //    //调用业务逻辑
        //    objSysAdmin = new SysAdminManage().Login(objSysAdmin);

        //    //保存数据 
        //    if (objSysAdmin != null)
        //    {
        //        ViewData["info"] = "welcome: " + objSysAdmin.AdminName;
        //        return RedirectToAction("Index", "Student");
        //    }
        //    else
        //    {
        //        ViewData["info"] = "user name or password error!";
        //        return View("AdminLogin");
        //    }

        //}

    }
}
