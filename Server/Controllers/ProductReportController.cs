using System.Threading.Tasks;
using eShop.CoreBusiness.Features;
using eShop.CoreBusiness.Models;
using eShop.CoreBusiness.Reports;
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

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetDataAsync(Product reportParam)
        {
            var reporter = new ProductReportExcel(_reportData);
            var report = await reporter.GenerateReport(reportParam);
            var content = report.ToArray();
            var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            var filename = "Product Excel Report";

            return File(content, contentType, filename);
        }
    }
}