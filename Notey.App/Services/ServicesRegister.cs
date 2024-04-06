using Microsoft.Extensions.DependencyInjection;
using Notey.App.Models;

namespace Notey.App.Services;

public static class ServicesRegister
{
    public static void AddServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddDbContext<DataContext>();
    }
}