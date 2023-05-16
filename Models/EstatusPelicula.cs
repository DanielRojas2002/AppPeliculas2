using System;
using System.Collections.Generic;

namespace AppPeliculas.Models;

public partial class EstatusPelicula
{
    public int IdEstatusPelicula { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Pelicula> Peliculas { get; set; } = new List<Pelicula>();
}
