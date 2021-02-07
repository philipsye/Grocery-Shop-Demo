using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GroceryShop
{
    public class Product : INotifyPropertyChanged
    {
        private string barcode;

        public string Barcode
        {
            get { return barcode; }
            set
            {
                barcode = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Barcode"));
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                price = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
