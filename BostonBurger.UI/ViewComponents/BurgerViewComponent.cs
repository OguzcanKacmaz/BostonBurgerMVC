using BostonBurger.DATA.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BostonBurger.UI.ViewComponents
{
    public class BurgerViewComponent : ViewComponent
    {
        private readonly UygulamaDbContext _db;

        public BurgerViewComponent(UygulamaDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var burgerler = await _db.Burgerler.ToListAsync();
            return View(burgerler);
        }
    }
}
