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
    public class TokenController : ControllerBase
    {


        private readonly AppIdenittyDbContext _context;

        public TokenController(AppIdenittyDbContext context)
        {
            _context = context;
        }



        // POST: api/Token
        [HttpPost]

        public async Task<ActionResult<TokenResource>> posttoken(TokenResource tokenResource)
        {
            _context.TokenResource.Add(tokenResource);


            try
            {

                _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.clients ON");

                _context.Database.OpenConnection();
                _context.SaveChanges();
                _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.clients OFF");

            }

            finally
            {
                _context.Database.CloseConnection();


            }
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetToken", new { id = tokenResource.Id }, tokenResource);
        }



        ////////public async Task<ActionResult<TokenResource>> puttoken(string id ,TokenResource tokenResource)
        ////////{

        ////////    var item = _context.TokenResource.Find(id);
        ////////    if (item == null)
        ////////    {
        ////////        return NotFound();
        ////////    }

        ////////    item.expires = tokenResource.expires;

        ////////    _context.TokenResource.Update(item);
        ////////    _context.SaveChanges();
        ////////    return Ok(item);
        ////////}




        [HttpPut("{id}")]
        public async Task<IActionResult> puttoken(int id, TokenResource tokenResource)
        {
           

            _context.Entry(tokenResource).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!puttokenexit(id))
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

        private bool puttokenexit(int id)
        {
            return _context.TokenResource.Any(e => e.Id == id);
        }
       
    }
}
