using PAK.BrodImalat.WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.Services
{
   public interface IGetNewOrderService
    {
        List<Order> GetAll();

        List<Order> GetEx(Expression<Func<Order, bool>> predicate);



        Order GetByID(int id);
        void Add(Order entity);
        void Update(Order entity);
        ////void Delete(T entity);
    }
}
