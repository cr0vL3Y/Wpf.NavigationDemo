using CommunityToolkit.Mvvm.ComponentModel;

namespace Sergio.ViewModels
{
    public partial class HomeViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string? _userName;
    }
}
