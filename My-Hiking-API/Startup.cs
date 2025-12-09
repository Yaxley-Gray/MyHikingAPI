using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using MyHikingAPI.Services;

[assembly: FunctionsStartup(typeof(MyNamespace.Startup))]

namespace MyNamespace;

public class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
         
        builder.Services.AddHttpClient();

        builder.Services.AddSingleton<IMountainService, MountainService>((s) => {
            return new MyService();
        });

        builder.Services.AddSingleton<ILoggerProvider, MyLoggerProvider>();
    }
}
