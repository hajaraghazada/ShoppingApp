using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EF
{
    public class ShoppingContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasMany(p => p.Colors).WithMany(p => p.Products).UsingEntity(p => p.ToTable("ProductToColor"));

            modelBuilder.Entity<SubCategory>().HasOne(p => p.Category).WithMany(p=>p.SubCategories).HasForeignKey(p => p.CategoryID).OnDelete(DeleteBehavior.Restrict); 
            modelBuilder.Entity<Product>().HasOne(p => p.SubCategory).WithMany(p => p.Products).HasForeignKey(p => p.SubCategoryID).OnDelete(DeleteBehavior.Restrict); 
            modelBuilder.Entity<Product>().HasOne(p=>p.Brand).WithMany(p=>p.Products).HasForeignKey(p=>p.BrandID).OnDelete(DeleteBehavior.Restrict); 
            modelBuilder.Entity<Order>().HasOne(p => p.User).WithMany(p => p.Orders).HasForeignKey(p => p.UserID).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<OrderDetail>().HasOne(p => p.Order).WithMany(p => p.OrderDetails).HasForeignKey(p => p.OrderID).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<OrderDetail>().HasOne(p => p.Product).WithMany().HasForeignKey(p => p.ProductID).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Review>().HasOne(p => p.Product).WithMany(p => p.Reviews).HasForeignKey(p => p.ProductID).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Review>().HasOne(p => p.User).WithMany().HasForeignKey(p => p.UserID).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Payment>().HasOne(p => p.Order).WithMany().HasForeignKey(p => p.OrderID).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Payment>().HasOne(p => p.User).WithMany().HasForeignKey(p => p.UserID).OnDelete(DeleteBehavior.Restrict);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-04AMR15;Database=ShoppingDb;Trusted_Connection = true;TrustServerCertificate=True;");
        }

    }
   
}
