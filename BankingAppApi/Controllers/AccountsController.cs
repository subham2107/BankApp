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
    public class AccountsController : ControllerBase
    {
        // GET: api/<AccountsController>
        private readonly BankingContext _context;
        public AccountsController(BankingContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Account> Get()
        {
            return _context.Accounts.ToList();
        }

        // GET api/<AccountsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AccountsController>
        [HttpPost]
        public string Post([FromBody] Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
            return "Success";
        }

        // PUT api/<AccountsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AccountsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
