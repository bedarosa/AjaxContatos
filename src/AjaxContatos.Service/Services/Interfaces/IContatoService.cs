using AjaxContatos.Domain.Entities;
using AjaxContatos.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxContatos.Service.Services.Interfaces
{
    public interface IContatoService : IService<ContatoViewModel>
    {
        List<ContatoViewModel> ListarTodosContatos();
        void CriarContato(ContatoViewModel contatoViewModel);
        ContatoViewModel ContatoDetalhes(Guid id);
        void DeletarContato(Guid id);
        ContatoViewModel EditarContato(ContatoViewModel contatoViewModel);
    }
}
