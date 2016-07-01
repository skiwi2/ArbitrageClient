using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbitrageClient
{
    class AddPurchaseViewModel : INotifyPropertyChanged
    {
        private AddPurchaseModel addPurchaseModel;

        public AddPurchaseViewModel()
        {
            AddPurchaseModel = new AddPurchaseModel { };
        }

        public AddPurchaseModel AddPurchaseModel
        {
            get
            {
                return addPurchaseModel;
            }

            set
            {
                addPurchaseModel = value;
            }
        }

        public DateTime PurchaseDate
        {
            get
            {
                return AddPurchaseModel.PurchaseDate;
            }

            set
            {
                if (AddPurchaseModel.PurchaseDate != value)
                {
                    AddPurchaseModel.PurchaseDate = value;
                    RaisePropertyChanged("PurchaseDate");
                }
            }
        }

        public string SellerName
        {
            get
            {
                return AddPurchaseModel.SellerName;
            }

            set
            {
                if (AddPurchaseModel.SellerName != value)
                {
                    AddPurchaseModel.SellerName = value;
                    RaisePropertyChanged("SellerName");
                }
            }
        }

        public string SellerStreet
        {
            get
            {
                return AddPurchaseModel.SellerStreet;
            }

            set
            {
                if (AddPurchaseModel.SellerStreet != value)
                {
                    AddPurchaseModel.SellerStreet = value;
                    RaisePropertyChanged("SellerStreet");
                }
            }
        }

        public string SellerCity
        {
            get
            {
                return AddPurchaseModel.SellerCity;
            }

            set
            {
                if (AddPurchaseModel.SellerCity != value)
                {
                    AddPurchaseModel.SellerCity = value;
                    RaisePropertyChanged("SellerCity");
                }
            }
        }

        public string SellerTelephoneNumber
        {
            get
            {
                return AddPurchaseModel.SellerTelephoneNumber;
            }

            set
            {
                if (AddPurchaseModel.SellerTelephoneNumber != value)
                {
                    AddPurchaseModel.SellerTelephoneNumber = value;
                    RaisePropertyChanged("SellerTelephoneNumber");
                }
            }
        }

        public string SellerComments
        {
            get
            {
                return AddPurchaseModel.SellerComments;
            }

            set
            {
                if (AddPurchaseModel.SellerComments != value)
                {
                    AddPurchaseModel.SellerComments = value;
                    RaisePropertyChanged("SellerComments");
                }
            }
        }

        public decimal SellingPrice
        {
            get
            {
                return AddPurchaseModel.SellingPrice;
            }

            set
            {
                if (AddPurchaseModel.SellingPrice != value)
                {
                    AddPurchaseModel.SellingPrice = value;
                    RaisePropertyChanged("SellingPrice");
                    RaisePropertyChanged("TotalPrice");
                }
            }
        }

        public ExtraCostType ExtraCostType
        {
            get
            {
                return AddPurchaseModel.ExtraCostType;
            }

            set
            {
                if (AddPurchaseModel.ExtraCostType != value)
                {
                    AddPurchaseModel.ExtraCostType = value;
                    RaisePropertyChanged("ExtraCostType");
                    RaisePropertyChanged("ShowFuelCost");
                    RaisePropertyChanged("ShowShippingCost");
                    RaisePropertyChanged("ShowShippingIncluded");
                    RaisePropertyChanged("TotalPrice");
                }
            }
        }

        public bool ShowFuelCost
        {
            get
            {
                return ExtraCostType == ExtraCostType.FuelCost;
            }
        }

        public bool ShowShippingCost
        {
            get
            {
                return ExtraCostType == ExtraCostType.ShippingCost;
            }
        }

        public bool ShowShippingIncluded
        {
            get
            {
                return ExtraCostType == ExtraCostType.ShippingIncluded;
            }
        }

        public decimal FuelCost
        {
            get
            {
                return AddPurchaseModel.FuelCost;
            }

            set
            {
                if (AddPurchaseModel.FuelCost != value)
                {
                    AddPurchaseModel.FuelCost = value;
                    RaisePropertyChanged("FuelCost");
                    RaisePropertyChanged("TotalPrice");
                }
            }
        }

        public decimal ShippingCost
        {
            get
            {
                return AddPurchaseModel.ShippingCost;
            }

            set
            {
                if (AddPurchaseModel.ShippingCost != value)
                {
                    AddPurchaseModel.ShippingCost = value;
                    RaisePropertyChanged("ShippingCost");
                    RaisePropertyChanged("TotalPrice");
                }
            }
        }

        public bool ShippingIncluded
        {
            get
            {
                return AddPurchaseModel.ShippingIncluded;
            }

            set
            {
                if (AddPurchaseModel.ShippingIncluded != value)
                {
                    AddPurchaseModel.ShippingIncluded = value;
                    RaisePropertyChanged("ShippingIncluded");
                }
            }
        }

        public decimal TotalPrice
        {
            get
            {
                decimal Total = SellingPrice;
                switch (ExtraCostType)
                {
                    case ExtraCostType.FuelCost:
                        Total += FuelCost;
                        break;
                    case ExtraCostType.ShippingCost:
                        Total += ShippingCost;
                        break;
                    default:
                        break;
                }
                return Total;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
