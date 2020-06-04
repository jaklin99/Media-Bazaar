using Org.BouncyCastle.Crypto.Macs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjectMB
{
    public static class Products
    {
        public static List<Product> products = new List<Product>();
        public delegate void productStatus(Product product);
        public static event productStatus productAdded;
        public static event productStatus productChanged;
        public static event productStatus productRemoved;

        public static Product FindProduct(string name)
        {
            foreach (var item in products)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }

        public static Product FindProduct(int id)
        {
            foreach (var item in products)
            {
                if (item.id == id)
                {
                    return item;
                }
            }
            return null;
        }
        public static Product[] FindProducts(ProductCategory category)
        {
            List<Product> products = new List<Product>();
            foreach (var item in Products.products)
            {
                if (item.Category == category)
                {
                    products.Add(item);
                }
            }
            return products.ToArray();
        }

        public static bool AddProduct(Product product)
        {
            DatabaseFunctions.AddProduct(product);
            products.Add(product);
            productAdded?.Invoke(product);
            return true;
        }
        public static bool UpdateProduct(Product product)
        {
            DatabaseFunctions.UpdateProduct(product);
            DatabaseFunctions.GetAllProducts();
            productChanged?.Invoke(product);
            return true;

        }
        public static bool RemoveProduct(Product product)
        {
            DatabaseFunctions.RemoveProduct(product);
            DatabaseFunctions.GetAllProducts();
            productRemoved(product);
            return true;
        }
    }
}
