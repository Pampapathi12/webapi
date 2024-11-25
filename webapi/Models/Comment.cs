using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    public class Comment
    {
        public int? StockId { get; set; }

        // Navigation property to Stock
        public Stock? Stock { get; set; }
    }
}
