using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonBurger.ENTITIES.Concreate
{
    public class BurgerSiparis
    {
        [Key]
        public int ID { get; set; }
        public int BurgerID { get; set; }
        public int SiparisID { get; set; }
        public Burger? Burger { get; set; }
        public Siparis? Siparis { get; set; }
    }
}
