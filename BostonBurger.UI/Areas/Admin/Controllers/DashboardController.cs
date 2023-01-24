using BostonBurger.DATA.Context;
using Microsoft.AspNetCore.Mvc;

namespace BostonBurger.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly UygulamaDbContext _db;

        public DashboardController(UygulamaDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewBag.Icerik = "Dashboard";
            ViewBag.Sayfa = "Dashboard";
            ViewBag.Index = "Index";
            ViewBag.Kazanc = _db.Siparisler.Where(x=>x.SiparisOnaylandı==true).Sum(x => x.Fiyat);
            return View();
        }
    }
}
