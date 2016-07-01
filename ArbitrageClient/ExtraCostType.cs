using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbitrageClient
{
    enum ExtraCostType
    {
        [Display(Name = "Fuel Cost")]
        FuelCost,
        [Display(Name = "Shipping Cost")]
        ShippingCost,
        [Display(Name = "Shipping Included")]
        ShippingIncluded
    }
}
