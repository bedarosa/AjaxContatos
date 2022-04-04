using AjaxContatos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxContatos.Service.ViewModels
{
    public class ContatoViewModel 
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public List<Contato> Contatos { get; set; }
        public int NumeroDeContatos { get; set; }
        public string Cpf { get; set; }
    }
}
