using System;
using System.Collections.Generic;
using policy_back.Models;

namespace policy_back.Interfaces
{
    public interface ICustomerActions
    { 
            List<Customer> GetAllCustomers();
            void AddCustomer(Customer customer);
    }
}
