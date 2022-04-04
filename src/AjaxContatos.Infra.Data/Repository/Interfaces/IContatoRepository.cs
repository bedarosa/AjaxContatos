using AjaxContatos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxContatos.Infra.Data.Repository.Interfaces
{
    public interface IContatoRepository : IRepository<Contato>
    {
        List<Contato> GetAll();
        void Create(Contato contato);
        Contato GetById(Guid id);
        void Deletar(Guid id);
        Contato Editar(Contato contato);
    }
}
