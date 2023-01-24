using BostonBurger.DATA.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BostonBurger.UI.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly UygulamaDbContext _db;

        public MenuViewComponent(UygulamaDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menuler = await _db.Menuler.ToListAsync();
            return View(menuler);
        }

    }
}
