using Microsoft.EntityFrameworkCore;
using Top.MasonTech.NetCoreBaseAPI.Infrastructure.Persistence.Entities;

namespace Top.MasonTech.NetCoreBaseAPI.Infrastructure.External.DbContexts;

/// <summary>
/// PSQL database context
/// </summary>
public sealed class PsqlDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    
    public PsqlDbContext(DbContextOptions<PsqlDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
}