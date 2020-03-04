using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PAK.BrodImalat.WebService.Data;
using PAK.BrodImalat.WebService.Models;
using PAK.BrodImalat.WebService.ModelsTokenUser;

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

        [Route("getorders")]
        [HttpGet]
        public async Task<ActionResult<OrderDetail>> getorder()
        {
            var orderDetail = await _context.orderDetails
                .Include(p => p.Order)
                .Include(p => p.Item)
                .Include(p => p.Order.Client)
               .Include(p => p.AltUnit)
                .ToListAsync();

            if (orderDetail == null)
            {
                return NotFound();
            }

            return Ok(orderDetail);
        }


        //[Route("getbeforedyeing")]
        [HttpGet("getbeforedyeing")]


        public ActionResult<string> getbeforedyeing([FromHeader]string token)
        {


            var userid = (User.Claims.FirstOrDefault(x => x.Type.ToString().Equals(ClaimTypes.NameIdentifier, StringComparison.OrdinalIgnoreCase))).Value;



               // var tokencontrol = _context.TokenResource.Where(x => ((x.Id == userid) && (x.mod == 0))).ToList();
                var tokencontrol = _context.TokenResource.Where(x => ((x.Id == userid) && (x.expires >= DateTime.Now))).ToList();

            if (tokencontrol.Count == 0)
            {

                return BadRequest("404");
            }
            else
            {
                return Ok(getbeforedyeingvalue());    

            }


        }

        [HttpGet("getbeforedyeingvalue")]


        public async Task<ActionResult<OrderDetail>> getbeforedyeingvalue()
        {
            var neworder1 = _context.orderDetails.Where(x => x.Order.statusId == 3)
                .Include(p => p.Order)
                .Include(p => p.Item)


                .ToList();



            if (neworder1 == null)
            {
                return NotFound();
            }

            return Ok(neworder1);
        }








        [Route("getafterdyeing")]
        [HttpGet]
        public async Task<ActionResult<OrderDetail>> getafterdyeing()
        {


            var neworder1 = _context.orderDetails.Where(x => x.Order.statusId == 3)
                .Include(p => p.Order)
                .Include(p => p.Item)


                .ToList();



            if (neworder1 == null)
            {
                return NotFound();
            }

            return Ok(neworder1);
        }




        //[Route("getbeforeclose")]
        [HttpGet("getbeforeclose")]
        public async Task<ActionResult<OrderDetail>> getbeforeclose()
        {


            var neworder1 = _context.orderDetails.Where(x => x.Order.statusId == 4)
                .Include(p => p.Order)
                .Include(p => p.Item)


                .ToList();



            if (neworder1 == null)
            {
                return NotFound();
            }

            return Ok(neworder1);
        }



        [Route("getafterclose")]
        [HttpGet]
        public async Task<ActionResult<OrderDetail>> getafterclose()
        {


            var neworder1 = _context.orderDetails.Where(x => x.Order.statusId == 5)
                .Include(p => p.Order)
                .Include(p => p.Item)


                .ToList();



            if (neworder1 == null)
            {
                return NotFound();
            }

            return Ok(neworder1);
        }





        [Route("getaftersendpaket")]
        [HttpGet]
        public async Task<ActionResult<OrderDetail>> getaftersendpaket()
        {


            var neworder1 = _context.orderDetails.Where(x => x.Order.statusId == 6)
                .Include(p => p.Order)
                .Include(p => p.Item)


                .ToList();



            if (neworder1 == null)
            {
                return NotFound();
            }

            return Ok(neworder1);
        }


        [HttpGet("byOrder/{id}")]
        public List<OrderDetail> GetOrderDetailByOrder(int id)
        {
            var orderDetail = _context.orderDetails

                .Where(p => p.OrderId == id);

            if (orderDetail == null)
            {
                return null;
            }

            return orderDetail.ToList();
        }



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
