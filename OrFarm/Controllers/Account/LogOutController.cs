using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrFarm.DAL;
using OrFarm.Models.Account;

namespace OrFarm.Controllers.Account
{
    public class LogOutController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        public LogOutController(
           SignInManager<AppUser> signInManager
)
        {
            _signInManager = signInManager;
        }
        public async Task<IActionResult> Index()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");

        }
    }
}
