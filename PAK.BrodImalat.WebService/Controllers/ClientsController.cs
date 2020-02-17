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
    public class ClientsController : ControllerBase
    {
        private readonly AppIdenittyDbContext _context;

        public ClientsController(AppIdenittyDbContext context)
        {
            _context = context;
        }

        // GET: api/Clients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> Getclients()
        {
            return await _context.clients.ToListAsync();
        }

        // GET: api/Clients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> GetClient(int id)
        {
            var client = await _context.clients.FindAsync(id);

            if (client == null)
            {
                return NotFound();
            }

            return client;
        }

        // GET: api/Clients/check/120.xxx
        [HttpGet("check/{id}")]
        public bool CheckClient(string id)
        {
            var client =  _context.clients.Where(p => p.ClientCode == id).FirstOrDefault();

            if (client == null)
            {
                return false;
            }

            return true;
        }

   

        // PUT: api/Clients/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClient(int id, Client client)
        {
            if (id != client.Id)
            {
                return BadRequest();
            }

            _context.Entry(client).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientExists(id))
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

        // POST: api/Clients
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Client>> PostClient(Client client)
        {

            _context.clients.Add(client);
            _context.Database.OpenConnection();

            try
            {

                _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.clients ON");
                _context.SaveChanges();
                _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.clients OFF");

            }

            finally
            {
                _context.Database.CloseConnection();


            }
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClient", new { id = client.Id }, client);
     
        }

        // DELETE: api/Clients/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Client>> DeleteClient(int id)
        {
            var client = await _context.clients.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }

            _context.clients.Remove(client);
            await _context.SaveChangesAsync();

            return client;
        }

        private bool ClientExists(int id)
        {
            return _context.clients.Any(e => e.Id == id);
        }
    }
}
