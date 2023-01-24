using BostonBurger.BL.EntityFramework;
using BostonBurger.ENTITIES.Concreate;
using BostonBurger.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace BostonBurger.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminIcecekController : Controller
    {
        private readonly EfIcecekDal _efIcecekDal;
        private readonly IWebHostEnvironment _env;

        public AdminIcecekController(EfIcecekDal efIcecekDal, IWebHostEnvironment env)
        {
            _efIcecekDal = efIcecekDal;
            _env = env;
        }
        public IActionResult Index()
        {
            ViewBag.Icerik = "Icecek";
            ViewBag.Sayfa = "AdminIcecek";
            ViewBag.Index = "Index";
            var icecekler = _efIcecekDal.GetList();
            return View(icecekler);
        }
        public IActionResult IcecekEkle()
        {
            ViewBag.Icerik = "Icecek";
            ViewBag.Sayfa = "AdminIcecek";
            ViewBag.Index = "IcecekEkle";
            return View();
        }
        [HttpPost, AutoValidateAntiforgeryToken]
        public IActionResult IcecekEkle(MenuViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Icecek icecek = new Icecek()
                {
                    Adı = vm.Adı,
                    Fiyat = vm.Fiyat,
                    Aciklama = vm.Aciklama,
                    Resim = ResimEkle(vm.Resim),
                    KategoriID=3
                };
                _efIcecekDal.Insert(icecek);
                TempData["Mesaj"] = "İçecek Eklendi";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult IcecekSil(int icecekId)
        {
            if (ModelState.IsValid)
            {
                _efIcecekDal.Delete(_efIcecekDal.GetById(icecekId));
                TempData["Mesaj"] = "İçecek Silindi";
            }
            return RedirectToAction("Index");
        }
        public IActionResult IcecekGuncelle(int icecekId)
        {
            if (ModelState.IsValid)
            {
                var icecek = _efIcecekDal.GetById(icecekId);
                MenuEditViewModel vm = new MenuEditViewModel()
                {
                    ID = icecek.ID,
                    Adı = icecek.Adı,
                    Fiyat = icecek.Fiyat,
                    Aciklama = icecek.Aciklama
                };

                return View(vm);
            }
            return View();
        }
        [HttpPost, AutoValidateAntiforgeryToken]
        public IActionResult IcecekGuncelle(MenuEditViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var secili = _efIcecekDal.GetById(vm.ID);
                secili.Adı = vm.Adı;
                secili.Fiyat = vm.Fiyat;
                secili.Aciklama = vm.Aciklama;
                secili.ID = vm.ID;
                if (vm.Resim != null)
                {
                    ResimSil(secili.Resim);
                    secili.Resim = ResimEkle(vm.Resim);
                }
                TempData["Mesaj"] = "İçecek Güncellendi";
                _efIcecekDal.Update(secili);

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
