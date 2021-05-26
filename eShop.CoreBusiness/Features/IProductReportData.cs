using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.CoreBusiness.Models;

namespace eShop.CoreBusiness.Features
{
    public interface IProductReportData
    {
       public Task<IEnumerable<Product>> GetReportData(Product reportParams);
    }
}