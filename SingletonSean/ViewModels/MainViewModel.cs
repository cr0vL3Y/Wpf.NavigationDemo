using CommunityToolkit.Mvvm.ComponentModel;

namespace SingletonSean.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        private readonly NavigationService navigator;

        [ObservableProperty]
        private ViewModelBase? currentViewModel;

        public MainViewModel(NavigationService navigationService)
        {
            this.navigator = navigationService;

            navigator.CurrentViewModelChanged += () =>
            {
                CurrentViewModel = navigationService.CurrentViewModel;
            };

            // 默认导航到登录页面
            navigator.NavigateTo<LoginViewModel>();
        }
    }
}
