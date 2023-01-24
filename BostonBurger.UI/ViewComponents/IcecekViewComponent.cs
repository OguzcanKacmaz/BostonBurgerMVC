using BostonBurger.DATA.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BostonBurger.UI.ViewComponents
{
    public class IcecekViewComponent : ViewComponent
    {
        private readonly UygulamaDbContext _db;

        public IcecekViewComponent(UygulamaDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var icecekler = await _db.Icecekler.ToListAsync();
            return View(icecekler);
        }
    }
}
