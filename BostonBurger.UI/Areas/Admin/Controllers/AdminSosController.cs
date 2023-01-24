using BostonBurger.BL.EntityFramework;
using BostonBurger.ENTITIES.Concreate;
using BostonBurger.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace BostonBurger.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminSosController : Controller
    {
        private readonly EfSosDal _efSosDal;
        private readonly IWebHostEnvironment _env;

        public AdminSosController(EfSosDal efSosDal,IWebHostEnvironment env)
        {
            _efSosDal = efSosDal;
            _env = env;
        }
        public IActionResult Index()
        {
            ViewBag.Icerik = "Sos";
            ViewBag.Sayfa = "AdminSos";
            ViewBag.Index = "Index";
            var sos = _efSosDal.GetList();
            return View(sos);
        }
        public IActionResult SosEkle()
        {
            ViewBag.Icerik = "Sos";
            ViewBag.Sayfa = "AdminSos";
            ViewBag.Index = "SosEkle";
            return View();
        }
        [HttpPost, AutoValidateAntiforgeryToken]
        public IActionResult SosEkle(MenuViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Sos sos = new Sos()
                {
                    Adı = vm.Adı,
                    Fiyat = vm.Fiyat,
                    Aciklama = vm.Aciklama,
                    Resim = ResimEkle(vm.Resim),
                    KategoriID = 5
                };
                _efSosDal.Insert(sos);
                TempData["Mesaj"] = "Sos Eklendi";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult sosSil(int sosId)
        {
            if (ModelState.IsValid)
            {
                _efSosDal.Delete(_efSosDal.GetById(sosId));
                TempData["Mesaj"] = "Menu Silindi";
            }
            return RedirectToAction("Index");
        }
        public IActionResult SosGuncelle(int sosId)
        {
            if (ModelState.IsValid)
            {
                var sos = _efSosDal.GetById(sosId);
                MenuEditViewModel vm = new MenuEditViewModel()
                {
                    ID = sos.ID,
                    Adı = sos.Adı,
                    Fiyat = sos.Fiyat,
                    Aciklama = sos.Aciklama
                };

                return View(vm);
            }
            return View();
        }
        [HttpPost, AutoValidateAntiforgeryToken]
        public IActionResult sosGuncelle(MenuEditViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var secili = _efSosDal.GetById(vm.ID);
                secili.Adı = vm.Adı;
                secili.Fiyat = vm.Fiyat;
                secili.Aciklama = vm.Aciklama;
                secili.ID = vm.ID;
                if (vm.Resim != null)
                {
                    ResimSil(secili.Resim);
                    secili.Resim = ResimEkle(vm.Resim);
                }
                TempData["Mesaj"] = "Sos Güncellendi";
                _efSosDal.Update(secili);

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
