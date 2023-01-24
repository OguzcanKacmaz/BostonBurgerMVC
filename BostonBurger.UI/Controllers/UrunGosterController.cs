using BostonBurger.BL.EntityFramework;
using BostonBurger.DATA.Context;
using Microsoft.AspNetCore.Mvc;

namespace BostonBurger.UI.Controllers
{
    public class UrunGosterController : Controller
    {
        private readonly UygulamaDbContext _db;

        public UrunGosterController(UygulamaDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int urunNo,string tur)
        {
            if (tur=="Burger")
            {
                EfBurgerDal efBurgerDal = new EfBurgerDal(_db);
                var urun=efBurgerDal.GetById(urunNo);
                return View(urun);
            }
            else if (tur == "Atistirmalik")
            {
                EfAtistirmalikDal efAtistirmalikDal = new EfAtistirmalikDal(_db);
                var urun = efAtistirmalikDal.GetById(urunNo);
                return View(urun);
            }
            else if (tur == "Icecek")
            {
                EfIcecekDal efIcecekDal = new EfIcecekDal(_db);
                var urun = efIcecekDal.GetById(urunNo);
                return View(urun);
            }
            else if (tur == "Menu")
            {
                EfMenuDal efMenuDal = new EfMenuDal(_db);
                var urun = efMenuDal.GetById(urunNo);
                return View(urun);
            }
            else if (tur == "Sos")
            {
                EfSosDal efSosDal = new EfSosDal(_db);
                var urun = efSosDal.GetById(urunNo);
                return View(urun);
            }
            return NotFound();
        }
    }
}
