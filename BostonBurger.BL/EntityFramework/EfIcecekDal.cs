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
    public class EfIcecekDal : GenericRepository<Icecek>, IIcecekDal
    {
        public EfIcecekDal(UygulamaDbContext db) : base(db)
        {
        }
    }
}
