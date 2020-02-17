using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PAK.BrodImalat.WebService.ModelsTokenUser;

namespace PAK.BrodImalat.WebService.ControlerTokenUser
{
    [Route("api/[controller]")]
    [ApiController]
    public class AspNetUsersController : ControllerBase
    {



        private readonly PakEkizcelibrode2Context _context;

        public AspNetUsersController(PakEkizcelibrode2Context context)
        {
            this._context = context;
        }





        // GET: api/AspNetUsers
        [HttpGet]
        public List<AspNetUsers> Get()
        {
            return _context.AspNetUsers.ToList();
        }
        
        // GET: api/AspNetUsers/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/AspNetUsers
       



        [HttpPost]
        public async Task<ActionResult<AspNetUsers>> PostUser(AspNetUsers user)
        {
            _context.AspNetUsers.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }




        // PUT: api/AspNetUsers/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
