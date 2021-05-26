using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DocumentFormat.OpenXml.Wordprocessing;
using eShop.CoreBusiness.Models;
using eShop.DataStore.HardCoded;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MudBlazor;

namespace Server.Pages.SearchProducts
{
    [Route("api/v1/products/search/")]
    public partial class SearchProducts : ComponentBase
    {
        public IEnumerable<Product> pageData;
        public MudTable<Product> table;

        private List<Product> Products = new();


        private int totalItems;
        private string searchString = null;
        [Inject] private IJSRuntime _jsRuntime { get; set; }

        public  async Task<TableData<Product>> ServerReload(TableState state)
        {
            // string uri = $"api/v1/products/search/products";

            // IEnumerable<Product> data = await httpClient.GetFromJsonAsync<List<Product>>(uri);
            var data = ProductRepository.GetProducts("");
            data = data.Where(product =>
            {
                if (string.IsNullOrWhiteSpace(searchString))
                {
                    return true;
                }

                if (product.Brand.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }

                if (product.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }

                if ($"{product.Price}".Contains(searchString))
                {
                    return true;
                }

                return false;
            }).ToArray();

            totalItems = data.Count();
            switch (state.SortLabel)
            {
                case "name_field":
                    data = data.OrderByDirection(state.SortDirection, o => o.Name);
                    break;

                case "brand_field":
                    data = data.OrderByDirection(state.SortDirection, o => o.Brand);
                    break;
                case "price_field":
                    data = data.OrderByDirection(state.SortDirection, o => o.Price);
                    break;
            }

            pageData = data.Skip(state.Page * state.PageSize).Take(state.PageSize).ToArray();
            return new TableData<Product>() {TotalItems = totalItems, Items = pageData};
        }

        public void OnSearch(string text)
        {
            searchString = text;
            table.ReloadServerData();
        }

        
        public async Task ExportExcel()
        {
            var products = Products.Select(p=>p.Id);
            var request =  new ProductReportRequest()
            {
                ProductIds = products,
                Title = "title"
            };
            
            var fileName = "Product Report";
            var resultBytes = await eShop.CoreBusiness.Features.ProductReportData.GetExcelReport(request);
            
            await _jsRuntime.InvokeVoidAsync(
                "Window.downloadFromByteArray",
                new
                {
                    ByteArray = resultBytes,
                    FileName = fileName,
                    ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
                });
        }
    }
}