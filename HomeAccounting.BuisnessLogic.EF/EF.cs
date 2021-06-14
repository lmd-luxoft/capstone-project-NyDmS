using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace HomeAccounting.BuisnessLogic.EF
{
    public class EF : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<Estate> Estates { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<ChangePrice> ChangePrices { get; set; }

        public EF()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=-;Database=helloEF;Trusted_Connection=True;");
        }
    }
}
