using Microsoft.AspNetCore.Mvc;

namespace Task22.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
