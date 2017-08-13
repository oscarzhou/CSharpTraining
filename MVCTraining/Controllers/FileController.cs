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

    }
}
