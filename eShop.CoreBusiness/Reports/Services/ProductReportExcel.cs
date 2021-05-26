using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using eShop.CoreBusiness.Features;
using eShop.CoreBusiness.Models;
using eShop.CoreBusiness.Reports.Excel;

namespace eShop.CoreBusiness.Reports.Services
{
    public class ProductReportExcel
    {

        private readonly IProductReportData _reportData;
        
        public ProductReportExcel(IProductReportData reportData)
        {
            _reportData = reportData;   
        }

        // public byte[] GenerateReport(List<Product> reportParams)
        // {
        //     const string title = "Products Report";
        //     var writer = new ProductListExcelReport();
        //     return  ProductListExcelReport.GenerateExcel(reportParams, title);
        // }

        public static async Task<MemoryStream> ExportProductListToExcel(IEnumerable<Product> reportParams)
        {
            return ProductListExcelReport.GenerateExcel(reportParams);
        }
    }
}