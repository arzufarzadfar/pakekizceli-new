using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PAK.BrodImalat.WebService.Models;

namespace PAK.BrodImalat.WebService.Services
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetNewOrderController : ControllerBase
    {

        private readonly IGetNewOrderService getNewOrderService;

        public GetNewOrderController(IGetNewOrderService getNewOrderService)
        {
            this.getNewOrderService = getNewOrderService;
        }

        [HttpGet]
      //  [GetCarException]
        //public IActionResult Get()
        //{

            //var responser = getNewOrderService.GetEx(x => x.Statu == 0).Select(x => new Order
            //{
            //    Id = x.Id,
            //    CreateTime = x.CreateTime,
            //    ClientId = x.ClientId


            //}).FirstOrDefault();

            //return Ok(responser);


            //var Entities = getNewOrderService.GetAll().Select(x => new { x.Id, x.CreateTime, x.ClientId }).ToList();


            ////response.EntitiesCount = response.Entities.Count();
            //return Ok(Entities);

        //}


        //  [HttpGet]
        [HttpGet("{id}")]
        // [GetNewOrderException]
        public IActionResult Get(int id)
        {


            var responser = getNewOrderService.GetEx(x => x.Id > 0).Select(x => new Order
            {
                Id = x.Id,
                CreateTime = x.CreateTime,
                ClientId = x.ClientId


            }).ToList();

            return Ok(responser);
            ////   var requests = response.Get(x=> x.Id>0).Select(x => new Order
            ////{
            ////    Id = x.Id,
            ////    CreateTime = x.CreateTime,
            ////    ClientId = x.ClientId


            ////}).Include(x => x.Client).
            ////ThenInclude(c => c.ClientCode).ToList();


          


            }

          }
}