using Microsoft.AspNetCore.Mvc;

namespace Task22.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
