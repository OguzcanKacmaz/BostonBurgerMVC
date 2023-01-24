using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonBurger.ENTITIES.Concreate
{
    public class AtistirmalikSiparis
    {
        public int ID { get; set; }
        public int AtistirmalikID { get; set; }
        public int SiparisID { get; set; }
        public Atistirmalik? Atistirmalik { get; set; }
        public Siparis? Siparis { get; set; }
    }
}
