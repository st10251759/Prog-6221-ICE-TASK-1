using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{//namespace begin
    // Derived class for electronics products
    public class ElectronicsProduct : Product
    { //ElectronicsProduct begin
        //private variables used in class
        private string brand;
        private string model;

        //public variables accessed outside of class
        public string Brand { get { return brand; } }
        public string Model { get { return model; } }

        //constructor method that inherits from parent class - Product
        public ElectronicsProduct(string name, double price, ProductCategory category, string brand, string model)
            : base(name, price, category)
        {//constructor begin
            //the two unique variables
            this.brand = brand;
            this.model = model;
        }//constructor end

        //method that overides the parent class method - Products and displays the size and colour from this class
        public override void GetInfo()
        {//GetInfo() begin
            base.GetInfo();
            Console.WriteLine($"Brand: {brand}, Model: {model}");
        }//GetInfo() end
    }// ElectronicsProduct end
}//namespace end
