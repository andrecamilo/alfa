
using Alfa.Infra.Repository;
using Alfa.Domain.Interface;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa.Infra.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected DbContext Context { get; private set; }

        public BaseRepository()
        {
            var contextManager = ServiceLocator.Current.GetInstance<ContextManager>();
            Context = contextManager.Context;
        }

        public void Add(T obj)
        {
            Context.Set<T>().Add(obj);
        }

        public void Delete(int id)
        {
            var obj = Get(id);
            Context.Set<T>().Remove(obj);
        }

        public void Delete(T obj)
        {
            Context.Set<T>().Remove(obj);
        }

        public IEnumerable<T> Get()
        {
            return  Context.Set<T>().ToList();
        }

        public T Get(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public void Update(T obj)
        {
            Context.Entry(obj).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
