using Microsoft.AspNetCore.Mvc;

namespace OrFarm.Controllers.AboutUs
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/AboutUs/Index.cshtml");
        }
    }
}
