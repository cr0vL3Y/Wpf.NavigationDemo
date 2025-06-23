using Sergio.ViewModels;
using Sergio.Views;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace Sergio
{
    public class NavigationService
    {
        private readonly Frame? mainFrame;

        public NavigationService(Frame mainFrame)
        {
            this.mainFrame = mainFrame;
            this.mainFrame.LoadCompleted += MainFrame_LoadCompleted;
        }

        /// <summary>
        /// 参数注入
        /// 导航完成时，如果有额外数据，则将其注入到当前页面的 ViewModel 中。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrame_LoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            if (e.ExtraData is not Dictionary<string, object?> extraData)
            {
                return;
            }

            if ((mainFrame?.Content as FrameworkElement)?.DataContext is not ViewModelBase vm)
            {
                return;
            }

            foreach (var item in extraData)
            {
                vm.GetType().GetProperty(item.Key)?.SetValue(vm, item.Value);
            }
        }

        /// <summary>
        /// Navigate to a specific ViewModel.
        /// 视图类型与 ViewModel 类型的映射表
        /// </summary>
        private readonly Dictionary<Type, Type> mapping = new Dictionary<Type, Type>()
        {
            [typeof(LoginViewModel)] = typeof(Login),
            [typeof(HomeViewModel)] = typeof(Home)
        };

        /// <summary>
        /// 视图类型查找
        /// 根据 ViewModel 名字，自动查找对应的 View 类型
        /// 使用反射，降低维护成本，只需命名规范即可自动配对。
        /// </summary>
        /// <typeparam name="VM"></typeparam>
        /// <returns></returns>
        private Type? FindView<VM>()
        {
            return Assembly.GetAssembly(typeof(VM))?.GetTypes().FirstOrDefault(t => t.Name == typeof(VM).Name.Replace("ViewModel", ""));
        }

        #region 导航方法

        public void Navigate<VM>() where VM : ViewModelBase
        {
            Navigate<VM>(null);
        }

        public void Navigate<VM>(Dictionary<string, object?>? extraData) where VM : ViewModelBase
        {
            var viewType = FindView<VM>();
            if (viewType is null)
            {
                return;
            }

            var page = App.Current.Services.GetService(viewType) as Page;
            mainFrame?.Navigate(page, extraData);
        }

        #endregion
    }
}
