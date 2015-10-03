using Alfa.Infra.Repository;
using Alfa.Domain.Interface;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa.Infra.IoC
{
    public class IoCModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IBaseRepository<>)).To(typeof(BaseRepository<>));
            Bind<IServicoRepository>().To<ServicoRepository>();
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<ContextManager>().ToSelf();
        }
    }
}
