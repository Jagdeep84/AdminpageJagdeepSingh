using AdminPage_JagdeepSingh.Interface;
using AdminPage_JagdeepSingh.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace AdminPage_JagdeepSingh.Models
{
    public class Product: KeyAutoIncrement
    {
        public int ID { get; set; }
        public Category category { get; set; }
        public Supplier supplier { get; set; }

        [Display(Name = "Product Name")]
        public string productName { get; set; }
        [Range(0, 999999.99)]
        public int quantityPerLabel { get; set; }
        [Display(Name = "Price")]
        [Range(0d, 999999.99d)]
        public decimal unitPrice { get; set; }
        [Display(Name = "Stock")]
        [Range(0, 999999.99)]
        public int unitsInStocks { get; set; }
        [Range(0, 999999.99)]
        public int unitsOnOrder { get; set; }
        [Range(0, 999999.99)]
        public int reorderLevel { get; set; }
        [Display(Name = "Discounted Price")]
        [Range(0d, 999999.99d)]
        public decimal dicounted { get; set; }
    }
}
