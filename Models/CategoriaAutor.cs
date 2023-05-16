using System;
using System.Collections.Generic;

namespace AppPeliculas.Models;

public partial class CategoriaAutor
{
    public int IdCategoriaAutor { get; set; }

    public int IdCategoria { get; set; }

    public int IdAutor { get; set; }

    public virtual Autor IdAutorNavigation { get; set; } = null!;

    public virtual Categorium IdCategoriaNavigation { get; set; } = null!;
}
