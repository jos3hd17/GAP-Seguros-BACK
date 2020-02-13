using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using policy_back.Data;
using policy_back.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace policy_back.Controllers
{
    [Route("api/customer")]
    public class CustomerController : Controller
    {
        // GET: api/customer
        [HttpGet]
        public List<Customer> Get()
        {
            CustomerRepo repo = new CustomerRepo();
            return repo.GetAllCustomers();
        }

        // GET api/customer/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/customer
        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            CustomerRepo repo = new CustomerRepo();
            repo.AddCustomer(customer);
        }

        // PUT api/customer/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/customer/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
