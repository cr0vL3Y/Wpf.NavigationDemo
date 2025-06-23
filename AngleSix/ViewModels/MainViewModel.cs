using AngleSix.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AngleSix.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ApplicationPage currentPage;

        public MainViewModel()
        {
            CurrentPage = ApplicationPage.Login;
        }
    }
}
