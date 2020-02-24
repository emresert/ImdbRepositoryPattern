using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ImdbData.Interfaces
{
    public interface IRepository<T>:IDisposable where T : class
    {
       
        IEnumerable<T> GetList();
        T FindWithRole(Expression<Func<T, bool>> predicate);
        T FindWithLink(Expression<Func<T, bool>> predicate);
        
        void Insert(T obj); 
        void Delete(T obj);
        void Save();




     
    }
}
/*------------- Helper --------- */

//  void Update(T obj);
//  IEnumerable<T> SelectAll();
//  T SelectByID(object id);
//  IEnumerable<T> FindLink(Expression<Func<T,bool>> predicate);