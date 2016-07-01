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
    class ExtraCostTypeValueToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var extraCostType = (ExtraCostType)value;
            return extraCostType.GetAttributeOfType<DisplayAttribute>().Name;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var name = (string)value;
            return Enum.GetValues(typeof(ExtraCostType)).Cast<ExtraCostType>()
                .Where(extraCostType => extraCostType.GetAttributeOfType<DisplayAttribute>().Name == name)
                .First();
        }
    }
}
