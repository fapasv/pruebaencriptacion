using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using encriptacion.Models;
using encriptacion.Services;

namespace encriptacion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            return View(new Mensaje());
        }

        // POST: Encriptar/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Mensaje captura)
        {
            try
            {
                var morse = new ToMorse();
                var octal = new ToOctal();
                captura.Salida = $"{morse.Codificar(captura.Texto)}, {octal.Codificar(captura.Texto)}";
                return View(captura);
            }
            catch
            {
                return View(new Mensaje());
            }
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
