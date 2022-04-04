using AjaxContatos.Domain.Entities;
using AjaxContatos.Service.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxContatos.Service.AutoMapperConfig
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Contato, ContatoViewModel>().ReverseMap();
        }
    }
}
