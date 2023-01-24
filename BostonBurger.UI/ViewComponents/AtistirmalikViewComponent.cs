using BostonBurger.DATA.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BostonBurger.UI.ViewComponents
{
    public class AtistirmalikViewComponent : ViewComponent
    {
        private readonly UygulamaDbContext _db;

        public AtistirmalikViewComponent(UygulamaDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var atistirmalik = await _db.Atistirmaliklar.ToListAsync();
            return View(atistirmalik);
        }
    }
}
