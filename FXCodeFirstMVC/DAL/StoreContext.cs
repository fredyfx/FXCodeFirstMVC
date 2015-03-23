using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Adding EF support for CodeFirst
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
//Adding for checking our models
using FXCodeFirstMVC.Models;

namespace FXCodeFirstMVC.DAL
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base ("StoreContext")
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}