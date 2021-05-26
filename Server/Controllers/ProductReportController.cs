using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.CoreBusiness.Features;
using eShop.CoreBusiness.Models;
using eShop.CoreBusiness.Reports;
using eShop.CoreBusiness.Reports.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/v1/productreport")]
    public class ProductReportController : Controller
    {
        private IProductReportData _reportData;
        
        public ProductReportController(IProductReportData reportData)
        {
            _reportData = reportData;
        }
        
        // [HttpPost]
        // [Route("")]
        // public async Task<IActionResult> GetDataAsync([FromBody] List<Product> reportParams)
        // {
        //     var reporter = new ProductReportExcel(_reportData);
        //     var report =  reporter.GenerateReport(reportParams);
        //     var content = report.ToArray();
        //     const string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
        //     const string filename = "Product Excel Report";
        //     return File(content, contentType, filename);
        // }
        
        [HttpPost]
        [Route("export-to-excel/")]
        public async Task<IActionResult > ExportToExcel([FromBody] List<Product> reportParams)
        {
            var stream = await ProductReportExcel.ExportProductListToExcel(reportParams);
            string mimeType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            return new FileStreamResult(stream, mimeType)
            {
                FileDownloadName = "ProductList.xlsx"
            };
        }
    }
}