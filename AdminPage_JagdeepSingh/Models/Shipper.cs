using AdminPage_JagdeepSingh.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPage_JagdeepSingh.Models
{
   public class Shipper: KeyAutoIncrement
    {
        public int ID { get; set; }
        [Display(Name = "Company Name")]
        [StringLength(100)]
        public string companyName { get; set; }
        [Display(Name = "Phone Number")]
        [Phone]
        public string phone { get; set; }

    }
}
