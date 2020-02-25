using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PAK.BrodImalat.WebService.Models;
using PAK.BrodImalat.WebService.ModelsLogo;
using log4net;
using log4net.Config;
using Microsoft.AspNetCore.Cors;

namespace PAK.BrodImalat.WebService.ControlerLogo
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class Lg00101StlineController : ControllerBase
    {
        private readonly GO3DbContext _context;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Lg00101StlineController(GO3DbContext context)
        {
            _context = context;
        }

        // GET: api/Lg00101Stline
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lg00101Stline>>> GetLg00101Stline()
        {
            return await _context.Lg00101Stline.ToListAsync();
        }

        // GET: api/Lg00101Stline/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Lg00101Stline>> GetLg00101Stline(int id)
        {
            var lg00101Stline = await _context.Lg00101Stline.FindAsync(id);

            if (lg00101Stline == null)
            {
                return NotFound();
            }

            return lg00101Stline;
        }



        // PUT: api/Lg00101Stline/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLg00101Stline(int id, Lg00101Stline lg00101Stline)
        {
            if (id != lg00101Stline.Logicalref)
            {
                return BadRequest();
            }

            _context.Entry(lg00101Stline).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Lg00101StlineExists(id))
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

        // POST: api/Lg00101Stline
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public int PostLg00101Stline(Lg00101Stline lg00101Stline)
        {


            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
            var logger = LogManager.GetLogger(typeof(Program));
            try
            {
                _context.Lg00101Stline.Add(lg00101Stline);
                _context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                log.Info("Stfiche eklerken hata alındı.");
                log.Error(e.InnerException.ToString());
                throw;
            }
            //return Ok(lg00101Stfiche);
            return lg00101Stline.Logicalref;


            //return CreatedAtAction("GetLg00101Stline", new { id = lg00101Stline.Logicalref }, lg00101Stline);
        }

        // DELETE: api/Lg00101Stline/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Lg00101Stline>> DeleteLg00101Stline(int id)
        {
            var lg00101Stline = await _context.Lg00101Stline.FindAsync(id);
            if (lg00101Stline == null)
            {
                return NotFound();
            }

            _context.Lg00101Stline.Remove(lg00101Stline);
            await _context.SaveChangesAsync();

            return lg00101Stline;
        }

        private bool Lg00101StlineExists(int id)
        {
            return _context.Lg00101Stline.Any(e => e.Logicalref == id);
        }
    }
}
