using BostonBurger.DATA.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BostonBurger.UI.ViewComponents
{
    public class SoslarViewComponent : ViewComponent
    {
        private readonly UygulamaDbContext _db;

        public SoslarViewComponent(UygulamaDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var soslar = await _db.Soslar.ToListAsync();
            return View(soslar);
        }
    }
}
