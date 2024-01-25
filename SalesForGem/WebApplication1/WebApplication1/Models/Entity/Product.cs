using System;
using System.Collections.Generic;

namespace WebApplication1.Models.Entity;

public partial class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public string ProductNo { get; set; } = null!;

    public string Unit { get; set; } = null!;

    public string? PartNumber { get; set; }

    public string? CustomerNumber { get; set; }

    public string? Remarks { get; set; }

    public virtual ICollection<Inquiry> Inquiries { get; set; } = new List<Inquiry>();

    public virtual ICollection<InventoryCount> InventoryCounts { get; set; } = new List<InventoryCount>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<SellQuote> SellQuotes { get; set; } = new List<SellQuote>();

    public virtual ICollection<Sell> Sells { get; set; } = new List<Sell>();

    public virtual ICollection<StockIn> StockIns { get; set; } = new List<StockIn>();
}
