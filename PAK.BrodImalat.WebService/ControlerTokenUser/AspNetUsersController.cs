using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using PAK.BrodImalat.WebService.Data;
using PAK.BrodImalat.WebService.Models;
using PAK.BrodImalat.WebService.ModelsTokenUser;

namespace PAK.BrodImalat.WebService.ControlerTokenUser
{
    [Route("api/[controller]")]
    [ApiController]
    public class AspNetUsersController : ControllerBase
    {



        ////private UserManager<ApplicationUser> userManager;

        ////public AspNetUsersController(UserManager<ApplicationUser> userManager)
        ////{
        ////    this.userManager = userManager;
        ////}


        private readonly PakEkizcelibrode2Context _context;

        public AspNetUsersController(PakEkizcelibrode2Context context)
        {
            _context = context;
        }










        [HttpPost]
        public async Task<ActionResult<AspNetUsers>> PostUser(AspNetUsers user)
        {
            _context.AspNetUsers.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }







        //////////////[HttpPost]
        //////////////[Route("createuser")]

        //////////////public async Task<IActionResult> CreateUser([FromBody] IServiceProvider serviceProvider, AspNetUsersModels model)

        //////////////{

        //////////////    var context = serviceProvider.GetRequiredService<AppIdenittyDbContext>();
        //////////////    var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        //////////////    var rolManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        //////////////    context.Database.EnsureCreated();


        //////////////    string rolAdmin = "admin";
        //////////////    string rolEditor = "editor";
        //////////////    ApplicationUser user = new ApplicationUser()
        //////////////    {
        //////////////        SecurityStamp = Guid.NewGuid().ToString(),
        //////////////        Email = model.Email,
        //////////////        UserName = model.UserName,

        //////////////    };
        //////////////    if (!context.Users.Any())    //// dar sorat nabod dar data base
        //////////////    {



        //////////////        await userManager.CreateAsync(user, model.PasswordHash);



        //////////////        if (!context.Roles.Any())
        //////////////        {
        //////////////            if (await rolManager.FindByNameAsync(rolAdmin) == null)
        //////////////            {
        //////////////                await rolManager.CreateAsync(new IdentityRole(rolAdmin));

        //////////////            }


        //////////////            if (await rolManager.FindByNameAsync(rolEditor) == null)

        //////////////            {
        //////////////                await rolManager.CreateAsync(new IdentityRole(rolEditor));

        //////////////            }
        //////////////            await userManager.AddToRoleAsync(user, rolAdmin);

        //////////////        }
        //////////////    }
        //////////////    return Ok(user);

        //////////////}








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
