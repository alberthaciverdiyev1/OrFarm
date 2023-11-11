using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OrFarm.DAL;
using OrFarm.Models.Account;
using OrFarm.ViewModels.Account;

namespace OrFarm.Controllers.Account
{
    public class LoginController : Controller
    {

        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<UserRole> _roleManager;

        public LoginController(
            AppDbContext context,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            RoleManager<UserRole> roleManager
)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View("~/Views/Account/Login/Index.cshtml");
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Username, Email or Password is Incorrect");
                return View("~/Views/Account/Login/Index.cshtml");
            }

            AppUser user = await _userManager.FindByNameAsync(login.UsernameOrEmail);
            if (user == null)
            {
                user = await _userManager.FindByEmailAsync(login.UsernameOrEmail);
                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "Username, Email or Password is Incorrect");
                    return View("~/Views/Account/Login/Index.cshtml");
                }
            }
            //if (!user.EmailConfirmed)
            //{
            //    ModelState.AddModelError(String.Empty, "Please confirm your email");
            //    return View("~/Views/Account/Login/Index.cshtml");

            //}
            var result = await _signInManager.PasswordSignInAsync(user, login.Password, login.RememberMe, true);
            if (!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Username, Email or Password is Incorrect");
                return View("~/Views/Account/Login/Index.cshtml");
            }

            //if (!string.IsNullOrEmpty(ReturnUrl) && Url.IsLocalUrl(ReturnUrl))
            //{
            //    return LocalRedirect(ReturnUrl);
            //}

            return RedirectToAction(nameof(Index), "Home");
        }


    }
}
