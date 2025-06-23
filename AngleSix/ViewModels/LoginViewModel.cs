using AngleSix.Models;
using AngleSix.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AngleSix.ViewModels
{
    public partial class LoginViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string? _username = "alarmDD";

        [ObservableProperty]
        private string? _password;

        public LoginViewModel()
        {

        }

        [RelayCommand]
        private void Login()
        {
            //if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            //{
            //    return;
            //}
            //else
            {
                NavigationService.Instance.Navigate(ApplicationPage.Home);
            }
        }
    }
}
