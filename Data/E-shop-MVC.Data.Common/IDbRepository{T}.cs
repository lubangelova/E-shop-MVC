using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_shop_MVC.Data.Common.Models;

namespace E_shop_MVC.Data.Common
{
    public interface IDbRepository<T> : IDbRepository<T,int>
          where T : BaseModel<int>
    {
    }
        public interface IDbRepository<T, in TKey>
           where T : BaseModel<TKey>
    {
        IQueryable<T> All();

        IQueryable<T> AllWithDeleted();

        T GetById(object id);

        void Add(T entity);

        void Delete(T entity);

        void HardDelete(T entity);

        void Save();

        void Dispose();
    }
}
