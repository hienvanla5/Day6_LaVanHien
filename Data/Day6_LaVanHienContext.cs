using Microsoft.EntityFrameworkCore;

public class Day6_LaVanHienContext(DbContextOptions<Day6_LaVanHienContext> options) : DbContext(options)
{
    public DbSet<Day6_LaVanHien.Models.Product> Product { get; set; } = default!;
    public DbSet<Day6_LaVanHien.Models.Genre> Genre { get; set; } = default!;
    public DbSet<Day6_LaVanHien.Models.Movie> Movie { get; set; } = default!;
}
