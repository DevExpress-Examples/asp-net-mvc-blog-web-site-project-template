using System.Web.Mvc;

namespace WebBlog.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult Home()
        {
            return View();
        }
    }
}