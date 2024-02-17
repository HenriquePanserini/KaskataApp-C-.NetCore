using KaskataDDD.Infrastructure.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaskataDDD.Infrastructure.Configuration
{
    internal class Context : IdentityDbContext<ApplicationUser>
    {
        public Context(DbContextOptions<Context> options) :  base(options)
        {  
        
        }

        public DbSet<News> News { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(e => e.Id);

            base.OnModelCreating(builder);
        }

        public string ConnectionString()
        {
            string strcon = "Data Source=DESKTOP-JDDJMQ9\\SQLEXPRESS; Initial Catalog=API_KASKATA_2024; Integrated Security=False; User ID=DESKTOP-JDDJMQ9\\henri;";
            return strcon;
        }
    }
}
