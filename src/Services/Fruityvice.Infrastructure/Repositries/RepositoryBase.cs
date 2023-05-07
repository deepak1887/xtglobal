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
        dbContext.Set<T>().Add(entity);
        await dbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<IReadOnlyList<T>> GetAllAsync()
    {
        return await dbContext.Set<T>().ToListAsync();
    }
}
