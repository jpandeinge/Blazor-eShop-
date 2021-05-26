using System;
using System.Collections.Generic;

namespace eShop.CoreBusiness.Models
{
    public class ProductReportRequest
    {
        public IEnumerable<Guid> ProductIds { get; set; }
        public string Title { get; set; }
    }
}