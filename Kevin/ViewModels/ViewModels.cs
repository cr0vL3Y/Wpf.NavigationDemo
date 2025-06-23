using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kevin.ViewModels
{
    public abstract partial class PageViewModelBase : ObservableObject
    {
        [ObservableProperty]
        private string? _header;
    }

    public partial class Page1ViewModel : PageViewModelBase
    {
        public Page1ViewModel() => Header = "Page1";

        [ObservableProperty]
        private string _pageMessage = "Hello,Page1";
    }

    public partial class Page2ViewModel : PageViewModelBase
    {
        public Page2ViewModel() => Header = "Page2";

        [ObservableProperty]
        private string _pageMessage = "Hello,Page2";
    }

    public partial class Page3ViewModel : PageViewModelBase
    {
        public Page3ViewModel() => Header = "Page3";

        [ObservableProperty]
        private string _pageMessage = "Hello,Page3";
    }
}
