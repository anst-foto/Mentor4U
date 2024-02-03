using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor4U.WpfClassic.Repository
{
    public interface IRepository<T>
    {
        Task Add(T entity);

        Task Delete(T entity);

        IEnumerable<T> GetAll();

        T Get(int id);

        Task Update (T entity);
    }
}
