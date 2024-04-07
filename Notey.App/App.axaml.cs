using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.DependencyInjection;
using Notey.App.Models.Repositories;
using Notey.App.Services;
using Notey.App.ViewModels;
using Notey.App.Views;

namespace Notey.App;

public partial class App : Application
{

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);

    }

    public override void OnFrameworkInitializationCompleted()
    {
        IServiceCollection _serviceCollection = new ServiceCollection();
        _serviceCollection.AddServices();
        ServiceProvider serviceProvider = _serviceCollection.BuildServiceProvider();

        var mainViewModel = serviceProvider.GetRequiredService<MainWindowViewModel>();
        
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow(serviceProvider)
            {
                DataContext = mainViewModel
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}