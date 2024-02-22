namespace DataAccess;

public class Window
{
    public int WindowId { get; set; }
    public required string Name { get; set; }
    public int QuantityOfWindows { get; set; }
    public int TotalSubElements { get; set; }
    public List<SubElement> SubElements { get; set; } = new();

    public int OrderId { get; set; }
    public Order Order { get; set; }
}