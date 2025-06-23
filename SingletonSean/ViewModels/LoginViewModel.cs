using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SingletonSean.ViewModels
{
    public partial class LoginViewModel : ViewModelBase
    {
        private readonly NavigationService navigator;

        private readonly UserService userService;

        [ObservableProperty]
        private string? _userName;

        public LoginViewModel(NavigationService navigator, UserService userService)
        {
            this.navigator = navigator;
            this.userService = userService;
        }

        [RelayCommand]
        private void Login()
        {
            userService.UserName = UserName;
            navigator.NavigateTo<HomeViewModel>();
        }
    }
}
