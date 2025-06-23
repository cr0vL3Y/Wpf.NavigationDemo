using AngleSix.Models;
using AngleSix.ViewModels;

namespace AngleSix.Services
{
    public class NavigationService
    {
        public static NavigationService Instance { get; } = new NavigationService();

        private MainViewModel mainViewModel;

        public void Navigate(ApplicationPage page)
        {
            if (mainViewModel == null)
            {
                mainViewModel = (MainViewModel)App.Current.MainWindow.DataContext;
            }

            mainViewModel.CurrentPage = page;
        }
    }
}
