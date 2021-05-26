using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.CoreBusiness.Models;

namespace eShop.CoreBusiness.Features
{
    public class ProductReportData : IProductReportData
    {
        public async Task<IEnumerable<Product>> GetReportData(Product reportParams)
        {
            var productList = new List<Product>();
            
            return productList;
        }
    }
}