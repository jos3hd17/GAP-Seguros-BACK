using System;
using System.Collections.Generic;
using System.Linq;
using policy_back.Models;

namespace policy_back.Services
{
    public class CustomerService
    {
        private ApiContext _context;
        public CustomerService(ApiContext context)
        {
            _context = context;
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customer.Add(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customer
                 .Where(b => b.Id != 0)
                 .OrderBy(b => b.Id)
                 .ToList();
        }
    }
}
