using BLL;
using Model;
using System.Web.Mvc;

namespace MVCTraining.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/

        public ActionResult Index()
        {
            return View("Register");
        }

        [HttpPost]
        public ActionResult Register(Customer objCustomer)
        {
            if (ModelState.IsValid)
            {
                CustomerManage objCustomerManage = new CustomerManage();
                if (!objCustomerManage.Register(objCustomer))
                {
                    ModelState.AddModelError("doubleUser", "当前用户名已被使用，请重新输入!");
                    return View("Register", objCustomer);
                }
                else
                {
                    return Content("<script>alert('注册成功,请继续购物!');window.location='" + Url.Content("~/") + "'</script>");
                }


            }
            else
            {
                return View("Register", objCustomer);    
            }
            
        }
    }
}
