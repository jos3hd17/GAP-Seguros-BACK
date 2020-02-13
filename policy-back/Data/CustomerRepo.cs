using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using policy_back.Interfaces;
using policy_back.Models;
using policy_back.Services;

namespace policy_back.Data
{
    public class CustomerRepo: Repository<Customer>, ICustomerActions 
    {
        public CustomerRepo()
        {
        }

        public void AddCustomer(Customer customer)
        {
            var context = new DbContextOptionsBuilder<ApiContext>()
                       .UseInMemoryDatabase(databaseName: "root")
                       .Options;
            using (var cont = new ApiContext(context))
            {
                var service = new CustomerService(cont);
                service.AddCustomer(customer);
                cont.SaveChanges();
            }
        }

        public List<Customer> GetAllCustomers()
        {
            var context = new DbContextOptionsBuilder<ApiContext>()
                        .UseInMemoryDatabase(databaseName: "root")
                        .Options;
            using (var cont = new ApiContext(context))
            {
                var service = new CustomerService(cont).GetAllCustomers();
                cont.SaveChanges();
                return service;
            }

        }
    }
}
