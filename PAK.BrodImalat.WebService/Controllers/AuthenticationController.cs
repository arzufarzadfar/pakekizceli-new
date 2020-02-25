﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PAK.BrodImalat.WebService.Data;
using PAK.BrodImalat.WebService.Models;
using PAK.BrodImalat.WebService.ModelsTokenUser;
using RequestApiService.Models;

namespace PAK.BrodImalat.WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {

           private UserManager<ApplicationUser> userManager;
         

        public AuthenticationController(UserManager<ApplicationUser> userManager)
            {
                this.userManager = userManager;
            }

        [Route("register")]
        [HttpPost]
        public async Task<ActionResult> InsertUser([FromBody] RegisterViewModel model)
        {
            ApplicationUser user1 = new ApplicationUser()
            {
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = model.Email,
                UserName = model.Email,
                firsName = model.firstName,
                lastName = model.lastName


            };

            var result = await userManager.CreateAsync(user1, model.Password);
            if (result.Succeeded)
            {
                //await userManager.AddToRoleAsync(user, "Customer");
            }
            return Ok( user1);
        }


        [HttpPost]
            [Route("login")]
            [EnableCors("MyPolicy")]
            public async Task<IActionResult> Login([FromBody] LoginModel model)
            {
                ServiceResponse<LoginModel> response = new ServiceResponse<LoginModel>();

                var user = await userManager.FindByNameAsync(model.UserName);  // await emza braye asankron
                if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
                {


                    var userRoles = await userManager.GetRolesAsync(user);
                   ////var userRoles1 = await userManager.getuser

                    var claims = new List<Claim>

                  {


                    new Claim (JwtRegisteredClaimNames.Email, user.Email ),

                      new Claim (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    

                        new Claim ("id","200")


                  };


                    foreach (var role in userRoles)

                    {
                        claims.Add(new Claim(ClaimTypes.Role, role));



                    }

                    var singinkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("AtasayarTeknoloji"));

                    var token = new JwtSecurityToken(

                        issuer: "https://localhost:51177",
                        audience: "https://localhost:51177",
                        expires: DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc).AddMinutes(20),
                        claims: claims,
                        signingCredentials: new SigningCredentials(singinkey, SecurityAlgorithms.HmacSha256)
                        );




                return Ok(new
                {
                        token = new JwtSecurityTokenHandler().WriteToken(token),
                        expiration = token.ValidTo,

                    firstName = user.firsName,
                    lastName = user.lastName,
                    Id = user.Id,


            }); 

          
            }
            else
                {
                    return BadRequest(new
                    {

                        message = "Kulanci adi ve şifre yanliş"

                    });
                }





        }




        [HttpGet("gettoken")]
        public ActionResult<string> gettoken()
        {
           var emailclime = User.Claims.FirstOrDefault(x => x.Type.ToString().Equals( "id", StringComparison.InvariantCultureIgnoreCase));
            if (emailclime != null)
            {

                return Ok(new
                {

                    expiresRefresh = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc).AddMinutes(20),

                    Exception = $"OK:{ emailclime.Value}"

                 });


            }
           return BadRequest("404");
        }

   
    }
}