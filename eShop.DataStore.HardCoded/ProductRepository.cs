using System;
using System.Collections.Generic;
using System.Linq;
using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;

namespace eShop.DataStore.HardCoded
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products;

        public ProductRepository()
        {
            new Product{ Id = 0030, Brand = "Vinatge", Name = "Vintage Blouse", Price = 100.00, ImageLink = "images/IMG-20200914-WA0030.jpg" };
            new Product{ Id = 0031, Brand = "Vinatge", Name = "Vintage Blouse", Price = 100.00, ImageLink = "images/IMG-20200914-WA0031.jpg" };
            new Product{ Id = 0032, Brand = "Vinatge", Name = "Vintage Blouse", Price = 100.00, ImageLink = "images/IMG-20200914-WA0032.jpg" };
            new Product{ Id = 0033, Brand = "Vinatge", Name = "Vintage Blouse", Price = 100.00, ImageLink = "images/IMG-20200914-WA0033.jpg" };
            new Product{ Id = 0034, Brand = "Vinatge", Name = "Vintage Blouse", Price = 100.00, ImageLink = "images/IMG-20200914-WA0034.jpg" };
            new Product{ Id = 0035, Brand = "Vinatge", Name = "Vintage Blouse", Price = 100.00, ImageLink = "images/IMG-20200914-WA0035.jpg" };
            
        }

        public Product GetProduct(int id)
        {
            return products.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> GetProducts(string filter = null)
        {
            if (string.IsNullOrWhiteSpace(filter))
            {
                return products;
            }

            return products.Where(x => x.Name.ToLower().Contains(filter.ToLower()));
        }
    }
}