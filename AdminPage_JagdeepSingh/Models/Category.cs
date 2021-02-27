using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AdminPage_JagdeepSingh.Interface;

namespace AdminPage_JagdeepSingh.Models
{
    public class Category: KeyAutoIncrement
    {
        
        public int ID { get; set; }
        [Display(Name = "Category Name")]
        public string categoryName { get; set; }
        [Display(Name = "Description")]
        [StringLength(4000)]
        public string description { get; set; }
        
    }
}
