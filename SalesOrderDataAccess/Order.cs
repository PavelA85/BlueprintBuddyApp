namespace DataAccess;

public class Order
{
    public int OrderId { get; set; }
    public required string Name { get; set; }
    public required string State { get; set; }
    public required List<Window> Windows { get; set; }
}