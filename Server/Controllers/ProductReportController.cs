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
    [Route("api/v1/product-report")]
    public class ProductReportController : Controller
    {
        
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