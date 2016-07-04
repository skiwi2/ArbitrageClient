using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ArbitrageClient
{
    public static class BindingExpressionHelper
    {
        public static object GetResolvedSourceObject(this BindingExpression bindingExpression)
        {
            var resolvedSource = bindingExpression.ResolvedSource;
            return resolvedSource.GetType().GetProperty(bindingExpression.ResolvedSourcePropertyName).GetValue(resolvedSource, null);
        }
    }
}
