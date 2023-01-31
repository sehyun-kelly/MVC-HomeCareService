using HomeCareService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HomeCareService
{
    public class AppContext : DbContext
    {
        public AppContext() : base("DefaultConnection")
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Service> Services { get; set; }

        public System.Data.Entity.DbSet<HomeCareService.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<HomeCareService.Models.Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
            .HasMany(c => c.Services).WithMany(i => i.Customers)
            .Map(t => t.MapLeftKey("Customer_ID")
             .MapRightKey("Service_ID")
                .ToTable("CustomerService"));
        }

    }
}