using Microsoft.AspNetCore.Mvc;

namespace OrFarm.Controllers.Blog
{
    public class AllController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Blog/All.cshtml");
        }
        public IActionResult Details()
        {
            return View("~/Views/Blog/Details.cshtml");
        }
    }
}
