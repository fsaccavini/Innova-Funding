using Innova_Funding.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Innova_Funding.Infraestructure.Data
{
    public class Innova_FundingContext : DbContext
    {
        public Innova_FundingContext(DbContextOptions<Innova_FundingContext> options)
        : base(options)
        { }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().Ignore(c => c.SalePrice);
        }
    }
}
