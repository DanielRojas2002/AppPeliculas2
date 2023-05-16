using System;
using System.Collections.Generic;

namespace AppPeliculas.Models;

public partial class Categorium
{
    public int IdCategoria { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<CategoriaAutor> CategoriaAutors { get; set; } = new List<CategoriaAutor>();

    public virtual ICollection<Pelicula> Peliculas { get; set; } = new List<Pelicula>();
}
