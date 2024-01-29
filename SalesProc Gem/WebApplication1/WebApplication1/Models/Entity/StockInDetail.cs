using System;
using System.Collections.Generic;

namespace WebApplication1.Models.Entity;

public partial class StockInDetail
{
    public int Id { get; set; }

    public int StockInId { get; set; }

    public int ProductId { get; set; }

    public decimal UnitPrice { get; set; }

    public int Quantity { get; set; }

    public string? 備註 { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual StockIn StockIn { get; set; } = null!;
}
