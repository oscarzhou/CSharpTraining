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
        public ActionResult Register(Customer objCustomer, string validateCode)
        {
            if (ModelState.IsValid)
            {
                if (string.Compare(TempData["ValidateCode"].ToString(), validateCode, true) != 0)
                {
                    ModelState.AddModelError("ValidateCode", "验证码不正确，请重新输入");
                    return View("Register");
                }


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


        public ActionResult ValidateCode()
        {
            CreateValidateCode objCreateCode = new CreateValidateCode();
            string code = objCreateCode.CreateRandomCode(5);
            TempData["ValidateCode"] = code;
            return File(objCreateCode.CreateValidateGraphic(code), "image/Jpeg");
        }
    }
}
