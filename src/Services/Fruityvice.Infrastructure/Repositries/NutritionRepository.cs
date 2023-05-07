using Fruityvice.Application.Persistence;
using Fruityvice.Domain.Enitites;
using Fruityvice.Infrastructure.Persistence;

namespace Fruityvice.Infrastructure.Repositries;
public class NutritionRepository : RepositoryBase<Nutrition>, INutritionRepository
{
    public NutritionRepository(FruityviceContext dbContext) : base(dbContext)
    {
    }
}
