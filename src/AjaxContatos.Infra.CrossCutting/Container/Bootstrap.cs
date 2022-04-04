using AjaxContatos.Infra.Data.Repository.Interfaces;
using AjaxContatos.Service.Services;
using AjaxContatos.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;
using System.Web.Mvc;
using SimpleInjector.Integration.Web.Mvc;
using AjaxContatos.Infra.Data.Repository;
using System.Reflection;
using System.Web.WebPages;
using FluentValidation;

namespace AjaxContatos.Infra.CrossCutting.Container
{
    public static class Bootstrap
    {
        public static SimpleInjector.Container BootstrapRegisterInjection()
        {
            var container = new SimpleInjector.Container();
            container.Register<IContatoService, ContatoService>();
            container.Register<IContatoRepository, ContatoRepository>();

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.RegisterMvcIntegratedFilterProvider();

            container.Options.ResolveUnregisteredConcreteTypes = true;

            container.Verify();

            DependencyResolver.SetResolver(
            new SimpleInjectorDependencyResolver(container));
            return container;
        }
    }
}
