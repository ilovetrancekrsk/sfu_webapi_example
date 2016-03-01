using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class AngularController : Controller
    {
        // GET: Angular
        public ActionResult Index()
        {
            ViewBag.Title = "AngularJS + WebAPI 2 Example";

            return View();
        }
    }
}