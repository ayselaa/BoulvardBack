using Microsoft.AspNetCore.Mvc;

namespace Boulvrd.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
