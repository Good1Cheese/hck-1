using HackatonProject.ViewModels;
using System.Windows;

namespace HackatonProject
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            NavigationStore navigationStore = new();
            NavigationBarViewModel navigationBarViewModel = new(navigationStore);

            MainWindow mainWindow = new()
            {
                DataContext = new MainViewModel(navigationBarViewModel, navigationStore)
            };

            mainWindow.Show();
        }
    }
}