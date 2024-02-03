using Mentor4U.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor4U.WpfClassic.DAL
{
    public class DataContext:DbContext
    {
       public DbSet<Mentor> Mentors { get; set; }

   

        public DataContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=M4UDB;Username=postgres;Password=1984;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mentor>().ToTable("MentorsTable");

           
        }
    }
}
