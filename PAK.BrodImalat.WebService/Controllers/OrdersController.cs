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
    public class OrdersController : ControllerBase
    {
        private readonly AppIdenittyDbContext _context;

        public OrdersController(AppIdenittyDbContext context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> Getorders()
        {
            return await _context.orders.ToListAsync();
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var order = await _context.orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        [HttpGet("getneworder")]
        public async Task<ActionResult<Order>> Get(int id)
        {

           
            var neworder1 = _context.orders.Where(x => x.statusId == 1)
                .Include(p=>p.Client)
                .ToList();

           
            if (neworder1 == null)
            {
                return NotFound();
            }

            return Ok(neworder1);
        }




        [HttpGet("getinprogressorder")]
        public async Task<ActionResult<Order>> Getinprogress(int id)
        {


            var neworder1 = _context.orders.Where(x => x.statusId == 2 || x.statusId == 3|| x.statusId == 4|| x.statusId == 5)
                .Include(p => p.Client)
               
                .ToList();


            if (neworder1 == null)
            {
                return NotFound();
            }

            return Ok(neworder1);
        }





        [HttpGet("getcompletedorder")]
        public async Task<ActionResult<Order>> Getcompletedorder(int id)
        {


            var neworder1 = _context.orders.Where(x => x.statusId == 6)
                .Include(p => p.Client)
                .ToList();


            if (neworder1 == null)
            {
                return NotFound();
            }

            return Ok(neworder1);
        }


        // GET: api/Orders/byOrder/5
        [HttpGet("byOrder/{id}")]
        public Order GetOrderByOrder(int id)
        {
            var order = _context.orders.Where(p => p.statusId == 5 && p.Id == id).FirstOrDefault();
            int ID = order.Id;
            if (order == null)
            {
                return null;
            }

            return (order);
        }



        // PUT: api/Orders/5
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



        //[Route("putstatu/{id}")]
        [HttpPut("putstatu/{id}")]
        public IActionResult PutStatu(int id, [FromBody] Order model)
        {
            if (ModelState.IsValid)
            {

                var order = new Order
                {
                    statusId = model.statusId

                };


                _context.orders.Update(order);
                _context.SaveChanges();
                return Ok(order);
            }
            else
            {
                return BadRequest(ModelState);

            }



        }






        // POST: api/Orders
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {




            _context.orders.Add(order);
            _context.Database.OpenConnection();
               

            try
                {

                    _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.orders ON");

               
                _context.SaveChanges();
                    _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.orders OFF");

                }

                finally
                {
                    _context.Database.CloseConnection();


                }
                await _context.SaveChangesAsync();
           

            return CreatedAtAction("GetOrder", new { id = order.Id }, order);
        }

        // DELETE: api/Orders/5
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
