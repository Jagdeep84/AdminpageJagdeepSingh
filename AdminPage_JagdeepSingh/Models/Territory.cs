using System;
using System.Collections.Generic;
using System.Text;
using AdminPage_JagdeepSingh.Interface;
using AdminPage_JagdeepSingh.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPage_JagdeepSingh.Models
{
   public class Territory: KeyAutoIncrement
    {
        public int ID { get; set; }
        public Region region { get; set; }
        [StringLength(4000)]
        public string territoryDescription { get; set; }
        public ICollection<Employee>Employees { get; set; }
    }
}
