using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PAK.BrodImalat.WebService.Data;
using PAK.BrodImalat.WebService.ModelsTokenUser;

namespace PAK.BrodImalat.WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenResourcesController : ControllerBase
    {
        private readonly AppIdenittyDbContext _context;

        public TokenResourcesController(AppIdenittyDbContext context)
        {
            _context = context;
        }

        // GET: api/TokenResources
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TokenResource>>> GetTokenResource()
        {
            return await _context.TokenResource.ToListAsync();
        }

        // GET: api/TokenResources/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TokenResource>> GetTokenResource(int id)
        {
            var tokenResource = await _context.TokenResource.FindAsync(id);

            if (tokenResource == null)
            {
                return NotFound();
            }

            return tokenResource;
        }

        // PUT: api/TokenResources/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTokenResource(int id, TokenResource tokenResource)
        {
            if (id != tokenResource.Id)
            {
                return BadRequest();
            }

            _context.Entry(tokenResource).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TokenResourceExists(id))
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

        // POST: api/TokenResources
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
       
            // more details see https://aka.ms/RazorPagesCRUD.



        [HttpPost]
        public async Task<ActionResult<TokenResource>> PostTokenResource(TokenResource tokenResource)
        {
            _context.TokenResource.Add(tokenResource);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTokenResource", new { id = tokenResource.Id }, tokenResource);
        }





        // DELETE: api/TokenResources/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TokenResource>> DeleteTokenResource(int id)
        {
            var tokenResource = await _context.TokenResource.FindAsync(id);
            if (tokenResource == null)
            {
                return NotFound();
            }

            _context.TokenResource.Remove(tokenResource);
            await _context.SaveChangesAsync();

            return tokenResource;
        }

        private bool TokenResourceExists(int id)
        {
            return _context.TokenResource.Any(e => e.Id == id);
        }
    }
}
