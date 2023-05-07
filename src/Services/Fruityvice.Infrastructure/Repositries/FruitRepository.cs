using Fruityvice.Application.Persistence;
using Fruityvice.Domain.Enitites;
using Fruityvice.Infrastructure.Persistence;

namespace Fruityvice.Infrastructure.Repositries;
public class FruitRepository : RepositoryBase<Fruit>, IFruitRepository
{
    public FruitRepository(FruityviceContext context): base(context)
    {

    }
}
