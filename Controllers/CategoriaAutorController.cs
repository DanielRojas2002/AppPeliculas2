using AppPeliculas.Models;
using AppPeliculas.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppPeliculas.Controllers
{
    public class CategoriaAutorController : Controller
    {

        private readonly DbpeliculasContext _context;

        public CategoriaAutorController (DbpeliculasContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {

            // include debes de tener antes un modelo que junta las tablas 
            var x = _context.CategoriaAutors.Include(m => m.IdCategoriaNavigation );


            // aqui no hay 
            var query_join4 = from tablaunion in _context.CategoriaAutors
                              join Categoria in _context.Categoria
                              on tablaunion.IdCategoria equals Categoria.IdCategoria
                              join Autor in _context.Autors
                              on tablaunion.IdAutor equals Autor.IdAutor
                              select new CategoriaAutorVM
                              {
                                  idcategoria = tablaunion.IdCategoria,
                                  descripcioncategoria = Categoria.Descripcion,
                                  idautor = tablaunion.IdAutor,
                                  nombrecompleto = Autor.Nombre + " " + Autor.APaterno + " " + Autor.AMaterno,


                              };



            return View(query_join4.ToList());
        }
    }
}
