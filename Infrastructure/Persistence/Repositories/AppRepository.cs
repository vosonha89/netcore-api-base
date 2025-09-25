using DevNetCore.SimpleRepository.Implementation;
using Microsoft.EntityFrameworkCore;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Interface;

namespace Top.MasonTech.NetCoreBaseAPI.Infrastructure.Persistence.Repositories;

/// <summary>
/// Application repository
/// </summary>
public class AppRepository : SimpleRepository, IAppRepository
{
    protected AppRepository(DbContext dbContext) : base(dbContext)
    {
    }
}