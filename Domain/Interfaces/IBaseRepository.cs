using Domain.Entities;
using System.Linq.Expressions;

namespace Domain.Interfaces;

public interface IBaseRepository<TEntity> where TEntity : EntityBase
{
    public Task<IEnumerable<TEntity>> ListAsync(Expression<Func<TEntity, bool>>? predicate = null);

    public Task<TEntity?> Find(Guid id);

    public Task Add(TEntity entity);

    public void Update(TEntity entity);

    public void Remove(TEntity entity);

    public Task Commit();

    public IQueryable<TEntity> Query();
}
