using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonBurger.ENTITIES.Concreate
{
    public class SosSiparis
    {
        [Key]
        public int ID { get; set; }
        public int SosID { get; set; }
        public int SiparisID { get; set; }
        public Sos? Sos { get; set; }
        public Siparis? Siparis { get; set; }
    }
}
