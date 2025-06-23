using AngleSix.ViewModels;
using System.Windows.Controls;

#region Description

// BasePageBinding is a generic UserControl that binds to a ViewModel of type VM.
// It is used as a base class for all pages in the application.
// The DataContext is set to a new instance of the ViewModel.

// BasePageBinding<VM> 是一个通用的 WPF 基类控件
// 用于自动将视图绑定到对应的 ViewModel
// 简化 MVVM 架构中“View 绑定 ViewModel”的操作

#endregion


namespace AngleSix.Views
{
    public abstract class BasePage<VM> : UserControl where VM : ViewModelBase, new()
    {
        public BasePage()
        {
            DataContext = new VM();
        }
    }
}
