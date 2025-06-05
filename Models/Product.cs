using System.ComponentModel;

namespace NorthWindMVC.Models;

public partial class Product
{

    public int ProductId { get; set; }

    [DisplayName ("Product Name")]

    public string ProductName { get; set; } = null!;

    public int? SupplierId { get; set; }

    public int? CategoryId { get; set; }

    [DisplayName ("Quantity Per Unit")]
    public string? QuantityPerUnit { get; set; }

    [DisplayName ("Unit Price")]
    public decimal? UnitPrice { get; set; }

    [DisplayName ("Units In Stock")]
    public short? UnitsInStock { get; set; }

    [DisplayName ("Units On Order")]
    public short? UnitsOnOrder { get; set; }

    [DisplayName ("Reorder Level")]
    public short? ReorderLevel { get; set; }

    public bool Discontinued { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Supplier? Supplier { get; set; }
}
