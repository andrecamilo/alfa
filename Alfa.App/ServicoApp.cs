using Alfa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa.App
{
    public class ServicoApp : BaseApplication
    {
        public void Register(Servico service)
        {
            BeginTrasaction();



            Commit();
        }
    }
}
