using Domain.Entities;

namespace Domain.Interfaces;

public interface IBaseRepository<TEntity> where TEntity : EntityBase
{
    public Task<IEnumerable<TEntity>> List();

    public Task<TEntity?> Find(Guid id);

    public Task Add(TEntity entity);

    public void Update(TEntity entity);

    public void Remove(TEntity entity);

    public Task Commit();

    public IQueryable<TEntity> Query();
}
