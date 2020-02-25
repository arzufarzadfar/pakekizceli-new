using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PAK.BrodImalat.WebService.Models;
using PAK.BrodImalat.WebService.ModelsLogo;

namespace PAK.BrodImalat.WebService.ControlerLogo
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class Lg00101StficheController : ControllerBase
    {
        private readonly GO3DbContext _context;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Lg00101StficheController(GO3DbContext context)
        {
            _context = context;
        }

        // GET: api/Lg00101Stfiche
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lg00101Stfiche>>> GetLg00101Stfiche()
        {
            return await _context.Lg00101Stfiche.ToListAsync();
        }

        // GET: api/Lg00101Stfiche/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Lg00101Stfiche>> GetLg00101Stfiche(int id)
        {
            var lg00101Stfiche = await _context.Lg00101Stfiche.FindAsync(id);

            if (lg00101Stfiche == null)
            {
                return NotFound();
            }

            return lg00101Stfiche;
        }


        // PUT: api/Lg00101Stfiche/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLg00101Stfiche(int id, Lg00101Stfiche lg00101Stfiche)
        {
            if (id != lg00101Stfiche.Logicalref)
            {
                return BadRequest();
            }

            _context.Entry(lg00101Stfiche).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Lg00101StficheExists(id))
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

        // POST: api/Lg00101Stfiche
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public int PostLg00101Stfiche(Lg00101Stfiche lg00101Stfiche)
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
            var logger = LogManager.GetLogger(typeof(Program));
            try
            {
                _context.Lg00101Stfiche.Add(lg00101Stfiche);
                _context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                log.Info("Stfiche eklerken hata alındı.");
                log.Error(e.InnerException.ToString());
                throw;
            }
            //return Ok(lg00101Stfiche);
            return lg00101Stfiche.Logicalref;
        }

        // DELETE: api/Lg00101Stfiche/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Lg00101Stfiche>> DeleteLg00101Stfiche(int id)
        {
            var lg00101Stfiche = await _context.Lg00101Stfiche.FindAsync(id);
            if (lg00101Stfiche == null)
            {
                return NotFound();
            }

            _context.Lg00101Stfiche.Remove(lg00101Stfiche);
            await _context.SaveChangesAsync();

            return lg00101Stfiche;
        }

        private bool Lg00101StficheExists(int id)
        {
            return _context.Lg00101Stfiche.Any(e => e.Logicalref == id);
        }
    }
}
