using System;
using System.Windows.Data;

namespace Metro.Core
{
    public class StringIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

            return value.ToString();
        }

        public object ConvertBack(
              object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

            int ret = 0;
            return int.TryParse((string)value, out ret) ? ret : 0;

        }

    }
}
