using Microsoft.AspNetCore.Mvc;
using Task22.Models;

namespace Task22.Controllers
{
    public class DesignController : Controller
    {
        public IActionResult Index()
        {
            Furniture furniture = new Furniture()
            {
                Id = 1,
                Name = "Stul",
                Price=100
            };
            Furniture furniture1 = new Furniture()
            {
                Id = 2,
                Name = "Stul",
                Price=150
            };
            Furniture furniture2 = new Furniture()
            {
                Id = 3,
                Name = "Stul",
                Price=200
            };
            List<Furniture> furnitureList = new List<Furniture>();
            furnitureList.Add(furniture);
            furnitureList.Add(furniture1);
            furnitureList.Add(furniture2);
        
            ViewBag.Furniture = furnitureList;
            return View();
        }
    }

    
}
