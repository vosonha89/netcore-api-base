using Top.MasonTech.NetCoreBaseAPI.Core.Application;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Configuration;

var builder = WebApplication.CreateBuilder(args);
ServiceManager.RegisterServices(ref builder);
AppEnvironment.ApplyConfig(ref builder);

var app = builder.Build();
ApplicationManager.InitApplication(ref app);
await app.RunAsync();