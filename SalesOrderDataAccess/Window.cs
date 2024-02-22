namespace DataAccess;

public class Window
{
    public int WindowId { get; set; } // Primary key
    public string Name { get; set; }
    public int QuantityOfWindows { get; set; }
    public int TotalSubElements { get; set; }
    public List<SubElement> SubElements { get; set; } = new List<SubElement>();

    // Foreign key for the Order this Window belongs to
    public int OrderId { get; set; }
    public Order Order { get; set; }
}