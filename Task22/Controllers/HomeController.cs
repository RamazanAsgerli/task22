using Microsoft.AspNetCore.Mvc;

namespace Task22.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
