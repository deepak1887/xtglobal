using Fruityvice.Application.Persistence;
using Fruityvice.Infrastructure.Persistence;
using Fruityvice.Infrastructure.Repositries;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Fruityvice.Infrastructure;
public static class RegisterInfra
{
    public static void AddInfra(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<FruityviceContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DemoConnection")));

        services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
        services.AddScoped<INutritionRepository, NutritionRepository>();
        services.AddScoped<IFruitRepository, FruitRepository>();
    }
}
