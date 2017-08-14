using BLL;
using Model;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace MVCTraining.Controllers
{
    public class FileController : Controller
    {
        //
        // GET: /File/

        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            if (file != null)
            {
                string filePath = Server.MapPath("~/files/") + file.FileName;
                file.SaveAs(filePath);
                return
                    Content("<script>alert('Uploading successfully!');location.href='" + Url.Content("~/Files") +
                            "'</script>");
                
            }
            return View("Index");
        }

        public ActionResult AddStaticNews()
        {
            return View("AddStaticNews");
        }

        public ActionResult AddDynamicNews()
        {
            List<NewsCategory> objCategories = new NewsManage().GetNewsCategory();
            SelectList list = new SelectList(objCategories, "CategoryId", "CategoryName", objCategories[0].CategoryId);
            ViewBag.Category = list;
            return View("AddDynamicNews");
        }

        [ValidateInput(false)]
        [HttpPost]
        public ActionResult PostNews(News objNews)
        {
            // Save the instance News to database

            return View("AddDynamicNews");
        }
    }
}
