using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace NorthWindMVC.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public string? CustomerId { get; set; }

    public int? EmployeeId { get; set; }

    [DisplayName ("Order Date")]
    public DateTime? OrderDate { get; set; }

    [DisplayName ("Required Date")]
    public DateTime? RequiredDate { get; set; }

    [DisplayName ("Shipped Date")]
    public DateTime? ShippedDate { get; set; }

    [DisplayName ("Ship Via")]
    public int? ShipVia { get; set; }

    [DisplayName ("Freight")]
    public decimal? Freight { get; set; }

    [DisplayName ("Ship Name")]
    public string? ShipName { get; set; }

    [DisplayName ("Ship Address")]
    public string? ShipAddress { get; set; }

    [DisplayName ("Ship City")]
    public string? ShipCity { get; set; }

    [DisplayName ("Ship Region")]
    public string? ShipRegion { get; set; }

    [DisplayName ("Ship Postal Code")]
    public string? ShipPostalCode { get; set; }

    [DisplayName ("Ship Country")]
    public string? ShipCountry { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Shipper? ShipViaNavigation { get; set; }
}
