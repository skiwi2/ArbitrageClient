using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace ArbitrageClient
{
    public class TextBoxBindingToCurrencyBehavior : Behavior<TextBox>
    {
        protected override void OnAttached()
        {
            base.OnAttached();

            if (AssociatedObject != null)
            {
                AssociatedObject.TextChanged += AssociatedObject_TextChanged;
                AssociatedObject.LostFocus += AssociatedObject_LostFocus;

                decimal initialValue = (decimal)AssociatedObject.GetBindingExpression(TextBox.TextProperty).GetResolvedSourceObject();
                AssociatedObject.Text = string.Format("{0:F}", initialValue);
            }
        }

        protected override void OnDetaching()
        {
            if (AssociatedObject != null)
            {
                AssociatedObject.LostFocus -= AssociatedObject_LostFocus;
                AssociatedObject.TextChanged -= AssociatedObject_TextChanged;
            }

            base.OnDetaching();
        }

        private void AssociatedObject_TextChanged(object sender, TextChangedEventArgs e)
        {
            //replace '.' and ',' with the decimal separator of current culture
            var caretIndex = AssociatedObject.CaretIndex;
            var text = AssociatedObject.Text
                .Replace(".", CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator)
                .Replace(",", CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);

            //remove any characters beyond the number of numbers behind the decimal separator of current culture
            if (text.Contains(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                string[] parts = text.Split(new string[] { CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator }, StringSplitOptions.None);
                if (parts[1].Length > CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalDigits)
                {
                    var extraNumbers = CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalDigits - parts[1].Length;
                    parts[1] = parts[1].Substring(0, CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalDigits);

                    text = string.Join(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator, parts);
                    caretIndex -= extraNumbers;
                }
            }

            AssociatedObject.Text = text;
            AssociatedObject.CaretIndex = caretIndex;
        }

        private void AssociatedObject_LostFocus(object sender, RoutedEventArgs e)
        {
            decimal output;
            if (decimal.TryParse(AssociatedObject.Text, out output))
            {
                AssociatedObject.Text = string.Format("{0:F}", output);
            }
        }
    }
}
