using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace ViewModel
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool boolValue)
            {
                bool inverse = parameter != null && parameter.ToString().Equals("True", StringComparison.OrdinalIgnoreCase);
                
                if (inverse)
                {
                    return boolValue ? Visibility.Collapsed : Visibility.Visible;
                } 
                else
                {
                    return boolValue ? Visibility.Visible : Visibility.Collapsed;
                }
                
            }

            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
