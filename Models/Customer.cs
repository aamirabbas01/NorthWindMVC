using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace NorthWindMVC.Models;

public partial class Customer
{
    public string CustomerId { get; set; } = null!;

    [DisplayName ("Company Name")]
    public string CompanyName { get; set; } = null!;

    [DisplayName ("Contact Name")]
    public string? ContactName { get; set; }

    [DisplayName ("Contact Title")]
    public string? ContactTitle { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? Region { get; set; }

    [DisplayName ("Postal Code")]
    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<CustomerDemographic> CustomerTypes { get; set; } = new List<CustomerDemographic>();
}
