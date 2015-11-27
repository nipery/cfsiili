using Microsoft.AspNet.Mvc;

namespace CrossFitSiili.Controllers.web
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}