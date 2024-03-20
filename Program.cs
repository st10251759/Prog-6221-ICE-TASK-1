namespace ShoppingCartApp
{//namespace begin
    internal class Program
    {//Program Class Begin
        static void Main(string[] args)
        {//Main Class Begin
            // Instantiating products and a shopping cart
            ShoppingCart cart = new ShoppingCart(5);

            while (true)
            {//while begin
                //Display options
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Display Cart items");
                Console.WriteLine("2. Add Product");
                Console.WriteLine("3. Remove Product");
                Console.WriteLine("4. Exit");


                //variable to hold users choice
                string choice = ReadLineWithRetry();

                //switch to run through all options
                switch (choice)
                {//switch begin
                    case "1":
                        cart.DisplayProducts();
                        break;
                    case "2":
                        AddProductToCart(cart);
                        break;
                    case "3":
                        RemoveProductFromCart(cart);
                        break;
                    case "4":
                    case "exit":
                        Console.WriteLine("Exiting program...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }//sitch end
            }//while end
        }//Main Class End

        //method to prompt user to Add product details for entering a new product
        static void AddProductToCart(ShoppingCart cart)
        {//AddProductToCart begin
            //prompts
            Console.WriteLine("Enter product name:");
            string name = ReadLineWithRetry();

            Console.WriteLine("Enter product price:");
            double price = Convert.ToDouble(ReadLineWithRetry());

            Console.WriteLine("Enter product category (Clothing, Electronics, Home, Beauty, Groceries):");
            ProductCategory category = (ProductCategory)Enum.Parse(typeof(ProductCategory), Console.ReadLine());

            if (category == ProductCategory.Clothing)
            {//if begin
                //prompts for clothing
                Console.WriteLine("Enter clothing size:");
                string size = ReadLineWithRetry();

                Console.WriteLine("Enter clothing color:");
                string color = ReadLineWithRetry();
                //instantiate object
                ClothingProduct clothingProduct = new ClothingProduct(name, price, category, size, color);
                cart.AddProduct(clothingProduct);
            }//if end
            else if (category == ProductCategory.Electronics)
            {//if else begin
                //prompts for electronics
                Console.WriteLine("Enter electronics brand:");
                string brand = ReadLineWithRetry();

                Console.WriteLine("Enter electronics model:");
                string model = ReadLineWithRetry();

                //object instation
                ElectronicsProduct electronicsProduct = new ElectronicsProduct(name, price, category, brand, model);
                cart.AddProduct(electronicsProduct);
            }//if else end
            else
            {//else end
                //normal prompts
                Product product = new Product(name, price, category);
                cart.AddProduct(product);
            }//else end

            Console.WriteLine("Product added to cart.");
        }//AddProgramToCart end
        
        //method to remove products from the cart
        static void RemoveProductFromCart(ShoppingCart cart)
        {//Remove product method begin
            Console.WriteLine("Enter the name of the product to remove:");
            string name = ReadLineWithRetry();
            //foreach to get access to each element in array
            foreach (Product product in cart.Products)
            {//foreach begin
                //if statement to search if element exsists 
                if (product != null && product.Name.Equals(name))
                {//if begin
                    cart.RemoveProduct(product);//call removeProduct class
                    Console.WriteLine("Product removed from cart.");
                    return;
                }//if end
            }//foreach end

            Console.WriteLine("Product not found in cart.");
        }//remove product method end

        //method to catch errors
        static string ReadLineWithRetry()
        {
            while (true)
            {
                try
                {
                    return Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    Console.WriteLine("Please try again.");
                }
            }
        }

    }//Program Class End
}//namespace end
