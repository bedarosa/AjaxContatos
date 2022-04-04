using AjaxContatos.Domain.Entities;
using AjaxContatos.Infra.Data.Context;
using AjaxContatos.Infra.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AjaxContatos.Infra.Data.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly AjaxContext context;
        public ContatoRepository()
        {
            context = new AjaxContext();
        }

        public void Create(Contato contato)
        {
            context.Contatos.Add(contato);
            context.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            context.Contatos.Remove(GetById(id));
            context.SaveChanges();
        }

        public Contato Editar(Contato contato)
        {
            //var contatoCompleto = GetById(contato.Id);
            context.Entry(contato).State = EntityState.Modified;
            context.SaveChanges();
            return contato;
        }

        public List<Contato> GetAll()
        {
            return context.Contatos.ToList();
        }

        public Contato GetById(Guid id)
        {
            return context.Contatos.Find(id);
        }
    }
}
