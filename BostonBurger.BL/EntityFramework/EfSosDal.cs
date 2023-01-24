using BostonBurger.BL.Abstract;
using BostonBurger.BL.Concreate;
using BostonBurger.DATA.Context;
using BostonBurger.ENTITIES.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonBurger.BL.EntityFramework
{
    public class EfSosDal : GenericRepository<Sos>, ISosDal
    {
        public EfSosDal(UygulamaDbContext db) : base(db)
        {
        }
    }
}
