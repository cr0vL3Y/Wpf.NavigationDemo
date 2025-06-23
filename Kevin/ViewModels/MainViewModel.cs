using CommunityToolkit.Mvvm.ComponentModel;

namespace Kevin.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<PageViewModelBase> _pageViewModels;

        public MainViewModel(Page1ViewModel page1ViewModel, Page2ViewModel page2ViewModel, Page3ViewModel page3ViewModel)
        {
            PageViewModels = new List<PageViewModelBase>() { page1ViewModel, page2ViewModel, page3ViewModel };
        }

    }
}
