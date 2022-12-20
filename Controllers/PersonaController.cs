using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using net2.Models;

namespace net2.Controllers
{
    public class PersonaController : Controller
    {
        private readonly ILogger<PersonaController> _logger;

        public PersonaController(ILogger<PersonaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           PersonaRepository repositorio= new PersonaRepository();
           List<Persona>lista=repositorio.BuscarTodas();
           ViewBag.lista=lista;
            return View();
        }

        public IActionResult FormularioInsertar()
        {
            return View();
        }

           public IActionResult Insertar(Persona persona)
        {
            PersonaRepository repositorio= new PersonaRepository();
            repositorio.Insertar(persona);
            List<Persona>lista=repositorio.BuscarTodas();
            ViewBag.lista=lista;
            return View("Index");
        }


           public IActionResult FormularioEditar()
        {
            PersonaRepository repositorio= new PersonaRepository();
            
            return View();
        }


            public IActionResult Borrar (String dni)
        {
            PersonaRepository repositorio= new PersonaRepository();
            repositorio.Borrar(new Persona(dni));
            List<Persona>lista=repositorio.BuscarTodas();
            ViewBag.lista=lista;
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
