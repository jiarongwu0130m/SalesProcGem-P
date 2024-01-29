using System;
using System.Collections.Generic;

namespace WebApplication1.Models.Entity;

public partial class SellDetail
{
    public int Id { get; set; }

    public int SellId { get; set; }

    public int ProductId { get; set; }

    public decimal UnitPrice { get; set; }

    public int Quantity { get; set; }

    public string? Remarks { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual Sell Sell { get; set; } = null!;
}
