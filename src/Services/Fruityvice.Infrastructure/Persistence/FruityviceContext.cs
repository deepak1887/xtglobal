using Fruityvice.Domain.Enitites;
using Microsoft.EntityFrameworkCore;

namespace Fruityvice.Infrastructure.Persistence;
public class FruityviceContext : DbContext
{
    public FruityviceContext(DbContextOptions<FruityviceContext> options) : base(options)
    {
    }

    public DbSet<Fruit> Fruits { get; set; }
    public DbSet<Nutrition> Nutritions { get; set; }

}
