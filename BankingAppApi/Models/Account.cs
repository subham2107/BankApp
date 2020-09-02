using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankingAppApi.Models
{
    public class Account
    {
        [Key]
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }

        public int Aadhar { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }

    }
}
