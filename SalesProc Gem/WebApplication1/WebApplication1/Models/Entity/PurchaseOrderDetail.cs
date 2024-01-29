using System;
using System.Collections.Generic;

namespace WebApplication1.Models.Entity;

public partial class PurchaseOrderDetail
{
    public int Id { get; set; }

    public int PurchaseId { get; set; }

    public int ProductId { get; set; }

    public decimal UnitPrice { get; set; }

    public int Quantity { get; set; }

    public DateTime? ArrivalDate { get; set; }

    public string? Remarks { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual PurchaseOrder Purchase { get; set; } = null!;
}
