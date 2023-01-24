using Microsoft.AspNetCore.Mvc;

namespace BostonBurger.UI.Controllers
{
    public class BurgerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
