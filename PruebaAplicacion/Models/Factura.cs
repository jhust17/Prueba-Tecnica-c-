using System;
using System.Collections.Generic;

namespace PruebaAplicacion.Models;

public partial class Factura
{
    public long IdFactura { get; set; }

    public string? Establecimiento { get; set; }

    public string? PuntoEmision { get; set; }

    public string? NumeroFactura { get; set; }

    public DateTime? Fecha { get; set; }

    public long? IdCliente { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? TotalIva { get; set; }

    public decimal? Total { get; set; }

    public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();

    public virtual Cliente? IdClienteNavigation { get; set; }
}
