using ImdbData.Contexts;
using ImdbData.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ImdbData.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        private ImdbContext db = null;
        private DbSet<T> table = null;
        public BaseRepository()
        {
            this.db = new ImdbContext();
            table = db.Set<T>();
        }
        public BaseRepository(ImdbContext db)
        {
            this.db = db;
            table = db.Set<T>();
        }
     
        public void Insert(T obj)
        {
            table.Add(obj);
            Save();
        }
        public IEnumerable<T> GetList()
        {
            return table.ToList();
        }
        public T FindWithLink(Expression<Func<T, bool>> predicate)
        {
            return table.Where(predicate).FirstOrDefault();
        }
        public T FindWithRole(Expression<Func<T, bool>> predicate)
        {
            return table.Where(predicate).FirstOrDefault();
        }
        public void Save()
        {
            db.SaveChanges();
        }

        
        private bool disposedValue = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    db.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
         
            Dispose(true);
         
        }
        public void Delete(T obj)
        {
            db.Entry(obj).State = EntityState.Deleted;
            Save();
        }



        /*------------- Helper --------- */

        //public IEnumerable<T> FindLink(Expression<Func<T,bool>> predicate)
        //{
        //    return db.Set<T>().Where(predicate).ToList();
        //}

        //public void Update(T obj)
        //{
        //    table.Attach(obj);
        //    db.Entry(obj).State = EntityState.Modified;
        //}

        //public IEnumerable<T> SelectAll()
        //{
        //    return table.ToList();
        //}

        //public T SelectByID(object id)
        //{
        //    return table.Find(id);
        //}
    }
}
