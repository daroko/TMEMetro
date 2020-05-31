using System;
using System.Windows.Data;

namespace Metro.Core
{
    public class EnumToStringConverter: IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string EnumString;
            try
            {
                EnumString = Enum.GetName((value.GetType()), value);
                return EnumString;
            }
            catch
            {
                return string.Empty;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
