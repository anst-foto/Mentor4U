using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mentor4U.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DAL.Mentor4U
{
    public class AppContext : DbContext
    {
        DbSet<Mentor> Mentors { get; set; }

        DbSet<Scill> Scills { get; set; }

        public AppContext(DbContextOptions<AppContext> options) : base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MentorsDB;Username=postgres;Password=1984");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mentor>().ToTable("MentorsDTO");

            modelBuilder.Entity<Scill>().ToTable("ScillDTO");
        }
    }
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppContext>
    {
        public AppContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MentorsDB;Username=postgres;Password=1984");

            return new AppContext(optionsBuilder.Options);
        }

        AppContext IDesignTimeDbContextFactory<AppContext>.CreateDbContext(string[] args)
        {
            throw new NotImplementedException();
        }
    }
}
