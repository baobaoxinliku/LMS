using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace LMS.DAL
{
    public class AccountContext:DbContext
    {
        public AccountContext() : base("AccountContext") { }

        public DbSet<Models.Admin> Admins { get; set; }

        public DbSet<Models.Car> Cars { get; set; }

        public DbSet<Models.F_Customer> F_Customers { get; set; }

        public DbSet<Models.S_Customer> S_Customers { get; set; }

        //public DbSet<Models.Classs> Classss { get; set; }

        //public DbSet<Models.Line> Lines { get; set; }

        //public DbSet<Models.Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}