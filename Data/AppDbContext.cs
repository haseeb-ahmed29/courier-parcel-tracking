using Microsoft.EntityFrameworkCore;
using CourierParcelTracking.Models;

namespace CourierParcelTracking.Data;
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Shipment> Shipments => Set<Shipment>();
}
