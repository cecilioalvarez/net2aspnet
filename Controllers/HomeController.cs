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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // programo aqui
            ViewBag.Mensaje="hola amigos";
            ViewBag.Nombre="miguel";
            ViewBag.Edad=20;
            List<String> lista1=new List<String>();
            lista1.Add("hola");
            lista1.Add("que");
            lista1.Add("tal");
            lista1.Add("estas");
            ViewBag.lista1=lista1;
            Persona p= new Persona("1","maria","gomez");
            Persona p2= new Persona("2","pepe","perez");
            List<Persona> lista2= new List<Persona>();
            lista2.Add(p);
            lista2.Add(p2);
            ViewBag.persona=p;
            ViewBag.lista2=lista2;


            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
