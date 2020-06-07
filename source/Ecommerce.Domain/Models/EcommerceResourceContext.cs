using System;
using System.Collections.Generic;
using System.Linq;
using Ecommerce.Core.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ecommerce.Domain.Models
{
    public partial class EcommerceResourceContext : DbContext
    {
        public EcommerceResourceContext()
        {
        }

        public EcommerceResourceContext(DbContextOptions<EcommerceResourceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(Const.DatabaseResourceConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            #region Seed Data Brands
            var brands = new List<Brand>()
            {
                new Brand()
                {
                    Id = 1,
                    Name = "Foods",
                    CreatedDate = DateTime.Now,
                    CreatedBy = 1,
                    UpdatedDate = DateTime.Now,
                    UpdatedBy = 1,
                },
                new Brand()
                {
                    Id = 2,
                    Name = "Drinks",
                    CreatedDate = DateTime.Now,
                    CreatedBy = 1,
                    UpdatedDate = DateTime.Now,
                    UpdatedBy = 1,
                },
            };
            modelBuilder.Entity<Brand>().HasData(brands);
            #endregion

            #region Seed Data Products
            var products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    CreatedBy = 1,
                    UpdatedDate = DateTime.Now,
                    UpdatedBy = 1,
                    Name = "Super Potato",
                    BrandId = 1,
                    Price = 50000,
                    Amount = 500,
                },
                new Product()
                {
                    Id = 2,
                    CreatedDate = DateTime.Now,
                    CreatedBy = 1,
                    UpdatedDate = DateTime.Now,
                    UpdatedBy = 1,
                    Name = "Strawberry Jam",
                    BrandId = 2,
                    Price = 50000,
                    Amount = 500,
                },
            };
            modelBuilder.Entity<Product>().HasData(products);

            #endregion

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
