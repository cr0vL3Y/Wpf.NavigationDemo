using AngleSix.Models;
using AngleSix.Views;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace AngleSix.Converters
{
    public class ApplicationPageViewConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.Home:
                    return new Home();
                case ApplicationPage.Login:
                    return new LoginView();
                case ApplicationPage.Empty:
                    return new TextBlock { Text = "404 Not Found" };
                default:
                    throw new ArgumentException("Invalid value passed to ApplicationPageViewConverter");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
