using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeAccounting.BuisnessLogic.EF
{
    public class Deposit : Account
    {
        public int Number { get; set; }
        public int Procent { get; set; }
        public string ProcentType { get; set; }

        public IEnumerable<Bank> banks { get; set; }
    }
}