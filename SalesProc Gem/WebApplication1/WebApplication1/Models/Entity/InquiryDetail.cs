using System;
using System.Collections.Generic;

namespace WebApplication1.Models.Entity;

public partial class InquiryDetail
{
    public int Id { get; set; }

    public int InquiryId { get; set; }

    public int ProductId { get; set; }

    public decimal UnitPrice { get; set; }

    public int? Moq { get; set; }

    public string? Remarks { get; set; }

    public virtual Inquiry Inquiry { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
