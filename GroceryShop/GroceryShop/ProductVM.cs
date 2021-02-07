using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace GroceryShop
{
    public class ProductVM : INotifyPropertyChanged
    {

        private Product newProduct = new Product();

        public Product NewProduct
        {
            get { return newProduct; }
            set
            {
                newProduct = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NewProduct"));
            }
        }


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


        private ObservableCollection<Product> allProducts = new ObservableCollection<Product>();

        public ObservableCollection<Product> AllProducts
        {
            get { return allProducts; }
            set { allProducts = value; }
        }

        public RelayCommand AddCommand { get; set; }//פעולה, אירוע כמו לחיצה,
        private void DoAdd()
        {

            AllProducts.Add(NewProduct);// new Product() {Name=Name, Barcode=Barcode, Price=Price });
            //Name = string.Empty;
            //Barcode = string.Empty;
            //Price = 0;
            NewProduct = new Product();
        }
        private bool AddCanExecute()
        {
            return !string.IsNullOrWhiteSpace(NewProduct.Barcode) && !string.IsNullOrWhiteSpace(NewProduct.Name);
        }


        public ProductVM()
        {
            Init();
        }

        private void Init()
        {
            AddCommand = new RelayCommand(DoAdd, AddCanExecute);//איתחול הקןמנד - וקשיר בינו לבין הפונקציה שתופעל
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
