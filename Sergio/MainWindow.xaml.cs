using Sergio.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace Sergio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel viewModel, NavigationService navigationService, Frame rootFrame)
        {
            InitializeComponent();

            DataContext = viewModel;

            this.AddChild(rootFrame);
        }
    }
}