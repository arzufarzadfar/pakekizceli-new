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
    public class AltUnitsController : ControllerBase
    {
        private readonly AppIdenittyDbContext _context;

        public AltUnitsController(AppIdenittyDbContext context)
        {
            _context = context;
        }

        // GET: api/AltUnits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AltUnit>>> GetaltUnits()
        {
            return await _context.altUnits.ToListAsync();
        }

        // GET: api/AltUnits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AltUnit>> GetAltUnit(int id)
        {
            var altUnit = await _context.altUnits.FindAsync(id);

            if (altUnit == null)
            {
                return NotFound();
            }

            return altUnit;
        }



        [HttpGet("check/{id}")]
        public bool CheckAltUnit(AltUnit altUnit)
        {
            var check = _context.altUnits.Where(p => p.Code == altUnit.Code).FirstOrDefault();

            if (check == null)
            {
                return false;
            }
           
            return true;
        }

        // PUT: api/AltUnits/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAltUnit(int id, AltUnit altUnit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != altUnit.Id)
            {
                return BadRequest();
            }

            _context.Entry(altUnit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AltUnitExists(id))
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

        // POST: api/AltUnits
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<AltUnit>> PostAltUnit(AltUnit altUnit)
        {
            // _context.altUnits.Add(altUnit);
            _context.Database.OpenConnection();

            try
            {
                //foreach (var item in _context.altUnits)
                //{
                if (!CheckAltUnit(altUnit))
                {
                    _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.altUnits ON");
                    _context.altUnits.Add(altUnit);
                    _context.SaveChanges();
                    _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.altUnits OFF");
                }
                //}

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

            return CreatedAtAction("GetAltUnit", new { id = altUnit.Id }, altUnit);
        }



        // DELETE: api/AltUnits/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AltUnit>> DeleteAltUnit(int id)
        {
            var altUnit = await _context.altUnits.FindAsync(id);
            if (altUnit == null)
            {
                return NotFound();
            }

            _context.altUnits.Remove(altUnit);
            await _context.SaveChangesAsync();

            return altUnit;
        }

        private bool AltUnitExists(int id)
        {
            return _context.altUnits.Any(e => e.Id == id);
        }
    }
}
