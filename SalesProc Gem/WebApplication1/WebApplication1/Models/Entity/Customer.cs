using System;
using System.Collections.Generic;

namespace WebApplication1.Models.Entity;

public partial class Customer
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

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<SellQuote> SellQuotes { get; set; } = new List<SellQuote>();

    public virtual ICollection<Sell> Sells { get; set; } = new List<Sell>();
}
