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
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext _context;

        public void BeginTransaction()
        {
            var contextManager = ServiceLocator.Current.GetInstance<ContextManager>();
            _context = contextManager.Context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
