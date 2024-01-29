using System;
using System.Collections.Generic;

namespace WebApplication1.Models.Entity;

public partial class PurchaseOrder
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public string DocumentNumber { get; set; } = null!;

    public int SupplierId { get; set; }

    public int ProductId { get; set; }

    public decimal UnitPrice { get; set; }

    public int Quantity { get; set; }

    public string? Remarks { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; } = new List<PurchaseOrderDetail>();

    public virtual Supplier Supplier { get; set; } = null!;
}
