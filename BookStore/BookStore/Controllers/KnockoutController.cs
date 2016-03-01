using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class KnockoutController : Controller
    {
        // GET: Knockout
        public ActionResult Index()
        {
            ViewBag.Title = "KnockoutJS + WebAPI 2 Example";

            return View();
        }
    }
}