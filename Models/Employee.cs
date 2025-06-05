using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace NorthWindMVC.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    [DisplayName("Last Name")]
    public string LastName { get; set; } = null!;

    [DisplayName("First Name")]
    public string FirstName { get; set; } = null!;

    public string? Title { get; set; }

    [DisplayName("Title of Courtesy")]
    public string? TitleOfCourtesy { get; set; }

    [DisplayName("Birth Date")]
    public DateTime? BirthDate { get; set; }
    
    [DisplayName("Hire Date")]
    public DateTime? HireDate { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    
    public string? Region { get; set; }

    [DisplayName("Postal Code")]
    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? HomePhone { get; set; }

    public string? Extension { get; set; }

    public byte[]? Photo { get; set; }

    public string? Notes { get; set; }

    [DisplayName("Reports To")]
    public int? ReportsTo { get; set; }

    [DisplayName("Photo Path")]
    public string? PhotoPath { get; set; }

    public virtual ICollection<Employee> InverseReportsToNavigation { get; set; } = new List<Employee>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Employee? ReportsToNavigation { get; set; }

    public virtual ICollection<Territory> Territories { get; set; } = new List<Territory>();
}
