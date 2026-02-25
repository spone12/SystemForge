using System;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using WinPilot.UI.Pages;

namespace SystemForge;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();
        ContentFrame.Navigate(typeof(FilesPage));
    }

    private void NavView_SelectionChanged(
        NavigationView sender,
        NavigationViewSelectionChangedEventArgs args)
    {
        if (args.SelectedItem is NavigationViewItem item)
        {
            Type pageType = item.Tag?.ToString() switch
            {
                "files" => typeof(FilesPage),
                "system" => typeof(SystemPage),
                "lua" => typeof(LuaPage),
                _ => null
            };

            if (pageType != null)
            {
                ContentFrame.Navigate(pageType);
            }
        }
    }
}
