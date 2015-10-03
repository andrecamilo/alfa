using Alfa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa.Infra.Repository
{
    public class Context: DbContext
    {
        DbSet<Servico> Servicos { get; set; }

        public Context(): base("DefaultConnection") 
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Alfa.Infra.Repository.Migrations.Configuration>("DefaultConnection"));
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new ServicoMap());
        }
    }
}
