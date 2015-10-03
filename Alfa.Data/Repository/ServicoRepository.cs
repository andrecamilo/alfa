using Alfa.Infra.Repository;
using Alfa.Domain.Entities;
using Alfa.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa.Infra.Repository
{
    public class ServicoRepository : BaseRepository<Servico>, IServicoRepository
    {
        public IEnumerable<Servico> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
