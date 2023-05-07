using Fruityvice.Application.Persistence;
using Fruityvice.Domain.Common;
using Fruityvice.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Fruityvice.Infrastructure.Repositries;
public class RepositoryBase<T> : IRepositoryBase<T> where T : EntityBase
{
    protected readonly FruityviceContext dbContext;
    public RepositoryBase(FruityviceContext dbContext)
    {
        this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    }

    public async Task<T> AddAsync(T entity)
    {
        var max = await dbContext.Set<T>().ToListAsync(); // this can be optimized
        var maxId = max.Max(x => x.Id);
        entity.Id = ++maxId;
        dbContext.Set<T>().Add(entity);
        await dbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<IReadOnlyList<T>> GetAllAsync()
    {
        return await dbContext.Set<T>().ToListAsync();
    }
}
