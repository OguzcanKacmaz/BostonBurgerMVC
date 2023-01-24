using Microsoft.AspNetCore.Mvc;

namespace BostonBurger.UI.Controllers
{
    public class SosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
