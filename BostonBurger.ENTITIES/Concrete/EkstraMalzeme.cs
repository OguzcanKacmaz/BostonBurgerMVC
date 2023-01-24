using BostonBurger.ENTITIES.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonBurger.ENTITIES.Concreate
{
    public class EkstraMalzeme : BaseEntity
    {
        public ICollection<EkstraMalzemeSiparis>? EkstraMalzemeSiparis { get; set; }

    }
}
