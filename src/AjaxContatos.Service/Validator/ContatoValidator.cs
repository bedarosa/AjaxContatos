using AjaxContatos.Service.ViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxContatos.Service.Validator
{
    public class ContatoValidator : AbstractValidator<ContatoViewModel>
    {
        public ContatoValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Preencha este campo com um nome válido.");
            RuleFor(x => x.Email).NotEmpty().EmailAddress().WithMessage("Preencha este campo com um e-mail válido.");
            RuleFor(x => x.Telefone).NotEmpty().WithMessage("Preencha este campo com um telefone válido.");
            RuleFor(x => x.Cpf).NotEmpty().IsValidCPF().WithMessage("Preencha com um cpf válido.");
        }
    }
}
