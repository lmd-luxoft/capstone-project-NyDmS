using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeAccounting.BuisnessLogic.EF
{
    public class Wallet : Account
    {
        public int BanknotsAmount { get; set; }

        public int MonetsAmount { get; set; }
    }
}