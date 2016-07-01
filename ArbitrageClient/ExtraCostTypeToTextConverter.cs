using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ArbitrageClient
{
    class ExtraCostTypeToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var extraCostTypes = (IEnumerable<ExtraCostType>)value;
            return extraCostTypes.Select(extraCostType => extraCostType.GetAttributeOfType<DisplayAttribute>().Name);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
