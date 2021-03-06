﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models.Entities
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string ProductName { get; set; }
        [Required]
        
        public string ProductBarcode { get; set; }
        [Required]
        public int ProductStock { get; set; }

        [Required]
        public decimal ProductPurchasingPrice { get; set; } 
        [Required]
        public decimal ProductSellingPrice { get; set; }
        public int CategoryId { get; set; }
        
       


        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }


        public virtual ICollection<Package> Packages { get; set; } = new HashSet<Package>();

        public virtual ICollection<SaleDetail> SaleDetails { get; set; } = new HashSet<SaleDetail>();


        public override string ToString()
        {
            return $"{ProductName}";
        }

    }
}
