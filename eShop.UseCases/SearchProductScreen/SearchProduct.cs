using System.Collections.Generic;
using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;

namespace eShop.UseCases.SearchProductScreen
{
    public class SearchProduct : ISearchProduct
    {
        private readonly IProductRepository _productRepository;

        public SearchProduct(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public  IEnumerable<Product> Execute(string filter = null)
        {
           return _productRepository.GetProducts(filter);
        }
    }
}