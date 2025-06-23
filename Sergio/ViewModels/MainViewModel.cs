using CommunityToolkit.Mvvm.Input;

namespace Sergio.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        private NavigationService navigationService;

        public MainViewModel(NavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        [RelayCommand]
        private void Loaded() => navigationService.Navigate<LoginViewModel>();
    }
}
