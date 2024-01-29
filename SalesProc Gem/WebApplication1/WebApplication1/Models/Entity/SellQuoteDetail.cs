using System;
using System.Collections.Generic;

namespace WebApplication1.Models.Entity;

public partial class SellQuoteDetail
{
    public int Id { get; set; }

    public int SellQuoteId { get; set; }

    public int ProductId { get; set; }

    public decimal UnitPrice { get; set; }

    public int? Moq { get; set; }

    public string? Remarks { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual SellQuote SellQuote { get; set; } = null!;
}
