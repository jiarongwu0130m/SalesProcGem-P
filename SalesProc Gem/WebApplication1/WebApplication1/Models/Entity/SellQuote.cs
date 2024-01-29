using System;
using System.Collections.Generic;

namespace WebApplication1.Models.Entity;

public partial class SellQuote
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public string DocumentNumber { get; set; } = null!;

    public int CustomerId { get; set; }

    public int ProductId { get; set; }

    public decimal UnitPrice { get; set; }

    public int? Moq { get; set; }

    public string? Note { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;

    public virtual ICollection<SellQuoteDetail> SellQuoteDetails { get; set; } = new List<SellQuoteDetail>();
}
