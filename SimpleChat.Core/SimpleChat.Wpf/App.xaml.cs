using System.Windows;
using SimpleChat.Client.Wpf.ViewModels;

namespace SimpleChat.Client.Wpf
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var viewModel = new MainWindowViewModel();
            var window = new MainWindow();

            window.DataContext = viewModel;
            window.Show();
        }
    }
}
