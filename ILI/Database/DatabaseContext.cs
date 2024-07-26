using ILI.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace ILI.Database
{
    internal class DatabaseContext : DbContext
    {
        public DbSet<Soldier> Soldiers { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Sensor> Sensors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ILIDB"].ConnectionString);
        }
    }
}
