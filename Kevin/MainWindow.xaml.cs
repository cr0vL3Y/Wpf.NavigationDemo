using Kevin.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kevin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();

            this.DataContext = viewModel;

            // Set the DataContext to the MainViewModel
            //Page1.DataContext = App.Current.Services.GetRequiredService<Page1ViewModel>();
            //Page2.DataContext = App.Current.Services.GetRequiredService<Page2ViewModel>();
            //Page3.DataContext = App.Current.Services.GetRequiredService<Page3ViewModel>();
        }
    }
}