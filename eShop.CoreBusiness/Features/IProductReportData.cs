using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.CoreBusiness.Models;

namespace eShop.CoreBusiness.Features
{
    public interface IProductReportData
    {
        Task<byte[]> GetExcelReport(ProductReportRequest request);
        
    }
}