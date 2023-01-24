using BostonBurger.DATA.Context;
using BostonBurger.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BostonBurger.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminSiparisController : Controller
    {
        private readonly UygulamaDbContext _db;

        public AdminSiparisController(UygulamaDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            SiparisListesiViewModel sm = new SiparisListesiViewModel();
            var siparisler = await _db.Siparisler.Include(x => x.MenuSiparisler).Include(x => x.BurgerSiparisler).Include(x => x.IcecekSiparisler).Include(x => x.AtistirmalikSiparisler).Include(x => x.SosSiparisler).Include(x => x.EkstraMalzemeSiparisler).OrderByDescending(x => x.ID).Take(5).ToListAsync();
            foreach (var siparis in siparisler)
            {
                SiparisViewModel vm = new SiparisViewModel();
                vm.siparis.Add(siparis);
                foreach (var menu in siparis.MenuSiparisler!.ToList())
                {
                    vm.menuAdListesi.Add(_db.Menuler.FirstOrDefault(x => x.ID == menu.MenuID)!.Adı);
                }
                foreach (var burger in siparis.BurgerSiparisler!.ToList())
                {
                    vm.burgerAdListesi.Add(_db.Burgerler.FirstOrDefault(x => x.ID == burger.BurgerID)!.Adı!);
                }
                foreach (var icecek in siparis.IcecekSiparisler!.ToList())
                {
                    vm.icecekAdListesi.Add(_db.Icecekler.FirstOrDefault(x => x.ID == icecek.IcecekID)!.Adı!);
                }
                foreach (var atistirmalik in siparis.AtistirmalikSiparisler!.ToList())
                {
                    vm.atistirmalikAdListesi.Add(_db.Atistirmaliklar.FirstOrDefault(x => x.ID == atistirmalik.AtistirmalikID)!.Adı!);
                }
                foreach (var sos in siparis.SosSiparisler!.ToList())
                {
                    vm.sosAdListesi.Add(_db.Soslar.FirstOrDefault(x => x.ID == sos.SosID)!.Adı!);
                }
                foreach (var ekstraMalzemeSiparis in siparis.EkstraMalzemeSiparisler!.ToList())
                {
                    vm.ekstraMalzemeAdListesi.Add(_db.EkstraMalzemeler.FirstOrDefault(x => x.ID == ekstraMalzemeSiparis.EkstraMalzemeID)!.Adı!);
                }
                sm.Siparisler.Add(vm);
            }
            return View(sm);
        }
        public IActionResult Siparisİptal(int siparisId)
        {
            var siparis = _db.Siparisler.Find(siparisId);
            siparis.SiparisOnaylandı = false;
            _db.Update(siparis);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
