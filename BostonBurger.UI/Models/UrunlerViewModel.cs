using BostonBurger.ENTITIES.Abstract;
using BostonBurger.ENTITIES.Concreate;
using BostonBurger.ENTITIES.Enumlar;

namespace BostonBurger.UI.Models
{
    public class UrunlerViewModel
    {
        public List<Burger> Burgerler { get; set; } = new List<Burger>();
        public List<Atistirmalik> Atistirmaliklar { get; set; } = new List<Atistirmalik>();
        public List<EkstraMalzeme> EkstraMalzemeler { get; set; } = new List<EkstraMalzeme>();
        public List<Icecek> Icecekler { get; set; } = new List<Icecek>();
        public List<Menu> Menuler { get; set; } = new List<Menu>();
        public List<Sos> Soslar { get; set; } = new List<Sos>();
        public List<BaseEntity> Sepet { get; set; } = new List<BaseEntity>();
        public int Adet { get; set; }
        public Boyut Boyut { get; set; }
    }
}
