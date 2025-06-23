using Microsoft.Extensions.DependencyInjection;
using Sergio.ViewModels;
using Sergio.Views;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Sergio
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static new App Current => (App)Application.Current;
        public IServiceProvider Services { get; }
        public App()
        {
            var container = new ServiceCollection();

            container.AddSingleton(_ => new Frame { NavigationUIVisibility = NavigationUIVisibility.Hidden });

            container.AddSingleton<MainWindow>();
            container.AddSingleton<MainViewModel>();

            container.AddTransient<Login>();
            container.AddTransient<Home>();

            container.AddTransient<LoginViewModel>();
            container.AddTransient<HomeViewModel>();

            container.AddSingleton<NavigationService>();

            Services = container.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow = Services.GetRequiredService<MainWindow>();
            MainWindow.Show();
        }
    }

}
