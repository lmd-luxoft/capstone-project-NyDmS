using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef
{
    public class Wallet : Account
    {
        public int BanknotsAmount { get; set; }

        public int MonetsAmount { get; set; }
    }
}