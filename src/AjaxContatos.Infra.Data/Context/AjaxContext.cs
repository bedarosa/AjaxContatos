using AjaxContatos.Domain.Entities;
using AjaxContatos.Infra.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxContatos.Infra.Data.Context
{
    public class AjaxContext : DbContext
    {
        public AjaxContext()
            :base("DefaultConnection")
        {

        }

        public DbSet<Contato> Contatos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<string>()
                .Configure(x => x.HasColumnType("varchar")
                .HasMaxLength(100));

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new ContatoMapping());

            base.OnModelCreating(modelBuilder);
        }

    }
}
