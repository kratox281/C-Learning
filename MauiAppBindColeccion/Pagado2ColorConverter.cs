using System.Globalization;

namespace MauiAppBindColeccion
{
    internal class P2CC : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color verde = Colors.Green;
            Color rojo = Colors.Red;
            return (bool)value?verde:rojo;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
