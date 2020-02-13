using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using policy_back.Interfaces;
using policy_back.Models;
using policy_back.Services;

namespace policy_back.Data
{
    public class PolicyRepo: Repository<Policy>, IPolicyActions
    {
        
        public PolicyRepo()
        {
            
        }

        public void AddPolicy(Policy policy)
        {
            var context = new DbContextOptionsBuilder<ApiContext>()
                       .UseInMemoryDatabase(databaseName: "root")
                       .Options;
            using (var cont = new ApiContext(context))
            {
                var service = new PolicyService(cont);
                service.AddPolicy(policy);
                cont.SaveChanges();
            }
        }

        public List<Policy> GetAllPolicy()
        {
            var context = new DbContextOptionsBuilder<ApiContext>()
                        .UseInMemoryDatabase(databaseName: "root")
                        .Options;
            using (var cont = new ApiContext(context))
            {
                var service = new PolicyService(cont).GetAllPolicy();
                cont.SaveChanges();
                return service;
            }
            
        }
    }
}
