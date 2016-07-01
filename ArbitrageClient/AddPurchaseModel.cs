using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbitrageClient
{
    class AddPurchaseModel
    {
        private DateTime purchaseDate;

        private string sellerName;
        private string sellerStreet;
        private string sellerCity;
        private string sellerTelephoneNumber;
        private string sellerComments;

        private decimal sellingPrice;
        private ExtraCostType extraCostType;
        private decimal fuelCost;
        private decimal shippingCost;
        private bool shippingIncluded;
        private decimal totalPrice;

        public DateTime PurchaseDate
        {
            get
            {
                return purchaseDate;
            }

            set
            {
                purchaseDate = value;
            }
        }

        public string SellerName
        {
            get
            {
                return sellerName;
            }

            set
            {
                sellerName = value;
            }
        }

        public string SellerStreet
        {
            get
            {
                return sellerStreet;
            }

            set
            {
                sellerStreet = value;
            }
        }

        public string SellerCity
        {
            get
            {
                return sellerCity;
            }

            set
            {
                sellerCity = value;
            }
        }

        public string SellerTelephoneNumber
        {
            get
            {
                return sellerTelephoneNumber;
            }

            set
            {
                sellerTelephoneNumber = value;
            }
        }

        public string SellerComments
        {
            get
            {
                return sellerComments;
            }

            set
            {
                sellerComments = value;
            }
        }

        public decimal SellingPrice
        {
            get
            {
                return sellingPrice;
            }

            set
            {
                sellingPrice = value;
            }
        }

        public ExtraCostType ExtraCostType
        {
            get
            {
                return extraCostType;
            }

            set
            {
                extraCostType = value;
            }
        }

        public decimal FuelCost
        {
            get
            {
                return fuelCost;
            }

            set
            {
                fuelCost = value;
            }
        }

        public decimal ShippingCost
        {
            get
            {
                return shippingCost;
            }

            set
            {
                shippingCost = value;
            }
        }

        public bool ShippingIncluded
        {
            get
            {
                return shippingIncluded;
            }

            set
            {
                shippingIncluded = value;
            }
        }

        public decimal TotalPrice
        {
            get
            {
                return totalPrice;
            }

            set
            {
                totalPrice = value;
            }
        }
    }
}
