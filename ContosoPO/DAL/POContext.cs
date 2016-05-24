using ContosoPO.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ContosoPO.DAL
{
    public class POContext : DbContext
    {

        public POContext() : base("POContext")
        {
        }

        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }

        public DbSet<LineItem> LineItems { get; set; }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}