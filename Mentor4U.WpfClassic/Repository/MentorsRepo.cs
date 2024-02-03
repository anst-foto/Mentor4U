using Mentor4U.Domain;
using Mentor4U.WpfClassic.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor4U.WpfClassic.Repository
{
    public class MentorsRepo : IRepository<Mentor>
    {
        

        public async Task Add(Mentor entity)
        {
            using(var db=new DataContext())
            {
                await db.Mentors.AddAsync(entity);
                await db.SaveChangesAsync();

            }
        }

        public async Task Delete(Mentor entity)
        {
            using (var db=new DataContext())
            {
                db.Mentors.Remove(entity);
                await db.SaveChangesAsync();
            }
        }

        public Mentor? Get(int id)
        {

           using(var db =new DataContext())
            {
                return db.Mentors.FirstOrDefault(x => x.Id == id);
            }
          
        }

        public IEnumerable<Mentor> GetAll()
        {
            using(var db=new DataContext())
            {
                return db.Mentors.AsEnumerable();
            }
        }

        public async Task Update(Mentor entity)
        {
            using(var db=new DataContext())
            {
                db.Mentors.Update(entity);
                await db.SaveChangesAsync();
            }
        }
    }
}
