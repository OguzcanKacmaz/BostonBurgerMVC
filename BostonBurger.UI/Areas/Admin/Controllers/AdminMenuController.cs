using BostonBurger.BL.EntityFramework;
using BostonBurger.ENTITIES.Concreate;
using BostonBurger.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace BostonBurger.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminMenuController : Controller
    {
        private readonly EfMenuDal _efMenuDal;
        private readonly IWebHostEnvironment _env;

        public AdminMenuController(EfMenuDal efMenuDal, IWebHostEnvironment env)
        {
            _efMenuDal = efMenuDal;
            _env = env;
        }
        public IActionResult Index()
        {
            ViewBag.Icerik = "Menu";
            ViewBag.Sayfa = "AdminMenu";
            ViewBag.Index = "Index";
            var menuler = _efMenuDal.GetList();
            return View(menuler);
        }
        public IActionResult MenuEkle()
        {
            ViewBag.Icerik = "Menu";
            ViewBag.Sayfa = "AdminMenu";
            ViewBag.Index = "MenuEkle";
            return View();
        }
        [HttpPost, AutoValidateAntiforgeryToken]
        public IActionResult MenuEkle(MenuViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Menu menu = new Menu()
                {
                    Adı = vm.Adı,
                    Fiyat = vm.Fiyat,
                    Aciklama = vm.Aciklama,
                    Resim = ResimEkle(vm.Resim),
                    KategoriID=2
                };
                _efMenuDal.Insert(menu);
                TempData["Mesaj"] = "Menu Eklendi";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult MenuSil(int menuId)
        {
            if (ModelState.IsValid)
            {
                _efMenuDal.Delete(_efMenuDal.GetById(menuId));
                TempData["Mesaj"] = "Menu Silindi";
            }
            return RedirectToAction("Index");
        }
        public IActionResult MenuGuncelle(int menuId)
        {
            if (ModelState.IsValid)
            {
                var menu = _efMenuDal.GetById(menuId);
                MenuEditViewModel vm = new MenuEditViewModel()
                {
                    ID = menu.ID,
                    Adı = menu.Adı,
                    Fiyat = menu.Fiyat,
                    Aciklama = menu.Aciklama
                };

                return View(vm);
            }
            return View();
        }
        [HttpPost, AutoValidateAntiforgeryToken]
        public IActionResult MenuGuncelle(MenuEditViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var secili = _efMenuDal.GetById(vm.ID);
                secili.Adı = vm.Adı;
                secili.Fiyat = vm.Fiyat;
                secili.Aciklama = vm.Aciklama;
                secili.ID = vm.ID;
                if (vm.Resim != null)
                {
                    ResimSil(secili.Resim);
                    secili.Resim = ResimEkle(vm.Resim);
                }
                TempData["Mesaj"] = "Menu Güncellendi";
                _efMenuDal.Update(secili);

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
