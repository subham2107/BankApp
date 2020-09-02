using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingAppApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankingAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        // GET: api/<TransactionsController>
        private readonly BankingContext _context;
        public TransactionsController(BankingContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TransactionsController>/5
        [HttpGet("{id}/{fromDate}/{toDate}")]
        public IEnumerable <Transaction> Get(int id,DateTime fromDate,DateTime toDate)
        {
            IEnumerable<Transaction> transactions = _context.Transactions.ToList();
            transactions = from t in transactions where (t.FromAccount == id || t.ToAccount == id) && (t.DOT >= fromDate && t.DOT <= toDate) select t;
            return transactions;
        }

        // POST api/<TransactionsController>
        [HttpPost]
        public string Post([FromBody] Transaction transaction)
        {
             _context.Transactions.Add(transaction);
            _context.SaveChanges();
            return "Successful Transaction";
        }

        // PUT api/<TransactionsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TransactionsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
