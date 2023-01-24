using BostonBurger.ENTITIES.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonBurger.ENTITIES.Concreate
{
    public class Menu : BaseEntity
    {
        public ICollection<MenuSiparis>? MenuSiparis { get; set; }

    }
}
