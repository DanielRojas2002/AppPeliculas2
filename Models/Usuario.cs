using System;
using System.Collections.Generic;

namespace AppPeliculas.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public int IdTipoUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public string? APaterno { get; set; }

    public string? AMaterno { get; set; }

    public string Correo { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public virtual ICollection<Carrito> Carritos { get; set; } = new List<Carrito>();

    public virtual Tipousuario IdTipoUsuarioNavigation { get; set; } = null!;
}
