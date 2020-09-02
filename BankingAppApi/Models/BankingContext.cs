using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingAppApi.Models
{
    public class BankingContext:DbContext
    {
        public BankingContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Account>Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
