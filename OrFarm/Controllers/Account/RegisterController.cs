using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OrFarm.DAL;
using OrFarm.Models.Account;
using OrFarm.ViewModels.Account;
using System.ComponentModel.DataAnnotations;

namespace OrFarm.Controllers.Account
{
    public class RegisterController : Controller
    {
        private readonly AppDbContext _context;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<UserRole> _roleManager;

        public RegisterController(
            AppDbContext context,
            SignInManager<AppUser> signInManager,
            UserManager<AppUser> userManager,
            RoleManager<UserRole> roleManager
            )
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View("~/Views/Account/Register/Index.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) { return View("~/Views/Account/Register/Index.cshtml"); }
            AppUser check = await _userManager.FindByEmailAsync(register.Email);
            if (check != null)
            {
                check = await _userManager.FindByNameAsync(register.Username);

                if (check != null)
                {
                    ModelState.AddModelError(string.Empty, "This user already exists");
                    return View();

                }
            }

            AppUser user = new AppUser
            {
                Email = register.Email,
                Name = register.Name,
                Surname = register.Surname,
                //Username = register.Username,
            };
            IdentityResult result = await _userManager.CreateAsync(user, register.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View();

            }
            await _signInManager.SignInAsync(user, false);


            return View();
        }
    }
}
