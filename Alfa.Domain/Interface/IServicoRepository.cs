using Alfa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa.Domain.Interface
{
    public interface IServicoRepository : IBaseRepository<Servico>
    {
        IEnumerable<Servico> GetByNome(string nome);
    }
}
