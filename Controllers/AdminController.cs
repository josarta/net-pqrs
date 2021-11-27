using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PQRS.Models;

namespace PQRS.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.nombreUsuario = "Jose Luis";
            ViewBag.correoUsuario = "josarta@misena.edu.co";
            ViewData["miga"]="Administrador/Management User";
            return View();
        }

          public IActionResult Profiles()
        {
            ViewBag.nombreUsuario = "Jose Luis";
            ViewBag.correoUsuario = "josarta@misena.edu.co";
            ViewData["miga"]="Administrador/Management Profiles";
            return View();
        }


          public IActionResult Management()
        {
            ViewBag.nombreUsuario = "Jose Luis";
            ViewBag.correoUsuario = "josarta@misena.edu.co";
            ViewData["miga"]="Administrador/Management PQRS";
            return View();
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
