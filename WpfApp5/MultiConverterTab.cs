using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Sudoku
{
    public class MultiConverterTab : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException("Rien à convertir");
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {

            string valueWithoutSpace = ((string)value).Trim();
          

            if (!string.IsNullOrEmpty(valueWithoutSpace) && int.TryParse(valueWithoutSpace, out int result))
            {
               
                 return new object[] { result, result, result };
            }
            else
            {
                 return new object[] { 0, 0, 0};
            }
       }
    }
}
