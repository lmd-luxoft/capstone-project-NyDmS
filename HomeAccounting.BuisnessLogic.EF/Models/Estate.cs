using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeAccounting.BuisnessLogic.EF
{
    public class Estate : Account
    {
        public decimal BaseCost { get; set; }

        public string Location { get; set; }

        public string Type { get; set; }

        public ChangePrice ChangePrice { get; set; }
    }
}