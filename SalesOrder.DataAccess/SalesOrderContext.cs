using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class SalesOrderContext : DbContext
{
    public SalesOrderContext(DbContextOptions<SalesOrderContext> options) : base(options)
    {
    }

    public DbSet<Order> Orders { get; set; }
    public DbSet<Window> Windows { get; set; }
    public DbSet<SubElement> SubElements { get; set; }
}