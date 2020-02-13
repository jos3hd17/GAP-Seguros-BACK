using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using policy_back.Data;
using policy_back.Models;

namespace policy_back.Controllers
{
    [Route("api/policies")]
    [ApiController]
    public class PoliciesController : ControllerBase
    {
        // GET: api/Policies
        [HttpGet]
        public List<Policy> Get()
        {
            PolicyRepo repo = new PolicyRepo();
            return repo.GetAllPolicy();
        }

        // GET: api/Policies/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Policies
        [HttpPost]
        public void Post([FromBody] Policy policy)
        {
            PolicyRepo repo = new PolicyRepo();
            repo.AddPolicy(policy);
        }

        // PUT: api/Policies/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
