using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public class Library
    {
        public Product[] products = new Product[0] ;

        public void AddProduct(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
        }
        public Product[] GetProductsByPrice(double minPrice,double maxPrice)
        {

            Product[] filterPrice = new Product[0];

            foreach (var item in products)
            {
                if (item.Price>minPrice && item.Price<maxPrice)
                {
                    Array.Resize(ref filterPrice, filterPrice.Length + 1);
                    filterPrice[filterPrice.Length - 1] = item;
                }
            }

            return filterPrice;
        }
        public Product[] GetProductByName(string name)
        {
            Product[] filterByName = new Product[0];

            foreach (var item in products)
            {
                if (item.Name.Contains(name))
                {
                    Array.Resize(ref filterByName, filterByName.Length + 1);
                    filterByName[filterByName.Length - 1] = item;
                }
            }
            return filterByName;
        }
   
        
    }
}
