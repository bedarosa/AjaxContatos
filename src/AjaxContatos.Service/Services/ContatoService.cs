using AjaxContatos.Domain.Entities;
using AjaxContatos.Infra.Data.Context;
using AjaxContatos.Infra.Data.Repository;
using AjaxContatos.Service.Services.Interfaces;
using AjaxContatos.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AjaxContatos.Service.AutoMapperConfig;
using AjaxContatos.Infra.Data.Repository.Interfaces;
using FluentValidation;

namespace AjaxContatos.Service.Services
{
    public class ContatoService : IContatoService
    {
        private readonly IContatoRepository _contatoRepository;
        public ContatoService(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        public ContatoViewModel ContatoDetalhes(Guid id)
        {
            return Mapper.Map<ContatoViewModel>(_contatoRepository.GetById(id));
        }

        public void CriarContato(ContatoViewModel contatoViewModel)
        {
            contatoViewModel.Id = Guid.NewGuid();
            _contatoRepository.Create(Mapper.Map<Contato>(contatoViewModel));
        }

        public void DeletarContato(Guid id)
        {
            _contatoRepository.Deletar(id);
        }

        public ContatoViewModel EditarContato(ContatoViewModel contatoViewModel)
        {
            var contato = Mapper.Map<Contato>(contatoViewModel);
            _contatoRepository.Editar(contato);
            return Mapper.Map<ContatoViewModel>(contato);
        }

        public List<ContatoViewModel> ListarTodosContatos()
        {
            IList<Contato> listaContatos = _contatoRepository.GetAll();
            return Mapper.Map<List<ContatoViewModel>>(_contatoRepository.GetAll());
        }

    }
}

