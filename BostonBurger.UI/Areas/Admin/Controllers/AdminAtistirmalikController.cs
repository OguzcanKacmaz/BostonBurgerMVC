using BostonBurger.BL.EntityFramework;
using BostonBurger.ENTITIES.Concreate;
using BostonBurger.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace BostonBurger.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminAtistirmalikController : Controller
    {
        private readonly EfAtistirmalikDal _efAtistirmalikDal;
        private readonly IWebHostEnvironment _env;

        public AdminAtistirmalikController(EfAtistirmalikDal efAtistirmalikDal,IWebHostEnvironment env)
        {
            _efAtistirmalikDal = efAtistirmalikDal;
            _env = env;
        }
        public IActionResult Index()
        {
            ViewBag.Icerik = "Atistirmalik";
            ViewBag.Sayfa = "AdminAtistirmalik";
            ViewBag.Index = "Index";
            var atistirmalik = _efAtistirmalikDal.GetList();
            return View(atistirmalik);
        }
        public IActionResult AtistirmalikEkle()
        {
            ViewBag.Icerik = "Atistirmalik";
            ViewBag.Sayfa = "AdminAtistirmalik";
            ViewBag.Index = "AtistirmalikEkle";
            return View();
        }
        [HttpPost, AutoValidateAntiforgeryToken]
        public IActionResult AtistirmalikEkle(MenuViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Atistirmalik atistirmalik = new Atistirmalik()
                {
                    Adı = vm.Adı,
                    Fiyat = vm.Fiyat,
                    Aciklama = vm.Aciklama,
                    Resim = ResimEkle(vm.Resim),
                    KategoriID=6
                };
                _efAtistirmalikDal.Insert(atistirmalik);
                TempData["Mesaj"] = "Atıştırmalık Eklendi";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult AtistirmalikSil(int atistirmalikId)
        {
            if (ModelState.IsValid)
            {
                _efAtistirmalikDal.Delete(_efAtistirmalikDal.GetById(atistirmalikId));
                TempData["Mesaj"] = "Atıştırmalık Silindi";
            }
            return RedirectToAction("Index");
        }
        public IActionResult AtistirmalikGuncelle(int atistirmalikId)
        {
            if (ModelState.IsValid)
            {
                var atistirmalik = _efAtistirmalikDal.GetById(atistirmalikId);
                MenuEditViewModel vm = new MenuEditViewModel()
                {
                    ID = atistirmalik.ID,
                    Adı = atistirmalik.Adı,
                    Fiyat = atistirmalik.Fiyat,
                    Aciklama = atistirmalik.Aciklama
                };

                return View(vm);
            }
            return View();
        }
        [HttpPost, AutoValidateAntiforgeryToken]
        public IActionResult AtistirmalikGuncelle(MenuEditViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var secili = _efAtistirmalikDal.GetById(vm.ID);
                secili.Adı = vm.Adı;
                secili.Fiyat = vm.Fiyat;
                secili.Aciklama = vm.Aciklama;
                secili.ID = vm.ID;
                if (vm.Resim != null)
                {
                    ResimSil(secili.Resim);
                    secili.Resim = ResimEkle(vm.Resim);
                }
                TempData["Mesaj"] = "Atıştırmalık Güncellendi";
                _efAtistirmalikDal.Update(secili);

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
