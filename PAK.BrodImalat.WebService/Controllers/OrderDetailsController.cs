using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PAK.BrodImalat.WebService.Data;
using PAK.BrodImalat.WebService.Models;

namespace PAK.BrodImalat.WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly AppIdenittyDbContext _context;

        public OrderDetailsController(AppIdenittyDbContext context)
        {
            _context = context;
        }

        // GET: api/OrderDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDetail>>> GetorderDetails()
        {
            return await _context.orderDetails.ToListAsync();
        }

        // GET: api/OrderDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDetail>> GetOrderDetail(int id)
        {
            var orderDetail = await _context.orderDetails.FindAsync(id);

            if (orderDetail == null)
            {
                return NotFound();
            }

            return orderDetail;
        }


        // GET: api/OrderDetails/getOrders
        [HttpGet("getorders")]
        public async Task<ActionResult<OrderDetail>> GetOrderDetailGetOrders()
        {
            var orderDetail = await _context.orderDetails
                .Include(p => p.Order)
                .Include(p => p.Item)
                .Include(p => p.Order.Client)
               .Include(p => p.AltUnit)

                .ToListAsync();

           

            return Ok(orderDetail);
        }




        //public IEnumerable<OrderDetail> GetAll()
        //{


        //    var orderDetail = _context.orderDetails
        //          .Include(p => p.Order)
        //        .Include(p => p.Item)
        //        .Include(p => p.Order.Client)
        //       .Include(p => p.AltUnit)

        //        .ToList();


        //    return orderDetail;
        //}

        // PUT: api/OrderDetails/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderDetail(int id, OrderDetail orderDetail)
        {
            if (id != orderDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(orderDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/OrderDetails
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<OrderDetail>> PostOrderDetail(OrderDetail orderDetail)
        {
            _context.orderDetails.Add(orderDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetImplamentaion", new { id = orderDetail.Id }, orderDetail);
        }

        // DELETE: api/OrderDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<OrderDetail>> DeleteOrderDetail(int id)
        {
            var orderDetail = await _context.orderDetails.FindAsync(id);
            if (orderDetail == null)
            {
                return NotFound();
            }

            _context.orderDetails.Remove(orderDetail);
            await _context.SaveChangesAsync();

            return orderDetail;
        }

        private bool OrderDetailExists(int id)
        {
            return _context.orderDetails.Any(e => e.Id == id);
        }
    }
}
