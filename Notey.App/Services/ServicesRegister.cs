using Microsoft.Extensions.DependencyInjection;
using Notey.App.Models;
using Notey.App.Models.Repositories;
using Notey.App.ViewModels;

namespace Notey.App.Services;

public static class ServicesRegister
{
    public static void AddServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddDbContext<DataContext>();
        serviceCollection.AddScoped<IPagesRepo, PagesRepo>();
        serviceCollection.AddScoped<MainWindowViewModel>();
        serviceCollection.AddScoped<AppState>();
        serviceCollection.AddScoped<SettingsPageViewModel>();
        
    }
}