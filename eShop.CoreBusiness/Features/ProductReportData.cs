using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using eShop.CoreBusiness.Models;

namespace eShop.CoreBusiness.Features
{
    public class ProductReportData 
    {
        private static HttpClient _httpClient;
        public ProductReportData(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public static async Task<byte[]> GetExcelReport(ProductReportRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/v1/productreport", request);
            var stream = await response.Content.ReadAsStreamAsync();
            await using var memoryStream = new MemoryStream();
            await stream.CopyToAsync(memoryStream);
            await stream.DisposeAsync();
            return memoryStream.ToArray();
        }
    }
}