using Microsoft.AspNetCore.Mvc;

namespace OrFarm.Controllers.Shop
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Shop/Index.cshtml");

        }
    }
}
