using BostonBurger.ENTITIES.Concreate;

namespace BostonBurger.UI.Areas.Admin.Models
{
    public class SiparisViewModel
    {
        public List<string> menuAdListesi { get; set; } = new List<string>();
        public List<string> burgerAdListesi { get; set; } = new List<string>();
        public List<string> icecekAdListesi { get; set; } = new List<string>();
        public List<string> atistirmalikAdListesi { get; set; } = new List<string>();
        public List<string> sosAdListesi { get; set; } = new List<string>();
        public List<string> ekstraMalzemeAdListesi { get; set; } = new List<string>();
        public List<Siparis> siparis { get; set; } = new List<Siparis>();
    }
}
