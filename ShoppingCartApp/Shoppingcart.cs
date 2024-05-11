using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    internal class Shoppingcart
    {
        private Product [] product;
        private int itemCount;

        //constructor
        public Shoppingcart(Product[] product, int itemCount)
        {
            this.product = product;
            this.itemCount = itemCount;
        }

        //getter methods for product[] and itemCount
        public Product[] Product
        {
            get { return product; }
        }

        public int ItemCount
        {
            get {return itemCount; }
        }
        
        public void AddProduct(Product newProduct)
        {
            if (itemCount < product.Length)
            {
                product[itemCount] = newProduct;
                itemCount++;
                Console.WriteLine("Product successfully added to shopping cart.");
            }
        }

        public void RemoveProduct(Product deleteProduct) 
        {
            bool found = false;
            for (int i = 0; i < itemCount; i++) 
            {
                if (product[i] == deleteProduct)
                {
                    for(int j = 0; j < itemCount - 1; j++)
                    {
                        product[j] = product[j+1];
                    }
                    itemCount--;
                    product[itemCount] = null;
                    found = true;
                    Console.WriteLine("Product successfully removed from shopping cart.");
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Product not found in shopping cart.");
            }
        }
    }
}
