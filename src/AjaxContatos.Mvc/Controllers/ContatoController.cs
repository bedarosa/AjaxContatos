using AjaxContatos.Service.Services;
using AjaxContatos.Service.Services.Interfaces;
using AjaxContatos.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxContatos.Mvc.Controllers
{
    public class ContatoController : Controller
    {
        readonly IContatoService _contatoService;
        public ContatoController(IContatoService contatoService)
        {
            _contatoService = contatoService;
        }

        public ActionResult Index()
        {
            return View(_contatoService.ListarTodosContatos());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContatoViewModel contatoViewModel)
        {
            if (ModelState.IsValid)
            {
                _contatoService.CriarContato(contatoViewModel);
                return RedirectToAction("Index");
            }
            return View(contatoViewModel);

        }

        [HttpGet]
        public ActionResult Details(Guid id)
        {

            return View(_contatoService.ContatoDetalhes(id));
        }

        public ActionResult Delete(Guid id)
        {
            _contatoService.DeletarContato(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(Guid id)
        {
            return View(_contatoService.ContatoDetalhes(id));
        }

        [HttpPost]
        public ActionResult Edit(ContatoViewModel contatoViewModel)
        {
            if (ModelState.IsValid)
            {
                _contatoService.EditarContato(contatoViewModel);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult BelaView()
        {
            return View();
        }
    }
}