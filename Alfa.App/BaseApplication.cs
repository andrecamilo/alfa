using Alfa.Domain.Interface;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa.App
{
    public class BaseApplication
    {
        private IUnitOfWork uow;
        public void BeginTrasaction()
        {
            uow = ServiceLocator.Current.GetInstance<IUnitOfWork>();
            uow.BeginTransaction();
        }

        public void Commit()
        {
            uow.Commit();
        }
    }
}
