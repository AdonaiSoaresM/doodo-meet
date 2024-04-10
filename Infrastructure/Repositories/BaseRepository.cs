using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Repositories;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : EntityBase
{
    protected readonly ProjectContext _context;
    protected readonly DbSet<TEntity> Dbset;

    public BaseRepository(ProjectContext context)
    {
        _context = context;
        Dbset = context.Set<TEntity>();
    }

    public async Task Add(TEntity entity)
    {
        await Dbset.AddAsync(entity);
    }

    public async Task Commit()
    {
        await _context.SaveChangesAsync();
    }

    public async Task<TEntity?> Find(Guid id)
    {
        return await Dbset.FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task<IEnumerable<TEntity>> ListAsync(Expression<Func<TEntity, bool>>? predicate = null)
    {
        return predicate == null ? await Dbset.ToListAsync() : await Dbset.Where(predicate).ToListAsync();
    }

    public IQueryable<TEntity> Query()
    {
        return Dbset.AsQueryable();
    }

    public void Remove(TEntity entity)
    {
        Dbset.Remove(entity);
    }

    public void Update(TEntity entity)
    {
        Dbset.Update(entity);
    }
}
