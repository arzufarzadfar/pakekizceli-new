using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PAK.BrodImalat.WebService.Data;
using PAK.BrodImalat.WebService.Models;

namespace PAK.BrodImalat.WebService.Services
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetOrderController : ControllerBase
    {
        private readonly AppIdenittyDbContext _context;

        public GetOrderController(AppIdenittyDbContext context)
        {
            _context = context;
        }

        // GET: api/GetOrder
        //[HttpGet]
        //public IActionResult Get()
        //{

        //    //var requests = _context.orders
        //    //    .FromSql("Select Id,CreateTime from dbo.orders")
        //    //    .Include(s => s.Client)
        //    //    .FirstOrDefault();

        //    //return Ok(requests);

        //    //var requests = _context.orders
        //    //      .Include(request => request.Client)
        //    //      .ThenInclude(request => request.ClientCode)
        //    //       .Include(request => request.ClientId)
        //    //      .ToList();
        //    //return Ok(requests);
        //}

        // GET: api/GetOrder/5
       // [HttpGet("{id}")]
        [HttpGet]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var order = await _context.orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // PUT: api/GetOrder/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, Order order)
        {
            if (id != order.Id)
            {
                return BadRequest();
            }

            _context.Entry(order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
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

        // POST: api/GetOrder
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {
            _context.orders.Add(order);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrder", new { id = order.Id }, order);
        }

        // DELETE: api/GetOrder/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Order>> DeleteOrder(int id)
        {
            var order = await _context.orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            _context.orders.Remove(order);
            await _context.SaveChangesAsync();

            return order;
        }

        private bool OrderExists(int id)
        {
            return _context.orders.Any(e => e.Id == id);
        }
    }
}
