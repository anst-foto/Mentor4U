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
        {;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mentor>().ToTable("MentorsTable");

           
        }
    }
}
