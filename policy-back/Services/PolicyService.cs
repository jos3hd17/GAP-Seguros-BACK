using System;
using System.Collections.Generic;
using System.Linq;
using policy_back.Models;


namespace policy_back.Services
{
    public class PolicyService
    {
        private ApiContext _context;
        public PolicyService(ApiContext context)
        {
            _context = context;
        }

        public void AddPolicy(Policy policy)
        {
            _context.Policy.Add(policy);
        }

        public List<Policy> GetAllPolicy()
        {
            return _context.Policy
                 .Where(b => b.Id != 0)
                 .OrderBy(b => b.Id)
                 .ToList();
        }
    }
}
