using System;
using System.Collections.Generic;

namespace PruebaAplicacion.Models;

public partial class DetalleFactura
{
    public long IdDetalle { get; set; }

    public long? IdFactura { get; set; }

    public long? IdProducto { get; set; }

    public decimal? Cantidad { get; set; }

    public string? UnidadMedida { get; set; }

    public decimal? Precio { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Subtotal { get; set; }

    public virtual Factura? IdFacturaNavigation { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }
}
