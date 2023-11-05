using Microsoft.AspNetCore.Mvc;

namespace OrFarm.Controllers.Account
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Account/Register/Index.cshtml");
        }
    }
}
