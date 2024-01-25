﻿using System;
using System.Collections.Generic;

namespace WebApplication1.Models.Entity;

public partial class Inquiry
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public string DocumentNumber { get; set; } = null!;

    public int SupplierId { get; set; }

    public int ProductId { get; set; }

    public decimal UnitPrice { get; set; }

    public int? Moq { get; set; }

    public string? Remarks { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;
}
