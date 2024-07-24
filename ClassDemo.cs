using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Full_Course
{
    internal class PrivateKeyWord
    {
        static void Main(string[] args)
        {
            Product Mobile = new Product();

            // Setting properties
            Mobile.ProductID = 1;
            Mobile.ProductName = "Mobile";
            Mobile.MRP = 500;
            Mobile.MakeBy = "Company A";
            Mobile.Stock = 100;
            Mobile.DiscPer = 10;

            // Calculating and displaying discounted price
            Mobile.CalculateDiscountedPrice();
            Console.WriteLine("Product ID: " + Mobile.ProductID);
            Console.WriteLine("Product Name: " + Mobile.ProductName);
            Console.WriteLine("MRP: " + Mobile.MRP);
            Console.WriteLine("Make By: " + Mobile.MakeBy);
            Console.WriteLine("Stock: " + Mobile.Stock);
            Console.WriteLine("Discount Percentage: " + Mobile.DiscPer + "%");
            Console.WriteLine("Discounted Price: " + Mobile.DiscountedPrice);
        }
    }

    class Product
    {
        private int productID;
        private string productName;
        private int mrp;
        private string makeBy;
        private int stock;
        private int discPer;
        private int discountedPrice;

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public int MRP
        {
            get { return mrp; }
            set { mrp = value; }
        }
        public string MakeBy
        {
            get { return makeBy; }
            set { makeBy = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public int DiscPer
        {
            get { return discPer; }
            set { discPer = value; }
        }
        public int DiscountedPrice
        {
            get { return discountedPrice; }
        }

        public void CalculateDiscountedPrice()
        {
            discountedPrice = mrp - (mrp * discPer / 100);
        }
    }
}