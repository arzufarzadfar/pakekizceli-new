using PAK.BrodImalat.WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.Repository
{
   public interface IRepositoty<T> where T : class, IEntity
    {

        IQueryable<T> GetAll();

        IQueryable<T> GetEx(Expression<Func<T, bool>> predicate);



        T GetByID(int id);
        void Add(T entity);
        void Update(T entity);
        ////void Delete(T entity);

        int Save();



    }
}
