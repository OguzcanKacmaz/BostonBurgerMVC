using Microsoft.AspNetCore.Mvc;

namespace BostonBurger.UI.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
