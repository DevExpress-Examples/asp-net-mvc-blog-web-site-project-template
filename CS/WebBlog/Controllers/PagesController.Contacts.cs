using System.Web.Mvc;

namespace WebBlog.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult Contacts()
        {
            return View();
        }
    }
}