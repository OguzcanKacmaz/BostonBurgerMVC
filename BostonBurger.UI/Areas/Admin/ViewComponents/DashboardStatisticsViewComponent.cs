using BostonBurger.BL.EntityFramework;
using BostonBurger.DATA.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BostonBurger.UI.Areas.Admin.ViewComponents
{
    [Area("Admin")]
    public class DashboardStatisticsViewComponent : ViewComponent
    {
        private readonly UygulamaDbContext _db;
        private readonly EfSiparisDal _efSiparisDal;

        public DashboardStatisticsViewComponent(UygulamaDbContext db,EfSiparisDal efSiparisDal)
        {
            _db = db;
            _efSiparisDal = efSiparisDal;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.ToplamSiparis = _efSiparisDal.GetList().Count();
            ViewBag.OnaylananSiparis = _db.Siparisler.Where(x => x.SiparisOnaylandı == true).Count();
            ViewBag.İptalOlanSiparis = _db.Siparisler.Where(x => x.SiparisOnaylandı == false).Count();
            return View();
        }
    }
}
