using Microsoft.EntityFrameworkCore;
using ProjectOne.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.DataAccess.DBContext
{
    public class DBContexts : DbContext
    {
        public DBContexts(DbContextOptions<DBContexts> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Add your model configurations here
        }
        // Define DbSets for your entities here
        // public DbSet<YourEntity> YourEntities { get; set; }

        // Example:
        public DbSet<Category>? Categorys { get; set; }
    }
}
