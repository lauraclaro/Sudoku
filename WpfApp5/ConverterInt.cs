using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp5
{
    public class ConverterInt : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException("Rien à convertir");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is string && !String.IsNullOrEmpty(value.ToString()))
            {
                return value;
            }
            else
            {
                return "vide";
            }
        }
    }
}
