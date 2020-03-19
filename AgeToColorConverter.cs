using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfAppTest
{
    public class AgeToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) =>
            (value is int age)
                ? age < 18
                    ? Color.FromRgb(255,0,0).ToString()
                    : Color.FromRgb(0, 255, 0).ToString()
                : Color.FromRgb(0,0,0).ToString();
        //if need convertBack maybe add age to color like color.FromRgb(0,255,(byte)age))
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
            (value is Color colorPerson)
                ? colorPerson != Color.FromArgb(0,0,0,0)
                    ? (int?)colorPerson.B
                    : null
                : null;
    }
}