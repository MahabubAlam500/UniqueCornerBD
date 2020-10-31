using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UniqueCornerBD.Models;

namespace UniqueCornerBD.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<UniqueCornerBD.Models.ProductTypes> ProductTypes { get; set; }
        public DbSet<UniqueCornerBD.Models.SpecialTag> SpecialTag { get; set; }
        public DbSet<UniqueCornerBD.Models.Products> Products { get; set; }
        public DbSet<UniqueCornerBD.Models.Order> orders { get; set; }
        public DbSet<UniqueCornerBD.Models.OrderDetails> orderDetails { get; set; }
        public DbSet<UniqueCornerBD.Models.ApplicationUser> applicationUsers { get; set; }
    }
}
