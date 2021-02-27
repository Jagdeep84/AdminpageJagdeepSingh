using AdminPage_JagdeepSingh.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AdminPage_JagdeepSingh.Models
{
   public class OrderDetail: KeyAutoIncrement
    {
        public int ID { get; set; }
        
        public Product product { get; set; }
        [Range(0d, 999999.99d)]
        public decimal unitPrice { get; set; }
        public int quantity { get; set; }
        [Range(0d, 999999.99d)]
        public decimal discount { get; set; }

    }
}
