using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCoreShop.Data.Models;

namespace NetCoreShop.Data
{
    public class NetCoreShopContext : DbContext
    {
        public DbSet<TestModel> TestModels { get; set; }

        public NetCoreShopContext(DbContextOptions options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            
            //TODO: Customization:

            modelBuilder.Entity<TestModel>()
                .HasKey(x => x.Id);

            EnsureSeedData();
        }

        public void EnsureSeedData()
        {

        }
    }
}