using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

using PAK.BrodImalat.WebService.Data;
using PAK.BrodImalat.WebService.Models;
using PAK.BrodImalat.WebService.ModelsTokenUser;
using PAK.BrodImalat.WebService.Repository;
using PAK.BrodImalat.WebService.Services;

namespace PAK.BrodImalat.WebService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson(opt=>opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddScoped<Controllers.ClientsController>();
            services.AddDbContext<AppIdenittyDbContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:MyConnection"]));

            services.AddCors(o  => o.AddPolicy ("MyPolicy",  builder =>
            {
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();

            }));





            //services.AddTransient<IGetNewOrderService, GetNewOrderManager>();
            //services.AddTransient<IGetNewOrderRepository, GetNewOrderDal>();

            //services.Configure<Controllers.ClientsController>(Configuration);
            // services.AddTransient<Controllers.ClientsController>();

           
              


            services.AddIdentity<ApplicationUser, IdentityRole>()
               .AddEntityFrameworkStores<AppIdenittyDbContext>()
               .AddDefaultTokenProviders();

            services.AddAuthentication(Options =>           //braye estefade postman
            {

                Options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                Options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                Options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                
            })
               .AddJwtBearer(Options =>
               {
                   Options.SaveToken = true;
                   Options.RequireHttpsMetadata = true;
                   Options.TokenValidationParameters = new TokenValidationParameters()

                   {
                       ValidateIssuer = true,
                       ValidIssuer = "https://localhost:51177",
                       ValidateAudience = true,
                       ValidAudience = "https://localhost:51177",
                       IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("AtasayarTeknoloji"))
                   };


               });

            services.AddDbContext<GO3DbContext>(opts2 => opts2.UseSqlServer(Configuration["ConnectionString:MyConnection2"]));

            services.AddDbContext<PakEkizcelibrode2Context>(opts2 => opts2.UseSqlServer(Configuration["ConnectionString:MyConnection"]));


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }



            ////SeedData.Add(app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope().ServiceProvider).Wait();

            app.UseAuthentication();
            app.UseHttpsRedirection();
          
            app.UseRouting();
            app.UseCors("MyPolicy");
            
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

            });
        }
    }
}
