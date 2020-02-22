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
    public class ItemsController : ControllerBase
    {
        private readonly AppIdenittyDbContext _context;

        public ItemsController(AppIdenittyDbContext context)
        {
            _context = context;
        }

        // GET: api/Items
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Item>>> Getitems()
        {
            return await _context.items.ToListAsync();
        }

        // GET: api/Items/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> GetItem(int id)
        {
            var item = await _context.items.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }





            return item;
        }

        // GET: api/items/check/120.xxx
        [HttpGet("check/{id}")]
        public bool CheckItem(Item item)
        {
            var check = _context.items.Where(p => p.Code == item.Code).FirstOrDefault();

            if (check == null)
            {
                return false;
            }
            if (check.LogicModifiedDate != item.LogicModifiedDate)
            {
                item.Id = check.Id;
                check.Name = item.Name;
                check.LogicModifiedDate = item.LogicCreatedDate;
                check.Pattern = item.Pattern;
                check.Rope = item.Rope;
                check.Strike = item.Strike;
                check.Floor = item.Floor;
                check.Color = item.Color;
                _ = PutItem(check.Id, check);
            }
            return true;
        }

        // PUT: api/Items/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.

        [HttpPut("{id}")]
        public async Task<IActionResult> PutItem(int id, Item item)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemExists(id))
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

        // POST: api/Items
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Item>> PostItem(Item item)
        {

            //item.mainUnit = null;
            _context.Database.OpenConnection();

            try
            {

                if (!CheckItem(item))
                {
                    _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.items ON");
                    _context.items.Add(item);
                    _context.SaveChanges();
                    _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.items OFF");
                }


            }
            catch (Exception ex)
            {
                /*throw*/
                string h = ex.Message;
            }

            finally
            {
                _context.Database.CloseConnection();
            }
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItem", new { id = item.Id }, item);
        }




        // DELETE: api/Items/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Item>> DeleteItem(int id)
        {
            var item = await _context.items.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            _context.items.Remove(item);
            await _context.SaveChangesAsync();

            return item;
        }

        private bool ItemExists(int id)
        {
            return _context.items.Any(e => e.Id == id);
        }
    }
}

