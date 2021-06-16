using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HomeAccounting.BuisnessLogic.EF
{
    [Table("Account")]
    public class Bank
    {
        public int Id { get; set; }
        public int Bic { get; set; }
        public IEnumerable<Deposit> deposits { get; set; }

    }
}
