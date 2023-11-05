using Microsoft.AspNetCore.Mvc;

namespace OrFarm.Controllers.ContactUs
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/ContactUs/Index.cshtml");
        }
    }
}
