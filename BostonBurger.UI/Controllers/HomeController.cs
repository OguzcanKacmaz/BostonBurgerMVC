using BostonBurger.BL.EntityFramework;
using BostonBurger.DATA.Context;
using BostonBurger.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Text.Json;

namespace BostonBurger.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly UygulamaDbContext _db;
        private readonly EfMenuDal _efMenuDal;
        private readonly EfAtistirmalikDal _efAtistirmalikDal;
        private readonly EfBurgerDal _efBurgerDal;
        private readonly EfEkstraMalzemeDal _efEkstraMalzemeDal;
        private readonly EfIcecekDal _efIcecekDal;
        private readonly EfSosDal _efSosDal;

        public HomeController(UygulamaDbContext db, EfMenuDal efMenuDal, EfAtistirmalikDal efAtistirmalikDal, EfBurgerDal efBurgerDal, EfEkstraMalzemeDal efEkstraMalzemeDal, EfIcecekDal efIcecekDal, EfSosDal efSosDal)
        {
            _db = db;
            _efMenuDal = efMenuDal;
            _efAtistirmalikDal = efAtistirmalikDal;
            _efBurgerDal = efBurgerDal;
            _efEkstraMalzemeDal = efEkstraMalzemeDal;
            _efIcecekDal = efIcecekDal;
            _efSosDal = efSosDal;
        }
        public IActionResult Index(int secilen, string tur)
        {
            var menuler = _efMenuDal.GetList();
            var atistirmaliklar = _efAtistirmalikDal.GetList();
            var burgerler = _efBurgerDal.GetList();
            var ekstraMalzemeler = _efEkstraMalzemeDal.GetList();
            var icecekler = _efIcecekDal.GetList();
            var soslar = _efSosDal.GetList();
            UrunlerViewModel vm = new UrunlerViewModel();
            vm.Soslar = soslar;
            vm.Atistirmaliklar = atistirmaliklar;
            vm.Burgerler = burgerler;
            vm.Menuler = menuler;
            vm.EkstraMalzemeler = ekstraMalzemeler;
            vm.Icecekler = icecekler;            
            return View(vm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}