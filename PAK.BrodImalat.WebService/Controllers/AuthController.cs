using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PAK.BrodImalat.WebService.Data;
using PAK.BrodImalat.WebService.Models;

namespace PAK.BrodImalat.WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

           private UserManager<ApplicationUser> userManager;

            public AuthController(UserManager<ApplicationUser> userManager)
            {
                this.userManager = userManager;
            }

            [HttpPost]
            [Route("login")]
            [EnableCors("MyPolicy")]
            public async Task<IActionResult> Login([FromBody] LoginModel model)
            {
                ServiceResponse<LoginModel> response = new ServiceResponse<LoginModel>();

                var user = await userManager.FindByNameAsync(model.Email);  // await emza braye asankron
                if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
                {


                    var userRoles = await userManager.GetRolesAsync(user);

                    var claims = new List<Claim>

                  {


                    new Claim (JwtRegisteredClaimNames.Email, user.Email ),

                      new Claim (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())

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
                        message = "Giriş Başarılı"

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
        }
}