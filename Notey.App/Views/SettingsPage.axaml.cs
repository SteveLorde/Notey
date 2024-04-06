using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.DependencyInjection;
using Notey.App.ViewModels;

namespace Notey.App.Views;

public partial class SettingsPage : Window
{
    public SettingsPage(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        this.DataContext = serviceProvider.GetRequiredService<SettingsPageViewModel>();
    }
}