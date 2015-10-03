using Alfa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa.Infra.Repository
{
    public class ServicoMap: EntityTypeConfiguration<Servico>
    {
        public ServicoMap()
        {
            Property(p => p.id).IsRequired();
            Property(p => p.nome).IsRequired().HasMaxLength(250);
        }
    }
}
