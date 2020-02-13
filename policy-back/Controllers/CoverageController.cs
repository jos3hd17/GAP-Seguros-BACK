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
    [Route("api/coverage")]
    public class CoverageController : Controller
    {
        // GET: api/coverage
        [HttpGet]
        public List<Coverage> Get()
        {
            CoverageRepo repo = new CoverageRepo();
            return repo.GetAllCoverage();
        }

        // GET api/coverage/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/coverage
        [HttpPost]
        public void Post([FromBody] Coverage coverage)
        {
            CoverageRepo repo = new CoverageRepo();
            repo.AddCoverage(coverage);
        }

        // PUT api/coverage/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/coverage/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
