using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Sergio.ViewModels
{
    public partial class LoginViewModel : ViewModelBase
    {
        private readonly NavigationService navigationService;

        [ObservableProperty]
        private string _userName = "Sergio";

        public LoginViewModel(NavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        [RelayCommand]
        private void Login()
        {
            navigationService.Navigate<HomeViewModel>(new Dictionary<string, object?>
            {
                [nameof(HomeViewModel.UserName)] = UserName
            });
        }
    }
}
