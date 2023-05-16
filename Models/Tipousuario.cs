using System;
using System.Collections.Generic;

namespace AppPeliculas.Models;

public partial class Tipousuario
{
    public int IdTipoUsuario { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
