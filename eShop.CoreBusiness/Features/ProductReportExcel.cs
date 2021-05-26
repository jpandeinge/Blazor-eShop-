using System.IO;
using System.Threading.Tasks;
using eShop.CoreBusiness.Models;
using eShop.CoreBusiness.Reports;

namespace eShop.CoreBusiness.Features
{
    public class ProductReportExcel
    {

        private readonly IProductReportData _reportData;
        
        public ProductReportExcel(IProductReportData reportData)
        {
            _reportData = reportData;   
        }

        public async Task<MemoryStream> GenerateReport(Product reportParams)
        {
            const string title = "Products Report";
            var results = await _reportData.GetReportData(reportParams);
            var writer = new ProductListExcelReportWriter();
            return await writer.GenerateExcel(results, title);
        }
    }
}