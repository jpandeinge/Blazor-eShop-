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
        public static async Task<MemoryStream> ExportProductListToExcel(IEnumerable<Product> reportParams)
        {
            return ProductListExcelReport.GenerateExcel(reportParams);
        }
    }
}