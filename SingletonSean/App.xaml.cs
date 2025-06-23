using Microsoft.Extensions.DependencyInjection;
using SingletonSean.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;

namespace SingletonSean
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

            container.AddSingleton<MainWindow>();
            container.AddSingleton<MainViewModel>();

            container.AddSingleton<NavigationService>();
            container.AddSingleton<UserService>();

            container.AddTransient<LoginViewModel>();   // AddTransient 每次请求创建新实例（短生命周期）
            container.AddTransient<HomeViewModel>();

            Services = container.BuildServiceProvider();

        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //var mainWindow = Services.GetRequiredService<MainWindow>();
            //mainWindow.Show();

            MainWindow = Services.GetRequiredService<MainWindow>();
            MainWindow.Show();
        }
    }

}
