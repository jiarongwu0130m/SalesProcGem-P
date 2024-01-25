using System;
using System.Collections.Generic;

namespace WebApplication1.Models.Entity;

public partial class InventoryCount
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int StockQuantity { get; set; }

    public int CountQuantity { get; set; }

    public string? Remarks { get; set; }

    public virtual Product Product { get; set; } = null!;
}
