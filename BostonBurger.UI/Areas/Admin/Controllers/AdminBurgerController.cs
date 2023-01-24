using BostonBurger.BL.EntityFramework;
using BostonBurger.ENTITIES.Concreate;
using BostonBurger.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace BostonBurger.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminBurgerController : Controller
    {
        private readonly EfBurgerDal _efBurgerDal;
        private readonly IWebHostEnvironment _env;

        public AdminBurgerController(EfBurgerDal efBurgerDal,IWebHostEnvironment env)
        {
            _efBurgerDal = efBurgerDal;
            _env = env;
        }
        public IActionResult Index()
        {
            ViewBag.Icerik = "Burger";
            ViewBag.Sayfa = "AdminBurger";
            ViewBag.Index = "Index";
            var burgerler = _efBurgerDal.GetList();
            return View(burgerler);
        }
        public IActionResult BurgerEkle()
        {
            ViewBag.Icerik = "Burger";
            ViewBag.Sayfa = "AdminBurger";
            ViewBag.Index = "BurgerEkle";
            return View();
        }
        [HttpPost, AutoValidateAntiforgeryToken]
        public IActionResult BurgerEkle(MenuViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Burger burger = new Burger()
                {
                    Adı = vm.Adı,
                    Fiyat = vm.Fiyat,
                    Aciklama = vm.Aciklama,
                    Resim = ResimEkle(vm.Resim),
                    KategoriID=1
                };
                _efBurgerDal.Insert(burger);
                TempData["Mesaj"] = "Burger Eklendi";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult BurgerSil(int burgerId)
        {
            if (ModelState.IsValid)
            {
                _efBurgerDal.Delete(_efBurgerDal.GetById(burgerId));
                TempData["Mesaj"] = "Menu Silindi";
            }
            return RedirectToAction("Index");
        }
        public IActionResult BurgerGuncelle(int burgerId)
        {
            if (ModelState.IsValid)
            {
                var burger = _efBurgerDal.GetById(burgerId);
                MenuEditViewModel vm = new MenuEditViewModel()
                {
                    ID = burger.ID,
                    Adı = burger.Adı,
                    Fiyat = burger.Fiyat,
                    Aciklama = burger.Aciklama
                };

                return View(vm);
            }
            return View();
        }
        [HttpPost, AutoValidateAntiforgeryToken]
        public IActionResult BurgerGuncelle(MenuEditViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var secili = _efBurgerDal.GetById(vm.ID);
                secili.Adı = vm.Adı;
                secili.Fiyat = vm.Fiyat;
                secili.Aciklama = vm.Aciklama;
                secili.ID = vm.ID;
                if (vm.Resim != null)
                {
                    ResimSil(secili.Resim);
                    secili.Resim = ResimEkle(vm.Resim);
                }
                TempData["Mesaj"] = "Burger Güncellendi";
                _efBurgerDal.Update(secili);

                return RedirectToAction("Index");
            }
            return View();
        }

        private void ResimSil(string resim)
        {
            if (string.IsNullOrEmpty(resim))
                return;

            string filePath = Path.Combine(_env.WebRootPath, "img", resim);

            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
        }

        private string ResimEkle(IFormFile resim)
        {
            var resimAdi = Guid.NewGuid() + Path.GetExtension(resim.FileName);
            var dosyaYolu = Path.Combine(_env.WebRootPath, "img", resimAdi);
            using (var stream = System.IO.File.Create(dosyaYolu))
            {
                resim.CopyTo(stream);
            }

            return resimAdi;
        }
    }
}
