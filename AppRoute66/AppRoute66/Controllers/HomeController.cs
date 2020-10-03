using AppRoute66.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppRoute66.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnumerable<Noticia> AsNoticias;

        public HomeController()
        {
            AsNoticias = new Noticia().TodasAsNoticias().OrderByDescending(x => x.Data);
        }

        public ActionResult Index()
        {
            var ultimasNoticias = AsNoticias.Take(3);
            var AsCategorias = AsNoticias.Select(x => x.Categoria).Distinct().ToList();

            ViewBag.Categoria = AsCategorias;

            return View(ultimasNoticias);
        }

        public ActionResult MostrarNoticia(int noticiaId, string titulo, string categoria)
        {
            return View(AsNoticias.FirstOrDefault(x => x.NoticiaId == noticiaId));
        }

        public ActionResult MostraCategoria(string categoria)
        {
            var categoriaEspecifica = AsNoticias.Where(x => x.Categoria.ToLower() == categoria.ToLower()).ToList();
            ViewBag.Categoria = categoria;
            return View(categoriaEspecifica);
        }

        public ActionResult Noticia()
        {
            return View(AsNoticias);
        }

        public ActionResult Estilo()
        {
            return View();
        }

    }
}