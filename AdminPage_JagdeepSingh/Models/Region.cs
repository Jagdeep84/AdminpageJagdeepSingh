using AdminPage_JagdeepSingh.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPage_JagdeepSingh.Models
{
   public class Region: KeyAutoIncrement
    {
        public int ID { get; set; }
        [StringLength(4000)]
        public string regionDescription { get; set; }
    }
}
