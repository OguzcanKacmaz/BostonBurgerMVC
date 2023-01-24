using BostonBurger.BL.Abstract;
using BostonBurger.DATA.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonBurger.BL.Concreate
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly UygulamaDbContext _db;

        public GenericRepository(UygulamaDbContext db)
        {
            _db = db;
        }
        public void Delete(T entity)
        {
            _db.Remove(entity);
            _db.SaveChanges();
        }

        public T GetById(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _db.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            _db.Add(entity);
            _db.SaveChanges();
        }

        public void Update(T entity)
        {
            _db.Update(entity);
            _db.SaveChanges();
        }
    }
}

