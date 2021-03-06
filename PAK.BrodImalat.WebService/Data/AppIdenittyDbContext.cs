﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PAK.BrodImalat.WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.Data
{
    public class AppIdenittyDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppIdenittyDbContext(DbContextOptions<AppIdenittyDbContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<AltUnit> altUnits { get; set; }
      
        public DbSet<Client> clients { get; set; }
        public DbSet<Item> items { get; set; }
        public DbSet<MainUnit> mainUnits { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }
        public DbSet<Status> status { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Implamentaion> implamentaions { get; set; }
        public DbSet<PAK.BrodImalat.WebService.Models.Student> Student { get; set; }

        /////////////////////////////////////////
        ///





    }
}
