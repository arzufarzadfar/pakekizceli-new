using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.Data
{
    public class SeedData
    {


        public static async Task Add(IServiceProvider serviceProvider)

        {

            var context = serviceProvider.GetRequiredService<AppIdenittyDbContext>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var rolManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            context.Database.EnsureCreated();


            string rolAdmin = "admin";
            string rolEditor = "editor";
            ApplicationUser user = new ApplicationUser()
            {
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "gizem@gmail.com",
                UserName = "gizem@gmail.com",
                firsName = "Gizem",
                lastName = "Zorba"


            };
            



                /// dar sorat nabod databese an ra ezafe mikonad



                await userManager.CreateAsync(user, "Gizem@123");



                if (!context.Roles.Any())
                {
                    if (await rolManager.FindByNameAsync(rolAdmin) == null)
                    {
                        await rolManager.CreateAsync(new IdentityRole(rolAdmin));

                    }


                    if (await rolManager.FindByNameAsync(rolEditor) == null)

                    {
                        await rolManager.CreateAsync(new IdentityRole(rolEditor));

                    }
                    await userManager.AddToRoleAsync(user, rolAdmin);

                }
            }

        






    }
}
