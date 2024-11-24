using DocumentFormat.OpenXml.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Models
{
    public class Comments
    {

        public int? StockId { get; set; }
        // navigation property

        public Stock? Stock { get; set; }
    }
}
