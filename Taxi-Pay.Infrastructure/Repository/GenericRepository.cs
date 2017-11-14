using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Taxi_Pay.Infrastructure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private Taxi_PayDbContext db = null;
        private DbSet<T> table = null;
        public GenericRepository()
        {
            this.db = new Taxi_PayDbContext();
            table = db.Set<T>();
        }
        public GenericRepository(Taxi_PayDbContext db)
        {
            this.db = db;
            table = db.Set<T>();
        }

        public IEnumerable<T> SelectAll()
        {
            return table.ToList();
        }

        public IQueryable<T> Table()
        {
            return table;
        }

        public IQueryable<T> TableUnTrack()
        {
            return table.AsNoTracking();
        }

        public T SelectByID(object id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
