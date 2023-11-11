using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Orfarm.Controllers.Transport
{
    public class AddController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add()
        {

            //if (register.Photo != null)
            //{

            //    if (register.Photo.ContentType.Contains("image/"))
            //    {
            //        if (register.Photo.Length < 1024 * 500)
            //        {
            //            string filename = Guid.NewGuid().ToString() + register.Photo.FileName;
            //            string path = Path.Combine(_env.WebRootPath, "assets/images/User", filename);
            //            FileStream stream = new FileStream(path, FileMode.Create);
            //            await register.Photo.CopyToAsync(stream);
            //            stream.Close();
            //            register.DateTime = DateTime.Now;
            //            register.ImageURL = filename;

            //        }
            //        else
            //        {
            //            ModelState.AddModelError(string.Empty, "Seklin olcusu 500kbdan boyuk ola bilmez");
            //            ViewBag.Professions = _context.Positions.ToList();

            //            return View();
            //        }
            //    }
            //    else
            //    {
            //        ModelState.AddModelError(string.Empty, "Seklin formati duzgun deyil");
            //        ViewBag.Professions = _context.Positions.ToList();

            //        return View();
            //    }
            //}
            return RedirectToAction(nameof(Index), "Home");
        }
    }
}
