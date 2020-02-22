using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PAK.BrodImalat.WebService.ModelsTokenUser;

namespace PAK.BrodImalat.WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NetUsersController : ControllerBase
    {

        private readonly PakEkizcelibrode2Context _context;

        public NetUsersController(PakEkizcelibrode2Context context)
        {
            _context = context;
        }





        // GET: api/NetUsers
        [HttpGet]
        public List<AspNetUsers> Get()
        {
            return _context.AspNetUsers.ToList();
        }

        // GET: api/NetUsers/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/NetUsers
        [HttpPost]
        //public IActionResult Post([FromBody] AspNetUsers model)
        //{

            //if (model != null)
            //{

            //    _context.AspNetUsers.Add(model);
            //    _context.SaveChanges();

            //    return CreatedAtRoute("Get", new { id = model.Id });
            //}
            //else
            //{
            //    return BadRequest();
            //}




        //}

        // PUT: api/NetUsers/5
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
