using BostonBurger.BL.EntityFramework;
using BostonBurger.ENTITIES.Concreate;
using BostonBurger.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace BostonBurger.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminEkstraMalzemeController : Controller
    {
        private readonly EfEkstraMalzemeDal _efEkstraMalzemeDal;
        private readonly IWebHostEnvironment _env;

        public AdminEkstraMalzemeController(EfEkstraMalzemeDal efEkstraMalzemeDal,IWebHostEnvironment env)
        {
            _efEkstraMalzemeDal = efEkstraMalzemeDal;
            _env = env;
        }
        public IActionResult Index()
        {
            ViewBag.Icerik = "EkstraMalzeme";
            ViewBag.Sayfa = "AdminEkstraMalzeme";
            ViewBag.Index = "Index";
            var ekstraMalzeme = _efEkstraMalzemeDal.GetList();
            return View(ekstraMalzeme);
        }
        public IActionResult EkstraMalzemeEkle()
        {
            ViewBag.Icerik = "EkstraMalzeme";
            ViewBag.Sayfa = "AdminEkstraMalzeme";
            ViewBag.Index = "EkstraMalzemeEkle";
            return View();
        }
        [HttpPost, AutoValidateAntiforgeryToken]
        public IActionResult EkstraMalzemeEkle(MenuViewModel vm)
        {
            if (ModelState.IsValid)
            {
                EkstraMalzeme ekstraMalzeme = new EkstraMalzeme()
                {
                    Adı = vm.Adı,
                    Fiyat = vm.Fiyat,
                    Aciklama = vm.Aciklama,
                    Resim = ResimEkle(vm.Resim),
                    KategoriID = 4
                };
                _efEkstraMalzemeDal.Insert(ekstraMalzeme);
                TempData["Mesaj"] = "Ekstra Malzeme Eklendi";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult EkstraMalzemeSil(int ekstraMalzemeId)
        {
            if (ModelState.IsValid)
            {
                _efEkstraMalzemeDal.Delete(_efEkstraMalzemeDal.GetById(ekstraMalzemeId));
                TempData["Mesaj"] = "Ekstra Malzeme Silindi";
            }
            return RedirectToAction("Index");
        }
        public IActionResult EkstraMalzemeGuncelle(int ekstraMalzemeId)
        {
            if (ModelState.IsValid)
            {
                var ekstraMalzeme = _efEkstraMalzemeDal.GetById(ekstraMalzemeId);
                MenuEditViewModel vm = new MenuEditViewModel()
                {
                    ID = ekstraMalzeme.ID,
                    Adı = ekstraMalzeme.Adı,
                    Fiyat = ekstraMalzeme.Fiyat,
                    Aciklama = ekstraMalzeme.Aciklama
                };

                return View(vm);
            }
            return View();
        }
        [HttpPost, AutoValidateAntiforgeryToken]
        public IActionResult EkstraMalzemeGuncelle(MenuEditViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var secili = _efEkstraMalzemeDal.GetById(vm.ID);
                secili.Adı = vm.Adı;
                secili.Fiyat = vm.Fiyat;
                secili.Aciklama = vm.Aciklama;
                secili.ID = vm.ID;
                if (vm.Resim != null)
                {
                    ResimSil(secili.Resim);
                    secili.Resim = ResimEkle(vm.Resim);
                }
                TempData["Mesaj"] = "Ekstra Malzeme Güncellendi";
                _efEkstraMalzemeDal.Update(secili);

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
