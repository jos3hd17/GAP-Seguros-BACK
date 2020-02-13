using System;
using policy_back.Interfaces;

namespace policy_back.Models
{
    public class Customer: Entity, ICustomer
    {
        public string ClientName { get ; set; }
        public string City { get; set; }
        public int RiskPercent { get; set; }

        public Customer()
        {
        }

      
    }
}
