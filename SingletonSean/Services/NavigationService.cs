using Microsoft.Extensions.DependencyInjection;
using SingletonSean.ViewModels;

namespace SingletonSean.ViewModels
{
    public class NavigationService
    {
        private ViewModelBase? currentViewModel;

        public ViewModelBase? CurrentViewModel
        {
            get { return currentViewModel; }
            set
            {
                currentViewModel = value;
                CurrentViewModelChanged?.Invoke();
            }
        }

        public event Action? CurrentViewModelChanged;

        public void NavigateTo<T>() where T : ViewModelBase 
            => CurrentViewModel = App.Current.Services.GetService<T>();
    }
}
