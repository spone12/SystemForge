using Microsoft.Extensions.DependencyInjection;
using SystemForge.Services.FileService;
using SystemForge.ViewModels;

namespace SystemForge.Infrastructure.DI;

public static class ServiceContainer
{
    public static ServiceProvider Configure()
    {
        var services = new ServiceCollection();

        // Services
        services.AddSingleton<FileService>();

        // ViewModels
        services.AddTransient<FilesViewModel>();

        return services.BuildServiceProvider();
    }
}
