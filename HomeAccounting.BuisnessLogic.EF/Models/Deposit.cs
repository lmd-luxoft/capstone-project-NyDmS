using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef
{
    public class Deposit : Account
    {
        public int Number { get; set; }
        public int Procent { get; set; }
        public string ProcentType { get; set; }
    }
}