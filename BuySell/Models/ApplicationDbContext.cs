using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BuySell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySell.Models
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, IdentityRole<int>, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){}

        public DbSet<ProductViewModel> Products { set; get; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<CategoryViewModel> Categories { get; set; }
        public DbSet<CommentViewModel> Comments { get; set; }
        public DbSet<OrderViewModel> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<PhotoViewModel> Photos { get; set; }
        public DbSet<StockViewModel> Stocks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<OrderDetail>()
                .HasKey(x => new { x.OrderId, x.ProductId });
            builder.Entity<OrderDetail>().HasOne(x => x.Product).WithMany(x => x.OrderDetails);
            builder.Entity<OrderDetail>().HasOne(x => x.Order).WithMany(x => x.OrderDetails);
            base.OnModelCreating(builder);
        }

    }
}
