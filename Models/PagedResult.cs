public class PagedResult<T>
{
    public required IEnumerable<T> Items { get; set; }
    public int PageNumber { get; set; }
    public int TotalPages { get; set; }
}
