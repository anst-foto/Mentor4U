using Mentor4U.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
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
            var config = new ConfigurationBuilder()
                       .AddJsonFile("appsettings.json")
                       .SetBasePath(Directory.GetCurrentDirectory())
                       .Build();

            optionsBuilder.UseNpgsql(config.GetConnectionString("Postgres"));
        }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mentor>().ToTable("MentorsTable");

           
        }
    

    
    }

}
