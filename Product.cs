using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{//namespace begin
    
    //enum with product categories
    public enum ProductCategory
    {//ProductCategory begin
        Clothing,
        Electronics,
        Home,
        Beauty,
        Groceries
    }//ProductCategory end

    public class Product
    {//Product class begin
        //Attributes - private variables within the Product Class
        private string name; //stores name of product
        private double price; //stores price of product
        private ProductCategory category; //store the category of a product from enum

        //Public variables accessed outside of class
        public string Name { get { return name; } }
        public double Price { get { return price; } }
        public ProductCategory Category { get { return category; } }
        //constructor method with parameters
        public Product(string name, double price, ProductCategory category)
        {//constructor begin
            this.name = name;
            this.price = price;
            this.category = category;
        }//constructor end

        //method i=to display the infor 
        public virtual void GetInfo()
        {//GetInfor method begin
            Console.WriteLine($"Name: {name}, Price: {price}, Category: {category}");
        }//GetInfor method end
    }//Product Class end
}//namespace end
