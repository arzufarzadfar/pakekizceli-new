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
    public class MainUnitsController : ControllerBase
    {
        private readonly AppIdenittyDbContext _context;

        public MainUnitsController(AppIdenittyDbContext context)
        {
            _context = context;
        }

        // GET: api/MainUnits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MainUnit>>> GetmainUnits()
        {
            return await _context.mainUnits.ToListAsync();
        }

        // GET: api/MainUnits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MainUnit>> GetMainUnit(int id)
        {
            var mainUnit = await _context.mainUnits.FindAsync(id);

            if (mainUnit == null)
            {
                return NotFound();
            }

            return mainUnit;
        }

        [HttpGet("check/{id}")]
        public bool CheckMainUnit(MainUnit main)
        {
            var check = _context.mainUnits.Where(p => p.Code == main.Code).FirstOrDefault();

            if (check == null)
            {
                return false;
            }
            if (check.LogicModifiedDate != main.LogicModifiedDate)
            {
                main.Id = check.Id;
                check.Name = main.Name;
                check.Code = main.Code;
                check.LogicModifiedDate = main.LogicModifiedDate;
                _ = PutMainUnit(check.Id, check);
            }
            return true;
        }

        // PUT: api/MainUnits/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMainUnit(int id, MainUnit main)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != main.Id)
            {
                return BadRequest();
            }

            _context.Entry(main).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MainUnitExists(id))
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

        // POST: api/MainUnits
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<MainUnit>> PostMainUnit(MainUnit mainUnit)
        {

            _context.Database.OpenConnection();

            try
            {


                //foreach (var item in _context.mainUnits)
                //{
                if (!CheckMainUnit(mainUnit))
                {
                    _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.mainUnits ON");
                    _context.mainUnits.Add(mainUnit);
                    _context.SaveChanges();
                    _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.mainUnits OFF");
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
            return CreatedAtAction("GetMainUnit", new { id = mainUnit.Id }, mainUnit);
        }



        // DELETE: api/MainUnits/5
        //////[HttpDelete("{id}")]
        //////public async Task<ActionResult<MainUnit>> DeleteMainUnit(int id)
        //////{
        //////    var mainUnit = await _context.mainUnits.FindAsync(id);
        //////    if (mainUnit == null)
        //////    {
        //////        return NotFound();
        //////    }

        //////    _context.mainUnits.Remove(mainUnit);
        //////    await _context.SaveChangesAsync();

        //////    return mainUnit;
        //////}

        private bool MainUnitExists(int id)
        {
            return _context.mainUnits.Any(e => e.Id == id);
        }
    }
}
