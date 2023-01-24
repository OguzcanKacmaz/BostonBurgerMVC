using BostonBurger.ENTITIES.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonBurger.ENTITIES.Concreate
{
    public class Burger : BaseEntity
    {
        public ICollection<BurgerSiparis>? BurgerSiparis { get; set; }
    }
}
