using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class InvoiceContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=e-InvoiceData;Trusted_Connection=true");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InvoiceProduct>()
      .HasKey(ue => new { ue.InvoiceId, ue.ProductId });
            modelBuilder.Entity<InvoiceProduct>()
                .HasOne(ue => ue.Invoice)
                .WithMany(o => o.Products)
                .HasForeignKey(ue => ue.InvoiceId);
            modelBuilder.Entity<InvoiceProduct>()
               .HasOne(q => q.Product)
              .WithMany(e => e.Invoices)
              .HasForeignKey(q => q.ProductId);




        }


        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<InvoiceProduct> InvoiceProduct { get; set; }

    }
}
