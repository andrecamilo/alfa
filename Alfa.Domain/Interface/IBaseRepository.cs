using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa.Domain.Interface
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T obj);
        void Delete(T obj);
        void Delete(int id);
        T Get(int id);
        IEnumerable<T> Get();
        void Update(T obj);
    }
}
