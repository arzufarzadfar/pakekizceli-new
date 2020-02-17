//using Microsoft.EntityFrameworkCore;
//using PAK.BrodImalat.WebService.Models;
//using PAK.BrodImalat.WebService.Repository;
//using PAK.BrodImalat.WebService.Services;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Threading.Tasks;

//namespace PAK.BrodImalat.WebService
//{
//    public class GetNewOrderManager : IGetNewOrderService
//    {

//        IGetNewOrderRepository repo;


        

//        public GetNewOrderManager(IGetNewOrderRepository repo)
//        {
//            this.repo = repo;
//        }

//        public void Add(Order entity)
//        {
//            repo.Add(entity);
//        }

//        public List<Order> GetAll()
//        {

//            return repo.GetAll().ToList();

//            //var requests = repo.GetAll().Select(x => new Order
//            //{
//            //    Id = x.Id,
//            //    CreateTime = x.CreateTime,
//            //    ClientId = x.ClientId


//            //}).Include(x => x.Client).
//            //ThenInclude(c => c.ClientCode).ToList();

//            //return (requests);

//            //Include(b => b.Client).
//            //ThenInclude(c => c.ClientCode).ToList();
//        }

//        public Order GetByID(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Order> GetEx(Expression<Func<Order, bool>> predicate)
//        {
            

//            return repo.GetEx(predicate).ToList();
//        }

//        public void Update(Order entity)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
