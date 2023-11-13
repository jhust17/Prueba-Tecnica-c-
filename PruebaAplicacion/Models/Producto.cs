using System;
using System.Collections.Generic;

namespace PruebaAplicacion.Models;

public partial class Producto
{
    public long IdProducto { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public string? Categoria { get; set; }

    public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();
}
