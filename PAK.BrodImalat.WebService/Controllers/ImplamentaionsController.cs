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
    public class ImplamentaionsController : ControllerBase
    {
        private readonly AppIdenittyDbContext _context;

        public ImplamentaionsController(AppIdenittyDbContext context)
        {
            _context = context;
        }

        // GET: api/Implamentaions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Implamentaion>>> Getimplamentaions()
        {
            return await _context.implamentaions.ToListAsync();
        }

        // GET: api/Implamentaions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Implamentaion>> GetImplamentaion(int id)
        {
            var implamentaion = await _context.implamentaions.FindAsync(id);

            if (implamentaion == null)
            {
                return NotFound();
            }

            return implamentaion;
        }

        // PUT: api/Implamentaions/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImplamentaion(int id, Implamentaion implamentaion)
        {
            if (id != implamentaion.Id)
            {
                return BadRequest();
            }

            _context.Entry(implamentaion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImplamentaionExists(id))
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

        // POST: api/Implamentaions
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Implamentaion>> PostImplamentaion(Implamentaion implamentaion)
        {
            _context.implamentaions.Add(implamentaion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetImplamentaion", new { id = implamentaion.Id }, implamentaion);
        }

        // DELETE: api/Implamentaions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Implamentaion>> DeleteImplamentaion(int id)
        {
            var implamentaion = await _context.implamentaions.FindAsync(id);
            if (implamentaion == null)
            {
                return NotFound();
            }

            _context.implamentaions.Remove(implamentaion);
            await _context.SaveChangesAsync();

            return implamentaion;
        }

        private bool ImplamentaionExists(int id)
        {
            return _context.implamentaions.Any(e => e.Id == id);
        }
    }
}
