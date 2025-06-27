using DevNetCore.SimpleRepository.Implementation;
using Microsoft.EntityFrameworkCore;

namespace Top.MasonTech.NetCoreBaseAPI.Infrastructure.Persistence.Repositories;

/// <summary>
/// Application repository
/// </summary>
public class AppRepository : SimpleRepository
{
    protected AppRepository(DbContext dbContext) : base(dbContext)
    {
    }
}