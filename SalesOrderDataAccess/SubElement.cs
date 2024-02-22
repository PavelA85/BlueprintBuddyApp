namespace DataAccess;

public class SubElement
{
    public int SubElementId { get; set; } // Primary key
    public int ElementNumber { get; set; } // Assuming 'Element' is a unique identifier or sequence number
    public string Type { get; set; } // e.g., "Doors", "Window"
    public int Width { get; set; }
    public int Height { get; set; }

    // Foreign key for the Window this SubElement belongs to
    public int WindowId { get; set; }
    public Window Window { get; set; }
}