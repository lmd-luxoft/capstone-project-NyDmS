using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeAccounting.BuisnessLogic.EF
{
    [Table("ChangePrice")]
    public class ChangePrice
    {
        [Key]
        public int Id { get; set; }
        public DateTime ChangeDate { get; set; }
        public int ChangeVal { get; set; }
    }
}