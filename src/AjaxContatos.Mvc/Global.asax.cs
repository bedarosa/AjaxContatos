using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AjaxContatos.Infra.CrossCutting.Container;
using AjaxContatos.Infra.Data.Repository;
using AjaxContatos.Mvc.Controllers;
using AjaxContatos.Service.AutoMapperConfig;
using AjaxContatos.Service.Services;
using AjaxContatos.Service.Services.Interfaces;
using AjaxContatos.Service.Validator;
using FluentValidation;
using FluentValidation.Mvc;

namespace AjaxContatos.Mvc
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            FluentValidatorFactory.ValidatorConfiguration();
            AutoMapper.Mapper.Initialize(cfg => cfg.AddProfile<MappingProfile>());
            Bootstrap.BootstrapRegisterInjection();
            FluentValidationModelValidatorProvider.Configure();
        }
    }
}
