using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{//namespace begin
    // Derived class for clothing products
    public class ClothingProduct : Product
    {//ClothingProduct begin
        //private variables used in class
        private string size;
        private string color;

        //public variables accessed outside of class
        public string Size { get { return size; } }
        public string Color { get { return color; } }

        //constructor method that inherits from parent class - Product
        public ClothingProduct(string name, double price, ProductCategory category, string size, string color)
            : base(name, price, category)
        {//constructor begin
            this.size = size;
            this.color = color;
        }//constructor end

        //method that overides the parent class method - Products and displays the size and colour from this class
        public override void GetInfo()
        {//GetInfo() begin
            base.GetInfo();
            Console.WriteLine($"Size: {size}, Color: {color}");
        }//GetInfo() end
    }//ClothingProduct
}//namespace end
