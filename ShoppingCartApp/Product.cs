using ShoppingCartApp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShoppingCartApp
{
    public class Product
    {
        //instantiate fields
        public String name { get; set; }
        protected double price { get; set; }
        protected ProductCategory category { get; set; }

        //constructor
        public Product(string name, double price, ProductCategory category)
        {
            this.name = name;
            this.price = price;
            this.category = category;
        }

        //getInfo() to return data
        public virtual string getInfo()
        {
            string productInfo = "Product Name: " + name + "\nProduct Price: R" + price + "\nProduct Category: " + category;
            return productInfo;
        }
    }
}

//child class ClothingProduct for Product
class ClothingProduct : Product
{
    //instantiate variables
    private String size { get; set; }
    private String color { get; set; }

    //constructor
    public ClothingProduct(string name, double price, ProductCategory category, String size, String color) : base(name, price, category)
    {
        this.size = size;
        this.color = color;
    }

    //overrride method for getInfo()
    public override string getInfo()
    {
        string productInfo = "Product Name: " + base.name + "\nProduct Price: R" + base.price + "\nProduct Category: " + base.category + "\nProduct Size: " + size + "\nProduct Color: " + color;
        return productInfo;
    }
}

//child class ElectronicProduct for Product
class ElectronicProduct : Product
{
    //instantiate variables
    private String brand { get; set; }
    private String model { get; set; }

    //constructor
    public ElectronicProduct(string name, double price, ProductCategory category, String brand, String model) : base(name, price, category)
    {
        this.brand = brand;
        this.model = model;
    }

    //overrride method for getInfo()
    public override string getInfo()
    {
        string productInfo = "Product Name: " + base.name + "\nProduct Price: R" + base.price + "\nProduct Category: " + base.category + "\nProduct Brand: " + brand + "\nProduct Model: " + model;
        return productInfo;
    }
}
