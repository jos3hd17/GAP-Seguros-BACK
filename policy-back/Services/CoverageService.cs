using System;
using System.Collections.Generic;
using System.Linq;
using policy_back.Models;

namespace policy_back.Services
{
    public class CoverageService
    {
        private ApiContext _context;
        public CoverageService(ApiContext context)
        {
            _context = context;
        }

        public void AddCoverage(Coverage coverage)
        {
            _context.Coverage.Add(coverage);
        }

        public List<Coverage> GetAllCoverage()
        {
            return _context.Coverage
                 .Where(b => b.Id != 0)
                 .OrderBy(b => b.Id)
                 .ToList();
        }
    }
}
