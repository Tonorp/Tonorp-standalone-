using System;
using System.Globalization;
using System.Windows;

namespace TonorpStandAloneWPF.ValueConverter
{
    /// <summary>
    /// A converter that takes a boolean and return a <see cref="Visibility"/>
    /// </summary>
    public class BooleanToVisibilityConverter : BaseValueConverter<BooleanToVisibilityConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null)
                return value != null && (bool)value ? Visibility.Collapsed : Visibility.Visible;
            else
                return value != null && (bool)value ? Visibility.Visible : Visibility.Collapsed;

        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
