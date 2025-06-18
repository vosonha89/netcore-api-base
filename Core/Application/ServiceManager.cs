using Top.MasonTech.NetCoreBaseAPI.Core.Application.Interfaces;
using Top.MasonTech.NetCoreBaseAPI.Core.Application.Services;

namespace Top.MasonTech.NetCoreBaseAPI.Core.Application;

/// <summary>
/// Provides a centralized mechanism to register various application services into the service container.
/// </summary>
public static class ServiceManager
{
    /// <summary>
    /// Registers application services into the service container
    /// </summary>
    /// <param name="builder">The application builder</param>
    public static void RegisterServices(ref WebApplicationBuilder builder)
    {
        #region Application Services

        builder.Services.AddControllers(); // Add services to the container.
        builder.Services
            .AddEndpointsApiExplorer(); // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddSwaggerGen();

        #endregion

        #region Singleton Services

        builder.Services.AddSingleton<ILoggingService, LoggingService>();

        #endregion

        #region Scoped Services

        #endregion

        #region Transient Services

        #endregion
    }
}