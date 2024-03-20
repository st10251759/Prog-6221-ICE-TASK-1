using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{//namespace begin
    // Class that represents a shopping cart
    public class ShoppingCart
    {//ShoopingCart begin
        //private variables used in class
        private Product[] products; //declared array to store products
        private int itemCount;

        //public variables accessed outside of class
        public Product[] Products { get { return products; } }
        public int ItemCount { get { return itemCount; } }

        //constuctor method with parameters
        public ShoppingCart(int capacity)
        {//constructor begin
            products = new Product[capacity];
            itemCount = 0;
        }//constructor end

        //method to add new products with a pramenter for product array
        public void AddProduct(Product product)
        {//AddProduct Begin
            products[itemCount++] = product; //add a new item to the product array
        }//AddProduct End

        //method to remove products with a parameter product array
        public void RemoveProduct(Product product)
        {//RemoveProduct begin
            //run loop to access all elements of the array
            for (int i = 0; i < itemCount; i++)
            {//for i loop  begin
                //if statement to search if one of elemenets stored in the array matches the  product searched for
                if (products[i] == product)
                {//if statement begins
                    // Shift remaining elements to the left
                    for (int j = i; j < itemCount - 1; j++)
                    {//for j loop begin
                        products[j] = products[j + 1];
                    }//for j loop end
                    itemCount--; //reducce size of array
                    break;
                }//if statement end
            }//for i loop end
        }//RemoveProduct end
        
        //method to display all products added to class
        public void DisplayProducts()
        {//DisplayProducts begin
            
            Console.WriteLine("Products in the shopping cart:");

            //run for loop to access each element of array
            for (int i = 0; i < itemCount; i++)
            {//for loop begin
                Console.WriteLine($"Product {i + 1}:");
                products[i].GetInfo();
                Console.WriteLine("\n");
            }//for loop end
        }//DisplayProducts end
    }//ShoppingCart end

}//namespace end
