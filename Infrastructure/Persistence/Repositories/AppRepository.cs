using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Constant;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Interface;
using Top.MasonTech.NetCoreBaseAPI.Infrastructure.External.DbContexts;

namespace Top.MasonTech.NetCoreBaseAPI.Infrastructure.Persistence.Repositories;

public class AppRepository : IAppRepository
{
    private readonly IDbContextFactory<PsqlDbContext> _contextFactory;

    public AppRepository(IDbContextFactory<PsqlDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public async Task<List<T>> Search<T, TId>(Expression<Func<T, bool>> predicate,
        int pageSize = ConstantValue.PageSize,
        int pageIndex = ConstantValue.PageIndex) where T : BaseEntity<TId>, new()
    {
        using (var context = await _contextFactory.CreateDbContextAsync())
        {
           return await context.Set<T>()
                .Where(predicate)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync<T>();
        }
    }

    // public Task<T?> Get<T>(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = new())
    //     where T : DbEntity, new()
    // {
    //     using var context = _contextFactory.CreateDbContext();
    //     return context.Set<T>().FirstOrDefaultAsync(predicate, cancellationToken);
    // }
    //
    // public ValueTask<EntityEntry<T>> Insert<T>(T entity, CancellationToken cancellationToken = new())
    //     where T : DbEntity, new()
    // {
    //     using var context = _contextFactory.CreateDbContext();
    //     entity.Id = Guid.NewGuid();
    //     if (string.IsNullOrEmpty(entity.CreatedBy))
    //     {
    //         entity.CreatedBy = Guid.Empty.ToString();
    //     }
    //
    //     entity.CreatedDate = DateTime.UtcNow;
    //     return context.Set<T>().AddAsync(entity, cancellationToken);
    // }
    //
    // public EntityEntry<T> Update<T>(T entity, CancellationToken cancellationToken = new())
    //     where T : DbEntity, new()
    // {
    //     using var context = _contextFactory.CreateDbContext();
    //     if (string.IsNullOrEmpty(entity.LastUpdateBy))
    //     {
    //         entity.LastUpdateBy = Guid.Empty.ToString();
    //     }
    //
    //     entity.LastUpdateDate = DateTime.UtcNow;
    //     return context.Set<T>().Update(entity);
    // }
    //
    // public EntityEntry<T> Delete<T>(T entity, CancellationToken cancellationToken = new CancellationToken())
    //     where T : DbEntity, new()
    // {
    //     using var context = _contextFactory.CreateDbContext();
    //     return context.Set<T>().Remove(entity);
    // }
    //
    // public async Task<int> SaveChanges(CancellationToken cancellationToken = new CancellationToken())
    // {
    //     await using var context = await _contextFactory.CreateDbContextAsync(cancellationToken);
    //     return await context.SaveChangesAsync(cancellationToken);
    // }
}
