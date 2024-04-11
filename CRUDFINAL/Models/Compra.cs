using System;
using System.Collections.Generic;

namespace CRUDFINAL.Models;

public partial class Compra
{
    public int Id { get; set; }

    public int? IdProveedor { get; set; }

    public DateOnly? Fecha { get; set; }

    public double? Total { get; set; }

    public double? Subtotal { get; set; }

    public double? Descuento { get; set; }

    public double? Iva { get; set; }
}
