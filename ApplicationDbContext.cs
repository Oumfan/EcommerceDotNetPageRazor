using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommercePageRazor.Models;

namespace ecommercePageRazor.Data
{
   
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {
            }
            public DbSet<Product> Product { get; set; } = default!;
        protected override void OnConfiguring(DbContextOptionsBuilder options)
=> options.UseSqlite(@"Data Source=data.db");

        public DbSet<ecommercePageRazor.Models.User> User { get; set; } = default!;
    }
}
