using Microsoft.AspNetCore.Mvc;

namespace OrFarm.Controllers.Account
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Account/Login/Index.cshtml");
        }
    }
}
