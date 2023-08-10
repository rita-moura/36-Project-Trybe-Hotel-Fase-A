using Microsoft.EntityFrameworkCore;
using TrybeHotel.Models;

namespace TrybeHotel.Repository;
public class TrybeHotelContext : DbContext, ITrybeHotelContext
{
    public TrybeHotelContext(DbContextOptions<TrybeHotelContext> options) : base(options) { }

    public DbSet<City> Cities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public DbSet<Hotel> Hotels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public DbSet<Room> Rooms { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionString = "Server=localhost;Database=TrybeHotel;User=SA;Password=TrybeHotel12!;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}