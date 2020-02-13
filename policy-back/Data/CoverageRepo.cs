using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using policy_back.Interfaces;
using policy_back.Models;
using policy_back.Services;

namespace policy_back.Data
{
    public class CoverageRepo: Repository<Coverage>, ICoverageActions 
    {
        public CoverageRepo()
        {
        }

        public void AddCoverage(Coverage coverage)
        {
            var context = new DbContextOptionsBuilder<ApiContext>()
                       .UseInMemoryDatabase(databaseName: "root")
                       .Options;
            using (var cont = new ApiContext(context))
            {
                var service = new CoverageService(cont);
                service.AddCoverage(coverage);
                cont.SaveChanges();
            }
        }

        public List<Coverage> GetAllCoverage()
        {
            var context = new DbContextOptionsBuilder<ApiContext>()
                        .UseInMemoryDatabase(databaseName: "root")
                        .Options;
            using (var cont = new ApiContext(context))
            {
                var service = new CoverageService(cont).GetAllCoverage();
                cont.SaveChanges();
                return service;
            }

        }
    }
}
