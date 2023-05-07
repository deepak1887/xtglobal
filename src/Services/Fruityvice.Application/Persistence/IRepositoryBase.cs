using Fruityvice.Domain.Common;

namespace Fruityvice.Application.Persistence;
public interface IRepositoryBase<T> where T : EntityBase
{
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<T> AddAsync(T entity);
}
