namespace ShoppingCartApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates instances of products
            Console.WriteLine("Enter the name of the clothing product:");
            string clothingName = Console.ReadLine();

            Console.WriteLine("Enter the price of the clothing product:");
            double clothingPrice;
            while (!double.TryParse(Console.ReadLine(), out clothingPrice))
            {
                Console.WriteLine("Invalid input. Please enter a valid price:");
            }

            Console.WriteLine("Enter the size of the clothing product:");
            string clothingSize = Console.ReadLine();

            Console.WriteLine("Enter the color of the clothing product:");
            string clothingColor = Console.ReadLine();

            Product clothingProduct = new ClothingProduct(clothingName, clothingPrice, ProductCategory.Clothing, clothingSize, clothingColor);

            Console.WriteLine("Enter the name of the electronic product:");
            string electronicName = Console.ReadLine();

            Console.WriteLine("Enter the price of the electronic product:");
            double electronicPrice;
            while (!double.TryParse(Console.ReadLine(), out electronicPrice))
            {
                Console.WriteLine("Invalid input. Please enter a valid price:");
            }

            Console.WriteLine("Enter the brand of the electronic product:");
            string electronicBrand = Console.ReadLine();

            Console.WriteLine("Enter the model of the electronic product:");
            string electronicModel = Console.ReadLine();

            Product electronicProduct = new ElectronicProduct(electronicName, electronicPrice, ProductCategory.Electronics, electronicBrand, electronicModel);

            // Creates an array of products
            Product[] products = new Product[] { clothingProduct, electronicProduct };

            // Creates an instance of ShoppingCart
            Shoppingcart cart = new Shoppingcart(products, products.Length);

            // Adds products to the shopping cart
            cart.AddProduct(clothingProduct);
            cart.AddProduct(electronicProduct);

            Console.WriteLine("\n\nContents of the shopping cart:");
            foreach (Product product in cart.Product)
            {
                if (product != null)
                {
                    Console.WriteLine(product.getInfo());
                    Console.WriteLine("-----------------------------");
                }
            }
            Console.WriteLine("Enter the name of the product you want to remove:");
            string productNameToRemove = Console.ReadLine();
            bool productRemoved = false;
            foreach (Product product in cart.Product)
            {
                if (product != null && product.name.Equals(productNameToRemove, StringComparison.OrdinalIgnoreCase))
                {
                    cart.RemoveProduct(product);
                    productRemoved = true;
                    break;
                }
            }
            if (!productRemoved)
            {
                Console.WriteLine("Product not found in shopping cart.");
            }

            Console.WriteLine("\n\nUpdated contents of the shopping cart:");
            foreach (Product product in cart.Product)
            {
                if (product != null)
                {
                    Console.WriteLine(product.getInfo());
                    Console.WriteLine("-----------------------------");
                }
            }
        }
    }
}