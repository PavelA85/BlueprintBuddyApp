namespace DataAccess;

public class SubElement
{
    public int SubElementId { get; set; }
    public int ElementNumber { get; set; }
    public required string Type { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public int WindowId { get; set; }
    public required Window Window { get; set; }
}