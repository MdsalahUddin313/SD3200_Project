using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SDProject03.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDProject03.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet <LocationsModel> Location { get; set; }
        public DbSet<TrainModel> Train { get; set; }
        public DbSet<BusModel> BusData { get; set; }

        public DbSet<HotelsModel> HotelsData { get; set; }
        public DbSet<BlogPostsModel> BlogsPost { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<CheckOut> CheckOut { get; set; }




    }
}
