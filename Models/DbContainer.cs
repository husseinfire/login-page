using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class DbContainer : DbContext
    {
        public DbContainer() : base("mycon")
        {
            // Database.SetInitializer(new MigrateDatabaseToLatestVersion<DbContainer, Migrations.Configuration>());
        }

        public DbSet<RegistrationUser> RegistrationUser { get; set; }
    }
}