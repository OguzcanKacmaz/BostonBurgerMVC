using BostonBurger.ENTITIES.Enumlar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonBurger.ENTITIES.Concreate
{
    public class Siparis
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Boyut 0 Olamaz!")]

        public Boyut SiparisBoyut { get; set; }
        [Required(ErrorMessage = "Adet 0 Olamaz!")]
        public int Adet { get; set; }
        public bool SiparisOnaylandı { get; set; }
        public decimal Fiyat { get; set; }

        public ICollection<BurgerSiparis>? BurgerSiparisler { get; set; }
        public ICollection<MenuSiparis>? MenuSiparisler { get; set; }
        public ICollection<EkstraMalzemeSiparis>? EkstraMalzemeSiparisler { get; set; }
        public ICollection<IcecekSiparis>? IcecekSiparisler { get; set; }
        public ICollection<AtistirmalikSiparis>? AtistirmalikSiparisler { get; set; }
        public ICollection<SosSiparis>? SosSiparisler { get; set; }

    }
}
