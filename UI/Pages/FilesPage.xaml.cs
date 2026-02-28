using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml.Controls;
using SystemForge.ViewModels;

namespace SystemForge.UI.Pages;

public sealed partial class FilesPage : Page
{
    public FilesViewModel ViewModel { get; }

    public FilesPage()
    {
        this.InitializeComponent();
        ViewModel = App.Services.GetRequiredService<FilesViewModel>();
        DataContext = ViewModel;
    }
}
