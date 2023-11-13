using System;
using System.Collections.Generic;

namespace PruebaAplicacion.Models;

public partial class Cliente
{
    public long IdCliente { get; set; }

    public string? Identificacion { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}
