﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace NorthWindMVC.Models;

public partial class OrderDetail
{
    public int OrderId { get; set; }

    public int ProductId { get; set; }

    [DisplayName("Unit Price")]
    public decimal UnitPrice { get; set; }

    public short Quantity { get; set; }

    public float Discount { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
