﻿using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class PublicacionController : Controller
    {
        static Sistema _sistema = Sistema.Instancia;

        public IActionResult Index()
        {
            ViewBag.Publicaciones = _sistema.Publicaciones;
            ViewBag.Titulo = "Publicaciones";
            return View();
        }

        public IActionResult Venta()
        {
            ViewBag.Publicaciones = _sistema.ListadoVentas();
            ViewBag.Titulo = "Ventas";
            return View("index");
        }

        public IActionResult Subasta()
        {
            ViewBag.Publicaciones = _sistema.ListadoSubastas();
            ViewBag.Titulo = "Subastas";
            return View("index");
        }

        public IActionResult ListadoPublicacionXNombre(string nombre)
        {
            ViewBag.Publicaciones = _sistema.ListadoPublicacionesXNombre(nombre);
            ViewBag.Titulo = "Subastas";
            return View("index");
        }
    }
}
