using Microsoft.AspNetCore.Mvc;

namespace Task22.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
