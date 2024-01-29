using System;
using System.Collections.Generic;

namespace WebApplication1.Models.Entity;

public partial class Supplier
{
    public int Id { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? TaxId { get; set; }

    public string Address { get; set; } = null!;

    public string ContactName { get; set; } = null!;

    public string CellPhone { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Remarks { get; set; }

    public virtual ICollection<Inquiry> Inquiries { get; set; } = new List<Inquiry>();

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<StockIn> StockIns { get; set; } = new List<StockIn>();
}
