using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using ClosedXML.Excel;
using eShop.CoreBusiness.Models;

namespace eShop.CoreBusiness.Reports
{
    public class ProductListExcelReportWriter
    {
        public async Task<MemoryStream> GenerateExcel(IEnumerable<Product> productList, string title)
        {
            // initiate the workbook from ClosedXML 
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add(title);
            
            // add title to first column and cell
            worksheet.Cell(1, 1).Value = title;
            
            // column header
            worksheet.Range(1, 1, 1, 3).Merge();
            
            // column names
            worksheet.Cell(3, 1).Value = "Product Name";
            worksheet.Cell(3, 2).Value = "Brand";
            worksheet.Cell(3, 3).Value = "Price";
            
            // workbook formatting
            var titlesStyle = workbook.Style;
            titlesStyle.Font.Bold = true; // column fonts set to bold
            titlesStyle.Border.OutsideBorder = XLBorderStyleValues.Medium; // border style  
            titlesStyle.Border.OutsideBorderColor = XLColor.Black; // border color 
            titlesStyle.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; // alignment of column values 
            
            // format all titles at once
            worksheet.Range(3, 1, 3, 9).Style = titlesStyle;

            var row = 4;
            var col = 1;

            foreach (var product in productList)
            {
                worksheet.Cell(row, col).Value = product.Name;
                col++;
                worksheet.Cell(row, col).Value = product.Brand;
                col++;
                worksheet.Cell(row, col).Value = product.Price;
                col = 1;
                row++;
            }

            worksheet.Columns().AdjustToContents(); // auto adjust cell to content

            // initiate memory stream and save workbook in the memory stream
            var memoryStream = new MemoryStream();
            workbook.SaveAs(memoryStream);
            memoryStream.Seek(0L, SeekOrigin.Begin);
            
            // // convert memory stream to array
            // var content = memoryStream.ToArray();
            // memoryStream.Close(); // close the memory stream
            return memoryStream; // return byte content
        }
    }
}