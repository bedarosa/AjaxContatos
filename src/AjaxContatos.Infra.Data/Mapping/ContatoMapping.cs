using AjaxContatos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxContatos.Infra.Data.Mapping
{
    public class ContatoMapping : EntityTypeConfiguration<Contato>
    {
        public ContatoMapping()
        {
            HasKey(x => x.Id);

            Property(x => x.Nome)
                .IsRequired();

            Property(x => x.Email)
                .IsRequired();

            Property(x => x.Telefone)
                .IsRequired();

            Property(x => x.Cpf)
                .IsRequired();

            ToTable("Contatos");
        }
    }
}
