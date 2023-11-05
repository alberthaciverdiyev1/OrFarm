using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrFarm.Controllers.WishList
{
    public class WishListController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}
