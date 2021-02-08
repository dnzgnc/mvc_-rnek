using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_SanatBlog.Models.Context
{
    public class girisContext:DbContext
    {
        public girisContext()
        {
            Database.Connection.ConnectionString = "server=.;database=DYSANIA;uid=null;pwd=null";
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<AppUserAndRole> AppUserAndRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUserAndRole>().HasKey(x => new { x.AppUserId, x.RoleId });
            base.OnModelCreating(modelBuilder);
        }
    }
}