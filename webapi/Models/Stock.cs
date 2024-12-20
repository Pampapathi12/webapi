﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Purchase { get; set; }  // Fixed typo

        [Column(TypeName = "decimal(18,2)")]
        public decimal LastDiv { get; set; }

        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }

        // Navigation property to Comment class
        public List<Comment> Comments { get; set; } = new List<Comment>();  // Fixed inconsistent naming
    }
}
