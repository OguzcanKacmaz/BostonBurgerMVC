using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonBurger.ENTITIES.Concreate
{
    public class Kategori
    {
        public int ID { get; set; }
        public string KategoriAdı { get; set; } = null!;

        public ICollection<Burger> Burgerler { get; set; } = null!;
        public ICollection<Menu> Menuler { get; set; } = null!;
        public ICollection<EkstraMalzeme> EkstraMalzemeler { get; set; } = null!;
        public ICollection<Sos> Soslar { get; set; } = null!;
        public ICollection<Icecek> Icecekler { get; set; } = null!;
        public ICollection<Atistirmalik> Atistirmaliklar { get; set; } = null!;
    }
}
