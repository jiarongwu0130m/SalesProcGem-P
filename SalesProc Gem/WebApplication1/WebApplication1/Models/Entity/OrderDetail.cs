using System;
using System.Collections.Generic;

namespace WebApplication1.Models.Entity;

public partial class OrderDetail
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public decimal UnitPrice { get; set; }

    public int Quantity { get; set; }

    public DateTime? ShippingDate { get; set; }

    public string? Remarks { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
