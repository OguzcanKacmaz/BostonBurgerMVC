using BostonBurger.BL.Abstract;
using BostonBurger.BL.EntityFramework;
using BostonBurger.DATA.Context;
using BostonBurger.ENTITIES.Abstract;
using BostonBurger.ENTITIES.Concreate;
using BostonBurger.ENTITIES.Enumlar;
using BostonBurger.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Linq;
using System.Text.Json;

namespace BostonBurger.UI.Controllers
{
    public class SiparisController : Controller
    {
        public static List<BaseEntity> Sepet { get; set; } = new List<BaseEntity>();
        private readonly UygulamaDbContext _db;
        private readonly EfMenuDal _efMenuDal;
        private readonly EfAtistirmalikDal _efAtistirmalikDal;
        private readonly EfBurgerDal _efBurgerDal;
        private readonly EfEkstraMalzemeDal _efEkstraMalzemeDal;
        private readonly EfIcecekDal _efIcecekDal;
        private readonly EfSosDal _efSosDal;
        private readonly EfSiparisDal _efSiparisDal;
        private readonly EfMenuSiparisDal _efMenuSiparisDal;
        private readonly EfBurgerSiparisDal _efBurgerSiparisDal;
        private readonly EfIcecekSiparisDal _efIcecekSiparisDal;
        private readonly EfAtistirmalikSiparisDal _efAtistirmalikSiparisDal;
        private readonly EfEkstraMalzemeSiparisDal _efEkstraMalzemeSiparisDal;
        private readonly EfSosSiparisDal _efSosSiparisDal;

        public SiparisController(UygulamaDbContext db, EfMenuDal efMenuDal, EfAtistirmalikDal efAtistirmalikDal, EfBurgerDal efBurgerDal, EfEkstraMalzemeDal efEkstraMalzemeDal, EfIcecekDal efIcecekDal, EfSosDal efSosDal, EfSiparisDal efSiparisDal, EfMenuSiparisDal efMenuSiparisDal,EfBurgerSiparisDal efBurgerSiparisDal,EfIcecekSiparisDal efIcecekSiparisDal,EfAtistirmalikSiparisDal efAtistirmalikSiparisDal,EfEkstraMalzemeSiparisDal efEkstraMalzemeSiparisDal,EfSosSiparisDal efSosSiparisDal)
        {
            _db = db;
            _efMenuDal = efMenuDal;
            _efAtistirmalikDal = efAtistirmalikDal;
            _efBurgerDal = efBurgerDal;
            _efEkstraMalzemeDal = efEkstraMalzemeDal;
            _efIcecekDal = efIcecekDal;
            _efSosDal = efSosDal;
            _efSiparisDal = efSiparisDal;
            _efMenuSiparisDal = efMenuSiparisDal;
            _efBurgerSiparisDal = efBurgerSiparisDal;
            _efIcecekSiparisDal = efIcecekSiparisDal;
            _efAtistirmalikSiparisDal = efAtistirmalikSiparisDal;
            _efEkstraMalzemeSiparisDal = efEkstraMalzemeSiparisDal;
            _efSosSiparisDal = efSosSiparisDal;
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
            vm.Sepet = Sepet;
            ViewBag.SepetUrunSayisi = Sepet.Count();
            return View(vm);
        }
        public IActionResult SepetiTemizle()
        {
            Sepet = new();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult SepetEkle(int menuId, string tur)
        {

            if (tur == "Menu")
            {
                var menu = _efMenuDal.GetById(menuId);
                Sepet.Add(menu);
            }
            else if (tur == "Burger")
            {
                var menu = _efBurgerDal.GetById(menuId);
                Sepet.Add(menu);
            }
            else if (tur == "Icecek")
            {
                var menu = _efIcecekDal.GetById(menuId);
                Sepet.Add(menu);
            }
            else if (tur == "Atistirmalik")
            {
                var menu = _efAtistirmalikDal.GetById(menuId);
                Sepet.Add(menu);
            }
            else if (tur == "EkstraMalzeme")
            {
                var menu = _efEkstraMalzemeDal.GetById(menuId);
                Sepet.Add(menu);
            }
            else if (tur == "Sos")
            {
                var menu = _efSosDal.GetById(menuId);
                Sepet.Add(menu);
            }
            return RedirectToAction("Index");
        }
        public IActionResult SepeteGit(UrunlerViewModel urunlerViewModel)
        {
            if (ModelState.IsValid)
            {
                decimal fiyat = 0;
                SepetViewModel vm = new SepetViewModel();
                foreach (var urun in Sepet)
                {
                    fiyat += urun.Fiyat;
                }
                if (urunlerViewModel.Boyut == Boyut.Orta)
                {
                    fiyat += fiyat * 0.10M;
                }
                else if (urunlerViewModel.Boyut == Boyut.Buyuk)
                {
                    fiyat += fiyat * 0.20M;
                }
                fiyat *= urunlerViewModel.Adet;
                vm.Fiyat = fiyat;
                vm.Sepet = Sepet;
                vm.Boyut = urunlerViewModel.Boyut;
                vm.Adet = urunlerViewModel.Adet;
                return View(vm);
            }
            return RedirectToAction("SepetEkle");

        }
        public IActionResult SepetiOnayla()
        {
            return RedirectToAction("Index", "Home");
        }

        [HttpPost, AutoValidateAntiforgeryToken]
        public IActionResult SepetiOnayla(SepetViewModel vm)
        {
            vm.Sepet = Sepet;
            if (ModelState.IsValid)
            {
                Siparis siparis = new Siparis();
                siparis.SiparisOnaylandı = true;
                siparis.Adet = vm.Adet;
                siparis.SiparisBoyut = vm.Boyut;
                siparis.Fiyat = vm.Fiyat;
                _efSiparisDal.Insert(siparis);

                foreach (var urun in vm.Sepet)
                {
                    var kategoriAdi = _db.Kategoriler.Find(urun.KategoriID)!.KategoriAdı;
                    if (kategoriAdi == "Menu")
                    {
                        MenuSiparis menuSiparis = new MenuSiparis()
                        {
                            MenuID = urun.ID,
                            SiparisID = siparis.ID,
                        };
                        _efMenuSiparisDal.Insert(menuSiparis);
                    }
                    else if (kategoriAdi == "Burger")
                    {
                        BurgerSiparis burgerSiparis = new BurgerSiparis() { BurgerID= urun.ID,SiparisID=siparis.ID };
                        _efBurgerSiparisDal.Insert(burgerSiparis);
                    }
                    else if (kategoriAdi == "Icecek")
                    {
                        IcecekSiparis ıcecekSiparis=new IcecekSiparis() { IcecekID=urun.ID,SiparisID=siparis.ID };
                        _efIcecekSiparisDal.Insert(ıcecekSiparis);
                    }
                    else if (kategoriAdi == "Atistirmalik")
                    {
                        AtistirmalikSiparis atistirmalikSiparis= new AtistirmalikSiparis() { AtistirmalikID=urun.ID,SiparisID= siparis.ID };
                        _efAtistirmalikSiparisDal.Insert(atistirmalikSiparis);
                    }
                    else if (kategoriAdi == "EkstraMalzeme")
                    {
                        EkstraMalzemeSiparis ekstraMalzemeSiparis=new EkstraMalzemeSiparis() { EkstraMalzemeID=urun.ID,SiparisID=siparis.ID };
                        _efEkstraMalzemeSiparisDal.Insert(ekstraMalzemeSiparis);
                    }
                    else if (kategoriAdi == "Sos")
                    {
                        SosSiparis sosSiparis = new SosSiparis() { SosID = urun.ID, SiparisID = siparis.ID };
                        _efSosSiparisDal.Insert(sosSiparis);
                    }
                }

                Sepet = new();
                TempData["Mesaj"] = "Siparişiniz Alındı";
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("SepeteGit", "Siparis");
        }
    }
}
